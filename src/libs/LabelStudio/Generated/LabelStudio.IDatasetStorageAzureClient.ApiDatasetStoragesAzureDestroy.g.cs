#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Delete import storage<br/>
        /// Delete a specific Azure import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesAzureDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}