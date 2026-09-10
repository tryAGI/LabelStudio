
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Flex entitlement snapshot for License &amp; Usage (FIT-2340).<br/>
    /// ``enabled`` is False for Starter/non-Enterprise, flag-off, or absent/expired<br/>
    /// windows so the UI can hide Flex licensing lines.
    /// </summary>
    public sealed partial class FlexChecks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.FlexActiveBlock> ActiveBlocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Capacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claim_mode")]
        public string? ClaimMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        public string? EndsAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live_claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LiveClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peak_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeakConcurrent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roster_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RosterCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starts_at")]
        public string? StartsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexChecks" /> class.
        /// </summary>
        /// <param name="activeBlocks"></param>
        /// <param name="capacity"></param>
        /// <param name="enabled"></param>
        /// <param name="liveClaims"></param>
        /// <param name="peakConcurrent"></param>
        /// <param name="rosterCount"></param>
        /// <param name="claimMode"></param>
        /// <param name="endsAt"></param>
        /// <param name="startsAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlexChecks(
            global::System.Collections.Generic.IList<global::LabelStudio.FlexActiveBlock> activeBlocks,
            int capacity,
            bool enabled,
            int liveClaims,
            int peakConcurrent,
            int rosterCount,
            string? claimMode,
            string? endsAt,
            string? startsAt)
        {
            this.ActiveBlocks = activeBlocks ?? throw new global::System.ArgumentNullException(nameof(activeBlocks));
            this.Capacity = capacity;
            this.ClaimMode = claimMode;
            this.Enabled = enabled;
            this.EndsAt = endsAt;
            this.LiveClaims = liveClaims;
            this.PeakConcurrent = peakConcurrent;
            this.RosterCount = rosterCount;
            this.StartsAt = startsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexChecks" /> class.
        /// </summary>
        public FlexChecks()
        {
        }

    }
}