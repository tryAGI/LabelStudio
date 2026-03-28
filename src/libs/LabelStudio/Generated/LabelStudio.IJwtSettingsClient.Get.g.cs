#nullable enable

namespace LabelStudio
{
    public partial interface IJwtSettingsClient
    {
        /// <summary>
        /// Retrieve JWT Settings<br/>
        /// Retrieve JWT settings for the currently active organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LSEJWTSettings> GetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}