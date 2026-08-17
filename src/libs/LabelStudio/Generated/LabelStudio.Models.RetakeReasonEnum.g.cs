
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `manual` - Manual invalidation<br/>
    /// * `gt_agreement` - Ground truth / agreement threshold
    /// </summary>
    public enum RetakeReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        GtAgreement,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetakeReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetakeReasonEnum value)
        {
            return value switch
            {
                RetakeReasonEnum.GtAgreement => "gt_agreement",
                RetakeReasonEnum.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetakeReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "gt_agreement" => RetakeReasonEnum.GtAgreement,
                "manual" => RetakeReasonEnum.Manual,
                _ => null,
            };
        }
    }
}