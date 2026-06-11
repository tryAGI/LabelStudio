
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningResourceCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_allow_manual_access")]
        public bool? DefaultAllowManualAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_gate_before_first_annotation")]
        public bool? DefaultGateBeforeFirstAnnotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceCreateRequest" /> class.
        /// </summary>
        /// <param name="defaultAllowManualAccess"></param>
        /// <param name="defaultGateBeforeFirstAnnotation"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceCreateRequest(
            bool? defaultAllowManualAccess,
            bool? defaultGateBeforeFirstAnnotation,
            string? summary,
            string? title,
            int? workspace)
        {
            this.DefaultAllowManualAccess = defaultAllowManualAccess;
            this.DefaultGateBeforeFirstAnnotation = defaultGateBeforeFirstAnnotation;
            this.Summary = summary;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceCreateRequest" /> class.
        /// </summary>
        public LearningResourceCreateRequest()
        {
        }

    }
}