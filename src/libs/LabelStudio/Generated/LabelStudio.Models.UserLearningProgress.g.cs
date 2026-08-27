
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
        /// <param name="importedAt">
        /// Included only in responses
        /// </param>
        /// <param name="invalidatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="startedAt">
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserLearningProgress(
            global::System.DateTime? completedAt,
            global::System.DateTime? importedAt,
            global::System.DateTime? invalidatedAt,
            global::System.DateTime? startedAt,
            bool isStale = default!,
            object pagesVisited = default!,
            object quizResults = default!,
            int resourceVersion = default!,
            global::LabelStudio.RetakeReasonEnum retakeReason = default!,
            int timeSpentSeconds = default!)
        {
            this.CompletedAt = completedAt;
            this.ImportedAt = importedAt;
            this.InvalidatedAt = invalidatedAt;
            this.IsStale = isStale;
            this.PagesVisited = pagesVisited;
            this.QuizResults = quizResults;
            this.ResourceVersion = resourceVersion;
            this.RetakeReason = retakeReason;
            this.StartedAt = startedAt;
            this.TimeSpentSeconds = timeSpentSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLearningProgress" /> class.
        /// </summary>
        public UserLearningProgress()
        {
        }

    }
}