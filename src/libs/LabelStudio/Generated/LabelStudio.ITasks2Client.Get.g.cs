#nullable enable

namespace LabelStudio
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Get task<br/>
        /// Get task data, metadata, annotations and other attributes for a specific labeling task by task ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.RoleBasedTask> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}