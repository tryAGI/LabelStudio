#nullable enable

namespace LabelStudio
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Update view<br/>
        /// Update view data with additional filters and other information for a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> UpdateAsync(
            string id,

            global::LabelStudio.ApiDmViewsPartialUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update view<br/>
        /// Update view data with additional filters and other information for a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> UpdateAsync(
            string id,
            global::LabelStudio.ApiDmViewsPartialUpdateRequestData? data = default,
            int? project = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}