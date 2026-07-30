#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Apply a structural change to a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Apply a semantic structural operation (add/delete/duplicate/reorder/move page or module, rename module) to current server state under a compare-and-swap on `structure_version`. A stale version returns 409 `structure_version_conflict` with the fresh outline so the client can resync and retry.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseStructureOpResponse> ApiLearningResourcesStructureCreateAsync(
            int id,

            global::LabelStudio.CourseStructureOpRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Apply a structural change to a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Apply a semantic structural operation (add/delete/duplicate/reorder/move page or module, rename module) to current server state under a compare-and-swap on `structure_version`. A stale version returns 409 `structure_version_conflict` with the fresh outline so the client can resync and retry.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.CourseStructureOpResponse>> ApiLearningResourcesStructureCreateAsResponseAsync(
            int id,

            global::LabelStudio.CourseStructureOpRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Apply a structural change to a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Apply a semantic structural operation (add/delete/duplicate/reorder/move page or module, rename module) to current server state under a compare-and-swap on `structure_version`. A stale version returns 409 `structure_version_conflict` with the fresh outline so the client can resync and retry.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destIndex"></param>
        /// <param name="destModuleId"></param>
        /// <param name="moduleId"></param>
        /// <param name="moduleIds"></param>
        /// <param name="op">
        /// * `add_page` - add_page<br/>
        /// * `delete_page` - delete_page<br/>
        /// * `duplicate_page` - duplicate_page<br/>
        /// * `reorder_pages` - reorder_pages<br/>
        /// * `move_page` - move_page<br/>
        /// * `add_module` - add_module<br/>
        /// * `delete_module` - delete_module<br/>
        /// * `duplicate_module` - duplicate_module<br/>
        /// * `reorder_modules` - reorder_modules<br/>
        /// * `rename_module` - rename_module
        /// </param>
        /// <param name="pageId"></param>
        /// <param name="sourceModuleId"></param>
        /// <param name="structureVersion"></param>
        /// <param name="title"></param>
        /// <param name="toIndex"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseStructureOpResponse> ApiLearningResourcesStructureCreateAsync(
            int id,
            global::LabelStudio.OpEnum op,
            int structureVersion,
            int? destIndex = default,
            int? destModuleId = default,
            int? moduleId = default,
            global::System.Collections.Generic.IList<int>? moduleIds = default,
            string? pageId = default,
            int? sourceModuleId = default,
            string? title = default,
            int? toIndex = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}