
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// User ID and user weight in score calculation. Format {user_id: weight} with weight in [0..1].
    /// </summary>
    public sealed partial class LseProjectParamsRequestAnnotatorParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}