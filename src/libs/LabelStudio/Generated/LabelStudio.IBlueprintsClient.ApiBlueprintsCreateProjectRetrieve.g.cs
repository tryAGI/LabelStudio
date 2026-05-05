#nullable enable

namespace LabelStudio
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Create project from blueprint<br/>
        /// Create a new project from an existing blueprint. On success, user is redirected to the new project with a 302.
        /// </summary>
        /// <param name="shareId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiBlueprintsCreateProjectRetrieveAsync(
            string shareId,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project from blueprint<br/>
        /// Create a new project from an existing blueprint. On success, user is redirected to the new project with a 302.
        /// </summary>
        /// <param name="shareId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> ApiBlueprintsCreateProjectRetrieveAsResponseAsync(
            string shareId,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}