
#nullable enable

namespace LabelStudio
{
    public partial class Prompts2Client
    {


        private static readonly global::LabelStudio.EndPointSecurityRequirement s_SubsetTasksSecurityRequirement0 =
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
        private static readonly global::LabelStudio.EndPointSecurityRequirement[] s_SubsetTasksSecurityRequirements =
            new global::LabelStudio.EndPointSecurityRequirement[]
            {                s_SubsetTasksSecurityRequirement0,
            };
        partial void PrepareSubsetTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? alignmentClass,
            ref string? alignmentFromName,
            ref global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome,
            ref bool? includeTotal,
            ref int? modelRun,
            ref string? ordering,
            ref string? outputClass,
            ref string? outputFromName,
            ref int? page,
            ref int? pageSize,
            ref int? parentModel,
            ref string? predictionVersionIds,
            ref int projectPk,
            ref string? projectSubset);
        partial void PrepareSubsetTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? alignmentClass,
            string? alignmentFromName,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome,
            bool? includeTotal,
            int? modelRun,
            string? ordering,
            string? outputClass,
            string? outputFromName,
            int? page,
            int? pageSize,
            int? parentModel,
            string? predictionVersionIds,
            int projectPk,
            string? projectSubset);
        partial void ProcessSubsetTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSubsetTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Get Project Subset Task List with Predictions and Accuracy details<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         Provides list of tasks, based on project subset. Includes predictions for tasks. For the 'HasGT' subset, accuracy metrics will also be provided.<br/>
        ///         
        /// </summary>
        /// <param name="alignmentClass"></param>
        /// <param name="alignmentFromName"></param>
        /// <param name="alignmentOutcome"></param>
        /// <param name="includeTotal"></param>
        /// <param name="modelRun"></param>
        /// <param name="ordering"></param>
        /// <param name="outputClass"></param>
        /// <param name="outputFromName"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentModel"></param>
        /// <param name="predictionVersionIds"></param>
        /// <param name="projectPk"></param>
        /// <param name="projectSubset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedProjectSubsetTasksResponseList> SubsetTasksAsync(
            int projectPk,
            string? alignmentClass = default,
            string? alignmentFromName = default,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome = default,
            bool? includeTotal = default,
            int? modelRun = default,
            string? ordering = default,
            string? outputClass = default,
            string? outputFromName = default,
            int? page = default,
            int? pageSize = default,
            int? parentModel = default,
            string? predictionVersionIds = default,
            string? projectSubset = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SubsetTasksAsResponseAsync(
                projectPk: projectPk,
                alignmentClass: alignmentClass,
                alignmentFromName: alignmentFromName,
                alignmentOutcome: alignmentOutcome,
                includeTotal: includeTotal,
                modelRun: modelRun,
                ordering: ordering,
                outputClass: outputClass,
                outputFromName: outputFromName,
                page: page,
                pageSize: pageSize,
                parentModel: parentModel,
                predictionVersionIds: predictionVersionIds,
                projectSubset: projectSubset,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// ✨ Get Project Subset Task List with Predictions and Accuracy details<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         Provides list of tasks, based on project subset. Includes predictions for tasks. For the 'HasGT' subset, accuracy metrics will also be provided.<br/>
        ///         
        /// </summary>
        /// <param name="alignmentClass"></param>
        /// <param name="alignmentFromName"></param>
        /// <param name="alignmentOutcome"></param>
        /// <param name="includeTotal"></param>
        /// <param name="modelRun"></param>
        /// <param name="ordering"></param>
        /// <param name="outputClass"></param>
        /// <param name="outputFromName"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentModel"></param>
        /// <param name="predictionVersionIds"></param>
        /// <param name="projectPk"></param>
        /// <param name="projectSubset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedProjectSubsetTasksResponseList>> SubsetTasksAsResponseAsync(
            int projectPk,
            string? alignmentClass = default,
            string? alignmentFromName = default,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? alignmentOutcome = default,
            bool? includeTotal = default,
            int? modelRun = default,
            string? ordering = default,
            string? outputClass = default,
            string? outputFromName = default,
            int? page = default,
            int? pageSize = default,
            int? parentModel = default,
            string? predictionVersionIds = default,
            string? projectSubset = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSubsetTasksArguments(
                httpClient: HttpClient,
                alignmentClass: ref alignmentClass,
                alignmentFromName: ref alignmentFromName,
                alignmentOutcome: ref alignmentOutcome,
                includeTotal: ref includeTotal,
                modelRun: ref modelRun,
                ordering: ref ordering,
                outputClass: ref outputClass,
                outputFromName: ref outputFromName,
                page: ref page,
                pageSize: ref pageSize,
                parentModel: ref parentModel,
                predictionVersionIds: ref predictionVersionIds,
                projectPk: ref projectPk,
                projectSubset: ref projectSubset);


            var __authorizations = global::LabelStudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SubsetTasksSecurityRequirements,
                operationName: "SubsetTasksAsync");

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
                                path: $"/api/projects/{projectPk}/subset-tasks",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("alignment_class", alignmentClass)
                                .AddOptionalParameter("alignment_from_name", alignmentFromName)
                                .AddOptionalParameter("alignment_outcome", alignmentOutcome?.ToValueString())
                                .AddOptionalParameter("include_total", includeTotal?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("model_run", modelRun?.ToString())
                                .AddOptionalParameter("ordering", ordering)
                                .AddOptionalParameter("output_class", outputClass)
                                .AddOptionalParameter("output_from_name", outputFromName)
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("parent_model", parentModel?.ToString())
                                .AddOptionalParameter("prediction_version_ids", predictionVersionIds)
                                .AddOptionalParameter("project_subset", projectSubset)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::LabelStudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::LabelStudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSubsetTasksRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    alignmentClass: alignmentClass,
                    alignmentFromName: alignmentFromName,
                    alignmentOutcome: alignmentOutcome,
                    includeTotal: includeTotal,
                    modelRun: modelRun,
                    ordering: ordering,
                    outputClass: outputClass,
                    outputFromName: outputFromName,
                    page: page,
                    pageSize: pageSize,
                    parentModel: parentModel,
                    predictionVersionIds: predictionVersionIds,
                    projectPk: projectPk!,
                    projectSubset: projectSubset);

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
                                operationId: "SubsetTasks",
                                methodName: "SubsetTasksAsync",
                                pathTemplate: "$\"/api/projects/{projectPk}/subset-tasks\"",
                                httpMethod: "GET",
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
                                operationId: "SubsetTasks",
                                methodName: "SubsetTasksAsync",
                                pathTemplate: "$\"/api/projects/{projectPk}/subset-tasks\"",
                                httpMethod: "GET",
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
                                operationId: "SubsetTasks",
                                methodName: "SubsetTasksAsync",
                                pathTemplate: "$\"/api/projects/{projectPk}/subset-tasks\"",
                                httpMethod: "GET",
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
                ProcessSubsetTasksResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubsetTasks",
                                methodName: "SubsetTasksAsync",
                                pathTemplate: "$\"/api/projects/{projectPk}/subset-tasks\"",
                                httpMethod: "GET",
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
                                operationId: "SubsetTasks",
                                methodName: "SubsetTasksAsync",
                                pathTemplate: "$\"/api/projects/{projectPk}/subset-tasks\"",
                                httpMethod: "GET",
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
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::LabelStudio.ApiException(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessSubsetTasksResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LabelStudio.PaginatedProjectSubsetTasksResponseList.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedProjectSubsetTasksResponseList>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LabelStudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::LabelStudio.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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

                                    var __value = await global::LabelStudio.PaginatedProjectSubsetTasksResponseList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedProjectSubsetTasksResponseList>(
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

                                    throw new global::LabelStudio.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}