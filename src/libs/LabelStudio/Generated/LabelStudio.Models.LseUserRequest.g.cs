
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class LseUserRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_organization")]
        public int? ActiveOrganization { get; set; }

        /// <summary>
        /// Allow sending newsletters to user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_newsletters")]
        public bool? AllowNewsletters { get; set; }

        /// <summary>
        /// Custom keyboard shortcuts configuration for the user interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hotkeys")]
        public object? CustomHotkeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_joined")]
        public global::System.DateTime? DateJoined { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="activeOrganization"></param>
        /// <param name="allowNewsletters">
        /// Allow sending newsletters to user
        /// </param>
        /// <param name="customHotkeys">
        /// Custom keyboard shortcuts configuration for the user interface
        /// </param>
        /// <param name="dateJoined"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password">
        /// Included only in requests
        /// </param>
        /// <param name="phone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseUserRequest(
            string username,
            int? activeOrganization,
            bool? allowNewsletters,
            object? customHotkeys,
            global::System.DateTime? dateJoined,
            string? email,
            string? firstName,
            string? lastName,
            string? password,
            string? phone)
        {
            this.ActiveOrganization = activeOrganization;
            this.AllowNewsletters = allowNewsletters;
            this.CustomHotkeys = customHotkeys;
            this.DateJoined = dateJoined;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Phone = phone;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserRequest" /> class.
        /// </summary>
        public LseUserRequest()
        {
        }

    }
}