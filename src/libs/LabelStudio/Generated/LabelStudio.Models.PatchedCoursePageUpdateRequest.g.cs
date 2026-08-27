
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Page-scoped content save: only the supplied keys are replaced.
    /// </summary>
    public sealed partial class PatchedCoursePageUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        public global::System.Collections.Generic.IList<object>? Blocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_version")]
        public int? PageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCoursePageUpdateRequest" /> class.
        /// </summary>
        /// <param name="blocks"></param>
        /// <param name="pageVersion"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedCoursePageUpdateRequest(
            global::System.Collections.Generic.IList<object>? blocks,
            int? pageVersion,
            string? summary,
            string? title)
        {
            this.Blocks = blocks;
            this.PageVersion = pageVersion;
            this.Summary = summary;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCoursePageUpdateRequest" /> class.
        /// </summary>
        public PatchedCoursePageUpdateRequest()
        {
        }

    }
}