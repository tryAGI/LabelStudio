
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `published_projects` - Published projects<br/>
    /// * `projects_cannot_move` - Projects cannot move<br/>
    /// * `inaccessible_projects` - Inaccessible projects<br/>
    /// * `project_limit` - Project limit
    /// </summary>
    public enum InterfaceMoveBlockerEnum
    {
        /// <summary>
        ///
        /// </summary>
        InaccessibleProjects,
        /// <summary>
        ///
        /// </summary>
        ProjectLimit,
        /// <summary>
        ///
        /// </summary>
        ProjectsCannotMove,
        /// <summary>
        ///
        /// </summary>
        PublishedProjects,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterfaceMoveBlockerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterfaceMoveBlockerEnum value)
        {
            return value switch
            {
                InterfaceMoveBlockerEnum.InaccessibleProjects => "inaccessible_projects",
                InterfaceMoveBlockerEnum.ProjectLimit => "project_limit",
                InterfaceMoveBlockerEnum.ProjectsCannotMove => "projects_cannot_move",
                InterfaceMoveBlockerEnum.PublishedProjects => "published_projects",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterfaceMoveBlockerEnum? ToEnum(string value)
        {
            return value switch
            {
                "inaccessible_projects" => InterfaceMoveBlockerEnum.InaccessibleProjects,
                "project_limit" => InterfaceMoveBlockerEnum.ProjectLimit,
                "projects_cannot_move" => InterfaceMoveBlockerEnum.ProjectsCannotMove,
                "published_projects" => InterfaceMoveBlockerEnum.PublishedProjects,
                _ => null,
            };
        }
    }
}