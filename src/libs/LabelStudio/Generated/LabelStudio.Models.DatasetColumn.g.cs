
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetColumn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<string>? Children { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public string? Parent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility_defaults")]
        public global::LabelStudio.DatasetColumnVisibilityDefaults? VisibilityDefaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumn" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="target"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
        /// <param name="children"></param>
        /// <param name="parent"></param>
        /// <param name="visibilityDefaults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetColumn(
            string id,
            string target,
            string title,
            string type,
            global::System.Collections.Generic.IList<string>? children,
            string? parent,
            global::LabelStudio.DatasetColumnVisibilityDefaults? visibilityDefaults)
        {
            this.Children = children;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Parent = parent;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.VisibilityDefaults = visibilityDefaults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumn" /> class.
        /// </summary>
        public DatasetColumn()
        {
        }

    }
}