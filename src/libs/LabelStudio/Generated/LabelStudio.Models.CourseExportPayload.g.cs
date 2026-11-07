
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// OpenAPI shape of GET /learning-resources/{id}/export/ (also the file Import accepts).
    /// </summary>
    public sealed partial class CourseExportPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Course { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exported_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExportedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FormatVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Modules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public object? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseExportPayload" /> class.
        /// </summary>
        /// <param name="course"></param>
        /// <param name="exportedAt"></param>
        /// <param name="format"></param>
        /// <param name="formatVersion"></param>
        /// <param name="modules"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseExportPayload(
            object course,
            global::System.DateTime exportedAt,
            string format,
            int formatVersion,
            global::System.Collections.Generic.IList<object> modules,
            object? source)
        {
            this.Course = course ?? throw new global::System.ArgumentNullException(nameof(course));
            this.ExportedAt = exportedAt;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.FormatVersion = formatVersion;
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseExportPayload" /> class.
        /// </summary>
        public CourseExportPayload()
        {
        }

    }
}