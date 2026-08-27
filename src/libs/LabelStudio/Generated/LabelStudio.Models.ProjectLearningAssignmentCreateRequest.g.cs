
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectLearningAssignmentCreateRequest
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_after_id")]
        public int? InsertAfterId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_before_id")]
        public int? InsertBeforeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearningResourceId { get; set; }

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
        /// Initializes a new instance of the <see cref="ProjectLearningAssignmentCreateRequest" /> class.
        /// </summary>
        /// <param name="learningResourceId"></param>
        /// <param name="allowManualAccess"></param>
        /// <param name="gateAnnotatorDataManager"></param>
        /// <param name="gateAnnotatorLabelStream"></param>
        /// <param name="gateReviewerDataManager"></param>
        /// <param name="gateReviewerLabelStream"></param>
        /// <param name="gateReviewerReviewStream"></param>
        /// <param name="insertAfterId"></param>
        /// <param name="insertBeforeId"></param>
        /// <param name="sortOrder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectLearningAssignmentCreateRequest(
            int learningResourceId,
            bool? allowManualAccess,
            bool? gateAnnotatorDataManager,
            bool? gateAnnotatorLabelStream,
            bool? gateReviewerDataManager,
            bool? gateReviewerLabelStream,
            bool? gateReviewerReviewStream,
            int? insertAfterId,
            int? insertBeforeId,
            int? sortOrder)
        {
            this.AllowManualAccess = allowManualAccess;
            this.GateAnnotatorDataManager = gateAnnotatorDataManager;
            this.GateAnnotatorLabelStream = gateAnnotatorLabelStream;
            this.GateReviewerDataManager = gateReviewerDataManager;
            this.GateReviewerLabelStream = gateReviewerLabelStream;
            this.GateReviewerReviewStream = gateReviewerReviewStream;
            this.InsertAfterId = insertAfterId;
            this.InsertBeforeId = insertBeforeId;
            this.LearningResourceId = learningResourceId;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLearningAssignmentCreateRequest" /> class.
        /// </summary>
        public ProjectLearningAssignmentCreateRequest()
        {
        }

    }
}