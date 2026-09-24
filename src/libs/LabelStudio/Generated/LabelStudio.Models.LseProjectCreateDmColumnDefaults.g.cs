
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Soft Data Manager column visibility and order defaults. Returned on project reads for every role so Data Manager can apply them at runtime; Managers and above may set this. explore is the main grid (shared order, role-keyed visible lists). labeling is reserved for independent Quick View defaults. On update, omitted surfaces keep their stored values; send null to clear both surfaces.
    /// </summary>
    public sealed partial class LseProjectCreateDmColumnDefaults
    {
        /// <summary>
        /// Main Data Manager grid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explore")]
        public global::LabelStudio.LseProjectCreateDmColumnDefaultsExplore? Explore { get; set; }

        /// <summary>
        /// Quick View (reserved).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labeling")]
        public global::LabelStudio.LseProjectCreateDmColumnDefaultsLabeling? Labeling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCreateDmColumnDefaults" /> class.
        /// </summary>
        /// <param name="explore">
        /// Main Data Manager grid.
        /// </param>
        /// <param name="labeling">
        /// Quick View (reserved).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseProjectCreateDmColumnDefaults(
            global::LabelStudio.LseProjectCreateDmColumnDefaultsExplore? explore,
            global::LabelStudio.LseProjectCreateDmColumnDefaultsLabeling? labeling)
        {
            this.Explore = explore;
            this.Labeling = labeling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCreateDmColumnDefaults" /> class.
        /// </summary>
        public LseProjectCreateDmColumnDefaults()
        {
        }

    }
}