
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `none` - none<br/>
    /// * `full` - full<br/>
    /// * `changed_modules` - changed_modules
    /// </summary>
    public enum RetakeScopeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ChangedModules,
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetakeScopeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetakeScopeEnum value)
        {
            return value switch
            {
                RetakeScopeEnum.ChangedModules => "changed_modules",
                RetakeScopeEnum.Full => "full",
                RetakeScopeEnum.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetakeScopeEnum? ToEnum(string value)
        {
            return value switch
            {
                "changed_modules" => RetakeScopeEnum.ChangedModules,
                "full" => RetakeScopeEnum.Full,
                "none" => RetakeScopeEnum.None,
                _ => null,
            };
        }
    }
}