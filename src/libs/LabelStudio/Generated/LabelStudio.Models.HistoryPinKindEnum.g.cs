
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `named` - named<br/>
    /// * `published` - published<br/>
    /// * `before_restore` - before_restore
    /// </summary>
    public enum HistoryPinKindEnum
    {
        /// <summary>
        ///
        /// </summary>
        BeforeRestore,
        /// <summary>
        ///
        /// </summary>
        Named,
        /// <summary>
        ///
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HistoryPinKindEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryPinKindEnum value)
        {
            return value switch
            {
                HistoryPinKindEnum.BeforeRestore => "before_restore",
                HistoryPinKindEnum.Named => "named",
                HistoryPinKindEnum.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryPinKindEnum? ToEnum(string value)
        {
            return value switch
            {
                "before_restore" => HistoryPinKindEnum.BeforeRestore,
                "named" => HistoryPinKindEnum.Named,
                "published" => HistoryPinKindEnum.Published,
                _ => null,
            };
        }
    }
}