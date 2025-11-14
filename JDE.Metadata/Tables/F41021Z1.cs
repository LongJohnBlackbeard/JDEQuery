using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021Z1 - .
/// </summary>
public class F41021Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZPBIN.
        /// </summary>
        public const string SZPBIN = "SZPBIN";

        /// <summary>
        /// SZGLPT.
        /// </summary>
        public const string SZGLPT = "SZGLPT";

        /// <summary>
        /// SZLOTS.
        /// </summary>
        public const string SZLOTS = "SZLOTS";

        /// <summary>
        /// SZLRCJ.
        /// </summary>
        public const string SZLRCJ = "SZLRCJ";

        /// <summary>
        /// SZPQOH.
        /// </summary>
        public const string SZPQOH = "SZPQOH";

        /// <summary>
        /// SZPBCK.
        /// </summary>
        public const string SZPBCK = "SZPBCK";

        /// <summary>
        /// SZPREQ.
        /// </summary>
        public const string SZPREQ = "SZPREQ";

        /// <summary>
        /// SZQWBO.
        /// </summary>
        public const string SZQWBO = "SZQWBO";

        /// <summary>
        /// SZOT1P.
        /// </summary>
        public const string SZOT1P = "SZOT1P";

        /// <summary>
        /// SZOT2P.
        /// </summary>
        public const string SZOT2P = "SZOT2P";

        /// <summary>
        /// SZOT1A.
        /// </summary>
        public const string SZOT1A = "SZOT1A";

        /// <summary>
        /// SZHCOM.
        /// </summary>
        public const string SZHCOM = "SZHCOM";

        /// <summary>
        /// SZPCOM.
        /// </summary>
        public const string SZPCOM = "SZPCOM";

        /// <summary>
        /// SZFCOM.
        /// </summary>
        public const string SZFCOM = "SZFCOM";

        /// <summary>
        /// SZFUN1.
        /// </summary>
        public const string SZFUN1 = "SZFUN1";

        /// <summary>
        /// SZQOWO.
        /// </summary>
        public const string SZQOWO = "SZQOWO";

        /// <summary>
        /// SZQTTR.
        /// </summary>
        public const string SZQTTR = "SZQTTR";

        /// <summary>
        /// SZQTIN.
        /// </summary>
        public const string SZQTIN = "SZQTIN";

        /// <summary>
        /// SZQONL.
        /// </summary>
        public const string SZQONL = "SZQONL";

        /// <summary>
        /// SZQTRI.
        /// </summary>
        public const string SZQTRI = "SZQTRI";

        /// <summary>
        /// SZQTRO.
        /// </summary>
        public const string SZQTRO = "SZQTRO";

        /// <summary>
        /// SZNCDJ.
        /// </summary>
        public const string SZNCDJ = "SZNCDJ";

        /// <summary>
        /// SZQTY1.
        /// </summary>
        public const string SZQTY1 = "SZQTY1";

        /// <summary>
        /// SZQTY2.
        /// </summary>
        public const string SZQTY2 = "SZQTY2";

        /// <summary>
        /// SZQTO1.
        /// </summary>
        public const string SZQTO1 = "SZQTO1";

        /// <summary>
        /// SZQTO2.
        /// </summary>
        public const string SZQTO2 = "SZQTO2";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZTRQT.
        /// </summary>
        public const string SZTRQT = "SZTRQT";

        /// <summary>
        /// SZILOD.
        /// </summary>
        public const string SZILOD = "SZILOD";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZHCMS.
        /// </summary>
        public const string SZHCMS = "SZHCMS";

        /// <summary>
        /// SZPJCM.
        /// </summary>
        public const string SZPJCM = "SZPJCM";

        /// <summary>
        /// SZPJDM.
        /// </summary>
        public const string SZPJDM = "SZPJDM";

        /// <summary>
        /// SZSCMS.
        /// </summary>
        public const string SZSCMS = "SZSCMS";

        /// <summary>
        /// SZSIBW.
        /// </summary>
        public const string SZSIBW = "SZSIBW";

        /// <summary>
        /// SZSOBW.
        /// </summary>
        public const string SZSOBW = "SZSOBW";

        /// <summary>
        /// SZSQOH.
        /// </summary>
        public const string SZSQOH = "SZSQOH";

        /// <summary>
        /// SZSQWO.
        /// </summary>
        public const string SZSQWO = "SZSQWO";

        /// <summary>
        /// SZSREQ.
        /// </summary>
        public const string SZSREQ = "SZSREQ";

        /// <summary>
        /// SZSWHC.
        /// </summary>
        public const string SZSWHC = "SZSWHC";

        /// <summary>
        /// SZSWSC.
        /// </summary>
        public const string SZSWSC = "SZSWSC";

        /// <summary>
        /// SZCFGSID.
        /// </summary>
        public const string SZCFGSID = "SZCFGSID";

        /// <summary>
        /// SZLOTC.
        /// </summary>
        public const string SZLOTC = "SZLOTC";
    }

    /// <inheritdoc />
    public override string TableName => "F41021Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZPBIN", "SZPBIN", JdeDataType.String, 2),
        new JdeField("SZGLPT", "SZGLPT", JdeDataType.String, 8),
        new JdeField("SZLOTS", "SZLOTS", JdeDataType.String, 2),
        new JdeField("SZLRCJ", "SZLRCJ", JdeDataType.Numeric),
        new JdeField("SZPQOH", "SZPQOH", JdeDataType.Numeric),
        new JdeField("SZPBCK", "SZPBCK", JdeDataType.Numeric),
        new JdeField("SZPREQ", "SZPREQ", JdeDataType.Numeric),
        new JdeField("SZQWBO", "SZQWBO", JdeDataType.Numeric),
        new JdeField("SZOT1P", "SZOT1P", JdeDataType.Numeric),
        new JdeField("SZOT2P", "SZOT2P", JdeDataType.Numeric),
        new JdeField("SZOT1A", "SZOT1A", JdeDataType.Numeric),
        new JdeField("SZHCOM", "SZHCOM", JdeDataType.Numeric),
        new JdeField("SZPCOM", "SZPCOM", JdeDataType.Numeric),
        new JdeField("SZFCOM", "SZFCOM", JdeDataType.Numeric),
        new JdeField("SZFUN1", "SZFUN1", JdeDataType.Numeric),
        new JdeField("SZQOWO", "SZQOWO", JdeDataType.Numeric),
        new JdeField("SZQTTR", "SZQTTR", JdeDataType.Numeric),
        new JdeField("SZQTIN", "SZQTIN", JdeDataType.Numeric),
        new JdeField("SZQONL", "SZQONL", JdeDataType.Numeric),
        new JdeField("SZQTRI", "SZQTRI", JdeDataType.Numeric),
        new JdeField("SZQTRO", "SZQTRO", JdeDataType.Numeric),
        new JdeField("SZNCDJ", "SZNCDJ", JdeDataType.Numeric),
        new JdeField("SZQTY1", "SZQTY1", JdeDataType.Numeric),
        new JdeField("SZQTY2", "SZQTY2", JdeDataType.Numeric),
        new JdeField("SZQTO1", "SZQTO1", JdeDataType.Numeric),
        new JdeField("SZQTO2", "SZQTO2", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZTRQT", "SZTRQT", JdeDataType.Numeric),
        new JdeField("SZILOD", "SZILOD", JdeDataType.String, 2),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZHCMS", "SZHCMS", JdeDataType.Numeric),
        new JdeField("SZPJCM", "SZPJCM", JdeDataType.Numeric),
        new JdeField("SZPJDM", "SZPJDM", JdeDataType.Numeric),
        new JdeField("SZSCMS", "SZSCMS", JdeDataType.Numeric),
        new JdeField("SZSIBW", "SZSIBW", JdeDataType.Numeric),
        new JdeField("SZSOBW", "SZSOBW", JdeDataType.Numeric),
        new JdeField("SZSQOH", "SZSQOH", JdeDataType.Numeric),
        new JdeField("SZSQWO", "SZSQWO", JdeDataType.Numeric),
        new JdeField("SZSREQ", "SZSREQ", JdeDataType.Numeric),
        new JdeField("SZSWHC", "SZSWHC", JdeDataType.Numeric),
        new JdeField("SZSWSC", "SZSWSC", JdeDataType.Numeric),
        new JdeField("SZCFGSID", "SZCFGSID", JdeDataType.String, 64),
        new JdeField("SZLOTC", "SZLOTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
