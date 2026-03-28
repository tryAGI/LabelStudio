#nullable enable

namespace LabelStudio
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Get export storage<br/>
        /// Get a specific Redis export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RedisExportStorage> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}