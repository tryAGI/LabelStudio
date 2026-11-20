
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InterfaceCompatibilityResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.InterfaceCompatibilityError> Errors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_checked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TasksChecked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_with_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TasksWithErrors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTasks { get; set; }

        /// <summary>
        /// True when only the first tasks of a large project were checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityResponse" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="tasksChecked"></param>
        /// <param name="tasksWithErrors"></param>
        /// <param name="totalTasks"></param>
        /// <param name="truncated">
        /// True when only the first tasks of a large project were checked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterfaceCompatibilityResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.InterfaceCompatibilityError> errors,
            int tasksChecked,
            int tasksWithErrors,
            int totalTasks,
            bool truncated)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.TasksChecked = tasksChecked;
            this.TasksWithErrors = tasksWithErrors;
            this.TotalTasks = totalTasks;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityResponse" /> class.
        /// </summary>
        public InterfaceCompatibilityResponse()
        {
        }

    }
}