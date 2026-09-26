
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobsSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed24h { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ObservedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.JobQuota Quota { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waiting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Waiting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsSummary" /> class.
        /// </summary>
        /// <param name="failed24h"></param>
        /// <param name="observedAt"></param>
        /// <param name="quota"></param>
        /// <param name="running"></param>
        /// <param name="waiting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsSummary(
            int failed24h,
            global::System.DateTime observedAt,
            global::LabelStudio.JobQuota quota,
            int running,
            int waiting)
        {
            this.Failed24h = failed24h;
            this.ObservedAt = observedAt;
            this.Quota = quota ?? throw new global::System.ArgumentNullException(nameof(quota));
            this.Running = running;
            this.Waiting = waiting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsSummary" /> class.
        /// </summary>
        public JobsSummary()
        {
        }

    }
}