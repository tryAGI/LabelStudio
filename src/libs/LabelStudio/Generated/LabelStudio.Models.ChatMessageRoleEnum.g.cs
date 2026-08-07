
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `user` - user<br/>
    /// * `developer` - developer<br/>
    /// * `system` - system<br/>
    /// * `assistant` - assistant<br/>
    /// * `tool` - tool
    /// </summary>
    public enum ChatMessageRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRoleEnum value)
        {
            return value switch
            {
                ChatMessageRoleEnum.Assistant => "assistant",
                ChatMessageRoleEnum.Developer => "developer",
                ChatMessageRoleEnum.System => "system",
                ChatMessageRoleEnum.Tool => "tool",
                ChatMessageRoleEnum.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageRoleEnum.Assistant,
                "developer" => ChatMessageRoleEnum.Developer,
                "system" => ChatMessageRoleEnum.System,
                "tool" => ChatMessageRoleEnum.Tool,
                "user" => ChatMessageRoleEnum.User,
                _ => null,
            };
        }
    }
}