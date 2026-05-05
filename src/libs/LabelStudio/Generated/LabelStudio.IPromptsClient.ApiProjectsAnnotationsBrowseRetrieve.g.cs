#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Browse annotations for few-shot examples<br/>
        /// Lightweight annotations list for few-shot example browser.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiProjectsAnnotationsBrowseRetrieveAsync(
            int projectPk,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Browse annotations for few-shot examples<br/>
        /// Lightweight annotations list for few-shot example browser.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> ApiProjectsAnnotationsBrowseRetrieveAsResponseAsync(
            int projectPk,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}