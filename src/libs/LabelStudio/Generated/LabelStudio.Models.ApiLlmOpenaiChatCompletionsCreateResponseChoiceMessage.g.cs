
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage
    {
        /// <summary>
        /// The content of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The role of the message author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message
        /// </param>
        /// <param name="role">
        /// The role of the message author
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage(
            string? content,
            string? role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateResponseChoiceMessage()
        {
        }

    }
}