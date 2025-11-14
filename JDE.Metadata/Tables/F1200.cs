using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1200 - .
/// </summary>
public class F1200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LNSUPC.
        /// </summary>
        public const string LNSUPC = "LNSUPC";

        /// <summary>
        /// LNDPCC.
        /// </summary>
        public const string LNDPCC = "LNDPCC";
    }

    /// <inheritdoc />
    public override string TableName => "F1200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LNSUPC", "LNSUPC", JdeDataType.Numeric, null, true, true),
        new JdeField("LNDPCC", "LNDPCC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1200_0", "Primary Key on LNSUPC, LNDPCC", new[] { "LNSUPC", "LNDPCC" }, isUnique: true, isPrimaryKey: true)
    };
}
