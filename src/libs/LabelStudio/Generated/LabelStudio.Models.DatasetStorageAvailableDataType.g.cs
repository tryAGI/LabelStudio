
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetStorageAvailableDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Indexable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InternalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStorageAvailableDataType" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="indexable"></param>
        /// <param name="internalName"></param>
        /// <param name="shortDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStorageAvailableDataType(
            string displayName,
            bool indexable,
            string internalName,
            string shortDisplayName)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Indexable = indexable;
            this.InternalName = internalName ?? throw new global::System.ArgumentNullException(nameof(internalName));
            this.ShortDisplayName = shortDisplayName ?? throw new global::System.ArgumentNullException(nameof(shortDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStorageAvailableDataType" /> class.
        /// </summary>
        public DatasetStorageAvailableDataType()
        {
        }

    }
}