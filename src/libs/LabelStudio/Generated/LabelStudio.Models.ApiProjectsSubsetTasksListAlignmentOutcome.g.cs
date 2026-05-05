
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsSubsetTasksListAlignmentOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        FalseNegative,
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        TruePositive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsSubsetTasksListAlignmentOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsSubsetTasksListAlignmentOutcome value)
        {
            return value switch
            {
                ApiProjectsSubsetTasksListAlignmentOutcome.All => "all",
                ApiProjectsSubsetTasksListAlignmentOutcome.FalseNegative => "false_negative",
                ApiProjectsSubsetTasksListAlignmentOutcome.FalsePositive => "false_positive",
                ApiProjectsSubsetTasksListAlignmentOutcome.TruePositive => "true_positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsSubsetTasksListAlignmentOutcome? ToEnum(string value)
        {
            return value switch
            {
                "all" => ApiProjectsSubsetTasksListAlignmentOutcome.All,
                "false_negative" => ApiProjectsSubsetTasksListAlignmentOutcome.FalseNegative,
                "false_positive" => ApiProjectsSubsetTasksListAlignmentOutcome.FalsePositive,
                "true_positive" => ApiProjectsSubsetTasksListAlignmentOutcome.TruePositive,
                _ => null,
            };
        }
    }
}