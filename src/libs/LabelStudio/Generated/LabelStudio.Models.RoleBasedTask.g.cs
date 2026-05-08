#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RoleBasedTask : global::System.IEquatable<RoleBasedTask>
    {
        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LabelStudio.LseTask? Lse { get; init; }
#else
        public global::LabelStudio.LseTask? Lse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lse))]
#endif
        public bool IsLse => Lse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LabelStudio.LseTask? value)
        {
            value = Lse;
            return IsLse;
        }

        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LabelStudio.LseTaskSerializerForReviewers? LseSerializerForReviewers { get; init; }
#else
        public global::LabelStudio.LseTaskSerializerForReviewers? LseSerializerForReviewers { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LseSerializerForReviewers))]
#endif
        public bool IsLseSerializerForReviewers => LseSerializerForReviewers != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLseSerializerForReviewers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LabelStudio.LseTaskSerializerForReviewers? value)
        {
            value = LseSerializerForReviewers;
            return IsLseSerializerForReviewers;
        }

        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LabelStudio.LseTaskSerializerForAnnotators? LseSerializerForAnnotators { get; init; }
#else
        public global::LabelStudio.LseTaskSerializerForAnnotators? LseSerializerForAnnotators { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LseSerializerForAnnotators))]
#endif
        public bool IsLseSerializerForAnnotators => LseSerializerForAnnotators != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLseSerializerForAnnotators(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LabelStudio.LseTaskSerializerForAnnotators? value)
        {
            value = LseSerializerForAnnotators;
            return IsLseSerializerForAnnotators;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::LabelStudio.LseTask value) => new RoleBasedTask((global::LabelStudio.LseTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LabelStudio.LseTask?(RoleBasedTask @this) => @this.Lse;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::LabelStudio.LseTask? value)
        {
            Lse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::LabelStudio.LseTaskSerializerForReviewers value) => new RoleBasedTask((global::LabelStudio.LseTaskSerializerForReviewers?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LabelStudio.LseTaskSerializerForReviewers?(RoleBasedTask @this) => @this.LseSerializerForReviewers;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::LabelStudio.LseTaskSerializerForReviewers? value)
        {
            LseSerializerForReviewers = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::LabelStudio.LseTaskSerializerForAnnotators value) => new RoleBasedTask((global::LabelStudio.LseTaskSerializerForAnnotators?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LabelStudio.LseTaskSerializerForAnnotators?(RoleBasedTask @this) => @this.LseSerializerForAnnotators;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::LabelStudio.LseTaskSerializerForAnnotators? value)
        {
            LseSerializerForAnnotators = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(
            global::LabelStudio.LseTask? lse,
            global::LabelStudio.LseTaskSerializerForReviewers? lseSerializerForReviewers,
            global::LabelStudio.LseTaskSerializerForAnnotators? lseSerializerForAnnotators
            )
        {
            Lse = lse;
            LseSerializerForReviewers = lseSerializerForReviewers;
            LseSerializerForAnnotators = lseSerializerForAnnotators;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LseSerializerForAnnotators as object ??
            LseSerializerForReviewers as object ??
            Lse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lse?.ToString() ??
            LseSerializerForReviewers?.ToString() ??
            LseSerializerForAnnotators?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLse && !IsLseSerializerForReviewers && !IsLseSerializerForAnnotators || !IsLse && IsLseSerializerForReviewers && !IsLseSerializerForAnnotators || !IsLse && !IsLseSerializerForReviewers && IsLseSerializerForAnnotators;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LabelStudio.LseTask, TResult>? lse = null,
            global::System.Func<global::LabelStudio.LseTaskSerializerForReviewers, TResult>? lseSerializerForReviewers = null,
            global::System.Func<global::LabelStudio.LseTaskSerializerForAnnotators, TResult>? lseSerializerForAnnotators = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLse && lse != null)
            {
                return lse(Lse!);
            }
            else if (IsLseSerializerForReviewers && lseSerializerForReviewers != null)
            {
                return lseSerializerForReviewers(LseSerializerForReviewers!);
            }
            else if (IsLseSerializerForAnnotators && lseSerializerForAnnotators != null)
            {
                return lseSerializerForAnnotators(LseSerializerForAnnotators!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LabelStudio.LseTask>? lse = null,

            global::System.Action<global::LabelStudio.LseTaskSerializerForReviewers>? lseSerializerForReviewers = null,

            global::System.Action<global::LabelStudio.LseTaskSerializerForAnnotators>? lseSerializerForAnnotators = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLse)
            {
                lse?.Invoke(Lse!);
            }
            else if (IsLseSerializerForReviewers)
            {
                lseSerializerForReviewers?.Invoke(LseSerializerForReviewers!);
            }
            else if (IsLseSerializerForAnnotators)
            {
                lseSerializerForAnnotators?.Invoke(LseSerializerForAnnotators!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LabelStudio.LseTask>? lse = null,
            global::System.Action<global::LabelStudio.LseTaskSerializerForReviewers>? lseSerializerForReviewers = null,
            global::System.Action<global::LabelStudio.LseTaskSerializerForAnnotators>? lseSerializerForAnnotators = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLse)
            {
                lse?.Invoke(Lse!);
            }
            else if (IsLseSerializerForReviewers)
            {
                lseSerializerForReviewers?.Invoke(LseSerializerForReviewers!);
            }
            else if (IsLseSerializerForAnnotators)
            {
                lseSerializerForAnnotators?.Invoke(LseSerializerForAnnotators!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lse,
                typeof(global::LabelStudio.LseTask),
                LseSerializerForReviewers,
                typeof(global::LabelStudio.LseTaskSerializerForReviewers),
                LseSerializerForAnnotators,
                typeof(global::LabelStudio.LseTaskSerializerForAnnotators),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RoleBasedTask other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LabelStudio.LseTask?>.Default.Equals(Lse, other.Lse) &&
                global::System.Collections.Generic.EqualityComparer<global::LabelStudio.LseTaskSerializerForReviewers?>.Default.Equals(LseSerializerForReviewers, other.LseSerializerForReviewers) &&
                global::System.Collections.Generic.EqualityComparer<global::LabelStudio.LseTaskSerializerForAnnotators?>.Default.Equals(LseSerializerForAnnotators, other.LseSerializerForAnnotators) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RoleBasedTask obj1, RoleBasedTask obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RoleBasedTask>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RoleBasedTask obj1, RoleBasedTask obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RoleBasedTask o && Equals(o);
        }
    }
}
