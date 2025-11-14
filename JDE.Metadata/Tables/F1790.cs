using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1790 - .
/// </summary>
public class F1790 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMPRODF.
        /// </summary>
        public const string PMPRODF = "PMPRODF";

        /// <summary>
        /// PMPRODM.
        /// </summary>
        public const string PMPRODM = "PMPRODM";

        /// <summary>
        /// PMMCUZ.
        /// </summary>
        public const string PMMCUZ = "PMMCUZ";

        /// <summary>
        /// PMCRTU.
        /// </summary>
        public const string PMCRTU = "PMCRTU";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMUPMT.
        /// </summary>
        public const string PMUPMT = "PMUPMT";

        /// <summary>
        /// PMKIT.
        /// </summary>
        public const string PMKIT = "PMKIT";

        /// <summary>
        /// PMMMCU.
        /// </summary>
        public const string PMMMCU = "PMMMCU";

        /// <summary>
        /// PMTBM.
        /// </summary>
        public const string PMTBM = "PMTBM";

        /// <summary>
        /// PMBQTY.
        /// </summary>
        public const string PMBQTY = "PMBQTY";

        /// <summary>
        /// PMCPNT.
        /// </summary>
        public const string PMCPNT = "PMCPNT";

        /// <summary>
        /// PMSBNT.
        /// </summary>
        public const string PMSBNT = "PMSBNT";

        /// <summary>
        /// PMCOBY.
        /// </summary>
        public const string PMCOBY = "PMCOBY";
    }

    /// <inheritdoc />
    public override string TableName => "F1790";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMPRODF", "PMPRODF", JdeDataType.String, 16),
        new JdeField("PMPRODM", "PMPRODM", JdeDataType.String, 16, true, true),
        new JdeField("PMMCUZ", "PMMCUZ", JdeDataType.String, 24),
        new JdeField("PMCRTU", "PMCRTU", JdeDataType.String, 20),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMUPMT", "PMUPMT", JdeDataType.Numeric),
        new JdeField("PMKIT", "PMKIT", JdeDataType.Numeric),
        new JdeField("PMMMCU", "PMMMCU", JdeDataType.String, 24),
        new JdeField("PMTBM", "PMTBM", JdeDataType.String, 6),
        new JdeField("PMBQTY", "PMBQTY", JdeDataType.Numeric),
        new JdeField("PMCPNT", "PMCPNT", JdeDataType.Numeric),
        new JdeField("PMSBNT", "PMSBNT", JdeDataType.Numeric),
        new JdeField("PMCOBY", "PMCOBY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1790_0", "Primary Key on PMPRODM", new[] { "PMPRODM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1790_1", "Index on PMPRODF, PMPRODM", new[] { "PMPRODF", "PMPRODM" })
    };
}
