
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewRoutingRuleRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_threshold")]
        public string? AgreementThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OperatorEnumJsonConverter))]
        public global::LabelStudio.OperatorEnum? Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRuleRequestRequest" /> class.
        /// </summary>
        /// <param name="sampleRate"></param>
        /// <param name="agreementThreshold"></param>
        /// <param name="dimension"></param>
        /// <param name="id"></param>
        /// <param name="operator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewRoutingRuleRequestRequest(
            string sampleRate,
            string? agreementThreshold,
            int? dimension,
            int? id,
            global::LabelStudio.OperatorEnum? @operator)
        {
            this.AgreementThreshold = agreementThreshold;
            this.Dimension = dimension;
            this.Id = id;
            this.Operator = @operator;
            this.SampleRate = sampleRate ?? throw new global::System.ArgumentNullException(nameof(sampleRate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRuleRequestRequest" /> class.
        /// </summary>
        public ReviewRoutingRuleRequestRequest()
        {
        }
    }
}