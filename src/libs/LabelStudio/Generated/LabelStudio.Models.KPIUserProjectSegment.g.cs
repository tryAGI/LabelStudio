
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer for 2D segmentation (user × project) in sparse compact format.<br/>
    /// Only non-empty cells are returned: user_ids[i], project_ids[i] and values[i] describe one cell.
    /// </summary>
    public sealed partial class KPIUserProjectSegment
    {
        /// <summary>
        /// Project ID of each cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> ProjectIds { get; set; }

        /// <summary>
        /// Projects that appear in at least one cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.KPIUserProjectInfo> Projects { get; set; }

        /// <summary>
        /// User ID of each cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> UserIds { get; set; }

        /// <summary>
        /// Users that appear in at least one cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo> Users { get; set; }

        /// <summary>
        /// KPI value of each cell (parallel to user_ids and project_ids)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double?> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserProjectSegment" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// Project ID of each cell
        /// </param>
        /// <param name="projects">
        /// Projects that appear in at least one cell
        /// </param>
        /// <param name="userIds">
        /// User ID of each cell
        /// </param>
        /// <param name="users">
        /// Users that appear in at least one cell
        /// </param>
        /// <param name="values">
        /// KPI value of each cell (parallel to user_ids and project_ids)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIUserProjectSegment(
            global::System.Collections.Generic.IList<int> projectIds,
            global::System.Collections.Generic.IList<global::LabelStudio.KPIUserProjectInfo> projects,
            global::System.Collections.Generic.IList<int> userIds,
            global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo> users,
            global::System.Collections.Generic.IList<double?> values)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserProjectSegment" /> class.
        /// </summary>
        public KPIUserProjectSegment()
        {
        }

    }
}