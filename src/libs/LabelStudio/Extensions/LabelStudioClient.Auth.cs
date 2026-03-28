#nullable enable

namespace LabelStudio;

public partial class LabelStudioClient
{
#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        // Label Studio uses "Token <key>" prefix instead of "Bearer <key>"
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue("Token", apiKey);
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
