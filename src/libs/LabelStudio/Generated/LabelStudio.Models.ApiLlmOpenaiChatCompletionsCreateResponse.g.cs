
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateResponse
    {
        /// <summary>
        /// Array of completion choices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseChoice>? Choices { get; set; }

        /// <summary>
        /// Unix timestamp of when the completion was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Unique identifier for the chat completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model used for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Object type, always "chat.completion"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Token usage statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponse" /> class.
        /// </summary>
        /// <param name="choices">
        /// Array of completion choices
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the completion was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the chat completion
        /// </param>
        /// <param name="model">
        /// The model used for the completion
        /// </param>
        /// <param name="object">
        /// Object type, always "chat.completion"
        /// </param>
        /// <param name="usage">
        /// Token usage statistics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLlmOpenaiChatCompletionsCreateResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseChoice>? choices,
            global::System.DateTimeOffset? created,
            string? id,
            string? model,
            string? @object,
            global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateResponseUsage? usage)
        {
            this.Choices = choices;
            this.Created = created;
            this.Id = id;
            this.Model = model;
            this.Object = @object;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponse" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateResponse()
        {
        }

    }
}