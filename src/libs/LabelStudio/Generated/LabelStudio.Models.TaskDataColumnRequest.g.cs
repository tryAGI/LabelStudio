
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TaskDataColumnRequest
    {
        /// <summary>
        /// Data column to set: the key in `task.data`, used exactly as sent. If no task of the project has it yet, it is created on the listed tasks only. A new column name cannot contain whitespace, quotation marks, brackets, semicolons, hashes, control characters, or SQL comments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// How the values are stored: `String` keeps the text exactly as sent; `Number` stores a number.<br/>
        /// * `String` - String<br/>
        /// * `Number` - Number<br/>
        /// Default Value: String
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.TaskDataColumnValueTypeEnumJsonConverter))]
        public global::LabelStudio.TaskDataColumnValueTypeEnum? ValueType { get; set; }

        /// <summary>
        /// Map of task ID to the value for that task, for example `{"101": "Missing box", "102": "OK"}`. At most `TASK_DATA_COLUMN_MAX_TASKS` tasks per request (1000 by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDataColumnRequest" /> class.
        /// </summary>
        /// <param name="columnName">
        /// Data column to set: the key in `task.data`, used exactly as sent. If no task of the project has it yet, it is created on the listed tasks only. A new column name cannot contain whitespace, quotation marks, brackets, semicolons, hashes, control characters, or SQL comments.
        /// </param>
        /// <param name="values">
        /// Map of task ID to the value for that task, for example `{"101": "Missing box", "102": "OK"}`. At most `TASK_DATA_COLUMN_MAX_TASKS` tasks per request (1000 by default).
        /// </param>
        /// <param name="valueType">
        /// How the values are stored: `String` keeps the text exactly as sent; `Number` stores a number.<br/>
        /// * `String` - String<br/>
        /// * `Number` - Number<br/>
        /// Default Value: String
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskDataColumnRequest(
            string columnName,
            object values,
            global::LabelStudio.TaskDataColumnValueTypeEnum? valueType)
        {
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.ValueType = valueType;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDataColumnRequest" /> class.
        /// </summary>
        public TaskDataColumnRequest()
        {
        }

    }
}