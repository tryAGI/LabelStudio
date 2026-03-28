#nullable enable

namespace LabelStudio
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Create project from blueprint<br/>
        /// Create a new project from an existing blueprint. On success, user is redirected to the new project with a 302.
        /// </summary>
        /// <param name="shareId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiBlueprintsCreateProjectRetrieveAsync(
            string shareId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}