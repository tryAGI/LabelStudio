#nullable enable

namespace LabelStudio
{
    public partial interface IDataManagerClient
    {
        /// <summary>
        /// Put view<br/>
        /// Overwrite view data with updated filters and other information for a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> ApiDmViewsUpdateAsync(
            string id,

            global::LabelStudio.ApiDmViewsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put view<br/>
        /// Overwrite view data with updated filters and other information for a specific project.
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
        global::System.Threading.Tasks.Task<global::LabelStudio.View> ApiDmViewsUpdateAsync(
            string id,
            global::LabelStudio.ApiDmViewsUpdateRequestData? data = default,
            int? project = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}