
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QuizAttemptHistory
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quizzes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.QuizAttemptHistoryQuiz> Quizzes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptHistory" /> class.
        /// </summary>
        /// <param name="quizzes"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuizAttemptHistory(
            global::System.Collections.Generic.IList<global::LabelStudio.QuizAttemptHistoryQuiz> quizzes,
            int userId)
        {
            this.Quizzes = quizzes ?? throw new global::System.ArgumentNullException(nameof(quizzes));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptHistory" /> class.
        /// </summary>
        public QuizAttemptHistory()
        {
        }

    }
}