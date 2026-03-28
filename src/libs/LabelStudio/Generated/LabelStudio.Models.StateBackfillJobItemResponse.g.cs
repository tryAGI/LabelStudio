
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillJobItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_data")]
        public global::LabelStudio.StateBackfillProgress? ProgressData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        public global::LabelStudio.StateTriggeredBy? TriggeredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItemResponse" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="jobId"></param>
        /// <param name="progressData"></param>
        /// <param name="rqJobId"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="triggeredBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StateBackfillJobItemResponse(
            global::System.DateTime createdAt,
            int jobId,
            string status,
            global::System.DateTime? completedAt,
            string? errorMessage,
            global::LabelStudio.StateBackfillProgress? progressData,
            string? rqJobId,
            global::System.DateTime? startedAt,
            global::LabelStudio.StateTriggeredBy? triggeredBy)
        {
            this.CreatedAt = createdAt;
            this.JobId = jobId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CompletedAt = completedAt;
            this.ErrorMessage = errorMessage;
            this.ProgressData = progressData;
            this.RqJobId = rqJobId;
            this.StartedAt = startedAt;
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItemResponse" /> class.
        /// </summary>
        public StateBackfillJobItemResponse()
        {
        }
    }
}