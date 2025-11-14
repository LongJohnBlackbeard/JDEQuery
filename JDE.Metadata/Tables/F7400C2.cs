using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400C2 - .
/// </summary>
public class F7400C2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPUKID.
        /// </summary>
        public const string DPUKID = "DPUKID";

        /// <summary>
        /// DPTAXA.
        /// </summary>
        public const string DPTAXA = "DPTAXA";

        /// <summary>
        /// DPATXA.
        /// </summary>
        public const string DPATXA = "DPATXA";

        /// <summary>
        /// DPTXA1.
        /// </summary>
        public const string DPTXA1 = "DPTXA1";
    }

    /// <inheritdoc />
    public override string TableName => "F7400C2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPUKID", "DPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DPTAXA", "DPTAXA", JdeDataType.String, 60, true, true),
        new JdeField("DPATXA", "DPATXA", JdeDataType.Numeric),
        new JdeField("DPTXA1", "DPTXA1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400C2_0", "Primary Key on DPUKID, DPTAXA", new[] { "DPUKID", "DPTAXA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7400C2_12", "Index on DPTAXA", new[] { "DPTAXA" })
    };
}
