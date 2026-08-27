
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `Sequential sampling` - Tasks are ordered by Data manager ordering<br/>
    /// * `Uniform sampling` - Tasks are chosen randomly<br/>
    /// * `Uncertainty sampling` - Tasks are chosen according to model uncertainty scores (active learning mode)
    /// </summary>
    public enum ProjectSamplingEnum
    {
        /// <summary>
        ///
        /// </summary>
        SequentialSampling,
        /// <summary>
        ///
        /// </summary>
        UncertaintySampling,
        /// <summary>
        ///
        /// </summary>
        UniformSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSamplingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSamplingEnum value)
        {
            return value switch
            {
                ProjectSamplingEnum.SequentialSampling => "Sequential sampling",
                ProjectSamplingEnum.UncertaintySampling => "Uncertainty sampling",
                ProjectSamplingEnum.UniformSampling => "Uniform sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSamplingEnum? ToEnum(string value)
        {
            return value switch
            {
                "Sequential sampling" => ProjectSamplingEnum.SequentialSampling,
                "Uncertainty sampling" => ProjectSamplingEnum.UncertaintySampling,
                "Uniform sampling" => ProjectSamplingEnum.UniformSampling,
                _ => null,
            };
        }
    }
}