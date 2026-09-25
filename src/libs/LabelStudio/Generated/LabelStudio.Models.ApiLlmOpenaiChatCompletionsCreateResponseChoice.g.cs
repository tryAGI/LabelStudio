
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateResponseChoice
    {
        /// <summary>
        /// The reason the completion finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// The index of the choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponseChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason the completion finished
        /// </param>
        /// <param name="index">
        /// The index of the choice
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLlmOpenaiChatCompletionsCreateResponseChoice(
            string? finishReason,
            int? index,
            global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage? message)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponseChoice" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateResponseChoice()
        {
        }

    }
}