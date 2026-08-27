
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublishLearningResourceRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_reshown")]
        public bool? ForceReshown { get; set; }

        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.RetakeScopeEnumJsonConverter))]
        public global::LabelStudio.RetakeScopeEnum? RetakeScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishLearningResourceRequest" /> class.
        /// </summary>
        /// <param name="forceReshown">
        /// Default Value: false
        /// </param>
        /// <param name="retakeScope">
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishLearningResourceRequest(
            bool? forceReshown,
            global::LabelStudio.RetakeScopeEnum? retakeScope)
        {
            this.ForceReshown = forceReshown;
            this.RetakeScope = retakeScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishLearningResourceRequest" /> class.
        /// </summary>
        public PublishLearningResourceRequest()
        {
        }

    }
}