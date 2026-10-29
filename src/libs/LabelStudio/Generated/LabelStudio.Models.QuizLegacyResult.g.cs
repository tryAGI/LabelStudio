
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Last result for attempts made before attempt recording existed: no answers, correct/incorrect only.
    /// </summary>
    public sealed partial class QuizLegacyResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Attempts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_attempt")]
        public string? LastAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object> QuestionResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScorePercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizLegacyResult" /> class.
        /// </summary>
        /// <param name="attempts"></param>
        /// <param name="questionResults"></param>
        /// <param name="scorePercent"></param>
        /// <param name="lastAttempt"></param>
        /// <param name="passed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuizLegacyResult(
            int attempts,
            global::System.Collections.Generic.Dictionary<string, object> questionResults,
            int scorePercent,
            string? lastAttempt,
            bool? passed)
        {
            this.Attempts = attempts;
            this.LastAttempt = lastAttempt;
            this.Passed = passed;
            this.QuestionResults = questionResults ?? throw new global::System.ArgumentNullException(nameof(questionResults));
            this.ScorePercent = scorePercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizLegacyResult" /> class.
        /// </summary>
        public QuizLegacyResult()
        {
        }

    }
}