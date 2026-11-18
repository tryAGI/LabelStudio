
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `String` - String<br/>
    /// * `Number` - Number
    /// </summary>
    public enum TaskDataColumnValueTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskDataColumnValueTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskDataColumnValueTypeEnum value)
        {
            return value switch
            {
                TaskDataColumnValueTypeEnum.Number => "Number",
                TaskDataColumnValueTypeEnum.String => "String",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskDataColumnValueTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "Number" => TaskDataColumnValueTypeEnum.Number,
                "String" => TaskDataColumnValueTypeEnum.String,
                _ => null,
            };
        }
    }
}