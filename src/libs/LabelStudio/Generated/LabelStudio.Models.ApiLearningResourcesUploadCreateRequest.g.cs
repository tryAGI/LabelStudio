
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiLearningResourcesUploadCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_external")]
        public bool? AllowExternal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLearningResourcesUploadCreateRequest" /> class.
        /// </summary>
        /// <param name="allowExternal"></param>
        /// <param name="dryRun"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLearningResourcesUploadCreateRequest(
            bool? allowExternal,
            bool? dryRun,
            byte[]? file,
            string? filename,
            string? url)
        {
            this.AllowExternal = allowExternal;
            this.DryRun = dryRun;
            this.File = file;
            this.Filename = filename;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLearningResourcesUploadCreateRequest" /> class.
        /// </summary>
        public ApiLearningResourcesUploadCreateRequest()
        {
        }

    }
}