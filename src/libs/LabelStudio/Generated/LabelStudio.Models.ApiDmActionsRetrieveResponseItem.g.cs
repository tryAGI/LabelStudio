
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmActionsRetrieveResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialog")]
        public global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog? Dialog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public bool? Experimental { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItem" /> class.
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="experimental"></param>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <param name="permission"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmActionsRetrieveResponseItem(
            global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog? dialog,
            bool? experimental,
            string? id,
            int? order,
            global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>? permission,
            string? title)
        {
            this.Dialog = dialog;
            this.Experimental = experimental;
            this.Id = id;
            this.Order = order;
            this.Permission = permission;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItem" /> class.
        /// </summary>
        public ApiDmActionsRetrieveResponseItem()
        {
        }
    }
}