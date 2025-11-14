using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760403A - .
/// </summary>
public class F760403A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K3CO.
        /// </summary>
        public const string K3CO = "K3CO";

        /// <summary>
        /// K3A004.
        /// </summary>
        public const string K3A004 = "K3A004";

        /// <summary>
        /// K3EFDJ.
        /// </summary>
        public const string K3EFDJ = "K3EFDJ";

        /// <summary>
        /// K3AIM.
        /// </summary>
        public const string K3AIM = "K3AIM";

        /// <summary>
        /// K3ARMN.
        /// </summary>
        public const string K3ARMN = "K3ARMN";

        /// <summary>
        /// K3A4CT.
        /// </summary>
        public const string K3A4CT = "K3A4CT";

        /// <summary>
        /// K3APR1.
        /// </summary>
        public const string K3APR1 = "K3APR1";

        /// <summary>
        /// K3APR2.
        /// </summary>
        public const string K3APR2 = "K3APR2";

        /// <summary>
        /// K3ALGC.
        /// </summary>
        public const string K3ALGC = "K3ALGC";

        /// <summary>
        /// K3RP1.
        /// </summary>
        public const string K3RP1 = "K3RP1";

        /// <summary>
        /// K3ARM1.
        /// </summary>
        public const string K3ARM1 = "K3ARM1";

        /// <summary>
        /// K3AIM1.
        /// </summary>
        public const string K3AIM1 = "K3AIM1";

        /// <summary>
        /// K3APR3.
        /// </summary>
        public const string K3APR3 = "K3APR3";

        /// <summary>
        /// K3FNUMB8.
        /// </summary>
        public const string K3FNUMB8 = "K3FNUMB8";

        /// <summary>
        /// K3FNUMB9.
        /// </summary>
        public const string K3FNUMB9 = "K3FNUMB9";

        /// <summary>
        /// K3FNUMB10.
        /// </summary>
        public const string K3FNUMB10 = "K3FNUMB10";

        /// <summary>
        /// K3FNUMB11.
        /// </summary>
        public const string K3FNUMB11 = "K3FNUMB11";

        /// <summary>
        /// K3FSTRN8.
        /// </summary>
        public const string K3FSTRN8 = "K3FSTRN8";

        /// <summary>
        /// K3FSTRN9.
        /// </summary>
        public const string K3FSTRN9 = "K3FSTRN9";

        /// <summary>
        /// K3FSTRN10.
        /// </summary>
        public const string K3FSTRN10 = "K3FSTRN10";

        /// <summary>
        /// K3FSTRN11.
        /// </summary>
        public const string K3FSTRN11 = "K3FSTRN11";
    }

    /// <inheritdoc />
    public override string TableName => "F760403A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K3CO", "K3CO", JdeDataType.String, 10, true, true),
        new JdeField("K3A004", "K3A004", JdeDataType.String, 6, true, true),
        new JdeField("K3EFDJ", "K3EFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K3AIM", "K3AIM", JdeDataType.Numeric),
        new JdeField("K3ARMN", "K3ARMN", JdeDataType.Numeric),
        new JdeField("K3A4CT", "K3A4CT", JdeDataType.String, 2),
        new JdeField("K3APR1", "K3APR1", JdeDataType.Numeric),
        new JdeField("K3APR2", "K3APR2", JdeDataType.Numeric),
        new JdeField("K3ALGC", "K3ALGC", JdeDataType.String, 6),
        new JdeField("K3RP1", "K3RP1", JdeDataType.String, 2),
        new JdeField("K3ARM1", "K3ARM1", JdeDataType.Numeric),
        new JdeField("K3AIM1", "K3AIM1", JdeDataType.Numeric),
        new JdeField("K3APR3", "K3APR3", JdeDataType.Numeric),
        new JdeField("K3FNUMB8", "K3FNUMB8", JdeDataType.Numeric),
        new JdeField("K3FNUMB9", "K3FNUMB9", JdeDataType.Numeric),
        new JdeField("K3FNUMB10", "K3FNUMB10", JdeDataType.Numeric),
        new JdeField("K3FNUMB11", "K3FNUMB11", JdeDataType.Numeric),
        new JdeField("K3FSTRN8", "K3FSTRN8", JdeDataType.String, 50),
        new JdeField("K3FSTRN9", "K3FSTRN9", JdeDataType.String, 50),
        new JdeField("K3FSTRN10", "K3FSTRN10", JdeDataType.String, 50),
        new JdeField("K3FSTRN11", "K3FSTRN11", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760403A_0", "Primary Key on K3CO, K3A004, K3EFDJ", new[] { "K3CO", "K3A004", "K3EFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
