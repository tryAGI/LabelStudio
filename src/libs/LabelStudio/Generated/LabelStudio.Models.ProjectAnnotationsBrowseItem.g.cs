
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAnnotationsBrowseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Annotator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_id")]
        public int? AnnotatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAnnotationsBrowseItem" /> class.
        /// </summary>
        /// <param name="annotator"></param>
        /// <param name="createdAt"></param>
        /// <param name="groundTruth"></param>
        /// <param name="id"></param>
        /// <param name="result"></param>
        /// <param name="taskId"></param>
        /// <param name="title"></param>
        /// <param name="annotatorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAnnotationsBrowseItem(
            string annotator,
            string createdAt,
            bool groundTruth,
            int id,
            object result,
            int taskId,
            string title,
            int? annotatorId)
        {
            this.Annotator = annotator ?? throw new global::System.ArgumentNullException(nameof(annotator));
            this.AnnotatorId = annotatorId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.GroundTruth = groundTruth;
            this.Id = id;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.TaskId = taskId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAnnotationsBrowseItem" /> class.
        /// </summary>
        public ProjectAnnotationsBrowseItem()
        {
        }

    }
}