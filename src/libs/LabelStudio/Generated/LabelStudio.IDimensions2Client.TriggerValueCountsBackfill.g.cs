#nullable enable

namespace LabelStudio
{
    public partial interface IDimensions2Client
    {
        /// <summary>
        /// ✨ Trigger Dimension value-counts backfill<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Trigger a Dimension label-distribution value-counts backfill for the authenticated user's active organization. Populates MatrixAnnotatorEntry.value_counts and rebuilds the ProjectSummary.dimension_value_counts cache for all tasks, without recomputing agreement scores. Exactly one of three body fields must be provided:<br/>
        /// - **project_id**: backfill a single specific project.<br/>
        /// - **num_projects**: batched org backfill — queue the next N not-yet-started projects (in ascending project ID order), leaving any currently in-flight jobs untouched. Repeat calls until `projects_remaining` in the response reaches 0.<br/>
        /// - **all_projects**: full org backfill — cancel all in-flight jobs and queue every remaining non-completed project at once.<br/>
        /// Requires administrator or owner role, the Agreement V2 feature flag, and the value-counts write feature flag.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AgreementV2BackfillTriggerResponse> TriggerValueCountsBackfillAsync(

            global::LabelStudio.AgreementV2BackfillTriggerRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Trigger Dimension value-counts backfill<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Trigger a Dimension label-distribution value-counts backfill for the authenticated user's active organization. Populates MatrixAnnotatorEntry.value_counts and rebuilds the ProjectSummary.dimension_value_counts cache for all tasks, without recomputing agreement scores. Exactly one of three body fields must be provided:<br/>
        /// - **project_id**: backfill a single specific project.<br/>
        /// - **num_projects**: batched org backfill — queue the next N not-yet-started projects (in ascending project ID order), leaving any currently in-flight jobs untouched. Repeat calls until `projects_remaining` in the response reaches 0.<br/>
        /// - **all_projects**: full org backfill — cancel all in-flight jobs and queue every remaining non-completed project at once.<br/>
        /// Requires administrator or owner role, the Agreement V2 feature flag, and the value-counts write feature flag.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.AgreementV2BackfillTriggerResponse>> TriggerValueCountsBackfillAsResponseAsync(

            global::LabelStudio.AgreementV2BackfillTriggerRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Trigger Dimension value-counts backfill<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Trigger a Dimension label-distribution value-counts backfill for the authenticated user's active organization. Populates MatrixAnnotatorEntry.value_counts and rebuilds the ProjectSummary.dimension_value_counts cache for all tasks, without recomputing agreement scores. Exactly one of three body fields must be provided:<br/>
        /// - **project_id**: backfill a single specific project.<br/>
        /// - **num_projects**: batched org backfill — queue the next N not-yet-started projects (in ascending project ID order), leaving any currently in-flight jobs untouched. Repeat calls until `projects_remaining` in the response reaches 0.<br/>
        /// - **all_projects**: full org backfill — cancel all in-flight jobs and queue every remaining non-completed project at once.<br/>
        /// Requires administrator or owner role, the Agreement V2 feature flag, and the value-counts write feature flag.
        /// </summary>
        /// <param name="allProjects">
        /// Set to true to trigger a full org backfill (cancels in-flight jobs and queues all remaining projects).
        /// </param>
        /// <param name="numProjects">
        /// Queue at most this many projects per call (batched mode).
        /// </param>
        /// <param name="projectId">
        /// Backfill a single specific project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AgreementV2BackfillTriggerResponse> TriggerValueCountsBackfillAsync(
            bool? allProjects = default,
            int? numProjects = default,
            int? projectId = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}