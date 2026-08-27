
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `created` - Created<br/>
    /// * `in_progress` - In progress<br/>
    /// * `failed` - Failed<br/>
    /// * `completed` - Completed
    /// </summary>
    public enum ProjectImportStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectImportStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectImportStatusEnum value)
        {
            return value switch
            {
                ProjectImportStatusEnum.Completed => "completed",
                ProjectImportStatusEnum.Created => "created",
                ProjectImportStatusEnum.Failed => "failed",
                ProjectImportStatusEnum.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectImportStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProjectImportStatusEnum.Completed,
                "created" => ProjectImportStatusEnum.Created,
                "failed" => ProjectImportStatusEnum.Failed,
                "in_progress" => ProjectImportStatusEnum.InProgress,
                _ => null,
            };
        }
    }
}