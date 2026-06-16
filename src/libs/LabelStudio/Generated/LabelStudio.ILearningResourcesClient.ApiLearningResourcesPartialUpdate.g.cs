#nullable enable

namespace LabelStudio
{
    public partial interface ILearningResourcesClient
    {
        /// <summary>
        /// ✨ Update a learning resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LearningResourceUpdate> ApiLearningResourcesPartialUpdateAsync(
            string id,

            global::LabelStudio.PatchedLearningResourceUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update a learning resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LearningResourceUpdate>> ApiLearningResourcesPartialUpdateAsResponseAsync(
            string id,

            global::LabelStudio.PatchedLearningResourceUpdateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update a learning resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowStandalone"></param>
        /// <param name="color"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="defaultAllowManualAccess"></param>
        /// <param name="defaultGateAnnotatorDataManager"></param>
        /// <param name="defaultGateAnnotatorLabelStream"></param>
        /// <param name="defaultGateReviewerDataManager"></param>
        /// <param name="defaultGateReviewerLabelStream"></param>
        /// <param name="defaultGateReviewerReviewStream"></param>
        /// <param name="estimatedDurationUnit">
        /// * `minutes` - Minutes<br/>
        /// * `hours` - Hours<br/>
        /// * `days` - Days<br/>
        /// * `weeks` - Weeks
        /// </param>
        /// <param name="estimatedDurationValue"></param>
        /// <param name="generateCertificateOnCompletion"></param>
        /// <param name="hideCompletedQuizzes"></param>
        /// <param name="summary"></param>
        /// <param name="title"></param>
        /// <param name="workspace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LearningResourceUpdate> ApiLearningResourcesPartialUpdateAsync(
            string id,
            bool? allowStandalone = default,
            string? color = default,
            string? coverImageUrl = default,
            bool? defaultAllowManualAccess = default,
            bool? defaultGateAnnotatorDataManager = default,
            bool? defaultGateAnnotatorLabelStream = default,
            bool? defaultGateReviewerDataManager = default,
            bool? defaultGateReviewerLabelStream = default,
            bool? defaultGateReviewerReviewStream = default,
            global::LabelStudio.EstimatedDurationUnitEnum? estimatedDurationUnit = default,
            int? estimatedDurationValue = default,
            bool? generateCertificateOnCompletion = default,
            bool? hideCompletedQuizzes = default,
            string? summary = default,
            string? title = default,
            int? workspace = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}