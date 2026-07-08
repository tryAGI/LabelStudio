
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseOrganization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.OrganizationBilling Billing { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Enable custom interfaces for this organization. When disabled, projects with use_custom_interface=True will not render custom interfaces anywhere in the product (label stream, embed, data manager, interfaces dashboard).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_interfaces_enabled")]
        public bool? CustomInterfacesEnabled { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_scripts_enabled")]
        public bool CustomScriptsEnabled { get; set; } = default!;

        /// <summary>
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OrganizationRoleEnumJsonConverter))]
        public global::LabelStudio.OrganizationRoleEnum? DefaultRole { get; set; }

        /// <summary>
        /// Get email notification settings with default values for all notification types.<br/>
        /// Returns a dictionary with the following structure:<br/>
        /// {<br/>
        ///     'notifications_allowed': {<br/>
        ///         'notification_type': bool<br/>
        ///     },<br/>
        ///     'notification_types': [<br/>
        ///         {'value': str, 'label': str}<br/>
        ///     ]<br/>
        /// }<br/>
        /// Excludes blocklisted notification types and ensures all valid types are included<br/>
        /// with proper defaults for any missing types.<br/>
        /// When organization's email_notification_settings is null or empty, all notifications<br/>
        /// are shown as enabled (True) by default. When organization has some settings,<br/>
        /// unconfigured notifications default to False.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_notification_settings")]
        public object EmailNotificationSettings { get; set; } = default!;

        /// <summary>
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_domains")]
        public object? EmbedDomains { get; set; }

        /// <summary>
        /// Enable embed functionality for this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_enabled")]
        public bool? EmbedEnabled { get; set; }

        /// <summary>
        /// Embed settings for this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// External ID to uniquely identify this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Security settings for custom interfaces: CSP allowlists, script origins, iframe permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interface_settings")]
        public object? InterfaceSettings { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("react_code_settings")]
        public object ReactCodeSettings { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganization" /> class.
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="customInterfacesEnabled">
        /// Enable custom interfaces for this organization. When disabled, projects with use_custom_interface=True will not render custom interfaces anywhere in the product (label stream, embed, data manager, interfaces dashboard).
        /// </param>
        /// <param name="defaultRole">
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="embedDomains">
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </param>
        /// <param name="embedEnabled">
        /// Enable embed functionality for this organization
        /// </param>
        /// <param name="embedSettings">
        /// Embed settings for this organization
        /// </param>
        /// <param name="externalId">
        /// External ID to uniquely identify this organization
        /// </param>
        /// <param name="interfaceSettings">
        /// Security settings for custom interfaces: CSP allowlists, script origins, iframe permissions.
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="customScriptsEnabled">
        /// Included only in responses
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Get email notification settings with default values for all notification types.<br/>
        /// Returns a dictionary with the following structure:<br/>
        /// {<br/>
        ///     'notifications_allowed': {<br/>
        ///         'notification_type': bool<br/>
        ///     },<br/>
        ///     'notification_types': [<br/>
        ///         {'value': str, 'label': str}<br/>
        ///     ]<br/>
        /// }<br/>
        /// Excludes blocklisted notification types and ensures all valid types are included<br/>
        /// with proper defaults for any missing types.<br/>
        /// When organization's email_notification_settings is null or empty, all notifications<br/>
        /// are shown as enabled (True) by default. When organization has some settings,<br/>
        /// unconfigured notifications default to False.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="reactCodeSettings">
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Included only in responses
        /// </param>
        /// <param name="token">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseOrganization(
            global::LabelStudio.OrganizationBilling billing,
            bool? customInterfacesEnabled,
            global::LabelStudio.OrganizationRoleEnum? defaultRole,
            object? embedDomains,
            bool? embedEnabled,
            object? embedSettings,
            string? externalId,
            object? interfaceSettings,
            global::System.DateTime createdAt = default!,
            bool customScriptsEnabled = default!,
            object emailNotificationSettings = default!,
            int id = default!,
            object reactCodeSettings = default!,
            string title = default!,
            string token = default!)
        {
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
            this.CreatedAt = createdAt;
            this.CustomInterfacesEnabled = customInterfacesEnabled;
            this.CustomScriptsEnabled = customScriptsEnabled;
            this.DefaultRole = defaultRole;
            this.EmailNotificationSettings = emailNotificationSettings;
            this.EmbedDomains = embedDomains;
            this.EmbedEnabled = embedEnabled;
            this.EmbedSettings = embedSettings;
            this.ExternalId = externalId;
            this.Id = id;
            this.InterfaceSettings = interfaceSettings;
            this.ReactCodeSettings = reactCodeSettings;
            this.Title = title;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganization" /> class.
        /// </summary>
        public LseOrganization()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LseOrganization"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LseOrganization FromBilling(global::LabelStudio.OrganizationBilling billing)
        {
            return new LseOrganization
            {
                Billing = billing,
            };
        }

    }
}