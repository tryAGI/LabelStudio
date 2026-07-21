
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationPermissionRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Ad,
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        Di,
        /// <summary>
        /// 
        /// </summary>
        Ma,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Ow,
        /// <summary>
        /// 
        /// </summary>
        Re,
        /// <summary>
        /// 
        /// </summary>
        Vo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationPermissionRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationPermissionRoleEnum value)
        {
            return value switch
            {
                OrganizationPermissionRoleEnum.Ad => "AD",
                OrganizationPermissionRoleEnum.An => "AN",
                OrganizationPermissionRoleEnum.Di => "DI",
                OrganizationPermissionRoleEnum.Ma => "MA",
                OrganizationPermissionRoleEnum.No => "NO",
                OrganizationPermissionRoleEnum.Ow => "OW",
                OrganizationPermissionRoleEnum.Re => "RE",
                OrganizationPermissionRoleEnum.Vo => "VO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationPermissionRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => OrganizationPermissionRoleEnum.Ad,
                "AN" => OrganizationPermissionRoleEnum.An,
                "DI" => OrganizationPermissionRoleEnum.Di,
                "MA" => OrganizationPermissionRoleEnum.Ma,
                "NO" => OrganizationPermissionRoleEnum.No,
                "OW" => OrganizationPermissionRoleEnum.Ow,
                "RE" => OrganizationPermissionRoleEnum.Re,
                "VO" => OrganizationPermissionRoleEnum.Vo,
                _ => null,
            };
        }
    }
}