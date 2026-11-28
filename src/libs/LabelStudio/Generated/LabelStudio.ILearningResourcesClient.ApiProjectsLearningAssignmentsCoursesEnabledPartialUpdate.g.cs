#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Turn Courses on or off for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// When Courses are on, Annotation and Reviewer Instructions are hidden from annotators and reviewers and published assigned courses are shown instead. The instruction content is never changed. Assigning a course to a project always turns Courses on automatically. When Courses are off, no assigned course gates or is offered on the project; the assignments are kept and apply again when Courses are turned back on.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ProjectCoursesEnabled> ApiProjectsLearningAssignmentsCoursesEnabledPartialUpdateAsync(
            int projectPk,

            global::LabelStudio.PatchedProjectCoursesEnabledRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Turn Courses on or off for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// When Courses are on, Annotation and Reviewer Instructions are hidden from annotators and reviewers and published assigned courses are shown instead. The instruction content is never changed. Assigning a course to a project always turns Courses on automatically. When Courses are off, no assigned course gates or is offered on the project; the assignments are kept and apply again when Courses are turned back on.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ProjectCoursesEnabled>> ApiProjectsLearningAssignmentsCoursesEnabledPartialUpdateAsResponseAsync(
            int projectPk,

            global::LabelStudio.PatchedProjectCoursesEnabledRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Turn Courses on or off for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// When Courses are on, Annotation and Reviewer Instructions are hidden from annotators and reviewers and published assigned courses are shown instead. The instruction content is never changed. Assigning a course to a project always turns Courses on automatically. When Courses are off, no assigned course gates or is offered on the project; the assignments are kept and apply again when Courses are turned back on.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="coursesEnabled">
        /// Courses replace Annotation and Reviewer Instructions on this project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ProjectCoursesEnabled> ApiProjectsLearningAssignmentsCoursesEnabledPartialUpdateAsync(
            int projectPk,
            bool? coursesEnabled = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}