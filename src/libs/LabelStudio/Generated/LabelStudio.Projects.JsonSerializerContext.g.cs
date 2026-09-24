
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AWSCustomFunctionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementMethodologyEnum), TypeInfoPropertyName = "AgreementMethodologyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AllRolesProjectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum), TypeInfoPropertyName = "AnnotatorEvaluationMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.BlueprintList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BlueprintList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ControlTagWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AllRolesProjectListDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AllRolesProjectListDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AllRolesProjectListDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSamplingEnum), TypeInfoPropertyName = "ProjectSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkipQueueEnum), TypeInfoPropertyName = "SkipQueueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationHistoryActionEnum), TypeInfoPropertyName = "AnnotationHistoryActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RejectActionEnum), TypeInfoPropertyName = "RejectActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableOrganizationRoleEnum), TypeInfoPropertyName = "AssignableOrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelStreamTaskDistributionEnum), TypeInfoPropertyName = "LabelStreamTaskDistributionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CheckMatchingFunctionRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CollectionModeEnum), TypeInfoPropertyName = "CollectionModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ControlTagWeightRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectImportStatusEnum), TypeInfoPropertyName = "ProjectImportStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CustomFunctionCodeRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimpleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCPCustomFunctionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OnboardingStateEnum), TypeInfoPropertyName = "OnboardingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TrialRoleEnum), TypeInfoPropertyName = "TrialRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SimpleOrganizationMemberTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateRequestDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateRequestDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateRequestDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectResponseDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectResponseDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectResponseDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MetricParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MetricParamUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedAllRolesProjectListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AllRolesProjectList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseProjectCountsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseProjectCounts>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedPaginatedProjectMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PaginatedProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedProjectSubsetTasksResponseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTasksResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseProjectUpdateRequestDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseProjectUpdateRequestDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseProjectUpdateRequestDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectDuplicateModeEnum), TypeInfoPropertyName = "ProjectDuplicateModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLabelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLabelConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberBulkAssignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberBulkAssignRolesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberBulkAssignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberIdentityVerificationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectReimport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetTaskItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RequeueRejectedTasksModeEnum), TypeInfoPropertyName = "RequeueRejectedTasksModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewCriteriaEnum), TypeInfoPropertyName = "ReviewCriteriaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RejectActionEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsSamplingEnum), TypeInfoPropertyName = "ReviewSettingsSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome), TypeInfoPropertyName = "ApiProjectsSubsetTasksListAlignmentOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsAwsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsDuplicateCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsGcpCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsMembersBulkDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.TaskSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementMethodologyEnum?), TypeInfoPropertyName = "NullableAgreementMethodologyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?), TypeInfoPropertyName = "NullableAnnotatorEvaluationMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSamplingEnum?), TypeInfoPropertyName = "NullableProjectSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkipQueueEnum?), TypeInfoPropertyName = "NullableSkipQueueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationHistoryActionEnum?), TypeInfoPropertyName = "NullableAnnotationHistoryActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RejectActionEnum?), TypeInfoPropertyName = "NullableRejectActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableOrganizationRoleEnum?), TypeInfoPropertyName = "NullableAssignableOrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?), TypeInfoPropertyName = "NullableLabelStreamTaskDistributionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CollectionModeEnum?), TypeInfoPropertyName = "NullableCollectionModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectImportStatusEnum?), TypeInfoPropertyName = "NullableProjectImportStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OnboardingStateEnum?), TypeInfoPropertyName = "NullableOnboardingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TrialRoleEnum?), TypeInfoPropertyName = "NullableTrialRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectDuplicateModeEnum?), TypeInfoPropertyName = "NullableProjectDuplicateModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?), TypeInfoPropertyName = "NullableRequeueRejectedTasksModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewCriteriaEnum?), TypeInfoPropertyName = "NullableReviewCriteriaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsSamplingEnum?), TypeInfoPropertyName = "NullableReviewSettingsSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome?), TypeInfoPropertyName = "NullableApiProjectsSubsetTasksListAlignmentOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus?), TypeInfoPropertyName = "NullableApiProjectsAwsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus?), TypeInfoPropertyName = "NullableApiProjectsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus?), TypeInfoPropertyName = "NullableApiProjectsGcpCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.BlueprintList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AllRolesProjectList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseProjectCounts>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PaginatedProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTasksResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RejectActionEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.TaskSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetItem>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum)

                    || typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum?)

                    || typeToConvert == typeof(global::LabelStudio.AnnotationHistoryActionEnum)

                    || typeToConvert == typeof(global::LabelStudio.AnnotationHistoryActionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum)

                    || typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?)

                    || typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum?)

                    || typeToConvert == typeof(global::LabelStudio.CollectionModeEnum)

                    || typeToConvert == typeof(global::LabelStudio.CollectionModeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum)

                    || typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum)

                    || typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ProjectDuplicateModeEnum)

                    || typeToConvert == typeof(global::LabelStudio.ProjectDuplicateModeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ProjectImportStatusEnum)

                    || typeToConvert == typeof(global::LabelStudio.ProjectImportStatusEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum)

                    || typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RejectActionEnum)

                    || typeToConvert == typeof(global::LabelStudio.RejectActionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum)

                    || typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum)

                    || typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum)

                    || typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum?)

                    || typeToConvert == typeof(global::LabelStudio.SkipQueueEnum)

                    || typeToConvert == typeof(global::LabelStudio.SkipQueueEnum?)

                    || typeToConvert == typeof(global::LabelStudio.TrialRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.TrialRoleEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum))
                {
                    return new global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotationHistoryActionEnum))
                {
                    return new global::LabelStudio.JsonConverters.AnnotationHistoryActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotationHistoryActionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AnnotationHistoryActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum))
                {
                    return new global::LabelStudio.JsonConverters.AnnotatorEvaluationMetricEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AnnotatorEvaluationMetricEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.CollectionModeEnum))
                {
                    return new global::LabelStudio.JsonConverters.CollectionModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.CollectionModeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.CollectionModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum))
                {
                    return new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum))
                {
                    return new global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectDuplicateModeEnum))
                {
                    return new global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectDuplicateModeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectImportStatusEnum))
                {
                    return new global::LabelStudio.JsonConverters.ProjectImportStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectImportStatusEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ProjectImportStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum))
                {
                    return new global::LabelStudio.JsonConverters.ProjectSamplingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ProjectSamplingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RejectActionEnum))
                {
                    return new global::LabelStudio.JsonConverters.RejectActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RejectActionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RejectActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum))
                {
                    return new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum))
                {
                    return new global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum))
                {
                    return new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.SkipQueueEnum))
                {
                    return new global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.SkipQueueEnum?))
                {
                    return new global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.TrialRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.TrialRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}