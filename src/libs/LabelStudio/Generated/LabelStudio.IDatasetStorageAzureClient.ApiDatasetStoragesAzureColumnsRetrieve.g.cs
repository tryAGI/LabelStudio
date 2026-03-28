#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Get data column names from storage<br/>
        /// Retrieves column names from users JSON/blob data in bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesAzureColumnsRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}