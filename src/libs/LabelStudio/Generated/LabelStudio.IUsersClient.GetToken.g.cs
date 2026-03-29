#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user token<br/>
        /// Get a user token to authenticate to the API as the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiCurrentUserTokenRetrieveResponse> GetTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}