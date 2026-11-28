#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Preview what assigning a learning resource does to projects<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Read-only. Returns one row per selected project (by title, capped; see total) and says whether assigning this course would turn Courses on there and so hide its written instructions (switch_with_instructions), turn Courses on with nothing to hide (switch_empty), or change nothing (already_on). Assigning a course always turns Courses on for the project. The preview lets the UI say what that costs; it changes nothing and the assignment endpoints never depend on it: assigning through the API or SDK is silent and turns Courses on for the project. Projects of other organizations or that the caller cannot access are left out.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AssignmentPreviewResponse> ApiLearningResourcesProjectAssignmentPreviewCreateAsync(
            int id,

            global::LabelStudio.AssignmentPreviewRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Preview what assigning a learning resource does to projects<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Read-only. Returns one row per selected project (by title, capped; see total) and says whether assigning this course would turn Courses on there and so hide its written instructions (switch_with_instructions), turn Courses on with nothing to hide (switch_empty), or change nothing (already_on). Assigning a course always turns Courses on for the project. The preview lets the UI say what that costs; it changes nothing and the assignment endpoints never depend on it: assigning through the API or SDK is silent and turns Courses on for the project. Projects of other organizations or that the caller cannot access are left out.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.AssignmentPreviewResponse>> ApiLearningResourcesProjectAssignmentPreviewCreateAsResponseAsync(
            int id,

            global::LabelStudio.AssignmentPreviewRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Preview what assigning a learning resource does to projects<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Read-only. Returns one row per selected project (by title, capped; see total) and says whether assigning this course would turn Courses on there and so hide its written instructions (switch_with_instructions), turn Courses on with nothing to hide (switch_empty), or change nothing (already_on). Assigning a course always turns Courses on for the project. The preview lets the UI say what that costs; it changes nothing and the assignment endpoints never depend on it: assigning through the API or SDK is silent and turns Courses on for the project. Projects of other organizations or that the caller cannot access are left out.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AssignmentPreviewResponse> ApiLearningResourcesProjectAssignmentPreviewCreateAsync(
            int id,
            global::System.Collections.Generic.IList<int> projectIds,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}