#nullable enable

namespace LabelStudio
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Get ML Backend<br/>
        ///     Get details about a specific ML backend connection by ID. For example, make a GET request using the<br/>
        ///     following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.MLBackend> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}