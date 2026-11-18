
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryAnchorUnavailable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Newest surviving state at or before the anchor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nearest_ref")]
        public string? NearestRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAnchorUnavailable" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="detail"></param>
        /// <param name="nearestRef">
        /// Newest surviving state at or before the anchor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryAnchorUnavailable(
            string code,
            string detail,
            string? nearestRef)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.NearestRef = nearestRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryAnchorUnavailable" /> class.
        /// </summary>
        public HistoryAnchorUnavailable()
        {
        }

    }
}