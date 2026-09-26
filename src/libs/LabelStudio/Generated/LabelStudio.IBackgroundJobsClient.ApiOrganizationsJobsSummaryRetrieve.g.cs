#nullable enable

namespace LabelStudio
{
    public partial interface IBackgroundJobsClient
    {
        /// <summary>
        /// Get organization background job summary<br/>
        /// Running/waiting/failed-24h counts and per-queue quota usage for the active organization, sourced from the FIT-2919 per-organization indexes. No per-project breakdown. Internal only.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.JobsSummary> ApiOrganizationsJobsSummaryRetrieveAsync(
            int id,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization background job summary<br/>
        /// Running/waiting/failed-24h counts and per-queue quota usage for the active organization, sourced from the FIT-2919 per-organization indexes. No per-project breakdown. Internal only.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.JobsSummary>> ApiOrganizationsJobsSummaryRetrieveAsResponseAsync(
            int id,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}