#nullable enable

namespace LabelStudio
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Update file upload<br/>
        /// Update a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.FileUpload> UpdateAsync(
            int id,

            global::LabelStudio.PatchedFileUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update file upload<br/>
        /// Update a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.FileUpload> UpdateAsync(
            int id,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}