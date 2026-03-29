#nullable enable

namespace LabelStudio;

public partial class LabelStudioClient
{
    partial void Authorized(
        global::System.Net.Http.HttpClient client)
    {
        // Label Studio uses "Token <key>" prefix instead of "Bearer <key>".
        // Set auth on DefaultRequestHeaders so all sub-clients inherit it,
        // and clear Authorizations to prevent per-request Bearer override.
        var bearer = Authorizations.Find(a => a is { Type: "Http", Name: "Bearer" });
        if (bearer?.Value is { } apiKey)
        {
            client.DefaultRequestHeaders.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue("Token", apiKey);
            Authorizations.Clear();
        }
    }
}
