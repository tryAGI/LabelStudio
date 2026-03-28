#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter Read(
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
                        return global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterExtensions.ToValueString(value));
        }
    }
}
