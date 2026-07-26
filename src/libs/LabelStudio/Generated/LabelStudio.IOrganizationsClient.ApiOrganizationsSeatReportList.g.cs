#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Seat report<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// For each member of the organization: whether they occupy a standard (paid) seat, the effective organization role, what set that role, and every identity-provider group assignment behind it.<br/>
        /// Only *organization role* assignments can put a user on a paid seat. Project role and workspace access assignments never affect the seat count.<br/>
        /// Use `?email=` to look up a single member, or `?has_stale_role_assignments=true` to find members kept on a seat by leftover group assignments.
        /// </summary>
        /// <param name="countsTowardSeatLimit"></param>
        /// <param name="email"></param>
        /// <param name="hasStaleRoleAssignments"></param>
        /// <param name="id"></param>
        /// <param name="includeSeatUsage"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="roleSource"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedSeatReportList> ApiOrganizationsSeatReportListAsync(
            int id,
            bool? countsTowardSeatLimit = default,
            string? email = default,
            bool? hasStaleRoleAssignments = default,
            bool? includeSeatUsage = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? roleSource = default,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Seat report<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// For each member of the organization: whether they occupy a standard (paid) seat, the effective organization role, what set that role, and every identity-provider group assignment behind it.<br/>
        /// Only *organization role* assignments can put a user on a paid seat. Project role and workspace access assignments never affect the seat count.<br/>
        /// Use `?email=` to look up a single member, or `?has_stale_role_assignments=true` to find members kept on a seat by leftover group assignments.
        /// </summary>
        /// <param name="countsTowardSeatLimit"></param>
        /// <param name="email"></param>
        /// <param name="hasStaleRoleAssignments"></param>
        /// <param name="id"></param>
        /// <param name="includeSeatUsage"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="roleSource"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedSeatReportList>> ApiOrganizationsSeatReportListAsResponseAsync(
            int id,
            bool? countsTowardSeatLimit = default,
            string? email = default,
            bool? hasStaleRoleAssignments = default,
            bool? includeSeatUsage = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? roleSource = default,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}