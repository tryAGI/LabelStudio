#nullable enable

namespace LabelStudio
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Create API token<br/>
        /// Create a new API token for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LSEAPITokenCreate> CreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}