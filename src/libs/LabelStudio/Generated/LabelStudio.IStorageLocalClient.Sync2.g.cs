#nullable enable

namespace LabelStudio
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Sync import storage<br/>
        /// Sync tasks from a local file import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LocalFilesImportStorage> Sync2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}