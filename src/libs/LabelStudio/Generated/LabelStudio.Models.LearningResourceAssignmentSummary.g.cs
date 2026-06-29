
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningResourceAssignmentSummary
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_allow_manual_access")]
        public bool DefaultAllowManualAccess { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_annotator_data_manager")]
        public bool? DefaultGateAnnotatorDataManager { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_annotator_label_stream")]
        public bool? DefaultGateAnnotatorLabelStream { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_data_manager")]
        public bool? DefaultGateReviewerDataManager { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_label_stream")]
        public bool? DefaultGateReviewerLabelStream { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_reviewer_review_stream")]
        public bool? DefaultGateReviewerReviewStream { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool IsPublished { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceAssignmentSummary" /> class.
        /// </summary>
        /// <param name="defaultGateAnnotatorDataManager">
        /// Included only in responses
        /// </param>
        /// <param name="defaultGateAnnotatorLabelStream">
        /// Included only in responses
        /// </param>
        /// <param name="defaultGateReviewerDataManager">
        /// Included only in responses
        /// </param>
        /// <param name="defaultGateReviewerLabelStream">
        /// Included only in responses
        /// </param>
        /// <param name="defaultGateReviewerReviewStream">
        /// Included only in responses
        /// </param>
        /// <param name="defaultAllowManualAccess">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="isPublished">
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceAssignmentSummary(
            bool? defaultGateAnnotatorDataManager,
            bool? defaultGateAnnotatorLabelStream,
            bool? defaultGateReviewerDataManager,
            bool? defaultGateReviewerLabelStream,
            bool? defaultGateReviewerReviewStream,
            bool defaultAllowManualAccess = default!,
            int id = default!,
            bool isPublished = default!,
            string title = default!)
        {
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateAnnotatorDataManager = defaultGateAnnotatorDataManager;
            this.DefaultGateAnnotatorLabelStream = defaultGateAnnotatorLabelStream;
            this.DefaultGateReviewerDataManager = defaultGateReviewerDataManager;
            this.DefaultGateReviewerLabelStream = defaultGateReviewerLabelStream;
            this.DefaultGateReviewerReviewStream = defaultGateReviewerReviewStream;
            this.Id = id;
            this.IsPublished = isPublished;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceAssignmentSummary" /> class.
        /// </summary>
        public LearningResourceAssignmentSummary()
        {
        }

    }
}