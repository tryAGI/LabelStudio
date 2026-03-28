#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset view details<br/>
        /// Get the details about a specific view in the data manager
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.DatasetView> ApiDatasetsViewsRetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}