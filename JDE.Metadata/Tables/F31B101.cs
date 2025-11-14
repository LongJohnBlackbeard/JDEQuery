using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B101 - .
/// </summary>
public class F31B101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDWLOTN.
        /// </summary>
        public const string VDWLOTN = "VDWLOTN";

        /// <summary>
        /// VDMCU.
        /// </summary>
        public const string VDMCU = "VDMCU";

        /// <summary>
        /// VDBRLNUM.
        /// </summary>
        public const string VDBRLNUM = "VDBRLNUM";

        /// <summary>
        /// VDWOPID.
        /// </summary>
        public const string VDWOPID = "VDWOPID";

        /// <summary>
        /// VDWVID.
        /// </summary>
        public const string VDWVID = "VDWVID";

        /// <summary>
        /// VDWV2VLNID.
        /// </summary>
        public const string VDWV2VLNID = "VDWV2VLNID";

        /// <summary>
        /// VDBIDSEQ.
        /// </summary>
        public const string VDBIDSEQ = "VDBIDSEQ";

        /// <summary>
        /// VDLOCN.
        /// </summary>
        public const string VDLOCN = "VDLOCN";

        /// <summary>
        /// VDRKNMR.
        /// </summary>
        public const string VDRKNMR = "VDRKNMR";

        /// <summary>
        /// VDQTRC.
        /// </summary>
        public const string VDQTRC = "VDQTRC";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDMKEY.
        /// </summary>
        public const string VDMKEY = "VDMKEY";

        /// <summary>
        /// VDUPMT.
        /// </summary>
        public const string VDUPMT = "VDUPMT";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDURAT.
        /// </summary>
        public const string VDURAT = "VDURAT";

        /// <summary>
        /// VDURCD.
        /// </summary>
        public const string VDURCD = "VDURCD";

        /// <summary>
        /// VDURDT.
        /// </summary>
        public const string VDURDT = "VDURDT";

        /// <summary>
        /// VDURAB.
        /// </summary>
        public const string VDURAB = "VDURAB";

        /// <summary>
        /// VDURRF.
        /// </summary>
        public const string VDURRF = "VDURRF";

        /// <summary>
        /// VDVID.
        /// </summary>
        public const string VDVID = "VDVID";

        /// <summary>
        /// VDSMPYN.
        /// </summary>
        public const string VDSMPYN = "VDSMPYN";

        /// <summary>
        /// VDBVST.
        /// </summary>
        public const string VDBVST = "VDBVST";

        /// <summary>
        /// VDVBTUSEF.
        /// </summary>
        public const string VDVBTUSEF = "VDVBTUSEF";

        /// <summary>
        /// VDCSRLNO.
        /// </summary>
        public const string VDCSRLNO = "VDCSRLNO";

        /// <summary>
        /// VDSMPSEQ.
        /// </summary>
        public const string VDSMPSEQ = "VDSMPSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F31B101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDWLOTN", "VDWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("VDMCU", "VDMCU", JdeDataType.String, 24, true, true),
        new JdeField("VDBRLNUM", "VDBRLNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("VDWOPID", "VDWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDWVID", "VDWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDWV2VLNID", "VDWV2VLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDBIDSEQ", "VDBIDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("VDLOCN", "VDLOCN", JdeDataType.String, 40),
        new JdeField("VDRKNMR", "VDRKNMR", JdeDataType.String, 40),
        new JdeField("VDQTRC", "VDQTRC", JdeDataType.Numeric),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDMKEY", "VDMKEY", JdeDataType.String, 30),
        new JdeField("VDUPMT", "VDUPMT", JdeDataType.Numeric),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDURAT", "VDURAT", JdeDataType.Numeric),
        new JdeField("VDURCD", "VDURCD", JdeDataType.String, 4),
        new JdeField("VDURDT", "VDURDT", JdeDataType.Numeric),
        new JdeField("VDURAB", "VDURAB", JdeDataType.Numeric),
        new JdeField("VDURRF", "VDURRF", JdeDataType.String, 30),
        new JdeField("VDVID", "VDVID", JdeDataType.String, 20),
        new JdeField("VDSMPYN", "VDSMPYN", JdeDataType.String, 2),
        new JdeField("VDBVST", "VDBVST", JdeDataType.String, 6),
        new JdeField("VDVBTUSEF", "VDVBTUSEF", JdeDataType.String, 2),
        new JdeField("VDCSRLNO", "VDCSRLNO", JdeDataType.String, 30),
        new JdeField("VDSMPSEQ", "VDSMPSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B101_0", "Primary Key on VDWOPID, VDWVID, VDWV2VLNID, VDMCU, VDBRLNUM, VDBIDSEQ, VDWLOTN", new[] { "VDWOPID", "VDWVID", "VDWV2VLNID", "VDMCU", "VDBRLNUM", "VDBIDSEQ", "VDWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B101_2", "Index on VDWLOTN, VDMCU, VDBRLNUM", new[] { "VDWLOTN", "VDMCU", "VDBRLNUM" }),
        new JdeIndex("F31B101_3", "Index on VDWVID, VDVBTUSEF", new[] { "VDWVID", "VDVBTUSEF" }),
        new JdeIndex("F31B101_4", "Index on VDBRLNUM, VDWOPID", new[] { "VDBRLNUM", "VDWOPID" })
    };
}
