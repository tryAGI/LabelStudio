
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `target_shared` - Target shared<br/>
    /// * `projects_stay_private` - Projects stay private<br/>
    /// * `target_private` - Target private<br/>
    /// * `target_workspace_visible` - Target workspace visible<br/>
    /// * `restricted_to_target` - Restricted to target
    /// </summary>
    public enum InterfaceMoveNoticeEnum
    {
        /// <summary>
        ///
        /// </summary>
        ProjectsStayPrivate,
        /// <summary>
        ///
        /// </summary>
        RestrictedToTarget,
        /// <summary>
        ///
        /// </summary>
        TargetPrivate,
        /// <summary>
        ///
        /// </summary>
        TargetShared,
        /// <summary>
        ///
        /// </summary>
        TargetWorkspaceVisible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterfaceMoveNoticeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterfaceMoveNoticeEnum value)
        {
            return value switch
            {
                InterfaceMoveNoticeEnum.ProjectsStayPrivate => "projects_stay_private",
                InterfaceMoveNoticeEnum.RestrictedToTarget => "restricted_to_target",
                InterfaceMoveNoticeEnum.TargetPrivate => "target_private",
                InterfaceMoveNoticeEnum.TargetShared => "target_shared",
                InterfaceMoveNoticeEnum.TargetWorkspaceVisible => "target_workspace_visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterfaceMoveNoticeEnum? ToEnum(string value)
        {
            return value switch
            {
                "projects_stay_private" => InterfaceMoveNoticeEnum.ProjectsStayPrivate,
                "restricted_to_target" => InterfaceMoveNoticeEnum.RestrictedToTarget,
                "target_private" => InterfaceMoveNoticeEnum.TargetPrivate,
                "target_shared" => InterfaceMoveNoticeEnum.TargetShared,
                "target_workspace_visible" => InterfaceMoveNoticeEnum.TargetWorkspaceVisible,
                _ => null,
            };
        }
    }
}