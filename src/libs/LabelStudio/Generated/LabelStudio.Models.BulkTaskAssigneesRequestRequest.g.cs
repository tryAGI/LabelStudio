
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkTaskAssigneesRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::LabelStudio.PrepareParamsFiltersRequest? Filters { get; set; }

        /// <summary>
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedItems")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue> SelectedItems { get; set; }

        /// <summary>
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AssignmentTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.AssignmentTypeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTaskAssigneesRequestRequest" /> class.
        /// </summary>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
        /// <param name="type">
        /// * `AN` - Annotate<br/>
        /// * `RE` - Review
        /// </param>
        /// <param name="users"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkTaskAssigneesRequestRequest(
            global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue> selectedItems,
            global::LabelStudio.AssignmentTypeEnum type,
            global::System.Collections.Generic.IList<int> users,
            global::LabelStudio.PrepareParamsFiltersRequest? filters)
        {
            this.Filters = filters;
            this.SelectedItems = selectedItems;
            this.Type = type;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTaskAssigneesRequestRequest" /> class.
        /// </summary>
        public BulkTaskAssigneesRequestRequest()
        {
        }

    }
}