
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// The file of the latest SUBMITTED annotation, for the collection grid.<br/>
    /// Read from the annotation (the submission's source of truth); the task<br/>
    /// itself carries only the brief.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class LseTaskSerializerForReviewersSubmission
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}