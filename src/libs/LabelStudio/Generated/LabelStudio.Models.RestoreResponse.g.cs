
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RestoreResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_restore_pin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.HistoryPin BeforeRestorePin { get; set; }

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
        /// Newest revision after the restore; null when the restore changed nothing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored_ref")]
        public string? RestoredRef { get; set; }

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
        /// Initializes a new instance of the <see cref="RestoreResponse" /> class.
        /// </summary>
        /// <param name="beforeRestorePin"></param>
        /// <param name="modules"></param>
        /// <param name="outline"></param>
        /// <param name="structureVersion"></param>
        /// <param name="restoredRef">
        /// Newest revision after the restore; null when the restore changed nothing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreResponse(
            global::LabelStudio.HistoryPin beforeRestorePin,
            global::System.Collections.Generic.IList<global::LabelStudio.CourseModule> modules,
            global::LabelStudio.CourseOutline outline,
            int structureVersion,
            string? restoredRef)
        {
            this.BeforeRestorePin = beforeRestorePin ?? throw new global::System.ArgumentNullException(nameof(beforeRestorePin));
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.Outline = outline ?? throw new global::System.ArgumentNullException(nameof(outline));
            this.RestoredRef = restoredRef;
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreResponse" /> class.
        /// </summary>
        public RestoreResponse()
        {
        }

    }
}