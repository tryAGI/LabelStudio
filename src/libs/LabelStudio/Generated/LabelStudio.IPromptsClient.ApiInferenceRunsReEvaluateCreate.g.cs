#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Re-evaluate specific tasks from a previous run<br/>
        /// Create a new inference run targeting only specific tasks (re-evaluation).<br/>
        /// Supports four modes:<br/>
        /// - custom: provide explicit task_ids<br/>
        /// - failed: re-run tasks with failed predictions from a source run<br/>
        /// - incorrect: re-run tasks with score &lt; 1.0 from a source run<br/>
        /// - regressions: re-run tasks that regressed between two runs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ReEvaluate> ApiInferenceRunsReEvaluateCreateAsync(

            global::LabelStudio.ReEvaluateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Re-evaluate specific tasks from a previous run<br/>
        /// Create a new inference run targeting only specific tasks (re-evaluation).<br/>
        /// Supports four modes:<br/>
        /// - custom: provide explicit task_ids<br/>
        /// - failed: re-run tasks with failed predictions from a source run<br/>
        /// - incorrect: re-run tasks with score &lt; 1.0 from a source run<br/>
        /// - regressions: re-run tasks that regressed between two runs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ReEvaluate>> ApiInferenceRunsReEvaluateCreateAsResponseAsync(

            global::LabelStudio.ReEvaluateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Re-evaluate specific tasks from a previous run<br/>
        /// Create a new inference run targeting only specific tasks (re-evaluation).<br/>
        /// Supports four modes:<br/>
        /// - custom: provide explicit task_ids<br/>
        /// - failed: re-run tasks with failed predictions from a source run<br/>
        /// - incorrect: re-run tasks with score &lt; 1.0 from a source run<br/>
        /// - regressions: re-run tasks that regressed between two runs
        /// </summary>
        /// <param name="mode">
        /// * `failed` - failed<br/>
        /// * `incorrect` - incorrect<br/>
        /// * `regressions` - regressions<br/>
        /// * `custom` - custom
        /// </param>
        /// <param name="modelVersionId"></param>
        /// <param name="runBId"></param>
        /// <param name="sourceModelRunId"></param>
        /// <param name="taskIds">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ReEvaluate> ApiInferenceRunsReEvaluateCreateAsync(
            global::LabelStudio.ReEvaluateModeEnum mode,
            int modelVersionId,
            int? runBId = default,
            int? sourceModelRunId = default,
            global::System.Collections.Generic.IList<int>? taskIds = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}