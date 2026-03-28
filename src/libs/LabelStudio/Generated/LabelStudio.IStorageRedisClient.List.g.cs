#nullable enable

namespace LabelStudio
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Get all export storage<br/>
        /// Get a list of all Redis export storage connections.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.RedisExportStorage>> ListAsync(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}