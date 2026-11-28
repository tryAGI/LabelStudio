
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActingRole
    {
        /// <summary>
        /// Role the user acts as, or null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acting_role")]
        public string? ActingRole1 { get; set; }

        /// <summary>
        /// Roles the user may act as; empty when they may not act
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedRoles { get; set; }

        /// <summary>
        /// Stored organization role of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_role")]
        public string? RealRole { get; set; }

        /// <summary>
        /// When acting started, or null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActingRole" /> class.
        /// </summary>
        /// <param name="allowedRoles">
        /// Roles the user may act as; empty when they may not act
        /// </param>
        /// <param name="actingRole1">
        /// Role the user acts as, or null
        /// </param>
        /// <param name="realRole">
        /// Stored organization role of the user
        /// </param>
        /// <param name="startedAt">
        /// When acting started, or null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActingRole(
            global::System.Collections.Generic.IList<string> allowedRoles,
            string? actingRole1,
            string? realRole,
            global::System.DateTime? startedAt)
        {
            this.ActingRole1 = actingRole1;
            this.AllowedRoles = allowedRoles ?? throw new global::System.ArgumentNullException(nameof(allowedRoles));
            this.RealRole = realRole;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActingRole" /> class.
        /// </summary>
        public ActingRole()
        {
        }

    }
}