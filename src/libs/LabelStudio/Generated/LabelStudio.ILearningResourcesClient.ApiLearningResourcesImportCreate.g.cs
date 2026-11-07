#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Import a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create an unpublished course in a workspace from an exported course file: the JSON payload, or the zip bundle that also carries its files. Files in a bundle become the new course's own assets. Other asset ids are only valid in the organization and instance the file was exported from. In that case asset URLs are kept and `unresolved_asset_ids` lists the ones that do not exist in this organization. For any other file (another organization or instance, or no source recorded) every asset id that is not bundled is listed as unresolved and its URL is detached so it cannot resolve to an asset here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseImportResponse> ApiLearningResourcesImportCreateAsync(

            global::LabelStudio.ApiLearningResourcesImportCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Import a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create an unpublished course in a workspace from an exported course file: the JSON payload, or the zip bundle that also carries its files. Files in a bundle become the new course's own assets. Other asset ids are only valid in the organization and instance the file was exported from. In that case asset URLs are kept and `unresolved_asset_ids` lists the ones that do not exist in this organization. For any other file (another organization or instance, or no source recorded) every asset id that is not bundled is listed as unresolved and its URL is detached so it cannot resolve to an asset here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.CourseImportResponse>> ApiLearningResourcesImportCreateAsResponseAsync(

            global::LabelStudio.ApiLearningResourcesImportCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Import a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create an unpublished course in a workspace from an exported course file: the JSON payload, or the zip bundle that also carries its files. Files in a bundle become the new course's own assets. Other asset ids are only valid in the organization and instance the file was exported from. In that case asset URLs are kept and `unresolved_asset_ids` lists the ones that do not exist in this organization. For any other file (another organization or instance, or no source recorded) every asset id that is not bundled is listed as unresolved and its URL is detached so it cannot resolve to an asset here.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseImportResponse> ApiLearningResourcesImportCreateAsync(
            byte[] file,
            string filename,
            int workspace,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ✨ Import a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create an unpublished course in a workspace from an exported course file: the JSON payload, or the zip bundle that also carries its files. Files in a bundle become the new course's own assets. Other asset ids are only valid in the organization and instance the file was exported from. In that case asset URLs are kept and `unresolved_asset_ids` lists the ones that do not exist in this organization. For any other file (another organization or instance, or no source recorded) every asset id that is not bundled is listed as unresolved and its URL is detached so it cannot resolve to an asset here.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.CourseImportResponse> ApiLearningResourcesImportCreateAsync(
            global::System.IO.Stream file,
            string filename,
            int workspace,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Import a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create an unpublished course in a workspace from an exported course file: the JSON payload, or the zip bundle that also carries its files. Files in a bundle become the new course's own assets. Other asset ids are only valid in the organization and instance the file was exported from. In that case asset URLs are kept and `unresolved_asset_ids` lists the ones that do not exist in this organization. For any other file (another organization or instance, or no source recorded) every asset id that is not bundled is listed as unresolved and its URL is detached so it cannot resolve to an asset here.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.CourseImportResponse>> ApiLearningResourcesImportCreateAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            int workspace,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}