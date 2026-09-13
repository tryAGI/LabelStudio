
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserSimple))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkProjectLearningAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkResetCourseProgressRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseEditingSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseEditingSessionHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseEditingSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.CourseEditingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseModule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseOutline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlineModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseOutlineModule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.CourseOutlinePage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseOutlinePage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CoursePageSaveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseProgressImportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseStructureOpRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OpEnum), TypeInfoPropertyName = "OpEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.CourseStructureOpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.CourseModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DuplicateLearningResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.EstimatedDurationUnitEnum), TypeInfoPropertyName = "EstimatedDurationUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningProgressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningProgressUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceAssignmentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserLearningProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceCountsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceCountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceCountsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LearningResourceUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedCertificateList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Certificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedCourseModuleList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLearningResourceListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LearningResourceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedUserLearningProgressListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.UserLearningProgressList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.UserLearningProgressList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedCoursePageUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLearningResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLearningResourceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedProjectLearningAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLearningAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectLearningAssignmentCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PublishLearningResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RetakeScopeEnum), TypeInfoPropertyName = "RetakeScopeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RetakeReasonEnum), TypeInfoPropertyName = "RetakeReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RevokeCertificateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiLearningResourcesUserProgressImportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiLearningResourcesUserProgressBulkResetCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectLearningAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OpEnum?), TypeInfoPropertyName = "NullableOpEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.EstimatedDurationUnitEnum?), TypeInfoPropertyName = "NullableEstimatedDurationUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RetakeScopeEnum?), TypeInfoPropertyName = "NullableRetakeScopeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RetakeReasonEnum?), TypeInfoPropertyName = "NullableRetakeReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.CourseEditingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.CourseOutlineModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.CourseOutlinePage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.CourseModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LearningResourceCountsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Certificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LearningResourceList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.UserLearningProgressList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectLearningAssignment>))]
    internal sealed partial class LearningResourcesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LearningResourcesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LearningResourcesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LearningResourcesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LabelStudio.EstimatedDurationUnitEnum)

                    || typeToConvert == typeof(global::LabelStudio.EstimatedDurationUnitEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OpEnum)

                    || typeToConvert == typeof(global::LabelStudio.OpEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RetakeReasonEnum)

                    || typeToConvert == typeof(global::LabelStudio.RetakeReasonEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RetakeScopeEnum)

                    || typeToConvert == typeof(global::LabelStudio.RetakeScopeEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.EstimatedDurationUnitEnum))
                {
                    return new global::LabelStudio.JsonConverters.EstimatedDurationUnitEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.EstimatedDurationUnitEnum?))
                {
                    return new global::LabelStudio.JsonConverters.EstimatedDurationUnitEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OpEnum))
                {
                    return new global::LabelStudio.JsonConverters.OpEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OpEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OpEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RetakeReasonEnum))
                {
                    return new global::LabelStudio.JsonConverters.RetakeReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RetakeReasonEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RetakeReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RetakeScopeEnum))
                {
                    return new global::LabelStudio.JsonConverters.RetakeScopeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RetakeScopeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RetakeScopeEnumNullableJsonConverter();
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
                    0 => new LearningResourcesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}