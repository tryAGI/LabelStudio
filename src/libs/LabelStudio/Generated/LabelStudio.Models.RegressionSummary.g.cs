
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegressionSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Improvements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int New { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Regressions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Removed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stable_correct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StableCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stable_incorrect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StableIncorrect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegressionSummary" /> class.
        /// </summary>
        /// <param name="improvements"></param>
        /// <param name="new"></param>
        /// <param name="regressions"></param>
        /// <param name="removed"></param>
        /// <param name="stableCorrect"></param>
        /// <param name="stableIncorrect"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegressionSummary(
            int improvements,
            int @new,
            int regressions,
            int removed,
            int stableCorrect,
            int stableIncorrect)
        {
            this.Improvements = improvements;
            this.New = @new;
            this.Regressions = regressions;
            this.Removed = removed;
            this.StableCorrect = stableCorrect;
            this.StableIncorrect = stableIncorrect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegressionSummary" /> class.
        /// </summary>
        public RegressionSummary()
        {
        }

    }
}