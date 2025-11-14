using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760410A - .
/// </summary>
public class F760410A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K0CO.
        /// </summary>
        public const string K0CO = "K0CO";

        /// <summary>
        /// K0A011.
        /// </summary>
        public const string K0A011 = "K0A011";

        /// <summary>
        /// K0A009.
        /// </summary>
        public const string K0A009 = "K0A009";

        /// <summary>
        /// K0EFTJ.
        /// </summary>
        public const string K0EFTJ = "K0EFTJ";

        /// <summary>
        /// K0EFDJ.
        /// </summary>
        public const string K0EFDJ = "K0EFDJ";

        /// <summary>
        /// K0APR2.
        /// </summary>
        public const string K0APR2 = "K0APR2";

        /// <summary>
        /// K0AIM.
        /// </summary>
        public const string K0AIM = "K0AIM";

        /// <summary>
        /// K0ABI.
        /// </summary>
        public const string K0ABI = "K0ABI";

        /// <summary>
        /// K0ALGC.
        /// </summary>
        public const string K0ALGC = "K0ALGC";

        /// <summary>
        /// K0RP1.
        /// </summary>
        public const string K0RP1 = "K0RP1";
    }

    /// <inheritdoc />
    public override string TableName => "F760410A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K0CO", "K0CO", JdeDataType.String, 10, true, true),
        new JdeField("K0A011", "K0A011", JdeDataType.String, 6, true, true),
        new JdeField("K0A009", "K0A009", JdeDataType.String, 6, true, true),
        new JdeField("K0EFTJ", "K0EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K0EFDJ", "K0EFDJ", JdeDataType.Numeric),
        new JdeField("K0APR2", "K0APR2", JdeDataType.Numeric),
        new JdeField("K0AIM", "K0AIM", JdeDataType.Numeric),
        new JdeField("K0ABI", "K0ABI", JdeDataType.String, 2),
        new JdeField("K0ALGC", "K0ALGC", JdeDataType.String, 6),
        new JdeField("K0RP1", "K0RP1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760410A_0", "Primary Key on K0CO, K0A011, K0A009, K0EFTJ", new[] { "K0CO", "K0A011", "K0A009", "K0EFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
