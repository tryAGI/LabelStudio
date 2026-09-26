
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobQuota
    {
        /// <summary>
        /// Max concurrent jobs per RQ queue name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_queue_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int?> PerQueueLimits { get; set; }

        /// <summary>
        /// Jobs running now per queue name (from the running index).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobQuota" /> class.
        /// </summary>
        /// <param name="perQueueLimits">
        /// Max concurrent jobs per RQ queue name.
        /// </param>
        /// <param name="used">
        /// Jobs running now per queue name (from the running index).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobQuota(
            global::System.Collections.Generic.Dictionary<string, int?> perQueueLimits,
            global::System.Collections.Generic.Dictionary<string, int> used)
        {
            this.PerQueueLimits = perQueueLimits ?? throw new global::System.ArgumentNullException(nameof(perQueueLimits));
            this.Used = used ?? throw new global::System.ArgumentNullException(nameof(used));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobQuota" /> class.
        /// </summary>
        public JobQuota()
        {
        }

    }
}