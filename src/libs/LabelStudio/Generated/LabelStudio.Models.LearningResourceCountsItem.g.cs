
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LearningResourceCountsItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learner_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearnerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_completed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearnersCompletedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learners_started_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearnersStartedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceCountsItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="learnerCount"></param>
        /// <param name="learnersCompletedCount"></param>
        /// <param name="learnersStartedCount"></param>
        /// <param name="pageCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LearningResourceCountsItem(
            int id,
            int learnerCount,
            int learnersCompletedCount,
            int learnersStartedCount,
            int pageCount)
        {
            this.Id = id;
            this.LearnerCount = learnerCount;
            this.LearnersCompletedCount = learnersCompletedCount;
            this.LearnersStartedCount = learnersStartedCount;
            this.PageCount = pageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningResourceCountsItem" /> class.
        /// </summary>
        public LearningResourceCountsItem()
        {
        }

    }
}