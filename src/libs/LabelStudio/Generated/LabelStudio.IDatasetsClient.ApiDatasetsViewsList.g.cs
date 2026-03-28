#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List dataset views<br/>
        /// List all views for a specific dataset.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.DatasetView>> ApiDatasetsViewsListAsync(
            int? dataset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}