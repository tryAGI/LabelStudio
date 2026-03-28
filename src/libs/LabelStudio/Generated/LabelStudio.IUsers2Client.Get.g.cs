#nullable enable

namespace LabelStudio
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// Get user info<br/>
        /// Get info about a specific Label Studio user, based on the user ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseUser> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}