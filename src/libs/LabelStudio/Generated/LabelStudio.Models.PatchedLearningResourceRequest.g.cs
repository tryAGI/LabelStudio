
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedLearningResourceRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_standalone")]
        public bool? AllowStandalone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_allow_manual_access")]
        public bool? DefaultAllowManualAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_annotator_data_manager")]
        public bool? DefaultGateAnnotatorDataManager { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_annotator_label_stream")]
        public bool? DefaultGateAnnotatorLabelStream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_data_manager")]
        public bool? DefaultGateReviewerDataManager { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_label_stream")]
        public bool? DefaultGateReviewerLabelStream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_review_stream")]
        public bool? DefaultGateReviewerReviewStream { get; set; }

        /// <summary>
        /// * `minutes` - Minutes<br/>
        /// * `hours` - Hours<br/>
        /// * `days` - Days<br/>
        /// * `weeks` - Weeks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.EstimatedDurationUnitEnumJsonConverter))]
        public global::LabelStudio.EstimatedDurationUnitEnum? EstimatedDurationUnit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_value")]
        public int? EstimatedDurationValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_certificate_on_completion")]
        public bool? GenerateCertificateOnCompletion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_completed_quizzes")]
        public bool? HideCompletedQuizzes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_page_review")]
        public bool? SinglePageReview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLearningResourceRequest" /> class.
        /// </summary>
        /// <param name="allowStandalone"></param>
        /// <param name="color"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="defaultAllowManualAccess"></param>
        /// <param name="defaultGateAnnotatorDataManager"></param>
        /// <param name="defaultGateAnnotatorLabelStream"></param>
        /// <param name="defaultGateReviewerDataManager"></param>
        /// <param name="defaultGateReviewerLabelStream"></param>
        /// <param name="defaultGateReviewerReviewStream"></param>
        /// <param name="estimatedDurationUnit">
        /// * `minutes` - Minutes<br/>
        /// * `hours` - Hours<br/>
        /// * `days` - Days<br/>
        /// * `weeks` - Weeks
        /// </param>
        /// <param name="estimatedDurationValue"></param>
        /// <param name="generateCertificateOnCompletion"></param>
        /// <param name="hideCompletedQuizzes"></param>
        /// <param name="singlePageReview"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLearningResourceRequest(
            bool? allowStandalone,
            string? color,
            string? coverImageUrl,
            bool? defaultAllowManualAccess,
            bool? defaultGateAnnotatorDataManager,
            bool? defaultGateAnnotatorLabelStream,
            bool? defaultGateReviewerDataManager,
            bool? defaultGateReviewerLabelStream,
            bool? defaultGateReviewerReviewStream,
            global::LabelStudio.EstimatedDurationUnitEnum? estimatedDurationUnit,
            int? estimatedDurationValue,
            bool? generateCertificateOnCompletion,
            bool? hideCompletedQuizzes,
            bool? singlePageReview,
            string? summary,
            string? title,
            int? workspace)
        {
            this.AllowStandalone = allowStandalone;
            this.Color = color;
            this.CoverImageUrl = coverImageUrl;
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateAnnotatorDataManager = defaultGateAnnotatorDataManager;
            this.DefaultGateAnnotatorLabelStream = defaultGateAnnotatorLabelStream;
            this.DefaultGateReviewerDataManager = defaultGateReviewerDataManager;
            this.DefaultGateReviewerLabelStream = defaultGateReviewerLabelStream;
            this.DefaultGateReviewerReviewStream = defaultGateReviewerReviewStream;
            this.EstimatedDurationUnit = estimatedDurationUnit;
            this.EstimatedDurationValue = estimatedDurationValue;
            this.GenerateCertificateOnCompletion = generateCertificateOnCompletion;
            this.HideCompletedQuizzes = hideCompletedQuizzes;
            this.SinglePageReview = singlePageReview;
            this.Summary = summary;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLearningResourceRequest" /> class.
        /// </summary>
        public PatchedLearningResourceRequest()
        {
        }

    }
}