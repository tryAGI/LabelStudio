
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiProjectsUserStatsPredictionRetrieveResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_prediction_agreement_per_user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? AveragePredictionAgreementPerUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="averagePredictionAgreementPerUser"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsUserStatsPredictionRetrieveResponse(
            global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? averagePredictionAgreementPerUser)
        {
            this.AveragePredictionAgreementPerUser = averagePredictionAgreementPerUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsUserStatsPredictionRetrieveResponse()
        {
        }

    }
}