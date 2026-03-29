#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user hotkeys<br/>
        /// Update the custom hotkeys configuration for the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Hotkeys> UpdateHotkeysAsync(

            global::LabelStudio.PatchedHotkeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user hotkeys<br/>
        /// Update the custom hotkeys configuration for the current user.
        /// </summary>
        /// <param name="customHotkeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Hotkeys> UpdateHotkeysAsync(
            object? customHotkeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}