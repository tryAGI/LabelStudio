
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementMethodologyEnum), TypeInfoPropertyName = "AgreementMethodologyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum), TypeInfoPropertyName = "AnnotatorEvaluationMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LabelStudio.ControlTagWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ControlTagWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSamplingEnum), TypeInfoPropertyName = "ProjectSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkipQueueEnum), TypeInfoPropertyName = "SkipQueueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RejectActionEnum), TypeInfoPropertyName = "RejectActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelStreamTaskDistributionEnum), TypeInfoPropertyName = "LabelStreamTaskDistributionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CreateProjectFromTemplateRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectDmColumnDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectDmColumnDefaultsExplore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectDmColumnDefaultsLabeling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedProjectTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RequeueRejectedTasksModeEnum), TypeInfoPropertyName = "RequeueRejectedTasksModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewCriteriaEnum), TypeInfoPropertyName = "ReviewCriteriaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RejectActionEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsSamplingEnum), TypeInfoPropertyName = "ReviewSettingsSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AgreementMethodologyEnum?), TypeInfoPropertyName = "NullableAgreementMethodologyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?), TypeInfoPropertyName = "NullableAnnotatorEvaluationMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectSamplingEnum?), TypeInfoPropertyName = "NullableProjectSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SkipQueueEnum?), TypeInfoPropertyName = "NullableSkipQueueEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RejectActionEnum?), TypeInfoPropertyName = "NullableRejectActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?), TypeInfoPropertyName = "NullableLabelStreamTaskDistributionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?), TypeInfoPropertyName = "NullableRequeueRejectedTasksModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewCriteriaEnum?), TypeInfoPropertyName = "NullableReviewCriteriaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ReviewSettingsSamplingEnum?), TypeInfoPropertyName = "NullableReviewSettingsSamplingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RejectActionEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectTemplate>))]
    internal sealed partial class ProjectTemplatesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectTemplatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectTemplatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectTemplatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum)

                    || typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum?)

                    || typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum)

                    || typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?)

                    || typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum)

                    || typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum)

                    || typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RejectActionEnum)

                    || typeToConvert == typeof(global::LabelStudio.RejectActionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum)

                    || typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum)

                    || typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum)

                    || typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum?)

                    || typeToConvert == typeof(global::LabelStudio.SkipQueueEnum)

                    || typeToConvert == typeof(global::LabelStudio.SkipQueueEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum))
                {
                    return new global::LabelStudio.JsonConverters.AgreementMethodologyEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AgreementMethodologyEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AgreementMethodologyEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum))
                {
                    return new global::LabelStudio.JsonConverters.AnnotatorEvaluationMetricEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AnnotatorEvaluationMetricEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AnnotatorEvaluationMetricEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum))
                {
                    return new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.LabelStreamTaskDistributionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum))
                {
                    return new global::LabelStudio.JsonConverters.ProjectSamplingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ProjectSamplingEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ProjectSamplingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RejectActionEnum))
                {
                    return new global::LabelStudio.JsonConverters.RejectActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RejectActionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RejectActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum))
                {
                    return new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RequeueRejectedTasksModeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum))
                {
                    return new global::LabelStudio.JsonConverters.ReviewCriteriaEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewCriteriaEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ReviewCriteriaEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum))
                {
                    return new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ReviewSettingsSamplingEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.SkipQueueEnum))
                {
                    return new global::LabelStudio.JsonConverters.SkipQueueEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.SkipQueueEnum?))
                {
                    return new global::LabelStudio.JsonConverters.SkipQueueEnumNullableJsonConverter();
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
                    0 => new ProjectTemplatesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}