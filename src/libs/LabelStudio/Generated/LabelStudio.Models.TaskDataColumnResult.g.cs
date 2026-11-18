
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TaskDataColumnResult
    {
        /// <summary>
        /// Requested task IDs that are not tasks of this project (nothing was written for them).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_found_task_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> NotFoundTaskIds { get; set; }

        /// <summary>
        /// Tasks whose column value was set, in ascending order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_task_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> UpdatedTaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDataColumnResult" /> class.
        /// </summary>
        /// <param name="notFoundTaskIds">
        /// Requested task IDs that are not tasks of this project (nothing was written for them).
        /// </param>
        /// <param name="updatedTaskIds">
        /// Tasks whose column value was set, in ascending order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskDataColumnResult(
            global::System.Collections.Generic.IList<int> notFoundTaskIds,
            global::System.Collections.Generic.IList<int> updatedTaskIds)
        {
            this.NotFoundTaskIds = notFoundTaskIds ?? throw new global::System.ArgumentNullException(nameof(notFoundTaskIds));
            this.UpdatedTaskIds = updatedTaskIds ?? throw new global::System.ArgumentNullException(nameof(updatedTaskIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDataColumnResult" /> class.
        /// </summary>
        public TaskDataColumnResult()
        {
        }

    }
}