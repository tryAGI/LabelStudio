
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Assignment type. Use AN for annotate or RE for review.
    /// </summary>
    public enum ApiProjectsTasksAssigneesBulkCreateRequestType
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
    public static class ApiProjectsTasksAssigneesBulkCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesBulkCreateRequestType value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesBulkCreateRequestType.An => "AN",
                ApiProjectsTasksAssigneesBulkCreateRequestType.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesBulkCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ApiProjectsTasksAssigneesBulkCreateRequestType.An,
                "RE" => ApiProjectsTasksAssigneesBulkCreateRequestType.Re,
                _ => null,
            };
        }
    }
}