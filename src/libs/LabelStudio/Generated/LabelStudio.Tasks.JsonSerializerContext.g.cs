
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentTypeEnum), TypeInfoPropertyName = "AssignmentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkTaskAssigneesRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>), TypeInfoPropertyName = "OneOfBulkTaskAssigneesRequestRequestSelectedItemsAllFalseBulkTaskAssigneesRequestRequestSelectedItemsAllTrue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConjunctionEnum), TypeInfoPropertyName = "ConjunctionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotatorsDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewersDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseTaskSerializerForReviewersPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseTaskSerializerForReviewersPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedRoleBasedTaskList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.RoleBasedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RoleBasedTask), TypeInfoPropertyName = "RoleBasedTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedTaskAssigneesMutationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter), TypeInfoPropertyName = "PrepareParamsFiltersRequestItemChildFilterFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator), TypeInfoPropertyName = "PrepareParamsFiltersRequestItemChildFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>), TypeInfoPropertyName = "OneOfStringInt32SingleBooleanObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter), TypeInfoPropertyName = "PrepareParamsFiltersRequestItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator), TypeInfoPropertyName = "PrepareParamsFiltersRequestItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskAssigneesMutationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TaskAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType), TypeInfoPropertyName = "ApiProjectsTasksAssigneesDestroyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiTasksListFields), TypeInfoPropertyName = "ApiTasksListFields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesBulkCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.TaskAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignmentTypeEnum?), TypeInfoPropertyName = "NullableAssignmentTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>?), TypeInfoPropertyName = "NullableOneOfBulkTaskAssigneesRequestRequestSelectedItemsAllFalseBulkTaskAssigneesRequestRequestSelectedItemsAllTrue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConjunctionEnum?), TypeInfoPropertyName = "NullableConjunctionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RoleBasedTask?), TypeInfoPropertyName = "NullableRoleBasedTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemChildFilterFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemChildFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>?), TypeInfoPropertyName = "NullableOneOfStringInt32SingleBooleanObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType?), TypeInfoPropertyName = "NullableApiProjectsTasksAssigneesDestroyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiTasksListFields?), TypeInfoPropertyName = "NullableApiTasksListFields2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForAnnotatorsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseTaskSerializerForReviewersPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.RoleBasedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.TaskAssignment>))]
    internal sealed partial class TasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LabelStudio.JsonConverters.RoleBasedTaskJsonConverter());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllFalse, global::LabelStudio.BulkTaskAssigneesRequestRequestSelectedItemsAllTrue>());
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
                    typeToConvert == typeof(global::LabelStudio.AssignmentTypeEnum)

                    || typeToConvert == typeof(global::LabelStudio.AssignmentTypeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.ConjunctionEnum)

                    || typeToConvert == typeof(global::LabelStudio.ConjunctionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator?)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType)

                    || typeToConvert == typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType?)

                    || typeToConvert == typeof(global::LabelStudio.ApiTasksListFields)

                    || typeToConvert == typeof(global::LabelStudio.ApiTasksListFields?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.AssignmentTypeEnum))
                {
                    return new global::LabelStudio.JsonConverters.AssignmentTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignmentTypeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AssignmentTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ConjunctionEnum))
                {
                    return new global::LabelStudio.JsonConverters.ConjunctionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ConjunctionEnum?))
                {
                    return new global::LabelStudio.JsonConverters.ConjunctionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemChildFilterFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter?))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemChildFilterFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemChildFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator?))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemChildFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter?))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator?))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsFiltersRequestItemOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiProjectsTasksAssigneesDestroyType?))
                {
                    return new global::LabelStudio.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiTasksListFields))
                {
                    return new global::LabelStudio.JsonConverters.ApiTasksListFieldsJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiTasksListFields?))
                {
                    return new global::LabelStudio.JsonConverters.ApiTasksListFieldsNullableJsonConverter();
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
                    0 => new TasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}