#nullable enable

namespace LabelStudio;

public partial class LabelStudioClient
{
    private static bool LooksLikePersonalAccessToken(string apiKey)
    {
        return apiKey.Count(c => c == '.') == 2;
    }

    partial void Authorized(
        global::System.Net.Http.HttpClient client)
    {
        var bearer = Authorizations.Find(a => a is { Type: "Http", Name: "Bearer" });
        if (bearer?.Value is { } apiKey)
        {
            if (LooksLikePersonalAccessToken(apiKey))
            {
                return;
            }

            // Legacy Label Studio tokens still use "Token <key>" while
            // personal access tokens use standard bearer auth.
            client.DefaultRequestHeaders.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue("Token", apiKey);
            Authorizations.Clear();
        }
    }
}
