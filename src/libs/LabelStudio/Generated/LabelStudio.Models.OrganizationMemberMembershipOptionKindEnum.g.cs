
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `project` - project<br/>
    /// * `workspace` - workspace
    /// </summary>
    public enum OrganizationMemberMembershipOptionKindEnum
    {
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationMemberMembershipOptionKindEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationMemberMembershipOptionKindEnum value)
        {
            return value switch
            {
                OrganizationMemberMembershipOptionKindEnum.Project => "project",
                OrganizationMemberMembershipOptionKindEnum.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationMemberMembershipOptionKindEnum? ToEnum(string value)
        {
            return value switch
            {
                "project" => OrganizationMemberMembershipOptionKindEnum.Project,
                "workspace" => OrganizationMemberMembershipOptionKindEnum.Workspace,
                _ => null,
            };
        }
    }
}