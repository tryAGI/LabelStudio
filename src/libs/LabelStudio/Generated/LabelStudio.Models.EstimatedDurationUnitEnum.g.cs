
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `minutes` - Minutes<br/>
    /// * `hours` - Hours<br/>
    /// * `days` - Days<br/>
    /// * `weeks` - Weeks
    /// </summary>
    public enum EstimatedDurationUnitEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Days,
        /// <summary>
        /// 
        /// </summary>
        Hours,
        /// <summary>
        /// 
        /// </summary>
        Minutes,
        /// <summary>
        /// 
        /// </summary>
        Weeks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatedDurationUnitEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatedDurationUnitEnum value)
        {
            return value switch
            {
                EstimatedDurationUnitEnum.Days => "days",
                EstimatedDurationUnitEnum.Hours => "hours",
                EstimatedDurationUnitEnum.Minutes => "minutes",
                EstimatedDurationUnitEnum.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatedDurationUnitEnum? ToEnum(string value)
        {
            return value switch
            {
                "days" => EstimatedDurationUnitEnum.Days,
                "hours" => EstimatedDurationUnitEnum.Hours,
                "minutes" => EstimatedDurationUnitEnum.Minutes,
                "weeks" => EstimatedDurationUnitEnum.Weeks,
                _ => null,
            };
        }
    }
}