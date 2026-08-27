
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `configured` - Configured<br/>
    /// * `orphaned` - Orphaned<br/>
    /// * `missing_membership` - Missing membership
    /// </summary>
    public enum MappingStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        Configured,
        /// <summary>
        ///
        /// </summary>
        MissingMembership,
        /// <summary>
        ///
        /// </summary>
        Orphaned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MappingStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MappingStatusEnum value)
        {
            return value switch
            {
                MappingStatusEnum.Configured => "configured",
                MappingStatusEnum.MissingMembership => "missing_membership",
                MappingStatusEnum.Orphaned => "orphaned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MappingStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "configured" => MappingStatusEnum.Configured,
                "missing_membership" => MappingStatusEnum.MissingMembership,
                "orphaned" => MappingStatusEnum.Orphaned,
                _ => null,
            };
        }
    }
}