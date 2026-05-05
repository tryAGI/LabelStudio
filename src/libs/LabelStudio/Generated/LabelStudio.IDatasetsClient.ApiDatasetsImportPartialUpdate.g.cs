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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsImportPartialUpdateAsync(
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> ApiDatasetsImportPartialUpdateAsResponseAsync(
            int? jobId = default,
            string? signal = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}