
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningResourceCreate
    {
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
        /// Initializes a new instance of the <see cref="LearningResourceCreate" /> class.
        /// </summary>
        /// <param name="defaultAllowManualAccess"></param>
        /// <param name="defaultGateAnnotatorDataManager"></param>
        /// <param name="defaultGateAnnotatorLabelStream"></param>
        /// <param name="defaultGateReviewerDataManager"></param>
        /// <param name="defaultGateReviewerLabelStream"></param>
        /// <param name="defaultGateReviewerReviewStream"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceCreate(
            bool? defaultAllowManualAccess,
            bool? defaultGateAnnotatorDataManager,
            bool? defaultGateAnnotatorLabelStream,
            bool? defaultGateReviewerDataManager,
            bool? defaultGateReviewerLabelStream,
            bool? defaultGateReviewerReviewStream,
            string? summary,
            string? title,
            int? workspace)
        {
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateAnnotatorDataManager = defaultGateAnnotatorDataManager;
            this.DefaultGateAnnotatorLabelStream = defaultGateAnnotatorLabelStream;
            this.DefaultGateReviewerDataManager = defaultGateReviewerDataManager;
            this.DefaultGateReviewerLabelStream = defaultGateReviewerLabelStream;
            this.DefaultGateReviewerReviewStream = defaultGateReviewerReviewStream;
            this.Summary = summary;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceCreate" /> class.
        /// </summary>
        public LearningResourceCreate()
        {
        }

    }
}