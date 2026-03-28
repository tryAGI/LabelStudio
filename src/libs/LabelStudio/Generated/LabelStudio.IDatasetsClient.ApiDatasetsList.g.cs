#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// List all datasets.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.Dataset>> ApiDatasetsListAsync(
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}