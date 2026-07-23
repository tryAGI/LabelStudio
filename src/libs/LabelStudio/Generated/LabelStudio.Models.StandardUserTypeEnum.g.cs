
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `standard` - Standard
    /// </summary>
    public enum StandardUserTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StandardUserTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardUserTypeEnum value)
        {
            return value switch
            {
                StandardUserTypeEnum.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardUserTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "standard" => StandardUserTypeEnum.Standard,
                _ => null,
            };
        }
    }
}