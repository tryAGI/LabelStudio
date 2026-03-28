#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter Read(
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
                        return global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilterExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiDmViewsCreateRequestDataFiltersItemFilterExtensions.ToValueString(value));
        }
    }
}
