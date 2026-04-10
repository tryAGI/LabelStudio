#nullable enable

namespace LabelStudio
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseExportCreate> CreateAsync(
            int id,

            global::LabelStudio.LseExportCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotationFilterOptions"></param>
        /// <param name="convertedFormats"></param>
        /// <param name="counters"></param>
        /// <param name="createdBy">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="md5"></param>
        /// <param name="serializationOptions"></param>
        /// <param name="status"></param>
        /// <param name="taskFilterOptions"></param>
        /// <param name="title"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseExportCreate> CreateAsync(
            int id,
            global::LabelStudio.LseAnnotationFilterOptionsRequest? annotationFilterOptions = default,
            global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? convertedFormats = default,
            object? counters = default,
            global::LabelStudio.UserSimpleRequest? createdBy = default,
            global::System.DateTime? finishedAt = default,
            string? md5 = default,
            global::LabelStudio.SerializationOptionsRequest? serializationOptions = default,
            global::LabelStudio.Status7bfEnum? status = default,
            global::LabelStudio.LseTaskFilterOptionsRequest? taskFilterOptions = default,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}