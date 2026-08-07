
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Validates and sanitizes individual chat messages for LLM chat completion requests.<br/>
    /// Supports the following message roles:<br/>
    /// - user, developer, system: Must have 'content' field (string or dict)<br/>
    /// - assistant: Must have either 'content' (non-empty) or 'tool_calls' (non-empty array)<br/>
    /// - tool: Must have 'content' (non-empty) and 'tool_call_id' fields<br/>
    /// All fields not explicitly defined are removed during validation to ensure<br/>
    /// only valid fields are passed to LLM providers.
    /// </summary>
    public sealed partial class ChatMessageRequest
    {
        /// <summary>
        /// The content of the message (can be a string or structured dict)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        /// The role of the message author (user, developer, system, assistant, or tool)<br/>
        /// * `user` - user<br/>
        /// * `developer` - developer<br/>
        /// * `system` - system<br/>
        /// * `assistant` - assistant<br/>
        /// * `tool` - tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ChatMessageRoleEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.ChatMessageRoleEnum Role { get; set; }

        /// <summary>
        /// The ID of the tool call this message is responding to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Tool calls made by the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<object>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message author (user, developer, system, assistant, or tool)<br/>
        /// * `user` - user<br/>
        /// * `developer` - developer<br/>
        /// * `system` - system<br/>
        /// * `assistant` - assistant<br/>
        /// * `tool` - tool
        /// </param>
        /// <param name="content">
        /// The content of the message (can be a string or structured dict)
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call this message is responding to
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls made by the assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageRequest(
            global::LabelStudio.ChatMessageRoleEnum role,
            object? content,
            string? toolCallId,
            global::System.Collections.Generic.IList<object>? toolCalls)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCallId = toolCallId;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageRequest" /> class.
        /// </summary>
        public ChatMessageRequest()
        {
        }

    }
}