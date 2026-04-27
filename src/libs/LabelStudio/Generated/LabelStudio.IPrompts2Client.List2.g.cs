#nullable enable

namespace LabelStudio
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ List prompts<br/>
        /// List all prompts.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedModelInterfaceSerializerGETList> List2Async(
            string? ordering = default,
            int? page = default,
            string? search = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}