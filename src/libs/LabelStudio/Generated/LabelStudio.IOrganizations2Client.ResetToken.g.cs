#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizations2Client
    {
        /// <summary>
        /// Reset organization token<br/>
        /// Reset the token used in the invitation link to invite someone to an organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.OrganizationInvite> ResetTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}