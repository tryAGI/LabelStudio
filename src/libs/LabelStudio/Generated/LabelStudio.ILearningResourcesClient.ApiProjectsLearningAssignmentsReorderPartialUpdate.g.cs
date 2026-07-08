#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Reorder learning assignments for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Reorder the learning resource assignments for a project.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>> ApiProjectsLearningAssignmentsReorderPartialUpdateAsync(
            int projectPk,

            global::LabelStudio.PatchedProjectLearningAssignmentRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Reorder learning assignments for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Reorder the learning resource assignments for a project.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>>> ApiProjectsLearningAssignmentsReorderPartialUpdateAsResponseAsync(
            int projectPk,

            global::LabelStudio.PatchedProjectLearningAssignmentRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Reorder learning assignments for a project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Reorder the learning resource assignments for a project.
        /// </summary>
        /// <param name="projectPk"></param>
        /// <param name="allowManualAccess"></param>
        /// <param name="gateAnnotatorDataManager"></param>
        /// <param name="gateAnnotatorLabelStream"></param>
        /// <param name="gateReviewerDataManager"></param>
        /// <param name="gateReviewerLabelStream"></param>
        /// <param name="gateReviewerReviewStream"></param>
        /// <param name="learningResourceId">
        /// Included only in requests
        /// </param>
        /// <param name="sortOrder"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>> ApiProjectsLearningAssignmentsReorderPartialUpdateAsync(
            int projectPk,
            int learningResourceId,
            bool? allowManualAccess = default,
            bool? gateAnnotatorDataManager = default,
            bool? gateAnnotatorLabelStream = default,
            bool? gateReviewerDataManager = default,
            bool? gateReviewerLabelStream = default,
            bool? gateReviewerReviewStream = default,
            int? sortOrder = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}