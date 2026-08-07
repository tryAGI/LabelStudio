
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MLBackendTrainRequestRequest
    {
        /// <summary>
        /// Whether to include ground truth annotations in training<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_ground_truth")]
        public bool? UseGroundTruth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackendTrainRequestRequest" /> class.
        /// </summary>
        /// <param name="useGroundTruth">
        /// Whether to include ground truth annotations in training<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MLBackendTrainRequestRequest(
            bool? useGroundTruth)
        {
            this.UseGroundTruth = useGroundTruth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackendTrainRequestRequest" /> class.
        /// </summary>
        public MLBackendTrainRequestRequest()
        {
        }

    }
}