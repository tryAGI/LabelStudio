
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistorySessionSavesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saves")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistorySave> Saves { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySessionSavesResponse" /> class.
        /// </summary>
        /// <param name="saves"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistorySessionSavesResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.HistorySave> saves)
        {
            this.Saves = saves ?? throw new global::System.ArgumentNullException(nameof(saves));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySessionSavesResponse" /> class.
        /// </summary>
        public HistorySessionSavesResponse()
        {
        }

    }
}