#nullable enable

namespace LabelStudio
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// ✨ Bulk unassign workspace members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Unassign workspace members in bulk. Pass selector fields via query parameters (`all`, `included`, `excluded`) and optional paginated-list filters (`search`, `ids`). For backward compatibility, a JSON body with bulk fields is still accepted.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="excluded"></param>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="included"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse> Delete3Async(
            int id,
            bool? all = default,
            string? excluded = default,
            string? ids = default,
            string? included = default,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Bulk unassign workspace members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Unassign workspace members in bulk. Pass selector fields via query parameters (`all`, `included`, `excluded`) and optional paginated-list filters (`search`, `ids`). For backward compatibility, a JSON body with bulk fields is still accepted.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="excluded"></param>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="included"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse>> Delete3AsResponseAsync(
            int id,
            bool? all = default,
            string? excluded = default,
            string? ids = default,
            string? included = default,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}