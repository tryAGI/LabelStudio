#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Bulk update labels<br/>
        ///         If you want to update the labels in saved annotations, use this endpoint.<br/>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LabelBulkUpdateResponse> UpdateManyAsync(

            global::LabelStudio.LabelBulkUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update labels<br/>
        ///         If you want to update the labels in saved annotations, use this endpoint.<br/>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LabelBulkUpdateResponse>> UpdateManyAsResponseAsync(

            global::LabelStudio.LabelBulkUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update labels<br/>
        ///         If you want to update the labels in saved annotations, use this endpoint.<br/>
        ///
        /// </summary>
        /// <param name="newLabel"></param>
        /// <param name="oldLabel"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LabelBulkUpdateResponse> UpdateManyAsync(
            object newLabel,
            object oldLabel,
            int? project = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}