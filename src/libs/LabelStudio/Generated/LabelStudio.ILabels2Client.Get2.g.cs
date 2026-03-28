#nullable enable

namespace LabelStudio
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// Get label<br/>
        ///         Retrieve a specific custom label used for your project by its ID.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Label> Get2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}