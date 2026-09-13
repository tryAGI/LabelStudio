
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ChildFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConjunctionEnum), TypeInfoPropertyName = "ConjunctionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.FilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.Filter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ChildFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.Filter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseProjectStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedViewRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ViewDataRequestRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.PrepareParamsOrderingRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsOrderingRequestItem), TypeInfoPropertyName = "PrepareParamsOrderingRequestItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>), TypeInfoPropertyName = "OneOfPrepareParamsRequestRequestSelectedItemsAllFalsePrepareParamsRequestRequestSelectedItemsAllTrue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.View))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ViewLockedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ViewOrderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ViewRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateId), TypeInfoPropertyName = "ApiDmActionsCreateId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ApiDmActionsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsRetrieveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsRetrieveResponseItemDialog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.View>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConjunctionEnum?), TypeInfoPropertyName = "NullableConjunctionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemChildFilterFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemChildFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, int?, float?, bool?, object, object>?), TypeInfoPropertyName = "NullableOneOfStringInt32SingleBooleanObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator?), TypeInfoPropertyName = "NullablePrepareParamsFiltersRequestItemOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PrepareParamsOrderingRequestItem?), TypeInfoPropertyName = "NullablePrepareParamsOrderingRequestItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>?), TypeInfoPropertyName = "NullableOneOfPrepareParamsRequestRequestSelectedItemsAllFalsePrepareParamsRequestRequestSelectedItemsAllTrue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiDmActionsCreateId?), TypeInfoPropertyName = "NullableApiDmActionsCreateId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ChildFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.Filter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsFiltersRequestItemChildFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.PrepareParamsOrderingRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ApiDmActionsRetrieveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.View>))]
    internal sealed partial class DataManagerSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataManagerSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DataManagerSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DataManagerSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LabelStudio.JsonConverters.OneOfJsonConverter<global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllFalse, global::LabelStudio.PrepareParamsRequestRequestSelectedItemsAllTrue>());
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
                    typeToConvert == typeof(global::LabelStudio.ConjunctionEnum)

                    || typeToConvert == typeof(global::LabelStudio.ConjunctionEnum?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterFilter?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemChildFilterOperator?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemFilter?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsFiltersRequestItemOperator?)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsOrderingRequestItem)

                    || typeToConvert == typeof(global::LabelStudio.PrepareParamsOrderingRequestItem?)

                    || typeToConvert == typeof(global::LabelStudio.ApiDmActionsCreateId)

                    || typeToConvert == typeof(global::LabelStudio.ApiDmActionsCreateId?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsOrderingRequestItem))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsOrderingRequestItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.PrepareParamsOrderingRequestItem?))
                {
                    return new global::LabelStudio.JsonConverters.PrepareParamsOrderingRequestItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiDmActionsCreateId))
                {
                    return new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.ApiDmActionsCreateId?))
                {
                    return new global::LabelStudio.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter();
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
                    0 => new DataManagerSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}