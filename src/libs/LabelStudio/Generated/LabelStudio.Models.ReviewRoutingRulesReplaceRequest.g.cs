
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewRoutingRulesReplaceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRulesReplaceRequest" /> class.
        /// </summary>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewRoutingRulesReplaceRequest(
            global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest> rules)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRulesReplaceRequest" /> class.
        /// </summary>
        public ReviewRoutingRulesReplaceRequest()
        {
        }
    }
}