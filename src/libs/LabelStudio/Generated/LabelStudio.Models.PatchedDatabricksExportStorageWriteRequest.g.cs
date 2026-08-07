
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer for Databricks export storage with multi-auth support.
    /// </summary>
    public sealed partial class PatchedDatabricksExportStorageWriteRequest
    {
        /// <summary>
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AuthTypeEnumJsonConverter))]
        public global::LabelStudio.AuthTypeEnum? AuthType { get; set; }

        /// <summary>
        /// Deletion from storage enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// UC catalog name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        public string? Catalog { get; set; }

        /// <summary>
        /// Service principal client/application ID (required for SP modes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Service principal client secret (required for SP modes)<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Cloud storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Databricks workspace base URL (https://...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// Export path prefix under the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// A unique integer value identifying this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Regex for filtering objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_filter")]
        public string? RegexFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_timeout_s")]
        public int? RequestTimeoutS { get; set; }

        /// <summary>
        /// UC schema name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_chunk_bytes")]
        public long? StreamChunkBytes { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchronizable")]
        public bool? Synchronizable { get; set; }

        /// <summary>
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Cloud storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Databricks personal access token (required for PAT mode)<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Generate blob URLs in tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_blob_urls")]
        public bool? UseBlobUrls { get; set; }

        /// <summary>
        /// Verify TLS certificates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_tls")]
        public bool? VerifyTls { get; set; }

        /// <summary>
        /// UC volume name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public string? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatabricksExportStorageWriteRequest" /> class.
        /// </summary>
        /// <param name="authType">
        /// Authentication method: PAT, Databricks SP, or Azure AD SP<br/>
        /// * `pat` - Personal Access Token<br/>
        /// * `dbx_sp` - Databricks Service Principal<br/>
        /// * `azure_ad_sp` - Azure AD Service Principal<br/>
        /// Default Value: pat
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled
        /// </param>
        /// <param name="catalog">
        /// UC catalog name
        /// </param>
        /// <param name="clientId">
        /// Service principal client/application ID (required for SP modes)
        /// </param>
        /// <param name="clientSecret">
        /// Service principal client secret (required for SP modes)<br/>
        /// Included only in requests
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="host">
        /// Databricks workspace base URL (https://...)
        /// </param>
        /// <param name="prefix">
        /// Export path prefix under the volume
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
        /// </param>
        /// <param name="requestTimeoutS"></param>
        /// <param name="schema">
        /// UC schema name
        /// </param>
        /// <param name="streamChunkBytes"></param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="tenantId">
        /// Azure AD tenant ID (required for Azure AD SP mode)
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="token">
        /// Databricks personal access token (required for PAT mode)<br/>
        /// Included only in requests
        /// </param>
        /// <param name="useBlobUrls">
        /// Generate blob URLs in tasks
        /// </param>
        /// <param name="verifyTls">
        /// Verify TLS certificates
        /// </param>
        /// <param name="volume">
        /// UC volume name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDatabricksExportStorageWriteRequest(
            global::LabelStudio.AuthTypeEnum? authType,
            bool? canDeleteObjects,
            string? catalog,
            string? clientId,
            string? clientSecret,
            string? description,
            string? host,
            string? prefix,
            int? project,
            string? regexFilter,
            int? requestTimeoutS,
            string? schema,
            long? streamChunkBytes,
            bool? synchronizable,
            string? tenantId,
            string? title,
            string? token,
            bool? useBlobUrls,
            bool? verifyTls,
            string? volume)
        {
            this.AuthType = authType;
            this.CanDeleteObjects = canDeleteObjects;
            this.Catalog = catalog;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Description = description;
            this.Host = host;
            this.Prefix = prefix;
            this.Project = project;
            this.RegexFilter = regexFilter;
            this.RequestTimeoutS = requestTimeoutS;
            this.Schema = schema;
            this.StreamChunkBytes = streamChunkBytes;
            this.Synchronizable = synchronizable;
            this.TenantId = tenantId;
            this.Title = title;
            this.Token = token;
            this.UseBlobUrls = useBlobUrls;
            this.VerifyTls = verifyTls;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatabricksExportStorageWriteRequest" /> class.
        /// </summary>
        public PatchedDatabricksExportStorageWriteRequest()
        {
        }

    }
}