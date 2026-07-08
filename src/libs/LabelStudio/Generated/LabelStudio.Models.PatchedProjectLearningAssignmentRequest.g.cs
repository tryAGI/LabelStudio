
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedProjectLearningAssignmentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_manual_access")]
        public bool? AllowManualAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_annotator_data_manager")]
        public bool? GateAnnotatorDataManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_annotator_label_stream")]
        public bool? GateAnnotatorLabelStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_reviewer_data_manager")]
        public bool? GateReviewerDataManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_reviewer_label_stream")]
        public bool? GateReviewerLabelStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_reviewer_review_stream")]
        public bool? GateReviewerReviewStream { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_resource_id")]
        public int? LearningResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedProjectLearningAssignmentRequest" /> class.
        /// </summary>
        /// <param name="allowManualAccess"></param>
        /// <param name="gateAnnotatorDataManager"></param>
        /// <param name="gateAnnotatorLabelStream"></param>
        /// <param name="gateReviewerDataManager"></param>
        /// <param name="gateReviewerLabelStream"></param>
        /// <param name="gateReviewerReviewStream"></param>
        /// <param name="learningResourceId">
        /// Included only in requests
        /// </param>
        /// <param name="sortOrder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedProjectLearningAssignmentRequest(
            bool? allowManualAccess,
            bool? gateAnnotatorDataManager,
            bool? gateAnnotatorLabelStream,
            bool? gateReviewerDataManager,
            bool? gateReviewerLabelStream,
            bool? gateReviewerReviewStream,
            int? learningResourceId,
            int? sortOrder)
        {
            this.AllowManualAccess = allowManualAccess;
            this.GateAnnotatorDataManager = gateAnnotatorDataManager;
            this.GateAnnotatorLabelStream = gateAnnotatorLabelStream;
            this.GateReviewerDataManager = gateReviewerDataManager;
            this.GateReviewerLabelStream = gateReviewerLabelStream;
            this.GateReviewerReviewStream = gateReviewerReviewStream;
            this.LearningResourceId = learningResourceId;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedProjectLearningAssignmentRequest" /> class.
        /// </summary>
        public PatchedProjectLearningAssignmentRequest()
        {
        }

    }
}