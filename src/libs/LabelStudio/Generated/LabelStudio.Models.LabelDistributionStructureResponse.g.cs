
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionStructureResponse
    {
        /// <summary>
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice_keys")]
        public string ChoiceKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension> Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        /// <param name="choiceKeys">
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dimensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionStructureResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension> dimensions,
            string choiceKeys = default!)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.ChoiceKeys = choiceKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        public LabelDistributionStructureResponse()
        {
        }
    }
}