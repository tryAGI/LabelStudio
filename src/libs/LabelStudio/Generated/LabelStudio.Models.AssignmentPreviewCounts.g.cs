
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignmentPreviewCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("already_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AlreadyOn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch_empty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SwitchEmpty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch_with_instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SwitchWithInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewCounts" /> class.
        /// </summary>
        /// <param name="alreadyOn"></param>
        /// <param name="switchEmpty"></param>
        /// <param name="switchWithInstructions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignmentPreviewCounts(
            int alreadyOn,
            int switchEmpty,
            int switchWithInstructions)
        {
            this.AlreadyOn = alreadyOn;
            this.SwitchEmpty = switchEmpty;
            this.SwitchWithInstructions = switchWithInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewCounts" /> class.
        /// </summary>
        public AssignmentPreviewCounts()
        {
        }

    }
}