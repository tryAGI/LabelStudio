#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiMlPartialUpdateRequestAuthMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod Read(
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
                        return global::LabelStudio.ApiMlPartialUpdateRequestAuthMethodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiMlPartialUpdateRequestAuthMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiMlPartialUpdateRequestAuthMethodExtensions.ToValueString(value));
        }
    }
}
