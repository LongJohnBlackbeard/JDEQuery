using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760405A - .
/// </summary>
public class F760405A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K7CO.
        /// </summary>
        public const string K7CO = "K7CO";

        /// <summary>
        /// K7A007.
        /// </summary>
        public const string K7A007 = "K7A007";

        /// <summary>
        /// K7EFTJ.
        /// </summary>
        public const string K7EFTJ = "K7EFTJ";

        /// <summary>
        /// K7EFDJ.
        /// </summary>
        public const string K7EFDJ = "K7EFDJ";

        /// <summary>
        /// K7APR2.
        /// </summary>
        public const string K7APR2 = "K7APR2";

        /// <summary>
        /// K7AIM.
        /// </summary>
        public const string K7AIM = "K7AIM";

        /// <summary>
        /// K7ABI.
        /// </summary>
        public const string K7ABI = "K7ABI";

        /// <summary>
        /// K7ALGC.
        /// </summary>
        public const string K7ALGC = "K7ALGC";

        /// <summary>
        /// K7RP1.
        /// </summary>
        public const string K7RP1 = "K7RP1";
    }

    /// <inheritdoc />
    public override string TableName => "F760405A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K7CO", "K7CO", JdeDataType.String, 10, true, true),
        new JdeField("K7A007", "K7A007", JdeDataType.String, 6, true, true),
        new JdeField("K7EFTJ", "K7EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K7EFDJ", "K7EFDJ", JdeDataType.Numeric),
        new JdeField("K7APR2", "K7APR2", JdeDataType.Numeric),
        new JdeField("K7AIM", "K7AIM", JdeDataType.Numeric),
        new JdeField("K7ABI", "K7ABI", JdeDataType.String, 2),
        new JdeField("K7ALGC", "K7ALGC", JdeDataType.String, 6),
        new JdeField("K7RP1", "K7RP1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760405A_0", "Primary Key on K7CO, K7A007, K7EFTJ", new[] { "K7CO", "K7A007", "K7EFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
