#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizations2Client
    {
        /// <summary>
        /// List your organizations<br/>
        ///         Return a list of the organizations you've created or that you have access to.<br/>
        ///         
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>> ListAsync(
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List your organizations<br/>
        ///         Return a list of the organizations you've created or that you have access to.<br/>
        ///         
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>>> ListAsResponseAsync(
            string? ordering = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}