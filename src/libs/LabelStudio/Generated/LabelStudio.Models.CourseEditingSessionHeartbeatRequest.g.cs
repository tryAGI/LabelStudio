
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseEditingSessionHeartbeatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module_id")]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("takeover")]
        public bool? Takeover { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wants_to_edit")]
        public bool? WantsToEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSessionHeartbeatRequest" /> class.
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="moduleId"></param>
        /// <param name="takeover">
        /// Default Value: false
        /// </param>
        /// <param name="wantsToEdit">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseEditingSessionHeartbeatRequest(
            string pageId,
            int? moduleId,
            bool? takeover,
            bool? wantsToEdit)
        {
            this.ModuleId = moduleId;
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.Takeover = takeover;
            this.WantsToEdit = wantsToEdit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSessionHeartbeatRequest" /> class.
        /// </summary>
        public CourseEditingSessionHeartbeatRequest()
        {
        }

    }
}