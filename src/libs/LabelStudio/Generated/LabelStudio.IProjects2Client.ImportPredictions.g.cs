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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsImportPredictionsCreateResponse> ImportPredictionsAsync(
            int id,

            global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}