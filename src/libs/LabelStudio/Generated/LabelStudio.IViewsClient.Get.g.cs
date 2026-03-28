#nullable enable

namespace LabelStudio
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Get view details<br/>
        /// Get the details about a specific view in the data manager
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.View> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}