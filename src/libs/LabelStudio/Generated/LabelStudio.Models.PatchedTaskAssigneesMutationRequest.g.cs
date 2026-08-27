
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedTaskAssigneesMutationRequest
    {
        /// <summary>
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AssignmentTypeEnumJsonConverter))]
        public global::LabelStudio.AssignmentTypeEnum? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<int>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskAssigneesMutationRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </param>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedTaskAssigneesMutationRequest(
            global::LabelStudio.AssignmentTypeEnum? type,
            global::System.Collections.Generic.IList<int>? users)
        {
            this.Type = type;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskAssigneesMutationRequest" /> class.
        /// </summary>
        public PatchedTaskAssigneesMutationRequest()
        {
        }

    }
}