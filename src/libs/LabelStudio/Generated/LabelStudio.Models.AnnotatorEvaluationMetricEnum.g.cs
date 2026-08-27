
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `gt_agreement` - Ground truth agreement<br/>
    /// * `acceptance_score` - Acceptance score<br/>
    /// * `rejection_rate` - Rejection rate
    /// </summary>
    public enum AnnotatorEvaluationMetricEnum
    {
        /// <summary>
        ///
        /// </summary>
        AcceptanceScore,
        /// <summary>
        ///
        /// </summary>
        GtAgreement,
        /// <summary>
        ///
        /// </summary>
        RejectionRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotatorEvaluationMetricEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotatorEvaluationMetricEnum value)
        {
            return value switch
            {
                AnnotatorEvaluationMetricEnum.AcceptanceScore => "acceptance_score",
                AnnotatorEvaluationMetricEnum.GtAgreement => "gt_agreement",
                AnnotatorEvaluationMetricEnum.RejectionRate => "rejection_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotatorEvaluationMetricEnum? ToEnum(string value)
        {
            return value switch
            {
                "acceptance_score" => AnnotatorEvaluationMetricEnum.AcceptanceScore,
                "gt_agreement" => AnnotatorEvaluationMetricEnum.GtAgreement,
                "rejection_rate" => AnnotatorEvaluationMetricEnum.RejectionRate,
                _ => null,
            };
        }
    }
}