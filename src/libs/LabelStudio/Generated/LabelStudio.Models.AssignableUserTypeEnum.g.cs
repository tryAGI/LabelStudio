
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `standard` - Standard<br/>
    /// * `flex` - Flex<br/>
    /// * `viewonly` - View Only
    /// </summary>
    public enum AssignableUserTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Flex,
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
    public static class AssignableUserTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignableUserTypeEnum value)
        {
            return value switch
            {
                AssignableUserTypeEnum.Flex => "flex",
                AssignableUserTypeEnum.Standard => "standard",
                AssignableUserTypeEnum.Viewonly => "viewonly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignableUserTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "flex" => AssignableUserTypeEnum.Flex,
                "standard" => AssignableUserTypeEnum.Standard,
                "viewonly" => AssignableUserTypeEnum.Viewonly,
                _ => null,
            };
        }
    }
}