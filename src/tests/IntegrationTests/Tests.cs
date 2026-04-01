namespace LabelStudio.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Environment? _environment;

    public static LabelStudioClient Client => _environment?.Client
        ?? throw new AssertInconclusiveException("LABEL_STUDIO_API_KEY environment variable is not found.");

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        try
        {
            _environment = await Environment.PrepareAsync();
        }
        catch (AssertInconclusiveException)
        {
            _environment = null;
        }
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
        if (_environment is not null)
        {
            await _environment.DisposeAsync();
        }
    }
}
