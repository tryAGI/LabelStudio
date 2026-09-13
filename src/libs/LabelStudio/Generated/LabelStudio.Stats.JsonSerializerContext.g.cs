
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LabelStudio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>?), TypeInfoPropertyName = "ApiProjectsStatsTotalAgreementRetrieveResponseVariant2_34675e999e90b30b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementConfusionMatrix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DataQualityConfusionPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityConfusionPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DataQualityAgreementDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FilteredLabelDistributionUnavailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionCountsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionCountsTotals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionStructureDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionStructureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LabelDistributionStructureDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelDistributionValidationErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode), TypeInfoPropertyName = "ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable), TypeInfoPropertyName = "ApiProjectsStatsMemberPerformanceParticipantsListTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable), TypeInfoPropertyName = "ApiProjectsStatsMemberPerformanceRowsRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable), TypeInfoPropertyName = "ApiProjectsStatsMemberPerformanceSummaryRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.DataQualityAgreementDimensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsAgreementRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsModelStatsPredictionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsIaaRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>), TypeInfoPropertyName = "OneOfIListIListDoubleDictionaryStringIListIListDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>), TypeInfoPropertyName = "OneOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementAnnotatorRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsFinishedRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>), TypeInfoPropertyName = "OneOfApiProjectsStatsTotalAgreementRetrieveResponseVariant1ApiProjectsStatsTotalAgreementRetrieveResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsPredictionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsReviewScoreListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsPredictionRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUserStatsReviewScoreRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode?), TypeInfoPropertyName = "NullableApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable?), TypeInfoPropertyName = "NullableApiProjectsStatsMemberPerformanceParticipantsListTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable?), TypeInfoPropertyName = "NullableApiProjectsStatsMemberPerformanceRowsRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable?), TypeInfoPropertyName = "NullableApiProjectsStatsMemberPerformanceSummaryRetrieveTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>?), TypeInfoPropertyName = "NullableOneOfIListIListDoubleDictionaryStringIListIListDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>?), TypeInfoPropertyName = "NullableOneOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DataQualityConfusionPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionCountsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LabelDistributionStructureDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.DataQualityAgreementDimensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.UserSimple>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>))]
    internal sealed partial class StatsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StatsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StatsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StatsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, int?, float?, bool?, object, object>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::LabelStudio.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveMode?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsAnalyticsDataQualityAgreementAnalysisConfusionMatrixRetrieveModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceParticipantsListTableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceParticipantsListTable?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceParticipantsListTableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceRowsRetrieveTable?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceRowsRetrieveTableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsStatsMemberPerformanceSummaryRetrieveTable?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsStatsMemberPerformanceSummaryRetrieveTableNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new StatsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}