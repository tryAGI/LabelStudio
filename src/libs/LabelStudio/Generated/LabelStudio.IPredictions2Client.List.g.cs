#nullable enable

namespace LabelStudio
{
    public partial interface IPredictions2Client
    {
        /// <summary>
        /// List predictions<br/>
        /// List all predictions and their IDs.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="task"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.Prediction>> ListAsync(
            int? project = default,
            int? task = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}