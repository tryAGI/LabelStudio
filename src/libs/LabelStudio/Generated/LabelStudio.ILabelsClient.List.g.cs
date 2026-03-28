#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// List label links<br/>
        /// List label links for a specific label and project.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedLabelLinkList> ListAsync(
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}