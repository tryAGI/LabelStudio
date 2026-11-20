
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InterfaceCompatibilityRequestRequest
    {
        /// <summary>
        /// Interface to check the project tasks against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_interface_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceInterfaceId { get; set; }

        /// <summary>
        /// Published version id. Defaults to the latest published version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_interface_version")]
        public int? SourceInterfaceVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityRequestRequest" /> class.
        /// </summary>
        /// <param name="sourceInterfaceId">
        /// Interface to check the project tasks against.
        /// </param>
        /// <param name="sourceInterfaceVersion">
        /// Published version id. Defaults to the latest published version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterfaceCompatibilityRequestRequest(
            int sourceInterfaceId,
            int? sourceInterfaceVersion)
        {
            this.SourceInterfaceId = sourceInterfaceId;
            this.SourceInterfaceVersion = sourceInterfaceVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityRequestRequest" /> class.
        /// </summary>
        public InterfaceCompatibilityRequestRequest()
        {
        }

    }
}