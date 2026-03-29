#nullable enable

namespace LabelStudio
{
    public partial interface IVersionsClient
    {
        /// <summary>
        /// Get version information<br/>
        /// Get version information about the Label Studio instance.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.VersionResponse> GetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}