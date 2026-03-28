#nullable enable

namespace LabelStudio
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Get all import storage<br/>
        /// Get list of all Azure import storage connections.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobImportStorage>> ListAsync(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}