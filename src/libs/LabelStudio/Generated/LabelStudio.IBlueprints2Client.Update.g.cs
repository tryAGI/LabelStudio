#nullable enable

namespace LabelStudio
{
    public partial interface IBlueprints2Client
    {
        /// <summary>
        /// Update blueprint<br/>
        /// Update a blueprint. Only title, description, and task_ids can be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Blueprint> UpdateAsync(
            string id,

            global::LabelStudio.PatchedBlueprintUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update blueprint<br/>
        /// Update a blueprint. Only title, description, and task_ids can be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="taskIds">
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Blueprint> UpdateAsync(
            string id,
            global::System.Collections.Generic.IList<int> taskIds,
            string? description = default,
            string? title = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}