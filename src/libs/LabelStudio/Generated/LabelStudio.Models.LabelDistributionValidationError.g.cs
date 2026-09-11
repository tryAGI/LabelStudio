
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelDistributionValidationError
    {
        /// <summary>
        /// Human-readable error summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Debug exception information when enabled; otherwise null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exc_info")]
        public object? ExcInfo { get; set; }

        /// <summary>
        /// Unique error identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.LabelDistributionValidationErrors ValidationErrors { get; set; }

        /// <summary>
        /// Label Studio backend version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionValidationError" /> class.
        /// </summary>
        /// <param name="detail">
        /// Human-readable error summary.
        /// </param>
        /// <param name="id">
        /// Unique error identifier.
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code.
        /// </param>
        /// <param name="validationErrors"></param>
        /// <param name="version">
        /// Label Studio backend version.
        /// </param>
        /// <param name="excInfo">
        /// Debug exception information when enabled; otherwise null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionValidationError(
            string detail,
            global::System.Guid id,
            int statusCode,
            global::LabelStudio.LabelDistributionValidationErrors validationErrors,
            string version,
            object? excInfo)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.ExcInfo = excInfo;
            this.Id = id;
            this.StatusCode = statusCode;
            this.ValidationErrors = validationErrors ?? throw new global::System.ArgumentNullException(nameof(validationErrors));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionValidationError" /> class.
        /// </summary>
        public LabelDistributionValidationError()
        {
        }

    }
}