#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List organization member membership filter options<br/>
        /// Return the actor-accessible workspaces, each with its projects, plus unparented projects.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>> ApiOrganizationsMembershipsFilterOptionsMembershipListAsync(
            int id,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization member membership filter options<br/>
        /// Return the actor-accessible workspaces, each with its projects, plus unparented projects.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>>> ApiOrganizationsMembershipsFilterOptionsMembershipListAsResponseAsync(
            int id,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}