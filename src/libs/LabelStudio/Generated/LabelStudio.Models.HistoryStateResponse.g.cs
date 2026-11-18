
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryStateResponse
    {
        /// <summary>
        /// Same shape as `content` of the course detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.HistoryStateModule> Modules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pin")]
        public global::LabelStudio.HistoryPin? Pin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryStateResponse" /> class.
        /// </summary>
        /// <param name="content">
        /// Same shape as `content` of the course detail.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="label"></param>
        /// <param name="modules"></param>
        /// <param name="ref"></param>
        /// <param name="pin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryStateResponse(
            object content,
            global::System.DateTime createdAt,
            string label,
            global::System.Collections.Generic.IList<global::LabelStudio.HistoryStateModule> modules,
            string @ref,
            global::LabelStudio.HistoryPin? pin)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Modules = modules ?? throw new global::System.ArgumentNullException(nameof(modules));
            this.Pin = pin;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryStateResponse" /> class.
        /// </summary>
        public HistoryStateResponse()
        {
        }

    }
}