
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedFewShotExampleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        public int? Annotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedFewShotExampleRequest" /> class.
        /// </summary>
        /// <param name="annotation"></param>
        /// <param name="order"></param>
        /// <param name="task"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedFewShotExampleRequest(
            int? annotation,
            int? order,
            int? task)
        {
            this.Annotation = annotation;
            this.Order = order;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedFewShotExampleRequest" /> class.
        /// </summary>
        public PatchedFewShotExampleRequest()
        {
        }
    }
}