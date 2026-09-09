
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Backend capabilities for the organization-member filter UI.
    /// </summary>
    public sealed partial class OrganizationMemberFilterSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Filters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberFilterSchema" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberFilterSchema(
            global::System.Collections.Generic.IList<object> filters,
            int version)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberFilterSchema" /> class.
        /// </summary>
        public OrganizationMemberFilterSchema()
        {
        }

    }
}