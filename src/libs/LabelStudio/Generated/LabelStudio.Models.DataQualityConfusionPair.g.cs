
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataQualityConfusionPair
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Actual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityConfusionPair" /> class.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="count"></param>
        /// <param name="label"></param>
        /// <param name="rate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataQualityConfusionPair(
            string actual,
            int count,
            string label,
            double rate)
        {
            this.Actual = actual ?? throw new global::System.ArgumentNullException(nameof(actual));
            this.Count = count;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityConfusionPair" /> class.
        /// </summary>
        public DataQualityConfusionPair()
        {
        }
    }
}