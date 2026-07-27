#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsCreateRequestDataFiltersItemChildFilterFilterNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilter?>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilter? Read(
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
                        return global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilterExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilter?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilter? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemChildFilterFilterExtensions.ToValueString(value.Value));
            }
        }
    }
}
