#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Get all import storage<br/>
        /// Get a list of all Azure import storage connections.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.AzureDatasetStorage>> ApiDatasetStoragesAzureListAsync(
            int? dataset = default,
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}