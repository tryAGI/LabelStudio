
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TryTaskRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_override")]
        public string? PromptOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TryTaskRequestRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="taskId"></param>
        /// <param name="promptOverride"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TryTaskRequestRequest(
            int projectId,
            int taskId,
            string? promptOverride)
        {
            this.ProjectId = projectId;
            this.PromptOverride = promptOverride;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TryTaskRequestRequest" /> class.
        /// </summary>
        public TryTaskRequestRequest()
        {
        }

    }
}