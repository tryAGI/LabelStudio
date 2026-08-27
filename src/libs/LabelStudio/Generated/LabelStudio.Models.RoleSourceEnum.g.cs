
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `manual` - Manual<br/>
    /// * `saml` - SAML<br/>
    /// * `scim` - SCIM<br/>
    /// * `ldap` - LDAP<br/>
    /// * `api` - API<br/>
    /// * `billing` - Billing
    /// </summary>
    public enum RoleSourceEnum
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
    public static class RoleSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoleSourceEnum value)
        {
            return value switch
            {
                RoleSourceEnum.Api => "api",
                RoleSourceEnum.Billing => "billing",
                RoleSourceEnum.Ldap => "ldap",
                RoleSourceEnum.Manual => "manual",
                RoleSourceEnum.Saml => "saml",
                RoleSourceEnum.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoleSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "api" => RoleSourceEnum.Api,
                "billing" => RoleSourceEnum.Billing,
                "ldap" => RoleSourceEnum.Ldap,
                "manual" => RoleSourceEnum.Manual,
                "saml" => RoleSourceEnum.Saml,
                "scim" => RoleSourceEnum.Scim,
                _ => null,
            };
        }
    }
}