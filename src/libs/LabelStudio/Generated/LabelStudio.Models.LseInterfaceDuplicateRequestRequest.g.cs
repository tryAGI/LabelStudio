
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Request body for ``POST /api/interfaces/{id}/duplicate/`` (OpenAPI/SDK only — the view reads raw data).<br/>
    /// Every field is optional; an empty body duplicates the latest state into the shared (no workspace) scope.
    /// </summary>
    public sealed partial class LseInterfaceDuplicateRequestRequest
    {
        /// <summary>
        /// Client-compiled bundle, accepted only when the source has none stored (system templates).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compiled")]
        public string? Compiled { get; set; }

        /// <summary>
        /// Description for the copy. Defaults to the source interface's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 'last' (default) copies only the current state; 'all' carries the full version history.<br/>
        /// * `last` - last<br/>
        /// * `all` - all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.LseInterfaceDuplicateRequestModeEnumJsonConverter))]
        public global::LabelStudio.LseInterfaceDuplicateRequestModeEnum? Mode { get; set; }

        /// <summary>
        /// Initial screen params (an object) seeded on the copy. Can't be combined with mode='all'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Title for the copy. Defaults to "&lt;source title&gt; (Copy)" when omitted or blank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Workspace ID to duplicate into. Omit or null for no workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceDuplicateRequestRequest" /> class.
        /// </summary>
        /// <param name="compiled">
        /// Client-compiled bundle, accepted only when the source has none stored (system templates).
        /// </param>
        /// <param name="description">
        /// Description for the copy. Defaults to the source interface's description.
        /// </param>
        /// <param name="mode">
        /// 'last' (default) copies only the current state; 'all' carries the full version history.<br/>
        /// * `last` - last<br/>
        /// * `all` - all
        /// </param>
        /// <param name="params">
        /// Initial screen params (an object) seeded on the copy. Can't be combined with mode='all'.
        /// </param>
        /// <param name="title">
        /// Title for the copy. Defaults to "&lt;source title&gt; (Copy)" when omitted or blank.
        /// </param>
        /// <param name="workspace">
        /// Workspace ID to duplicate into. Omit or null for no workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceDuplicateRequestRequest(
            string? compiled,
            string? description,
            global::LabelStudio.LseInterfaceDuplicateRequestModeEnum? mode,
            object? @params,
            string? title,
            int? workspace)
        {
            this.Compiled = compiled;
            this.Description = description;
            this.Mode = mode;
            this.Params = @params;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceDuplicateRequestRequest" /> class.
        /// </summary>
        public LseInterfaceDuplicateRequestRequest()
        {
        }

    }
}