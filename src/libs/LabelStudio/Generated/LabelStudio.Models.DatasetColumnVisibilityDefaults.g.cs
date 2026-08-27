
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetColumnVisibilityDefaults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explore")]
        public bool? Explore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public bool? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumnVisibilityDefaults" /> class.
        /// </summary>
        /// <param name="explore"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetColumnVisibilityDefaults(
            bool? explore,
            bool? filter)
        {
            this.Explore = explore;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetColumnVisibilityDefaults" /> class.
        /// </summary>
        public DatasetColumnVisibilityDefaults()
        {
        }

    }
}