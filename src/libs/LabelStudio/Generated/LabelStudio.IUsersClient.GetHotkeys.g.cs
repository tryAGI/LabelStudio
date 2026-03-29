#nullable enable

namespace LabelStudio
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user hotkeys<br/>
        /// Retrieve the custom hotkeys configuration for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Hotkeys> GetHotkeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}