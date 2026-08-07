
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `AN` - Annotate<br/>
    /// * `RE` - Review
    /// </summary>
    public enum AssignmentTypeEnum
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
    public static class AssignmentTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignmentTypeEnum value)
        {
            return value switch
            {
                AssignmentTypeEnum.An => "AN",
                AssignmentTypeEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignmentTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "AN" => AssignmentTypeEnum.An,
                "RE" => AssignmentTypeEnum.Re,
                _ => null,
            };
        }
    }
}