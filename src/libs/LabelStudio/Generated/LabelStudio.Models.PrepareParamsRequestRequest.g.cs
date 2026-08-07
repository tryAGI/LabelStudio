
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrepareParamsRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::LabelStudio.PrepareParamsFiltersRequest? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordering")]
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? Ordering { get; set; }

        /// <summary>
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedItems")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>))]
        public global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? SelectedItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareParamsRequestRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="ordering"></param>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrepareParamsRequestRequest(
            global::LabelStudio.PrepareParamsFiltersRequest? filters,
            global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? ordering,
            global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? selectedItems)
        {
            this.Filters = filters;
            this.Ordering = ordering;
            this.SelectedItems = selectedItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareParamsRequestRequest" /> class.
        /// </summary>
        public PrepareParamsRequestRequest()
        {
        }

    }
}