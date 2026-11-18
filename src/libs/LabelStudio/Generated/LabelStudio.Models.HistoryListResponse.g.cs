
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.HistoryCurrent Current { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistoryDeletedPage> DeletedPages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_before")]
        public int? NextBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistoryPin> Pins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistorySession> Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryListResponse" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="deletedPages"></param>
        /// <param name="pins"></param>
        /// <param name="sessions"></param>
        /// <param name="nextBefore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryListResponse(
            global::LabelStudio.HistoryCurrent current,
            global::System.Collections.Generic.IList<global::LabelStudio.HistoryDeletedPage> deletedPages,
            global::System.Collections.Generic.IList<global::LabelStudio.HistoryPin> pins,
            global::System.Collections.Generic.IList<global::LabelStudio.HistorySession> sessions,
            int? nextBefore)
        {
            this.Current = current ?? throw new global::System.ArgumentNullException(nameof(current));
            this.DeletedPages = deletedPages ?? throw new global::System.ArgumentNullException(nameof(deletedPages));
            this.NextBefore = nextBefore;
            this.Pins = pins ?? throw new global::System.ArgumentNullException(nameof(pins));
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryListResponse" /> class.
        /// </summary>
        public HistoryListResponse()
        {
        }

    }
}