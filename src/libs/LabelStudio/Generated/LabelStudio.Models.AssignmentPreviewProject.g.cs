
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignmentPreviewProject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_annotation_instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAnnotationInstructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_review_instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasReviewInstructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// One of switch_with_instructions, switch_empty, already_on. switch_with_instructions: Courses off and written instructions (assigning turns Courses on and hides them). switch_empty: Courses off and no written instructions (assigning turns Courses on). already_on: Courses on (nothing changes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewProject" /> class.
        /// </summary>
        /// <param name="hasAnnotationInstructions"></param>
        /// <param name="hasReviewInstructions"></param>
        /// <param name="id"></param>
        /// <param name="state">
        /// One of switch_with_instructions, switch_empty, already_on. switch_with_instructions: Courses off and written instructions (assigning turns Courses on and hides them). switch_empty: Courses off and no written instructions (assigning turns Courses on). already_on: Courses on (nothing changes).
        /// </param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignmentPreviewProject(
            bool hasAnnotationInstructions,
            bool hasReviewInstructions,
            int id,
            string state,
            string title)
        {
            this.HasAnnotationInstructions = hasAnnotationInstructions;
            this.HasReviewInstructions = hasReviewInstructions;
            this.Id = id;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewProject" /> class.
        /// </summary>
        public AssignmentPreviewProject()
        {
        }

    }
}