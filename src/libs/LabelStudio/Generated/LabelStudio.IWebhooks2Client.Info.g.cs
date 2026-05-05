#nullable enable

namespace LabelStudio
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// Get all webhook actions<br/>
        /// Get descriptions of all available webhook actions to set up webhooks.
        /// </summary>
        /// <param name="organizationOnly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiWebhooksInfoRetrieveResponse> InfoAsync(
            bool? organizationOnly = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all webhook actions<br/>
        /// Get descriptions of all available webhook actions to set up webhooks.
        /// </summary>
        /// <param name="organizationOnly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ApiWebhooksInfoRetrieveResponse>> InfoAsResponseAsync(
            bool? organizationOnly = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}