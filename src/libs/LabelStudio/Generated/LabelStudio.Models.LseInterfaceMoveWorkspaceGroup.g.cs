
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseInterfaceMoveWorkspaceGroup
    {
        /// <summary>
        /// * `move` - Move<br/>
        /// * `already_in_target` - Already in target<br/>
        /// * `stay` - Stay<br/>
        /// * `cannot_move` - Cannot move
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.InterfaceMoveOutcomeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.InterfaceMoveOutcomeEnum Outcome { get; set; }

        /// <summary>
        /// The projects sit in a different workspace from the interface's workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outside_interface_workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OutsideInterfaceWorkspace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceMoveProject> Projects { get; set; }

        /// <summary>
        /// Published projects in this workspace group that stop a move into a Personal Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublishedProjectsCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public global::LabelStudio.LseInterfaceMoveWorkspace? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveWorkspaceGroup" /> class.
        /// </summary>
        /// <param name="outcome">
        /// * `move` - Move<br/>
        /// * `already_in_target` - Already in target<br/>
        /// * `stay` - Stay<br/>
        /// * `cannot_move` - Cannot move
        /// </param>
        /// <param name="outsideInterfaceWorkspace">
        /// The projects sit in a different workspace from the interface's workspace.
        /// </param>
        /// <param name="projects"></param>
        /// <param name="publishedProjectsCount">
        /// Published projects in this workspace group that stop a move into a Personal Sandbox.
        /// </param>
        /// <param name="workspace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceMoveWorkspaceGroup(
            global::LabelStudio.InterfaceMoveOutcomeEnum outcome,
            bool outsideInterfaceWorkspace,
            global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceMoveProject> projects,
            int publishedProjectsCount,
            global::LabelStudio.LseInterfaceMoveWorkspace? workspace)
        {
            this.Outcome = outcome;
            this.OutsideInterfaceWorkspace = outsideInterfaceWorkspace;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.PublishedProjectsCount = publishedProjectsCount;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveWorkspaceGroup" /> class.
        /// </summary>
        public LseInterfaceMoveWorkspaceGroup()
        {
        }

    }
}