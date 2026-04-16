
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `settings` - Only settings<br/>
    /// * `settings,data` - Settings and tasks
    /// </summary>
    public enum ProjectDuplicateModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Settings_data,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectDuplicateModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDuplicateModeEnum value)
        {
            return value switch
            {
                ProjectDuplicateModeEnum.Settings => "settings",
                ProjectDuplicateModeEnum.Settings_data => "settings,data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDuplicateModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "settings" => ProjectDuplicateModeEnum.Settings,
                "settings,data" => ProjectDuplicateModeEnum.Settings_data,
                _ => null,
            };
        }
    }
}