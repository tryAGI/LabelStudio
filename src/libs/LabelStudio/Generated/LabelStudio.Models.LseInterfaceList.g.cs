
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseInterfaceList
    {
        /// <summary>
        /// JSX source code for the interface screen module
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::LabelStudio.UserSimple CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// JSON Schema declaring expected task data field types for import validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// HumanSignal-provided system template visible to all organizations<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_system")]
        public bool IsSystem { get; set; } = default!;

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
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_count")]
        public int ProjectsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public string Versions { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LseInterfaceList" /> class.
        /// </summary>
        /// <param name="code">
        /// JSX source code for the interface screen module
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="inputSchema">
        /// JSON Schema declaring expected task data field types for import validation
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata for this interface
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema declaring the annotation output fields this interface produces (for Prompter/auto-labeling)
        /// </param>
        /// <param name="workspace"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="isSystem">
        /// HumanSignal-provided system template visible to all organizations<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projectsCount">
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="versions">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceList(
            string code,
            string title,
            string? description,
            object? inputSchema,
            object? metadata,
            object? outputSchema,
            int? workspace,
            global::System.DateTime createdAt = default!,
            global::LabelStudio.UserSimple createdBy = default!,
            int id = default!,
            bool isSystem = default!,
            int projectsCount = default!,
            global::System.DateTime updatedAt = default!,
            string versions = default!)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.InputSchema = inputSchema;
            this.IsSystem = isSystem;
            this.Metadata = metadata;
            this.OutputSchema = outputSchema;
            this.ProjectsCount = projectsCount;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Versions = versions;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceList" /> class.
        /// </summary>
        public LseInterfaceList()
        {
        }
    }
}