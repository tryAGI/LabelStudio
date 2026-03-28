#nullable enable

namespace LabelStudio
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download a specific uploaded file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadAsync(
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}