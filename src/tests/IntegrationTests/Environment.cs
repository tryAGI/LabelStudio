using System.Net;
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

                // Login to get session cookie, then retrieve the API token
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

        // GET /api/current-user/token to retrieve the API token
        var tokenResponse = await httpClient.GetAsync("/api/current-user/token");
        tokenResponse.EnsureSuccessStatusCode();
        var tokenJson = await tokenResponse.Content.ReadAsStringAsync();

        // Response is {"token":"<value>"}
        var tokenDoc = System.Text.Json.JsonDocument.Parse(tokenJson);
        return tokenDoc.RootElement.GetProperty("token").GetString()
               ?? throw new InvalidOperationException("Failed to get API token from Label Studio container.");
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
