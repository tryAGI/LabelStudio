
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseOutline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule> Modules { get; set; }

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
        /// Initializes a new instance of the <see cref="CourseOutline" /> class.
        /// </summary>
        /// <param name="modules"></param>
        /// <param name="structureVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseOutline(
            global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule> modules,
            int structureVersion)
        {
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseOutline" /> class.
        /// </summary>
        public CourseOutline()
        {
        }

    }
}