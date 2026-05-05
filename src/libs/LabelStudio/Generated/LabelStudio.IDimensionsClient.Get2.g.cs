#nullable enable

namespace LabelStudio
{
    public partial interface IDimensionsClient
    {
        /// <summary>
        /// ✨ Get task agreement matrix<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Returns a pairwise agreement matrix between selected participants for a single task, averaged across all active dimensions or a single specified dimension.
        /// </summary>
        /// <param name="dimension"></param>
        /// <param name="projectPk"></param>
        /// <param name="selection"></param>
        /// <param name="taskPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TaskAgreementMatrixResponse> Get2Async(
            int projectPk,
            global::LabelStudio.AgreementSelectionRequest selection,
            int taskPk,
            int? dimension = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Get task agreement matrix<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Returns a pairwise agreement matrix between selected participants for a single task, averaged across all active dimensions or a single specified dimension.
        /// </summary>
        /// <param name="dimension"></param>
        /// <param name="projectPk"></param>
        /// <param name="selection"></param>
        /// <param name="taskPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.TaskAgreementMatrixResponse>> Get2AsResponseAsync(
            int projectPk,
            global::LabelStudio.AgreementSelectionRequest selection,
            int taskPk,
            int? dimension = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}