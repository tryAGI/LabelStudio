
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Public view write contract; runtime conversion remains in ``ViewSerializer``.
    /// </summary>
    public sealed partial class PatchedViewRequestRequest
    {
        /// <summary>
        /// Established public view payload nested under ``data``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::LabelStudio.ViewDataRequestRequest? Data { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedViewRequestRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Established public view payload nested under ``data``.
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedViewRequestRequest(
            global::LabelStudio.ViewDataRequestRequest? data,
            int? project)
        {
            this.Data = data;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedViewRequestRequest" /> class.
        /// </summary>
        public PatchedViewRequestRequest()
        {
        }

    }
}