
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `cannot_move` - Cannot move<br/>
    /// * `published` - Published
    /// </summary>
    public enum InterfaceMoveBlockingReasonEnum
    {
        /// <summary>
        ///
        /// </summary>
        CannotMove,
        /// <summary>
        ///
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterfaceMoveBlockingReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterfaceMoveBlockingReasonEnum value)
        {
            return value switch
            {
                InterfaceMoveBlockingReasonEnum.CannotMove => "cannot_move",
                InterfaceMoveBlockingReasonEnum.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterfaceMoveBlockingReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "cannot_move" => InterfaceMoveBlockingReasonEnum.CannotMove,
                "published" => InterfaceMoveBlockingReasonEnum.Published,
                _ => null,
            };
        }
    }
}