
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseProjectStateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanDeleteTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_manage_annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanManageAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_manage_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanManageTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_has_control_tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConfigHasControlTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_syncing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SourceSyncing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_syncing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TargetSyncing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectStateResponse" /> class.
        /// </summary>
        /// <param name="annotationCount"></param>
        /// <param name="canDeleteTasks"></param>
        /// <param name="canManageAnnotations"></param>
        /// <param name="canManageTasks"></param>
        /// <param name="configHasControlTags"></param>
        /// <param name="sourceSyncing"></param>
        /// <param name="targetSyncing"></param>
        /// <param name="taskCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseProjectStateResponse(
            int annotationCount,
            bool canDeleteTasks,
            bool canManageAnnotations,
            bool canManageTasks,
            bool configHasControlTags,
            bool sourceSyncing,
            bool targetSyncing,
            int taskCount)
        {
            this.AnnotationCount = annotationCount;
            this.CanDeleteTasks = canDeleteTasks;
            this.CanManageAnnotations = canManageAnnotations;
            this.CanManageTasks = canManageTasks;
            this.ConfigHasControlTags = configHasControlTags;
            this.SourceSyncing = sourceSyncing;
            this.TargetSyncing = targetSyncing;
            this.TaskCount = taskCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectStateResponse" /> class.
        /// </summary>
        public LseProjectStateResponse()
        {
        }

    }
}