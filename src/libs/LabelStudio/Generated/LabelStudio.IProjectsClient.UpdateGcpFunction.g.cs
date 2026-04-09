#nullable enable

namespace LabelStudio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// ✨ Update GCP custom metric Cloud Function<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create or update the GCP Cloud Function used for custom metrics in this project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateGcpFunctionAsync(
            int id,

            global::LabelStudio.GCPCustomFunctionUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update GCP custom metric Cloud Function<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create or update the GCP Cloud Function used for custom metrics in this project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="code">
        /// The Python code for the custom metric function.
        /// </param>
        /// <param name="project">
        /// The GCP project ID. Uses default if not provided.
        /// </param>
        /// <param name="region">
        /// The GCP region for the Cloud Function. Uses default if not provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateGcpFunctionAsync(
            int id,
            string code,
            string? project = default,
            string? region = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}