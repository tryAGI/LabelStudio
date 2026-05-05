#nullable enable

namespace LabelStudio
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get member performance table summary aggregates<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Footer / Total aggregates for member performance tables. Use with paginated &lt;code&gt;member_performance_rows&lt;/code&gt;. Guarded by &lt;code&gt;fflag_feat_lse_project_dashboards_v3_members_short&lt;/code&gt;.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="table"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse> MemberPerformanceSummaryAsync(
            int id,
            string? ids = default,
            global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? table = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Get member performance table summary aggregates<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Footer / Total aggregates for member performance tables. Use with paginated &lt;code&gt;member_performance_rows&lt;/code&gt;. Guarded by &lt;code&gt;fflag_feat_lse_project_dashboards_v3_members_short&lt;/code&gt;.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="table"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse>> MemberPerformanceSummaryAsResponseAsync(
            int id,
            string? ids = default,
            global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? table = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}