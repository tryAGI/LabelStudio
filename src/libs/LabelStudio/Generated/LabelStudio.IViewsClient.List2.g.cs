#nullable enable

namespace LabelStudio
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// List views<br/>
        /// List all views for a specific project.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.View>> List2Async(
            int? project = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}