
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedGCSExportStorageWriteRequest
    {
        /// <summary>
        /// GCS bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_application_credentials")]
        public string? GoogleApplicationCredentials { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_project_id")]
        public string? GoogleProjectId { get; set; }

        /// <summary>
        /// GCS bucket prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Cloud storage regex for filtering objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Interpret objects as BLOBs and generate URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedGCSExportStorageWriteRequest" /> class.
        /// </summary>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="prefix">
        /// GCS bucket prefix
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedGCSExportStorageWriteRequest(
            string? bucket,
            bool? canDeleteObjects,
            string? description,
            string? googleApplicationCredentials,
            string? googleProjectId,
            string? prefix,
            int? project,
            string? regexFilter,
            bool? synchronizable,
            string? title,
            bool? useBlobUrls)
        {
            this.Bucket = bucket;
            this.CanDeleteObjects = canDeleteObjects;
            this.Description = description;
            this.GoogleApplicationCredentials = googleApplicationCredentials;
            this.GoogleProjectId = googleProjectId;
            this.Prefix = prefix;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedGCSExportStorageWriteRequest" /> class.
        /// </summary>
        public PatchedGCSExportStorageWriteRequest()
        {
        }

    }
}