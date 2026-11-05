
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Learners-tab filters, named and formatted like the `user-progress` list query string.<br/>
    /// Unlike the list (which ignores invalid values), a bad value is an error here: a dropped filter<br/>
    /// would widen a destructive reset.
    /// </summary>
    public sealed partial class BulkResetCourseProgressFiltersRequest
    {
        /// <summary>
        /// ISO datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_completed_after")]
        public string? CourseCompletedAfter { get; set; }

        /// <summary>
        /// ISO datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_completed_before")]
        public string? CourseCompletedBefore { get; set; }

        /// <summary>
        /// true/false/1/0/yes/no.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_completed_never")]
        public string? CourseCompletedNever { get; set; }

        /// <summary>
        /// ISO datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_started_after")]
        public string? CourseStartedAfter { get; set; }

        /// <summary>
        /// ISO datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("course_started_before")]
        public string? CourseStartedBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Comma-separated course statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResetCourseProgressFiltersRequest" /> class.
        /// </summary>
        /// <param name="courseCompletedAfter">
        /// ISO datetime.
        /// </param>
        /// <param name="courseCompletedBefore">
        /// ISO datetime.
        /// </param>
        /// <param name="courseCompletedNever">
        /// true/false/1/0/yes/no.
        /// </param>
        /// <param name="courseStartedAfter">
        /// ISO datetime.
        /// </param>
        /// <param name="courseStartedBefore">
        /// ISO datetime.
        /// </param>
        /// <param name="search"></param>
        /// <param name="status">
        /// Comma-separated course statuses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkResetCourseProgressFiltersRequest(
            string? courseCompletedAfter,
            string? courseCompletedBefore,
            string? courseCompletedNever,
            string? courseStartedAfter,
            string? courseStartedBefore,
            string? search,
            string? status)
        {
            this.CourseCompletedAfter = courseCompletedAfter;
            this.CourseCompletedBefore = courseCompletedBefore;
            this.CourseCompletedNever = courseCompletedNever;
            this.CourseStartedAfter = courseStartedAfter;
            this.CourseStartedBefore = courseStartedBefore;
            this.Search = search;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResetCourseProgressFiltersRequest" /> class.
        /// </summary>
        public BulkResetCourseProgressFiltersRequest()
        {
        }

    }
}