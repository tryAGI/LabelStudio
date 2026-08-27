#nullable enable

namespace LabelStudio
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Update ML Backend<br/>
        ///     Update ML backend parameters using the Label Studio UI or by sending a PATCH request using the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X PATCH -H 'Content-type: application/json' http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9091"}' <br/>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.MLBackend> UpdateAsync(
            int id,

            global::LabelStudio.PatchedMLBackendRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update ML Backend<br/>
        ///     Update ML backend parameters using the Label Studio UI or by sending a PATCH request using the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X PATCH -H 'Content-type: application/json' http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9091"}' <br/>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.MLBackend>> UpdateAsResponseAsync(
            int id,

            global::LabelStudio.PatchedMLBackendRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update ML Backend<br/>
        ///     Update ML backend parameters using the Label Studio UI or by sending a PATCH request using the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X PATCH -H 'Content-type: application/json' http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9091"}' <br/>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authMethod">
        /// * `NONE` - None<br/>
        /// * `BASIC_AUTH` - Basic Auth
        /// </param>
        /// <param name="autoUpdate">
        /// If false, model version is set by the user, if true - getting latest version from backend.
        /// </param>
        /// <param name="basicAuthPass">
        /// Included only in requests
        /// </param>
        /// <param name="basicAuthUser">
        /// HTTP Basic Auth user
        /// </param>
        /// <param name="description">
        /// Description for the machine learning backend
        /// </param>
        /// <param name="extraParams">
        /// Any extra parameters passed to the ML Backend during the setup
        /// </param>
        /// <param name="isInteractive">
        /// Used to interactively annotate tasks. If true, model returns one list with results
        /// </param>
        /// <param name="modelVersion">
        /// Current model version associated with this machine learning backend
        /// </param>
        /// <param name="project"></param>
        /// <param name="timeout">
        /// Response model timeout
        /// </param>
        /// <param name="title">
        /// Name of the machine learning backend
        /// </param>
        /// <param name="url">
        /// URL for the machine learning model server
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.MLBackend> UpdateAsync(
            int id,
            global::LabelStudio.AuthMethodEnum? authMethod = default,
            bool? autoUpdate = default,
            string? basicAuthPass = default,
            string? basicAuthUser = default,
            string? description = default,
            object? extraParams = default,
            bool? isInteractive = default,
            string? modelVersion = default,
            int? project = default,
            double? timeout = default,
            string? title = default,
            string? url = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}