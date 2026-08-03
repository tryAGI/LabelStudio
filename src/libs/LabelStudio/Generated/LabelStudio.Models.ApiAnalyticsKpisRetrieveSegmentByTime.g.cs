
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiAnalyticsKpisRetrieveSegmentByTime
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
        /// <summary>
        /// 
        /// </summary>
        Yearly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiAnalyticsKpisRetrieveSegmentByTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiAnalyticsKpisRetrieveSegmentByTime value)
        {
            return value switch
            {
                ApiAnalyticsKpisRetrieveSegmentByTime.Daily => "daily",
                ApiAnalyticsKpisRetrieveSegmentByTime.Hourly => "hourly",
                ApiAnalyticsKpisRetrieveSegmentByTime.Monthly => "monthly",
                ApiAnalyticsKpisRetrieveSegmentByTime.Weekly => "weekly",
                ApiAnalyticsKpisRetrieveSegmentByTime.Yearly => "yearly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiAnalyticsKpisRetrieveSegmentByTime? ToEnum(string value)
        {
            return value switch
            {
                "daily" => ApiAnalyticsKpisRetrieveSegmentByTime.Daily,
                "hourly" => ApiAnalyticsKpisRetrieveSegmentByTime.Hourly,
                "monthly" => ApiAnalyticsKpisRetrieveSegmentByTime.Monthly,
                "weekly" => ApiAnalyticsKpisRetrieveSegmentByTime.Weekly,
                "yearly" => ApiAnalyticsKpisRetrieveSegmentByTime.Yearly,
                _ => null,
            };
        }
    }
}