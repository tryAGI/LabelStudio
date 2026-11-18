
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistorySave
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::LabelStudio.HistoryUser? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

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
        /// Initializes a new instance of the <see cref="HistorySave" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="kind"></param>
        /// <param name="ref"></param>
        /// <param name="createdBy"></param>
        /// <param name="pageId"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistorySave(
            global::System.DateTime createdAt,
            string kind,
            string @ref,
            global::LabelStudio.HistoryUser? createdBy,
            string? pageId,
            string? title)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.PageId = pageId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySave" /> class.
        /// </summary>
        public HistorySave()
        {
        }

    }
}