
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoursePageSaveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageVersion { get; set; }

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
        /// Initializes a new instance of the <see cref="CoursePageSaveResponse" /> class.
        /// </summary>
        /// <param name="pageVersion"></param>
        /// <param name="structureVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoursePageSaveResponse(
            int pageVersion,
            int structureVersion)
        {
            this.PageVersion = pageVersion;
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoursePageSaveResponse" /> class.
        /// </summary>
        public CoursePageSaveResponse()
        {
        }

    }
}