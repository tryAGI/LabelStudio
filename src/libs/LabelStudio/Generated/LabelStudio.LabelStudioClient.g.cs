
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Label Studio API for data annotation and labeling<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LabelStudioClient : global::LabelStudio.ILabelStudioClient, global::System.IDisposable
    {
        /// <summary>
        /// Label Studio
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:8000";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::LabelStudio.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::LabelStudio.JsonConverters.ActionEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ActionEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ActionsEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ActionsEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.AnnotatedEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.AnnotatedEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.AuthMethodEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.AuthMethodEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.AuthTypeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.AuthTypeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.BudgetResetPeriodEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.BudgetResetPeriodEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.DashboardTypeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.DashboardTypeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.Default165EnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.Default165EnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.EditionEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.EditionEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.FinishedEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.FinishedEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.LastActionEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.LastActionEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ModeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ModeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ModelRunStatusEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ModelRunStatusEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.Options165EnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.Options165EnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProjectGroupRoleEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProjectGroupRoleEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProjectSubsetEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProjectSubsetEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.PromptsStatusEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.PromptsStatusEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProviderEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ProviderEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReasonEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReasonEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewedEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ReviewedEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.Role9e7EnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.Role9e7EnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.SamplingDe5EnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.SamplingDe5EnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ScopeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.ScopeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.SegmentationEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.SegmentationEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkillNameEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkillNameEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkippedEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.SkippedEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.StateEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.StateEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.Status7bfEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.Status7bfEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.StatusC5aEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.StatusC5aEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.TypeEnumJsonConverter(),
                    new global::LabelStudio.JsonConverters.TypeEnumNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiActivityLogsListMethodJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiActivityLogsListMethodNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiTasksListFieldsJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiTasksListFieldsNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter(),
                    new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter(),
                    new global::LabelStudio.JsonConverters.MaybeExpandedCommentJsonConverter(),
                    new global::LabelStudio.JsonConverters.RoleBasedTaskJsonConverter(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::LabelStudio.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public ActionsClient Actions => new ActionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ActivityLogsClient ActivityLogs => new ActivityLogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationHistoryClient AnnotationHistory => new AnnotationHistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviewsClient AnnotationReviews => new AnnotationReviewsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviews2Client AnnotationReviews2 => new AnnotationReviews2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations => new AnnotationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AwsClient Aws => new AwsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BlueprintsClient Blueprints => new BlueprintsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Blueprints2Client Blueprints2 => new Blueprints2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Comments2Client Comments2 => new Comments2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataExplorerClient DataExplorer => new DataExplorerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataManagerClient DataManager => new DataManagerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageAzureClient DatasetStorageAzure => new DatasetStorageAzureClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageGcsClient DatasetStorageGcs => new DatasetStorageGcsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageS3Client DatasetStorageS3 => new DatasetStorageS3Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DimensionsClient Dimensions => new DimensionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Dimensions2Client Dimensions2 => new Dimensions2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExportClient Export => new ExportClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImportClient Import => new ImportClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JwtSettingsClient JwtSettings => new JwtSettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels => new LabelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Labels2Client Labels2 => new Labels2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm => new LlmClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MlClient Ml => new MlClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelProviderConnectionClient ModelProviderConnection => new ModelProviderConnectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelProvidersClient ModelProviders => new ModelProvidersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Organizations2Client Organizations2 => new Organizations2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PausesClient Pauses => new PausesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Predictions2Client Predictions2 => new Predictions2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectRolesClient ProjectRoles => new ProjectRolesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectTemplatesClient ProjectTemplates => new ProjectTemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Projects2Client Projects2 => new Projects2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompts2Client Prompts2 => new Prompts2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionPolicyClient SessionPolicy => new SessionPolicyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SsoClient Sso => new SsoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatesClient States => new StatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats => new StatsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageClient Storage => new StorageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureClient StorageAzure => new StorageAzureClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureSpiClient StorageAzureSpi => new StorageAzureSpiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageDatabricksFilesClient StorageDatabricksFiles => new StorageDatabricksFilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsClient StorageGcs => new StorageGcsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsWifClient StorageGcsWif => new StorageGcsWifClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageLocalClient StorageLocal => new StorageLocalClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageRedisClient StorageRedis => new StorageRedisClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageS3Client StorageS3 => new StorageS3Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageS3RolesClient StorageS3Roles => new StorageS3RolesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks => new TasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Tasks2Client Tasks2 => new Tasks2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens => new TokensClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VersionsClient Versions => new VersionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views => new ViewsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Webhooks2Client Webhooks2 => new Webhooks2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Workspaces2Client Workspaces2 => new Workspaces2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the LabelStudioClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LabelStudioClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LabelStudio.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::LabelStudio.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}