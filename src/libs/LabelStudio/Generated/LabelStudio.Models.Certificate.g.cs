
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Certificate
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime CompletedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Included only in responses
        /// </param>
        /// <param name="revokedAt">
        /// Included only in responses
        /// </param>
        /// <param name="completedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="learningResource">
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Included only in responses
        /// </param>
        /// <param name="serialNumber">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Certificate(
            global::System.DateTime? expiresAt,
            global::System.DateTime? revokedAt,
            global::System.DateTime completedAt = default!,
            global::System.DateTime createdAt = default!,
            int id = default!,
            int learningResource = default!,
            object metadata = default!,
            string serialNumber = default!)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.LearningResource = learningResource;
            this.Metadata = metadata;
            this.RevokedAt = revokedAt;
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        public Certificate()
        {
        }

    }
}