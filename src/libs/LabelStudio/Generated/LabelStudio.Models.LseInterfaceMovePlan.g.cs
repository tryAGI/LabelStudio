
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Move plan returned by dry runs, executed moves and move-related 409 responses.<br/>
    /// Inaccessible connected projects only ever appear as ``inaccessible_projects_count``.
    /// </summary>
    public sealed partial class LseInterfaceMovePlan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Allowed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveBlockerEnum> Blockers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cannot_move_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CannotMoveProjectsCount { get; set; }

        /// <summary>
        /// Present on 409 responses.<br/>
        /// * `interface_move_blocked` - Interface move blocked<br/>
        /// * `interface_move_plan_changed` - Interface move plan changed<br/>
        /// * `interface_move_requires_confirmation` - Interface move requires confirmation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.InterfaceMoveCodeEnumJsonConverter))]
        public global::LabelStudio.InterfaceMoveCodeEnum? Code { get; set; }

        /// <summary>
        /// All connected projects, inaccessible ones included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectedProjectsCount { get; set; }

        /// <summary>
        /// Present on 409 responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inaccessible_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InaccessibleProjectsCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moving_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MovingProjectsCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveNoticeEnum> Notices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_projects_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublishedProjectsCount { get; set; }

        /// <summary>
        /// Target workspace, or null for Shared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::LabelStudio.LseInterfaceMoveWorkspace? Target { get; set; }

        /// <summary>
        /// Accessible connected projects grouped by workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceMoveWorkspaceGroup> Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMovePlan" /> class.
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="blockers"></param>
        /// <param name="cannotMoveProjectsCount"></param>
        /// <param name="connectedProjectsCount">
        /// All connected projects, inaccessible ones included.
        /// </param>
        /// <param name="inaccessibleProjectsCount"></param>
        /// <param name="movingProjectsCount"></param>
        /// <param name="notices"></param>
        /// <param name="publishedProjectsCount"></param>
        /// <param name="workspaces">
        /// Accessible connected projects grouped by workspace.
        /// </param>
        /// <param name="code">
        /// Present on 409 responses.<br/>
        /// * `interface_move_blocked` - Interface move blocked<br/>
        /// * `interface_move_plan_changed` - Interface move plan changed<br/>
        /// * `interface_move_requires_confirmation` - Interface move requires confirmation
        /// </param>
        /// <param name="detail">
        /// Present on 409 responses.
        /// </param>
        /// <param name="target">
        /// Target workspace, or null for Shared.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceMovePlan(
            bool allowed,
            global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveBlockerEnum> blockers,
            int cannotMoveProjectsCount,
            int connectedProjectsCount,
            int inaccessibleProjectsCount,
            int movingProjectsCount,
            global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveNoticeEnum> notices,
            int publishedProjectsCount,
            global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceMoveWorkspaceGroup> workspaces,
            global::LabelStudio.InterfaceMoveCodeEnum? code,
            string? detail,
            global::LabelStudio.LseInterfaceMoveWorkspace? target)
        {
            this.Allowed = allowed;
            this.Blockers = blockers ?? throw new global::System.ArgumentNullException(nameof(blockers));
            this.CannotMoveProjectsCount = cannotMoveProjectsCount;
            this.Code = code;
            this.ConnectedProjectsCount = connectedProjectsCount;
            this.Detail = detail;
            this.InaccessibleProjectsCount = inaccessibleProjectsCount;
            this.MovingProjectsCount = movingProjectsCount;
            this.Notices = notices ?? throw new global::System.ArgumentNullException(nameof(notices));
            this.PublishedProjectsCount = publishedProjectsCount;
            this.Target = target;
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMovePlan" /> class.
        /// </summary>
        public LseInterfaceMovePlan()
        {
        }

    }
}