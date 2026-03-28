#nullable enable

namespace LabelStudio
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Delete all tasks<br/>
        /// Delete all tasks from a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAllTasksAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}