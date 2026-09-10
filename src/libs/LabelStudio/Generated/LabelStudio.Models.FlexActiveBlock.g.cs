
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FlexActiveBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claim_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClaimMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndsAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starts_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartsAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexActiveBlock" /> class.
        /// </summary>
        /// <param name="claimMode"></param>
        /// <param name="endsAt"></param>
        /// <param name="id"></param>
        /// <param name="maxConcurrent"></param>
        /// <param name="startsAt"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlexActiveBlock(
            string claimMode,
            string endsAt,
            string id,
            int maxConcurrent,
            string startsAt,
            string status)
        {
            this.ClaimMode = claimMode ?? throw new global::System.ArgumentNullException(nameof(claimMode));
            this.EndsAt = endsAt ?? throw new global::System.ArgumentNullException(nameof(endsAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxConcurrent = maxConcurrent;
            this.StartsAt = startsAt ?? throw new global::System.ArgumentNullException(nameof(startsAt));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexActiveBlock" /> class.
        /// </summary>
        public FlexActiveBlock()
        {
        }

    }
}