#nullable enable

namespace LabelStudio
{
    public partial interface IJwtSettingsClient
    {
        /// <summary>
        /// Retrieve JWT Settings<br/>
        /// Retrieve JWT settings for the currently active organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LSEJWTSettings> GetAsync(
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}