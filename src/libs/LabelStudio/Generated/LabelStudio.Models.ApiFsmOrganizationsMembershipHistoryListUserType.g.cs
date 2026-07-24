
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiFsmOrganizationsMembershipHistoryListUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Viewonly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiFsmOrganizationsMembershipHistoryListUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiFsmOrganizationsMembershipHistoryListUserType value)
        {
            return value switch
            {
                ApiFsmOrganizationsMembershipHistoryListUserType.Service => "service",
                ApiFsmOrganizationsMembershipHistoryListUserType.Standard => "standard",
                ApiFsmOrganizationsMembershipHistoryListUserType.Viewonly => "viewonly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiFsmOrganizationsMembershipHistoryListUserType? ToEnum(string value)
        {
            return value switch
            {
                "service" => ApiFsmOrganizationsMembershipHistoryListUserType.Service,
                "standard" => ApiFsmOrganizationsMembershipHistoryListUserType.Standard,
                "viewonly" => ApiFsmOrganizationsMembershipHistoryListUserType.Viewonly,
                _ => null,
            };
        }
    }
}