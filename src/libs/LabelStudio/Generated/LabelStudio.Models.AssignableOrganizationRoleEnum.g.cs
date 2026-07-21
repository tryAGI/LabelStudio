
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `OW` - Owner<br/>
    /// * `AD` - Administrator<br/>
    /// * `MA` - Manager<br/>
    /// * `RE` - Reviewer<br/>
    /// * `AN` - Annotator<br/>
    /// * `DI` - Deactivated<br/>
    /// * `NO` - Not Activated
    /// </summary>
    public enum AssignableOrganizationRoleEnum
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssignableOrganizationRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignableOrganizationRoleEnum value)
        {
            return value switch
            {
                AssignableOrganizationRoleEnum.Ad => "AD",
                AssignableOrganizationRoleEnum.An => "AN",
                AssignableOrganizationRoleEnum.Di => "DI",
                AssignableOrganizationRoleEnum.Ma => "MA",
                AssignableOrganizationRoleEnum.No => "NO",
                AssignableOrganizationRoleEnum.Ow => "OW",
                AssignableOrganizationRoleEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignableOrganizationRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => AssignableOrganizationRoleEnum.Ad,
                "AN" => AssignableOrganizationRoleEnum.An,
                "DI" => AssignableOrganizationRoleEnum.Di,
                "MA" => AssignableOrganizationRoleEnum.Ma,
                "NO" => AssignableOrganizationRoleEnum.No,
                "OW" => AssignableOrganizationRoleEnum.Ow,
                "RE" => AssignableOrganizationRoleEnum.Re,
                _ => null,
            };
        }
    }
}