
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchPredictionsRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelrun_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelrunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPredictionsRequestRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="modelrunId"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchPredictionsRequestRequest(
            int modelrunId,
            global::System.Collections.Generic.IList<object> results,
            string? jobId)
        {
            this.ModelrunId = modelrunId;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.JobId = jobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPredictionsRequestRequest" /> class.
        /// </summary>
        public BatchPredictionsRequestRequest()
        {
        }
    }
}