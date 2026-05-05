#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Dataset> ApiDatasetsCreateAsync(

            global::LabelStudio.DatasetRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.Dataset>> ApiDatasetsCreateAsResponseAsync(

            global::LabelStudio.DatasetRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="columns">
        /// All data columns found in Dataset tasks
        /// </param>
        /// <param name="createdBy">
        /// User who created Dataset
        /// </param>
        /// <param name="description">
        /// Dataset description
        /// </param>
        /// <param name="organization"></param>
        /// <param name="title">
        /// Dataset title
        /// </param>
        /// <param name="totalEntities"></param>
        /// <param name="vectorDbDatasetName">
        /// Dataset name for weaviate schema
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Dataset> ApiDatasetsCreateAsync(
            string title,
            object? columns = default,
            global::LabelStudio.UserSimpleRequest? createdBy = default,
            string? description = default,
            int? organization = default,
            int? totalEntities = default,
            string? vectorDbDatasetName = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}