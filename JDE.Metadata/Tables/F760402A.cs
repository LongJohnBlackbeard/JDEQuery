using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760402A - .
/// </summary>
public class F760402A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K1CO.
        /// </summary>
        public const string K1CO = "K1CO";

        /// <summary>
        /// K1A002.
        /// </summary>
        public const string K1A002 = "K1A002";

        /// <summary>
        /// K1EFTJ.
        /// </summary>
        public const string K1EFTJ = "K1EFTJ";

        /// <summary>
        /// K1EFDJ.
        /// </summary>
        public const string K1EFDJ = "K1EFDJ";

        /// <summary>
        /// K1APR2.
        /// </summary>
        public const string K1APR2 = "K1APR2";

        /// <summary>
        /// K1AIM.
        /// </summary>
        public const string K1AIM = "K1AIM";

        /// <summary>
        /// K1ALGC.
        /// </summary>
        public const string K1ALGC = "K1ALGC";

        /// <summary>
        /// K1RP1.
        /// </summary>
        public const string K1RP1 = "K1RP1";
    }

    /// <inheritdoc />
    public override string TableName => "F760402A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K1CO", "K1CO", JdeDataType.String, 10, true, true),
        new JdeField("K1A002", "K1A002", JdeDataType.String, 6, true, true),
        new JdeField("K1EFTJ", "K1EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K1EFDJ", "K1EFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K1APR2", "K1APR2", JdeDataType.Numeric),
        new JdeField("K1AIM", "K1AIM", JdeDataType.Numeric),
        new JdeField("K1ALGC", "K1ALGC", JdeDataType.String, 6),
        new JdeField("K1RP1", "K1RP1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760402A_0", "Primary Key on K1CO, K1A002, K1EFTJ, K1EFDJ", new[] { "K1CO", "K1A002", "K1EFTJ", "K1EFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
