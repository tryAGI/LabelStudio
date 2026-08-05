#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Heartbeat or release an editing session for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// POST claims or refreshes presence on a (module, page). A bare heartbeat only tracks presence — it never claims the write lock. Pass `wants_to_edit` to actually claim it: the first session on a free page to ask becomes the writer, later ones stay read-only unless `takeover` is set (which itself implies `wants_to_edit`). Sessions expire 60 seconds after the last heartbeat. DELETE releases the caller's own session.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseEditingSessionResponse> ApiLearningResourcesEditingSessionCreateAsync(
            int id,

            global::LabelStudio.CourseEditingSessionHeartbeatRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Heartbeat or release an editing session for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// POST claims or refreshes presence on a (module, page). A bare heartbeat only tracks presence — it never claims the write lock. Pass `wants_to_edit` to actually claim it: the first session on a free page to ask becomes the writer, later ones stay read-only unless `takeover` is set (which itself implies `wants_to_edit`). Sessions expire 60 seconds after the last heartbeat. DELETE releases the caller's own session.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.CourseEditingSessionResponse>> ApiLearningResourcesEditingSessionCreateAsResponseAsync(
            int id,

            global::LabelStudio.CourseEditingSessionHeartbeatRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Heartbeat or release an editing session for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// POST claims or refreshes presence on a (module, page). A bare heartbeat only tracks presence — it never claims the write lock. Pass `wants_to_edit` to actually claim it: the first session on a free page to ask becomes the writer, later ones stay read-only unless `takeover` is set (which itself implies `wants_to_edit`). Sessions expire 60 seconds after the last heartbeat. DELETE releases the caller's own session.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
        /// <param name="takeover">
        /// Default Value: false
        /// </param>
        /// <param name="wantsToEdit">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseEditingSessionResponse> ApiLearningResourcesEditingSessionCreateAsync(
            int id,
            string pageId,
            int? moduleId = default,
            bool? takeover = default,
            bool? wantsToEdit = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}