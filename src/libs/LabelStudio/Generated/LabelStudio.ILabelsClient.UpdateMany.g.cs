#nullable enable

namespace LabelStudio
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Bulk update labels<br/>
        ///         If you want to update the labels in saved annotations, use this endpoint.<br/>
        ///         
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateManyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}