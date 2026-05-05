#nullable enable

namespace LabelStudio
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// Create labels<br/>
        /// Add labels to your project without updating the labeling configuration.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedLabelCreateList> Create2Async(

            global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest> request,
            string? ordering = default,
            int? page = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create labels<br/>
        /// Add labels to your project without updating the labeling configuration.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLabelCreateList>> Create2AsResponseAsync(

            global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest> request,
            string? ordering = default,
            int? page = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}