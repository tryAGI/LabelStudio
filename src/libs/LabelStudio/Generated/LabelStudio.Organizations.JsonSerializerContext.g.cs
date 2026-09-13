
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableOrganizationRoleEnum), TypeInfoPropertyName = "AssignableOrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableUserTypeEnum), TypeInfoPropertyName = "AssignableUserTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.BulkOrganizationMemberTagAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ConfigurablePermissionOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.AssignableOrganizationRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.DefaultRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationRoleEnum), TypeInfoPropertyName = "OrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OnboardingStateEnum), TypeInfoPropertyName = "OnboardingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TrialRoleEnum), TypeInfoPropertyName = "TrialRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberListContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseOrganizationMemberListCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RoleSourceEnum), TypeInfoPropertyName = "RoleSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SimpleOrganizationMemberTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberListContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.LseUserOrganizationMemberListCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MappingStatusEnum), TypeInfoPropertyName = "MappingStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberContributedToProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberCreatedProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberFilterRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberFilterSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum), TypeInfoPropertyName = "OrganizationMemberMembershipOptionKindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipProjectOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipProjectOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum), TypeInfoPropertyName = "OrganizationMemberMembershipProjectOptionKindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberSkillsOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagBulkCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum), TypeInfoPropertyName = "OrganizationMemberTagImportStatusStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermissionRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermissionRoleEnum), TypeInfoPropertyName = "OrganizationPermissionRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationRoleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedLseOrganizationMemberListList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.LseOrganizationMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedOrganizationMemberTagList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PaginatedSeatReportList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.SeatReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SeatReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedDefaultRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedLseOrganizationSerializerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationMemberCreateUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StandardUserTypeEnum), TypeInfoPropertyName = "StandardUserTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationMemberTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.PatchedOrganizationPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ProjectRoleAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RevokeInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationRoleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ProjectRoleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.WorkspaceAccessAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.WorkspaceAccessAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.SendInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsAssignmentsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsBulkDestroyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsBulkCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.ApiOrganizationsMemberTagsImportsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberMembershipOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationMemberSkillsOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.OrganizationPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LabelStudio.ConfigurablePermissionOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableOrganizationRoleEnum?), TypeInfoPropertyName = "NullableAssignableOrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.AssignableUserTypeEnum?), TypeInfoPropertyName = "NullableAssignableUserTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationRoleEnum?), TypeInfoPropertyName = "NullableOrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OnboardingStateEnum?), TypeInfoPropertyName = "NullableOnboardingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.TrialRoleEnum?), TypeInfoPropertyName = "NullableTrialRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.RoleSourceEnum?), TypeInfoPropertyName = "NullableRoleSourceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.MappingStatusEnum?), TypeInfoPropertyName = "NullableMappingStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum?), TypeInfoPropertyName = "NullableOrganizationMemberMembershipOptionKindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum?), TypeInfoPropertyName = "NullableOrganizationMemberMembershipProjectOptionKindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum?), TypeInfoPropertyName = "NullableOrganizationMemberTagImportStatusStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.OrganizationPermissionRoleEnum?), TypeInfoPropertyName = "NullableOrganizationPermissionRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LabelStudio.StandardUserTypeEnum?), TypeInfoPropertyName = "NullableStandardUserTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.AssignableOrganizationRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.SimpleOrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseUserOrganizationMemberListCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberContributedToProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberCreatedProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipProjectOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermissionRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.LseOrganizationMemberList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.SeatReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationRoleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ProjectRoleAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.WorkspaceAccessAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberMembershipOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationMemberSkillsOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.OrganizationPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LabelStudio.ConfigurablePermissionOption>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum?)

                    || typeToConvert == typeof(global::LabelStudio.AssignableUserTypeEnum)

                    || typeToConvert == typeof(global::LabelStudio.AssignableUserTypeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.MappingStatusEnum)

                    || typeToConvert == typeof(global::LabelStudio.MappingStatusEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum)

                    || typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationPermissionRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationPermissionRoleEnum?)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.OrganizationRoleEnum?)

                    || typeToConvert == typeof(global::LabelStudio.RoleSourceEnum)

                    || typeToConvert == typeof(global::LabelStudio.RoleSourceEnum?)

                    || typeToConvert == typeof(global::LabelStudio.StandardUserTypeEnum)

                    || typeToConvert == typeof(global::LabelStudio.StandardUserTypeEnum?)

                    || typeToConvert == typeof(global::LabelStudio.TrialRoleEnum)

                    || typeToConvert == typeof(global::LabelStudio.TrialRoleEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignableOrganizationRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AssignableOrganizationRoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignableUserTypeEnum))
                {
                    return new global::LabelStudio.JsonConverters.AssignableUserTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.AssignableUserTypeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.AssignableUserTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.MappingStatusEnum))
                {
                    return new global::LabelStudio.JsonConverters.MappingStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.MappingStatusEnum?))
                {
                    return new global::LabelStudio.JsonConverters.MappingStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum))
                {
                    return new global::LabelStudio.JsonConverters.OnboardingStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OnboardingStateEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OnboardingStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberMembershipOptionKindEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipOptionKindEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberMembershipOptionKindEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberMembershipProjectOptionKindEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberMembershipProjectOptionKindEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberMembershipProjectOptionKindEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationMemberTagImportStatusStatusEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationPermissionRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationPermissionRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationPermissionRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationPermissionRoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.OrganizationRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.OrganizationRoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RoleSourceEnum))
                {
                    return new global::LabelStudio.JsonConverters.RoleSourceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.RoleSourceEnum?))
                {
                    return new global::LabelStudio.JsonConverters.RoleSourceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.StandardUserTypeEnum))
                {
                    return new global::LabelStudio.JsonConverters.StandardUserTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.StandardUserTypeEnum?))
                {
                    return new global::LabelStudio.JsonConverters.StandardUserTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.TrialRoleEnum))
                {
                    return new global::LabelStudio.JsonConverters.TrialRoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LabelStudio.TrialRoleEnum?))
                {
                    return new global::LabelStudio.JsonConverters.TrialRoleEnumNullableJsonConverter();
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}