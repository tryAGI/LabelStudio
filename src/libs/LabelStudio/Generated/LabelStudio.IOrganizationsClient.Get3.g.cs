#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization member details<br/>
        /// Get organization member details by user ID.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="id"></param>
        /// <param name="userPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.OrganizationMember> Get3Async(
            int id,
            int userPk,
            bool? contributedToProjects = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization member details<br/>
        /// Get organization member details by user ID.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="id"></param>
        /// <param name="userPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.OrganizationMember>> Get3AsResponseAsync(
            int id,
            int userPk,
            bool? contributedToProjects = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}