#nullable enable

namespace LabelStudio
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// ✨ Get KPI data with optional segmentation<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve data for a specific KPI with support for filtering and segmentation. Can segment by time (hourly, daily, weekly, monthly, yearly), by user, or both (2D matrix). If no segmentation is specified, returns a single total value. Supports filtering by projects, members, and date range. Date filters are interpreted in the specified timezone (required parameter). Maximum 50 projects allowed per request for performance reasons.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="end"></param>
        /// <param name="kpiKey"></param>
        /// <param name="members"></param>
        /// <param name="projects"></param>
        /// <param name="segmentByProject"></param>
        /// <param name="segmentByTime"></param>
        /// <param name="segmentByUser"></param>
        /// <param name="start"></param>
        /// <param name="tz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.KPIDetailResponse> GetAsync(
            string kpiKey,
            string tz,
            bool? all = default,
            global::System.DateTime? end = default,
            string? members = default,
            string? projects = default,
            bool? segmentByProject = default,
            global::LabelStudio.ApiAnalyticsKpisRetrieveSegmentByTime? segmentByTime = default,
            bool? segmentByUser = default,
            global::System.DateTime? start = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Get KPI data with optional segmentation<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve data for a specific KPI with support for filtering and segmentation. Can segment by time (hourly, daily, weekly, monthly, yearly), by user, or both (2D matrix). If no segmentation is specified, returns a single total value. Supports filtering by projects, members, and date range. Date filters are interpreted in the specified timezone (required parameter). Maximum 50 projects allowed per request for performance reasons.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="end"></param>
        /// <param name="kpiKey"></param>
        /// <param name="members"></param>
        /// <param name="projects"></param>
        /// <param name="segmentByProject"></param>
        /// <param name="segmentByTime"></param>
        /// <param name="segmentByUser"></param>
        /// <param name="start"></param>
        /// <param name="tz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.KPIDetailResponse>> GetAsResponseAsync(
            string kpiKey,
            string tz,
            bool? all = default,
            global::System.DateTime? end = default,
            string? members = default,
            string? projects = default,
            bool? segmentByProject = default,
            global::LabelStudio.ApiAnalyticsKpisRetrieveSegmentByTime? segmentByTime = default,
            bool? segmentByUser = default,
            global::System.DateTime? start = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}