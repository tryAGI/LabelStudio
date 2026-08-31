
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// The contributor's own submitted file, for the collection grid.<br/>
    /// Read from the annotation (the submission's source of truth); the task<br/>
    /// itself is untouched input.<br/>
    /// Scoped to the requester, exactly as ``get_annotations`` scopes the<br/>
    /// annotation list: a contributor sees the file they submitted and never<br/>
    /// another contributor's media. The column is only offered to annotators,<br/>
    /// so this is also the only case that renders.<br/>
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