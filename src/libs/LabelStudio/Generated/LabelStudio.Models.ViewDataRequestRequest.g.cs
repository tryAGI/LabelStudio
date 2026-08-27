
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Established public view payload nested under ``data``.
    /// </summary>
    public sealed partial class ViewDataRequestRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDataRequestRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="ordering"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewDataRequestRequest(
            global::LabelStudio.PrepareParamsFiltersRequest? filters,
            global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? ordering)
        {
            this.Filters = filters;
            this.Ordering = ordering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDataRequestRequest" /> class.
        /// </summary>
        public ViewDataRequestRequest()
        {
        }

    }
}