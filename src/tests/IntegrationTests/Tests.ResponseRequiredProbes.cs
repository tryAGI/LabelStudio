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
        // LseUserAPI.initials - `Lse` is Label Studio Enterprise: the community edition answers
        // this route with a 404, so the probe can only settle the schema against an Enterprise
        // instance. Caught by status rather than by `NotFoundException`, which the generated
        // operations never throw: they throw its `NotFoundException<T>` variant, an unrelated type.
        LseUserAPI user;
        try
        {
            user = await Client.Users.GetCurrentUserAsync();
        }
        catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("/api/current-user is Enterprise-only; this instance is community.");
            return;
        }

        user.Should().NotBeNull();
    }

    [TestMethod]
    public async Task PredictionsResponseDeserializes()
    {
        // Prediction.created_ago - an empty list still proves the element type deserializes when
        // the instance has predictions, and a non-empty one proves it outright.
        var predictions = await Client.Predictions2.ListAsync();

        predictions.Should().NotBeNull();
    }

    /// <summary>
    /// `TaskSimple.annotations` / `.predictions` sit behind a project id, so this one needs a
    /// fixture - which means creating something, and cleaning it up even when the assertion fails.
    /// </summary>
    [TestMethod]
    public async Task ProjectTasksResponseDeserializes()
    {
        // Named so a leaked project is obviously a test's, and unique so parallel runs don't collide.
        var project = await Client.Projects2.CreateAsync(new LseProjectCreateRequest
        {
            Title = $"tryagi-probe-{Guid.NewGuid():N}",
        });

        try
        {
            // This route is Enterprise-only too, so on community the probe can only prove that the
            // project round-trip itself deserializes - which is already worth having: it is how the
            // two response-shape bugs in `generate.sh` were found.
            try
            {
                var tasks = await Client.Projects.ApiProjectsTasksListAsync(id: project.Id);

                tasks.Should().NotBeNull();
            }
            catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Assert.Inconclusive("/api/projects/{id}/tasks/ is Enterprise-only; this instance is community.");
            }
        }
        finally
        {
            // Swallow only the cleanup's own failure: the verdict belongs to the assertion above.
            try
            {
                await Client.Projects2.DeleteAsync(id: project.Id);
            }
            catch (ApiException)
            {
            }
        }
    }

    [TestMethod]
    public async Task WhoAmIResponseDeserializes()
    {
        // WhoAmIUser.initials
        var user = await Client.Users.WhoamiAsync();

        user.Should().NotBeNull();
    }
}
