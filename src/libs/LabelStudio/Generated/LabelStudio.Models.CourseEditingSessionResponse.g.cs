
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CourseEditingSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession> Sessions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StructureVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSessionResponse" /> class.
        /// </summary>
        /// <param name="sessions"></param>
        /// <param name="structureVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CourseEditingSessionResponse(
            global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession> sessions,
            int structureVersion)
        {
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
            this.StructureVersion = structureVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourseEditingSessionResponse" /> class.
        /// </summary>
        public CourseEditingSessionResponse()
        {
        }

    }
}