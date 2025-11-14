using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3420 - .
/// </summary>
public class F3420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSVERS.
        /// </summary>
        public const string MSVERS = "MSVERS";

        /// <summary>
        /// MSMATH01.
        /// </summary>
        public const string MSMATH01 = "MSMATH01";
    }

    /// <inheritdoc />
    public override string TableName => "F3420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20, true, true),
        new JdeField("MSVERS", "MSVERS", JdeDataType.String, 20, true, true),
        new JdeField("MSMATH01", "MSMATH01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3420_0", "Primary Key on MSPID, MSVERS", new[] { "MSPID", "MSVERS" }, isUnique: true, isPrimaryKey: true)
    };
}
