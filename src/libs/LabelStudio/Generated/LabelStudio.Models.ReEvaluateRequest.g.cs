
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReEvaluateRequest
    {
        /// <summary>
        /// * `failed` - failed<br/>
        /// * `incorrect` - incorrect<br/>
        /// * `regressions` - regressions<br/>
        /// * `custom` - custom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ReEvaluateModeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.ReEvaluateModeEnum Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_b_id")]
        public int? RunBId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_model_run_id")]
        public int? SourceModelRunId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public global::System.Collections.Generic.IList<int>? TaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReEvaluateRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// * `failed` - failed<br/>
        /// * `incorrect` - incorrect<br/>
        /// * `regressions` - regressions<br/>
        /// * `custom` - custom
        /// </param>
        /// <param name="modelVersionId"></param>
        /// <param name="runBId"></param>
        /// <param name="sourceModelRunId"></param>
        /// <param name="taskIds">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReEvaluateRequest(
            global::LabelStudio.ReEvaluateModeEnum mode,
            int modelVersionId,
            int? runBId,
            int? sourceModelRunId,
            global::System.Collections.Generic.IList<int>? taskIds)
        {
            this.Mode = mode;
            this.ModelVersionId = modelVersionId;
            this.RunBId = runBId;
            this.SourceModelRunId = sourceModelRunId;
            this.TaskIds = taskIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReEvaluateRequest" /> class.
        /// </summary>
        public ReEvaluateRequest()
        {
        }
    }
}