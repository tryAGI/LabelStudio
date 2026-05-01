#nullable enable

namespace LabelStudio
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get paginated member performance rows<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Paginated, sortable member performance rows for annotation/review tables. Guarded by &lt;code&gt;fflag_feat_lse_project_dashboards_v3_members_short&lt;/code&gt;.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="table"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse> MemberPerformanceRowsAsync(
            int id,
            string? ids = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable? table = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}