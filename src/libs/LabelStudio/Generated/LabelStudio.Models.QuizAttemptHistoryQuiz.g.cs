
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QuizAttemptHistoryQuiz
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.QuizAttempt> Attempts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_result")]
        public global::LabelStudio.QuizLegacyResult? LegacyResult { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageTitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quiz_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuizId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Removed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrecorded_attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnrecordedAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptHistoryQuiz" /> class.
        /// </summary>
        /// <param name="attempts"></param>
        /// <param name="pageTitle"></param>
        /// <param name="quizId"></param>
        /// <param name="removed"></param>
        /// <param name="title"></param>
        /// <param name="unrecordedAttempts"></param>
        /// <param name="legacyResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuizAttemptHistoryQuiz(
            global::System.Collections.Generic.IList<global::LabelStudio.QuizAttempt> attempts,
            string pageTitle,
            string quizId,
            bool removed,
            string title,
            int unrecordedAttempts,
            global::LabelStudio.QuizLegacyResult? legacyResult)
        {
            this.Attempts = attempts ?? throw new global::System.ArgumentNullException(nameof(attempts));
            this.LegacyResult = legacyResult;
            this.PageTitle = pageTitle ?? throw new global::System.ArgumentNullException(nameof(pageTitle));
            this.QuizId = quizId ?? throw new global::System.ArgumentNullException(nameof(quizId));
            this.Removed = removed;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UnrecordedAttempts = unrecordedAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptHistoryQuiz" /> class.
        /// </summary>
        public QuizAttemptHistoryQuiz()
        {
        }

    }
}