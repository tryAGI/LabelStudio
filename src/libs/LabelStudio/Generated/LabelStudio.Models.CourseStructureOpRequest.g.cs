
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseStructureOpRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest_index")]
        public int? DestIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest_module_id")]
        public int? DestModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_id")]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_ids")]
        public global::System.Collections.Generic.IList<int>? ModuleIds { get; set; }

        /// <summary>
        /// * `add_page` - add_page<br/>
        /// * `delete_page` - delete_page<br/>
        /// * `duplicate_page` - duplicate_page<br/>
        /// * `reorder_pages` - reorder_pages<br/>
        /// * `move_page` - move_page<br/>
        /// * `add_module` - add_module<br/>
        /// * `delete_module` - delete_module<br/>
        /// * `duplicate_module` - duplicate_module<br/>
        /// * `reorder_modules` - reorder_modules<br/>
        /// * `rename_module` - rename_module
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OpEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.OpEnum Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_module_id")]
        public int? SourceModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StructureVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_index")]
        public int? ToIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseStructureOpRequest" /> class.
        /// </summary>
        /// <param name="op">
        /// * `add_page` - add_page<br/>
        /// * `delete_page` - delete_page<br/>
        /// * `duplicate_page` - duplicate_page<br/>
        /// * `reorder_pages` - reorder_pages<br/>
        /// * `move_page` - move_page<br/>
        /// * `add_module` - add_module<br/>
        /// * `delete_module` - delete_module<br/>
        /// * `duplicate_module` - duplicate_module<br/>
        /// * `reorder_modules` - reorder_modules<br/>
        /// * `rename_module` - rename_module
        /// </param>
        /// <param name="structureVersion"></param>
        /// <param name="destIndex"></param>
        /// <param name="destModuleId"></param>
        /// <param name="moduleId"></param>
        /// <param name="moduleIds"></param>
        /// <param name="pageId"></param>
        /// <param name="sourceModuleId"></param>
        /// <param name="title"></param>
        /// <param name="toIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseStructureOpRequest(
            global::LabelStudio.OpEnum op,
            int structureVersion,
            int? destIndex,
            int? destModuleId,
            int? moduleId,
            global::System.Collections.Generic.IList<int>? moduleIds,
            string? pageId,
            int? sourceModuleId,
            string? title,
            int? toIndex)
        {
            this.DestIndex = destIndex;
            this.DestModuleId = destModuleId;
            this.ModuleId = moduleId;
            this.ModuleIds = moduleIds;
            this.Op = op;
            this.PageId = pageId;
            this.SourceModuleId = sourceModuleId;
            this.StructureVersion = structureVersion;
            this.Title = title;
            this.ToIndex = toIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseStructureOpRequest" /> class.
        /// </summary>
        public CourseStructureOpRequest()
        {
        }

    }
}