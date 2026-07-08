#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Try prompt on a single task<br/>
        /// Run a single-task ephemeral prediction using the current (possibly unsaved) prompt.<br/>
        /// No ModelRun is created and no Prediction is stored. The user iterates<br/>
        /// until happy, then saves and does a full Run.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TryTaskResponse> ApiPromptsVersionsTryTaskCreateAsync(
            int promptId,
            int versionId,

            global::LabelStudio.TryTaskRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Try prompt on a single task<br/>
        /// Run a single-task ephemeral prediction using the current (possibly unsaved) prompt.<br/>
        /// No ModelRun is created and no Prediction is stored. The user iterates<br/>
        /// until happy, then saves and does a full Run.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.TryTaskResponse>> ApiPromptsVersionsTryTaskCreateAsResponseAsync(
            int promptId,
            int versionId,

            global::LabelStudio.TryTaskRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Try prompt on a single task<br/>
        /// Run a single-task ephemeral prediction using the current (possibly unsaved) prompt.<br/>
        /// No ModelRun is created and no Prediction is stored. The user iterates<br/>
        /// until happy, then saves and does a full Run.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="projectId"></param>
        /// <param name="promptOverride"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TryTaskResponse> ApiPromptsVersionsTryTaskCreateAsync(
            int promptId,
            int versionId,
            int projectId,
            int taskId,
            string? promptOverride = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}