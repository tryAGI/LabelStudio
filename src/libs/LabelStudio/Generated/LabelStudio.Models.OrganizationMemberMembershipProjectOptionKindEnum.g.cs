
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `project` - project
    /// </summary>
    public enum OrganizationMemberMembershipProjectOptionKindEnum
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationMemberMembershipProjectOptionKindEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationMemberMembershipProjectOptionKindEnum value)
        {
            return value switch
            {
                OrganizationMemberMembershipProjectOptionKindEnum.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationMemberMembershipProjectOptionKindEnum? ToEnum(string value)
        {
            return value switch
            {
                "project" => OrganizationMemberMembershipProjectOptionKindEnum.Project,
                _ => null,
            };
        }
    }
}