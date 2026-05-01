
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsStatsMemberPerformanceRowsRetrieveTable
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
    public static class ApiProjectsStatsMemberPerformanceRowsRetrieveTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsStatsMemberPerformanceRowsRetrieveTable value)
        {
            return value switch
            {
                ApiProjectsStatsMemberPerformanceRowsRetrieveTable.Annotations => "annotations",
                ApiProjectsStatsMemberPerformanceRowsRetrieveTable.Reviews => "reviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsStatsMemberPerformanceRowsRetrieveTable? ToEnum(string value)
        {
            return value switch
            {
                "annotations" => ApiProjectsStatsMemberPerformanceRowsRetrieveTable.Annotations,
                "reviews" => ApiProjectsStatsMemberPerformanceRowsRetrieveTable.Reviews,
                _ => null,
            };
        }
    }
}