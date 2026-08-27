#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssignableUserTypeEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.AssignableUserTypeEnum?>
    {
        /// <inheritdoc />
        public override global::LabelStudio.AssignableUserTypeEnum? Read(
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
                        return global::LabelStudio.AssignableUserTypeEnumExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.AssignableUserTypeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.AssignableUserTypeEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.AssignableUserTypeEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LabelStudio.AssignableUserTypeEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
