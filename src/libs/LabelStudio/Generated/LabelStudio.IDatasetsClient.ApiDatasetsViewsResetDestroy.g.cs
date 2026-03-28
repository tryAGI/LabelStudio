#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Reset dataset views<br/>
        /// Reset all views for a specific dataset.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsViewsResetDestroyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}