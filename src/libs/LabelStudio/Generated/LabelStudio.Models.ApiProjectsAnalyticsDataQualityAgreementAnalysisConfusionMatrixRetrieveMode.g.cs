
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        GroundTruth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode value)
        {
            return value switch
            {
                ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.Accepted => "accepted",
                ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.All => "all",
                ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.GroundTruth => "ground_truth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.Accepted,
                "all" => ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.All,
                "ground_truth" => ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode.GroundTruth,
                _ => null,
            };
        }
    }
}