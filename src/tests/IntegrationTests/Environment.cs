using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace LabelStudio.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string LabelStudioImage = "heartexlabs/label-studio:latest";
    private const ushort LabelStudioPort = 8080;
    private const string ContainerApiToken = "testtoken1234567890";
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
                var container = new ContainerBuilder(LabelStudioImage)
                    .WithPortBinding(LabelStudioPort, assignRandomHostPort: true)
                    .WithEnvironment("LABEL_STUDIO_USERNAME", "test@test.com")
                    .WithEnvironment("LABEL_STUDIO_PASSWORD", "testpassword123")
                    .WithEnvironment("LABEL_STUDIO_USER_TOKEN", ContainerApiToken)
                    .WithEnvironment("LABEL_STUDIO_DISABLE_SIGNUP_WITHOUT_LINK", "true")
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/user/login")
                                .ForPort(LabelStudioPort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var client = new LabelStudioClient(
                    ContainerApiToken,
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(LabelStudioPort)).Uri);

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
