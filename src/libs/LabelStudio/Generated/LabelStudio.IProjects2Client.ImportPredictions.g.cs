#nullable enable

namespace LabelStudio
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Import predictions<br/>
        /// Import model predictions for tasks in the specified project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsImportPredictionsCreateResponse> ImportPredictionsAsync(
            int id,

            global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest> request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}