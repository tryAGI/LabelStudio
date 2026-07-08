
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `prediction` - Created from prediction<br/>
    /// * `propagated_annotation` - Created from another annotation<br/>
    /// * `imported` - Imported<br/>
    /// * `submitted` - Submitted<br/>
    /// * `updated` - Updated<br/>
    /// * `skipped` - Skipped<br/>
    /// * `accepted` - Accepted<br/>
    /// * `rejected` - Rejected<br/>
    /// * `fixed_and_accepted` - Fixed and accepted<br/>
    /// * `deleted_review` - Deleted review
    /// </summary>
    public enum AnnotationHistoryActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        DeletedReview,
        /// <summary>
        /// 
        /// </summary>
        FixedAndAccepted,
        /// <summary>
        /// 
        /// </summary>
        Imported,
        /// <summary>
        /// 
        /// </summary>
        Prediction,
        /// <summary>
        /// 
        /// </summary>
        PropagatedAnnotation,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationHistoryActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationHistoryActionEnum value)
        {
            return value switch
            {
                AnnotationHistoryActionEnum.Accepted => "accepted",
                AnnotationHistoryActionEnum.DeletedReview => "deleted_review",
                AnnotationHistoryActionEnum.FixedAndAccepted => "fixed_and_accepted",
                AnnotationHistoryActionEnum.Imported => "imported",
                AnnotationHistoryActionEnum.Prediction => "prediction",
                AnnotationHistoryActionEnum.PropagatedAnnotation => "propagated_annotation",
                AnnotationHistoryActionEnum.Rejected => "rejected",
                AnnotationHistoryActionEnum.Skipped => "skipped",
                AnnotationHistoryActionEnum.Submitted => "submitted",
                AnnotationHistoryActionEnum.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationHistoryActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => AnnotationHistoryActionEnum.Accepted,
                "deleted_review" => AnnotationHistoryActionEnum.DeletedReview,
                "fixed_and_accepted" => AnnotationHistoryActionEnum.FixedAndAccepted,
                "imported" => AnnotationHistoryActionEnum.Imported,
                "prediction" => AnnotationHistoryActionEnum.Prediction,
                "propagated_annotation" => AnnotationHistoryActionEnum.PropagatedAnnotation,
                "rejected" => AnnotationHistoryActionEnum.Rejected,
                "skipped" => AnnotationHistoryActionEnum.Skipped,
                "submitted" => AnnotationHistoryActionEnum.Submitted,
                "updated" => AnnotationHistoryActionEnum.Updated,
                _ => null,
            };
        }
    }
}