
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Admin list payload: core metadata + cheap annotated counts (no page content).<br/>
    /// Learner progress counts and page_count are deferred to GET .../counts/?ids=... so the<br/>
    /// list path stays flat as modules/learners grow. Those fields are null here for FE skeletons.
    /// </summary>
    public sealed partial class LearningResourceList
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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_version")]
        public int ContentVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::LabelStudio.UserSimple CreatedBy { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unpublished_changes")]
        public bool? HasUnpublishedChanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_completed_quizzes")]
        public bool? HideCompletedQuizzes { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("learner_count")]
        public int? LearnerCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_completed_count")]
        public int? LearnersCompletedCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_started_count")]
        public int? LearnersStartedCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_count")]
        public int ModuleCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        public int? PageCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_count")]
        public int ProjectCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_version")]
        public int StructureVersion { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::LabelStudio.UserSimple UpdatedBy { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LearningResourceList" /> class.
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
        /// <param name="hasUnpublishedChanges">
        /// Included only in responses
        /// </param>
        /// <param name="hideCompletedQuizzes"></param>
        /// <param name="learnerCount">
        /// Included only in responses
        /// </param>
        /// <param name="learnersCompletedCount">
        /// Included only in responses
        /// </param>
        /// <param name="learnersStartedCount">
        /// Included only in responses
        /// </param>
        /// <param name="pageCount">
        /// Included only in responses
        /// </param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="contentVersion">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="isPublished">
        /// Included only in responses
        /// </param>
        /// <param name="moduleCount">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="projectCount">
        /// Included only in responses
        /// </param>
        /// <param name="structureVersion">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="updatedBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceList(
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
            bool? hasUnpublishedChanges,
            bool? hideCompletedQuizzes,
            int? learnerCount,
            int? learnersCompletedCount,
            int? learnersStartedCount,
            int? pageCount,
            string? summary,
            string? title,
            int? workspace,
            int contentVersion = default!,
            global::System.DateTime createdAt = default!,
            global::LabelStudio.UserSimple createdBy = default!,
            int id = default!,
            bool isPublished = default!,
            int moduleCount = default!,
            int organization = default!,
            int projectCount = default!,
            int structureVersion = default!,
            global::System.DateTime updatedAt = default!,
            global::LabelStudio.UserSimple updatedBy = default!)
        {
            this.AllowStandalone = allowStandalone;
            this.Color = color;
            this.ContentVersion = contentVersion;
            this.CoverImageUrl = coverImageUrl;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateAnnotatorDataManager = defaultGateAnnotatorDataManager;
            this.DefaultGateAnnotatorLabelStream = defaultGateAnnotatorLabelStream;
            this.DefaultGateReviewerDataManager = defaultGateReviewerDataManager;
            this.DefaultGateReviewerLabelStream = defaultGateReviewerLabelStream;
            this.DefaultGateReviewerReviewStream = defaultGateReviewerReviewStream;
            this.EstimatedDurationUnit = estimatedDurationUnit;
            this.EstimatedDurationValue = estimatedDurationValue;
            this.GenerateCertificateOnCompletion = generateCertificateOnCompletion;
            this.HasUnpublishedChanges = hasUnpublishedChanges;
            this.HideCompletedQuizzes = hideCompletedQuizzes;
            this.Id = id;
            this.IsPublished = isPublished;
            this.LearnerCount = learnerCount;
            this.LearnersCompletedCount = learnersCompletedCount;
            this.LearnersStartedCount = learnersStartedCount;
            this.ModuleCount = moduleCount;
            this.Organization = organization;
            this.PageCount = pageCount;
            this.ProjectCount = projectCount;
            this.StructureVersion = structureVersion;
            this.Summary = summary;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceList" /> class.
        /// </summary>
        public LearningResourceList()
        {
        }

    }
}