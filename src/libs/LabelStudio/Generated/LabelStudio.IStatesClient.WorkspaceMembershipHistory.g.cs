#nullable enable

namespace LabelStudio
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// Get workspace membership history<br/>
        /// Read-only state history for workspace memberships (admin/owner of the workspace organization only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedStateModelList> WorkspaceMembershipHistoryAsync(
            int workspaceId,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            int? userId = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace membership history<br/>
        /// Read-only state history for workspace memberships (admin/owner of the workspace organization only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedStateModelList>> WorkspaceMembershipHistoryAsResponseAsync(
            int workspaceId,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            int? userId = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}