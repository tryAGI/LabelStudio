
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseEditingSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_writer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsWriter { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::LabelStudio.UserSimple User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSession" /> class.
        /// </summary>
        /// <param name="isWriter"></param>
        /// <param name="pageId"></param>
        /// <param name="moduleId"></param>
        /// <param name="user">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseEditingSession(
            bool isWriter,
            string pageId,
            int? moduleId,
            global::LabelStudio.UserSimple user = default!)
        {
            this.IsWriter = isWriter;
            this.ModuleId = moduleId;
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSession" /> class.
        /// </summary>
        public CourseEditingSession()
        {
        }

    }
}