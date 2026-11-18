
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RestoreRequestRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        /// Default Value: course
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.CourseHistoryScopeEnumJsonConverter))]
        public global::LabelStudio.CourseHistoryScopeEnum? Scope { get; set; }

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
        /// Initializes a new instance of the <see cref="RestoreRequestRequest" /> class.
        /// </summary>
        /// <param name="structureVersion"></param>
        /// <param name="pageId"></param>
        /// <param name="scope">
        /// Default Value: course
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreRequestRequest(
            int structureVersion,
            string? pageId,
            global::LabelStudio.CourseHistoryScopeEnum? scope)
        {
            this.PageId = pageId;
            this.Scope = scope;
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreRequestRequest" /> class.
        /// </summary>
        public RestoreRequestRequest()
        {
        }

    }
}