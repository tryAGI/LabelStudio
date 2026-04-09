
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiProjectsCustomFunctionRetrieveResponseStatus
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
    public static class ApiProjectsCustomFunctionRetrieveResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsCustomFunctionRetrieveResponseStatus value)
        {
            return value switch
            {
                ApiProjectsCustomFunctionRetrieveResponseStatus.Active => "Active",
                ApiProjectsCustomFunctionRetrieveResponseStatus.Error => "Error",
                ApiProjectsCustomFunctionRetrieveResponseStatus.Failed => "Failed",
                ApiProjectsCustomFunctionRetrieveResponseStatus.NotDeployed => "NotDeployed",
                ApiProjectsCustomFunctionRetrieveResponseStatus.NotFound => "NotFound",
                ApiProjectsCustomFunctionRetrieveResponseStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsCustomFunctionRetrieveResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Active" => ApiProjectsCustomFunctionRetrieveResponseStatus.Active,
                "Error" => ApiProjectsCustomFunctionRetrieveResponseStatus.Error,
                "Failed" => ApiProjectsCustomFunctionRetrieveResponseStatus.Failed,
                "NotDeployed" => ApiProjectsCustomFunctionRetrieveResponseStatus.NotDeployed,
                "NotFound" => ApiProjectsCustomFunctionRetrieveResponseStatus.NotFound,
                "Pending" => ApiProjectsCustomFunctionRetrieveResponseStatus.Pending,
                _ => null,
            };
        }
    }
}