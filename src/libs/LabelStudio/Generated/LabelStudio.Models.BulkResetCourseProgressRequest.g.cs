
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Reset by explicit `user_ids`, or by `select_all` over the filtered learners. Exactly one mode.
    /// </summary>
    public sealed partial class BulkResetCourseProgressRequest
    {
        /// <summary>
        /// Only with `select_all`. If the filters now match a different number of learners, respond 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_count")]
        public int? ExpectedCount { get; set; }

        /// <summary>
        /// Learners-tab filters; only with `select_all`. Omit for all learners.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::LabelStudio.BulkResetCourseProgressFiltersRequest? Filters { get; set; }

        /// <summary>
        /// Reset every learner matching `filters` (boolean true only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select_all")]
        public bool? SelectAll { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<int>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResetCourseProgressRequest" /> class.
        /// </summary>
        /// <param name="expectedCount">
        /// Only with `select_all`. If the filters now match a different number of learners, respond 409.
        /// </param>
        /// <param name="filters">
        /// Learners-tab filters; only with `select_all`. Omit for all learners.
        /// </param>
        /// <param name="selectAll">
        /// Reset every learner matching `filters` (boolean true only).
        /// </param>
        /// <param name="userIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkResetCourseProgressRequest(
            int? expectedCount,
            global::LabelStudio.BulkResetCourseProgressFiltersRequest? filters,
            bool? selectAll,
            global::System.Collections.Generic.IList<int>? userIds)
        {
            this.ExpectedCount = expectedCount;
            this.Filters = filters;
            this.SelectAll = selectAll;
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResetCourseProgressRequest" /> class.
        /// </summary>
        public BulkResetCourseProgressRequest()
        {
        }

    }
}