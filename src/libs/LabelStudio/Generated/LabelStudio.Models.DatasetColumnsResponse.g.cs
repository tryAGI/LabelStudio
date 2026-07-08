
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetColumnsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.DatasetColumn> Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumnsResponse" /> class.
        /// </summary>
        /// <param name="columns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetColumnsResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.DatasetColumn> columns)
        {
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumnsResponse" /> class.
        /// </summary>
        public DatasetColumnsResponse()
        {
        }

    }
}