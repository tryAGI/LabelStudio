
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseInterfaceList
    {
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
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_count")]
        public int ProjectsCount { get; set; } = default!;

        /// <summary>
        /// Number of published versions for list cards (derived from versions JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_versions_count")]
        public int? PublishedVersionsCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// CamelCase screen component name for list cards (derived from code)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_name")]
        public string? TypeName { get; set; }

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
        public global::System.Collections.Generic.IList<object> Versions { get; set; } = default!;

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
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="metadata">
        /// Arbitrary metadata for this interface
        /// </param>
        /// <param name="publishedVersionsCount">
        /// Number of published versions for list cards (derived from versions JSON)
        /// </param>
        /// <param name="typeName">
        /// CamelCase screen component name for list cards (derived from code)
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
            string title,
            string? description,
            object? metadata,
            int? publishedVersionsCount,
            string? typeName,
            int? workspace,
            global::System.DateTime createdAt = default!,
            global::LabelStudio.UserSimple createdBy = default!,
            int id = default!,
            bool isSystem = default!,
            int projectsCount = default!,
            global::System.DateTime updatedAt = default!,
            global::System.Collections.Generic.IList<object> versions = default!)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.IsSystem = isSystem;
            this.Metadata = metadata;
            this.ProjectsCount = projectsCount;
            this.PublishedVersionsCount = publishedVersionsCount;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TypeName = typeName;
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

        /// <summary>
        /// Creates a new <see cref="LseInterfaceList"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LseInterfaceList FromTitle(string title)
        {
            return new LseInterfaceList
            {
                Title = title,
            };
        }

    }
}