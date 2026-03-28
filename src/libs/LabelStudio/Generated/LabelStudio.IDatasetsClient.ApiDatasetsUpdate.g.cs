#nullable enable

namespace LabelStudio
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Put dataset<br/>
        /// Overwrite a specific dataset by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Dataset> ApiDatasetsUpdateAsync(
            string id,

            global::LabelStudio.DatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put dataset<br/>
        /// Overwrite a specific dataset by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columns">
        /// All data columns found in Dataset tasks
        /// </param>
        /// <param name="createdBy">
        /// User who created Dataset
        /// </param>
        /// <param name="description">
        /// Dataset description
        /// </param>
        /// <param name="organization"></param>
        /// <param name="title">
        /// Dataset title
        /// </param>
        /// <param name="totalEntities"></param>
        /// <param name="vectorDbDatasetName">
        /// Dataset name for weaviate schema
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Dataset> ApiDatasetsUpdateAsync(
            string id,
            string title,
            object? columns = default,
            global::LabelStudio.UserSimpleRequest? createdBy = default,
            string? description = default,
            int? organization = default,
            int? totalEntities = default,
            string? vectorDbDatasetName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}