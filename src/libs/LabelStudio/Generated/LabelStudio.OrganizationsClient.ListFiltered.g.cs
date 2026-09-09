
#nullable enable

namespace LabelStudio
{
    public partial class OrganizationsClient
    {


        private static readonly global::LabelStudio.EndPointSecurityRequirement s_ListFilteredSecurityRequirement0 =
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
        private static readonly global::LabelStudio.EndPointSecurityRequirement[] s_ListFilteredSecurityRequirements =
            new global::LabelStudio.EndPointSecurityRequirement[]
            {                s_ListFilteredSecurityRequirement0,
            };
        partial void PrepareListFilteredArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref double? excludeProjectId,
            ref double? excludeWorkspaceId,
            ref string? filters,
            ref int id,
            ref bool? isDeleted,
            ref string? ordering,
            ref int? page,
            ref int? pageSize,
            global::System.Collections.Generic.IList<string>? role,
            ref string? search,
            global::System.Collections.Generic.IList<int>? tags,
            ref global::System.DateTime? userLastActivityGte,
            ref global::System.DateTime? userLastActivityLte,
            global::System.Collections.Generic.IList<string>? userType);
        partial void PrepareListFilteredRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double? excludeProjectId,
            double? excludeWorkspaceId,
            string? filters,
            int id,
            bool? isDeleted,
            string? ordering,
            int? page,
            int? pageSize,
            global::System.Collections.Generic.IList<string>? role,
            string? search,
            global::System.Collections.Generic.IList<int>? tags,
            global::System.DateTime? userLastActivityGte,
            global::System.DateTime? userLastActivityLte,
            global::System.Collections.Generic.IList<string>? userType);
        partial void ProcessListFilteredResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFilteredResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization members using reusable filters<br/>
        /// Retrieve a paginated organization-member list using the versioned `filters` query parameter.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.PaginatedLseOrganizationMemberListList> ListFilteredAsync(
            int id,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            string? filters = default,
            bool? isDeleted = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<string>? role = default,
            string? search = default,
            global::System.Collections.Generic.IList<int>? tags = default,
            global::System.DateTime? userLastActivityGte = default,
            global::System.DateTime? userLastActivityLte = default,
            global::System.Collections.Generic.IList<string>? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListFilteredAsResponseAsync(
                id: id,
                excludeProjectId: excludeProjectId,
                excludeWorkspaceId: excludeWorkspaceId,
                filters: filters,
                isDeleted: isDeleted,
                ordering: ordering,
                page: page,
                pageSize: pageSize,
                role: role,
                search: search,
                tags: tags,
                userLastActivityGte: userLastActivityGte,
                userLastActivityLte: userLastActivityLte,
                userType: userType,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List organization members using reusable filters<br/>
        /// Retrieve a paginated organization-member list using the versioned `filters` query parameter.
        /// </summary>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="id"></param>
        /// <param name="isDeleted"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="userLastActivityGte"></param>
        /// <param name="userLastActivityLte"></param>
        /// <param name="userType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLseOrganizationMemberListList>> ListFilteredAsResponseAsync(
            int id,
            double? excludeProjectId = default,
            double? excludeWorkspaceId = default,
            string? filters = default,
            bool? isDeleted = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<string>? role = default,
            string? search = default,
            global::System.Collections.Generic.IList<int>? tags = default,
            global::System.DateTime? userLastActivityGte = default,
            global::System.DateTime? userLastActivityLte = default,
            global::System.Collections.Generic.IList<string>? userType = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListFilteredArguments(
                httpClient: HttpClient,
                excludeProjectId: ref excludeProjectId,
                excludeWorkspaceId: ref excludeWorkspaceId,
                filters: ref filters,
                id: ref id,
                isDeleted: ref isDeleted,
                ordering: ref ordering,
                page: ref page,
                pageSize: ref pageSize,
                role: role,
                search: ref search,
                tags: tags,
                userLastActivityGte: ref userLastActivityGte,
                userLastActivityLte: ref userLastActivityLte,
                userType: userType);


            var __authorizations = global::LabelStudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListFilteredSecurityRequirements,
                operationName: "ListFilteredAsync");

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
                                path: $"/api/organizations/{id}/memberships/search",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("exclude_project_id", excludeProjectId?.ToString())
                                .AddOptionalParameter("exclude_workspace_id", excludeWorkspaceId?.ToString())
                                .AddOptionalParameter("filters", filters)
                                .AddOptionalParameter("is_deleted", isDeleted?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("ordering", ordering)
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("role", role, delimiter: ",", explode: false)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("tags", tags, selector: static x => x.ToString()!, delimiter: ",", explode: false)
                                .AddOptionalParameter("user__last_activity__gte", userLastActivityGte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("user__last_activity__lte", userLastActivityLte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("user_type", userType, delimiter: ",", explode: false)
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
                PrepareListFilteredRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    excludeProjectId: excludeProjectId,
                    excludeWorkspaceId: excludeWorkspaceId,
                    filters: filters,
                    id: id!,
                    isDeleted: isDeleted,
                    ordering: ordering,
                    page: page,
                    pageSize: pageSize,
                    role: role,
                    search: search,
                    tags: tags,
                    userLastActivityGte: userLastActivityGte,
                    userLastActivityLte: userLastActivityLte,
                    userType: userType);

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
                                operationId: "ListFiltered",
                                methodName: "ListFilteredAsync",
                                pathTemplate: "$\"/api/organizations/{id}/memberships/search\"",
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
                                operationId: "ListFiltered",
                                methodName: "ListFilteredAsync",
                                pathTemplate: "$\"/api/organizations/{id}/memberships/search\"",
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
                                operationId: "ListFiltered",
                                methodName: "ListFilteredAsync",
                                pathTemplate: "$\"/api/organizations/{id}/memberships/search\"",
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
                ProcessListFilteredResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LabelStudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LabelStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListFiltered",
                                methodName: "ListFilteredAsync",
                                pathTemplate: "$\"/api/organizations/{id}/memberships/search\"",
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
                                operationId: "ListFiltered",
                                methodName: "ListFilteredAsync",
                                pathTemplate: "$\"/api/organizations/{id}/memberships/search\"",
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
                                ProcessListFilteredResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LabelStudio.PaginatedLseOrganizationMemberListList.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLseOrganizationMemberListList>(
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

                                    var __value = await global::LabelStudio.PaginatedLseOrganizationMemberListList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.PaginatedLseOrganizationMemberListList>(
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
    }
}