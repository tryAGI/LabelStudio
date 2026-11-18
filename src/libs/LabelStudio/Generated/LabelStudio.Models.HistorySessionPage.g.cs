
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistorySessionPage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saves")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Saves { get; set; }

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
        /// Initializes a new instance of the <see cref="HistorySessionPage" /> class.
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="ref"></param>
        /// <param name="saves"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistorySessionPage(
            string pageId,
            string @ref,
            int saves,
            string title)
        {
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Saves = saves;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySessionPage" /> class.
        /// </summary>
        public HistorySessionPage()
        {
        }

    }
}