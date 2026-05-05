#nullable enable

namespace LabelStudio
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// List all available KPIs<br/>
        /// Returns metadata for all available KPI (Key Performance Indicator) classes. Each KPI includes its key, label, base class, dependencies, and configuration. This endpoint is useful for discovering available metrics and understanding their relationships and requirements.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>> ApiAnalyticsKpisRetrieveAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all available KPIs<br/>
        /// Returns metadata for all available KPI (Key Performance Indicator) classes. Each KPI includes its key, label, base class, dependencies, and configuration. This endpoint is useful for discovering available metrics and understanding their relationships and requirements.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>>> ApiAnalyticsKpisRetrieveAsResponseAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}