
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedProjectCoursesEnabledRequest
    {
        /// <summary>
        /// Courses replace Annotation and Reviewer Instructions on this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("courses_enabled")]
        public bool? CoursesEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedProjectCoursesEnabledRequest" /> class.
        /// </summary>
        /// <param name="coursesEnabled">
        /// Courses replace Annotation and Reviewer Instructions on this project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedProjectCoursesEnabledRequest(
            bool? coursesEnabled)
        {
            this.CoursesEnabled = coursesEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedProjectCoursesEnabledRequest" /> class.
        /// </summary>
        public PatchedProjectCoursesEnabledRequest()
        {
        }

    }
}