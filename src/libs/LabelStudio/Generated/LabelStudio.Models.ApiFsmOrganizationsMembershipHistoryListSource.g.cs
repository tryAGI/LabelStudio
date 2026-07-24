
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiFsmOrganizationsMembershipHistoryListSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Ldap,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Scim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiFsmOrganizationsMembershipHistoryListSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiFsmOrganizationsMembershipHistoryListSource value)
        {
            return value switch
            {
                ApiFsmOrganizationsMembershipHistoryListSource.Api => "api",
                ApiFsmOrganizationsMembershipHistoryListSource.Billing => "billing",
                ApiFsmOrganizationsMembershipHistoryListSource.Ldap => "ldap",
                ApiFsmOrganizationsMembershipHistoryListSource.Manual => "manual",
                ApiFsmOrganizationsMembershipHistoryListSource.Saml => "saml",
                ApiFsmOrganizationsMembershipHistoryListSource.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiFsmOrganizationsMembershipHistoryListSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => ApiFsmOrganizationsMembershipHistoryListSource.Api,
                "billing" => ApiFsmOrganizationsMembershipHistoryListSource.Billing,
                "ldap" => ApiFsmOrganizationsMembershipHistoryListSource.Ldap,
                "manual" => ApiFsmOrganizationsMembershipHistoryListSource.Manual,
                "saml" => ApiFsmOrganizationsMembershipHistoryListSource.Saml,
                "scim" => ApiFsmOrganizationsMembershipHistoryListSource.Scim,
                _ => null,
            };
        }
    }
}