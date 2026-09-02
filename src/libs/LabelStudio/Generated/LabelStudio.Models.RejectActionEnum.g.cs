
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `remove` - Remove<br/>
    /// * `requeue` - Requeue<br/>
    /// * `redistribute` - Redistribute
    /// </summary>
    public enum RejectActionEnum
    {
        /// <summary>
        ///
        /// </summary>
        Redistribute,
        /// <summary>
        ///
        /// </summary>
        Remove,
        /// <summary>
        ///
        /// </summary>
        Requeue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RejectActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RejectActionEnum value)
        {
            return value switch
            {
                RejectActionEnum.Redistribute => "redistribute",
                RejectActionEnum.Remove => "remove",
                RejectActionEnum.Requeue => "requeue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RejectActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "redistribute" => RejectActionEnum.Redistribute,
                "remove" => RejectActionEnum.Remove,
                "requeue" => RejectActionEnum.Requeue,
                _ => null,
            };
        }
    }
}