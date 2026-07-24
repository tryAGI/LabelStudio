#nullable enable

namespace LabelStudio
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// Get organization IdP group assignment history<br/>
        /// Read-only state history for IdP group assignments, scoped to the active organization (admin/owner only).
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="kind"></param>
        /// <param name="ordering"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedStateModelList> OrganizationIdpAssignmentsHistoryAsync(
            int orgId,
            string? groupName = default,
            global::LabelStudio.ApiFsmOrganizationsIdpAssignmentsHistoryListKind? kind = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization IdP group assignment history<br/>
        /// Read-only state history for IdP group assignments, scoped to the active organization (admin/owner only).
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="kind"></param>
        /// <param name="ordering"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedStateModelList>> OrganizationIdpAssignmentsHistoryAsResponseAsync(
            int orgId,
            string? groupName = default,
            global::LabelStudio.ApiFsmOrganizationsIdpAssignmentsHistoryListKind? kind = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}