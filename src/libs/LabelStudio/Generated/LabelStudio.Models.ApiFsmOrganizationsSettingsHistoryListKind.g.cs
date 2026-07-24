
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiFsmOrganizationsSettingsHistoryListKind
    {
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
    public static class ApiFsmOrganizationsSettingsHistoryListKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiFsmOrganizationsSettingsHistoryListKind value)
        {
            return value switch
            {
                ApiFsmOrganizationsSettingsHistoryListKind.Saml => "saml",
                ApiFsmOrganizationsSettingsHistoryListKind.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiFsmOrganizationsSettingsHistoryListKind? ToEnum(string value)
        {
            return value switch
            {
                "saml" => ApiFsmOrganizationsSettingsHistoryListKind.Saml,
                "scim" => ApiFsmOrganizationsSettingsHistoryListKind.Scim,
                _ => null,
            };
        }
    }
}