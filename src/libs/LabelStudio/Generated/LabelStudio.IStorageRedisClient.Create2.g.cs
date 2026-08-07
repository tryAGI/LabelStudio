#nullable enable

namespace LabelStudio
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Create import storage<br/>
        /// Create a new Redis import storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RedisImportStorage> Create2Async(

            global::LabelStudio.RedisImportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create import storage<br/>
        /// Create a new Redis import storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.RedisImportStorage>> Create2AsResponseAsync(

            global::LabelStudio.RedisImportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create import storage<br/>
        /// Create a new Redis import storage connection.
        /// </summary>
        /// <param name="db">
        /// Server Database
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="host">
        /// Server Host IP (optional)
        /// </param>
        /// <param name="password">
        /// Server Password (optional)
        /// </param>
        /// <param name="path">
        /// Storage prefix (optional)
        /// </param>
        /// <param name="port">
        /// Server Port (optional)
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RedisImportStorage> Create2Async(
            int project,
            int? db = default,
            string? description = default,
            string? host = default,
            string? password = default,
            string? path = default,
            string? port = default,
            string? regexFilter = default,
            bool? synchronizable = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}