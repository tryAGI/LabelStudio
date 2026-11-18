#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Restore a past state of a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Author-only. Forward-only: appends revisions and a `before_restore` pin, never removes history. Restores the whole course, or one page (`scope=page`, which also brings back a deleted page). The result is a draft edit: it never publishes and never changes `content_version`. A stale `structure_version` answers 409 `structure_version_conflict`; a purged revision answers 410 `history_anchor_unavailable` and changes nothing.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RestoreResponse> ApiLearningResourcesHistoryStatesRestoreCreateAsync(
            int id,
            string @ref,

            global::LabelStudio.RestoreRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Restore a past state of a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Author-only. Forward-only: appends revisions and a `before_restore` pin, never removes history. Restores the whole course, or one page (`scope=page`, which also brings back a deleted page). The result is a draft edit: it never publishes and never changes `content_version`. A stale `structure_version` answers 409 `structure_version_conflict`; a purged revision answers 410 `history_anchor_unavailable` and changes nothing.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.RestoreResponse>> ApiLearningResourcesHistoryStatesRestoreCreateAsResponseAsync(
            int id,
            string @ref,

            global::LabelStudio.RestoreRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Restore a past state of a course<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Author-only. Forward-only: appends revisions and a `before_restore` pin, never removes history. Restores the whole course, or one page (`scope=page`, which also brings back a deleted page). The result is a draft edit: it never publishes and never changes `content_version`. A stale `structure_version` answers 409 `structure_version_conflict`; a purged revision answers 410 `history_anchor_unavailable` and changes nothing.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ref"></param>
        /// <param name="pageId"></param>
        /// <param name="scope">
        /// Default Value: course
        /// </param>
        /// <param name="structureVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RestoreResponse> ApiLearningResourcesHistoryStatesRestoreCreateAsync(
            int id,
            string @ref,
            int structureVersion,
            string? pageId = default,
            global::LabelStudio.CourseHistoryScopeEnum? scope = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}