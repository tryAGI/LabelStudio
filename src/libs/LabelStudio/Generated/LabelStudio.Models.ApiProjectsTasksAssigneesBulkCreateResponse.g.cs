
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiProjectsTasksAssigneesBulkCreateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public int? Assignments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Task IDs included in this assignment request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public global::System.Collections.Generic.IList<int>? TaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesBulkCreateResponse" /> class.
        /// </summary>
        /// <param name="assignments"></param>
        /// <param name="async"></param>
        /// <param name="taskIds">
        /// Task IDs included in this assignment request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsTasksAssigneesBulkCreateResponse(
            int? assignments,
            bool? async,
            global::System.Collections.Generic.IList<int>? taskIds)
        {
            this.Assignments = assignments;
            this.Async = async;
            this.TaskIds = taskIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesBulkCreateResponse" /> class.
        /// </summary>
        public ApiProjectsTasksAssigneesBulkCreateResponse()
        {
        }

    }
}