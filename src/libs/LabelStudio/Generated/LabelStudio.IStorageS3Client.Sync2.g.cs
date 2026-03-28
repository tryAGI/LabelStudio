#nullable enable

namespace LabelStudio
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Sync import storage<br/>
        /// Sync tasks from an S3 import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.S3ImportStorage> Sync2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}