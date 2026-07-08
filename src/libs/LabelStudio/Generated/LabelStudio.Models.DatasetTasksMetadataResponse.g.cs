
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetTasksMetadataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CandidateTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTasksMetadataResponse" /> class.
        /// </summary>
        /// <param name="candidateTaskId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetTasksMetadataResponse(
            string candidateTaskId,
            object metadata)
        {
            this.CandidateTaskId = candidateTaskId ?? throw new global::System.ArgumentNullException(nameof(candidateTaskId));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTasksMetadataResponse" /> class.
        /// </summary>
        public DatasetTasksMetadataResponse()
        {
        }

    }
}