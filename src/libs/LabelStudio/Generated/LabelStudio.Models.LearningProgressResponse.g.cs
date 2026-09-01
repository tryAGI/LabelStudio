
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LearningProgressResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_page_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> CompletedPageVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_updated_at")]
        public global::System.DateTime? ContentUpdatedAt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_reset")]
        public bool? CourseReset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Gating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_completed_page_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCompletedPageVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_progress")]
        public object? ModuleProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_visited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PagesVisited { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quiz_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object QuizResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResourceVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_spent_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeSpentSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_page_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UpdatedPageIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningProgressResponse" /> class.
        /// </summary>
        /// <param name="completedPageVersions"></param>
        /// <param name="gating"></param>
        /// <param name="hasCompletedPageVersions"></param>
        /// <param name="isStale"></param>
        /// <param name="pagesVisited"></param>
        /// <param name="quizResults"></param>
        /// <param name="resourceVersion"></param>
        /// <param name="timeSpentSeconds"></param>
        /// <param name="updatedPageIds"></param>
        /// <param name="completedAt"></param>
        /// <param name="contentUpdatedAt"></param>
        /// <param name="courseReset">
        /// Default Value: false
        /// </param>
        /// <param name="moduleProgress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningProgressResponse(
            global::System.Collections.Generic.Dictionary<string, int> completedPageVersions,
            object gating,
            bool hasCompletedPageVersions,
            bool isStale,
            global::System.Collections.Generic.IList<string> pagesVisited,
            object quizResults,
            int resourceVersion,
            int timeSpentSeconds,
            global::System.Collections.Generic.IList<string> updatedPageIds,
            global::System.DateTime? completedAt,
            global::System.DateTime? contentUpdatedAt,
            bool? courseReset,
            object? moduleProgress)
        {
            this.CompletedAt = completedAt;
            this.CompletedPageVersions = completedPageVersions ?? throw new global::System.ArgumentNullException(nameof(completedPageVersions));
            this.ContentUpdatedAt = contentUpdatedAt;
            this.CourseReset = courseReset;
            this.Gating = gating ?? throw new global::System.ArgumentNullException(nameof(gating));
            this.HasCompletedPageVersions = hasCompletedPageVersions;
            this.IsStale = isStale;
            this.ModuleProgress = moduleProgress;
            this.PagesVisited = pagesVisited ?? throw new global::System.ArgumentNullException(nameof(pagesVisited));
            this.QuizResults = quizResults ?? throw new global::System.ArgumentNullException(nameof(quizResults));
            this.ResourceVersion = resourceVersion;
            this.TimeSpentSeconds = timeSpentSeconds;
            this.UpdatedPageIds = updatedPageIds ?? throw new global::System.ArgumentNullException(nameof(updatedPageIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningProgressResponse" /> class.
        /// </summary>
        public LearningProgressResponse()
        {
        }

    }
}