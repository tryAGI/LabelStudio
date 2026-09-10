
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelDistributionStructureResponse
    {
        /// <summary>
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice_keys")]
        public global::System.Collections.Generic.IList<string> ChoiceKeys { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension> Dimensions { get; set; }

        /// <summary>
        /// True when the project has at least one Prediction row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_predictions")]
        public bool? HasPredictions { get; set; }

        /// <summary>
        /// True when the UI may offer prediction-scoped filters (prediction identity ready and the project has predictions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_filters_supported")]
        public bool? PredictionFiltersSupported { get; set; }

        /// <summary>
        /// True when dimension value-counts cache is at prediction-identity version 2. Prediction-scoped Label Distribution filters require this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_identity_ready")]
        public bool? PredictionIdentityReady { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        /// <param name="dimensions"></param>
        /// <param name="hasPredictions">
        /// True when the project has at least one Prediction row.
        /// </param>
        /// <param name="predictionFiltersSupported">
        /// True when the UI may offer prediction-scoped filters (prediction identity ready and the project has predictions).
        /// </param>
        /// <param name="predictionIdentityReady">
        /// True when dimension value-counts cache is at prediction-identity version 2. Prediction-scoped Label Distribution filters require this.
        /// </param>
        /// <param name="choiceKeys">
        /// All project choice keys in stable order, joined with "___PIPE___" when passed as query param.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionStructureResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension> dimensions,
            bool? hasPredictions,
            bool? predictionFiltersSupported,
            bool? predictionIdentityReady,
            global::System.Collections.Generic.IList<string> choiceKeys = default!)
        {
            this.ChoiceKeys = choiceKeys;
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.HasPredictions = hasPredictions;
            this.PredictionFiltersSupported = predictionFiltersSupported;
            this.PredictionIdentityReady = predictionIdentityReady;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionStructureResponse" /> class.
        /// </summary>
        public LabelDistributionStructureResponse()
        {
        }

    }
}