#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific Azure import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AzureDatasetStorage> ApiDatasetStoragesAzureRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}