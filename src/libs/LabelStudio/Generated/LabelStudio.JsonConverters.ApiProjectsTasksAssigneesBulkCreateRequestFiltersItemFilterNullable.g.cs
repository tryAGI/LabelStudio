#nullable enable

namespace LabelStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilterNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilter?>
    {
        /// <inheritdoc />
        public override global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilter? Read(
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
                        return global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilterExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilter?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilter? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateRequestFiltersItemFilterExtensions.ToValueString(value.Value));
            }
        }
    }
}
