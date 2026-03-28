#nullable enable

namespace LabelStudio
{
    public partial interface IPredictions2Client
    {
        /// <summary>
        /// Delete prediction<br/>
        /// Delete a prediction by prediction ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}