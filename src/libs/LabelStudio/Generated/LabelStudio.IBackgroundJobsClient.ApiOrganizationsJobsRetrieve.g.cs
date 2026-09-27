#nullable enable

namespace LabelStudio
{
    public partial interface IBackgroundJobsClient
    {
        /// <summary>
        /// Get organization background job detail<br/>
        /// Detail for a single active-organization background job. Failed jobs include redacted exception info (class, message, last 8 repo-relative frames — never args/kwargs). Internal only.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.JobDetail> ApiOrganizationsJobsRetrieveAsync(
            int id,
            string jobId,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization background job detail<br/>
        /// Detail for a single active-organization background job. Failed jobs include redacted exception info (class, message, last 8 repo-relative frames — never args/kwargs). Internal only.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.JobDetail>> ApiOrganizationsJobsRetrieveAsResponseAsync(
            int id,
            string jobId,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}