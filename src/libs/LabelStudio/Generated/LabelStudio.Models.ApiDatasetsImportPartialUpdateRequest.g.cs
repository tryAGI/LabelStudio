
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDatasetsImportPartialUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// Operation type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDatasetsImportPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal">
        /// Operation type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDatasetsImportPartialUpdateRequest(
            int jobId,
            string signal)
        {
            this.JobId = jobId;
            this.Signal = signal ?? throw new global::System.ArgumentNullException(nameof(signal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDatasetsImportPartialUpdateRequest" /> class.
        /// </summary>
        public ApiDatasetsImportPartialUpdateRequest()
        {
        }

    }
}