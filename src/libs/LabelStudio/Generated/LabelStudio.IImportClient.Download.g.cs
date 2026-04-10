#nullable enable

namespace LabelStudio
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download a specific uploaded file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadAsync(
            string filename,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}