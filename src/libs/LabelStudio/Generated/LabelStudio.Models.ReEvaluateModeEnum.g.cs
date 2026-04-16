
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `failed` - failed<br/>
    /// * `incorrect` - incorrect<br/>
    /// * `regressions` - regressions<br/>
    /// * `custom` - custom
    /// </summary>
    public enum ReEvaluateModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Incorrect,
        /// <summary>
        /// 
        /// </summary>
        Regressions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReEvaluateModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReEvaluateModeEnum value)
        {
            return value switch
            {
                ReEvaluateModeEnum.Custom => "custom",
                ReEvaluateModeEnum.Failed => "failed",
                ReEvaluateModeEnum.Incorrect => "incorrect",
                ReEvaluateModeEnum.Regressions => "regressions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReEvaluateModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ReEvaluateModeEnum.Custom,
                "failed" => ReEvaluateModeEnum.Failed,
                "incorrect" => ReEvaluateModeEnum.Incorrect,
                "regressions" => ReEvaluateModeEnum.Regressions,
                _ => null,
            };
        }
    }
}