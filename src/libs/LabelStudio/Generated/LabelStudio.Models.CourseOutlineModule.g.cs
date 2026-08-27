
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CourseOutlineModule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marked_stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MarkedStale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage> Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SortOrder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::LabelStudio.UserSimple? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseOutlineModule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="markedStale"></param>
        /// <param name="pages"></param>
        /// <param name="sortOrder"></param>
        /// <param name="title"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseOutlineModule(
            int id,
            bool markedStale,
            global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage> pages,
            int sortOrder,
            string title,
            global::LabelStudio.UserSimple? updatedBy)
        {
            this.Id = id;
            this.MarkedStale = markedStale;
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.SortOrder = sortOrder;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseOutlineModule" /> class.
        /// </summary>
        public CourseOutlineModule()
        {
        }

    }
}