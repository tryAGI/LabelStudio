
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `initialized` - Initialized<br/>
    /// * `queued` - Queued<br/>
    /// * `in_progress` - In progress<br/>
    /// * `failed` - Failed<br/>
    /// * `completed` - Completed<br/>
    /// * `completed_with_errors` - Completed with errors
    /// </summary>
    public enum StorageStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        CompletedWithErrors,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Initialized,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageStatusEnum value)
        {
            return value switch
            {
                StorageStatusEnum.Completed => "completed",
                StorageStatusEnum.CompletedWithErrors => "completed_with_errors",
                StorageStatusEnum.Failed => "failed",
                StorageStatusEnum.InProgress => "in_progress",
                StorageStatusEnum.Initialized => "initialized",
                StorageStatusEnum.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => StorageStatusEnum.Completed,
                "completed_with_errors" => StorageStatusEnum.CompletedWithErrors,
                "failed" => StorageStatusEnum.Failed,
                "in_progress" => StorageStatusEnum.InProgress,
                "initialized" => StorageStatusEnum.Initialized,
                "queued" => StorageStatusEnum.Queued,
                _ => null,
            };
        }
    }
}