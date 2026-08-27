
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Workspace access granted by a group. Carries no role and never affects the seat count.
    /// </summary>
    public sealed partial class WorkspaceAccessAssignment
    {
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
        /// Null when the record has no linked membership
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_title")]
        public string? WorkspaceTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAccessAssignment" /> class.
        /// </summary>
        /// <param name="assignmentId">
        /// Primary key of the assignment record
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="identityProviderGroup">
        /// Name of the group in the identity provider (Okta/Entra) that created this record
        /// </param>
        /// <param name="linkedMembershipId">
        /// Membership this assignment is attached to; null means an incomplete record
        /// </param>
        /// <param name="workspaceId">
        /// Null when the record has no linked membership
        /// </param>
        /// <param name="workspaceTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceAccessAssignment(
            int assignmentId,
            global::System.DateTime createdAt,
            string? identityProviderGroup,
            int? linkedMembershipId,
            int? workspaceId,
            string? workspaceTitle)
        {
            this.AssignmentId = assignmentId;
            this.CreatedAt = createdAt;
            this.IdentityProviderGroup = identityProviderGroup;
            this.LinkedMembershipId = linkedMembershipId;
            this.WorkspaceId = workspaceId;
            this.WorkspaceTitle = workspaceTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAccessAssignment" /> class.
        /// </summary>
        public WorkspaceAccessAssignment()
        {
        }

    }
}