
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MemberSkill
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimed_level")]
        public string? ClaimedLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_level")]
        public string? FailedLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levels")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Levels { get; set; }

        /// <summary>
        /// * `verified` - verified<br/>
        /// * `self_reported` - self_reported<br/>
        /// * `failed` - failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.MemberSkillStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.MemberSkillStatusEnum Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_level")]
        public string? VerifiedLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberSkill" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="label"></param>
        /// <param name="status">
        /// * `verified` - verified<br/>
        /// * `self_reported` - self_reported<br/>
        /// * `failed` - failed
        /// </param>
        /// <param name="claimedLevel"></param>
        /// <param name="failedLevel"></param>
        /// <param name="levels"></param>
        /// <param name="verifiedLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemberSkill(
            string code,
            string label,
            global::LabelStudio.MemberSkillStatusEnum status,
            string? claimedLevel,
            string? failedLevel,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? levels,
            string? verifiedLevel)
        {
            this.ClaimedLevel = claimedLevel;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.FailedLevel = failedLevel;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Levels = levels;
            this.Status = status;
            this.VerifiedLevel = verifiedLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberSkill" /> class.
        /// </summary>
        public MemberSkill()
        {
        }

    }
}