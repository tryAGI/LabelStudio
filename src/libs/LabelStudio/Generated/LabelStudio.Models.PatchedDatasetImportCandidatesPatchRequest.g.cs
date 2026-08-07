
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDatasetImportCandidatesPatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Operation type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signal")]
        public string? Signal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatasetImportCandidatesPatchRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal">
        /// Operation type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDatasetImportCandidatesPatchRequest(
            int? jobId,
            string? signal)
        {
            this.JobId = jobId;
            this.Signal = signal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatasetImportCandidatesPatchRequest" /> class.
        /// </summary>
        public PatchedDatasetImportCandidatesPatchRequest()
        {
        }

    }
}