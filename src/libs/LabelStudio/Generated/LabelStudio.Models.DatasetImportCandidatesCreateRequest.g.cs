
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetImportCandidatesCreateRequest
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_filters")]
        public object? AdditionalFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dataset { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        public object? Excluded { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public object? Included { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        public int? View { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportCandidatesCreateRequest" /> class.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="additionalFilters">
        /// Default Value: {}
        /// </param>
        /// <param name="excluded">
        /// Default Value: {}
        /// </param>
        /// <param name="included">
        /// Default Value: {}
        /// </param>
        /// <param name="project"></param>
        /// <param name="view"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetImportCandidatesCreateRequest(
            int dataset,
            object? additionalFilters,
            object? excluded,
            object? included,
            int? project,
            int? view)
        {
            this.AdditionalFilters = additionalFilters;
            this.Dataset = dataset;
            this.Excluded = excluded;
            this.Included = included;
            this.Project = project;
            this.View = view;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportCandidatesCreateRequest" /> class.
        /// </summary>
        public DatasetImportCandidatesCreateRequest()
        {
        }

    }
}