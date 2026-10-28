
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `RE` - Reviewer<br/>
    /// * `AN` - Annotator
    /// </summary>
    public enum ProjectMemberBulkAssignRolesRoleEnum
    {
        /// <summary>
        ///
        /// </summary>
        An,
        /// <summary>
        ///
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMemberBulkAssignRolesRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMemberBulkAssignRolesRoleEnum value)
        {
            return value switch
            {
                ProjectMemberBulkAssignRolesRoleEnum.An => "AN",
                ProjectMemberBulkAssignRolesRoleEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMemberBulkAssignRolesRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ProjectMemberBulkAssignRolesRoleEnum.An,
                "RE" => ProjectMemberBulkAssignRolesRoleEnum.Re,
                _ => null,
            };
        }
    }
}