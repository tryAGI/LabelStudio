#nullable enable

namespace LabelStudio
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Bulk delete annotations by IDs<br/>
        /// Delete multiple annotations by their IDs. The deletion is processed synchronously. Returns the count of deleted annotations in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse> DeleteBulkAsync(

            global::LabelStudio.AnnotationBulkDeleteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete annotations by IDs<br/>
        /// Delete multiple annotations by their IDs. The deletion is processed synchronously. Returns the count of deleted annotations in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse>> DeleteBulkAsResponseAsync(

            global::LabelStudio.AnnotationBulkDeleteRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete annotations by IDs<br/>
        /// Delete multiple annotations by their IDs. The deletion is processed synchronously. Returns the count of deleted annotations in the response.
        /// </summary>
        /// <param name="ids">
        /// List of annotation IDs to delete
        /// </param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse> DeleteBulkAsync(
            global::System.Collections.Generic.IList<int> ids,
            int project,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}