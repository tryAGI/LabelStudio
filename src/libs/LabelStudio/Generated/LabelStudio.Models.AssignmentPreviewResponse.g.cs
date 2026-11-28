
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignmentPreviewResponse
    {
        /// <summary>
        /// Selected projects that already have this course
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("already_assigned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AlreadyAssigned { get; set; }

        /// <summary>
        /// Projects per state, over every project, not just the rows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.AssignmentPreviewCounts Counts { get; set; }

        /// <summary>
        /// One row per project that would get the course, by title (capped; see total)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.AssignmentPreviewProject> Projects { get; set; }

        /// <summary>
        /// Projects that would get the course; more than len(projects) if capped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewResponse" /> class.
        /// </summary>
        /// <param name="alreadyAssigned">
        /// Selected projects that already have this course
        /// </param>
        /// <param name="counts">
        /// Projects per state, over every project, not just the rows
        /// </param>
        /// <param name="projects">
        /// One row per project that would get the course, by title (capped; see total)
        /// </param>
        /// <param name="total">
        /// Projects that would get the course; more than len(projects) if capped
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignmentPreviewResponse(
            int alreadyAssigned,
            global::LabelStudio.AssignmentPreviewCounts counts,
            global::System.Collections.Generic.IList<global::LabelStudio.AssignmentPreviewProject> projects,
            int total)
        {
            this.AlreadyAssigned = alreadyAssigned;
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentPreviewResponse" /> class.
        /// </summary>
        public AssignmentPreviewResponse()
        {
        }

    }
}