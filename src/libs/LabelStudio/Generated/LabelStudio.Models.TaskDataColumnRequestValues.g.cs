
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Map of task ID to the value for that task, for example `{"101": "Missing box", "102": "OK"}`. At most `TASK_DATA_COLUMN_MAX_TASKS` tasks per request (1000 by default).
    /// </summary>
    public sealed partial class TaskDataColumnRequestValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}