
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
            typeof(global::LabelStudio.JsonConverters.ActionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionsEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionsEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AnnotatedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AnnotatedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthMethodEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthMethodEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthTypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthTypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.BudgetResetPeriodEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.BudgetResetPeriodEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.DashboardTypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.DashboardTypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Default165EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Default165EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.EditionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.EditionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.FinishedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.FinishedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LastActionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LastActionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ModelRunStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ModelRunStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OperatorEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OperatorEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Options165EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Options165EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectGroupRoleEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectGroupRoleEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectSubsetEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectSubsetEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.PromptsStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.PromptsStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProviderEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProviderEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReEvaluateModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReEvaluateModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReasonEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReasonEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Role9e7EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Role9e7EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SamplingDe5EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SamplingDe5EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ScopeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ScopeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SegmentationEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SegmentationEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkillNameEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkillNameEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkippedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkippedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StateEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StateEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Status7bfEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Status7bfEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StatusC5aEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StatusC5aEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiActivityLogsListMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiActivityLogsListMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateIdJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiTasksListFieldsJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiTasksListFieldsNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.MaybeExpandedCommentJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RoleBasedTaskJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue_0a76eaf8251d7fab")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>?), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue_9babc75f04464d9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>?), TypeInfoPropertyName = "ApiProjectsStatsTotalAgreementRetrieveResponseVariant2_34675e999e90b30b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AWSCustomFunctionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ActionEnum), TypeInfoPropertyName = "ActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ActionsEnum), TypeInfoPropertyName = "ActionsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ActivityLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ActivityLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ActivityLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementMethodologyEnum), TypeInfoPropertyName = "AgreementMethodologyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementSelectionGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementSelectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementV2BackfillCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementV2BackfillJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementV2BackfillJobStatusEnum), TypeInfoPropertyName = "AgreementV2BackfillJobStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementV2BackfillTriggerRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementV2BackfillTriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AllRolesProjectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.BlueprintList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BlueprintList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ControlTagWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SamplingDe5Enum), TypeInfoPropertyName = "SamplingDe5Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkipQueueEnum), TypeInfoPropertyName = "SkipQueueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnalyticsView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DashboardTypeEnum), TypeInfoPropertyName = "DashboardTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnalyticsViewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotatedEnum), TypeInfoPropertyName = "AnnotatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LastActionEnum), TypeInfoPropertyName = "LastActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationBulkDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationBulkSerializerWithSelectedItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SelectedItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotationReviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelStreamTaskDistributionEnum), TypeInfoPropertyName = "LabelStreamTaskDistributionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssociatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AuthMethodEnum), TypeInfoPropertyName = "AuthMethodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AuthTypeEnum), TypeInfoPropertyName = "AuthTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureBlobExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StatusC5aEnum), TypeInfoPropertyName = "StatusC5aEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureBlobImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureDatasetStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureDatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureServicePrincipalExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureServicePrincipalExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureServicePrincipalImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AzureServicePrincipalImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BatchFailedPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BatchFailedPredictionsRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BatchPredictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BatchPredictionsRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BillingChecks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CountLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PromptsStatusEnum), TypeInfoPropertyName = "PromptsStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BillingFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BillingInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Blueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BlueprintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BudgetResetPeriodEnum), TypeInfoPropertyName = "BudgetResetPeriodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkOrganizationMemberTagAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CancelModelRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CheckMatchingFunctionRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ChildFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ChildFilterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CommentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CommentSerializerWithExpandedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConfigurablePermissionOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Role9e7Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Role9e7Enum), TypeInfoPropertyName = "Role9e7Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ControlTagWeightRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConvertedFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Status7bfEnum), TypeInfoPropertyName = "Status7bfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConvertedFormatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CustomFunctionCodeRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementConfusionMatrix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityConfusionPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatabricksExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatabricksExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatabricksImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatabricksImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatasetMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatasetMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimpleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatasetView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DatasetViewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FilterGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Default165Enum), TypeInfoPropertyName = "Default165Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DefaultRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Dimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DimensionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DimensionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DimensionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.EditionEnum), TypeInfoPropertyName = "EditionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Export))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ExportConvertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FSMTransitionExecuteRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FSMTransitionExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FewShotExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FewShotExampleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FileUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Filter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Filter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.FilterRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FilterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FinishedEnum), TypeInfoPropertyName = "FinishedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCPCustomFunctionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSDatasetStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSDatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSSAExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSSAExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSSAImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSSAImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSWIFExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSWIFExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSWIFImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.GCSWIFImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Hotkeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ImportApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.InferenceRunCostEstimate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIProjectSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIUserSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIMatrixSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIProjectMatrixSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SegmentationEnum), TypeInfoPropertyName = "SegmentationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPITimeSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.KPIProjectInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.KPIProjectInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSAPITokenBlacklistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSAPITokenRotateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSEAPITokenCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSEAPITokenList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSEJWTSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSEJWTSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LSEKeyIndicatorValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionCountsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsTotals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionStructureDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionStructureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LocalFilesExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LocalFilesImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseAnnotationFilterOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewedEnum), TypeInfoPropertyName = "ReviewedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseAnnotationFilterOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseExportCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SerializationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskFilterOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseExportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SerializationOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskFilterOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OnboardingStateEnum), TypeInfoPropertyName = "OnboardingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TrialRoleEnum), TypeInfoPropertyName = "TrialRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseFieldsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceAppendVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceAppendVersionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceVersionDescriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseInterfaceVersionIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberListContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberListCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SimpleOrganizationMemberTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseS3ExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseS3ExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseS3ImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseS3ImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkippedEnum), TypeInfoPropertyName = "SkippedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotatorsDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewersDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewersPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserAPI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberListContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberListCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MLBackend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateEnum), TypeInfoPropertyName = "StateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MLBackendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MLInteractiveAnnotatingRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MaybeExpandedComment), TypeInfoPropertyName = "MaybeExpandedComment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MetricParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MetricParamUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkillNameEnum), TypeInfoPropertyName = "SkillNameEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelInterfaceSerializerGET))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AssociatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelProviderConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProviderEnum), TypeInfoPropertyName = "ProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ScopeEnum), TypeInfoPropertyName = "ScopeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelProviderConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetEnum), TypeInfoPropertyName = "ProjectSubsetEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelRunStatusEnum), TypeInfoPropertyName = "ModelRunStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ModelRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OperatorEnum), TypeInfoPropertyName = "OperatorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Options165Enum), TypeInfoPropertyName = "Options165Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagBulkCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum), TypeInfoPropertyName = "OrganizationMemberTagImportStatusStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMembershipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Default165Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Options165Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedAllRolesProjectListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AllRolesProjectList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedAnnotationHistoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AnnotationHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLabelCreateList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLabelLinkList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLabelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseInterfaceListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseOrganizationMemberListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseProjectCountsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseProjectCounts>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseUserList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedModelInterfaceSerializerGETList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ModelInterfaceSerializerGET>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedOrganizationMemberTagList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedPaginatedProjectMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PaginatedProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedProjectSubsetTasksResponseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTasksResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedRoleBasedTaskList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RoleBasedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RoleBasedTask), TypeInfoPropertyName = "RoleBasedTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedStateModelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.StateModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedAnalyticsViewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedAnnotationReviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedAzureDatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedAzureServicePrincipalExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedAzureServicePrincipalImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedBlueprintUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedCommentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDatabricksExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDatabricksImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDatasetViewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDefaultRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDimensionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedFewShotExampleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedFileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedGCSDatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedGCSSAExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedGCSSAImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedGCSWIFExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedGCSWIFImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedHotkeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLabelLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseOrganizationSerializerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseS3ExportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseS3ImportStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseUserSerializerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedModelInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedModelProviderConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationMemberCreateUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationMemberTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedPauseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReasonEnum), TypeInfoPropertyName = "ReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedProjectTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedS3DatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedSessionTimeoutPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedThirdPartyModelVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedWebhookSerializerForUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ActionsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Pause))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PauseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectDuplicateModeEnum), TypeInfoPropertyName = "ProjectDuplicateModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectGroupRoleEnum), TypeInfoPropertyName = "ProjectGroupRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLabelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLabelConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberBulkAssignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberBulkAssignRolesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectReimport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSubsetTaskItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReEvaluate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReEvaluateModeEnum), TypeInfoPropertyName = "ReEvaluateModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReEvaluateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RedisExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RedisImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RefinePromptRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RefinedPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ThirdPartyModelVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RequeueRejectedTasksModeEnum), TypeInfoPropertyName = "RequeueRejectedTasksModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewCriteriaEnum), TypeInfoPropertyName = "ReviewCriteriaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewRoutingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewRoutingRuleRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewRoutingRulesReplaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsSamplingEnum), TypeInfoPropertyName = "ReviewSettingsSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RevokeInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.S3DatasetStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.S3DatasetStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.S3ExportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.S3ImportStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SamlSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SamlSettingsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SamlSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroupRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ScimSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ScimSettingsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ScimSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SendInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SerializationOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SerializationOptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SessionTimeoutPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillJobItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillJobItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateTriggeredBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillJobListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillOrgStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StateBackfillStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TriggeredBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskAgreementMatrixResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TypeEnum), TypeInfoPropertyName = "TypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ThirdPartyModelVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TokenRefreshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TokenRefreshResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TokenRotateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ValidateSamlMetadataUrlRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ValidateSamlMetadataUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.VersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.View))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ViewOrderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WebhookSerializerForUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WebhookSerializerForUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WhoAmILseFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WhoAmIUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceMemberBulkAssignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceMemberCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceMemberCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceProjectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiAnnotationsPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestFiltersConjunction), TypeInfoPropertyName = "ApiDmActionsCreateRequestFiltersConjunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsCreateRequestFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestFiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter), TypeInfoPropertyName = "ApiDmActionsCreateRequestFiltersItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestFiltersItemOperator), TypeInfoPropertyName = "ApiDmActionsCreateRequestFiltersItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>), TypeInfoPropertyName = "OneOfStringInt32SingleBooleanObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsCreateRequestOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestOrderingItem), TypeInfoPropertyName = "ApiDmActionsCreateRequestOrderingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue>), TypeInfoPropertyName = "OneOfApiDmActionsCreateRequestSelectedItemsAllFalseApiDmActionsCreateRequestSelectedItemsAllTrue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestData))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LabelStudio.JsonConverters.ActionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionsEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ActionsEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AnnotatedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AnnotatedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthMethodEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthMethodEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthTypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.AuthTypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.BudgetResetPeriodEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.BudgetResetPeriodEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.DashboardTypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.DashboardTypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Default165EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Default165EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.EditionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.EditionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.FinishedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.FinishedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LastActionEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.LastActionEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ModelRunStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ModelRunStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OperatorEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OperatorEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Options165EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Options165EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectGroupRoleEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectGroupRoleEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectSubsetEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProjectSubsetEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.PromptsStatusEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.PromptsStatusEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProviderEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ProviderEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReEvaluateModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReEvaluateModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReasonEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReasonEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ReviewedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Role9e7EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Role9e7EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SamplingDe5EnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SamplingDe5EnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ScopeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ScopeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SegmentationEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SegmentationEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkillNameEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkillNameEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkippedEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.SkippedEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StateEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StateEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Status7bfEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.Status7bfEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StatusC5aEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.StatusC5aEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TypeEnumJsonConverter),

            typeof(global::LabelStudio.JsonConverters.TypeEnumNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiActivityLogsListMethodJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiActivityLogsListMethodNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateIdJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiTasksListFieldsJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiTasksListFieldsNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusJsonConverter),

            typeof(global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusNullableJsonConverter),

            typeof(global::LabelStudio.JsonConverters.MaybeExpandedCommentJsonConverter),

            typeof(global::LabelStudio.JsonConverters.RoleBasedTaskJsonConverter),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::LabelStudio.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue_0a76eaf8251d7fab")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>?), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue_9babc75f04464d9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>?), TypeInfoPropertyName = "ApiProjectsStatsTotalAgreementRetrieveResponseVariant2_34675e999e90b30b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersConjunction), TypeInfoPropertyName = "ApiDmViewsCreateRequestDataFiltersConjunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter), TypeInfoPropertyName = "ApiDmViewsCreateRequestDataFiltersItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemOperator), TypeInfoPropertyName = "ApiDmViewsCreateRequestDataFiltersItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsCreateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsCreateRequestDataOrderingItem), TypeInfoPropertyName = "ApiDmViewsCreateRequestDataOrderingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersConjunction), TypeInfoPropertyName = "ApiDmViewsPartialUpdateRequestDataFiltersConjunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter), TypeInfoPropertyName = "ApiDmViewsPartialUpdateRequestDataFiltersItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator), TypeInfoPropertyName = "ApiDmViewsPartialUpdateRequestDataFiltersItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataOrderingItem), TypeInfoPropertyName = "ApiDmViewsPartialUpdateRequestDataOrderingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction), TypeInfoPropertyName = "ApiDmViewsUpdateRequestDataFiltersConjunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersItemFilter), TypeInfoPropertyName = "ApiDmViewsUpdateRequestDataFiltersItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersItemOperator), TypeInfoPropertyName = "ApiDmViewsUpdateRequestDataFiltersItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmViewsUpdateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmViewsUpdateRequestDataOrderingItem), TypeInfoPropertyName = "ApiDmViewsUpdateRequestDataOrderingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole), TypeInfoPropertyName = "ApiLlmOpenaiChatCompletionsCreateRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlCreateRequestAuthMethod), TypeInfoPropertyName = "ApiMlCreateRequestAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod), TypeInfoPropertyName = "ApiMlPartialUpdateRequestAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlTrainCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiPredictionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiPredictionsPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiPredictionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectTemplatesCreateProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ImportApiRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersConjunction), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestFiltersConjunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilter), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestFiltersItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestType), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType), TypeInfoPropertyName = "ApiProjectsTasksAssigneesPartialUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreate2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreate2RequestType), TypeInfoPropertyName = "ApiProjectsTasksAssigneesCreate2RequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesAzureCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesAzureValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesAzurePartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportAzureCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportAzureValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportAzurePartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportGcsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportGcsValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportGcsPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportLocalfilesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportLocalfilesValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportLocalfilesPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportRedisCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportRedisValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportRedisPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportS3CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportS3ValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportS3PartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesGcsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesGcsValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesGcsPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesLocalfilesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesLocalfilesValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesLocalfilesPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesRedisCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesRedisValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesRedisPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesS3CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesS3ValidateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesS3PartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiTasksAnnotationsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiUsersCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiUsersPartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiActivityLogsListMethod), TypeInfoPropertyName = "ApiActivityLogsListMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateId), TypeInfoPropertyName = "ApiDmActionsCreateId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMembershipsListScope), TypeInfoPropertyName = "ApiOrganizationsMembershipsListScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode), TypeInfoPropertyName = "ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable), TypeInfoPropertyName = "ApiProjectsStatsMemberPerformanceRowsRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable), TypeInfoPropertyName = "ApiProjectsStatsMemberPerformanceSummaryRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType), TypeInfoPropertyName = "ApiProjectsTasksAssigneesDestroyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome), TypeInfoPropertyName = "ApiProjectsSubsetTasksListAlignmentOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType), TypeInfoPropertyName = "ApiPromptsCompatibleProjectsListProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiPromptsVersionsInferenceRunsListProjectSubset), TypeInfoPropertyName = "ApiPromptsVersionsInferenceRunsListProjectSubset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiTasksListFields), TypeInfoPropertyName = "ApiTasksListFields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ActivityLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AnalyticsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiAnnotationHistoryDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AnnotationReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiAnnotationsBulkCreateResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.MaybeExpandedComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiCurrentUserResetTokenCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiCurrentUserTokenRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AzureDatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSDatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DatasetView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DatasetMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AgreementV2BackfillJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsRetrieveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiInferenceRunsIndicatorsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiInferenceRunsIndicatorsRetrieveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.MLBackend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiMlVersionsRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ModelProviderConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiModelProviderConnectionsProviderChoicesRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsAssignmentsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsBulkDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsImportsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ConfigurablePermissionOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DataQualityAgreementDimensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsAwsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsDashboardRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsDuplicateCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Export>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsExportsConvertCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.FileUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus), TypeInfoPropertyName = "ApiProjectsGcpCustomFunctionRetrieveResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsImportCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsImportPredictionsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsMembersBulkDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsMembersBulkCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsAgreementRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsPredictionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsIaaRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>), TypeInfoPropertyName = "OneOfIListIListDoubleDictionaryStringIListIListDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>), TypeInfoPropertyName = "OneOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementAnnotatorRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsFinishedRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>), TypeInfoPropertyName = "OneOfApiProjectsStatsTotalAgreementRetrieveResponseVariant1ApiProjectsStatsTotalAgreementRetrieveResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.TaskSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.TaskAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsPredictionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsPredictionRetrieve2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieve2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DimensionList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Pause>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ThirdPartyModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DatabricksImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DatabricksExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSSAExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RedisExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.S3ExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseS3ExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSSAImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RedisImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.S3ImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseS3ImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiStoragesTypesRetrieveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LSEAPITokenList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUserAPI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiWorkspacesMembershipsBulkCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ActivityLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.BlueprintList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Role9e7Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DataQualityConfusionPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ConvertedFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Filter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.FilterRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PredictionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.KPIUserInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.KPIProjectInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionCountsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionStructureDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ConvertedFormatRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceAppendVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AssociatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Default165Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Options165Enum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AllRolesProjectList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AnnotationHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseProjectCounts>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ModelInterfaceSerializerGET>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PaginatedProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTasksResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RoleBasedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.StateModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ActionsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRuleRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectGroupRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsCreateRequestFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsCreateRequestOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsCreateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmViewsUpdateRequestDataOrderingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiLlmOpenaiChatCompletionsCreateRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ImportApiRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestFiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ActivityLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.KPIMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AnalyticsView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AnnotationReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.MaybeExpandedComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AzureDatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSDatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.S3DatasetStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DatasetView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DatasetMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AgreementV2BackfillJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiInferenceRunsIndicatorsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.MLBackend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ModelProviderConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ConfigurablePermissionOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DataQualityAgreementDimensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Export>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.FileUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.TaskSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.TaskAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DimensionList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Pause>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ThirdPartyModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.FewShotExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AzureBlobImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DatabricksImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AzureBlobExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DatabricksExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSSAExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSWIFExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LocalFilesExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RedisExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.S3ExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseS3ExportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSSAImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.GCSWIFImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LocalFilesImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RedisImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.S3ImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseS3ImportStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LSEAPITokenList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUserAPI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.WorkspaceMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Project>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::LabelStudio.JsonConverters.ActionEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ActionEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ActionsEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ActionsEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AgreementV2BackfillJobStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AnnotatedEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AnnotatedEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AuthMethodEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AuthMethodEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AuthTypeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.AuthTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.BudgetResetPeriodEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.BudgetResetPeriodEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.DashboardTypeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.DashboardTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Default165EnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Default165EnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.EditionEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.EditionEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.FinishedEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.FinishedEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.LastActionEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.LastActionEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ModelRunStatusEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ModelRunStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OperatorEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OperatorEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Options165EnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Options165EnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectDuplicateModeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectGroupRoleEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectGroupRoleEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectSubsetEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProjectSubsetEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.PromptsStatusEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.PromptsStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProviderEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ProviderEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReEvaluateModeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReEvaluateModeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReasonEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReasonEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewedEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ReviewedEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Role9e7EnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Role9e7EnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SamplingDe5EnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SamplingDe5EnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ScopeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ScopeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SegmentationEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SegmentationEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkillNameEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkillNameEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkippedEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.SkippedEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.StateEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.StateEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Status7bfEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.Status7bfEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.StatusC5aEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.StatusC5aEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.TypeEnumJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.TypeEnumNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateRequestOrderingItemNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiMlCreateRequestAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiMlPartialUpdateRequestAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiActivityLogsListMethodJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiActivityLogsListMethodNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiOrganizationsMembershipsListScopeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsSubsetTasksListAlignmentOutcomeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiTasksListFieldsJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiTasksListFieldsNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.MaybeExpandedCommentJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.RoleBasedTaskJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiDmActionsCreateRequestSelectedItemsAllTrue>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllFalse, global::LabelStudio.ApiProjectsTasksAssigneesCreateRequestSelectedItemsAllTrue>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}