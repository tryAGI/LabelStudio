#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve my user<br/>
        /// Retrieve details of the account that you are using to access the API.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.WhoAmIUser> WhoamiAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}