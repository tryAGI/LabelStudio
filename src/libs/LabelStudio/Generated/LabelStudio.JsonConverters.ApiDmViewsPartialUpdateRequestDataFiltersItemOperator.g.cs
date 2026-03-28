#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator Read(
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
                        return global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LabelStudio.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorExtensions.ToValueString(value));
        }
    }
}
