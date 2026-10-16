#nullable enable

namespace LabelStudio
{
    public partial interface IInterfacesClient
    {
        /// <summary>
        /// ✨ Move a saved interface to another workspace<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Move a saved interface to a workspace, your Personal Sandbox, or Shared (`workspace: null`). A workspace-scoped interface can only be used by projects in its workspace, so connected projects move with it when needed. Send `dry_run: true` first to get the move plan, then confirm with `dry_run: false` and the `expected_project_ids` from that plan. The response is the plan in every case; a blocked move or a changed plan returns 409 with the fresh plan.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseInterfaceMovePlan> MoveAsync(
            int id,

            global::LabelStudio.LseInterfaceMoveRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Move a saved interface to another workspace<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Move a saved interface to a workspace, your Personal Sandbox, or Shared (`workspace: null`). A workspace-scoped interface can only be used by projects in its workspace, so connected projects move with it when needed. Send `dry_run: true` first to get the move plan, then confirm with `dry_run: false` and the `expected_project_ids` from that plan. The response is the plan in every case; a blocked move or a changed plan returns 409 with the fresh plan.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LseInterfaceMovePlan>> MoveAsResponseAsync(
            int id,

            global::LabelStudio.LseInterfaceMoveRequestRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Move a saved interface to another workspace<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Move a saved interface to a workspace, your Personal Sandbox, or Shared (`workspace: null`). A workspace-scoped interface can only be used by projects in its workspace, so connected projects move with it when needed. Send `dry_run: true` first to get the move plan, then confirm with `dry_run: false` and the `expected_project_ids` from that plan. The response is the plan in every case; a blocked move or a changed plan returns 409 with the fresh plan.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dryRun">
        /// Return the move plan without changing anything.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expectedProjectIds">
        /// Required when dry_run is false: IDs of the projects in workspace groups with outcome "move" from the dry run you confirmed. If the server computes a different set, it responds with 409 "interface_move_plan_changed" and the fresh plan.
        /// </param>
        /// <param name="workspace">
        /// Target workspace ID, or null to make the interface Shared.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseInterfaceMovePlan> MoveAsync(
            int id,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<int>? expectedProjectIds = default,
            int? workspace = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}