using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760404A - .
/// </summary>
public class F760404A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K5CO.
        /// </summary>
        public const string K5CO = "K5CO";

        /// <summary>
        /// K5A004.
        /// </summary>
        public const string K5A004 = "K5A004";

        /// <summary>
        /// K5EFDJ.
        /// </summary>
        public const string K5EFDJ = "K5EFDJ";

        /// <summary>
        /// K5ALSP.
        /// </summary>
        public const string K5ALSP = "K5ALSP";

        /// <summary>
        /// K5AIBS.
        /// </summary>
        public const string K5AIBS = "K5AIBS";

        /// <summary>
        /// K5AEXC.
        /// </summary>
        public const string K5AEXC = "K5AEXC";

        /// <summary>
        /// K5APR1.
        /// </summary>
        public const string K5APR1 = "K5APR1";
    }

    /// <inheritdoc />
    public override string TableName => "F760404A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K5CO", "K5CO", JdeDataType.String, 10, true, true),
        new JdeField("K5A004", "K5A004", JdeDataType.String, 6, true, true),
        new JdeField("K5EFDJ", "K5EFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K5ALSP", "K5ALSP", JdeDataType.Numeric, null, true, true),
        new JdeField("K5AIBS", "K5AIBS", JdeDataType.Numeric),
        new JdeField("K5AEXC", "K5AEXC", JdeDataType.Numeric),
        new JdeField("K5APR1", "K5APR1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760404A_0", "Primary Key on K5CO, K5A004, K5ALSP, K5EFDJ", new[] { "K5CO", "K5A004", "K5ALSP", "K5EFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
