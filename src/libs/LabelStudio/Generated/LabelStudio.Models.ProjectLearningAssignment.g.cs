
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectLearningAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_manual_access")]
        public bool? AllowManualAccess { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_before_first_annotation")]
        public bool? GateBeforeFirstAnnotation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_resource")]
        public global::LabelStudio.LearningResource LearningResource { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int Project { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLearningAssignment" /> class.
        /// </summary>
        /// <param name="allowManualAccess"></param>
        /// <param name="gateBeforeFirstAnnotation"></param>
        /// <param name="sortOrder"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="learningResource">
        /// Included only in responses
        /// </param>
        /// <param name="project">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectLearningAssignment(
            bool? allowManualAccess,
            bool? gateBeforeFirstAnnotation,
            int? sortOrder,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::LabelStudio.LearningResource learningResource = default!,
            int project = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AllowManualAccess = allowManualAccess;
            this.CreatedAt = createdAt;
            this.GateBeforeFirstAnnotation = gateBeforeFirstAnnotation;
            this.Id = id;
            this.LearningResource = learningResource;
            this.Project = project;
            this.SortOrder = sortOrder;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLearningAssignment" /> class.
        /// </summary>
        public ProjectLearningAssignment()
        {
        }

    }
}