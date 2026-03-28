#nullable enable

namespace LabelStudio
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Soft delete an organization member<br/>
        /// Soft delete a member from the organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userPk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete3Async(
            int id,
            int userPk,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}