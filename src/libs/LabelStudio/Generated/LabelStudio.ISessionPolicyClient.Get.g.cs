#nullable enable

namespace LabelStudio
{
    public partial interface ISessionPolicyClient
    {
        /// <summary>
        /// Retrieve Session Policy<br/>
        /// Retrieve session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.SessionTimeoutPolicy> GetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}