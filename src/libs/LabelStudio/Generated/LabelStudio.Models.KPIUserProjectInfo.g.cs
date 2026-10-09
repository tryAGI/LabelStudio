
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Project information for user × project segmentation, with display colors.
    /// </summary>
    public sealed partial class KPIUserProjectInfo
    {
        /// <summary>
        /// Project color (hex)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_color")]
        public string? ProjectColor { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Workspace color (hex)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_color")]
        public string? WorkspaceColor { get; set; }

        /// <summary>
        /// Shared workspace ID, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Shared workspace name, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserProjectInfo" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="projectName">
        /// Project name
        /// </param>
        /// <param name="projectColor">
        /// Project color (hex)
        /// </param>
        /// <param name="workspaceColor">
        /// Workspace color (hex)
        /// </param>
        /// <param name="workspaceId">
        /// Shared workspace ID, if any
        /// </param>
        /// <param name="workspaceName">
        /// Shared workspace name, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIUserProjectInfo(
            int projectId,
            string projectName,
            string? projectColor,
            string? workspaceColor,
            int? workspaceId,
            string? workspaceName)
        {
            this.ProjectColor = projectColor;
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.WorkspaceColor = workspaceColor;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserProjectInfo" /> class.
        /// </summary>
        public KPIUserProjectInfo()
        {
        }

    }
}