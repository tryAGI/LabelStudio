
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseExportCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_filter_options")]
        public global::LabelStudio.LseAnnotationFilterOptionsRequest? AnnotationFilterOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("converted_formats")]
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? ConvertedFormats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counters")]
        public object? Counters { get; set; }

        /// <summary>
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::LabelStudio.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// When true, the export is omitted from list endpoints. Detail and download by id still work. TTL deletion (EPHEMERAL_EXPORT_TTL_HOURS, default 24) runs via the RQ cron scheduler when enabled (SaaS; on-prem `rqcron.enabled`); otherwise delete explicitly.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral")]
        public bool? Ephemeral { get; set; }

        /// <summary>
        /// Complete or fail time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialization_options")]
        public global::LabelStudio.SerializationOptionsRequest? SerializationOptions { get; set; }

        /// <summary>
        /// Inclusive lower bound on Task.updated_at for an incremental snapshot. Omit for a full export. Pair with until for a half-open window [since, until).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        public global::System.DateTime? Since { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ProjectImportStatusEnumJsonConverter))]
        public global::LabelStudio.ProjectImportStatusEnum? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_filter_options")]
        public global::LabelStudio.LseTaskFilterOptionsRequest? TaskFilterOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Exclusive upper bound on Task.updated_at. If omitted, or later than create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS, the server uses that time instead. Use the returned value as since on the next incremental create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("until")]
        public global::System.DateTime? Until { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseExportCreateRequest" /> class.
        /// </summary>
        /// <param name="annotationFilterOptions"></param>
        /// <param name="convertedFormats"></param>
        /// <param name="counters"></param>
        /// <param name="createdBy">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="ephemeral">
        /// When true, the export is omitted from list endpoints. Detail and download by id still work. TTL deletion (EPHEMERAL_EXPORT_TTL_HOURS, default 24) runs via the RQ cron scheduler when enabled (SaaS; on-prem `rqcron.enabled`); otherwise delete explicitly.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="md5"></param>
        /// <param name="serializationOptions"></param>
        /// <param name="since">
        /// Inclusive lower bound on Task.updated_at for an incremental snapshot. Omit for a full export. Pair with until for a half-open window [since, until).
        /// </param>
        /// <param name="status"></param>
        /// <param name="taskFilterOptions"></param>
        /// <param name="title"></param>
        /// <param name="until">
        /// Exclusive upper bound on Task.updated_at. If omitted, or later than create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS, the server uses that time instead. Use the returned value as since on the next incremental create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseExportCreateRequest(
            global::LabelStudio.LseAnnotationFilterOptionsRequest? annotationFilterOptions,
            global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? convertedFormats,
            object? counters,
            global::LabelStudio.UserSimpleRequest? createdBy,
            bool? ephemeral,
            global::System.DateTime? finishedAt,
            string? md5,
            global::LabelStudio.SerializationOptionsRequest? serializationOptions,
            global::System.DateTime? since,
            global::LabelStudio.ProjectImportStatusEnum? status,
            global::LabelStudio.LseTaskFilterOptionsRequest? taskFilterOptions,
            string? title,
            global::System.DateTime? until)
        {
            this.AnnotationFilterOptions = annotationFilterOptions;
            this.ConvertedFormats = convertedFormats;
            this.Counters = counters;
            this.CreatedBy = createdBy;
            this.Ephemeral = ephemeral;
            this.FinishedAt = finishedAt;
            this.Md5 = md5;
            this.SerializationOptions = serializationOptions;
            this.Since = since;
            this.Status = status;
            this.TaskFilterOptions = taskFilterOptions;
            this.Title = title;
            this.Until = until;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseExportCreateRequest" /> class.
        /// </summary>
        public LseExportCreateRequest()
        {
        }

    }
}