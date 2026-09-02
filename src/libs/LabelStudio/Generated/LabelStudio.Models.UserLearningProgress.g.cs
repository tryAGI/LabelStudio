
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserLearningProgress
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_page_versions")]
        public global::System.Collections.Generic.Dictionary<string, int> CompletedPageVersions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_updated_at")]
        public string? ContentUpdatedAt { get; set; }

        /// <summary>
        /// True only when the baseline covers the outline, so the client can list edited pages.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_completed_page_versions")]
        public bool HasCompletedPageVersions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported_at")]
        public global::System.DateTime? ImportedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidated_at")]
        public global::System.DateTime? InvalidatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stale")]
        public bool IsStale { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_visited")]
        public object PagesVisited { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("quiz_results")]
        public object QuizResults { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_version")]
        public int ResourceVersion { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.RetakeReasonEnumJsonConverter))]
        public global::LabelStudio.RetakeReasonEnum RetakeReason { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_spent_seconds")]
        public int TimeSpentSeconds { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_page_ids")]
        public global::System.Collections.Generic.IList<string> UpdatedPageIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLearningProgress" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// Included only in responses
        /// </param>
        /// <param name="contentUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="importedAt">
        /// Included only in responses
        /// </param>
        /// <param name="invalidatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="startedAt">
        /// Included only in responses
        /// </param>
        /// <param name="completedPageVersions">
        /// Included only in responses
        /// </param>
        /// <param name="hasCompletedPageVersions">
        /// True only when the baseline covers the outline, so the client can list edited pages.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isStale">
        /// Included only in responses
        /// </param>
        /// <param name="pagesVisited">
        /// Included only in responses
        /// </param>
        /// <param name="quizResults">
        /// Included only in responses
        /// </param>
        /// <param name="resourceVersion">
        /// Included only in responses
        /// </param>
        /// <param name="retakeReason">
        /// Included only in responses
        /// </param>
        /// <param name="timeSpentSeconds">
        /// Included only in responses
        /// </param>
        /// <param name="updatedPageIds">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserLearningProgress(
            global::System.DateTime? completedAt,
            string? contentUpdatedAt,
            global::System.DateTime? importedAt,
            global::System.DateTime? invalidatedAt,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.Dictionary<string, int> completedPageVersions = default!,
            bool hasCompletedPageVersions = default!,
            bool isStale = default!,
            object pagesVisited = default!,
            object quizResults = default!,
            int resourceVersion = default!,
            global::LabelStudio.RetakeReasonEnum retakeReason = default!,
            int timeSpentSeconds = default!,
            global::System.Collections.Generic.IList<string> updatedPageIds = default!)
        {
            this.CompletedAt = completedAt;
            this.CompletedPageVersions = completedPageVersions;
            this.ContentUpdatedAt = contentUpdatedAt;
            this.HasCompletedPageVersions = hasCompletedPageVersions;
            this.ImportedAt = importedAt;
            this.InvalidatedAt = invalidatedAt;
            this.IsStale = isStale;
            this.PagesVisited = pagesVisited;
            this.QuizResults = quizResults;
            this.ResourceVersion = resourceVersion;
            this.RetakeReason = retakeReason;
            this.StartedAt = startedAt;
            this.TimeSpentSeconds = timeSpentSeconds;
            this.UpdatedPageIds = updatedPageIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLearningProgress" /> class.
        /// </summary>
        public UserLearningProgress()
        {
        }

    }
}