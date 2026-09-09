
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// A project nested under one of the actor's accessible workspaces.
    /// </summary>
    public sealed partial class OrganizationMemberMembershipProjectOption
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// * `project` - project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OrganizationMemberMembershipProjectOptionKindEnumJsonConverter))]
        public global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberMembershipProjectOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="kind">
        /// * `project` - project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberMembershipProjectOption(
            int id,
            string label,
            global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum kind)
        {
            this.Id = id;
            this.Kind = kind;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberMembershipProjectOption" /> class.
        /// </summary>
        public OrganizationMemberMembershipProjectOption()
        {
        }

    }
}