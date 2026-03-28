
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsDataFilterRetrieveResponse
    {
        /// <summary>
        /// Data filter statistics by user and model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_filters")]
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? UserFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponse" /> class.
        /// </summary>
        /// <param name="userFilters">
        /// Data filter statistics by user and model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsDataFilterRetrieveResponse(
            global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? userFilters)
        {
            this.UserFilters = userFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsDataFilterRetrieveResponse()
        {
        }
    }
}