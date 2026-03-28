namespace LabelStudio.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LabelStudioClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LABEL_STUDIO_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("LABELSTUDIO_API_KEY") is { Length: > 0 } altKeyValue ? altKeyValue :
            throw new AssertInconclusiveException("LABEL_STUDIO_API_KEY environment variable is not found.");

        var baseUrl =
            Environment.GetEnvironmentVariable("LABEL_STUDIO_BASE_URL") is { Length: > 0 } baseUrlValue
                ? baseUrlValue
                : LabelStudioClient.DefaultBaseUrl;

        var client = new LabelStudioClient(
            apiKey,
            baseUri: new Uri(baseUrl));

        return client;
    }
}
