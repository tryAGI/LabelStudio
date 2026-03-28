#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Bulk create organization member tags<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create multiple member tags for the organization in bulk. Duplicate labels within the request are deduplicated. Labels that already exist in the organization are skipped.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse> PostAsync(
            int id,

            global::LabelStudio.OrganizationMemberTagBulkCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Bulk create organization member tags<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create multiple member tags for the organization in bulk. Duplicate labels within the request are deduplicated. Labels that already exist in the organization are skipped.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="labels">
        /// List of tag labels to create.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse> PostAsync(
            int id,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}