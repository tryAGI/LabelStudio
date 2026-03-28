#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Get label link<br/>
        /// Get label links for a specific project configuration. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LabelLink> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}