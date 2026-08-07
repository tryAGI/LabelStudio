#nullable enable

namespace LabelStudio
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAsync(
            global::LabelStudio.ApiDmActionsCreateId id,
            int project,

            global::LabelStudio.PrepareParamsRequestRequest request,
            int? view = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse> CreateAsResponseAsync(
            global::LabelStudio.ApiDmActionsCreateId id,
            int project,

            global::LabelStudio.PrepareParamsRequestRequest request,
            int? view = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post actions<br/>
        /// Perform a Data Manager action with the selected tasks and filters. Note: More complex actions require additional parameters in the request body. Call `GET api/actions?project=&lt;id&gt;` to explore them. Example: `GET api/actions?id=delete_tasks&amp;project=1`
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="filters"></param>
        /// <param name="ordering"></param>
        /// <param name="selectedItems">
        /// Task selection by IDs. If filters are applied, the selection will be applied to the filtered tasks.If "all" is `false`, `"included"` must be used. If "all" is `true`, `"excluded"` must be used.Examples: `{"all": false, "included": [1, 2, 3]}` or `{"all": true, "excluded": [4, 5]}`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAsync(
            global::LabelStudio.ApiDmActionsCreateId id,
            int project,
            int? view = default,
            global::LabelStudio.PrepareParamsFiltersRequest? filters = default,
            global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? ordering = default,
            global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? selectedItems = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}