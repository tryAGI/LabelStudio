
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseStructureOpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_id")]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.CourseModule> Modules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.CourseOutline Outline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StructureVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseStructureOpResponse" /> class.
        /// </summary>
        /// <param name="modules"></param>
        /// <param name="outline"></param>
        /// <param name="structureVersion"></param>
        /// <param name="moduleId"></param>
        /// <param name="pageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseStructureOpResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.CourseModule> modules,
            global::LabelStudio.CourseOutline outline,
            int structureVersion,
            int? moduleId,
            string? pageId)
        {
            this.ModuleId = moduleId;
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.Outline = outline ?? throw new global::System.ArgumentNullException(nameof(outline));
            this.PageId = pageId;
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseStructureOpResponse" /> class.
        /// </summary>
        public CourseStructureOpResponse()
        {
        }

    }
}