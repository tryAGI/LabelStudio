#nullable enable

namespace LabelStudio
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from an S3 export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.S3ExportStorage> SyncAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}