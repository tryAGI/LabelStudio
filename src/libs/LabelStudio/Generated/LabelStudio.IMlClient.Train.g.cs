#nullable enable

namespace LabelStudio
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Train<br/>
        ///         After you add an ML backend, call this API with the ML backend ID to start training with <br/>
        ///         already-labeled tasks. <br/>
        ///         <br/>
        ///         Get the ML backend ID by [listing the ML backends for a project](api:GET/api/ml/).<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task TrainAsync(
            int id,

            global::LabelStudio.MLBackendTrainRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train<br/>
        ///         After you add an ML backend, call this API with the ML backend ID to start training with <br/>
        ///         already-labeled tasks. <br/>
        ///         <br/>
        ///         Get the ML backend ID by [listing the ML backends for a project](api:GET/api/ml/).<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> TrainAsResponseAsync(
            int id,

            global::LabelStudio.MLBackendTrainRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train<br/>
        ///         After you add an ML backend, call this API with the ML backend ID to start training with <br/>
        ///         already-labeled tasks. <br/>
        ///         <br/>
        ///         Get the ML backend ID by [listing the ML backends for a project](api:GET/api/ml/).<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="useGroundTruth">
        /// Whether to include ground truth annotations in training<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task TrainAsync(
            int id,
            bool? useGroundTruth = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}