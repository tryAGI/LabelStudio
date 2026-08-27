
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer get numbers from project queryset annotation,<br/>
    /// make sure, that you use correct one(Project.objects.with_counts())
    /// </summary>
    public sealed partial class LseProjectCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplication_status")]
        public string? DuplicationStatus { get; set; }

        /// <summary>
        /// Project-wide count of tasks considered finished under project completion rules (agreement threshold, overlap, or FSM states such as needs-review and completed). Not a per-user queue counter. Analytics KPIs such as `annotated_tasks`, `done_tasks`, and `total_tasks` measure related but not identical project-wide totals.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_task_number")]
        public int FinishedTaskNumber { get; set; } = default!;

        /// <summary>
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth_number")]
        public int GroundTruthNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Tasks with at least one annotation. For annotators, counts only tasks this user annotated; for other roles, counts project-wide. For analytics, use annotated_tasks or related KPIs with explicit project/member filters.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tasks_with_annotations")]
        public int? NumTasksWithAnnotations { get; set; }

        /// <summary>
        /// Annotator-only: tasks this user has completed in the labeling queue for the project.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_done")]
        public int QueueDone { get; set; } = default!;

        /// <summary>
        /// Reviewer-only: remaining tasks in this user's manually assigned review queue. Returns 0 when no manual assignments apply; the project card then uses `review_total_tasks` and `reviewed_number` for auto-review progress. Not the same as the project-wide `tasks_pending_review` KPI.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_left")]
        public int? QueueLeft { get; set; }

        /// <summary>
        /// Role-dependent queue size. Annotators: total tasks in the labeling queue. Reviewers (list/counts): total manually assigned review tasks (same pool as `reviewer_queue_total`). Not the same as `task_number` (all project tasks) or `review_total_tasks` (auto-review stream pool).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_total")]
        public int QueueTotal { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        public int Rejected { get; set; } = default!;

        /// <summary>
        /// Total tasks in this user's reviewer queue for the project (denominator for personal review progress). Respects review sampling limits when configured. Null for annotators. This is not the project-wide reviewed or pending count; see Analytics KPIs tasks_reviewed and tasks_pending_review for org-level totals.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_total_tasks")]
        public int? ReviewTotalTasks { get; set; }

        /// <summary>
        /// Tasks this user has reviewed in the project (personal reviewer progress shown on the project card). Includes only reviews created by the authenticated user, so the value can be lower than the project-wide reviewed total when multiple reviewers participate. Null for annotators. For all reviewed tasks in the project, use the Analytics KPI tasks_reviewed: GET /api/analytics/kpis/tasks_reviewed?projects={id}&amp;tz=UTC.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_number")]
        public int? ReviewedNumber { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_annotations_number")]
        public int? SkippedAnnotationsNumber { get; set; }

        /// <summary>
        /// Total task number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_number")]
        public int TaskNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_annotations_number")]
        public int TotalAnnotationsNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions_number")]
        public int TotalPredictionsNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useful_annotation_number")]
        public int? UsefulAnnotationNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCounts" /> class.
        /// </summary>
        /// <param name="duplicationStatus"></param>
        /// <param name="numTasksWithAnnotations">
        /// Tasks with at least one annotation. For annotators, counts only tasks this user annotated; for other roles, counts project-wide. For analytics, use annotated_tasks or related KPIs with explicit project/member filters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="queueLeft">
        /// Reviewer-only: remaining tasks in this user's manually assigned review queue. Returns 0 when no manual assignments apply; the project card then uses `review_total_tasks` and `reviewed_number` for auto-review progress. Not the same as the project-wide `tasks_pending_review` KPI.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewTotalTasks">
        /// Total tasks in this user's reviewer queue for the project (denominator for personal review progress). Respects review sampling limits when configured. Null for annotators. This is not the project-wide reviewed or pending count; see Analytics KPIs tasks_reviewed and tasks_pending_review for org-level totals.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewedNumber">
        /// Tasks this user has reviewed in the project (personal reviewer progress shown on the project card). Includes only reviews created by the authenticated user, so the value can be lower than the project-wide reviewed total when multiple reviewers participate. Null for annotators. For all reviewed tasks in the project, use the Analytics KPI tasks_reviewed: GET /api/analytics/kpis/tasks_reviewed?projects={id}&amp;tz=UTC.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="skippedAnnotationsNumber">
        /// Included only in responses
        /// </param>
        /// <param name="usefulAnnotationNumber">
        /// Included only in responses
        /// </param>
        /// <param name="finishedTaskNumber">
        /// Project-wide count of tasks considered finished under project completion rules (agreement threshold, overlap, or FSM states such as needs-review and completed). Not a per-user queue counter. Analytics KPIs such as `annotated_tasks`, `done_tasks`, and `total_tasks` measure related but not identical project-wide totals.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="groundTruthNumber">
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="queueDone">
        /// Annotator-only: tasks this user has completed in the labeling queue for the project.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="queueTotal">
        /// Role-dependent queue size. Annotators: total tasks in the labeling queue. Reviewers (list/counts): total manually assigned review tasks (same pool as `reviewer_queue_total`). Not the same as `task_number` (all project tasks) or `review_total_tasks` (auto-review stream pool).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rejected">
        /// Included only in responses
        /// </param>
        /// <param name="taskNumber">
        /// Total task number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalAnnotationsNumber">
        /// Included only in responses
        /// </param>
        /// <param name="totalPredictionsNumber">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseProjectCounts(
            string? duplicationStatus,
            int? numTasksWithAnnotations,
            int? queueLeft,
            int? reviewTotalTasks,
            int? reviewedNumber,
            int? skippedAnnotationsNumber,
            int? usefulAnnotationNumber,
            int finishedTaskNumber = default!,
            int groundTruthNumber = default!,
            int id = default!,
            int queueDone = default!,
            int queueTotal = default!,
            int rejected = default!,
            int taskNumber = default!,
            int totalAnnotationsNumber = default!,
            int totalPredictionsNumber = default!)
        {
            this.DuplicationStatus = duplicationStatus;
            this.FinishedTaskNumber = finishedTaskNumber;
            this.GroundTruthNumber = groundTruthNumber;
            this.Id = id;
            this.NumTasksWithAnnotations = numTasksWithAnnotations;
            this.QueueDone = queueDone;
            this.QueueLeft = queueLeft;
            this.QueueTotal = queueTotal;
            this.Rejected = rejected;
            this.ReviewTotalTasks = reviewTotalTasks;
            this.ReviewedNumber = reviewedNumber;
            this.SkippedAnnotationsNumber = skippedAnnotationsNumber;
            this.TaskNumber = taskNumber;
            this.TotalAnnotationsNumber = totalAnnotationsNumber;
            this.TotalPredictionsNumber = totalPredictionsNumber;
            this.UsefulAnnotationNumber = usefulAnnotationNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCounts" /> class.
        /// </summary>
        public LseProjectCounts()
        {
        }

    }
}