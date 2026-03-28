#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction?>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction? Read(
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
                        return global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunctionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LabelStudio.ApiDmViewsUpdateRequestDataFiltersConjunctionExtensions.ToValueString(value.Value));
            }
        }
    }
}
