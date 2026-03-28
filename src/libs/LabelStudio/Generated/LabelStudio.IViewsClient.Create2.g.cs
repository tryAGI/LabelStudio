#nullable enable

namespace LabelStudio
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Create view<br/>
        /// Create a view for a specific project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> Create2Async(

            global::LabelStudio.ApiDmViewsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create view<br/>
        /// Create a view for a specific project.
        /// </summary>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> Create2Async(
            global::LabelStudio.ApiDmViewsCreateRequestData? data = default,
            int? project = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}