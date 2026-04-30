
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `lt` - &lt;<br/>
    /// * `lte` - &lt;=<br/>
    /// * `gt` - &gt;<br/>
    /// * `gte` - &gt;=<br/>
    /// * `eq` - =
    /// </summary>
    public enum OperatorEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperatorEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperatorEnum value)
        {
            return value switch
            {
                OperatorEnum.Eq => "eq",
                OperatorEnum.Gt => "gt",
                OperatorEnum.Gte => "gte",
                OperatorEnum.Lt => "lt",
                OperatorEnum.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperatorEnum? ToEnum(string value)
        {
            return value switch
            {
                "eq" => OperatorEnum.Eq,
                "gt" => OperatorEnum.Gt,
                "gte" => OperatorEnum.Gte,
                "lt" => OperatorEnum.Lt,
                "lte" => OperatorEnum.Lte,
                _ => null,
            };
        }
    }
}