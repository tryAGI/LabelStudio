
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataQualityAgreementDimensions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement")]
        public double? Agreement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_tag")]
        public string? ControlTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementDimensions" /> class.
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="name"></param>
        /// <param name="agreement"></param>
        /// <param name="controlTag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataQualityAgreementDimensions(
            string fromName,
            string name,
            double? agreement,
            string? controlTag)
        {
            this.Agreement = agreement;
            this.ControlTag = controlTag;
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementDimensions" /> class.
        /// </summary>
        public DataQualityAgreementDimensions()
        {
        }

    }
}