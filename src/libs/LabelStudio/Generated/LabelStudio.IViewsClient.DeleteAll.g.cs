#nullable enable

namespace LabelStudio
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Delete all project views<br/>
        /// Delete all views for a specific project.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAllAsync(
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}