
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `only` - only<br/>
    /// * `exclude` - exclude<br/>
    /// * `None` - None
    /// </summary>
    public enum DataManagerFilterModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataManagerFilterModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataManagerFilterModeEnum value)
        {
            return value switch
            {
                DataManagerFilterModeEnum.Exclude => "exclude",
                DataManagerFilterModeEnum.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataManagerFilterModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => DataManagerFilterModeEnum.Exclude,
                "only" => DataManagerFilterModeEnum.Only,
                _ => null,
            };
        }
    }
}