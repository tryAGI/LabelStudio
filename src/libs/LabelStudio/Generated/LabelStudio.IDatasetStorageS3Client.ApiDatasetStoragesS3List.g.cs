#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetStorageS3Client
    {
        /// <summary>
        /// Get all import storage<br/>
        /// Get a list of all S3 import storage connections.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>> ApiDatasetStoragesS3ListAsync(
            int? dataset = default,
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all import storage<br/>
        /// Get a list of all S3 import storage connections.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>>> ApiDatasetStoragesS3ListAsResponseAsync(
            int? dataset = default,
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}