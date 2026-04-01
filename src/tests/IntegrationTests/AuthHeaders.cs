namespace LabelStudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void UsesBearerAuthorizationForPersonalAccessTokens()
    {
        using var client = new LabelStudioClient(apiKey: "header.payload.signature");

        client.HttpClient.DefaultRequestHeaders.Authorization.Should().BeNull();
        client.Authorizations.Should().ContainSingle().Which.Should().BeEquivalentTo(new global::LabelStudio.EndPointAuthorization
        {
            Type = "Http",
            Location = "Header",
            Name = "Bearer",
            Value = "header.payload.signature",
        });
    }

    [TestMethod]
    public void UsesTokenAuthorizationForLegacyTokens()
    {
        using var client = new LabelStudioClient(apiKey: "legacy-token");

        client.HttpClient.DefaultRequestHeaders.Authorization.Should().NotBeNull();
        client.HttpClient.DefaultRequestHeaders.Authorization!.Scheme.Should().Be("Token");
        client.HttpClient.DefaultRequestHeaders.Authorization.Parameter.Should().Be("legacy-token");
        client.Authorizations.Should().BeEmpty();
    }
}
