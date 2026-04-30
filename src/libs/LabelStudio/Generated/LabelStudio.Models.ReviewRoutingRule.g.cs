
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewRoutingRule
    {
        /// <summary>
        /// Agreement threshold (0..1) compared against the rule operator. Required when operator is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_threshold")]
        public string? AgreementThreshold { get; set; }

        /// <summary>
        /// Time this rule was created<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Dimension whose agreement is compared. Null =&gt; compare overall task agreement. Deleting the dimension cascades to the rule (a dimension-scoped rule has no meaning without its dimension; falling back to overall agreement would silently change the cohort).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Comparison operator applied to the agreement value. Null =&gt; catch-all rule.<br/>
        /// * `lt` - &lt;<br/>
        /// * `lte` - &lt;=<br/>
        /// * `gt` - &gt;<br/>
        /// * `gte` - &gt;=<br/>
        /// * `eq` - =
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OperatorEnumJsonConverter))]
        public global::LabelStudio.OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Position in the rule list (rules are evaluated in ascending order)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int Order { get; set; } = default!;

        /// <summary>
        /// Sample rate (0..1) of matching tasks routed for review. 1 always routes, 0 never routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public string? SampleRate { get; set; }

        /// <summary>
        /// Last time this rule was updated<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRule" /> class.
        /// </summary>
        /// <param name="agreementThreshold">
        /// Agreement threshold (0..1) compared against the rule operator. Required when operator is set.
        /// </param>
        /// <param name="dimension">
        /// Dimension whose agreement is compared. Null =&gt; compare overall task agreement. Deleting the dimension cascades to the rule (a dimension-scoped rule has no meaning without its dimension; falling back to overall agreement would silently change the cohort).
        /// </param>
        /// <param name="id"></param>
        /// <param name="operator">
        /// Comparison operator applied to the agreement value. Null =&gt; catch-all rule.<br/>
        /// * `lt` - &lt;<br/>
        /// * `lte` - &lt;=<br/>
        /// * `gt` - &gt;<br/>
        /// * `gte` - &gt;=<br/>
        /// * `eq` - =
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate (0..1) of matching tasks routed for review. 1 always routes, 0 never routes.
        /// </param>
        /// <param name="createdAt">
        /// Time this rule was created<br/>
        /// Included only in responses
        /// </param>
        /// <param name="order">
        /// Position in the rule list (rules are evaluated in ascending order)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last time this rule was updated<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewRoutingRule(
            string? agreementThreshold,
            int? dimension,
            int? id,
            global::LabelStudio.OperatorEnum? @operator,
            string? sampleRate,
            global::System.DateTime createdAt = default!,
            int order = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AgreementThreshold = agreementThreshold;
            this.CreatedAt = createdAt;
            this.Dimension = dimension;
            this.Id = id;
            this.Operator = @operator;
            this.Order = order;
            this.SampleRate = sampleRate;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewRoutingRule" /> class.
        /// </summary>
        public ReviewRoutingRule()
        {
        }
    }
}