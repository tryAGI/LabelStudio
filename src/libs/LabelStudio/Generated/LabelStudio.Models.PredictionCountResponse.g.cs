
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existing_predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExistingPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_to_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TasksToRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCountResponse" /> class.
        /// </summary>
        /// <param name="existingPredictions"></param>
        /// <param name="tasksToRun"></param>
        /// <param name="totalTasks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionCountResponse(
            int existingPredictions,
            int tasksToRun,
            int totalTasks)
        {
            this.ExistingPredictions = existingPredictions;
            this.TasksToRun = tasksToRun;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCountResponse" /> class.
        /// </summary>
        public PredictionCountResponse()
        {
        }

    }
}