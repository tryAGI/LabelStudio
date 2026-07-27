
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
    /// </summary>
    public enum ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator
    {
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Contains,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        EndsWith,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Equal,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Exists,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Greater,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        GreaterOrEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        In,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        InList,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Less,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        LessOrEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotContains,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotExists,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotIn,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotInList,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Contains => "contains",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.EndsWith => "ends_with",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Equal => "equal",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Exists => "exists",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Greater => "greater",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.GreaterOrEqual => "greater_or_equal",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.In => "in",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.InList => "in_list",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Less => "less",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.LessOrEqual => "less_or_equal",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotContains => "not_contains",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotEqual => "not_equal",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotExists => "not_exists",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotIn => "not_in",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotInList => "not_in_list",
                ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Contains,
                "ends_with" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.EndsWith,
                "equal" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Equal,
                "exists" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Exists,
                "greater" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Greater,
                "greater_or_equal" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.GreaterOrEqual,
                "in" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.In,
                "in_list" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.InList,
                "less" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.Less,
                "less_or_equal" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.LessOrEqual,
                "not_contains" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotContains,
                "not_equal" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotEqual,
                "not_exists" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotExists,
                "not_in" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotIn,
                "not_in_list" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.NotInList,
                "starts_with" => ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemChildFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}