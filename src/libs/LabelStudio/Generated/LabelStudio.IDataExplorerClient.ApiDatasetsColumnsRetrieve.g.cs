#nullable enable

namespace LabelStudio
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Get data explorer columns<br/>
        /// Retrieve the data explorer columns available for a specific Dataset.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsColumnsRetrieveAsync(
            int? dataset = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}