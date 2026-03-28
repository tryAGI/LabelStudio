
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillStatusResponse
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
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Job ID (if fetching a specific job)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Aggregated organization status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_status")]
        public global::LabelStudio.StateBackfillOrgStatus? OrgStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::LabelStudio.StateBackfillProgress? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_job_info")]
        public object? RqJobInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="StateBackfillStatusResponse" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="jobId">
        /// Job ID (if fetching a specific job)
        /// </param>
        /// <param name="orgStatus">
        /// Aggregated organization status
        /// </param>
        /// <param name="progress"></param>
        /// <param name="rqJobId"></param>
        /// <param name="rqJobInfo"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="triggeredBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StateBackfillStatusResponse(
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? errorMessage,
            int? jobId,
            global::LabelStudio.StateBackfillOrgStatus? orgStatus,
            global::LabelStudio.StateBackfillProgress? progress,
            string? rqJobId,
            object? rqJobInfo,
            global::System.DateTime? startedAt,
            string? status,
            global::LabelStudio.StateTriggeredBy? triggeredBy)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.ErrorMessage = errorMessage;
            this.JobId = jobId;
            this.OrgStatus = orgStatus;
            this.Progress = progress;
            this.RqJobId = rqJobId;
            this.RqJobInfo = rqJobInfo;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillStatusResponse" /> class.
        /// </summary>
        public StateBackfillStatusResponse()
        {
        }
    }
}