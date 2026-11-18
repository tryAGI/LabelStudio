
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StructureVersionConflict
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.CourseOutline Outline { get; set; }

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
        /// Initializes a new instance of the <see cref="StructureVersionConflict" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="detail"></param>
        /// <param name="outline"></param>
        /// <param name="structureVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructureVersionConflict(
            string code,
            string detail,
            global::LabelStudio.CourseOutline outline,
            int structureVersion)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Outline = outline ?? throw new global::System.ArgumentNullException(nameof(outline));
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructureVersionConflict" /> class.
        /// </summary>
        public StructureVersionConflict()
        {
        }

    }
}