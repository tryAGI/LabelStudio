
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
    public enum FsmBackfillJobStatusEnum
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
    public static class FsmBackfillJobStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FsmBackfillJobStatusEnum value)
        {
            return value switch
            {
                FsmBackfillJobStatusEnum.Completed => "COMPLETED",
                FsmBackfillJobStatusEnum.Failed => "FAILED",
                FsmBackfillJobStatusEnum.Pending => "PENDING",
                FsmBackfillJobStatusEnum.Queued => "QUEUED",
                FsmBackfillJobStatusEnum.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FsmBackfillJobStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => FsmBackfillJobStatusEnum.Completed,
                "FAILED" => FsmBackfillJobStatusEnum.Failed,
                "PENDING" => FsmBackfillJobStatusEnum.Pending,
                "QUEUED" => FsmBackfillJobStatusEnum.Queued,
                "RUNNING" => FsmBackfillJobStatusEnum.Running,
                _ => null,
            };
        }
    }
}