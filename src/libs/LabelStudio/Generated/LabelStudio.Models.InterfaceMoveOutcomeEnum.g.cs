
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `move` - Move<br/>
    /// * `already_in_target` - Already in target<br/>
    /// * `stay` - Stay<br/>
    /// * `cannot_move` - Cannot move
    /// </summary>
    public enum InterfaceMoveOutcomeEnum
    {
        /// <summary>
        ///
        /// </summary>
        AlreadyInTarget,
        /// <summary>
        ///
        /// </summary>
        CannotMove,
        /// <summary>
        ///
        /// </summary>
        Move,
        /// <summary>
        ///
        /// </summary>
        Stay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterfaceMoveOutcomeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterfaceMoveOutcomeEnum value)
        {
            return value switch
            {
                InterfaceMoveOutcomeEnum.AlreadyInTarget => "already_in_target",
                InterfaceMoveOutcomeEnum.CannotMove => "cannot_move",
                InterfaceMoveOutcomeEnum.Move => "move",
                InterfaceMoveOutcomeEnum.Stay => "stay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterfaceMoveOutcomeEnum? ToEnum(string value)
        {
            return value switch
            {
                "already_in_target" => InterfaceMoveOutcomeEnum.AlreadyInTarget,
                "cannot_move" => InterfaceMoveOutcomeEnum.CannotMove,
                "move" => InterfaceMoveOutcomeEnum.Move,
                "stay" => InterfaceMoveOutcomeEnum.Stay,
                _ => null,
            };
        }
    }
}