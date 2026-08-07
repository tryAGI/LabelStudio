
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`in_list` Field value is one of the items in the supplied list. Value must be a JSON array of strings or numbers, e.g. `[1, 2, 3]` or `["a", "b"]`. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`not_in_list` Field value is NOT in the supplied list. Value must be a JSON array of strings or numbers. Supported only for Task ID, Inner ID, and `task.data.*` fields.&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
    /// </summary>
    public enum PrepareParamsFiltersRequestItemChildFilterOperator
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
    public static class PrepareParamsFiltersRequestItemChildFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrepareParamsFiltersRequestItemChildFilterOperator value)
        {
            return value switch
            {
                PrepareParamsFiltersRequestItemChildFilterOperator.Contains => "contains",
                PrepareParamsFiltersRequestItemChildFilterOperator.EndsWith => "ends_with",
                PrepareParamsFiltersRequestItemChildFilterOperator.Equal => "equal",
                PrepareParamsFiltersRequestItemChildFilterOperator.Exists => "exists",
                PrepareParamsFiltersRequestItemChildFilterOperator.Greater => "greater",
                PrepareParamsFiltersRequestItemChildFilterOperator.GreaterOrEqual => "greater_or_equal",
                PrepareParamsFiltersRequestItemChildFilterOperator.In => "in",
                PrepareParamsFiltersRequestItemChildFilterOperator.InList => "in_list",
                PrepareParamsFiltersRequestItemChildFilterOperator.Less => "less",
                PrepareParamsFiltersRequestItemChildFilterOperator.LessOrEqual => "less_or_equal",
                PrepareParamsFiltersRequestItemChildFilterOperator.NotContains => "not_contains",
                PrepareParamsFiltersRequestItemChildFilterOperator.NotEqual => "not_equal",
                PrepareParamsFiltersRequestItemChildFilterOperator.NotExists => "not_exists",
                PrepareParamsFiltersRequestItemChildFilterOperator.NotIn => "not_in",
                PrepareParamsFiltersRequestItemChildFilterOperator.NotInList => "not_in_list",
                PrepareParamsFiltersRequestItemChildFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrepareParamsFiltersRequestItemChildFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => PrepareParamsFiltersRequestItemChildFilterOperator.Contains,
                "ends_with" => PrepareParamsFiltersRequestItemChildFilterOperator.EndsWith,
                "equal" => PrepareParamsFiltersRequestItemChildFilterOperator.Equal,
                "exists" => PrepareParamsFiltersRequestItemChildFilterOperator.Exists,
                "greater" => PrepareParamsFiltersRequestItemChildFilterOperator.Greater,
                "greater_or_equal" => PrepareParamsFiltersRequestItemChildFilterOperator.GreaterOrEqual,
                "in" => PrepareParamsFiltersRequestItemChildFilterOperator.In,
                "in_list" => PrepareParamsFiltersRequestItemChildFilterOperator.InList,
                "less" => PrepareParamsFiltersRequestItemChildFilterOperator.Less,
                "less_or_equal" => PrepareParamsFiltersRequestItemChildFilterOperator.LessOrEqual,
                "not_contains" => PrepareParamsFiltersRequestItemChildFilterOperator.NotContains,
                "not_equal" => PrepareParamsFiltersRequestItemChildFilterOperator.NotEqual,
                "not_exists" => PrepareParamsFiltersRequestItemChildFilterOperator.NotExists,
                "not_in" => PrepareParamsFiltersRequestItemChildFilterOperator.NotIn,
                "not_in_list" => PrepareParamsFiltersRequestItemChildFilterOperator.NotInList,
                "starts_with" => PrepareParamsFiltersRequestItemChildFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}