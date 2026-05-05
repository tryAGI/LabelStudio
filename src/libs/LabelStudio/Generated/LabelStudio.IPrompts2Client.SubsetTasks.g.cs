#nullable enable

namespace LabelStudio
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ Get Project Subset Task List with Predictions and Accuracy details<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         Provides list of tasks, based on project subset. Includes predictions for tasks. For the 'HasGT' subset, accuracy metrics will also be provided.<br/>
        ///         
        /// </summary>
        /// <param name="alignmentClass"></param>
        /// <param name="alignmentFromName"></param>
        /// <param name="alignmentOutcome"></param>
        /// <param name="includeTotal"></param>
        /// <param name="modelRun"></param>
        /// <param name="ordering"></param>
        /// <param name="outputClass"></param>
        /// <param name="outputFromName"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentModel"></param>
        /// <param name="predictionVersionIds"></param>
        /// <param name="projectPk"></param>
        /// <param name="projectSubset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedProjectSubsetTasksResponseList> SubsetTasksAsync(
            int projectPk,
            string? alignmentClass = default,
            string? alignmentFromName = default,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome = default,
            bool? includeTotal = default,
            int? modelRun = default,
            string? ordering = default,
            string? outputClass = default,
            string? outputFromName = default,
            int? page = default,
            int? pageSize = default,
            int? parentModel = default,
            string? predictionVersionIds = default,
            string? projectSubset = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Get Project Subset Task List with Predictions and Accuracy details<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         Provides list of tasks, based on project subset. Includes predictions for tasks. For the 'HasGT' subset, accuracy metrics will also be provided.<br/>
        ///         
        /// </summary>
        /// <param name="alignmentClass"></param>
        /// <param name="alignmentFromName"></param>
        /// <param name="alignmentOutcome"></param>
        /// <param name="includeTotal"></param>
        /// <param name="modelRun"></param>
        /// <param name="ordering"></param>
        /// <param name="outputClass"></param>
        /// <param name="outputFromName"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentModel"></param>
        /// <param name="predictionVersionIds"></param>
        /// <param name="projectPk"></param>
        /// <param name="projectSubset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedProjectSubsetTasksResponseList>> SubsetTasksAsResponseAsync(
            int projectPk,
            string? alignmentClass = default,
            string? alignmentFromName = default,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome = default,
            bool? includeTotal = default,
            int? modelRun = default,
            string? ordering = default,
            string? outputClass = default,
            string? outputFromName = default,
            int? page = default,
            int? pageSize = default,
            int? parentModel = default,
            string? predictionVersionIds = default,
            string? projectSubset = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}