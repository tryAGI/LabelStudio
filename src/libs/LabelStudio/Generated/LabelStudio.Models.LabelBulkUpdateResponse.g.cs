
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelBulkUpdateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationsUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelBulkUpdateResponse" /> class.
        /// </summary>
        /// <param name="annotationsUpdated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelBulkUpdateResponse(
            int annotationsUpdated)
        {
            this.AnnotationsUpdated = annotationsUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelBulkUpdateResponse" /> class.
        /// </summary>
        public LabelBulkUpdateResponse()
        {
        }

    }
}