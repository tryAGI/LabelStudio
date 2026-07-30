#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Save one page of a module<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Replace only the supplied keys of a single page. Rejects a stale `page_version` with 409 `page_version_conflict`, and a page that moved to another module with 410 `page_moved`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CoursePageSaveResponse> ApiLearningResourcesModulesPagesPartialUpdateAsync(
            int id,
            string moduleId,
            string pageId,

            global::LabelStudio.PatchedCoursePageUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Save one page of a module<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Replace only the supplied keys of a single page. Rejects a stale `page_version` with 409 `page_version_conflict`, and a page that moved to another module with 410 `page_moved`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.CoursePageSaveResponse>> ApiLearningResourcesModulesPagesPartialUpdateAsResponseAsync(
            int id,
            string moduleId,
            string pageId,

            global::LabelStudio.PatchedCoursePageUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Save one page of a module<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Replace only the supplied keys of a single page. Rejects a stale `page_version` with 409 `page_version_conflict`, and a page that moved to another module with 410 `page_moved`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
        /// <param name="blocks"></param>
        /// <param name="pageVersion"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CoursePageSaveResponse> ApiLearningResourcesModulesPagesPartialUpdateAsync(
            int id,
            string moduleId,
            string pageId,
            global::System.Collections.Generic.IList<object>? blocks = default,
            int? pageVersion = default,
            string? summary = default,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}