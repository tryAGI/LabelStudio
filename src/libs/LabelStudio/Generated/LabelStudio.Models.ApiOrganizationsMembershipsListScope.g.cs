
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiOrganizationsMembershipsListScope
    {
        /// <summary>
        /// 
        /// </summary>
        Accessible,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiOrganizationsMembershipsListScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiOrganizationsMembershipsListScope value)
        {
            return value switch
            {
                ApiOrganizationsMembershipsListScope.Accessible => "accessible",
                ApiOrganizationsMembershipsListScope.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiOrganizationsMembershipsListScope? ToEnum(string value)
        {
            return value switch
            {
                "accessible" => ApiOrganizationsMembershipsListScope.Accessible,
                "all" => ApiOrganizationsMembershipsListScope.All,
                _ => null,
            };
        }
    }
}