#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get invite link<br/>
        /// Get invite link for organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.OrganizationInvite> GetInviteLinkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}