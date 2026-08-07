#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user details<br/>
        ///         Update details for a specific user, such as their name or contact information, in Label Studio.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseUser> UpdateAsync(
            int id,

            global::LabelStudio.PatchedLseUserSerializerUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user details<br/>
        ///         Update details for a specific user, such as their name or contact information, in Label Studio.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LseUser>> UpdateAsResponseAsync(
            int id,

            global::LabelStudio.PatchedLseUserSerializerUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user details<br/>
        ///         Update details for a specific user, such as their name or contact information, in Label Studio.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activeOrganization"></param>
        /// <param name="allowNewsletters">
        /// Allow sending newsletters to user
        /// </param>
        /// <param name="customHotkeys">
        /// Custom keyboard shortcuts configuration for the user interface
        /// </param>
        /// <param name="dateJoined"></param>
        /// <param name="emailNotificationSettings">
        /// Included only in requests
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="isEmailVerified">
        /// Included only in requests
        /// </param>
        /// <param name="lastName"></param>
        /// <param name="onboardingState">
        /// Included only in requests
        /// </param>
        /// <param name="password">
        /// Included only in requests
        /// </param>
        /// <param name="phone"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseUser> UpdateAsync(
            int id,
            object emailNotificationSettings,
            bool? isEmailVerified,
            string? onboardingState,
            string password,
            int? activeOrganization = default,
            bool? allowNewsletters = default,
            object? customHotkeys = default,
            global::System.DateTime? dateJoined = default,
            string? firstName = default,
            string? lastName = default,
            string? phone = default,
            string? username = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}