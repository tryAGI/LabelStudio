
#nullable enable

namespace LabelStudio
{
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
    public sealed partial class LseOrganizationEmailNotificationSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}