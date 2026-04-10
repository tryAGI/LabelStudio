#nullable enable

namespace LabelStudio
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Get project by ID<br/>
        /// Retrieve information about a project by project ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseProjectResponse> GetAsync(
            int id,
            int? membersLimit = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}