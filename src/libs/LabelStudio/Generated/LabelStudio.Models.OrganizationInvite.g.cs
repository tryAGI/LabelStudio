
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationInvite
    {
        /// <summary>
        /// True once the invite link has expired; reset the token to issue a new link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// When the invite link expires; null if no expiry was recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_url")]
        public string? InviteUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        /// <param name="expired">
        /// True once the invite link has expired; reset the token to issue a new link
        /// </param>
        /// <param name="expiresAt">
        /// When the invite link expires; null if no expiry was recorded
        /// </param>
        /// <param name="inviteUrl"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInvite(
            bool? expired,
            global::System.DateTime? expiresAt,
            string? inviteUrl,
            string? token)
        {
            this.Expired = expired;
            this.ExpiresAt = expiresAt;
            this.InviteUrl = inviteUrl;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        public OrganizationInvite()
        {
        }

    }
}