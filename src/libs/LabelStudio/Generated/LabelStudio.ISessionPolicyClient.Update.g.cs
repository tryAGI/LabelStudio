#nullable enable

namespace LabelStudio
{
    public partial interface ISessionPolicyClient
    {
        /// <summary>
        /// Update Session Policy<br/>
        /// Update session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.SessionTimeoutPolicy> UpdateAsync(

            global::LabelStudio.PatchedSessionTimeoutPolicyRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session Policy<br/>
        /// Update session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="maxSessionAge">
        /// Number of minutes that a session can be active before needing to re-login
        /// </param>
        /// <param name="maxTimeBetweenActivity">
        /// Number of minutes that a session stays active without any activity
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.SessionTimeoutPolicy> UpdateAsync(
            int? maxSessionAge = default,
            int? maxTimeBetweenActivity = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}