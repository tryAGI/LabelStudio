
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiProjectsMembersPaginatedListTagsOperator
    {
        /// <summary>
        /// `any` (at least one tag), `all` (every tag, the default), `none` (no selected tag).
        /// </summary>
        All,
        /// <summary>
        /// `any` (at least one tag), `all` (every tag, the default), `none` (no selected tag).
        /// </summary>
        Any,
        /// <summary>
        /// `any` (at least one tag), `all` (every tag, the default), `none` (no selected tag).
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsMembersPaginatedListTagsOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsMembersPaginatedListTagsOperator value)
        {
            return value switch
            {
                ApiProjectsMembersPaginatedListTagsOperator.All => "all",
                ApiProjectsMembersPaginatedListTagsOperator.Any => "any",
                ApiProjectsMembersPaginatedListTagsOperator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsMembersPaginatedListTagsOperator? ToEnum(string value)
        {
            return value switch
            {
                "all" => ApiProjectsMembersPaginatedListTagsOperator.All,
                "any" => ApiProjectsMembersPaginatedListTagsOperator.Any,
                "none" => ApiProjectsMembersPaginatedListTagsOperator.None,
                _ => null,
            };
        }
    }
}