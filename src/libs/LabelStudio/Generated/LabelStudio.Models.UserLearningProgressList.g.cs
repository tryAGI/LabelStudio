
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserLearningProgressList
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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stale")]
        public bool IsStale { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_module_title")]
        public string LastModuleTitle { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_page_id")]
        public string LastPageId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_page_title")]
        public string LastPageTitle { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_visited")]
        public global::System.Collections.Generic.IList<string> PagesVisited { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_percent")]
        public string ProgressPercent { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("quiz_summary")]
        public string QuizSummary { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_retake")]
        public string RequiresRetake { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::LabelStudio.UserSimple User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLearningProgressList" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// Included only in responses
        /// </param>
        /// <param name="startedAt">
        /// Included only in responses
        /// </param>
        /// <param name="isStale">
        /// Included only in responses
        /// </param>
        /// <param name="lastModuleTitle">
        /// Included only in responses
        /// </param>
        /// <param name="lastPageId">
        /// Included only in responses
        /// </param>
        /// <param name="lastPageTitle">
        /// Included only in responses
        /// </param>
        /// <param name="pagesVisited">
        /// Included only in responses
        /// </param>
        /// <param name="progressPercent">
        /// Included only in responses
        /// </param>
        /// <param name="quizSummary">
        /// Included only in responses
        /// </param>
        /// <param name="requiresRetake">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="timeSpentSeconds">
        /// Included only in responses
        /// </param>
        /// <param name="user">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserLearningProgressList(
            global::System.DateTime? completedAt,
            global::System.DateTime? startedAt,
            bool isStale = default!,
            string lastModuleTitle = default!,
            string lastPageId = default!,
            string lastPageTitle = default!,
            global::System.Collections.Generic.IList<string> pagesVisited = default!,
            string progressPercent = default!,
            string quizSummary = default!,
            string requiresRetake = default!,
            string status = default!,
            int timeSpentSeconds = default!,
            global::LabelStudio.UserSimple user = default!)
        {
            this.CompletedAt = completedAt;
            this.IsStale = isStale;
            this.LastModuleTitle = lastModuleTitle;
            this.LastPageId = lastPageId;
            this.LastPageTitle = lastPageTitle;
            this.PagesVisited = pagesVisited;
            this.ProgressPercent = progressPercent;
            this.QuizSummary = quizSummary;
            this.RequiresRetake = requiresRetake;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TimeSpentSeconds = timeSpentSeconds;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLearningProgressList" /> class.
        /// </summary>
        public UserLearningProgressList()
        {
        }

    }
}