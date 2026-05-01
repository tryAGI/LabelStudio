
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsMemberPerformanceRowsRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<object>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsMemberPerformanceRowsRetrieveResponse" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="results"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsMemberPerformanceRowsRetrieveResponse(
            int? count,
            int? page,
            int? pageSize,
            global::System.Collections.Generic.IList<object>? results,
            object? summary)
        {
            this.Count = count;
            this.Page = page;
            this.PageSize = pageSize;
            this.Results = results;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsMemberPerformanceRowsRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsMemberPerformanceRowsRetrieveResponse()
        {
        }
    }
}