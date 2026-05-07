
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseInterfaceVersionIdRequest
    {
        /// <summary>
        /// Stable interface version ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceVersionIdRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// Stable interface version ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceVersionIdRequest(
            int versionId)
        {
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceVersionIdRequest" /> class.
        /// </summary>
        public LseInterfaceVersionIdRequest()
        {
        }
    }
}