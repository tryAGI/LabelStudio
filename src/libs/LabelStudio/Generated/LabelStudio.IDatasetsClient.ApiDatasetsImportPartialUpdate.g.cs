#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Export candidate tasks to project<br/>
        /// Export Candidate task for a specific dataset to project.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DatasetImportCandidatesResponse> ApiDatasetsImportPartialUpdateAsync(

            global::LabelStudio.PatchedDatasetImportCandidatesPatchRequest request,
            int? jobId = default,
            string? signal = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export candidate tasks to project<br/>
        /// Export Candidate task for a specific dataset to project.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.DatasetImportCandidatesResponse>> ApiDatasetsImportPartialUpdateAsResponseAsync(

            global::LabelStudio.PatchedDatasetImportCandidatesPatchRequest request,
            int? jobId = default,
            string? signal = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export candidate tasks to project<br/>
        /// Export Candidate task for a specific dataset to project.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal"></param>
        /// <param name="requestJobId"></param>
        /// <param name="requestSignal">
        /// Operation type.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DatasetImportCandidatesResponse> ApiDatasetsImportPartialUpdateAsync(
            int? jobId = default,
            string? signal = default,
            int? requestJobId = default,
            string? requestSignal = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}