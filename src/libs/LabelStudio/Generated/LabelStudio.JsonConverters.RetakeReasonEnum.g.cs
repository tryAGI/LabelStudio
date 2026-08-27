#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class RetakeReasonEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.RetakeReasonEnum>
    {
        /// <inheritdoc />
        public override global::LabelStudio.RetakeReasonEnum Read(
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
                        return global::LabelStudio.RetakeReasonEnumExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.RetakeReasonEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.RetakeReasonEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.RetakeReasonEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.RetakeReasonEnumExtensions.ToValueString(value));
        }
    }
}
