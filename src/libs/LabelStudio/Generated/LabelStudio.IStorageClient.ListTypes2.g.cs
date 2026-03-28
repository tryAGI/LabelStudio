#nullable enable

namespace LabelStudio
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all import storages types<br/>
        /// Retrieve a list of the import storages types.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>> ListTypes2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}