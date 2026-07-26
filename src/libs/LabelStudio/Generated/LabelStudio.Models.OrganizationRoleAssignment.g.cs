
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// An organization-role assignment — the only kind that can put a user on a paid seat.
    /// </summary>
    public sealed partial class OrganizationRoleAssignment
    {
        /// <summary>
        /// Role code this group is mapped to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_role")]
        public string? AssignedRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_role_display")]
        public string? AssignedRoleDisplay { get; set; }

        /// <summary>
        /// Primary key of the assignment record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the group in the identity provider (Okta/Entra) that created this record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_group")]
        public string? IdentityProviderGroup { get; set; }

        /// <summary>
        /// Membership this assignment is attached to; null means an incomplete record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_membership_id")]
        public int? LinkedMembershipId { get; set; }

        /// <summary>
        /// configured = the group is still mapped in SCIM settings; orphaned = the mapping is gone but the record remains; missing_membership = the record is not linked to a membership<br/>
        /// * `configured` - Configured<br/>
        /// * `orphaned` - Orphaned<br/>
        /// * `missing_membership` - Missing membership
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.MappingStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.MappingStatusEnum MappingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_status_display")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MappingStatusDisplay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRoleAssignment" /> class.
        /// </summary>
        /// <param name="assignmentId">
        /// Primary key of the assignment record
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="mappingStatus">
        /// configured = the group is still mapped in SCIM settings; orphaned = the mapping is gone but the record remains; missing_membership = the record is not linked to a membership<br/>
        /// * `configured` - Configured<br/>
        /// * `orphaned` - Orphaned<br/>
        /// * `missing_membership` - Missing membership
        /// </param>
        /// <param name="mappingStatusDisplay"></param>
        /// <param name="assignedRole">
        /// Role code this group is mapped to
        /// </param>
        /// <param name="assignedRoleDisplay"></param>
        /// <param name="identityProviderGroup">
        /// Name of the group in the identity provider (Okta/Entra) that created this record
        /// </param>
        /// <param name="linkedMembershipId">
        /// Membership this assignment is attached to; null means an incomplete record
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationRoleAssignment(
            int assignmentId,
            global::System.DateTime createdAt,
            global::LabelStudio.MappingStatusEnum mappingStatus,
            string mappingStatusDisplay,
            string? assignedRole,
            string? assignedRoleDisplay,
            string? identityProviderGroup,
            int? linkedMembershipId)
        {
            this.AssignedRole = assignedRole;
            this.AssignedRoleDisplay = assignedRoleDisplay;
            this.AssignmentId = assignmentId;
            this.CreatedAt = createdAt;
            this.IdentityProviderGroup = identityProviderGroup;
            this.LinkedMembershipId = linkedMembershipId;
            this.MappingStatus = mappingStatus;
            this.MappingStatusDisplay = mappingStatusDisplay ?? throw new global::System.ArgumentNullException(nameof(mappingStatusDisplay));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRoleAssignment" /> class.
        /// </summary>
        public OrganizationRoleAssignment()
        {
        }

    }
}