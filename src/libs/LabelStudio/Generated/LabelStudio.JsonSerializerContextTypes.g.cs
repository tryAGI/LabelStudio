
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
        public global::LabelStudio.AuthModeEnum? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AuthTypeEnum? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorage? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StorageStatusEnum? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorageValidateRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobExportStorageWriteRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorage? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorageValidateRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureBlobImportStorageWriteRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureDatasetStorage? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureDatasetStorageRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalExportStorage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalExportStorageRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalImportStorage? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.AzureServicePrincipalImportStorageRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchFailedPredictions? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchFailedPredictionsRequestRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchPredictions? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BatchPredictionsRequestRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingChecks? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CountLimit? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FlexChecks? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PromptsStatusEnum? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingFlags? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BillingInfoResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Blueprint? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BlueprintRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BudgetResetPeriodEnum? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorRun? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkIndicatorsResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.BulkIndicatorRun>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkOrganizationMemberTagAssignmentRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkProjectLearningAssignmentRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkResetCourseProgressRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CancelModelRunResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Certificate? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatCompletionRequestRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChatMessageRequest>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRequest? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChatMessageRoleEnum? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CheckMatchingFunctionRequestRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilter? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ChildFilterRequest? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CollectionModeEnum? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Comment? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CommentSerializerWithExpandedUser? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUser? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConfigurablePermissionOption? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssignableOrganizationRoleEnum>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConjunctionEnum? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ControlTagWeightRequest? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormat? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImportStatusEnum? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ConvertedFormatRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSession? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionHeartbeatRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseEditingSessionResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseModule? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutline? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlineModule? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseOutlinePage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CoursePageSaveResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseProgressImportResult? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OpEnum? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CourseStructureOpResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.CourseModule>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CreateProjectFromTemplateRequestRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.CustomFunctionCodeRequestRequest? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataManagerFilterModeEnum? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementConfusionMatrix? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityConfusionPair? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDimensions? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DataQualityAgreementDistribution? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorage? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageValidateRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksExportStorageWriteRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorage? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageValidateRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatabricksImportStorageWriteRequest? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dataset? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumn? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnVisibilityDefaults? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetColumnsResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetColumn>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesCreateRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetImportCandidatesResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMember? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetMemberRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserSimpleRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageAvailableDataType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetStorageColumnsResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageAvailableDataType>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetStorageColumnType>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetTasksMetadataResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetView? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroup? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewLockedBy? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DatasetViewRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterGroupRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultModelVersionNameResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DefaultRole? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleEnum? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Dimension? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionCreateRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionList? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DimensionRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.DuplicateLearningResourceRequest? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EditionEnum? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.EstimatedDurationUnitEnum? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Export? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormat>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ExportConvertRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteRequestRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FSMTransitionExecuteResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateModel? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExample? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FewShotExampleRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FileUpload? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Filter? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilter>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Filter>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FilterRequest>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FilterRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ChildFilterRequest>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.FlexActiveBlock? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FlexActiveBlock>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCPCustomFunctionUpdateRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorage? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSDatasetStorageRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorage? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageValidateRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSExportStorageWriteRequest? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorage? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageValidateRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSImportStorageWriteRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorage? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAExportStorageRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorage? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSSAImportStorageRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorage? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFExportStorageRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorage? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.GCSWIFImportStorageRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Hotkeys? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ImportApiRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationRequest>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PredictionRequest>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.InferenceRunCostEstimate? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIDetailResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectSegment? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserSegment? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMatrixSegment? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectMatrixSegment? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SegmentationEnum? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPITimeSegment? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIValue? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.DateTime>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIUserInfo>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIUserInfo? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIMetadata? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.KPIProjectInfo? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIProjectInfo>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OneOf<double?, string>?>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, string>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenBlacklistRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSAPITokenRotateRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenCreate? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEAPITokenList? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettings? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEJWTSettingsRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LSEKeyIndicatorValue? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Label? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelBulkUpdateResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreate? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelCreateRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionCountsRow>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsRow? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionCountsTotals? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureDimension? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelDistributionStructureResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLink? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LabelLinkRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningProgressUpdateRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResource? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceAssignmentSummary? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgress? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsItem? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCountsResponse? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceCountsItem>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreate? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceCreateRequest? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceDetail? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceList? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUpdate? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LearningResourceUploadResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorage? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageValidateRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesExportStorageWriteRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorage? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageValidateRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LocalFilesImportStorageWriteRequest? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptions? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseAnnotationFilterOptionsRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreate? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptions? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptions? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseExportCreateRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConvertedFormatRequest>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionsRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskFilterOptionsRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFields? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OnboardingStateEnum? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TrialRoleEnum? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseFieldsRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterface? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceAppendVersionsRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceAppendVersionRequest>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceList? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionDescriptionRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseInterfaceVersionIdRequest? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganization? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationBilling? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberList? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListContributedToProject>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListContributedToProject? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListCreatedProject>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseOrganizationMemberListCreatedProject? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleSourceEnum? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SimpleOrganizationMemberTag? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberList? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProject? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCounts? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreate? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectCreateRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeightRequest>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParams? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectParamsRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseProjectStateResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorage? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ExportStorageRequest? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorage? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseS3ImportStorageRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTask? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskDraft>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskDraft? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskPrediction>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskPrediction? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotators? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsDraft? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewers? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersDraft>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersDraft? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersPrediction>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseTaskSerializerForReviewersPrediction? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMembership>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembership? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserAPI? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListContributedToProject? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserOrganizationMemberListCreatedProject? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.LseUserRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackend? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateEnum? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequest? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendRequestRequest? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLBackendTrainRequestRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MLInteractiveAnnotatingRequestRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MappingStatusEnum? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MaybeExpandedComment? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParam? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.MetricParamUpdateRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterface? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SkillNameEnum? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelInterfaceSerializerGET? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AssociatedProject>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnection? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProviderEnum? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScopeEnum? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelProviderConnectionRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRun? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetEnum? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunStatusEnum? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ModelRunRequestRequest? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OperatorEnum? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationId? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationInvite? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMember? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberContributedToProject>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberContributedToProject? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberCreatedProject>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberCreatedProject? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterRequestRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberFilterSchema? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOption? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipOptionKindEnum? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOption? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberSkillsOption? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTag? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagBulkCreateRequest? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportCreateRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMemberTagRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationMembershipRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermission? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermissionRoleEnum>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRoleEnum? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleEnum>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationPermissionRequest? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OrganizationRoleAssignment? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAllRolesProjectListList? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AllRolesProjectList>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedAnnotationHistoryList? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationHistory>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCertificateList? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Certificate>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedCourseModuleList? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelCreateList? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreate>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelLinkList? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelLink>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLabelList? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Label>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLearningResourceListList? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceList>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseInterfaceListList? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseInterfaceList>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseOrganizationMemberListList? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberList>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseProjectCountsList? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseProjectCounts>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedLseUserList? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUser>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedModelInterfaceSerializerGETList? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelInterfaceSerializerGET>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedOrganizationMemberTagList? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberTag>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedPaginatedProjectMemberList? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PaginatedProjectMember>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectMember? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedProjectSubsetTasksResponseList? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTasksResponse>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTasksResponse? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedRoleBasedTaskList? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RoleBasedTask>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RoleBasedTask? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedSeatReportList? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.SeatReport>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SeatReport? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedStateModelList? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateModel>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PaginatedUserLearningProgressListList? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserLearningProgressList>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.UserLearningProgressList? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnalyticsViewRequest? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAnnotationReviewRequest? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobExportStorageWriteRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureBlobImportStorageWriteRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureDatasetStorageRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalExportStorageRequest? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedAzureServicePrincipalImportStorageRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedBlueprintUpdateRequest? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCommentRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedCoursePageUpdateRequest? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksExportStorageWriteRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatabricksImportStorageWriteRequest? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetImportCandidatesPatchRequest? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetRequest? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDatasetViewRequest? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDefaultRoleRequest? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedDimensionRequest? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFewShotExampleRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedFileUploadRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSDatasetStorageRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSExportStorageWriteRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSImportStorageWriteRequest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAExportStorageRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSSAImportStorageRequest? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFExportStorageRequest? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedGCSWIFImportStorageRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedHotkeysRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelLinkRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLabelRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLearningResourceUpdateRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesExportStorageWriteRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLocalFilesImportStorageWriteRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseInterfaceRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseOrganizationSerializerUpdateRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseProjectUpdateRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ExportStorageRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseS3ImportStorageRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseTaskRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedLseUserSerializerUpdateRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedMLBackendRequestRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelInterfaceRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedModelProviderConnectionRequest? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberCreateUpdateRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StandardUserTypeEnum? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationMemberTagRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedOrganizationPermissionRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPauseRequest? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReasonEnum? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedPredictionRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectLearningAssignmentRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedProjectTemplateRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisExportStorageWriteRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedRedisImportStorageWriteRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3DatasetStorageRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ExportStorageWriteRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedS3ImportStorageWriteRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedSessionTimeoutPolicyRequest? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedTaskAssigneesMutationRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedThirdPartyModelVersionRequest? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedViewRequestRequest? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewDataRequestRequest? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWebhookSerializerForUpdateRequest? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActionsEnum>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PatchedWorkspaceRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Pause? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PauseRequest? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Prediction? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PredictionCountResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItem>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItem? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemFilter? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsFiltersRequestItemOperator? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsOrderingRequestItem? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequest? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Project? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseItem? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectAnnotationsBrowseResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectAnnotationsBrowseItem>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateModeEnum? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectDuplicateRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroup? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRoleEnum? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectGroupRequest? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectImport? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfig? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLabelConfigRequest? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignment? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectLearningAssignmentCreateRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMember? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRequest? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectMemberBulkAssignRolesRequest>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignRolesRequest? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberBulkAssignResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberIdentityVerificationError? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectMemberRequest? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectReimport? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRole? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleAssignment? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectRoleRequest? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetItem? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectSubsetTaskItem? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetTaskItem>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplate? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ProjectTemplateRequest? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PromptPreviewResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.PublishLearningResourceRequest? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeScopeEnum? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluate? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateModeEnum? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReEvaluateRequest? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorage? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageValidateRequest? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisExportStorageWriteRequest? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorage? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageValidateRequest? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RedisImportStorageWriteRequest? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinePromptRequestRequest? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RefinedPromptResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersion? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionSummary? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RegressionsResponse? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RequeueRejectedTasksModeEnum? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RetakeReasonEnum? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewCriteriaEnum? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRule? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRuleRequestRequest? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewRoutingRulesReplaceRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRuleRequestRequest>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RejectActionEnum>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ReviewSettingsSamplingEnum? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeCertificateRequest? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.RevokeInviteRequest? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorage? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3DatasetStorageRequest? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorage? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageValidateRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ExportStorageWriteRequest? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorage? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageValidateRequest? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.S3ImportStorageWriteRequest? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettings? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroup>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SamlSettingsUpdateRequest? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectGroupRequest>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettings? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdate? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ScimSettingsUpdateRequest? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceAccessAssignment? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SendInviteRequest? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOption? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SerializationOptionRequest? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.SessionTimeoutPolicy? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillCancelResponse? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillErrorResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItem? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobItemResponse? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillProgress? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateTriggeredBy? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillJobListResponse? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItemResponse>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillOrgStatus? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillResponse? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.StateBackfillJobItem>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.StateBackfillStatusResponse? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TriggeredBy2? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAgreementMatrixResponse? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssigneesMutationRequest? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskAssignment? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEvent? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskEventRequest? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TaskSimple? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Annotation>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Prediction>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ThirdPartyModelVersionRequest? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenDetailError? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshRequest? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRefreshResponse? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TokenRotateResponse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskRequestRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.TryTaskResponse? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainRequestRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlDomainResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlRequestRequest? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValidateSamlMetadataUrlResponse? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ValueCountsBackfillJob? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.VersionResponse? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.View? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewLockedBy? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewOrderRequest? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ViewRequestRequest? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Webhook? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookRequest? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdate? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WebhookSerializerForUpdateRequest? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmILseFields? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WhoAmIUser? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.Workspace? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberBulkAssignRequest? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreate? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberCreateRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceMemberList? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceProjectsRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.WorkspaceRequest? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LabelCreateRequest>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressImportCreateRequest? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ImportApiRequest>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiActivityLogsListMethod? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnalyticsKpisRetrieveSegmentByTime? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsCreateId? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsIdpAssignmentsHistoryListKind? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListSource? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsMembershipHistoryListUserType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiFsmOrganizationsSettingsHistoryListKind? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesDestroyType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsCompatibleProjectsListProjectType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiPromptsVersionsInferenceRunsListProjectSubset? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiTasksListFields? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ActivityLogResponse>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.KPIMetadata>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnalyticsView>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationHistoryDestroyResponse? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AnnotationReview>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkDeleteCreateResponse? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiAnnotationsBulkCreateResponseItem>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiAnnotationsBulkCreateResponseItem? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MaybeExpandedComment>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserResetTokenCreateResponse? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiCurrentUserTokenRetrieveResponse? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureDatasetStorage>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSDatasetStorage>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3DatasetStorage>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Dataset>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetView>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatasetMember>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AgreementV2BackfillJob>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ValueCountsBackfillJob>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItem? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.View>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiInferenceRunsIndicatorsListResponseItem? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiLearningResourcesUserProgressBulkResetCreateResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.MLBackend>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiMlVersionsRetrieveResponse? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelProviderConnection>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiModelProviderConnectionsProviderChoicesRetrieveResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsAssignmentsCreateResponse? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkDestroyResponse? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiOrganizationsMemberTagsImportsCreateResponse? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberSkillsOption>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermission>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ConfigurablePermissionOption>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectTemplate>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectRole>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DataQualityAgreementDimensions>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsAwsCustomFunctionRetrieveResponseStatus? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDashboardRetrieveResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsDuplicateCreateResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Export>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsExportsConvertCreateResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FileUpload>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportCreateResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsImportPredictionsCreateResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsMembersBulkDestroyResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementRetrieveResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsModelStatsPredictionRetrieveResponse? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ReviewRoutingRule>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsIaaRetrieveResponse? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementGroundtruthRetrieveResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorRetrieveResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsFinishedRetrieveResponse? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskSimple>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.TaskAssignment>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionListResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreListResponse? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsPredictionRetrieveResponse? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieveResponse? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DimensionList>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Pause>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ProjectSubsetItem>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ThirdPartyModelVersion>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.FewShotExample>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ModelRun>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobImportStorage>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalImportStorage>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksImportStorage>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureBlobExportStorage>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.AzureServicePrincipalExportStorage>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.DatabricksExportStorage>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSExportStorage>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAExportStorage>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFExportStorage>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesExportStorage>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisExportStorage>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ExportStorage>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ExportStorage>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesExportTypesRetrieveResponseItem? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSImportStorage>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSSAImportStorage>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.GCSWIFImportStorage>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LocalFilesImportStorage>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.RedisImportStorage>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.S3ImportStorage>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseS3ImportStorage>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.ApiStoragesTypesRetrieveResponseItem>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiStoragesTypesRetrieveResponseItem? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LSEAPITokenList>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.LseUserAPI>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Webhook>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponse? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationCreated? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectCreated? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectDeleted? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseProjectUpdated? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewsDeleted? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewCreated? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseReviewUpdated? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksCreated? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWebhooksInfoRetrieveResponseTasksDeleted? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Workspace>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceMemberList>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkDestroyResponse? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LabelStudio.ApiWorkspacesMembershipsBulkCreateResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LabelStudio.Project>? Type832 { get; set; }

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