#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Create label links<br/>
        /// Create label links to link new custom labels to your project labeling configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LabelLink> CreateAsync(

            global::LabelStudio.LabelLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create label links<br/>
        /// Create label links to link new custom labels to your project labeling configuration.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LabelLink> CreateAsync(
            string fromName,
            int label,
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}