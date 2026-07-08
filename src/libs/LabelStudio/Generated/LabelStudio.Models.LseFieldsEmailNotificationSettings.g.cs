
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Get email notification settings with organization-level filtering.<br/>
    /// Use the model's getter method to ensure all notification types are included<br/>
    /// with proper defaults for any missing types. Transform the output to include<br/>
    /// both value and label for each notification type.<br/>
    /// Filter notifications based on organization's allowed notifications if user<br/>
    /// belongs to exactly one organization.<br/>
    /// Role-based filtering: not_activated_user_login is only available to users<br/>
    /// who are admins or owners in at least one organization.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class LseFieldsEmailNotificationSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}