#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization members list<br/>
        /// Retrieve a list of the organization members and their IDs.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedLseOrganizationMemberListList> List3Async(
            int id,
            bool? contributedToProjects = default,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<string>? role = default,
            string? search = default,
            global::System.Collections.Generic.IList<int>? tags = default,
            global::System.DateTime? userLastActivityGte = default,
            global::System.DateTime? userLastActivityLte = default,
            global::System.Collections.Generic.IList<string>? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization members list<br/>
        /// Retrieve a list of the organization members and their IDs.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLseOrganizationMemberListList>> List3AsResponseAsync(
            int id,
            bool? contributedToProjects = default,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            bool? isDeleted = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<string>? role = default,
            string? search = default,
            global::System.Collections.Generic.IList<int>? tags = default,
            global::System.DateTime? userLastActivityGte = default,
            global::System.DateTime? userLastActivityLte = default,
            global::System.Collections.Generic.IList<string>? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}