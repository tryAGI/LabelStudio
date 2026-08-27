#nullable enable

namespace LabelStudio
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Export candidate tasks to project<br/>
        ///     Export Candidate task for a specific dataset to project.<br/>
        ///
        /// </summary>
        /// <param name="additionalFilters"></param>
        /// <param name="dataset"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DatasetImportCandidatesResponse> ApiDatasetsImportCreateAsync(

            global::LabelStudio.DatasetImportCandidatesCreateRequest request,
            object? additionalFilters = default,
            int? dataset = default,
            object? excluded = default,
            object? included = default,
            int? project = default,
            int? view = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export candidate tasks to project<br/>
        ///     Export Candidate task for a specific dataset to project.<br/>
        ///
        /// </summary>
        /// <param name="additionalFilters"></param>
        /// <param name="dataset"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.DatasetImportCandidatesResponse>> ApiDatasetsImportCreateAsResponseAsync(

            global::LabelStudio.DatasetImportCandidatesCreateRequest request,
            object? additionalFilters = default,
            int? dataset = default,
            object? excluded = default,
            object? included = default,
            int? project = default,
            int? view = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export candidate tasks to project<br/>
        ///     Export Candidate task for a specific dataset to project.<br/>
        ///
        /// </summary>
        /// <param name="additionalFilters"></param>
        /// <param name="dataset"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="requestAdditionalFilters">
        /// Default Value: {}
        /// </param>
        /// <param name="requestDataset"></param>
        /// <param name="requestExcluded">
        /// Default Value: {}
        /// </param>
        /// <param name="requestIncluded">
        /// Default Value: {}
        /// </param>
        /// <param name="requestProject"></param>
        /// <param name="requestView"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DatasetImportCandidatesResponse> ApiDatasetsImportCreateAsync(
            int requestDataset,
            object? additionalFilters = default,
            int? dataset = default,
            object? excluded = default,
            object? included = default,
            int? project = default,
            int? view = default,
            object? requestAdditionalFilters = default,
            object? requestExcluded = default,
            object? requestIncluded = default,
            int? requestProject = default,
            int? requestView = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}