
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseFields
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
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_notification_settings")]
        public object EmailNotificationSettings { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_activated")]
        public bool? InviteActivated { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_expired")]
        public bool? InviteExpired { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_expired_at")]
        public global::System.DateTime? InviteExpiredAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        public global::System.DateTime? InvitedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by")]
        public int? InvitedBy { get; set; }

        /// <summary>
        /// The current stage of user onboarding<br/>
        /// * `not_started` - Not Started<br/>
        /// * `signup` - Signup<br/>
        /// * `trial_signup` - Trial Signup<br/>
        /// * `first_tutorial` - First Tutorial<br/>
        /// * `in_app_guidance` - In App Guidance<br/>
        /// * `complete` - Complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter))]
        public global::LabelStudio.OnboardingStateEnum? OnboardingState { get; set; }

        /// <summary>
        /// Is user finished social authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_auth_finished")]
        public bool? SocialAuthFinished { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_company")]
        public string? TrialCompany { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_experience_labeling")]
        public string? TrialExperienceLabeling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_license_enterprise")]
        public bool? TrialLicenseEnterprise { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_models_in_production")]
        public string? TrialModelsInProduction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter))]
        public global::LabelStudio.TrialRoleEnum? TrialRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseFields" /> class.
        /// </summary>
        /// <param name="inviteActivated"></param>
        /// <param name="inviteExpired">
        /// Included only in responses
        /// </param>
        /// <param name="inviteExpiredAt">
        /// Included only in responses
        /// </param>
        /// <param name="invitedAt"></param>
        /// <param name="invitedBy"></param>
        /// <param name="onboardingState">
        /// The current stage of user onboarding<br/>
        /// * `not_started` - Not Started<br/>
        /// * `signup` - Signup<br/>
        /// * `trial_signup` - Trial Signup<br/>
        /// * `first_tutorial` - First Tutorial<br/>
        /// * `in_app_guidance` - In App Guidance<br/>
        /// * `complete` - Complete
        /// </param>
        /// <param name="socialAuthFinished">
        /// Is user finished social authentication
        /// </param>
        /// <param name="trialCompany"></param>
        /// <param name="trialExperienceLabeling"></param>
        /// <param name="trialLicenseEnterprise"></param>
        /// <param name="trialModelsInProduction"></param>
        /// <param name="trialRole"></param>
        /// <param name="emailNotificationSettings">
        /// Get email notification settings with organization-level filtering.<br/>
        /// Use the model's getter method to ensure all notification types are included<br/>
        /// with proper defaults for any missing types. Transform the output to include<br/>
        /// both value and label for each notification type.<br/>
        /// Filter notifications based on organization's allowed notifications if user<br/>
        /// belongs to exactly one organization.<br/>
        /// Role-based filtering: not_activated_user_login is only available to users<br/>
        /// who are admins or owners in at least one organization.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseFields(
            bool? inviteActivated,
            bool? inviteExpired,
            global::System.DateTime? inviteExpiredAt,
            global::System.DateTime? invitedAt,
            int? invitedBy,
            global::LabelStudio.OnboardingStateEnum? onboardingState,
            bool? socialAuthFinished,
            string? trialCompany,
            string? trialExperienceLabeling,
            bool? trialLicenseEnterprise,
            string? trialModelsInProduction,
            global::LabelStudio.TrialRoleEnum? trialRole,
            object emailNotificationSettings = default!)
        {
            this.EmailNotificationSettings = emailNotificationSettings;
            this.InviteActivated = inviteActivated;
            this.InviteExpired = inviteExpired;
            this.InviteExpiredAt = inviteExpiredAt;
            this.InvitedAt = invitedAt;
            this.InvitedBy = invitedBy;
            this.OnboardingState = onboardingState;
            this.SocialAuthFinished = socialAuthFinished;
            this.TrialCompany = trialCompany;
            this.TrialExperienceLabeling = trialExperienceLabeling;
            this.TrialLicenseEnterprise = trialLicenseEnterprise;
            this.TrialModelsInProduction = trialModelsInProduction;
            this.TrialRole = trialRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseFields" /> class.
        /// </summary>
        public LseFields()
        {
        }

    }
}