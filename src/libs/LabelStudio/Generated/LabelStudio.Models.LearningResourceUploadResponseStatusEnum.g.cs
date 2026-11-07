
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `uploaded` - uploaded<br/>
    /// * `imported` - imported<br/>
    /// * `unchanged` - unchanged<br/>
    /// * `importable` - importable<br/>
    /// * `external` - external
    /// </summary>
    public enum LearningResourceUploadResponseStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Importable,
        /// <summary>
        ///
        /// </summary>
        Imported,
        /// <summary>
        ///
        /// </summary>
        Unchanged,
        /// <summary>
        ///
        /// </summary>
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LearningResourceUploadResponseStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LearningResourceUploadResponseStatusEnum value)
        {
            return value switch
            {
                LearningResourceUploadResponseStatusEnum.External => "external",
                LearningResourceUploadResponseStatusEnum.Importable => "importable",
                LearningResourceUploadResponseStatusEnum.Imported => "imported",
                LearningResourceUploadResponseStatusEnum.Unchanged => "unchanged",
                LearningResourceUploadResponseStatusEnum.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LearningResourceUploadResponseStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "external" => LearningResourceUploadResponseStatusEnum.External,
                "importable" => LearningResourceUploadResponseStatusEnum.Importable,
                "imported" => LearningResourceUploadResponseStatusEnum.Imported,
                "unchanged" => LearningResourceUploadResponseStatusEnum.Unchanged,
                "uploaded" => LearningResourceUploadResponseStatusEnum.Uploaded,
                _ => null,
            };
        }
    }
}