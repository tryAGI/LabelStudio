
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AWSCustomFunctionUpdateRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ActionsEnum? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ActivityLog? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ActivityLogResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActivityLog>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementMethodologyEnum? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementSelectionGroupRequest? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementSelectionRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementV2BackfillCancelResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementV2BackfillJob? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FsmBackfillJobStatusEnum? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<int?, string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementV2BackfillTriggerRequestRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AgreementV2BackfillTriggerResponse? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AllRolesProjectList? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotatorEvaluationMetricEnum? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssignmentSettings? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.BlueprintList>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BlueprintList? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeight>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ControlTagWeight? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserSimple? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettings? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSamplingEnum? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SkipQueueEnum? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnalyticsView? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DashboardTypeEnum? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnalyticsViewRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Annotation? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationHistoryActionEnum? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationBulkDeleteRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationBulkSerializerWithSelectedItemsRequest? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationBulkSerializerWithSelectedItemsRequestSelectedItemsAllFalse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationBulkSerializerWithSelectedItemsRequestSelectedItemsAllTrue? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationHistory? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationRequest? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationReview? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RejectActionEnum? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AnnotationReviewRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssignableOrganizationRoleEnum? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssignableUserTypeEnum? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelStreamTaskDistributionEnum? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssignmentSettingsRequest? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssignmentTypeEnum? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AssociatedProject? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AuthMethodEnum? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AuthTypeEnum? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorage? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StorageStatusEnum? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorageValidateRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorageWriteRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorage? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorageValidateRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorageWriteRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureDatasetStorage? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureDatasetStorageRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalExportStorage? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalExportStorageRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalImportStorage? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalImportStorageRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchFailedPredictions? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchFailedPredictionsRequestRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchPredictions? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchPredictionsRequestRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingChecks? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CountLimit? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FlexChecks? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PromptsStatusEnum? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingFlags? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingInfoResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Blueprint? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BlueprintRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BudgetResetPeriodEnum? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorRun? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorsResponse? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.BulkIndicatorRun>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkOrganizationMemberTagAssignmentRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkProjectLearningAssignmentRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkResetCourseProgressRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CancelModelRunResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Certificate? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatCompletionRequestRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChatMessageRequest>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRoleEnum? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CheckMatchingFunctionRequestRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilter? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilterRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CollectionModeEnum? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Comment? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentSerializerWithExpandedUser? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUser? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConfigurablePermissionOption? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssignableOrganizationRoleEnum>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConjunctionEnum? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ControlTagWeightRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormat? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImportStatusEnum? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormatRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSession? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionHeartbeatRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionResponse? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseModule? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutline? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlineModule? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlinePage? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CoursePageSaveResponse? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseProgressImportResult? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OpEnum? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseModule>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CreateProjectFromTemplateRequestRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CustomFunctionCodeRequestRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataManagerFilterModeEnum? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementConfusionMatrix? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityConfusionPair? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDimensions? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDistribution? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorage? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageValidateRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageWriteRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorage? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageValidateRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageWriteRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dataset? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumn? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnVisibilityDefaults? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnsResponse? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetColumn>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesCreateRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesResponse? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMember? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMemberRequest? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserSimpleRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageAvailableDataType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnsResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageAvailableDataType>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageColumnType>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetTasksMetadataResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetView? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroup? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewLockedBy? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroupRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultModelVersionNameResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultRole? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleEnum? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dimension? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionCreateRequest? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionList? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DuplicateLearningResourceRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EditionEnum? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EstimatedDurationUnitEnum? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Export? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormat>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ExportConvertRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteRequestRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateModel? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExample? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExampleRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FileUpload? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Filter? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilter>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Filter>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FilterRequest>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilterRequest>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FlexActiveBlock? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FlexActiveBlock>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCPCustomFunctionUpdateRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorage? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorageRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorage? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageValidateRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageWriteRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorage? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageValidateRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageWriteRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorage? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorageRequest? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorage? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorageRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorage? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorageRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorage? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorageRequest? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Hotkeys? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ImportApiRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationRequest>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.InferenceRunCostEstimate? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIDetailResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectSegment? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserSegment? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMatrixSegment? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectMatrixSegment? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SegmentationEnum? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPITimeSegment? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIValue? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserInfo? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMetadata? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectInfo? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIProjectInfo>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OneOf<double?, string>?>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, string>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenBlacklistRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenRotateRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenCreate? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenList? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettings? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettingsRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEKeyIndicatorValue? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Label? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreate? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreateRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionCountsRow>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsRow? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsTotals? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureDimension? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLink? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLinkRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressUpdateRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResource? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceAssignmentSummary? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgress? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsItem? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceCountsItem>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreate? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreateRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceDetail? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceList? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUpdate? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUploadResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorage? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageValidateRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageWriteRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorage? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageValidateRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageWriteRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptions? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptionsRequest? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreate? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptions? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptions? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreateRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionsRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptionsRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFields? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OnboardingStateEnum? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TrialRoleEnum? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFieldsRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterface? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionsRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceList? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionDescriptionRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionIdRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganization? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationBilling? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberList? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListContributedToProject>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListContributedToProject? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListCreatedProject>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListCreatedProject? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleSourceEnum? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SimpleOrganizationMemberTag? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberList? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProject? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCounts? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreate? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreateRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParams? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParamsRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectStateResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorage? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorageRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorage? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorageRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTask? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskDraft>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskDraft? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskPrediction>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskPrediction? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotators? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsDraft? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewers? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersDraft>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersDraft? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersPrediction>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersPrediction? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMembership>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembership? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserAPI? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListContributedToProject? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListCreatedProject? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserRequest? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackend? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateEnum? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequest? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequestRequest? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendTrainRequestRequest? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLInteractiveAnnotatingRequestRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MappingStatusEnum? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MaybeExpandedComment? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParam? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParamUpdateRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterface? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SkillNameEnum? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceRequest? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceSerializerGET? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssociatedProject>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnection? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProviderEnum? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScopeEnum? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnectionRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRun? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetEnum? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunStatusEnum? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunRequestRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OperatorEnum? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationId? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationInvite? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMember? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberContributedToProject>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberContributedToProject? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberCreatedProject>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberCreatedProject? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterRequestRequest? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterSchema? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOption? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOptionKindEnum? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOption? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberSkillsOption? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTag? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagBulkCreateRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportCreateRequest? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatus? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembershipRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermission? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermissionRoleEnum>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRoleEnum? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleEnum>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRequest? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleAssignment? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAllRolesProjectListList? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AllRolesProjectList>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAnnotationHistoryList? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationHistory>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCertificateList? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Certificate>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCourseModuleList? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelCreateList? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreate>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelLinkList? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelLink>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelList? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Label>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLearningResourceListList? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceList>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseInterfaceListList? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceList>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseOrganizationMemberListList? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberList>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseProjectCountsList? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseProjectCounts>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseUserList? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUser>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedModelInterfaceSerializerGETList? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelInterfaceSerializerGET>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedOrganizationMemberTagList? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberTag>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedPaginatedProjectMemberList? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PaginatedProjectMember>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectMember? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectSubsetTasksResponseList? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTasksResponse>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTasksResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedRoleBasedTaskList? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RoleBasedTask>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleBasedTask? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedSeatReportList? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SeatReport>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SeatReport? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedStateModelList? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateModel>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedUserLearningProgressListList? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserLearningProgressList>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgressList? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnalyticsViewRequest? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationRequest? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationReviewRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobExportStorageWriteRequest? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobImportStorageWriteRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureDatasetStorageRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalExportStorageRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalImportStorageRequest? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedBlueprintUpdateRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCommentRequest? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCoursePageUpdateRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksExportStorageWriteRequest? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksImportStorageWriteRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetImportCandidatesPatchRequest? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetRequest? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetViewRequest? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDefaultRoleRequest? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDimensionRequest? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFewShotExampleRequest? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFileUploadRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSDatasetStorageRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSExportStorageWriteRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSImportStorageWriteRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAExportStorageRequest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAImportStorageRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFExportStorageRequest? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFImportStorageRequest? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedHotkeysRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelLinkRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceUpdateRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesExportStorageWriteRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesImportStorageWriteRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseInterfaceRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseOrganizationSerializerUpdateRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseProjectUpdateRequest? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ExportStorageRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ImportStorageRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseTaskRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseUserSerializerUpdateRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedMLBackendRequestRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelInterfaceRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelProviderConnectionRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberCreateUpdateRequest? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StandardUserTypeEnum? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberTagRequest? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationPermissionRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPauseRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReasonEnum? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPredictionRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectLearningAssignmentRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectTemplateRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisExportStorageWriteRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisImportStorageWriteRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3DatasetStorageRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ExportStorageWriteRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ImportStorageWriteRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedSessionTimeoutPolicyRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedTaskAssigneesMutationRequest? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedThirdPartyModelVersionRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedViewRequestRequest? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewDataRequestRequest? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWebhookSerializerForUpdateRequest? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActionsEnum>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWorkspaceRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Pause? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PauseRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Prediction? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionCountResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItem>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItem? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemFilter? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemOperator? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsOrderingRequestItem? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequest? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Project? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseItem? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseResponse? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectAnnotationsBrowseItem>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateModeEnum? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroup? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRoleEnum? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImport? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfig? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfigRequest? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignment? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignmentCreateRequest? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMember? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRolesRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberIdentityVerificationError? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberRequest? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectReimport? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRole? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleAssignment? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleRequest? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetItem? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTaskItem? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTaskItem>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplate? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplateRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PromptPreviewResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PublishLearningResourceRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeScopeEnum? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluate? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateModeEnum? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorage? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageValidateRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageWriteRequest? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorage? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageValidateRequest? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageWriteRequest? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinePromptRequestRequest? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinedPromptResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersion? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionSummary? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionsResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RequeueRejectedTasksModeEnum? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeReasonEnum? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewCriteriaEnum? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRule? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRuleRequestRequest? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRulesReplaceRequest? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RejectActionEnum>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsSamplingEnum? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeCertificateRequest? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeInviteRequest? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorage? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorageRequest? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorage? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageValidateRequest? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageWriteRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorage? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageValidateRequest? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageWriteRequest? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettings? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdate? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdateRequest? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroupRequest>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettings? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdate? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdateRequest? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceAccessAssignment? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SendInviteRequest? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOption? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionRequest? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SessionTimeoutPolicy? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillCancelResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillErrorResponse? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItem? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItemResponse? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillProgress? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateTriggeredBy? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobListResponse? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItemResponse>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillOrgStatus? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillResponse? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItem>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillStatusResponse? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TriggeredBy2? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAgreementMatrixResponse? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssigneesMutationRequest? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssignment? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEvent? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEventRequest? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskSimple? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Annotation>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Prediction>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersionRequest? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenDetailError? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshResponse? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRotateResponse? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskRequestRequest? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskResponse? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainRequestRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainResponse? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlRequestRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValueCountsBackfillJob? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.VersionResponse? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.View? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewLockedBy? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewOrderRequest? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewRequestRequest? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Webhook? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookRequest? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdate? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdateRequest? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmILseFields? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmIUser? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Workspace? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberBulkAssignRequest? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreate? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreateRequest? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberList? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceProjectsRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressImportCreateRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ImportApiRequest>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiActivityLogsListMethod? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnalyticsKpisRetrieveSegmentByTime? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsCreateId? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsIdpAssignmentsHistoryListKind? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListSource? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListUserType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsSettingsHistoryListKind? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesDestroyType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsVersionsInferenceRunsListProjectSubset? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiTasksListFields? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActivityLogResponse>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnalyticsView>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationHistoryDestroyResponse? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationReview>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkCreateResponseItem? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MaybeExpandedComment>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserResetTokenCreateResponse? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserTokenRetrieveResponse? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureDatasetStorage>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSDatasetStorage>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Dataset>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetView>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetMember>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AgreementV2BackfillJob>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ValueCountsBackfillJob>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItem? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.View>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressBulkResetCreateResponse? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MLBackend>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiMlVersionsRetrieveResponse? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelProviderConnection>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiModelProviderConnectionsProviderChoicesRetrieveResponse? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsAssignmentsCreateResponse? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkDestroyResponse? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsImportsCreateResponse? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberSkillsOption>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermission>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConfigurablePermissionOption>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectTemplate>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRole>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityAgreementDimensions>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponse? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDashboardRetrieveResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDuplicateCreateResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Export>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsExportsConvertCreateResponse? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FileUpload>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportCreateResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportPredictionsCreateResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsMembersBulkDestroyResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementRetrieveResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsPredictionRetrieveResponse? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRule>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsIaaRetrieveResponse? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementGroundtruthRetrieveResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorRetrieveResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponse? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsFinishedRetrieveResponse? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskSimple>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateResponse? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskAssignment>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionListResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreListResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionRetrieveResponse? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieveResponse? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DimensionList>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Pause>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetItem>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ThirdPartyModelVersion>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelRun>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobImportStorage>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalImportStorage>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksImportStorage>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobExportStorage>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalExportStorage>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksExportStorage>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSExportStorage>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAExportStorage>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFExportStorage>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesExportStorage>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisExportStorage>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ExportStorage>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ExportStorage>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSImportStorage>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAImportStorage>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFImportStorage>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesImportStorage>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisImportStorage>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ImportStorage>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ImportStorage>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesTypesRetrieveResponseItem? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LSEAPITokenList>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserAPI>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Webhook>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponse? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Workspace>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceMemberList>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkCreateResponse? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Project>? Type831 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ActivityLog>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.BlueprintList>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.BulkIndicatorRun>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ChatMessageRequest>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AssignableOrganizationRoleEnum>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.CourseEditingSession>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.CourseOutlineModule>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.CourseOutlinePage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.CourseModule>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DataQualityConfusionPair>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetColumn>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetStorageAvailableDataType>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetStorageColumnType>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ConvertedFormat>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ChildFilter>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Filter>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FilterRequest>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ChildFilterRequest>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FlexActiveBlock>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationRequest>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PredictionRequest>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIUserInfo>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIProjectInfo>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OneOf<double?, string>?>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionCountsRow>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionStructureDimension>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LearningResourceCountsItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ConvertedFormatRequest>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceAppendVersionRequest>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListContributedToProject>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListCreatedProject>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.SimpleOrganizationMemberTag>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskDraft>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskPrediction>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersDraft>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersPrediction>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMembership>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AssociatedProject>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberContributedToProject>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberCreatedProject>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipProjectOption>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermissionRoleEnum>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleEnum>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AllRolesProjectList>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationHistory>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Certificate>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelCreate>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelLink>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Label>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LearningResourceList>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceList>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberList>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseProjectCounts>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUser>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelInterfaceSerializerGET>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberTag>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PaginatedProjectMember>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTasksResponse>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RoleBasedTask>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.SeatReport>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateModel>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.UserLearningProgressList>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ActionsEnum>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsOrderingRequestItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectAnnotationsBrowseItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTaskItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRuleRequestRequest>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RejectActionEnum>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectGroup>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectGroupRequest>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleAssignment>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectRoleAssignment>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.WorkspaceAccessAssignment>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItemResponse>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItem>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Annotation>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Prediction>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelCreateRequest>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ImportApiRequest>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ActivityLogResponse>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIMetadata>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnalyticsView>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationReview>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.MaybeExpandedComment>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureDatasetStorage>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSDatasetStorage>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3DatasetStorage>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Dataset>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetView>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetMember>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AgreementV2BackfillJob>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ValueCountsBackfillJob>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsRetrieveResponseItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.List<string>>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.View>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.MLBackend>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelProviderConnection>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationId>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipOption>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberSkillsOption>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermission>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ConfigurablePermissionOption>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectTemplate>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectRole>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DataQualityAgreementDimensions>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.UserSimple>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Export>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FileUpload>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRule>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.TaskSimple>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.TaskAssignment>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DimensionList>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectLearningAssignment>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Pause>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetItem>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ThirdPartyModelVersion>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FewShotExample>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelRun>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureBlobImportStorage>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalImportStorage>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatabricksImportStorage>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureBlobExportStorage>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalExportStorage>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatabricksExportStorage>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSExportStorage>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSSAExportStorage>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSWIFExportStorage>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LocalFilesExportStorage>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RedisExportStorage>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3ExportStorage>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseS3ExportStorage>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSImportStorage>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSSAImportStorage>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSWIFImportStorage>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LocalFilesImportStorage>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RedisImportStorage>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3ImportStorage>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseS3ImportStorage>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LSEAPITokenList>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserAPI>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Webhook>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Workspace>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.WorkspaceMemberList>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Project>? ListType165 { get; set; }
    }
}