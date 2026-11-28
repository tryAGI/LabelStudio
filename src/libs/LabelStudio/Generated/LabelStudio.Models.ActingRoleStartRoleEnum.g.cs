
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `AD` - Administrator<br/>
    /// * `MA` - Manager<br/>
    /// * `RE` - Reviewer<br/>
    /// * `AN` - Annotator
    /// </summary>
    public enum ActingRoleStartRoleEnum
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
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActingRoleStartRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActingRoleStartRoleEnum value)
        {
            return value switch
            {
                ActingRoleStartRoleEnum.Ad => "AD",
                ActingRoleStartRoleEnum.An => "AN",
                ActingRoleStartRoleEnum.Ma => "MA",
                ActingRoleStartRoleEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActingRoleStartRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => ActingRoleStartRoleEnum.Ad,
                "AN" => ActingRoleStartRoleEnum.An,
                "MA" => ActingRoleStartRoleEnum.Ma,
                "RE" => ActingRoleStartRoleEnum.Re,
                _ => null,
            };
        }
    }
}