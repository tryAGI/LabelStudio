#nullable enable

namespace LabelStudio
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all dataset storages types<br/>
        /// Retrieve a list of the dataset storages types.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesTypesRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}