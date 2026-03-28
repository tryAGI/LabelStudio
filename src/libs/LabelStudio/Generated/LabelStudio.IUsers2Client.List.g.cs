#nullable enable

namespace LabelStudio
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// List users<br/>
        /// List the users that exist on the Label Studio server.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LabelStudio.LseUserAPI>> ListAsync(
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}