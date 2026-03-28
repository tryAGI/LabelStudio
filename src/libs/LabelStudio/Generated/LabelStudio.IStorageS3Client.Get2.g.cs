#nullable enable

namespace LabelStudio
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific S3 import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.S3ImportStorage> Get2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}