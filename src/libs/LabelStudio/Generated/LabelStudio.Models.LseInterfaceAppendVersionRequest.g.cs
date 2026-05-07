
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseInterfaceAppendVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifactId")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changeRanges")]
        public object? ChangeRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compiled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Compiled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public string? Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paramsSchema")]
        public object? ParamsSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceAppendVersionRequest" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="compiled"></param>
        /// <param name="artifactId"></param>
        /// <param name="changeRanges"></param>
        /// <param name="description"></param>
        /// <param name="inputSchema"></param>
        /// <param name="messageId"></param>
        /// <param name="op"></param>
        /// <param name="outputSchema"></param>
        /// <param name="paramsSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceAppendVersionRequest(
            string code,
            string compiled,
            string? artifactId,
            object? changeRanges,
            string? description,
            object? inputSchema,
            string? messageId,
            string? op,
            object? outputSchema,
            object? paramsSchema)
        {
            this.ArtifactId = artifactId;
            this.ChangeRanges = changeRanges;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Compiled = compiled ?? throw new global::System.ArgumentNullException(nameof(compiled));
            this.Description = description;
            this.InputSchema = inputSchema;
            this.MessageId = messageId;
            this.Op = op;
            this.OutputSchema = outputSchema;
            this.ParamsSchema = paramsSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceAppendVersionRequest" /> class.
        /// </summary>
        public LseInterfaceAppendVersionRequest()
        {
        }
    }
}