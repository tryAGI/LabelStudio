
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `PENDING` - Pending<br/>
    /// * `QUEUED` - Queued<br/>
    /// * `RUNNING` - Running<br/>
    /// * `COMPLETED` - Completed<br/>
    /// * `FAILED` - Failed
    /// </summary>
    public enum StatusA47Enum
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusA47EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusA47Enum value)
        {
            return value switch
            {
                StatusA47Enum.Completed => "COMPLETED",
                StatusA47Enum.Failed => "FAILED",
                StatusA47Enum.Pending => "PENDING",
                StatusA47Enum.Queued => "QUEUED",
                StatusA47Enum.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusA47Enum? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => StatusA47Enum.Completed,
                "FAILED" => StatusA47Enum.Failed,
                "PENDING" => StatusA47Enum.Pending,
                "QUEUED" => StatusA47Enum.Queued,
                "RUNNING" => StatusA47Enum.Running,
                _ => null,
            };
        }
    }
}