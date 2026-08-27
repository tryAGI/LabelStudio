
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLearningResourcesUserProgressBulkResetCreateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_count")]
        public int? ResetCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLearningResourcesUserProgressBulkResetCreateResponse" /> class.
        /// </summary>
        /// <param name="resetCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLearningResourcesUserProgressBulkResetCreateResponse(
            int? resetCount)
        {
            this.ResetCount = resetCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLearningResourcesUserProgressBulkResetCreateResponse" /> class.
        /// </summary>
        public ApiLearningResourcesUserProgressBulkResetCreateResponse()
        {
        }

    }
}