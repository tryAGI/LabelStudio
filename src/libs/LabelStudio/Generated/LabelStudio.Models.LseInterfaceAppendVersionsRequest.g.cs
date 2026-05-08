
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseInterfaceAppendVersionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public object? Artifacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compiled")]
        public string? Compiled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sample")]
        public object? DataSample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public object? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceAppendVersionsRequest" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="artifacts"></param>
        /// <param name="code"></param>
        /// <param name="compiled"></param>
        /// <param name="dataSample"></param>
        /// <param name="inputSchema"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="outputSchema"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceAppendVersionsRequest(
            global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest> versions,
            object? artifacts,
            string? code,
            string? compiled,
            object? dataSample,
            object? inputSchema,
            object? messages,
            object? metadata,
            object? outputSchema,
            string? title)
        {
            this.Artifacts = artifacts;
            this.Code = code;
            this.Compiled = compiled;
            this.DataSample = dataSample;
            this.InputSchema = inputSchema;
            this.Messages = messages;
            this.Metadata = metadata;
            this.OutputSchema = outputSchema;
            this.Title = title;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceAppendVersionsRequest" /> class.
        /// </summary>
        public LseInterfaceAppendVersionsRequest()
        {
        }
    }
}