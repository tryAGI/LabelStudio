
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateResponse2
    {
        /// <summary>
        /// Error message describing the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponse2" /> class.
        /// </summary>
        /// <param name="detail">
        /// Error message describing the issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLlmOpenaiChatCompletionsCreateResponse2(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateResponse2" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateResponse2()
        {
        }

    }
}