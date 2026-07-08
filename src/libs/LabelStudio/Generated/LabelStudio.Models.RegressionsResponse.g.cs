
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegressionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Improvements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> New { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Regressions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Removed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_a")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_b")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stable_correct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> StableCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stable_incorrect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> StableIncorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.RegressionSummary Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegressionsResponse" /> class.
        /// </summary>
        /// <param name="improvements"></param>
        /// <param name="new"></param>
        /// <param name="regressions"></param>
        /// <param name="removed"></param>
        /// <param name="runA"></param>
        /// <param name="runB"></param>
        /// <param name="stableCorrect"></param>
        /// <param name="stableIncorrect"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegressionsResponse(
            global::System.Collections.Generic.IList<object> improvements,
            global::System.Collections.Generic.IList<object> @new,
            global::System.Collections.Generic.IList<object> regressions,
            global::System.Collections.Generic.IList<object> removed,
            int runA,
            int runB,
            global::System.Collections.Generic.IList<object> stableCorrect,
            global::System.Collections.Generic.IList<object> stableIncorrect,
            global::LabelStudio.RegressionSummary summary)
        {
            this.Improvements = improvements ?? throw new global::System.ArgumentNullException(nameof(improvements));
            this.New = @new ?? throw new global::System.ArgumentNullException(nameof(@new));
            this.Regressions = regressions ?? throw new global::System.ArgumentNullException(nameof(regressions));
            this.Removed = removed ?? throw new global::System.ArgumentNullException(nameof(removed));
            this.RunA = runA;
            this.RunB = runB;
            this.StableCorrect = stableCorrect ?? throw new global::System.ArgumentNullException(nameof(stableCorrect));
            this.StableIncorrect = stableIncorrect ?? throw new global::System.ArgumentNullException(nameof(stableIncorrect));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegressionsResponse" /> class.
        /// </summary>
        public RegressionsResponse()
        {
        }

    }
}