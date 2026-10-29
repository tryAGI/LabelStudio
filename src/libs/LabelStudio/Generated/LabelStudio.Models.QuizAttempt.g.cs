
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QuizAttempt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.QuizAttemptQuestion> Questions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetakeCycle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScorePercent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SubmittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttempt" /> class.
        /// </summary>
        /// <param name="attemptNumber"></param>
        /// <param name="passed"></param>
        /// <param name="questions"></param>
        /// <param name="retakeCycle"></param>
        /// <param name="scorePercent"></param>
        /// <param name="submittedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuizAttempt(
            int attemptNumber,
            bool passed,
            global::System.Collections.Generic.IList<global::LabelStudio.QuizAttemptQuestion> questions,
            int retakeCycle,
            int scorePercent,
            global::System.DateTime submittedAt)
        {
            this.AttemptNumber = attemptNumber;
            this.Passed = passed;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.RetakeCycle = retakeCycle;
            this.ScorePercent = scorePercent;
            this.SubmittedAt = submittedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttempt" /> class.
        /// </summary>
        public QuizAttempt()
        {
        }

    }
}