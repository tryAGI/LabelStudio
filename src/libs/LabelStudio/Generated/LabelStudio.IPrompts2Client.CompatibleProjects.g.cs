#nullable enable

namespace LabelStudio
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ List projects compatible with prompt<br/>
        /// Retrieve a list of compatible project for prompt.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="ids"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectType">
        /// Default Value: TextClassification
        /// </param>
        /// <param name="sourceInterfaceId"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedAllRolesProjectListList> CompatibleProjectsAsync(
            bool? archived = default,
            global::System.Collections.Generic.IList<int>? ids = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType? projectType = default,
            double? sourceInterfaceId = default,
            string? state = default,
            string? title = default,
            int? workspaces = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ List projects compatible with prompt<br/>
        /// Retrieve a list of compatible project for prompt.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="ids"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectType">
        /// Default Value: TextClassification
        /// </param>
        /// <param name="sourceInterfaceId"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedAllRolesProjectListList>> CompatibleProjectsAsResponseAsync(
            bool? archived = default,
            global::System.Collections.Generic.IList<int>? ids = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType? projectType = default,
            double? sourceInterfaceId = default,
            string? state = default,
            string? title = default,
            int? workspaces = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}