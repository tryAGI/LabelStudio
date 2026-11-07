#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Upload or import a file for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Upload a new file, or import media already reachable elsewhere (an asset from another course, a project upload, or — with `allow_external` — any http(s) URL) as a CourseAsset served from this origin. Exactly one of `file`/`url` is required; `allow_external` and `dry_run` are only valid with `url`. `dry_run` classifies the URL without creating anything. A source that does not exist and one you may not read both answer 403.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LearningResourceUploadResponse> ApiLearningResourcesUploadCreateAsync(
            int id,

            global::LabelStudio.ApiLearningResourcesUploadCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Upload or import a file for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Upload a new file, or import media already reachable elsewhere (an asset from another course, a project upload, or — with `allow_external` — any http(s) URL) as a CourseAsset served from this origin. Exactly one of `file`/`url` is required; `allow_external` and `dry_run` are only valid with `url`. `dry_run` classifies the URL without creating anything. A source that does not exist and one you may not read both answer 403.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LearningResourceUploadResponse>> ApiLearningResourcesUploadCreateAsResponseAsync(
            int id,

            global::LabelStudio.ApiLearningResourcesUploadCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Upload or import a file for a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Upload a new file, or import media already reachable elsewhere (an asset from another course, a project upload, or — with `allow_external` — any http(s) URL) as a CourseAsset served from this origin. Exactly one of `file`/`url` is required; `allow_external` and `dry_run` are only valid with `url`. `dry_run` classifies the URL without creating anything. A source that does not exist and one you may not read both answer 403.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowExternal"></param>
        /// <param name="dryRun"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LearningResourceUploadResponse> ApiLearningResourcesUploadCreateAsync(
            int id,
            bool? allowExternal = default,
            bool? dryRun = default,
            byte[]? file = default,
            string? filename = default,
            string? url = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}