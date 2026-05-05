#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiProjectsSubsetTasksListAlignmentOutcomeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcomeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcome value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiProjectsSubsetTasksListAlignmentOutcomeExtensions.ToValueString(value));
        }
    }
}
