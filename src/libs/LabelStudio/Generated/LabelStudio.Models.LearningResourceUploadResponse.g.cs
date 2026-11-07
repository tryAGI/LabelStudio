
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LearningResourceUploadResponse
    {
        /// <summary>
        /// * `uploaded` - uploaded<br/>
        /// * `imported` - imported<br/>
        /// * `unchanged` - unchanged<br/>
        /// * `importable` - importable<br/>
        /// * `external` - external
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.LearningResourceUploadResponseStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.LearningResourceUploadResponseStatusEnum Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceUploadResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// * `uploaded` - uploaded<br/>
        /// * `imported` - imported<br/>
        /// * `unchanged` - unchanged<br/>
        /// * `importable` - importable<br/>
        /// * `external` - external
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceUploadResponse(
            global::LabelStudio.LearningResourceUploadResponseStatusEnum status,
            string url)
        {
            this.Status = status;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceUploadResponse" /> class.
        /// </summary>
        public LearningResourceUploadResponse()
        {
        }

    }
}