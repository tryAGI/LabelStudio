
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningResourceDetail
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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = default!;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_before_first_annotation")]
        public bool? DefaultGateBeforeFirstAnnotation { get; set; }

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
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("learner_count")]
        public string LearnerCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_completed_count")]
        public string LearnersCompletedCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_started_count")]
        public string LearnersStartedCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_count")]
        public string ModuleCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseModule> Modules { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        public string PageCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public string Progress { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_assignments")]
        public string ProjectAssignments { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_count")]
        public string ProjectCount { get; set; } = default!;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("unpublished_module_ids")]
        public string UnpublishedModuleIds { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LearningResourceDetail" /> class.
        /// </summary>
        /// <param name="allowStandalone"></param>
        /// <param name="color"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="defaultAllowManualAccess"></param>
        /// <param name="defaultGateBeforeFirstAnnotation"></param>
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
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="content">
        /// Included only in responses
        /// </param>
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
        /// <param name="learnerCount">
        /// Included only in responses
        /// </param>
        /// <param name="learnersCompletedCount">
        /// Included only in responses
        /// </param>
        /// <param name="learnersStartedCount">
        /// Included only in responses
        /// </param>
        /// <param name="moduleCount">
        /// Included only in responses
        /// </param>
        /// <param name="modules">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="pageCount">
        /// Included only in responses
        /// </param>
        /// <param name="progress">
        /// Included only in responses
        /// </param>
        /// <param name="projectAssignments">
        /// Included only in responses
        /// </param>
        /// <param name="projectCount">
        /// Included only in responses
        /// </param>
        /// <param name="unpublishedModuleIds">
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
        public LearningResourceDetail(
            bool? allowStandalone,
            string? color,
            string? coverImageUrl,
            bool? defaultAllowManualAccess,
            bool? defaultGateBeforeFirstAnnotation,
            global::LabelStudio.EstimatedDurationUnitEnum? estimatedDurationUnit,
            int? estimatedDurationValue,
            bool? generateCertificateOnCompletion,
            bool? hasUnpublishedChanges,
            bool? hideCompletedQuizzes,
            string? summary,
            string? title,
            int? workspace,
            string content = default!,
            int contentVersion = default!,
            global::System.DateTime createdAt = default!,
            global::LabelStudio.UserSimple createdBy = default!,
            int id = default!,
            bool isPublished = default!,
            string learnerCount = default!,
            string learnersCompletedCount = default!,
            string learnersStartedCount = default!,
            string moduleCount = default!,
            global::System.Collections.Generic.IList<global::LabelStudio.CourseModule> modules = default!,
            int organization = default!,
            string pageCount = default!,
            string progress = default!,
            string projectAssignments = default!,
            string projectCount = default!,
            string unpublishedModuleIds = default!,
            global::System.DateTime updatedAt = default!,
            global::LabelStudio.UserSimple updatedBy = default!)
        {
            this.AllowStandalone = allowStandalone;
            this.Color = color;
            this.Content = content;
            this.ContentVersion = contentVersion;
            this.CoverImageUrl = coverImageUrl;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateBeforeFirstAnnotation = defaultGateBeforeFirstAnnotation;
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
            this.Modules = modules;
            this.Organization = organization;
            this.PageCount = pageCount;
            this.Progress = progress;
            this.ProjectAssignments = projectAssignments;
            this.ProjectCount = projectCount;
            this.Summary = summary;
            this.Title = title;
            this.UnpublishedModuleIds = unpublishedModuleIds;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceDetail" /> class.
        /// </summary>
        public LearningResourceDetail()
        {
        }

    }
}