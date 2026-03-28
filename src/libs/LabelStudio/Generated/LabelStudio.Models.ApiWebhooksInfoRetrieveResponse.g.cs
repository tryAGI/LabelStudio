
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiWebhooksInfoRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATIONS_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? AnnotationsCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATIONS_DELETED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? AnnotationsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATION_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated? AnnotationCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATION_UPDATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? AnnotationUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? LabelLinkCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_DELETED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? LabelLinkDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_UPDATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? LabelLinkUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_DELETED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted? ProjectDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_UPDATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEWS_DELETED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted? ReviewsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEW_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated? ReviewCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEW_UPDATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated? ReviewUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TASKS_CREATED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated? TasksCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TASKS_DELETED")]
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted? TasksDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponse" /> class.
        /// </summary>
        /// <param name="annotationsCreated"></param>
        /// <param name="annotationsDeleted"></param>
        /// <param name="annotationCreated"></param>
        /// <param name="annotationUpdated"></param>
        /// <param name="labelLinkCreated"></param>
        /// <param name="labelLinkDeleted"></param>
        /// <param name="labelLinkUpdated"></param>
        /// <param name="projectCreated"></param>
        /// <param name="projectDeleted"></param>
        /// <param name="projectUpdated"></param>
        /// <param name="reviewsDeleted"></param>
        /// <param name="reviewCreated"></param>
        /// <param name="reviewUpdated"></param>
        /// <param name="tasksCreated"></param>
        /// <param name="tasksDeleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiWebhooksInfoRetrieveResponse(
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? annotationsCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? annotationsDeleted,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated? annotationCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? annotationUpdated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? labelLinkCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? labelLinkDeleted,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? labelLinkUpdated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated? projectCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted? projectDeleted,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated? projectUpdated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted? reviewsDeleted,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated? reviewCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated? reviewUpdated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated? tasksCreated,
            global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted? tasksDeleted)
        {
            this.AnnotationsCreated = annotationsCreated;
            this.AnnotationsDeleted = annotationsDeleted;
            this.AnnotationCreated = annotationCreated;
            this.AnnotationUpdated = annotationUpdated;
            this.LabelLinkCreated = labelLinkCreated;
            this.LabelLinkDeleted = labelLinkDeleted;
            this.LabelLinkUpdated = labelLinkUpdated;
            this.ProjectCreated = projectCreated;
            this.ProjectDeleted = projectDeleted;
            this.ProjectUpdated = projectUpdated;
            this.ReviewsDeleted = reviewsDeleted;
            this.ReviewCreated = reviewCreated;
            this.ReviewUpdated = reviewUpdated;
            this.TasksCreated = tasksCreated;
            this.TasksDeleted = tasksDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponse" /> class.
        /// </summary>
        public ApiWebhooksInfoRetrieveResponse()
        {
        }
    }
}