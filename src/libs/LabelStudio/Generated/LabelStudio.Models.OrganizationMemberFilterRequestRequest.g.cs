
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Versioned, transport-neutral reusable organization-member filter payload.
    /// </summary>
    public sealed partial class OrganizationMemberFilterRequestRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberFilterRequestRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberFilterRequestRequest(
            object filters)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberFilterRequestRequest" /> class.
        /// </summary>
        public OrganizationMemberFilterRequestRequest()
        {
        }

    }
}