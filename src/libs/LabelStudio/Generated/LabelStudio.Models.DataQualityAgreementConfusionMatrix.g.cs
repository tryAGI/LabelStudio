
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataQualityAgreementConfusionMatrix
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> Matrix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Precision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Recall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_confusion_pairs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair> TopConfusionPairs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementConfusionMatrix" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="matrix"></param>
        /// <param name="precision"></param>
        /// <param name="recall"></param>
        /// <param name="topConfusionPairs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataQualityAgreementConfusionMatrix(
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> matrix,
            global::System.Collections.Generic.IList<double> precision,
            global::System.Collections.Generic.IList<double> recall,
            global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair> topConfusionPairs)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Matrix = matrix ?? throw new global::System.ArgumentNullException(nameof(matrix));
            this.Precision = precision ?? throw new global::System.ArgumentNullException(nameof(precision));
            this.Recall = recall ?? throw new global::System.ArgumentNullException(nameof(recall));
            this.TopConfusionPairs = topConfusionPairs ?? throw new global::System.ArgumentNullException(nameof(topConfusionPairs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementConfusionMatrix" /> class.
        /// </summary>
        public DataQualityAgreementConfusionMatrix()
        {
        }
    }
}