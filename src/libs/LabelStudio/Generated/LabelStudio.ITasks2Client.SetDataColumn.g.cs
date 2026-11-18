#nullable enable

namespace LabelStudio
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Set a data column on tasks<br/>
        /// Set one `task.data` key to a different value for each listed task of the project, in one synchronous request. Only that key of the listed tasks is written: other keys and other tasks are not touched, and a new column is created on the listed tasks only (the "Add or Update Columns" Data Manager action, in contrast, writes `null` into every other task when it adds a column). The column then appears in the Data Manager. All values are validated first; if any is invalid, nothing is written. The response lists the tasks that were updated and the requested IDs that are not tasks of this project. Requires the same permission and feature flag as the "Add or Update Columns" action. Values are not checked against the labeling configuration or a custom interface input schema. If an "Add or Update Columns" action that adds the same column is still running in the background, it can overwrite the values with `null`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TaskDataColumnResult> SetDataColumnAsync(
            int id,

            global::LabelStudio.TaskDataColumnRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a data column on tasks<br/>
        /// Set one `task.data` key to a different value for each listed task of the project, in one synchronous request. Only that key of the listed tasks is written: other keys and other tasks are not touched, and a new column is created on the listed tasks only (the "Add or Update Columns" Data Manager action, in contrast, writes `null` into every other task when it adds a column). The column then appears in the Data Manager. All values are validated first; if any is invalid, nothing is written. The response lists the tasks that were updated and the requested IDs that are not tasks of this project. Requires the same permission and feature flag as the "Add or Update Columns" action. Values are not checked against the labeling configuration or a custom interface input schema. If an "Add or Update Columns" action that adds the same column is still running in the background, it can overwrite the values with `null`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.TaskDataColumnResult>> SetDataColumnAsResponseAsync(
            int id,

            global::LabelStudio.TaskDataColumnRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a data column on tasks<br/>
        /// Set one `task.data` key to a different value for each listed task of the project, in one synchronous request. Only that key of the listed tasks is written: other keys and other tasks are not touched, and a new column is created on the listed tasks only (the "Add or Update Columns" Data Manager action, in contrast, writes `null` into every other task when it adds a column). The column then appears in the Data Manager. All values are validated first; if any is invalid, nothing is written. The response lists the tasks that were updated and the requested IDs that are not tasks of this project. Requires the same permission and feature flag as the "Add or Update Columns" action. Values are not checked against the labeling configuration or a custom interface input schema. If an "Add or Update Columns" action that adds the same column is still running in the background, it can overwrite the values with `null`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columnName">
        /// Data column to set: the key in `task.data`, used exactly as sent. If no task of the project has it yet, it is created on the listed tasks only. A new column name cannot contain whitespace, quotation marks, brackets, semicolons, hashes, control characters, or SQL comments.
        /// </param>
        /// <param name="valueType">
        /// How the values are stored: `String` keeps the text exactly as sent; `Number` stores a number.<br/>
        /// * `String` - String<br/>
        /// * `Number` - Number<br/>
        /// Default Value: String
        /// </param>
        /// <param name="values">
        /// Map of task ID to the value for that task, for example `{"101": "Missing box", "102": "OK"}`. At most `TASK_DATA_COLUMN_MAX_TASKS` tasks per request (1000 by default).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TaskDataColumnResult> SetDataColumnAsync(
            int id,
            string columnName,
            object values,
            global::LabelStudio.TaskDataColumnValueTypeEnum? valueType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}