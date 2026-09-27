
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobException
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception_class")]
        public string? ExceptionClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Frames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobException" /> class.
        /// </summary>
        /// <param name="frames"></param>
        /// <param name="exceptionClass"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobException(
            global::System.Collections.Generic.IList<string> frames,
            string? exceptionClass,
            string? message)
        {
            this.ExceptionClass = exceptionClass;
            this.Frames = frames ?? throw new global::System.ArgumentNullException(nameof(frames));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobException" /> class.
        /// </summary>
        public JobException()
        {
        }

    }
}