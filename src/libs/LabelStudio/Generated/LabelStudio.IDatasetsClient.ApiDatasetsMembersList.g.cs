#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get datasets members<br/>
        /// Retrieve the members for a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.DatasetMember>> ApiDatasetsMembersListAsync(
            int id,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}