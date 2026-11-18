
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Default Value: course
    /// </summary>
    public enum ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope
    {
        /// <summary>
        ///
        /// </summary>
        Course,
        /// <summary>
        ///
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope value)
        {
            return value switch
            {
                ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope.Course => "course",
                ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope? ToEnum(string value)
        {
            return value switch
            {
                "course" => ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope.Course,
                "page" => ApiLearningResourcesHistoryStatesRestorePreviewRetrieveScope.Page,
                _ => null,
            };
        }
    }
}