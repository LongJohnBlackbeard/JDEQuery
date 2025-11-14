using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW49 - .
/// </summary>
public class FCW49 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDKIT.
        /// </summary>
        public const string BDKIT = "BDKIT";

        /// <summary>
        /// BDMMCU.
        /// </summary>
        public const string BDMMCU = "BDMMCU";

        /// <summary>
        /// BDTBM.
        /// </summary>
        public const string BDTBM = "BDTBM";

        /// <summary>
        /// BDBQTY.
        /// </summary>
        public const string BDBQTY = "BDBQTY";

        /// <summary>
        /// BDITM.
        /// </summary>
        public const string BDITM = "BDITM";

        /// <summary>
        /// BDC9LVNO.
        /// </summary>
        public const string BDC9LVNO = "BDC9LVNO";

        /// <summary>
        /// BDC9LVCO.
        /// </summary>
        public const string BDC9LVCO = "BDC9LVCO";

        /// <summary>
        /// BDCPNT.
        /// </summary>
        public const string BDCPNT = "BDCPNT";

        /// <summary>
        /// BDSBNT.
        /// </summary>
        public const string BDSBNT = "BDSBNT";

        /// <summary>
        /// BDCOBY.
        /// </summary>
        public const string BDCOBY = "BDCOBY";

        /// <summary>
        /// BDC9LVC0.
        /// </summary>
        public const string BDC9LVC0 = "BDC9LVC0";

        /// <summary>
        /// BDC9LVNO1.
        /// </summary>
        public const string BDC9LVNO1 = "BDC9LVNO1";

        /// <summary>
        /// BDC9LVCO1.
        /// </summary>
        public const string BDC9LVCO1 = "BDC9LVCO1";

        /// <summary>
        /// BDQNTY.
        /// </summary>
        public const string BDQNTY = "BDQNTY";

        /// <summary>
        /// BDCPNB.
        /// </summary>
        public const string BDCPNB = "BDCPNB";

        /// <summary>
        /// BDQTY.
        /// </summary>
        public const string BDQTY = "BDQTY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW49";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDKIT", "BDKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BDMMCU", "BDMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BDTBM", "BDTBM", JdeDataType.String, 6, true, true),
        new JdeField("BDBQTY", "BDBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BDITM", "BDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BDC9LVNO", "BDC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("BDC9LVCO", "BDC9LVCO", JdeDataType.String, 50, true, true),
        new JdeField("BDCPNT", "BDCPNT", JdeDataType.Numeric),
        new JdeField("BDSBNT", "BDSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("BDCOBY", "BDCOBY", JdeDataType.String, 2, true, true),
        new JdeField("BDC9LVC0", "BDC9LVC0", JdeDataType.String, 50),
        new JdeField("BDC9LVNO1", "BDC9LVNO1", JdeDataType.Numeric),
        new JdeField("BDC9LVCO1", "BDC9LVCO1", JdeDataType.String, 50),
        new JdeField("BDQNTY", "BDQNTY", JdeDataType.Numeric),
        new JdeField("BDCPNB", "BDCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BDQTY", "BDQTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW49_0", "Primary Key on BDKIT, BDMMCU, BDTBM, BDBQTY, BDITM, BDC9LVNO, BDC9LVCO, BDCPNB, BDSBNT, BDCOBY", new[] { "BDKIT", "BDMMCU", "BDTBM", "BDBQTY", "BDITM", "BDC9LVNO", "BDC9LVCO", "BDCPNB", "BDSBNT", "BDCOBY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW49_2", "Index on BDKIT, BDMMCU, BDTBM, BDBQTY, BDITM, BDC9LVCO, BDCPNB, BDSBNT, BDCOBY, BDC9LVC0, BDC9LVNO1", new[] { "BDKIT", "BDMMCU", "BDTBM", "BDBQTY", "BDITM", "BDC9LVCO", "BDCPNB", "BDSBNT", "BDCOBY", "BDC9LVC0", "BDC9LVNO1" }),
        new JdeIndex("FCW49_3", "Index on BDKIT, BDMMCU, BDTBM, BDBQTY, BDITM, BDCPNB, BDSBNT, BDCOBY, BDC9LVC0", new[] { "BDKIT", "BDMMCU", "BDTBM", "BDBQTY", "BDITM", "BDCPNB", "BDSBNT", "BDCOBY", "BDC9LVC0" }),
        new JdeIndex("FCW49_4", "Index on BDKIT, BDMMCU, BDTBM, BDBQTY, BDITM, BDCPNB, BDSBNT, BDCOBY", new[] { "BDKIT", "BDMMCU", "BDTBM", "BDBQTY", "BDITM", "BDCPNB", "BDSBNT", "BDCOBY" })
    };
}
