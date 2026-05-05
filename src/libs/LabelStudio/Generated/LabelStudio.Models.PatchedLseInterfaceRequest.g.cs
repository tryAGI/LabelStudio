
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedLseInterfaceRequest
    {
        /// <summary>
        /// AI-produced code snapshots for session continuity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public object? Artifacts { get; set; }

        /// <summary>
        /// JSX source code for the interface screen module
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compiled")]
        public string? Compiled { get; set; }

        /// <summary>
        /// Sample task data for preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sample")]
        public object? DataSample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema declaring expected task data field types for import validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Chat conversation history
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public object? Messages { get; set; }

        /// <summary>
        /// Arbitrary metadata for this interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// JSON Schema declaring the annotation output fields this interface produces (for Prompter/auto-labeling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Code version history
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public object? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseInterfaceRequest" /> class.
        /// </summary>
        /// <param name="artifacts">
        /// AI-produced code snapshots for session continuity
        /// </param>
        /// <param name="code">
        /// JSX source code for the interface screen module
        /// </param>
        /// <param name="compiled"></param>
        /// <param name="dataSample">
        /// Sample task data for preview
        /// </param>
        /// <param name="description"></param>
        /// <param name="inputSchema">
        /// JSON Schema declaring expected task data field types for import validation
        /// </param>
        /// <param name="messages">
        /// Chat conversation history
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata for this interface
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema declaring the annotation output fields this interface produces (for Prompter/auto-labeling)
        /// </param>
        /// <param name="title"></param>
        /// <param name="versions">
        /// Code version history
        /// </param>
        /// <param name="workspace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLseInterfaceRequest(
            object? artifacts,
            string? code,
            string? compiled,
            object? dataSample,
            string? description,
            object? inputSchema,
            object? messages,
            object? metadata,
            object? outputSchema,
            string? title,
            object? versions,
            int? workspace)
        {
            this.Artifacts = artifacts;
            this.Code = code;
            this.Compiled = compiled;
            this.DataSample = dataSample;
            this.Description = description;
            this.InputSchema = inputSchema;
            this.Messages = messages;
            this.Metadata = metadata;
            this.OutputSchema = outputSchema;
            this.Title = title;
            this.Versions = versions;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseInterfaceRequest" /> class.
        /// </summary>
        public PatchedLseInterfaceRequest()
        {
        }
    }
}