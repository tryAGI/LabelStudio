#nullable enable

namespace LabelStudio
{
    public partial interface IBackgroundJobsClient
    {
        /// <summary>
        /// List organization background jobs<br/>
        /// Bounded, cursor-paginated list of background jobs for the active organization, sourced from the FIT-2919 per-organization indexes. Internal only.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="id"></param>
        /// <param name="jobFunction"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.JobsListResponse> ApiOrganizationsJobsListAsync(
            int id,
            global::LabelStudio.ApiOrganizationsJobsListStatus status,
            string? cursor = default,
            string? jobFunction = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization background jobs<br/>
        /// Bounded, cursor-paginated list of background jobs for the active organization, sourced from the FIT-2919 per-organization indexes. Internal only.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="id"></param>
        /// <param name="jobFunction"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.JobsListResponse>> ApiOrganizationsJobsListAsResponseAsync(
            int id,
            global::LabelStudio.ApiOrganizationsJobsListStatus status,
            string? cursor = default,
            string? jobFunction = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}