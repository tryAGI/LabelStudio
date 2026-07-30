
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendInviteRequest
    {
        /// <summary>
        /// Email addresses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Project IDs to grant access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<int>? Projects { get; set; }

        /// <summary>
        /// Organization role. Required unless user_type is viewonly.<br/>
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
        /// Seat type for the invited members. View-Only members are free read-only seats scoped to the invited projects/workspaces and cannot be combined with a role.<br/>
        /// * `standard` - Standard<br/>
        /// * `flex` - Flex<br/>
        /// * `viewonly` - View Only<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AssignableUserTypeEnumJsonConverter))]
        public global::LabelStudio.AssignableUserTypeEnum? UserType { get; set; }

        /// <summary>
        /// Workspace IDs to grant access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<int>? Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInviteRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses
        /// </param>
        /// <param name="projects">
        /// Project IDs to grant access to
        /// </param>
        /// <param name="role">
        /// Organization role. Required unless user_type is viewonly.<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userType">
        /// Seat type for the invited members. View-Only members are free read-only seats scoped to the invited projects/workspaces and cannot be combined with a role.<br/>
        /// * `standard` - Standard<br/>
        /// * `flex` - Flex<br/>
        /// * `viewonly` - View Only<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="workspaces">
        /// Workspace IDs to grant access to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendInviteRequest(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<int>? projects,
            global::LabelStudio.AssignableOrganizationRoleEnum? role,
            global::LabelStudio.AssignableUserTypeEnum? userType,
            global::System.Collections.Generic.IList<int>? workspaces)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Projects = projects;
            this.Role = role;
            this.UserType = userType;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInviteRequest" /> class.
        /// </summary>
        public SendInviteRequest()
        {
        }

    }
}