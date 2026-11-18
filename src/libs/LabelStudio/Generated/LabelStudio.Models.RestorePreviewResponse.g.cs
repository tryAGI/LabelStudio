
#nullable enable

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RestorePreviewResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_with_progress_on_removed_modules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearnersWithProgressOnRemovedModules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModulesAdded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModulesRemoved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PagesAdded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_changed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PagesChanged { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PagesRemoved { get; set; }

        /// <summary>
        /// * `course` - course<br/>
        /// * `page` - page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LabelStudio.JsonConverters.CourseHistoryScopeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LabelStudio.CourseHistoryScopeEnum Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePreviewResponse" /> class.
        /// </summary>
        /// <param name="learnersWithProgressOnRemovedModules"></param>
        /// <param name="modulesAdded"></param>
        /// <param name="modulesRemoved"></param>
        /// <param name="pagesAdded"></param>
        /// <param name="pagesChanged"></param>
        /// <param name="pagesRemoved"></param>
        /// <param name="scope">
        /// * `course` - course<br/>
        /// * `page` - page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestorePreviewResponse(
            int learnersWithProgressOnRemovedModules,
            int modulesAdded,
            int modulesRemoved,
            int pagesAdded,
            int pagesChanged,
            int pagesRemoved,
            global::LabelStudio.CourseHistoryScopeEnum scope)
        {
            this.LearnersWithProgressOnRemovedModules = learnersWithProgressOnRemovedModules;
            this.ModulesAdded = modulesAdded;
            this.ModulesRemoved = modulesRemoved;
            this.PagesAdded = pagesAdded;
            this.PagesChanged = pagesChanged;
            this.PagesRemoved = pagesRemoved;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePreviewResponse" /> class.
        /// </summary>
        public RestorePreviewResponse()
        {
        }

    }
}