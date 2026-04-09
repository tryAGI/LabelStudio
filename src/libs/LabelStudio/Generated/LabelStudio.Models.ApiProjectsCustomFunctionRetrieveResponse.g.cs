
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsCustomFunctionRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ApiProjectsCustomFunctionRetrieveResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsCustomFunctionRetrieveResponse(
            string code,
            global::LabelStudio.ApiProjectsCustomFunctionRetrieveResponseStatus status)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsCustomFunctionRetrieveResponse()
        {
        }
    }
}