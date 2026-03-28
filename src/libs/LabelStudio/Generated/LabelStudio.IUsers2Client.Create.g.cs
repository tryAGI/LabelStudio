#nullable enable

namespace LabelStudio
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// Create new user<br/>
        /// Create a user in Label Studio.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseUser> CreateAsync(

            global::LabelStudio.ApiUsersCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new user<br/>
        /// Create a user in Label Studio.
        /// </summary>
        /// <param name="allowNewsletters">
        /// Whether the user allows newsletters
        /// </param>
        /// <param name="avatar">
        /// Avatar URL of the user
        /// </param>
        /// <param name="email">
        /// Email of the user
        /// </param>
        /// <param name="firstName">
        /// First name of the user
        /// </param>
        /// <param name="id">
        /// User ID
        /// </param>
        /// <param name="initials">
        /// Initials of the user
        /// </param>
        /// <param name="lastName">
        /// Last name of the user
        /// </param>
        /// <param name="phone">
        /// Phone number of the user
        /// </param>
        /// <param name="username">
        /// Username of the user
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseUser> CreateAsync(
            bool? allowNewsletters = default,
            string? avatar = default,
            string? email = default,
            string? firstName = default,
            int? id = default,
            string? initials = default,
            string? lastName = default,
            string? phone = default,
            string? username = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}