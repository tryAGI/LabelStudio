#nullable enable

namespace LabelStudio
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all dataset storages types<br/>
        /// Retrieve a list of the dataset storages types.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesTypesRetrieveAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}