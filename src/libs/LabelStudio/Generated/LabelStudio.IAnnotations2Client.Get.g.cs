#nullable enable

namespace LabelStudio
{
    public partial interface IAnnotations2Client
    {
        /// <summary>
        /// Get annotation by its ID<br/>
        /// Retrieve a specific annotation for a task using the annotation result ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.Annotation> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}