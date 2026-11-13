
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedDefaultRoleRequest
    {
        /// <summary>
        /// Default membership role for invited users<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.DefaultRoleDefaultRoleEnumJsonConverter))]
        public global::LabelStudio.DefaultRoleDefaultRoleEnum? DefaultRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDefaultRoleRequest" /> class.
        /// </summary>
        /// <param name="defaultRole">
        /// Default membership role for invited users<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `NO` - Not Activated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDefaultRoleRequest(
            global::LabelStudio.DefaultRoleDefaultRoleEnum? defaultRole)
        {
            this.DefaultRole = defaultRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDefaultRoleRequest" /> class.
        /// </summary>
        public PatchedDefaultRoleRequest()
        {
        }

    }
}