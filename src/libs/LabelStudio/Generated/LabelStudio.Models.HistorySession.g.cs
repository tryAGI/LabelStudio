
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistorySession
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistoryUser> Authors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistorySessionPage> Pages { get; set; }

        /// <summary>
        /// The session's last revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored_from")]
        public global::LabelStudio.HistoryRestoredFrom? RestoredFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saves")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Saves { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StructureChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySession" /> class.
        /// </summary>
        /// <param name="authors"></param>
        /// <param name="endedAt"></param>
        /// <param name="inProgress"></param>
        /// <param name="pages"></param>
        /// <param name="ref">
        /// The session's last revision.
        /// </param>
        /// <param name="saves"></param>
        /// <param name="startedAt"></param>
        /// <param name="structureChanges"></param>
        /// <param name="restoredFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistorySession(
            global::System.Collections.Generic.IList<global::LabelStudio.HistoryUser> authors,
            global::System.DateTime endedAt,
            bool inProgress,
            global::System.Collections.Generic.IList<global::LabelStudio.HistorySessionPage> pages,
            string @ref,
            int saves,
            global::System.DateTime startedAt,
            int structureChanges,
            global::LabelStudio.HistoryRestoredFrom? restoredFrom)
        {
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.EndedAt = endedAt;
            this.InProgress = inProgress;
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RestoredFrom = restoredFrom;
            this.Saves = saves;
            this.StartedAt = startedAt;
            this.StructureChanges = structureChanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySession" /> class.
        /// </summary>
        public HistorySession()
        {
        }

    }
}