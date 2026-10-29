
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// One question as the learner saw it, with their answer and the correct-answer key.
    /// </summary>
    public sealed partial class QuizAttemptQuestion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public object? Answer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocksJson")]
        public string? BlocksJson { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<object>? Choices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Correct { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correctAnswerIds")]
        public object? CorrectAnswerIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pairs")]
        public global::System.Collections.Generic.IList<object>? Pairs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptQuestion" /> class.
        /// </summary>
        /// <param name="correct"></param>
        /// <param name="id"></param>
        /// <param name="answer"></param>
        /// <param name="blocksJson"></param>
        /// <param name="choices"></param>
        /// <param name="correctAnswerIds"></param>
        /// <param name="pairs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuizAttemptQuestion(
            bool correct,
            string id,
            object? answer,
            string? blocksJson,
            global::System.Collections.Generic.IList<object>? choices,
            object? correctAnswerIds,
            global::System.Collections.Generic.IList<object>? pairs,
            string? type)
        {
            this.Answer = answer;
            this.BlocksJson = blocksJson;
            this.Choices = choices;
            this.Correct = correct;
            this.CorrectAnswerIds = correctAnswerIds;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pairs = pairs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuizAttemptQuestion" /> class.
        /// </summary>
        public QuizAttemptQuestion()
        {
        }

    }
}