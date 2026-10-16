
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LseInterfaceMoveProject
    {
        /// <summary>
        /// Why this project stops the move. Empty when it does not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveBlockingReasonEnum> BlockingReasons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublished { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveProject" /> class.
        /// </summary>
        /// <param name="blockingReasons">
        /// Why this project stops the move. Empty when it does not.
        /// </param>
        /// <param name="id"></param>
        /// <param name="isPublished"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseInterfaceMoveProject(
            global::System.Collections.Generic.IList<global::LabelStudio.InterfaceMoveBlockingReasonEnum> blockingReasons,
            int id,
            bool isPublished,
            string? title)
        {
            this.BlockingReasons = blockingReasons ?? throw new global::System.ArgumentNullException(nameof(blockingReasons));
            this.Id = id;
            this.IsPublished = isPublished;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseInterfaceMoveProject" /> class.
        /// </summary>
        public LseInterfaceMoveProject()
        {
        }

    }
}