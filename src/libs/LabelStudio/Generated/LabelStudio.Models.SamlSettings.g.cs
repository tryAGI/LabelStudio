
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer for reading SAML settings (GET requests).<br/>
    /// Includes all model fields plus computed read-only fields for SP URLs<br/>
    /// that are needed for IdP configuration.
    /// </summary>
    public sealed partial class SamlSettings
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acs_url")]
        public string? AcsUrl { get; set; }

        /// <summary>
        /// Organization web domain or domains; use comma separated list with no spaces for multiple. Example:labelstud.io,humansignal.comIMPORTANT: DO NOT PUT COMMON DOMAINS LIKE GMAIL.COM, YAHOO.COM, ETC. IN THIS FIELD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Identity Provider preset key (e.g. okta, azure, google, custom)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_provider")]
        public string? IdpProvider { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login_url")]
        public string? LoginUrl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout_url")]
        public string? LogoutUrl { get; set; }

        /// <summary>
        /// Allow manually assigning organization roles instead of IdP-managed groups. None = use billing default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_role_management")]
        public bool? ManualRoleManagement { get; set; }

        /// <summary>
        /// Mapping attributes: user email from SAML request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_email")]
        public string? MappingEmail { get; set; }

        /// <summary>
        /// Mapping attributes: user first name from SAML request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_first_name")]
        public string? MappingFirstName { get; set; }

        /// <summary>
        /// Mapping attributes: groups attribute for user mapping to workspaces and roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_groups")]
        public string? MappingGroups { get; set; }

        /// <summary>
        /// Mapping attributes: user last name from SAML request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping_last_name")]
        public string? MappingLastName { get; set; }

        /// <summary>
        /// URL SAML metadata from IdP
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// Metadata XML file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml_url")]
        public string? MetadataXmlUrl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameid_format")]
        public string NameidFormat { get; set; } = default!;

        /// <summary>
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_groups")]
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>? ProjectsGroups { get; set; }

        /// <summary>
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? RolesGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? WorkspacesGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSettings" /> class.
        /// </summary>
        /// <param name="acsUrl">
        /// Included only in responses
        /// </param>
        /// <param name="domain">
        /// Organization web domain or domains; use comma separated list with no spaces for multiple. Example:labelstud.io,humansignal.comIMPORTANT: DO NOT PUT COMMON DOMAINS LIKE GMAIL.COM, YAHOO.COM, ETC. IN THIS FIELD
        /// </param>
        /// <param name="idpProvider">
        /// Identity Provider preset key (e.g. okta, azure, google, custom)
        /// </param>
        /// <param name="loginUrl">
        /// Included only in responses
        /// </param>
        /// <param name="logoutUrl">
        /// Included only in responses
        /// </param>
        /// <param name="manualRoleManagement">
        /// Allow manually assigning organization roles instead of IdP-managed groups. None = use billing default.
        /// </param>
        /// <param name="mappingEmail">
        /// Mapping attributes: user email from SAML request
        /// </param>
        /// <param name="mappingFirstName">
        /// Mapping attributes: user first name from SAML request
        /// </param>
        /// <param name="mappingGroups">
        /// Mapping attributes: groups attribute for user mapping to workspaces and roles
        /// </param>
        /// <param name="mappingLastName">
        /// Mapping attributes: user last name from SAML request
        /// </param>
        /// <param name="metadataUrl">
        /// URL SAML metadata from IdP
        /// </param>
        /// <param name="metadataXml">
        /// Metadata XML file
        /// </param>
        /// <param name="metadataXmlUrl">
        /// Included only in responses
        /// </param>
        /// <param name="projectsGroups">
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </param>
        /// <param name="rolesGroups">
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </param>
        /// <param name="token"></param>
        /// <param name="workspacesGroups">
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </param>
        /// <param name="nameidFormat">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamlSettings(
            string? acsUrl,
            string? domain,
            string? idpProvider,
            string? loginUrl,
            string? logoutUrl,
            bool? manualRoleManagement,
            string? mappingEmail,
            string? mappingFirstName,
            string? mappingGroups,
            string? mappingLastName,
            string? metadataUrl,
            string? metadataXml,
            string? metadataXmlUrl,
            global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>? projectsGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rolesGroups,
            string? token,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? workspacesGroups,
            string nameidFormat = default!)
        {
            this.AcsUrl = acsUrl;
            this.Domain = domain;
            this.IdpProvider = idpProvider;
            this.LoginUrl = loginUrl;
            this.LogoutUrl = logoutUrl;
            this.ManualRoleManagement = manualRoleManagement;
            this.MappingEmail = mappingEmail;
            this.MappingFirstName = mappingFirstName;
            this.MappingGroups = mappingGroups;
            this.MappingLastName = mappingLastName;
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
            this.MetadataXmlUrl = metadataXmlUrl;
            this.NameidFormat = nameidFormat;
            this.ProjectsGroups = projectsGroups;
            this.RolesGroups = rolesGroups;
            this.Token = token;
            this.WorkspacesGroups = workspacesGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSettings" /> class.
        /// </summary>
        public SamlSettings()
        {
        }
    }
}