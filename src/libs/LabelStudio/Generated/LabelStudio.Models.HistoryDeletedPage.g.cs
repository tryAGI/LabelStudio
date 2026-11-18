
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryDeletedPage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DeletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by")]
        public global::LabelStudio.HistoryUser? DeletedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_id")]
        public int? ModuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageId { get; set; }

        /// <summary>
        /// The tombstone revision. Restore it with `scope=page`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDeletedPage" /> class.
        /// </summary>
        /// <param name="deletedAt"></param>
        /// <param name="pageId"></param>
        /// <param name="ref">
        /// The tombstone revision. Restore it with `scope=page`.
        /// </param>
        /// <param name="title"></param>
        /// <param name="deletedBy"></param>
        /// <param name="moduleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryDeletedPage(
            global::System.DateTime deletedAt,
            string pageId,
            string @ref,
            string title,
            global::LabelStudio.HistoryUser? deletedBy,
            int? moduleId)
        {
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.ModuleId = moduleId;
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDeletedPage" /> class.
        /// </summary>
        public HistoryDeletedPage()
        {
        }

    }
}