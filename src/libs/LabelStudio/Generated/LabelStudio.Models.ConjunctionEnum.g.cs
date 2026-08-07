
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConjunctionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConjunctionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConjunctionEnum value)
        {
            return value switch
            {
                ConjunctionEnum.And => "and",
                ConjunctionEnum.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConjunctionEnum? ToEnum(string value)
        {
            return value switch
            {
                "and" => ConjunctionEnum.And,
                "or" => ConjunctionEnum.Or,
                _ => null,
            };
        }
    }
}