
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsStatsMemberPerformanceSummaryRetrieveTable
    {
        /// <summary>
        /// "annotations" or "reviews".
        /// </summary>
        Annotations,
        /// <summary>
        /// "annotations" or "reviews".
        /// </summary>
        Reviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsStatsMemberPerformanceSummaryRetrieveTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsStatsMemberPerformanceSummaryRetrieveTable value)
        {
            return value switch
            {
                ApiProjectsStatsMemberPerformanceSummaryRetrieveTable.Annotations => "annotations",
                ApiProjectsStatsMemberPerformanceSummaryRetrieveTable.Reviews => "reviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? ToEnum(string value)
        {
            return value switch
            {
                "annotations" => ApiProjectsStatsMemberPerformanceSummaryRetrieveTable.Annotations,
                "reviews" => ApiProjectsStatsMemberPerformanceSummaryRetrieveTable.Reviews,
                _ => null,
            };
        }
    }
}