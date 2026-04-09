#nullable enable

namespace LabelStudio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// ✨ Bulk unassign project members<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Unassign project members in bulk. Pass selector fields via query parameters (`all`, `included`, `excluded`) and optional member filters (`search`, `role`, `tags`, `last_activity__gte`, `last_activity__lte`). For backward compatibility, a JSON body with bulk fields is still accepted.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="excluded"></param>
        /// <param name="id"></param>
        /// <param name="included"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiProjectsMembersBulkDestroyResponse> Delete2Async(
            int id,
            bool? all = default,
            string? excluded = default,
            string? included = default,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}