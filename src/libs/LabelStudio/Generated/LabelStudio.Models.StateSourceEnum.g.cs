
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum StateSourceEnum
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateSourceEnum value)
        {
            return value switch
            {
                StateSourceEnum.Auto => "auto",
                StateSourceEnum.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StateSourceEnum.Auto,
                "manual" => StateSourceEnum.Manual,
                _ => null,
            };
        }
    }
}