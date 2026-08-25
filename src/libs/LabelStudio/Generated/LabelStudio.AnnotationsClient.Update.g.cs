
#nullable enable

namespace LabelStudio
{
    public partial class AnnotationsClient
    {


        private static readonly global::LabelStudio.EndPointSecurityRequirement s_UpdateSecurityRequirement0 =
            new global::LabelStudio.EndPointSecurityRequirement
            {
                Authorizations = new global::LabelStudio.EndPointAuthorizationRequirement[]
                {                    new global::LabelStudio.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::LabelStudio.EndPointSecurityRequirement[] s_UpdateSecurityRequirements =
            new global::LabelStudio.EndPointSecurityRequirement[]
            {                s_UpdateSecurityRequirement0,
            };
        partial void PrepareUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::LabelStudio.PatchedAnnotationRequest request);
        partial void PrepareUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::LabelStudio.PatchedAnnotationRequest request);
        partial void ProcessUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update annotation<br/>
        /// Update existing attributes on an annotation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.Annotation> UpdateAsync(
            int id,

            global::LabelStudio.PatchedAnnotationRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdateAsResponseAsync(
                id: id,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update annotation<br/>
        /// Update existing attributes on an annotation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.Annotation>> UpdateAsResponseAsync(
            int id,

            global::LabelStudio.PatchedAnnotationRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::LabelStudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateSecurityRequirements,
                operationName: "UpdateAsync");

            using var __timeoutCancellationTokenSource = global::LabelStudio.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::LabelStudio.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::LabelStudio.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::LabelStudio.PathBuilder(
                                path: $"/api/annotations/{id}/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::LabelStudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::LabelStudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUpdateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::LabelStudio.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/api/annotations/{id}/\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::LabelStudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/api/annotations/{id}/\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LabelStudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LabelStudio.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::LabelStudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/api/annotations/{id}/\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LabelStudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessUpdateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/api/annotations/{id}/\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/api/annotations/{id}/\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessUpdateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LabelStudio.Annotation.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.Annotation>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LabelStudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::LabelStudio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::LabelStudio.Annotation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.Annotation>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LabelStudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::LabelStudio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update annotation<br/>
        /// Update existing attributes on an annotation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bulkCreated">
        /// Annotation was created in bulk mode
        /// </param>
        /// <param name="completedBy"></param>
        /// <param name="draftCreatedAt">
        /// Draft creation time
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth (ground_truth)
        /// </param>
        /// <param name="importId">
        /// Original annotation ID that was at the import step or NULL if this annotation wasn't imported
        /// </param>
        /// <param name="lastAction">
        /// Action which was performed in the last annotation history item<br/>
        /// * `prediction` - Created from prediction<br/>
        /// * `propagated_annotation` - Created from another annotation<br/>
        /// * `imported` - Imported<br/>
        /// * `submitted` - Submitted<br/>
        /// * `updated` - Updated<br/>
        /// * `skipped` - Skipped<br/>
        /// * `accepted` - Accepted<br/>
        /// * `rejected` - Rejected<br/>
        /// * `fixed_and_accepted` - Fixed and accepted<br/>
        /// * `deleted_review` - Deleted review
        /// </param>
        /// <param name="lastCreatedBy">
        /// User who created the last annotation history item
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task
        /// </param>
        /// <param name="parentAnnotation">
        /// Points to the parent annotation from which this annotation was created
        /// </param>
        /// <param name="parentPrediction">
        /// Points to the prediction from which this annotation was created
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// List of annotation results for the task
        /// </param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="uniqueId">
        /// Included only in requests
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.Annotation> UpdateAsync(
            int id,
            bool? bulkCreated = default,
            int? completedBy = default,
            global::System.DateTime? draftCreatedAt = default,
            bool? groundTruth = default,
            long? importId = default,
            global::LabelStudio.AnnotationHistoryActionEnum? lastAction = default,
            int? lastCreatedBy = default,
            double? leadTime = default,
            int? parentAnnotation = default,
            int? parentPrediction = default,
            int? project = default,
            global::System.Collections.Generic.IList<object>? result = default,
            int? task = default,
            string? uniqueId = default,
            int? updatedBy = default,
            bool? wasCancelled = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LabelStudio.PatchedAnnotationRequest
            {
                BulkCreated = bulkCreated,
                CompletedBy = completedBy,
                DraftCreatedAt = draftCreatedAt,
                GroundTruth = groundTruth,
                ImportId = importId,
                LastAction = lastAction,
                LastCreatedBy = lastCreatedBy,
                LeadTime = leadTime,
                ParentAnnotation = parentAnnotation,
                ParentPrediction = parentPrediction,
                Project = project,
                Result = result,
                Task = task,
                UniqueId = uniqueId,
                UpdatedBy = updatedBy,
                WasCancelled = wasCancelled,
            };

            return await UpdateAsync(
                id: id,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}