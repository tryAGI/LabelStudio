
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelDistributionValidationErrors
    {
        /// <summary>
        /// Filter-plan parsing or validation messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionValidationErrors" /> class.
        /// </summary>
        /// <param name="filters">
        /// Filter-plan parsing or validation messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionValidationErrors(
            global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>> filters)
        {
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionValidationErrors" /> class.
        /// </summary>
        public LabelDistributionValidationErrors()
        {
        }

    }
}