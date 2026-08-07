
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Validates and sanitizes chat completion request payload.<br/>
    /// Ensures:<br/>
    /// - messages is a list of valid message dictionaries<br/>
    /// - Each message conforms to role-specific requirements<br/>
    /// - Only allowed fields are included in the sanitized output
    /// </summary>
    public sealed partial class ChatCompletionRequestRequest
    {
        /// <summary>
        /// Array of message objects forming the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.ChatMessageRequest> Messages { get; set; }

        /// <summary>
        /// Model identifier in format "provider/model-name" (e.g., "openai/gpt-4")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Array of message objects forming the conversation
        /// </param>
        /// <param name="model">
        /// Model identifier in format "provider/model-name" (e.g., "openai/gpt-4")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestRequest(
            global::System.Collections.Generic.IList<global::LabelStudio.ChatMessageRequest> messages,
            string model)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestRequest" /> class.
        /// </summary>
        public ChatCompletionRequestRequest()
        {
        }

    }
}