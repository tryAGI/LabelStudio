#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType Read(
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
                        return global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiProjectsTasksAssigneesPartialUpdateRequestTypeExtensions.ToValueString(value));
        }
    }
}
