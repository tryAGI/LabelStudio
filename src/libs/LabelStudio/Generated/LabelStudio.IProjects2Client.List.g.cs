#nullable enable

namespace LabelStudio
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// List projects<br/>
        /// Retrieve a list of projects. Counter fields in each result follow one of two scopes:<br/>
        /// * **Per-user progress** — computed for the authenticated user and their project role (for example `reviewed_number`, `review_total_tasks`, `queue_done`, `queue_total`, `queue_left`). These power project-card progress in the UI and differ across users. Note: `queue_left` counts manual review assignments only; when it is `0`, the card uses `review_total_tasks` / `reviewed_number` for auto-review progress.<br/>
        /// * **Project-wide totals** — the same for every caller (for example `task_number`, `finished_task_number`).<br/>
        /// For organization-level reviewed-task totals (all reviewers combined), use `GET /api/analytics/kpis/tasks_reviewed?projects={id}&amp;tz=UTC` rather than `reviewed_number`. See Analytics KPI `tasks_reviewed`, `tasks_pending_review`, `annotated_tasks`, and `total_tasks` for other project-wide metrics.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sourceInterfaceId"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedAllRolesProjectListList> ListAsync(
            bool? archived = default,
            string? filter = default,
            string? ids = default,
            string? include = default,
            int? membersLimit = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            double? sourceInterfaceId = default,
            string? state = default,
            string? title = default,
            double? workspaces = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List projects<br/>
        /// Retrieve a list of projects. Counter fields in each result follow one of two scopes:<br/>
        /// * **Per-user progress** — computed for the authenticated user and their project role (for example `reviewed_number`, `review_total_tasks`, `queue_done`, `queue_total`, `queue_left`). These power project-card progress in the UI and differ across users. Note: `queue_left` counts manual review assignments only; when it is `0`, the card uses `review_total_tasks` / `reviewed_number` for auto-review progress.<br/>
        /// * **Project-wide totals** — the same for every caller (for example `task_number`, `finished_task_number`).<br/>
        /// For organization-level reviewed-task totals (all reviewers combined), use `GET /api/analytics/kpis/tasks_reviewed?projects={id}&amp;tz=UTC` rather than `reviewed_number`. See Analytics KPI `tasks_reviewed`, `tasks_pending_review`, `annotated_tasks`, and `total_tasks` for other project-wide metrics.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sourceInterfaceId"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedAllRolesProjectListList>> ListAsResponseAsync(
            bool? archived = default,
            string? filter = default,
            string? ids = default,
            string? include = default,
            int? membersLimit = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            double? sourceInterfaceId = default,
            string? state = default,
            string? title = default,
            double? workspaces = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}