
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `service_principal` - Service Principal<br/>
    /// * `workload_identity` - Workload identity
    /// </summary>
    public enum AuthModeEnum
    {
        /// <summary>
        ///
        /// </summary>
        ServicePrincipal,
        /// <summary>
        ///
        /// </summary>
        WorkloadIdentity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthModeEnum value)
        {
            return value switch
            {
                AuthModeEnum.ServicePrincipal => "service_principal",
                AuthModeEnum.WorkloadIdentity => "workload_identity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "service_principal" => AuthModeEnum.ServicePrincipal,
                "workload_identity" => AuthModeEnum.WorkloadIdentity,
                _ => null,
            };
        }
    }
}