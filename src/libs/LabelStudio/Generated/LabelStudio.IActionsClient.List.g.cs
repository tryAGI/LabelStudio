#nullable enable

namespace LabelStudio
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get actions<br/>
        /// Retrieve all the registered actions with descriptions that data manager can use.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>> ListAsync(
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}