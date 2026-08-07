#nullable enable

namespace LabelStudio
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Validate export storage<br/>
        /// Validate a specific Azure export storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task Validate2Async(

            global::LabelStudio.AzureBlobExportStorageValidateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate export storage<br/>
        /// Validate a specific Azure export storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> Validate2AsResponseAsync(

            global::LabelStudio.AzureBlobExportStorageValidateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate export storage<br/>
        /// Validate a specific Azure export storage connection.
        /// </summary>
        /// <param name="accountKey">
        /// Azure Blob account key
        /// </param>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="container">
        /// Azure blob container
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="prefix">
        /// Azure blob prefix name
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
        global::System.Threading.Tasks.Task Validate2Async(
            int project,
            string? accountKey = default,
            string? accountName = default,
            bool? canDeleteObjects = default,
            string? container = default,
            string? description = default,
            int? id = default,
            string? prefix = default,
            string? regexFilter = default,
            bool? synchronizable = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}