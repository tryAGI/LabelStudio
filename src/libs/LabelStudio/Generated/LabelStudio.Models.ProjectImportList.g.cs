
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Slim list serializer — excludes large fields like task_ids.
    /// </summary>
    public sealed partial class ProjectImportList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_count")]
        public int? AnnotationCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_to_project")]
        public bool? CommitToProject { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload_ids")]
        public object? FileUploadIds { get; set; }

        /// <summary>
        /// Complete or fail time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_count")]
        public int? PredictionCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ProjectImportStatusEnumJsonConverter))]
        public global::LabelStudio.ProjectImportStatusEnum? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_count")]
        public int? TaskCount { get; set; }

        /// <summary>
        /// Last time import progress or terminal status was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImportList" /> class.
        /// </summary>
        /// <param name="annotationCount"></param>
        /// <param name="commitToProject"></param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="duration"></param>
        /// <param name="error"></param>
        /// <param name="fileUploadIds"></param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="predictionCount"></param>
        /// <param name="project"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </param>
        /// <param name="taskCount"></param>
        /// <param name="updatedAt">
        /// Last time import progress or terminal status was updated
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectImportList(
            int? annotationCount,
            bool? commitToProject,
            global::System.DateTime? createdAt,
            int? duration,
            string? error,
            object? fileUploadIds,
            global::System.DateTime? finishedAt,
            int? predictionCount,
            int? project,
            global::LabelStudio.ProjectImportStatusEnum? status,
            int? taskCount,
            global::System.DateTime? updatedAt,
            int id = default!)
        {
            this.AnnotationCount = annotationCount;
            this.CommitToProject = commitToProject;
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.Error = error;
            this.FileUploadIds = fileUploadIds;
            this.FinishedAt = finishedAt;
            this.Id = id;
            this.PredictionCount = predictionCount;
            this.Project = project;
            this.Status = status;
            this.TaskCount = taskCount;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImportList" /> class.
        /// </summary>
        public ProjectImportList()
        {
        }

    }
}