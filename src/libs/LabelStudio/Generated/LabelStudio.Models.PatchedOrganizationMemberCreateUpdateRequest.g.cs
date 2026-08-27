
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedOrganizationMemberCreateUpdateRequest
    {
        /// <summary>
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumJsonConverter))]
        public global::LabelStudio.AssignableOrganizationRoleEnum? Role { get; set; }

        /// <summary>
        /// Member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Membership seat type. Assigning a working role to a View-Only member upgrades them to a paid Standard seat. View-Only is not accepted because paid-to-View-Only downgrade is not supported.<br/>
        /// * `standard` - Standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.StandardUserTypeEnumJsonConverter))]
        public global::LabelStudio.StandardUserTypeEnum? UserType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationMemberCreateUpdateRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userId">
        /// Member
        /// </param>
        /// <param name="userType">
        /// Membership seat type. Assigning a working role to a View-Only member upgrades them to a paid Standard seat. View-Only is not accepted because paid-to-View-Only downgrade is not supported.<br/>
        /// * `standard` - Standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedOrganizationMemberCreateUpdateRequest(
            global::LabelStudio.AssignableOrganizationRoleEnum? role,
            int? userId,
            global::LabelStudio.StandardUserTypeEnum? userType)
        {
            this.Role = role;
            this.UserId = userId;
            this.UserType = userType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationMemberCreateUpdateRequest" /> class.
        /// </summary>
        public PatchedOrganizationMemberCreateUpdateRequest()
        {
        }

    }
}