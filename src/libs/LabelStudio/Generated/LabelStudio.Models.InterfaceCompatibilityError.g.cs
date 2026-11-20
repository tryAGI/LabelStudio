
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InterfaceCompatibilityError
    {
        /// <summary>
        /// Number of tasks with this error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_task_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SampleTaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityError" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of tasks with this error.
        /// </param>
        /// <param name="message"></param>
        /// <param name="sampleTaskIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterfaceCompatibilityError(
            int count,
            string message,
            global::System.Collections.Generic.IList<int> sampleTaskIds)
        {
            this.Count = count;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.SampleTaskIds = sampleTaskIds ?? throw new global::System.ArgumentNullException(nameof(sampleTaskIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceCompatibilityError" /> class.
        /// </summary>
        public InterfaceCompatibilityError()
        {
        }

    }
}