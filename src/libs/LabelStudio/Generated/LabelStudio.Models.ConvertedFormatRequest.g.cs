
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertedFormatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportType { get; set; }

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.Status7bfEnumJsonConverter))]
        public global::LabelStudio.Status7bfEnum? Status { get; set; }

        /// <summary>
        /// Traceback report in case of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertedFormatRequest" /> class.
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </param>
        /// <param name="traceback">
        /// Traceback report in case of errors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertedFormatRequest(
            string exportType,
            global::LabelStudio.Status7bfEnum? status,
            string? traceback)
        {
            this.ExportType = exportType ?? throw new global::System.ArgumentNullException(nameof(exportType));
            this.Status = status;
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertedFormatRequest" /> class.
        /// </summary>
        public ConvertedFormatRequest()
        {
        }
    }
}