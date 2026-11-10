#nullable enable

namespace LabelStudio
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID. Optional `since` / `until` limit the snapshot to tasks with `updated_at` in the half-open window `[since, until)`. `since` must be in the past; an omitted or later `until` becomes create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS. Set `ephemeral=true` to omit the snapshot from list endpoints. On deployments that run the RQ cron scheduler (SaaS; on-prem with `rqcron.enabled`), ephemeral exports older than EPHEMERAL_EXPORT_TTL_HOURS (default 24) are deleted by a daily low-queue sweep; otherwise they remain unlisted until explicitly deleted. Use the resolved `until` from the response as `since` on the next incremental create. Task deletions are not represented in incremental snapshots (only surviving tasks with bumped `updated_at`). Rows committed after the export query starts but stamped with `updated_at` before `until` can fall outside both consecutive windows; the default `until` lag mitigates long transactions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseExportCreate> CreateAsync(
            int id,

            global::LabelStudio.LseExportCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID. Optional `since` / `until` limit the snapshot to tasks with `updated_at` in the half-open window `[since, until)`. `since` must be in the past; an omitted or later `until` becomes create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS. Set `ephemeral=true` to omit the snapshot from list endpoints. On deployments that run the RQ cron scheduler (SaaS; on-prem with `rqcron.enabled`), ephemeral exports older than EPHEMERAL_EXPORT_TTL_HOURS (default 24) are deleted by a daily low-queue sweep; otherwise they remain unlisted until explicitly deleted. Use the resolved `until` from the response as `since` on the next incremental create. Task deletions are not represented in incremental snapshots (only surviving tasks with bumped `updated_at`). Rows committed after the export query starts but stamped with `updated_at` before `until` can fall outside both consecutive windows; the default `until` lag mitigates long transactions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LabelStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.AutoSDKHttpResponse<global::LabelStudio.LseExportCreate>> CreateAsResponseAsync(
            int id,

            global::LabelStudio.LseExportCreateRequest request,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID. Optional `since` / `until` limit the snapshot to tasks with `updated_at` in the half-open window `[since, until)`. `since` must be in the past; an omitted or later `until` becomes create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS. Set `ephemeral=true` to omit the snapshot from list endpoints. On deployments that run the RQ cron scheduler (SaaS; on-prem with `rqcron.enabled`), ephemeral exports older than EPHEMERAL_EXPORT_TTL_HOURS (default 24) are deleted by a daily low-queue sweep; otherwise they remain unlisted until explicitly deleted. Use the resolved `until` from the response as `since` on the next incremental create. Task deletions are not represented in incremental snapshots (only surviving tasks with bumped `updated_at`). Rows committed after the export query starts but stamped with `updated_at` before `until` can fall outside both consecutive windows; the default `until` lag mitigates long transactions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotationFilterOptions"></param>
        /// <param name="convertedFormats"></param>
        /// <param name="counters"></param>
        /// <param name="createdBy">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="ephemeral">
        /// When true, the export is omitted from list endpoints. Detail and download by id still work. TTL deletion (EPHEMERAL_EXPORT_TTL_HOURS, default 24) runs via the RQ cron scheduler when enabled (SaaS; on-prem `rqcron.enabled`); otherwise delete explicitly.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="md5"></param>
        /// <param name="serializationOptions"></param>
        /// <param name="since">
        /// Inclusive lower bound on Task.updated_at for an incremental snapshot. Omit for a full export. Pair with until for a half-open window [since, until).
        /// </param>
        /// <param name="status"></param>
        /// <param name="taskFilterOptions"></param>
        /// <param name="title"></param>
        /// <param name="until">
        /// Exclusive upper bound on Task.updated_at. If omitted, or later than create/request time minus INCREMENTAL_EXPORT_UNTIL_LAG_SECONDS, the server uses that time instead. Use the returned value as since on the next incremental create.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LabelStudio.LseExportCreate> CreateAsync(
            int id,
            global::LabelStudio.LseAnnotationFilterOptionsRequest? annotationFilterOptions = default,
            global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? convertedFormats = default,
            object? counters = default,
            global::LabelStudio.UserSimpleRequest? createdBy = default,
            bool? ephemeral = default,
            global::System.DateTime? finishedAt = default,
            string? md5 = default,
            global::LabelStudio.SerializationOptionsRequest? serializationOptions = default,
            global::System.DateTime? since = default,
            global::LabelStudio.ProjectImportStatusEnum? status = default,
            global::LabelStudio.LseTaskFilterOptionsRequest? taskFilterOptions = default,
            string? title = default,
            global::System.DateTime? until = default,
            global::LabelStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}