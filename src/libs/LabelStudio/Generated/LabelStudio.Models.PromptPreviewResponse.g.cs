
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPreviewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RenderedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPreviewResponse" /> class.
        /// </summary>
        /// <param name="renderedPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptPreviewResponse(
            string renderedPrompt)
        {
            this.RenderedPrompt = renderedPrompt ?? throw new global::System.ArgumentNullException(nameof(renderedPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPreviewResponse" /> class.
        /// </summary>
        public PromptPreviewResponse()
        {
        }

    }
}