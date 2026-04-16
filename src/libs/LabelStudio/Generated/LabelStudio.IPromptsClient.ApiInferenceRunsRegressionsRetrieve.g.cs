#nullable enable

namespace LabelStudio
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Compare correctness transitions between inference runs<br/>
        /// Compare correctness transitions between two inference runs.<br/>
        /// Classifies each task as regression, improvement, stable_correct,<br/>
        /// stable_incorrect, new, or removed based on prediction scores.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiInferenceRunsRegressionsRetrieveAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}