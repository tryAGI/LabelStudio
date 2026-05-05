#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ List few-shot examples<br/>
        /// CRUD API for managing few-shot examples on a ThirdPartyModelVersion.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>> ApiPromptsVersionsFewShotExamplesListAsync(
            int promptId,
            int versionId,
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ List few-shot examples<br/>
        /// CRUD API for managing few-shot examples on a ThirdPartyModelVersion.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>>> ApiPromptsVersionsFewShotExamplesListAsResponseAsync(
            int promptId,
            int versionId,
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}