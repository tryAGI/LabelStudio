
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationBilling
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_session_concurrency")]
        public bool EnforceSessionConcurrency { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_role_management")]
        public bool ManualRoleManagement { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_workspace_management")]
        public bool ManualWorkspaceManagement { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_sessions")]
        public int MaxParallelSessions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_concurrency_window_seconds")]
        public int SessionConcurrencyWindowSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBilling" /> class.
        /// </summary>
        /// <param name="enforceSessionConcurrency">
        /// Included only in responses
        /// </param>
        /// <param name="manualRoleManagement">
        /// Included only in responses
        /// </param>
        /// <param name="manualWorkspaceManagement">
        /// Included only in responses
        /// </param>
        /// <param name="maxParallelSessions">
        /// Included only in responses
        /// </param>
        /// <param name="sessionConcurrencyWindowSeconds">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationBilling(
            bool enforceSessionConcurrency = default!,
            bool manualRoleManagement = default!,
            bool manualWorkspaceManagement = default!,
            int maxParallelSessions = default!,
            int sessionConcurrencyWindowSeconds = default!)
        {
            this.EnforceSessionConcurrency = enforceSessionConcurrency;
            this.ManualRoleManagement = manualRoleManagement;
            this.ManualWorkspaceManagement = manualWorkspaceManagement;
            this.MaxParallelSessions = maxParallelSessions;
            this.SessionConcurrencyWindowSeconds = sessionConcurrencyWindowSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBilling" /> class.
        /// </summary>
        public OrganizationBilling()
        {
        }

    }
}