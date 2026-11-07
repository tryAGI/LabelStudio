#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Export a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Return the draft course (settings, modules, pages) as a portable JSON payload for Import. With any of `include_images`, `include_audio_video` and `include_other` the response is a zip instead: `course.json` (the same payload), `assets.json` and the referenced files under `assets/`. References that cannot be bundled are counted in the `X-Course-Export-Skipped-Assets` header.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeAudioVideo">
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Default Value: false
        /// </param>
        /// <param name="includeOther">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ApiLearningResourcesExportRetrieveAsBytesAsync(
            int id,
            bool? includeAudioVideo = default,
            bool? includeImages = default,
            bool? includeOther = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Export a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Return the draft course (settings, modules, pages) as a portable JSON payload for Import. With any of `include_images`, `include_audio_video` and `include_other` the response is a zip instead: `course.json` (the same payload), `assets.json` and the referenced files under `assets/`. References that cannot be bundled are counted in the `X-Course-Export-Skipped-Assets` header.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeAudioVideo">
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Default Value: false
        /// </param>
        /// <param name="includeOther">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ApiLearningResourcesExportRetrieveAsBytesAsStreamAsync(
            int id,
            bool? includeAudioVideo = default,
            bool? includeImages = default,
            bool? includeOther = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Export a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Return the draft course (settings, modules, pages) as a portable JSON payload for Import. With any of `include_images`, `include_audio_video` and `include_other` the response is a zip instead: `course.json` (the same payload), `assets.json` and the referenced files under `assets/`. References that cannot be bundled are counted in the `X-Course-Export-Skipped-Assets` header.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeAudioVideo">
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Default Value: false
        /// </param>
        /// <param name="includeOther">
        /// Default Value: false
        /// </param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::System.IO.Stream>> ApiLearningResourcesExportRetrieveAsBytesAsStreamAsResponseAsync(
            int id,
            bool? includeAudioVideo = default,
            bool? includeImages = default,
            bool? includeOther = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Export a learning resource<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Return the draft course (settings, modules, pages) as a portable JSON payload for Import. With any of `include_images`, `include_audio_video` and `include_other` the response is a zip instead: `course.json` (the same payload), `assets.json` and the referenced files under `assets/`. References that cannot be bundled are counted in the `X-Course-Export-Skipped-Assets` header.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeAudioVideo">
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Default Value: false
        /// </param>
        /// <param name="includeOther">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<byte[]>> ApiLearningResourcesExportRetrieveAsBytesAsResponseAsync(
            int id,
            bool? includeAudioVideo = default,
            bool? includeImages = default,
            bool? includeOther = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}