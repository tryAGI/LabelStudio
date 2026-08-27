
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
    /// * `NO` - Not Activated<br/>
    /// * `VO` - View Only
    /// </summary>
    public enum OrganizationRoleEnum
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
    public static class OrganizationRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleEnum value)
        {
            return value switch
            {
                OrganizationRoleEnum.Ad => "AD",
                OrganizationRoleEnum.An => "AN",
                OrganizationRoleEnum.Di => "DI",
                OrganizationRoleEnum.Ma => "MA",
                OrganizationRoleEnum.No => "NO",
                OrganizationRoleEnum.Ow => "OW",
                OrganizationRoleEnum.Re => "RE",
                OrganizationRoleEnum.Vo => "VO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => OrganizationRoleEnum.Ad,
                "AN" => OrganizationRoleEnum.An,
                "DI" => OrganizationRoleEnum.Di,
                "MA" => OrganizationRoleEnum.Ma,
                "NO" => OrganizationRoleEnum.No,
                "OW" => OrganizationRoleEnum.Ow,
                "RE" => OrganizationRoleEnum.Re,
                "VO" => OrganizationRoleEnum.Vo,
                _ => null,
            };
        }
    }
}