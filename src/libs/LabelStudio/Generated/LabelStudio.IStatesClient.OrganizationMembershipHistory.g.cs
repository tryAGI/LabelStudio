#nullable enable

namespace LabelStudio
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// Get organization membership history<br/>
        /// Read-only state history for organization memberships, scoped to the active organization (admin/owner only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="source"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedStateModelList> OrganizationMembershipHistoryAsync(
            int orgId,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListSource? source = default,
            global::System.DateTime? until = default,
            int? userId = default,
            global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListUserType? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization membership history<br/>
        /// Read-only state history for organization memberships, scoped to the active organization (admin/owner only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="source"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedStateModelList>> OrganizationMembershipHistoryAsResponseAsync(
            int orgId,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListSource? source = default,
            global::System.DateTime? until = default,
            int? userId = default,
            global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListUserType? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}