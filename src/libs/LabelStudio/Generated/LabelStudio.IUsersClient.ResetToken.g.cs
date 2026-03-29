#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Reset user token<br/>
        /// Reset the user token for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiCurrentUserResetTokenCreateResponse> ResetTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}