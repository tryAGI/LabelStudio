using System.Net;
using System.Text;
using System.Text.Json;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace LabelStudio.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string LabelStudioImage = "heartexlabs/label-studio:latest";
    private const ushort LabelStudioPort = 8080;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(3);

    public IContainer? Container { get; init; }
    public required LabelStudioClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var apiKey =
                    System.Environment.GetEnvironmentVariable("LABEL_STUDIO_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
                    System.Environment.GetEnvironmentVariable("LABELSTUDIO_API_KEY") is { Length: > 0 } altKeyValue ? altKeyValue :
                    throw new AssertInconclusiveException("LABEL_STUDIO_API_KEY environment variable is not found.");

                var baseUrl =
                    System.Environment.GetEnvironmentVariable("LABEL_STUDIO_BASE_URL") is { Length: > 0 } baseUrlValue
                        ? baseUrlValue
                        : $"http://127.0.0.1:{LabelStudioPort}";

                var client = new LabelStudioClient(apiKey, baseUri: new Uri(baseUrl));

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                const string email = "test@test.com";
                const string password = "testpassword123";

                var container = new ContainerBuilder(LabelStudioImage)
                    .WithPortBinding(LabelStudioPort, assignRandomHostPort: true)
                    .WithEnvironment("LABEL_STUDIO_USERNAME", email)
                    .WithEnvironment("LABEL_STUDIO_PASSWORD", password)
                    .WithEnvironment("LABEL_STUDIO_DISABLE_SIGNUP_WITHOUT_LINK", "true")
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/user/login")
                                .ForPort(LabelStudioPort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var baseUri = new UriBuilder(
                    Uri.UriSchemeHttp,
                    container.Hostname,
                    container.GetMappedPublicPort(LabelStudioPort)).Uri;

                // Login to get session cookie, then retrieve an API token.
                // Prefer a personal access token because legacy tokens may be
                // disabled at the organization level.
                var apiToken = await GetApiTokenAsync(baseUri, email, password);

                var client = new LabelStudioClient(apiToken, baseUri: baseUri);

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static async Task<string> GetApiTokenAsync(Uri baseUri, string email, string password)
    {
        var cookieContainer = new CookieContainer();
        using var handler = new HttpClientHandler { CookieContainer = cookieContainer };
        using var httpClient = new HttpClient(handler) { BaseAddress = baseUri };

        // GET /user/login to get CSRF token cookie
        await httpClient.GetAsync("/user/login");
        var csrfToken = cookieContainer.GetCookies(baseUri)["csrftoken"]?.Value ?? "";

        // POST /user/login with credentials
        var loginContent = new FormUrlEncodedContent(
        [
            new KeyValuePair<string, string>("email", email),
            new KeyValuePair<string, string>("password", password),
            new KeyValuePair<string, string>("csrfmiddlewaretoken", csrfToken),
        ]);
        httpClient.DefaultRequestHeaders.Add("Referer", baseUri.ToString());
        await httpClient.PostAsync("/user/login", loginContent);

        var personalAccessToken = await TryCreatePersonalAccessTokenAsync(httpClient, cookieContainer, baseUri);
        if (!string.IsNullOrWhiteSpace(personalAccessToken))
        {
            return personalAccessToken;
        }

        // Fallback for older Label Studio versions that only expose the legacy token endpoint.
        var tokenResponse = await httpClient.GetAsync("/api/current-user/token");
        tokenResponse.EnsureSuccessStatusCode();
        var tokenJson = await tokenResponse.Content.ReadAsStringAsync();
        return ExtractToken(tokenJson)
               ?? throw new InvalidOperationException("Failed to get API token from Label Studio container.");
    }

    private static async Task<string?> TryCreatePersonalAccessTokenAsync(
        HttpClient httpClient,
        CookieContainer cookieContainer,
        Uri baseUri)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, "/api/token/")
        {
            Content = new StringContent("{}", Encoding.UTF8, "application/json"),
        };
        request.Headers.TryAddWithoutValidation("Referer", baseUri.ToString());

        var csrfToken = cookieContainer.GetCookies(baseUri)["csrftoken"]?.Value;
        if (!string.IsNullOrWhiteSpace(csrfToken))
        {
            request.Headers.TryAddWithoutValidation("X-CSRFToken", csrfToken);
        }

        using var response = await httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var content = await response.Content.ReadAsStringAsync();
        var refreshToken = ExtractToken(content);
        if (string.IsNullOrWhiteSpace(refreshToken))
        {
            return null;
        }

        return await TryExchangeRefreshTokenAsync(httpClient, refreshToken) ?? refreshToken;
    }

    private static async Task<string?> TryExchangeRefreshTokenAsync(HttpClient httpClient, string refreshToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, "/api/token/refresh/")
        {
            Content = new StringContent(
                JsonSerializer.Serialize(new Dictionary<string, string>
                {
                    ["refresh"] = refreshToken,
                }),
                Encoding.UTF8,
                "application/json"),
        };

        using var response = await httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var content = await response.Content.ReadAsStringAsync();
        using var tokenDoc = JsonDocument.Parse(content);
        return tokenDoc.RootElement.TryGetProperty("access", out var accessElement)
            ? accessElement.GetString()
            : null;
    }

    private static string? ExtractToken(string content)
    {
        using var tokenDoc = JsonDocument.Parse(content);
        var root = tokenDoc.RootElement;

        if (root.TryGetProperty("token", out var tokenElement))
        {
            return tokenElement.GetString();
        }

        if (root.TryGetProperty("detail", out var detailElement))
        {
            var detail = detailElement.GetString();
            if (!string.IsNullOrWhiteSpace(detail))
            {
                var parts = detail.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var tokenIndex = Array.IndexOf(parts, "Token");
                if (tokenIndex >= 0 && tokenIndex + 1 < parts.Length)
                {
                    return parts[tokenIndex + 1];
                }
            }
        }

        return null;
    }

    private static EnvironmentType InferEnvironment()
    {
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
