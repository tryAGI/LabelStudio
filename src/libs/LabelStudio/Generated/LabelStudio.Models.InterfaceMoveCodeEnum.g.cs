
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `interface_move_blocked` - Interface move blocked<br/>
    /// * `interface_move_plan_changed` - Interface move plan changed<br/>
    /// * `interface_move_requires_confirmation` - Interface move requires confirmation
    /// </summary>
    public enum InterfaceMoveCodeEnum
    {
        /// <summary>
        ///
        /// </summary>
        InterfaceMoveBlocked,
        /// <summary>
        ///
        /// </summary>
        InterfaceMovePlanChanged,
        /// <summary>
        ///
        /// </summary>
        InterfaceMoveRequiresConfirmation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterfaceMoveCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterfaceMoveCodeEnum value)
        {
            return value switch
            {
                InterfaceMoveCodeEnum.InterfaceMoveBlocked => "interface_move_blocked",
                InterfaceMoveCodeEnum.InterfaceMovePlanChanged => "interface_move_plan_changed",
                InterfaceMoveCodeEnum.InterfaceMoveRequiresConfirmation => "interface_move_requires_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterfaceMoveCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "interface_move_blocked" => InterfaceMoveCodeEnum.InterfaceMoveBlocked,
                "interface_move_plan_changed" => InterfaceMoveCodeEnum.InterfaceMovePlanChanged,
                "interface_move_requires_confirmation" => InterfaceMoveCodeEnum.InterfaceMoveRequiresConfirmation,
                _ => null,
            };
        }
    }
}