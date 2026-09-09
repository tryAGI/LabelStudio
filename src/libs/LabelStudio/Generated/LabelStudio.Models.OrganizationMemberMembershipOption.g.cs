
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// A membership target available to the current actor.<br/>
    /// Workspaces carry their accessible projects; a project with no accessible parent<br/>
    /// workspace is returned as a top-level node without ``projects``.
    /// </summary>
    public sealed partial class OrganizationMemberMembershipOption
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// * `project` - project<br/>
        /// * `workspace` - workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OrganizationMemberMembershipOptionKindEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.OrganizationMemberMembershipOptionKindEnum Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberMembershipOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kind">
        /// * `project` - project<br/>
        /// * `workspace` - workspace
        /// </param>
        /// <param name="label"></param>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberMembershipOption(
            int id,
            global::LabelStudio.OrganizationMemberMembershipOptionKindEnum kind,
            string label,
            global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>? projects)
        {
            this.Id = id;
            this.Kind = kind;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberMembershipOption" /> class.
        /// </summary>
        public OrganizationMemberMembershipOption()
        {
        }

    }
}