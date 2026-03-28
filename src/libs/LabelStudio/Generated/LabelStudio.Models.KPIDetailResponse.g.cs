
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Response serializer for KPI detail endpoint.<br/>
    /// Structure varies based on segmentation parameters.
    /// </summary>
    public sealed partial class KPIDetailResponse
    {
        /// <summary>
        /// Project-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_project")]
        public global::LabelStudio.KPIProjectSegment? ByProject { get; set; }

        /// <summary>
        /// User-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_user")]
        public global::LabelStudio.KPIUserSegment? ByUser { get; set; }

        /// <summary>
        /// KPI identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kpi_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KpiKey { get; set; }

        /// <summary>
        /// Human-readable KPI label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kpi_label")]
        public string? KpiLabel { get; set; }

        /// <summary>
        /// 2D matrix (time × user) in compact format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrix")]
        public global::LabelStudio.KPIMatrixSegment? Matrix { get; set; }

        /// <summary>
        /// 2D matrix (time × project) in compact format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_matrix")]
        public global::LabelStudio.KPIProjectMatrixSegment? ProjectMatrix { get; set; }

        /// <summary>
        /// Type of segmentation applied<br/>
        /// * `none` - none<br/>
        /// * `time` - time<br/>
        /// * `user` - user<br/>
        /// * `project` - project<br/>
        /// * `matrix` - matrix<br/>
        /// * `project_matrix` - project_matrix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.SegmentationEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.SegmentationEnum Segmentation { get; set; }

        /// <summary>
        /// Time-segmented data (compact format with parallel arrays)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        public global::LabelStudio.KPITimeSegment? TimeSeries { get; set; }

        /// <summary>
        /// Total value (no segmentation)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public global::LabelStudio.KPIValue? Total { get; set; }

        /// <summary>
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIDetailResponse" /> class.
        /// </summary>
        /// <param name="byProject">
        /// Project-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="byUser">
        /// User-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="kpiKey">
        /// KPI identifier
        /// </param>
        /// <param name="kpiLabel">
        /// Human-readable KPI label
        /// </param>
        /// <param name="matrix">
        /// 2D matrix (time × user) in compact format
        /// </param>
        /// <param name="projectMatrix">
        /// 2D matrix (time × project) in compact format
        /// </param>
        /// <param name="segmentation">
        /// Type of segmentation applied<br/>
        /// * `none` - none<br/>
        /// * `time` - time<br/>
        /// * `user` - user<br/>
        /// * `project` - project<br/>
        /// * `matrix` - matrix<br/>
        /// * `project_matrix` - project_matrix
        /// </param>
        /// <param name="timeSeries">
        /// Time-segmented data (compact format with parallel arrays)
        /// </param>
        /// <param name="total">
        /// Total value (no segmentation)
        /// </param>
        /// <param name="unit">
        /// Unit of measurement: seconds, minutes, hours, count, or ratio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIDetailResponse(
            string kpiKey,
            global::LabelStudio.SegmentationEnum segmentation,
            string unit,
            global::LabelStudio.KPIProjectSegment? byProject,
            global::LabelStudio.KPIUserSegment? byUser,
            string? kpiLabel,
            global::LabelStudio.KPIMatrixSegment? matrix,
            global::LabelStudio.KPIProjectMatrixSegment? projectMatrix,
            global::LabelStudio.KPITimeSegment? timeSeries,
            global::LabelStudio.KPIValue? total)
        {
            this.KpiKey = kpiKey ?? throw new global::System.ArgumentNullException(nameof(kpiKey));
            this.Segmentation = segmentation;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.ByProject = byProject;
            this.ByUser = byUser;
            this.KpiLabel = kpiLabel;
            this.Matrix = matrix;
            this.ProjectMatrix = projectMatrix;
            this.TimeSeries = timeSeries;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIDetailResponse" /> class.
        /// </summary>
        public KPIDetailResponse()
        {
        }
    }
}