#nullable enable

namespace LabelStudio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// ✨ Export project members as CSV<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Download every member of a project matching the supplied member-list filters as a CSV file. This endpoint is restricted to users who can manage project settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="implicit"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="ordering"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userType"></param>
        /// <param name="withDeleted"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExportCsvAsync(
            int id,
            string? ids = default,
            bool? @implicit = default,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? ordering = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            string? userType = default,
            bool? withDeleted = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Export project members as CSV<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Download every member of a project matching the supplied member-list filters as a CSV file. This endpoint is restricted to users who can manage project settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="implicit"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="ordering"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userType"></param>
        /// <param name="withDeleted"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ExportCsvAsStreamAsync(
            int id,
            string? ids = default,
            bool? @implicit = default,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? ordering = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            string? userType = default,
            bool? withDeleted = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Export project members as CSV<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Download every member of a project matching the supplied member-list filters as a CSV file. This endpoint is restricted to users who can manage project settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="implicit"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="ordering"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userType"></param>
        /// <param name="withDeleted"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<byte[]>> ExportCsvAsResponseAsync(
            int id,
            string? ids = default,
            bool? @implicit = default,
            string? lastActivityGte = default,
            string? lastActivityLte = default,
            string? ordering = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            string? userType = default,
            bool? withDeleted = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}