#nullable enable

namespace LabelStudio
{
    public partial interface IJwtSettingsClient
    {
        /// <summary>
        /// Update JWT Settings<br/>
        /// Update JWT settings for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LSEJWTSettings> UpdateAsync(

            global::LabelStudio.LSEJWTSettingsRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update JWT Settings<br/>
        /// Update JWT settings for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LSEJWTSettings>> UpdateAsResponseAsync(

            global::LabelStudio.LSEJWTSettingsRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update JWT Settings<br/>
        /// Update JWT settings for the currently active organization.
        /// </summary>
        /// <param name="apiTokenTtlDays"></param>
        /// <param name="apiTokensEnabled">
        /// Enable JWT API token authentication for this organization
        /// </param>
        /// <param name="legacyApiTokensEnabled">
        /// Enable legacy API token authentication for this organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LSEJWTSettings> UpdateAsync(
            int apiTokenTtlDays,
            bool? apiTokensEnabled = default,
            bool? legacyApiTokensEnabled = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}