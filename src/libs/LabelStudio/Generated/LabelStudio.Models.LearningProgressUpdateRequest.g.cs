
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningProgressUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        public object? Answers { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mark_complete")]
        public bool? MarkComplete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_id")]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quiz_id")]
        public string? QuizId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_spent_seconds")]
        public int? TimeSpentSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningProgressUpdateRequest" /> class.
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="markComplete">
        /// Default Value: false
        /// </param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
        /// <param name="passed"></param>
        /// <param name="quizId"></param>
        /// <param name="timeSpentSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningProgressUpdateRequest(
            object? answers,
            bool? markComplete,
            int? moduleId,
            string? pageId,
            bool? passed,
            string? quizId,
            int? timeSpentSeconds)
        {
            this.Answers = answers;
            this.MarkComplete = markComplete;
            this.ModuleId = moduleId;
            this.PageId = pageId;
            this.Passed = passed;
            this.QuizId = quizId;
            this.TimeSpentSeconds = timeSpentSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningProgressUpdateRequest" /> class.
        /// </summary>
        public LearningProgressUpdateRequest()
        {
        }

    }
}