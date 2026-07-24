#nullable enable

namespace LabelStudio
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// Get project membership history<br/>
        /// Read-only state history for project memberships (admin/owner of the project organization only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedStateModelList> ProjectMembershipHistoryAsync(
            int projectId,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            int? userId = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get project membership history<br/>
        /// Read-only state history for project memberships (admin/owner of the project organization only).
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedStateModelList>> ProjectMembershipHistoryAsResponseAsync(
            int projectId,
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