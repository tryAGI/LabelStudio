namespace LabelStudio.IntegrationTests;

/// <summary>
/// Probes for response fields this spec declares <c>required</c> while also giving them a
/// <c>default</c>.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a field the service omits turns a
/// successful HTTP 200 into a <c>JsonException</c> - and a documented default is the spec saying the
/// producer may omit it. Anthropic's spec had `caller` in exactly this shape and never sends it, so
/// every response that used a server tool failed to deserialize while nothing exercised those
/// surfaces live.
///
/// Reaching the typed response at all is the whole point, so asserting that it came back non-null is
/// enough. Both calls are read-only and need no fixture.
/// `scripts/audit_response_required_defaults.py --endpoints` in the workspace lists the rest; this
/// SDK's remaining candidates hang off a project, prompt or annotation id.
/// </remarks>
public partial class Tests
{
    [TestMethod]
    public async Task CurrentUserResponseDeserializes()
    {
        // LseUserAPI.initials
        var user = await Client.Users.GetCurrentUserAsync();

        user.Should().NotBeNull();
    }

    [TestMethod]
    public async Task WhoAmIResponseDeserializes()
    {
        // WhoAmIUser.initials
        var user = await Client.Users.WhoamiAsync();

        user.Should().NotBeNull();
    }
}
