
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectMemberIdentityVerificationError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SkippedUserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberIdentityVerificationError" /> class.
        /// </summary>
        /// <param name="skippedUserIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMemberIdentityVerificationError(
            global::System.Collections.Generic.IList<int> skippedUserIds)
        {
            this.SkippedUserIds = skippedUserIds ?? throw new global::System.ArgumentNullException(nameof(skippedUserIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberIdentityVerificationError" /> class.
        /// </summary>
        public ProjectMemberIdentityVerificationError()
        {
        }

    }
}