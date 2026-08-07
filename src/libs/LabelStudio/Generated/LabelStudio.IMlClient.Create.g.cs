#nullable enable

namespace LabelStudio
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Add ML Backend<br/>
        ///     Add an ML backend to a project using the Label Studio UI or by sending a POST request using the following cURL <br/>
        ///     command:<br/>
        ///     ```bash<br/>
        ///     curl -X POST -H 'Content-type: application/json' http://localhost:8000/api/ml -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9090", "project": {project_id}}' <br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.MLBackend> CreateAsync(

            global::LabelStudio.MLBackendRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add ML Backend<br/>
        ///     Add an ML backend to a project using the Label Studio UI or by sending a POST request using the following cURL <br/>
        ///     command:<br/>
        ///     ```bash<br/>
        ///     curl -X POST -H 'Content-type: application/json' http://localhost:8000/api/ml -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9090", "project": {project_id}}' <br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.MLBackend>> CreateAsResponseAsync(

            global::LabelStudio.MLBackendRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add ML Backend<br/>
        ///     Add an ML backend to a project using the Label Studio UI or by sending a POST request using the following cURL <br/>
        ///     command:<br/>
        ///     ```bash<br/>
        ///     curl -X POST -H 'Content-type: application/json' http://localhost:8000/api/ml -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9090", "project": {project_id}}' <br/>
        ///     
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::LabelStudio.MLBackend> CreateAsync(
            string? basicAuthPass,
            int project,
            string url,
            global::LabelStudio.AuthMethodEnum? authMethod = default,
            bool? autoUpdate = default,
            string? basicAuthUser = default,
            string? description = default,
            object? extraParams = default,
            bool? isInteractive = default,
            string? modelVersion = default,
            double? timeout = default,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}