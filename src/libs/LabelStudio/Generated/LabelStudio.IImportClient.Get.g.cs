#nullable enable

namespace LabelStudio
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Get file upload<br/>
        /// Retrieve details about a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.FileUpload> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}