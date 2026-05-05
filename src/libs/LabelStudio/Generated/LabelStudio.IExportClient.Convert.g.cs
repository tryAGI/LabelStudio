#nullable enable

namespace LabelStudio
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Export conversion<br/>
        /// Convert export snapshot to selected format
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsExportsConvertCreateResponse> ConvertAsync(
            int exportPk,
            int id,

            global::LabelStudio.ExportConvertRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export conversion<br/>
        /// Convert export snapshot to selected format
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ApiProjectsExportsConvertCreateResponse>> ConvertAsResponseAsync(
            int exportPk,
            int id,

            global::LabelStudio.ExportConvertRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export conversion<br/>
        /// Convert export snapshot to selected format
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="downloadResources">
        /// Download resources in converter.
        /// </param>
        /// <param name="exportType">
        /// Export file format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsExportsConvertCreateResponse> ConvertAsync(
            int exportPk,
            int id,
            string exportType,
            bool? downloadResources = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}