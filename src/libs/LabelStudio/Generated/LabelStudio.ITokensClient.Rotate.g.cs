#nullable enable

namespace LabelStudio
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Rotate JWT refresh token<br/>
        /// Creates a new JWT refresh token and blacklists the current one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TokenRotateResponse> RotateAsync(

            global::LabelStudio.LSAPITokenRotateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate JWT refresh token<br/>
        /// Creates a new JWT refresh token and blacklists the current one.
        /// </summary>
        /// <param name="refresh"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.TokenRotateResponse> RotateAsync(
            string refresh,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}