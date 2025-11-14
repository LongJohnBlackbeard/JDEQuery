using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA24C - .
/// </summary>
public class F90CA24C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DADTAATID.
        /// </summary>
        public const string DADTAATID = "DADTAATID";

        /// <summary>
        /// DADTAILSEQ.
        /// </summary>
        public const string DADTAILSEQ = "DADTAILSEQ";

        /// <summary>
        /// DADTASUPDT.
        /// </summary>
        public const string DADTASUPDT = "DADTASUPDT";

        /// <summary>
        /// DAATCIDENT.
        /// </summary>
        public const string DAATCIDENT = "DAATCIDENT";

        /// <summary>
        /// DADTID.
        /// </summary>
        public const string DADTID = "DADTID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA24C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DADTAATID", "DADTAATID", JdeDataType.Numeric, null, true, true),
        new JdeField("DADTAILSEQ", "DADTAILSEQ", JdeDataType.Numeric),
        new JdeField("DADTASUPDT", "DADTASUPDT", JdeDataType.Numeric),
        new JdeField("DAATCIDENT", "DAATCIDENT", JdeDataType.Numeric),
        new JdeField("DADTID", "DADTID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA24C_0", "Primary Key on DADTAATID", new[] { "DADTAATID" }, isUnique: true, isPrimaryKey: true)
    };
}
