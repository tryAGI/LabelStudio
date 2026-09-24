
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// Main Data Manager grid.
    /// </summary>
    public sealed partial class AllRolesProjectListDmColumnDefaultsExplore
    {
        /// <summary>
        /// Shared column id order for this surface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<string>? Order { get; set; }

        /// <summary>
        /// Public organization role to visible column ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Visible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllRolesProjectListDmColumnDefaultsExplore" /> class.
        /// </summary>
        /// <param name="order">
        /// Shared column id order for this surface.
        /// </param>
        /// <param name="visible">
        /// Public organization role to visible column ids.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllRolesProjectListDmColumnDefaultsExplore(
            global::System.Collections.Generic.IList<string>? order,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? visible)
        {
            this.Order = order;
            this.Visible = visible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllRolesProjectListDmColumnDefaultsExplore" /> class.
        /// </summary>
        public AllRolesProjectListDmColumnDefaultsExplore()
        {
        }

    }
}