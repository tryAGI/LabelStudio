#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Bulk fetch indicators for inference runs<br/>
        /// Bulk fetch default indicators for multiple inference runs at once.<br/>
        /// Returns aggregated metrics for up to 20 completed runs in a single request,<br/>
        /// used by the Comparison Matrix to show all versions side by side.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiInferenceRunsBulkIndicatorsRetrieveAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Bulk fetch indicators for inference runs<br/>
        /// Bulk fetch default indicators for multiple inference runs at once.<br/>
        /// Returns aggregated metrics for up to 20 completed runs in a single request,<br/>
        /// used by the Comparison Matrix to show all versions side by side.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> ApiInferenceRunsBulkIndicatorsRetrieveAsResponseAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}