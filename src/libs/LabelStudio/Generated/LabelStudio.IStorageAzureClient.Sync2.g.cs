#nullable enable

namespace LabelStudio
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from an Azure export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AzureBlobExportStorage> Sync2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}