
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LocalFilesExportStorageValidateRequest
    {
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
        /// Storage ID. If set, storage with specified ID will be updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Local path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Regex for filtering objects
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
        /// Initializes a new instance of the <see cref="LocalFilesExportStorageValidateRequest" /> class.
        /// </summary>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="path">
        /// Local path
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
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
        public LocalFilesExportStorageValidateRequest(
            int project,
            bool? canDeleteObjects,
            string? description,
            int? id,
            string? path,
            string? regexFilter,
            bool? synchronizable,
            string? title,
            bool? useBlobUrls)
        {
            this.CanDeleteObjects = canDeleteObjects;
            this.Description = description;
            this.Id = id;
            this.Path = path;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalFilesExportStorageValidateRequest" /> class.
        /// </summary>
        public LocalFilesExportStorageValidateRequest()
        {
        }

    }
}