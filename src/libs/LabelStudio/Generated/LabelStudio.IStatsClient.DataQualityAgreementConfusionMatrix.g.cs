#nullable enable

namespace LabelStudio
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Data quality: confusion matrix<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Returns label confusion matrix with precision, recall, and top confusion pairs.
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="id"></param>
        /// <param name="mode">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DataQualityAgreementConfusionMatrix> DataQualityAgreementConfusionMatrixAsync(
            int id,
            string? fromName = default,
            global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? mode = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Data quality: confusion matrix<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Returns label confusion matrix with precision, recall, and top confusion pairs.
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="id"></param>
        /// <param name="mode">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.DataQualityAgreementConfusionMatrix>> DataQualityAgreementConfusionMatrixAsResponseAsync(
            int id,
            string? fromName = default,
            global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? mode = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}