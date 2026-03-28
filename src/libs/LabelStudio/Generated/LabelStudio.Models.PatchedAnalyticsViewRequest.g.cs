
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Serializer for user-scoped analytics saved views.<br/>
    /// The primary key is intentionally excluded; the ``uuid`` field is the only<br/>
    /// stable public identifier exposed to callers.<br/>
    /// ``dashboard_type`` scopes views per dashboard: "overview" vs "member_performance".
    /// </summary>
    public sealed partial class PatchedAnalyticsViewRequest
    {
        /// <summary>
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboard_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.DashboardTypeEnumJsonConverter))]
        public global::LabelStudio.DashboardTypeEnum? DashboardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnalyticsViewRequest" /> class.
        /// </summary>
        /// <param name="dashboardType">
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </param>
        /// <param name="filters"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAnalyticsViewRequest(
            global::LabelStudio.DashboardTypeEnum? dashboardType,
            object? filters,
            string? name)
        {
            this.DashboardType = dashboardType;
            this.Filters = filters;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnalyticsViewRequest" /> class.
        /// </summary>
        public PatchedAnalyticsViewRequest()
        {
        }
    }
}