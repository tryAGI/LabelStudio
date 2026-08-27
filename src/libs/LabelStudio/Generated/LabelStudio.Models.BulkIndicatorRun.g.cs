
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkIndicatorRun
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indicators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Indicators { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_display_name")]
        public string? ModelDisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelVersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelVersionTitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_subset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectSubset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_correct_predictions")]
        public int? TotalCorrectPredictions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        public int? TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIndicatorRun" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="indicators"></param>
        /// <param name="modelVersionId"></param>
        /// <param name="modelVersionTitle"></param>
        /// <param name="projectSubset"></param>
        /// <param name="runId"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="modelDisplayName"></param>
        /// <param name="totalCorrectPredictions"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="totalTasks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkIndicatorRun(
            string createdAt,
            object indicators,
            int modelVersionId,
            string modelVersionTitle,
            string projectSubset,
            int runId,
            string status,
            string? completedAt,
            string? modelDisplayName,
            int? totalCorrectPredictions,
            int? totalPredictions,
            int? totalTasks)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Indicators = indicators ?? throw new global::System.ArgumentNullException(nameof(indicators));
            this.ModelDisplayName = modelDisplayName;
            this.ModelVersionId = modelVersionId;
            this.ModelVersionTitle = modelVersionTitle ?? throw new global::System.ArgumentNullException(nameof(modelVersionTitle));
            this.ProjectSubset = projectSubset ?? throw new global::System.ArgumentNullException(nameof(projectSubset));
            this.RunId = runId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TotalCorrectPredictions = totalCorrectPredictions;
            this.TotalPredictions = totalPredictions;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkIndicatorRun" /> class.
        /// </summary>
        public BulkIndicatorRun()
        {
        }

    }
}