#nullable enable

namespace LabelStudio
{
    public partial interface IPredictions2Client
    {
        /// <summary>
        /// Create prediction<br/>
        /// Create a prediction for a specific task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Prediction> CreateAsync(

            global::LabelStudio.PredictionRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prediction<br/>
        /// Create a prediction for a specific task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.Prediction>> CreateAsResponseAsync(

            global::LabelStudio.PredictionRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prediction<br/>
        /// Create a prediction for a specific task.
        /// </summary>
        /// <param name="cluster">
        /// Cluster for the current prediction
        /// </param>
        /// <param name="mislabeling">
        /// Related task mislabeling score
        /// </param>
        /// <param name="model">
        /// An ML Backend instance that created the prediction.
        /// </param>
        /// <param name="modelRun">
        /// A run of a ModelVersion that created the prediction.
        /// </param>
        /// <param name="modelVersion">
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface
        /// </param>
        /// <param name="neighbors">
        /// Array of task IDs of the closest neighbors
        /// </param>
        /// <param name="project"></param>
        /// <param name="result">
        /// List of prediction results for the task
        /// </param>
        /// <param name="score">
        /// Prediction score
        /// </param>
        /// <param name="task"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Prediction> CreateAsync(
            global::System.Collections.Generic.IList<object> result,
            int task,
            int? cluster = default,
            double? mislabeling = default,
            int? model = default,
            int? modelRun = default,
            string? modelVersion = default,
            object? neighbors = default,
            int? project = default,
            double? score = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}