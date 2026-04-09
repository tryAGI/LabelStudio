
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsGcpCustomFunctionRetrieveResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.ApiProjectsGcpCustomFunctionRetrieveResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsGcpCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsGcpCustomFunctionRetrieveResponse(
            string code,
            global::LabelStudio.ApiProjectsGcpCustomFunctionRetrieveResponseStatus status)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsGcpCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsGcpCustomFunctionRetrieveResponse()
        {
        }
    }
}