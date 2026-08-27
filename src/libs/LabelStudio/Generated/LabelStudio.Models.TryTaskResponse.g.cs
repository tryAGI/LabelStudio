
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TryTaskResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> AnnotationResult { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed_result")]
        public object? ParsedResult { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TryTaskResponse" /> class.
        /// </summary>
        /// <param name="annotationResult"></param>
        /// <param name="rawResponse"></param>
        /// <param name="taskId"></param>
        /// <param name="usage"></param>
        /// <param name="parsedResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TryTaskResponse(
            global::System.Collections.Generic.IList<object> annotationResult,
            string rawResponse,
            int taskId,
            object usage,
            object? parsedResult)
        {
            this.AnnotationResult = annotationResult ?? throw new global::System.ArgumentNullException(nameof(annotationResult));
            this.ParsedResult = parsedResult;
            this.RawResponse = rawResponse ?? throw new global::System.ArgumentNullException(nameof(rawResponse));
            this.TaskId = taskId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TryTaskResponse" /> class.
        /// </summary>
        public TryTaskResponse()
        {
        }

    }
}