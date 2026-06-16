
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseProgressImportResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImportedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported_emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImportedEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_invalid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> SkippedInvalid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_not_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SkippedNotCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_not_in_org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SkippedNotInOrg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseProgressImportResult" /> class.
        /// </summary>
        /// <param name="importedCount"></param>
        /// <param name="importedEmails"></param>
        /// <param name="skippedInvalid"></param>
        /// <param name="skippedNotCompleted"></param>
        /// <param name="skippedNotInOrg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseProgressImportResult(
            int importedCount,
            global::System.Collections.Generic.IList<string> importedEmails,
            global::System.Collections.Generic.IList<object> skippedInvalid,
            global::System.Collections.Generic.IList<string> skippedNotCompleted,
            global::System.Collections.Generic.IList<string> skippedNotInOrg)
        {
            this.ImportedCount = importedCount;
            this.ImportedEmails = importedEmails ?? throw new global::System.ArgumentNullException(nameof(importedEmails));
            this.SkippedInvalid = skippedInvalid ?? throw new global::System.ArgumentNullException(nameof(skippedInvalid));
            this.SkippedNotCompleted = skippedNotCompleted ?? throw new global::System.ArgumentNullException(nameof(skippedNotCompleted));
            this.SkippedNotInOrg = skippedNotInOrg ?? throw new global::System.ArgumentNullException(nameof(skippedNotInOrg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseProgressImportResult" /> class.
        /// </summary>
        public CourseProgressImportResult()
        {
        }

    }
}