#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// List label links<br/>
        /// List label links for a specific label and project.
        /// </summary>
        /// <param name="labelCreatedAt"></param>
        /// <param name="labelCreatedAtGte"></param>
        /// <param name="labelCreatedAtLte"></param>
        /// <param name="labelCreatedBy"></param>
        /// <param name="page"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedLabelLinkList> ListAsync(
            global::System.DateTime? labelCreatedAt = default,
            global::System.DateTime? labelCreatedAtGte = default,
            global::System.DateTime? labelCreatedAtLte = default,
            int? labelCreatedBy = default,
            int? page = default,
            int? project = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List label links<br/>
        /// List label links for a specific label and project.
        /// </summary>
        /// <param name="labelCreatedAt"></param>
        /// <param name="labelCreatedAtGte"></param>
        /// <param name="labelCreatedAtLte"></param>
        /// <param name="labelCreatedBy"></param>
        /// <param name="page"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLabelLinkList>> ListAsResponseAsync(
            global::System.DateTime? labelCreatedAt = default,
            global::System.DateTime? labelCreatedAtGte = default,
            global::System.DateTime? labelCreatedAtLte = default,
            int? labelCreatedBy = default,
            int? page = default,
            int? project = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}