
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseInterfaceMoveRequestRequest
    {
        /// <summary>
        /// Return the move plan without changing anything.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Required when dry_run is false: IDs of the projects in workspace groups with outcome "move" from the dry run you confirmed. If the server computes a different set, it responds with 409 "interface_move_plan_changed" and the fresh plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_project_ids")]
        public global::System.Collections.Generic.IList<int>? ExpectedProjectIds { get; set; }

        /// <summary>
        /// Target workspace ID, or null to make the interface Shared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveRequestRequest" /> class.
        /// </summary>
        /// <param name="dryRun">
        /// Return the move plan without changing anything.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expectedProjectIds">
        /// Required when dry_run is false: IDs of the projects in workspace groups with outcome "move" from the dry run you confirmed. If the server computes a different set, it responds with 409 "interface_move_plan_changed" and the fresh plan.
        /// </param>
        /// <param name="workspace">
        /// Target workspace ID, or null to make the interface Shared.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceMoveRequestRequest(
            bool? dryRun,
            global::System.Collections.Generic.IList<int>? expectedProjectIds,
            int? workspace)
        {
            this.DryRun = dryRun;
            this.ExpectedProjectIds = expectedProjectIds;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveRequestRequest" /> class.
        /// </summary>
        public LseInterfaceMoveRequestRequest()
        {
        }

    }
}