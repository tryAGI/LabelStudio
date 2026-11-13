
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `AD` - Administrator<br/>
    /// * `MA` - Manager<br/>
    /// * `RE` - Reviewer<br/>
    /// * `AN` - Annotator<br/>
    /// * `NO` - Not Activated
    /// </summary>
    public enum DefaultRoleDefaultRoleEnum
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
        Ma,
        /// <summary>
        ///
        /// </summary>
        No,
        /// <summary>
        ///
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DefaultRoleDefaultRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultRoleDefaultRoleEnum value)
        {
            return value switch
            {
                DefaultRoleDefaultRoleEnum.Ad => "AD",
                DefaultRoleDefaultRoleEnum.An => "AN",
                DefaultRoleDefaultRoleEnum.Ma => "MA",
                DefaultRoleDefaultRoleEnum.No => "NO",
                DefaultRoleDefaultRoleEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultRoleDefaultRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => DefaultRoleDefaultRoleEnum.Ad,
                "AN" => DefaultRoleDefaultRoleEnum.An,
                "MA" => DefaultRoleDefaultRoleEnum.Ma,
                "NO" => DefaultRoleDefaultRoleEnum.No,
                "RE" => DefaultRoleDefaultRoleEnum.Re,
                _ => null,
            };
        }
    }
}