
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// One organization member, with the reason they do or do not occupy a paid seat.<br/>
    /// Serializes an ``OrganizationMember`` annotated with ``counts_toward_seat_limit`` and<br/>
    /// ``has_stale_role_assignments``; assignment records come from the batch-loaded<br/>
    /// ``assignment_index`` in the serializer context (never queried per row).
    /// </summary>
    public sealed partial class SeatReport
    {
        /// <summary>
        /// Whether the account can log in. Does NOT by itself decide the seat — the organization role does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AccountIsActive { get; set; }

        /// <summary>
        /// Whether this membership occupies a standard (paid) seat, using the same predicate as billing. Service accounts and View-Only seats are licensed separately and do not count here. Note this is per membership, while the licence counts distinct users (instance-wide on-prem), so summing this column is an upper bound on the invoice, not the invoice.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts_toward_seat_limit")]
        public bool CountsTowardSeatLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// True when any role assignment is orphaned or missing its membership link — the usual cause of stale seats<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_stale_role_assignments")]
        public bool HasStaleRoleAssignments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// Effective organization role code<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role")]
        public string? OrganizationRole { get; set; }

        /// <summary>
        /// Group assignments that can put this user on an organization role (and therefore a seat)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role_assignments")]
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment> OrganizationRoleAssignments { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role_display")]
        public string? OrganizationRoleDisplay { get; set; }

        /// <summary>
        /// Group assignments scoped to a project. Never affect the seat count.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_role_assignments")]
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment> ProjectRoleAssignments { get; set; } = default!;

        /// <summary>
        /// What set the role: manual, saml, scim, ldap, api, billing<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_source")]
        public string? RoleSource { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_source_display")]
        public string? RoleSourceDisplay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// standard, service or viewonly<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_type")]
        public string? UserType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_type_display")]
        public string? UserTypeDisplay { get; set; }

        /// <summary>
        /// Group assignments granting workspace access only. Never affect the seat count.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_access_assignments")]
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment> WorkspaceAccessAssignments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeatReport" /> class.
        /// </summary>
        /// <param name="accountIsActive">
        /// Whether the account can log in. Does NOT by itself decide the seat — the organization role does.
        /// </param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userId"></param>
        /// <param name="organizationRole">
        /// Effective organization role code<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organizationRoleDisplay">
        /// Included only in responses
        /// </param>
        /// <param name="roleSource">
        /// What set the role: manual, saml, scim, ldap, api, billing<br/>
        /// Included only in responses
        /// </param>
        /// <param name="roleSourceDisplay">
        /// Included only in responses
        /// </param>
        /// <param name="userType">
        /// standard, service or viewonly<br/>
        /// Included only in responses
        /// </param>
        /// <param name="userTypeDisplay">
        /// Included only in responses
        /// </param>
        /// <param name="countsTowardSeatLimit">
        /// Whether this membership occupies a standard (paid) seat, using the same predicate as billing. Service accounts and View-Only seats are licensed separately and do not count here. Note this is per membership, while the licence counts distinct users (instance-wide on-prem), so summing this column is an upper bound on the invoice, not the invoice.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="hasStaleRoleAssignments">
        /// True when any role assignment is orphaned or missing its membership link — the usual cause of stale seats<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organizationRoleAssignments">
        /// Group assignments that can put this user on an organization role (and therefore a seat)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projectRoleAssignments">
        /// Group assignments scoped to a project. Never affect the seat count.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="workspaceAccessAssignments">
        /// Group assignments granting workspace access only. Never affect the seat count.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeatReport(
            bool accountIsActive,
            string email,
            string firstName,
            string lastName,
            int userId,
            string? organizationRole,
            string? organizationRoleDisplay,
            string? roleSource,
            string? roleSourceDisplay,
            string? userType,
            string? userTypeDisplay,
            bool countsTowardSeatLimit = default!,
            bool hasStaleRoleAssignments = default!,
            global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment> organizationRoleAssignments = default!,
            global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment> projectRoleAssignments = default!,
            global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment> workspaceAccessAssignments = default!)
        {
            this.AccountIsActive = accountIsActive;
            this.CountsTowardSeatLimit = countsTowardSeatLimit;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.HasStaleRoleAssignments = hasStaleRoleAssignments;
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.OrganizationRole = organizationRole;
            this.OrganizationRoleAssignments = organizationRoleAssignments;
            this.OrganizationRoleDisplay = organizationRoleDisplay;
            this.ProjectRoleAssignments = projectRoleAssignments;
            this.RoleSource = roleSource;
            this.RoleSourceDisplay = roleSourceDisplay;
            this.UserId = userId;
            this.UserType = userType;
            this.UserTypeDisplay = userTypeDisplay;
            this.WorkspaceAccessAssignments = workspaceAccessAssignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeatReport" /> class.
        /// </summary>
        public SeatReport()
        {
        }

    }
}