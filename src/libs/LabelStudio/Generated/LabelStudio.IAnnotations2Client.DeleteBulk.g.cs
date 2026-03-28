#nullable enable

namespace LabelStudio
{
    public partial interface IAnnotations2Client
    {
        /// <summary>
        /// Bulk delete annotations by IDs<br/>
        /// Delete multiple annotations by their IDs. The deletion is processed synchronously. Returns the count of deleted annotations in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse> DeleteBulkAsync(

            global::LabelStudio.AnnotationBulkDeleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete annotations by IDs<br/>
        /// Delete multiple annotations by their IDs. The deletion is processed synchronously. Returns the count of deleted annotations in the response.
        /// </summary>
        /// <param name="ids">
        /// List of annotation IDs to delete
        /// </param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse> DeleteBulkAsync(
            global::System.Collections.Generic.IList<int> ids,
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}