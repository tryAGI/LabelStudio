#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter?>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter? Read(
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
                        return global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilterExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilter? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LabelStudio.ApiDmActionsCreateRequestFiltersItemFilterExtensions.ToValueString(value.Value));
            }
        }
    }
}
