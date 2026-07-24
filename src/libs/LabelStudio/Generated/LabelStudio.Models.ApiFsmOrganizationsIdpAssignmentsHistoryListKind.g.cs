
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiFsmOrganizationsIdpAssignmentsHistoryListKind
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
    public static class ApiFsmOrganizationsIdpAssignmentsHistoryListKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiFsmOrganizationsIdpAssignmentsHistoryListKind value)
        {
            return value switch
            {
                ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Organization => "organization",
                ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Project => "project",
                ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiFsmOrganizationsIdpAssignmentsHistoryListKind? ToEnum(string value)
        {
            return value switch
            {
                "organization" => ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Organization,
                "project" => ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Project,
                "workspace" => ApiFsmOrganizationsIdpAssignmentsHistoryListKind.Workspace,
                _ => null,
            };
        }
    }
}