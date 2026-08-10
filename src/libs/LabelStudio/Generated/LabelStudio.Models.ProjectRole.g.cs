
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectRole
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.AssignableOrganizationRoleEnum Role { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.RoleSourceEnumJsonConverter))]
        public global::LabelStudio.RoleSourceEnum? RoleSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRole" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="role">
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="user"></param>
        /// <param name="roleSource">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRole(
            int project,
            global::LabelStudio.AssignableOrganizationRoleEnum role,
            int user,
            global::LabelStudio.RoleSourceEnum? roleSource,
            int id = default!)
        {
            this.Id = id;
            this.Project = project;
            this.Role = role;
            this.RoleSource = roleSource;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRole" /> class.
        /// </summary>
        public ProjectRole()
        {
        }

    }
}