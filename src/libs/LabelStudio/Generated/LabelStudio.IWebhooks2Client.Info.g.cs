#nullable enable

namespace LabelStudio
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// Get all webhook actions<br/>
        /// Get descriptions of all available webhook actions to set up webhooks.
        /// </summary>
        /// <param name="organizationOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiWebhooksInfoRetrieveResponse> InfoAsync(
            bool? organizationOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}