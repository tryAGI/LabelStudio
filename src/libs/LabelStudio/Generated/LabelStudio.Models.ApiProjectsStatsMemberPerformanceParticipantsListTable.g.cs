
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiProjectsStatsMemberPerformanceParticipantsListTable
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
    public static class ApiProjectsStatsMemberPerformanceParticipantsListTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsStatsMemberPerformanceParticipantsListTable value)
        {
            return value switch
            {
                ApiProjectsStatsMemberPerformanceParticipantsListTable.Annotations => "annotations",
                ApiProjectsStatsMemberPerformanceParticipantsListTable.Reviews => "reviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsStatsMemberPerformanceParticipantsListTable? ToEnum(string value)
        {
            return value switch
            {
                "annotations" => ApiProjectsStatsMemberPerformanceParticipantsListTable.Annotations,
                "reviews" => ApiProjectsStatsMemberPerformanceParticipantsListTable.Reviews,
                _ => null,
            };
        }
    }
}