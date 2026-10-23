
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `verified` - verified<br/>
    /// * `self_reported` - self_reported<br/>
    /// * `failed` - failed
    /// </summary>
    public enum MemberSkillStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        SelfReported,
        /// <summary>
        ///
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemberSkillStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemberSkillStatusEnum value)
        {
            return value switch
            {
                MemberSkillStatusEnum.Failed => "failed",
                MemberSkillStatusEnum.SelfReported => "self_reported",
                MemberSkillStatusEnum.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemberSkillStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "failed" => MemberSkillStatusEnum.Failed,
                "self_reported" => MemberSkillStatusEnum.SelfReported,
                "verified" => MemberSkillStatusEnum.Verified,
                _ => null,
            };
        }
    }
}