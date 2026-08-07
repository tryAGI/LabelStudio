
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedRedisExportStorageWriteRequest
    {
        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Server Database
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db")]
        public int? Db { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Server Host IP (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// Server Password (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Storage prefix (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Server Port (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public string? Port { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchedRedisExportStorageWriteRequest" /> class.
        /// </summary>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="db">
        /// Server Database
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="host">
        /// Server Host IP (optional)
        /// </param>
        /// <param name="password">
        /// Server Password (optional)
        /// </param>
        /// <param name="path">
        /// Storage prefix (optional)
        /// </param>
        /// <param name="port">
        /// Server Port (optional)
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
        public PatchedRedisExportStorageWriteRequest(
            bool? canDeleteObjects,
            int? db,
            string? description,
            string? host,
            string? password,
            string? path,
            string? port,
            int? project,
            string? regexFilter,
            bool? synchronizable,
            string? title,
            bool? useBlobUrls)
        {
            this.CanDeleteObjects = canDeleteObjects;
            this.Db = db;
            this.Description = description;
            this.Host = host;
            this.Password = password;
            this.Path = path;
            this.Port = port;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.Synchronizable = synchronizable;
            this.Title = title;
            this.UseBlobUrls = useBlobUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedRedisExportStorageWriteRequest" /> class.
        /// </summary>
        public PatchedRedisExportStorageWriteRequest()
        {
        }

    }
}