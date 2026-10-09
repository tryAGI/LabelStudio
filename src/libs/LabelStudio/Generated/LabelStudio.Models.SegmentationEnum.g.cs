
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `none` - none<br/>
    /// * `time` - time<br/>
    /// * `user` - user<br/>
    /// * `project` - project<br/>
    /// * `matrix` - matrix<br/>
    /// * `project_matrix` - project_matrix<br/>
    /// * `user_project` - user_project
    /// </summary>
    public enum SegmentationEnum
    {
        /// <summary>
        ///
        /// </summary>
        Matrix,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectMatrix,
        /// <summary>
        ///
        /// </summary>
        Time,
        /// <summary>
        ///
        /// </summary>
        User,
        /// <summary>
        ///
        /// </summary>
        UserProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentationEnum value)
        {
            return value switch
            {
                SegmentationEnum.Matrix => "matrix",
                SegmentationEnum.None => "none",
                SegmentationEnum.Project => "project",
                SegmentationEnum.ProjectMatrix => "project_matrix",
                SegmentationEnum.Time => "time",
                SegmentationEnum.User => "user",
                SegmentationEnum.UserProject => "user_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentationEnum? ToEnum(string value)
        {
            return value switch
            {
                "matrix" => SegmentationEnum.Matrix,
                "none" => SegmentationEnum.None,
                "project" => SegmentationEnum.Project,
                "project_matrix" => SegmentationEnum.ProjectMatrix,
                "time" => SegmentationEnum.Time,
                "user" => SegmentationEnum.User,
                "user_project" => SegmentationEnum.UserProject,
                _ => null,
            };
        }
    }
}