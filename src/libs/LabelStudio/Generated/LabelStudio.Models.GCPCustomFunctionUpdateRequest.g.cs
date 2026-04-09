
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer for updating GCP Cloud Function custom metric.
    /// </summary>
    public sealed partial class GCPCustomFunctionUpdateRequest
    {
        /// <summary>
        /// The Python code for the custom metric function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The GCP project ID. Uses default if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// The GCP region for the Cloud Function. Uses default if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GCPCustomFunctionUpdateRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// The Python code for the custom metric function.
        /// </param>
        /// <param name="project">
        /// The GCP project ID. Uses default if not provided.
        /// </param>
        /// <param name="region">
        /// The GCP region for the Cloud Function. Uses default if not provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GCPCustomFunctionUpdateRequest(
            string code,
            string? project,
            string? region)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Project = project;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GCPCustomFunctionUpdateRequest" /> class.
        /// </summary>
        public GCPCustomFunctionUpdateRequest()
        {
        }
    }
}