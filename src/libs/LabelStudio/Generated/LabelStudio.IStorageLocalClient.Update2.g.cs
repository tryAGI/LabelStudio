#nullable enable

namespace LabelStudio
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Update import storage<br/>
        /// Update a specific local file import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LocalFilesImportStorage> Update2Async(
            int id,

            global::LabelStudio.PatchedLocalFilesImportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update import storage<br/>
        /// Update a specific local file import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LocalFilesImportStorage>> Update2AsResponseAsync(
            int id,

            global::LabelStudio.PatchedLocalFilesImportStorageWriteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update import storage<br/>
        /// Update a specific local file import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="path">
        /// Local path
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="recursiveScan">
        /// Perform recursive scan over the directory content
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
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
        global::System.Threading.Tasks.Task<global::LabelStudio.LocalFilesImportStorage> Update2Async(
            int id,
            string? description = default,
            string? path = default,
            int? project = default,
            bool? recursiveScan = default,
            string? regexFilter = default,
            bool? synchronizable = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}