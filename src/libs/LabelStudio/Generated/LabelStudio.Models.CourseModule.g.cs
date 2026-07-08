
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseModule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_resource")]
        public int LearningResource { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marked_stale")]
        public bool? MarkedStale { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        public int PageCount { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::LabelStudio.UserSimple UpdatedBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseModule" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="markedStale"></param>
        /// <param name="sortOrder">
        /// Default Value: 0
        /// </param>
        /// <param name="title"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="learningResource">
        /// Included only in responses
        /// </param>
        /// <param name="pageCount">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="updatedBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseModule(
            object? content,
            bool? markedStale,
            int? sortOrder,
            string? title,
            global::System.DateTime createdAt = default!,
            int id = default!,
            int learningResource = default!,
            int pageCount = default!,
            global::System.DateTime updatedAt = default!,
            global::LabelStudio.UserSimple updatedBy = default!)
        {
            this.Content = content;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.LearningResource = learningResource;
            this.MarkedStale = markedStale;
            this.PageCount = pageCount;
            this.SortOrder = sortOrder;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseModule" /> class.
        /// </summary>
        public CourseModule()
        {
        }

    }
}