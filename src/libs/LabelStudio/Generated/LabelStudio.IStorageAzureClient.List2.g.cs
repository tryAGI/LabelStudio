#nullable enable

namespace LabelStudio
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Get all export storage<br/>
        /// Get a list of all Azure export storage connections.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobExportStorage>> List2Async(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}