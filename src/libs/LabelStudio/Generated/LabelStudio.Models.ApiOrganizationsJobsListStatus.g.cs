
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiOrganizationsJobsListStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiOrganizationsJobsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiOrganizationsJobsListStatus value)
        {
            return value switch
            {
                ApiOrganizationsJobsListStatus.Failed => "failed",
                ApiOrganizationsJobsListStatus.Running => "running",
                ApiOrganizationsJobsListStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiOrganizationsJobsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ApiOrganizationsJobsListStatus.Failed,
                "running" => ApiOrganizationsJobsListStatus.Running,
                "waiting" => ApiOrganizationsJobsListStatus.Waiting,
                _ => null,
            };
        }
    }
}