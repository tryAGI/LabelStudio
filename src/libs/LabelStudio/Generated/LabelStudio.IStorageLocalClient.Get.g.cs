#nullable enable

namespace LabelStudio
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Get export storage<br/>
        /// Get a specific local file export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LocalFilesExportStorage> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}