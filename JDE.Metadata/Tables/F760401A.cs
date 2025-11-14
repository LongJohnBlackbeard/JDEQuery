using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760401A - .
/// </summary>
public class F760401A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K2CO.
        /// </summary>
        public const string K2CO = "K2CO";

        /// <summary>
        /// K2A005.
        /// </summary>
        public const string K2A005 = "K2A005";

        /// <summary>
        /// K2A009.
        /// </summary>
        public const string K2A009 = "K2A009";

        /// <summary>
        /// K2A001.
        /// </summary>
        public const string K2A001 = "K2A001";

        /// <summary>
        /// K2EFTJ.
        /// </summary>
        public const string K2EFTJ = "K2EFTJ";

        /// <summary>
        /// K2EFDJ.
        /// </summary>
        public const string K2EFDJ = "K2EFDJ";

        /// <summary>
        /// K2APR2.
        /// </summary>
        public const string K2APR2 = "K2APR2";

        /// <summary>
        /// K2AIM.
        /// </summary>
        public const string K2AIM = "K2AIM";

        /// <summary>
        /// K2ABCN.
        /// </summary>
        public const string K2ABCN = "K2ABCN";

        /// <summary>
        /// K2ABI.
        /// </summary>
        public const string K2ABI = "K2ABI";

        /// <summary>
        /// K2APR1.
        /// </summary>
        public const string K2APR1 = "K2APR1";

        /// <summary>
        /// K2ALGC.
        /// </summary>
        public const string K2ALGC = "K2ALGC";
    }

    /// <inheritdoc />
    public override string TableName => "F760401A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K2CO", "K2CO", JdeDataType.String, 10, true, true),
        new JdeField("K2A005", "K2A005", JdeDataType.String, 6, true, true),
        new JdeField("K2A009", "K2A009", JdeDataType.String, 6, true, true),
        new JdeField("K2A001", "K2A001", JdeDataType.String, 6, true, true),
        new JdeField("K2EFTJ", "K2EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K2EFDJ", "K2EFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K2APR2", "K2APR2", JdeDataType.Numeric),
        new JdeField("K2AIM", "K2AIM", JdeDataType.Numeric),
        new JdeField("K2ABCN", "K2ABCN", JdeDataType.String, 2),
        new JdeField("K2ABI", "K2ABI", JdeDataType.String, 2),
        new JdeField("K2APR1", "K2APR1", JdeDataType.Numeric),
        new JdeField("K2ALGC", "K2ALGC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760401A_0", "Primary Key on K2CO, K2A005, K2A009, K2A001, K2EFTJ, K2EFDJ", new[] { "K2CO", "K2A005", "K2A009", "K2A001", "K2EFTJ", "K2EFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
