
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetStorageColumnsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_data_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageAvailableDataType> AvailableDataTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns_with_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageColumnType> ColumnsWithTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStorageColumnsResponse" /> class.
        /// </summary>
        /// <param name="availableDataTypes"></param>
        /// <param name="columnsWithTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStorageColumnsResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageAvailableDataType> availableDataTypes,
            global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageColumnType> columnsWithTypes)
        {
            this.AvailableDataTypes = availableDataTypes ?? throw new global::System.ArgumentNullException(nameof(availableDataTypes));
            this.ColumnsWithTypes = columnsWithTypes ?? throw new global::System.ArgumentNullException(nameof(columnsWithTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStorageColumnsResponse" /> class.
        /// </summary>
        public DatasetStorageColumnsResponse()
        {
        }

    }
}