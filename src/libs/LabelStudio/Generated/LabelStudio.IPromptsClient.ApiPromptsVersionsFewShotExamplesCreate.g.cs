#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Create a few-shot example<br/>
        /// CRUD API for managing few-shot examples on a ThirdPartyModelVersion.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.FewShotExample> ApiPromptsVersionsFewShotExamplesCreateAsync(
            int promptId,
            int versionId,

            global::LabelStudio.FewShotExampleRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Create a few-shot example<br/>
        /// CRUD API for managing few-shot examples on a ThirdPartyModelVersion.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.FewShotExample>> ApiPromptsVersionsFewShotExamplesCreateAsResponseAsync(
            int promptId,
            int versionId,

            global::LabelStudio.FewShotExampleRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Create a few-shot example<br/>
        /// CRUD API for managing few-shot examples on a ThirdPartyModelVersion.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="annotation"></param>
        /// <param name="order"></param>
        /// <param name="task"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.FewShotExample> ApiPromptsVersionsFewShotExamplesCreateAsync(
            int promptId,
            int versionId,
            int annotation,
            int task,
            int? order = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}