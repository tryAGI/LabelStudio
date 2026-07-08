
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetImportCandidatesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_tasks")]
        public int? ProjectTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public int? Skipped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportCandidatesResponse" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="job"></param>
        /// <param name="projectTasks"></param>
        /// <param name="skipped"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetImportCandidatesResponse(
            string? detail,
            int? job,
            int? projectTasks,
            int? skipped,
            int? total)
        {
            this.Detail = detail;
            this.Job = job;
            this.ProjectTasks = projectTasks;
            this.Skipped = skipped;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportCandidatesResponse" /> class.
        /// </summary>
        public DatasetImportCandidatesResponse()
        {
        }

    }
}