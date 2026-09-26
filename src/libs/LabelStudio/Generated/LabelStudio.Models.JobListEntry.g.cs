
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobListEntry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enqueued_at")]
        public string? EnqueuedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_key")]
        public string? ExecutionKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public string? FailedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_func")]
        public string? JobFunc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lane")]
        public object? Lane { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lease")]
        public object? Lease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public string? Queue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobListEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="enqueuedAt"></param>
        /// <param name="executionKey"></param>
        /// <param name="failedAt"></param>
        /// <param name="jobFunc"></param>
        /// <param name="lane"></param>
        /// <param name="lease"></param>
        /// <param name="queue"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobListEntry(
            string id,
            string status,
            string? enqueuedAt,
            string? executionKey,
            string? failedAt,
            string? jobFunc,
            object? lane,
            object? lease,
            string? queue,
            string? startedAt)
        {
            this.EnqueuedAt = enqueuedAt;
            this.ExecutionKey = executionKey;
            this.FailedAt = failedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.JobFunc = jobFunc;
            this.Lane = lane;
            this.Lease = lease;
            this.Queue = queue;
            this.StartedAt = startedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobListEntry" /> class.
        /// </summary>
        public JobListEntry()
        {
        }

    }
}