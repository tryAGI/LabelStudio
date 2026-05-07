
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataQualityAgreementDistribution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_agreement")]
        public double? AverageAgreement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("histogram")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Histogram { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_agreement_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LowAgreementCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementDistribution" /> class.
        /// </summary>
        /// <param name="histogram"></param>
        /// <param name="lowAgreementCount"></param>
        /// <param name="totalTasks"></param>
        /// <param name="averageAgreement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataQualityAgreementDistribution(
            global::System.Collections.Generic.IList<int> histogram,
            int lowAgreementCount,
            int totalTasks,
            double? averageAgreement)
        {
            this.AverageAgreement = averageAgreement;
            this.Histogram = histogram ?? throw new global::System.ArgumentNullException(nameof(histogram));
            this.LowAgreementCount = lowAgreementCount;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataQualityAgreementDistribution" /> class.
        /// </summary>
        public DataQualityAgreementDistribution()
        {
        }
    }
}