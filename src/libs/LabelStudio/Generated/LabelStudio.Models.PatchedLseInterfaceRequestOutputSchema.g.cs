
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// JSON Schema declaring the annotation output fields this interface produces (for Prompter/auto-labeling)
    /// </summary>
    public sealed partial class PatchedLseInterfaceRequestOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}