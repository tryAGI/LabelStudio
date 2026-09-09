
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
        public global::LabelStudio.PromptsStatusEnum? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingFlags? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingInfoResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Blueprint? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BlueprintRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BudgetResetPeriodEnum? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorRun? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorsResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.BulkIndicatorRun>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkOrganizationMemberTagAssignmentRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkProjectLearningAssignmentRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkResetCourseProgressRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CancelModelRunResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Certificate? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatCompletionRequestRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChatMessageRequest>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRoleEnum? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CheckMatchingFunctionRequestRequest? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilter? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilterRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CollectionModeEnum? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Comment? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentSerializerWithExpandedUser? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUser? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConfigurablePermissionOption? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssignableOrganizationRoleEnum>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConjunctionEnum? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ControlTagWeightRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormat? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImportStatusEnum? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormatRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSession? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionHeartbeatRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseModule? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutline? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlineModule? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlinePage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CoursePageSaveResponse? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseProgressImportResult? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OpEnum? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseModule>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CreateProjectFromTemplateRequestRequest? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CustomFunctionCodeRequestRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataManagerFilterModeEnum? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementConfusionMatrix? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityConfusionPair? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDimensions? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDistribution? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorage? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageValidateRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageWriteRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorage? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageValidateRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageWriteRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dataset? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumn? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnVisibilityDefaults? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnsResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetColumn>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesCreateRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesResponse? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMember? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMemberRequest? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetRequest? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserSimpleRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageAvailableDataType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnsResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageAvailableDataType>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageColumnType>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetTasksMetadataResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetView? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroup? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewLockedBy? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroupRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultModelVersionNameResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultRole? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleEnum? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dimension? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionCreateRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionList? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DuplicateLearningResourceRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EditionEnum? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EstimatedDurationUnitEnum? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Export? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormat>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ExportConvertRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteRequestRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateModel? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExample? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExampleRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FileUpload? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Filter? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilter>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Filter>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FilterRequest>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilterRequest>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCPCustomFunctionUpdateRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorage? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorageRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorage? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageValidateRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageWriteRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorage? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageValidateRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageWriteRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorage? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorageRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorage? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorageRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorage? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorageRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorage? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorageRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Hotkeys? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ImportApiRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationRequest>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.InferenceRunCostEstimate? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIDetailResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectSegment? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserSegment? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMatrixSegment? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectMatrixSegment? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SegmentationEnum? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPITimeSegment? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIValue? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserInfo? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMetadata? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectInfo? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIProjectInfo>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OneOf<double?, string>?>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, string>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenBlacklistRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenRotateRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenCreate? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenList? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettings? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettingsRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEKeyIndicatorValue? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Label? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreate? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreateRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionCountsRow>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsRow? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsTotals? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureDimension? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLink? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLinkRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressUpdateRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResource? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceAssignmentSummary? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgress? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsItem? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceCountsItem>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreate? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreateRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceDetail? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceList? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUpdate? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUploadResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorage? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageValidateRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageWriteRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorage? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageValidateRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageWriteRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptions? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptionsRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreate? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptions? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptions? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreateRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionsRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptionsRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFields? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OnboardingStateEnum? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TrialRoleEnum? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFieldsRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterface? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionsRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceList? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionDescriptionRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionIdRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganization? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationBilling? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberList? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListContributedToProject>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListContributedToProject? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListCreatedProject>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListCreatedProject? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleSourceEnum? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SimpleOrganizationMemberTag? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberList? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProject? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCounts? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreate? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreateRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParams? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParamsRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectStateResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorage? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorageRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorage? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorageRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTask? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskDraft>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskDraft? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskPrediction>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskPrediction? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotators? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsDraft? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewers? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersDraft>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersDraft? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersPrediction>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersPrediction? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMembership>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembership? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserAPI? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListContributedToProject? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListCreatedProject? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackend? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateEnum? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequest? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequestRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendTrainRequestRequest? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLInteractiveAnnotatingRequestRequest? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MappingStatusEnum? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MaybeExpandedComment? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParam? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParamUpdateRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterface? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SkillNameEnum? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceSerializerGET? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssociatedProject>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnection? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProviderEnum? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScopeEnum? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnectionRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRun? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetEnum? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunStatusEnum? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunRequestRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OperatorEnum? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationId? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationInvite? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMember? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberContributedToProject>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberContributedToProject? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberCreatedProject>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberCreatedProject? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterRequestRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterSchema? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOption? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOptionKindEnum? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOption? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberSkillsOption? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTag? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagBulkCreateRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportCreateRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatus? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembershipRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermission? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermissionRoleEnum>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRoleEnum? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleEnum>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRequest? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleAssignment? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAllRolesProjectListList? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AllRolesProjectList>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAnnotationHistoryList? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationHistory>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCertificateList? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Certificate>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCourseModuleList? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelCreateList? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreate>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelLinkList? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelLink>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelList? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Label>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLearningResourceListList? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceList>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseInterfaceListList? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceList>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseOrganizationMemberListList? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberList>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseProjectCountsList? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseProjectCounts>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseUserList? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUser>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedModelInterfaceSerializerGETList? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelInterfaceSerializerGET>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedOrganizationMemberTagList? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberTag>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedPaginatedProjectMemberList? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PaginatedProjectMember>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectMember? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectSubsetTasksResponseList? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTasksResponse>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTasksResponse? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedRoleBasedTaskList? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RoleBasedTask>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleBasedTask? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedSeatReportList? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SeatReport>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SeatReport? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedStateModelList? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateModel>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedUserLearningProgressListList? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserLearningProgressList>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgressList? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnalyticsViewRequest? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationRequest? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationReviewRequest? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobExportStorageWriteRequest? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobImportStorageWriteRequest? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureDatasetStorageRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalExportStorageRequest? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalImportStorageRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedBlueprintUpdateRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCommentRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCoursePageUpdateRequest? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksExportStorageWriteRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksImportStorageWriteRequest? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetImportCandidatesPatchRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetRequest? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetViewRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDefaultRoleRequest? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDimensionRequest? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFewShotExampleRequest? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFileUploadRequest? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSDatasetStorageRequest? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSExportStorageWriteRequest? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSImportStorageWriteRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAExportStorageRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAImportStorageRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFExportStorageRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFImportStorageRequest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedHotkeysRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelLinkRequest? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelRequest? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceUpdateRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesExportStorageWriteRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesImportStorageWriteRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseInterfaceRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseOrganizationSerializerUpdateRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseProjectUpdateRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ExportStorageRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ImportStorageRequest? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseTaskRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseUserSerializerUpdateRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedMLBackendRequestRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelInterfaceRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelProviderConnectionRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberCreateUpdateRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StandardUserTypeEnum? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberTagRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationPermissionRequest? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPauseRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReasonEnum? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPredictionRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectLearningAssignmentRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectTemplateRequest? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisExportStorageWriteRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisImportStorageWriteRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3DatasetStorageRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ExportStorageWriteRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ImportStorageWriteRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedSessionTimeoutPolicyRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedTaskAssigneesMutationRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedThirdPartyModelVersionRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedViewRequestRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewDataRequestRequest? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWebhookSerializerForUpdateRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActionsEnum>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWorkspaceRequest? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Pause? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PauseRequest? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Prediction? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionCountResponse? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItem>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItem? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemFilter? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemOperator? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsOrderingRequestItem? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Project? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseItem? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectAnnotationsBrowseItem>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateModeEnum? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateRequest? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroup? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRoleEnum? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRequest? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImport? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfig? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfigRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignment? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignmentCreateRequest? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMember? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRequest? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRolesRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberIdentityVerificationError? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectReimport? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRole? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleAssignment? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleRequest? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetItem? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTaskItem? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTaskItem>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplate? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplateRequest? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PromptPreviewResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PublishLearningResourceRequest? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeScopeEnum? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluate? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateModeEnum? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateRequest? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorage? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageValidateRequest? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageWriteRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorage? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageValidateRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageWriteRequest? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinePromptRequestRequest? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinedPromptResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersion? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionSummary? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionsResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RequeueRejectedTasksModeEnum? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeReasonEnum? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewCriteriaEnum? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRule? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRuleRequestRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRulesReplaceRequest? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RejectActionEnum>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsSamplingEnum? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeCertificateRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeInviteRequest? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorage? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorageRequest? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorage? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageValidateRequest? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageWriteRequest? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorage? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageValidateRequest? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageWriteRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettings? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdate? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdateRequest? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroupRequest>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettings? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdateRequest? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceAccessAssignment? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SendInviteRequest? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOption? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionRequest? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SessionTimeoutPolicy? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillCancelResponse? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillErrorResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItem? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItemResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillProgress? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateTriggeredBy? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobListResponse? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItemResponse>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillOrgStatus? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillResponse? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItem>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillStatusResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TriggeredBy2? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAgreementMatrixResponse? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssigneesMutationRequest? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssignment? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEvent? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEventRequest? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskSimple? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Annotation>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Prediction>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersionRequest? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenDetailError? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshRequest? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshResponse? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRotateResponse? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskRequestRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskResponse? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainRequestRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainResponse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlRequestRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlResponse? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValueCountsBackfillJob? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.VersionResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.View? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewLockedBy? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewOrderRequest? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewRequestRequest? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Webhook? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookRequest? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdate? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdateRequest? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmILseFields? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmIUser? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Workspace? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberBulkAssignRequest? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreate? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreateRequest? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberList? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceProjectsRequest? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceRequest? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressImportCreateRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ImportApiRequest>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiActivityLogsListMethod? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnalyticsKpisRetrieveSegmentByTime? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsCreateId? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsIdpAssignmentsHistoryListKind? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListSource? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListUserType? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsSettingsHistoryListKind? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesDestroyType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsVersionsInferenceRunsListProjectSubset? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiTasksListFields? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActivityLogResponse>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnalyticsView>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationHistoryDestroyResponse? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationReview>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkCreateResponseItem? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MaybeExpandedComment>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserResetTokenCreateResponse? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserTokenRetrieveResponse? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureDatasetStorage>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSDatasetStorage>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Dataset>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetView>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetMember>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AgreementV2BackfillJob>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ValueCountsBackfillJob>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItem? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.View>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressBulkResetCreateResponse? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MLBackend>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiMlVersionsRetrieveResponse? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelProviderConnection>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiModelProviderConnectionsProviderChoicesRetrieveResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsAssignmentsCreateResponse? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkDestroyResponse? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsImportsCreateResponse? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberSkillsOption>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermission>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConfigurablePermissionOption>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectTemplate>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRole>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityAgreementDimensions>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponse? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDashboardRetrieveResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDuplicateCreateResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Export>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsExportsConvertCreateResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FileUpload>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportCreateResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportPredictionsCreateResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsMembersBulkDestroyResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementRetrieveResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsPredictionRetrieveResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRule>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsIaaRetrieveResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementGroundtruthRetrieveResponse? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorRetrieveResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsFinishedRetrieveResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponse? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskSimple>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskAssignment>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionListResponse? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreListResponse? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionRetrieveResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieveResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DimensionList>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Pause>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetItem>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ThirdPartyModelVersion>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelRun>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobImportStorage>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalImportStorage>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksImportStorage>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobExportStorage>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalExportStorage>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksExportStorage>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSExportStorage>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAExportStorage>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFExportStorage>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesExportStorage>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisExportStorage>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ExportStorage>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ExportStorage>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSImportStorage>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAImportStorage>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFImportStorage>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesImportStorage>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisImportStorage>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ImportStorage>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ImportStorage>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesTypesRetrieveResponseItem? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LSEAPITokenList>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserAPI>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Webhook>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponse? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Workspace>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceMemberList>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkCreateResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Project>? Type828 { get; set; }

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
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationRequest>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PredictionRequest>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.DateTime>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIUserInfo>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIProjectInfo>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OneOf<double?, string>?>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionCountsRow>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionStructureDimension>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LearningResourceCountsItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ConvertedFormatRequest>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceAppendVersionRequest>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListContributedToProject>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListCreatedProject>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.SimpleOrganizationMemberTag>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskDraft>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskPrediction>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersDraft>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersPrediction>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMembership>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AssociatedProject>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberContributedToProject>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberCreatedProject>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipProjectOption>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermissionRoleEnum>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleEnum>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AllRolesProjectList>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationHistory>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Certificate>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelCreate>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelLink>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Label>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LearningResourceList>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseInterfaceList>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberList>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseProjectCounts>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUser>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelInterfaceSerializerGET>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberTag>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PaginatedProjectMember>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTasksResponse>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RoleBasedTask>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.SeatReport>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateModel>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.UserLearningProgressList>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ActionsEnum>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsOrderingRequestItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectAnnotationsBrowseItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetTaskItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRuleRequestRequest>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RejectActionEnum>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectGroup>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectGroupRequest>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleAssignment>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectRoleAssignment>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.WorkspaceAccessAssignment>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItemResponse>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.StateBackfillJobItem>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Annotation>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Prediction>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LabelCreateRequest>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ImportApiRequest>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ActivityLogResponse>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.KPIMetadata>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnalyticsView>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AnnotationReview>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.MaybeExpandedComment>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureDatasetStorage>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSDatasetStorage>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3DatasetStorage>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Dataset>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetView>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatasetMember>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AgreementV2BackfillJob>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ValueCountsBackfillJob>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsRetrieveResponseItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.List<string>>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.View>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.MLBackend>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelProviderConnection>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationId>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipOption>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberSkillsOption>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermission>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ConfigurablePermissionOption>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectTemplate>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectRole>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DataQualityAgreementDimensions>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.UserSimple>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Export>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FileUpload>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ReviewRoutingRule>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.TaskSimple>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.TaskAssignment>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DimensionList>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectLearningAssignment>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Pause>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ProjectSubsetItem>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ThirdPartyModelVersion>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.FewShotExample>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ModelRun>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureBlobImportStorage>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalImportStorage>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatabricksImportStorage>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureBlobExportStorage>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.AzureServicePrincipalExportStorage>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.DatabricksExportStorage>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSExportStorage>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSSAExportStorage>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSWIFExportStorage>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LocalFilesExportStorage>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RedisExportStorage>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3ExportStorage>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseS3ExportStorage>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSImportStorage>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSSAImportStorage>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.GCSWIFImportStorage>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LocalFilesImportStorage>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.RedisImportStorage>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.S3ImportStorage>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseS3ImportStorage>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LSEAPITokenList>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.LseUserAPI>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Webhook>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Workspace>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.WorkspaceMemberList>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LabelStudio.Project>? ListType164 { get; set; }
    }
}