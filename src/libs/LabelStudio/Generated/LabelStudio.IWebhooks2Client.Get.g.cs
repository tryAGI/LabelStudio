#nullable enable

namespace LabelStudio
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// Get webhook info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Webhook> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}