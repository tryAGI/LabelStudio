
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `assigned` - Assigned<br/>
    /// * `open` - Open
    /// </summary>
    public enum CollectionModeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Assigned,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CollectionModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CollectionModeEnum value)
        {
            return value switch
            {
                CollectionModeEnum.Assigned => "assigned",
                CollectionModeEnum.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CollectionModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "assigned" => CollectionModeEnum.Assigned,
                "open" => CollectionModeEnum.Open,
                _ => null,
            };
        }
    }
}