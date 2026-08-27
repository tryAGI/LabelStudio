
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelBulkUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object NewLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object OldLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelBulkUpdateRequest" /> class.
        /// </summary>
        /// <param name="newLabel"></param>
        /// <param name="oldLabel"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelBulkUpdateRequest(
            object newLabel,
            object oldLabel,
            int? project)
        {
            this.NewLabel = newLabel ?? throw new global::System.ArgumentNullException(nameof(newLabel));
            this.OldLabel = oldLabel ?? throw new global::System.ArgumentNullException(nameof(oldLabel));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelBulkUpdateRequest" /> class.
        /// </summary>
        public LabelBulkUpdateRequest()
        {
        }

    }
}