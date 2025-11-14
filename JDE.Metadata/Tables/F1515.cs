using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1515 - .
/// </summary>
public class F1515 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCAPID.
        /// </summary>
        public const string CHCAPID = "CHCAPID";

        /// <summary>
        /// CHDL01.
        /// </summary>
        public const string CHDL01 = "CHDL01";

        /// <summary>
        /// CHCAPTYPE.
        /// </summary>
        public const string CHCAPTYPE = "CHCAPTYPE";

        /// <summary>
        /// CHCAPPCT.
        /// </summary>
        public const string CHCAPPCT = "CHCAPPCT";

        /// <summary>
        /// CHCAPOP.
        /// </summary>
        public const string CHCAPOP = "CHCAPOP";

        /// <summary>
        /// CHCAPOP1.
        /// </summary>
        public const string CHCAPOP1 = "CHCAPOP1";

        /// <summary>
        /// CHCAPOP2.
        /// </summary>
        public const string CHCAPOP2 = "CHCAPOP2";

        /// <summary>
        /// CHCAPIDX.
        /// </summary>
        public const string CHCAPIDX = "CHCAPIDX";

        /// <summary>
        /// CHCIDXMT.
        /// </summary>
        public const string CHCIDXMT = "CHCIDXMT";

        /// <summary>
        /// CHCIDXYR.
        /// </summary>
        public const string CHCIDXYR = "CHCIDXYR";

        /// <summary>
        /// CHCAPROLL.
        /// </summary>
        public const string CHCAPROLL = "CHCAPROLL";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHMKEY.
        /// </summary>
        public const string CHMKEY = "CHMKEY";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHENTJ.
        /// </summary>
        public const string CHENTJ = "CHENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1515";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCAPID", "CHCAPID", JdeDataType.String, 20, true, true),
        new JdeField("CHDL01", "CHDL01", JdeDataType.String, 60),
        new JdeField("CHCAPTYPE", "CHCAPTYPE", JdeDataType.String, 2),
        new JdeField("CHCAPPCT", "CHCAPPCT", JdeDataType.Numeric),
        new JdeField("CHCAPOP", "CHCAPOP", JdeDataType.String, 2),
        new JdeField("CHCAPOP1", "CHCAPOP1", JdeDataType.String, 2),
        new JdeField("CHCAPOP2", "CHCAPOP2", JdeDataType.String, 2),
        new JdeField("CHCAPIDX", "CHCAPIDX", JdeDataType.String, 10),
        new JdeField("CHCIDXMT", "CHCIDXMT", JdeDataType.Numeric),
        new JdeField("CHCIDXYR", "CHCIDXYR", JdeDataType.Numeric),
        new JdeField("CHCAPROLL", "CHCAPROLL", JdeDataType.String, 2),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHMKEY", "CHMKEY", JdeDataType.String, 30),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHENTJ", "CHENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1515_0", "Primary Key on CHCAPID", new[] { "CHCAPID" }, isUnique: true, isPrimaryKey: true)
    };
}
