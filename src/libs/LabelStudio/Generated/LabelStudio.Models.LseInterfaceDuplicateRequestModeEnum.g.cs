
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `last` - last<br/>
    /// * `all` - all
    /// </summary>
    public enum LseInterfaceDuplicateRequestModeEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LseInterfaceDuplicateRequestModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LseInterfaceDuplicateRequestModeEnum value)
        {
            return value switch
            {
                LseInterfaceDuplicateRequestModeEnum.All => "all",
                LseInterfaceDuplicateRequestModeEnum.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LseInterfaceDuplicateRequestModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => LseInterfaceDuplicateRequestModeEnum.All,
                "last" => LseInterfaceDuplicateRequestModeEnum.Last,
                _ => null,
            };
        }
    }
}