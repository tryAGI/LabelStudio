
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryPin
    {
        /// <summary>
        /// Revision id the pin was taken at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public int? Anchor { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_current_published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrentPublished { get; set; }

        /// <summary>
        /// * `named` - named<br/>
        /// * `published` - published<br/>
        /// * `before_restore` - before_restore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.HistoryPinKindEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.HistoryPinKindEnum Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="HistoryPin" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="isCurrentPublished"></param>
        /// <param name="kind">
        /// * `named` - named<br/>
        /// * `published` - published<br/>
        /// * `before_restore` - before_restore
        /// </param>
        /// <param name="ref"></param>
        /// <param name="anchor">
        /// Revision id the pin was taken at.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryPin(
            global::System.DateTime createdAt,
            int id,
            bool isCurrentPublished,
            global::LabelStudio.HistoryPinKindEnum kind,
            string @ref,
            int? anchor,
            global::LabelStudio.HistoryUser? createdBy,
            string? name)
        {
            this.Anchor = anchor;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.IsCurrentPublished = isCurrentPublished;
            this.Kind = kind;
            this.Name = name;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryPin" /> class.
        /// </summary>
        public HistoryPin()
        {
        }

    }
}