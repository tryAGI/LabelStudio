
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PrepareParamsOrderingRequestItem
    {
        /// <summary>
        ///
        /// </summary>
        Tasks_agreement,
        /// <summary>
        ///
        /// </summary>
        Tasks_annotationsResults,
        /// <summary>
        ///
        /// </summary>
        Tasks_annotators,
        /// <summary>
        ///
        /// </summary>
        Tasks_cancelledAnnotations,
        /// <summary>
        ///
        /// </summary>
        Tasks_comments,
        /// <summary>
        ///
        /// </summary>
        Tasks_completedAt,
        /// <summary>
        ///
        /// </summary>
        Tasks_createdAt,
        /// <summary>
        ///
        /// </summary>
        Tasks_fileUpload,
        /// <summary>
        ///
        /// </summary>
        Tasks_groundTruth,
        /// <summary>
        ///
        /// </summary>
        Tasks_id,
        /// <summary>
        ///
        /// </summary>
        Tasks_innerId,
        /// <summary>
        ///
        /// </summary>
        Tasks_predictionsModelVersions,
        /// <summary>
        ///
        /// </summary>
        Tasks_predictionsResults,
        /// <summary>
        ///
        /// </summary>
        Tasks_predictionsScore,
        /// <summary>
        ///
        /// </summary>
        Tasks_reviewed,
        /// <summary>
        ///
        /// </summary>
        Tasks_reviewers,
        /// <summary>
        ///
        /// </summary>
        Tasks_reviewsAccepted,
        /// <summary>
        ///
        /// </summary>
        Tasks_reviewsRejected,
        /// <summary>
        ///
        /// </summary>
        Tasks_totalAnnotations,
        /// <summary>
        ///
        /// </summary>
        Tasks_totalPredictions,
        /// <summary>
        ///
        /// </summary>
        Tasks_unresolvedCommentCount,
        /// <summary>
        ///
        /// </summary>
        Tasks_updatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrepareParamsOrderingRequestItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrepareParamsOrderingRequestItem value)
        {
            return value switch
            {
                PrepareParamsOrderingRequestItem.Tasks_agreement => "tasks:agreement",
                PrepareParamsOrderingRequestItem.Tasks_annotationsResults => "tasks:annotations_results",
                PrepareParamsOrderingRequestItem.Tasks_annotators => "tasks:annotators",
                PrepareParamsOrderingRequestItem.Tasks_cancelledAnnotations => "tasks:cancelled_annotations",
                PrepareParamsOrderingRequestItem.Tasks_comments => "tasks:comments",
                PrepareParamsOrderingRequestItem.Tasks_completedAt => "tasks:completed_at",
                PrepareParamsOrderingRequestItem.Tasks_createdAt => "tasks:created_at",
                PrepareParamsOrderingRequestItem.Tasks_fileUpload => "tasks:file_upload",
                PrepareParamsOrderingRequestItem.Tasks_groundTruth => "tasks:ground_truth",
                PrepareParamsOrderingRequestItem.Tasks_id => "tasks:id",
                PrepareParamsOrderingRequestItem.Tasks_innerId => "tasks:inner_id",
                PrepareParamsOrderingRequestItem.Tasks_predictionsModelVersions => "tasks:predictions_model_versions",
                PrepareParamsOrderingRequestItem.Tasks_predictionsResults => "tasks:predictions_results",
                PrepareParamsOrderingRequestItem.Tasks_predictionsScore => "tasks:predictions_score",
                PrepareParamsOrderingRequestItem.Tasks_reviewed => "tasks:reviewed",
                PrepareParamsOrderingRequestItem.Tasks_reviewers => "tasks:reviewers",
                PrepareParamsOrderingRequestItem.Tasks_reviewsAccepted => "tasks:reviews_accepted",
                PrepareParamsOrderingRequestItem.Tasks_reviewsRejected => "tasks:reviews_rejected",
                PrepareParamsOrderingRequestItem.Tasks_totalAnnotations => "tasks:total_annotations",
                PrepareParamsOrderingRequestItem.Tasks_totalPredictions => "tasks:total_predictions",
                PrepareParamsOrderingRequestItem.Tasks_unresolvedCommentCount => "tasks:unresolved_comment_count",
                PrepareParamsOrderingRequestItem.Tasks_updatedAt => "tasks:updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrepareParamsOrderingRequestItem? ToEnum(string value)
        {
            return value switch
            {
                "tasks:agreement" => PrepareParamsOrderingRequestItem.Tasks_agreement,
                "tasks:annotations_results" => PrepareParamsOrderingRequestItem.Tasks_annotationsResults,
                "tasks:annotators" => PrepareParamsOrderingRequestItem.Tasks_annotators,
                "tasks:cancelled_annotations" => PrepareParamsOrderingRequestItem.Tasks_cancelledAnnotations,
                "tasks:comments" => PrepareParamsOrderingRequestItem.Tasks_comments,
                "tasks:completed_at" => PrepareParamsOrderingRequestItem.Tasks_completedAt,
                "tasks:created_at" => PrepareParamsOrderingRequestItem.Tasks_createdAt,
                "tasks:file_upload" => PrepareParamsOrderingRequestItem.Tasks_fileUpload,
                "tasks:ground_truth" => PrepareParamsOrderingRequestItem.Tasks_groundTruth,
                "tasks:id" => PrepareParamsOrderingRequestItem.Tasks_id,
                "tasks:inner_id" => PrepareParamsOrderingRequestItem.Tasks_innerId,
                "tasks:predictions_model_versions" => PrepareParamsOrderingRequestItem.Tasks_predictionsModelVersions,
                "tasks:predictions_results" => PrepareParamsOrderingRequestItem.Tasks_predictionsResults,
                "tasks:predictions_score" => PrepareParamsOrderingRequestItem.Tasks_predictionsScore,
                "tasks:reviewed" => PrepareParamsOrderingRequestItem.Tasks_reviewed,
                "tasks:reviewers" => PrepareParamsOrderingRequestItem.Tasks_reviewers,
                "tasks:reviews_accepted" => PrepareParamsOrderingRequestItem.Tasks_reviewsAccepted,
                "tasks:reviews_rejected" => PrepareParamsOrderingRequestItem.Tasks_reviewsRejected,
                "tasks:total_annotations" => PrepareParamsOrderingRequestItem.Tasks_totalAnnotations,
                "tasks:total_predictions" => PrepareParamsOrderingRequestItem.Tasks_totalPredictions,
                "tasks:unresolved_comment_count" => PrepareParamsOrderingRequestItem.Tasks_unresolvedCommentCount,
                "tasks:updated_at" => PrepareParamsOrderingRequestItem.Tasks_updatedAt,
                _ => null,
            };
        }
    }
}