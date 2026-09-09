
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// An enumerable Contributor Setup answer available to the Skills filter.<br/>
    /// ``section_key`` / ``field_key`` / ``code`` are the filter identity. Titles are live<br/>
    /// Contributor Setup names. ``parent_code`` is set only when that ancestor is also an<br/>
    /// option on the same question, matching ``OrganizationTaxonomyNodeSerializer``.
    /// </summary>
    public sealed partial class OrganizationMemberSkillsOption
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_code")]
        public string? ParentCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SectionKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SectionTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberSkillsOption" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="fieldKey"></param>
        /// <param name="fieldLabel"></param>
        /// <param name="label"></param>
        /// <param name="sectionKey"></param>
        /// <param name="sectionTitle"></param>
        /// <param name="parentCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberSkillsOption(
            string code,
            string fieldKey,
            string fieldLabel,
            string label,
            string sectionKey,
            string sectionTitle,
            string? parentCode)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.FieldKey = fieldKey ?? throw new global::System.ArgumentNullException(nameof(fieldKey));
            this.FieldLabel = fieldLabel ?? throw new global::System.ArgumentNullException(nameof(fieldLabel));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ParentCode = parentCode;
            this.SectionKey = sectionKey ?? throw new global::System.ArgumentNullException(nameof(sectionKey));
            this.SectionTitle = sectionTitle ?? throw new global::System.ArgumentNullException(nameof(sectionTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberSkillsOption" /> class.
        /// </summary>
        public OrganizationMemberSkillsOption()
        {
        }

    }
}