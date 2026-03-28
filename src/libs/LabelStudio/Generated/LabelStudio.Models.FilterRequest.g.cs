
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_filter")]
        public global::LabelStudio.ChildFilterRequest? ChildFilter { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// Display order among root filters only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Filter operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public int? Parent { get; set; }

        /// <summary>
        /// Field type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Filter value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterRequest" /> class.
        /// </summary>
        /// <param name="childFilter"></param>
        /// <param name="column">
        /// Field name
        /// </param>
        /// <param name="index">
        /// Display order among root filters only
        /// </param>
        /// <param name="operator">
        /// Filter operator
        /// </param>
        /// <param name="parent">
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </param>
        /// <param name="type">
        /// Field type
        /// </param>
        /// <param name="value">
        /// Filter value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterRequest(
            string column,
            string @operator,
            string type,
            global::LabelStudio.ChildFilterRequest? childFilter,
            int? index,
            int? parent,
            object? value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ChildFilter = childFilter;
            this.Index = index;
            this.Parent = parent;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterRequest" /> class.
        /// </summary>
        public FilterRequest()
        {
        }
    }
}