
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `course` - course<br/>
    /// * `page` - page
    /// </summary>
    public enum CourseHistoryScopeEnum
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
    public static class CourseHistoryScopeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CourseHistoryScopeEnum value)
        {
            return value switch
            {
                CourseHistoryScopeEnum.Course => "course",
                CourseHistoryScopeEnum.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CourseHistoryScopeEnum? ToEnum(string value)
        {
            return value switch
            {
                "course" => CourseHistoryScopeEnum.Course,
                "page" => CourseHistoryScopeEnum.Page,
                _ => null,
            };
        }
    }
}