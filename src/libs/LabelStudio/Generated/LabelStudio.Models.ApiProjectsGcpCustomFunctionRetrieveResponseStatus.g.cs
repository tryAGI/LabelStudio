
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsGcpCustomFunctionRetrieveResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NotDeployed,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsGcpCustomFunctionRetrieveResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsGcpCustomFunctionRetrieveResponseStatus value)
        {
            return value switch
            {
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Active => "Active",
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Error => "Error",
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Failed => "Failed",
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.NotDeployed => "NotDeployed",
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.NotFound => "NotFound",
                ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsGcpCustomFunctionRetrieveResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Active" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Active,
                "Error" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Error,
                "Failed" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Failed,
                "NotDeployed" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.NotDeployed,
                "NotFound" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.NotFound,
                "Pending" => ApiProjectsGcpCustomFunctionRetrieveResponseStatus.Pending,
                _ => null,
            };
        }
    }
}