
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Lean nested resource for project assignment lists (gating / on-demand UI).<br/>
    /// Includes the current user's progress so clients can evaluate gates without<br/>
    /// N extra GET /learning-resources/:id/ detail calls.
    /// </summary>
    public sealed partial class LearningResourceAssignmentSummary
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::LabelStudio.UserLearningProgress? Progress { get; set; }

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
        /// <param name="color">
        /// Included only in responses
        /// </param>
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
        /// <param name="progress">
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
            string? color,
            bool? defaultGateAnnotatorDataManager,
            bool? defaultGateAnnotatorLabelStream,
            bool? defaultGateReviewerDataManager,
            bool? defaultGateReviewerLabelStream,
            bool? defaultGateReviewerReviewStream,
            global::LabelStudio.UserLearningProgress? progress,
            bool defaultAllowManualAccess = default!,
            int id = default!,
            bool isPublished = default!,
            string title = default!)
        {
            this.Color = color;
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateAnnotatorDataManager = defaultGateAnnotatorDataManager;
            this.DefaultGateAnnotatorLabelStream = defaultGateAnnotatorLabelStream;
            this.DefaultGateReviewerDataManager = defaultGateReviewerDataManager;
            this.DefaultGateReviewerLabelStream = defaultGateReviewerLabelStream;
            this.DefaultGateReviewerReviewStream = defaultGateReviewerReviewStream;
            this.Id = id;
            this.IsPublished = isPublished;
            this.Progress = progress;
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