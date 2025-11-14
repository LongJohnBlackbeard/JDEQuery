using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04515OW - .
/// </summary>
public class F04515OW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G1APMM.
        /// </summary>
        public const string G1APMM = "G1APMM";

        /// <summary>
        /// G1LNID.
        /// </summary>
        public const string G1LNID = "G1LNID";
    }

    /// <inheritdoc />
    public override string TableName => "F04515OW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G1APMM", "G1APMM", JdeDataType.String, 1500),
        new JdeField("G1LNID", "G1LNID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04515OW_0", "Primary Key on G1LNID", new[] { "G1LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
