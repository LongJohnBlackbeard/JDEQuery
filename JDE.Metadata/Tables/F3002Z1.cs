using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3002Z1 - .
/// </summary>
public class F3002Z1 : JdeTable
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
        /// SZTBM.
        /// </summary>
        public const string SZTBM = "SZTBM";

        /// <summary>
        /// SZKIT.
        /// </summary>
        public const string SZKIT = "SZKIT";

        /// <summary>
        /// SZKITL.
        /// </summary>
        public const string SZKITL = "SZKITL";

        /// <summary>
        /// SZKITA.
        /// </summary>
        public const string SZKITA = "SZKITA";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZCMCU.
        /// </summary>
        public const string SZCMCU = "SZCMCU";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZSBNT.
        /// </summary>
        public const string SZSBNT = "SZSBNT";

        /// <summary>
        /// SZPRTA.
        /// </summary>
        public const string SZPRTA = "SZPRTA";

        /// <summary>
        /// SZQNTY.
        /// </summary>
        public const string SZQNTY = "SZQNTY";

        /// <summary>
        /// SZUM.
        /// </summary>
        public const string SZUM = "SZUM";

        /// <summary>
        /// SZBQTY.
        /// </summary>
        public const string SZBQTY = "SZBQTY";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZFVBT.
        /// </summary>
        public const string SZFVBT = "SZFVBT";

        /// <summary>
        /// SZEFFF.
        /// </summary>
        public const string SZEFFF = "SZEFFF";

        /// <summary>
        /// SZEFFT.
        /// </summary>
        public const string SZEFFT = "SZEFFT";

        /// <summary>
        /// SZFSER.
        /// </summary>
        public const string SZFSER = "SZFSER";

        /// <summary>
        /// SZTSER.
        /// </summary>
        public const string SZTSER = "SZTSER";

        /// <summary>
        /// SZITC.
        /// </summary>
        public const string SZITC = "SZITC";

        /// <summary>
        /// SZFTRC.
        /// </summary>
        public const string SZFTRC = "SZFTRC";

        /// <summary>
        /// SZOPTK.
        /// </summary>
        public const string SZOPTK = "SZOPTK";

        /// <summary>
        /// SZFORV.
        /// </summary>
        public const string SZFORV = "SZFORV";

        /// <summary>
        /// SZCSTM.
        /// </summary>
        public const string SZCSTM = "SZCSTM";

        /// <summary>
        /// SZCSMP.
        /// </summary>
        public const string SZCSMP = "SZCSMP";

        /// <summary>
        /// SZORDW.
        /// </summary>
        public const string SZORDW = "SZORDW";

        /// <summary>
        /// SZFORQ.
        /// </summary>
        public const string SZFORQ = "SZFORQ";

        /// <summary>
        /// SZCOBY.
        /// </summary>
        public const string SZCOBY = "SZCOBY";

        /// <summary>
        /// SZCOTY.
        /// </summary>
        public const string SZCOTY = "SZCOTY";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZTHRP.
        /// </summary>
        public const string SZTHRP = "SZTHRP";

        /// <summary>
        /// SZFRGD.
        /// </summary>
        public const string SZFRGD = "SZFRGD";

        /// <summary>
        /// SZTHGD.
        /// </summary>
        public const string SZTHGD = "SZTHGD";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZBSEQ.
        /// </summary>
        public const string SZBSEQ = "SZBSEQ";

        /// <summary>
        /// SZFTRP.
        /// </summary>
        public const string SZFTRP = "SZFTRP";

        /// <summary>
        /// SZF$RP.
        /// </summary>
        public const string SZF_RP = "SZF$RP";

        /// <summary>
        /// SZRSCP.
        /// </summary>
        public const string SZRSCP = "SZRSCP";

        /// <summary>
        /// SZSCRP.
        /// </summary>
        public const string SZSCRP = "SZSCRP";

        /// <summary>
        /// SZREWP.
        /// </summary>
        public const string SZREWP = "SZREWP";

        /// <summary>
        /// SZASIP.
        /// </summary>
        public const string SZASIP = "SZASIP";

        /// <summary>
        /// SZCPYP.
        /// </summary>
        public const string SZCPYP = "SZCPYP";

        /// <summary>
        /// SZSTPP.
        /// </summary>
        public const string SZSTPP = "SZSTPP";

        /// <summary>
        /// SZLOVD.
        /// </summary>
        public const string SZLOVD = "SZLOVD";

        /// <summary>
        /// SZECO.
        /// </summary>
        public const string SZECO = "SZECO";

        /// <summary>
        /// SZECTY.
        /// </summary>
        public const string SZECTY = "SZECTY";

        /// <summary>
        /// SZECOD.
        /// </summary>
        public const string SZECOD = "SZECOD";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZPRIC.
        /// </summary>
        public const string SZPRIC = "SZPRIC";

        /// <summary>
        /// SZUNCS.
        /// </summary>
        public const string SZUNCS = "SZUNCS";

        /// <summary>
        /// SZPCTK.
        /// </summary>
        public const string SZPCTK = "SZPCTK";

        /// <summary>
        /// SZSHNO.
        /// </summary>
        public const string SZSHNO = "SZSHNO";

        /// <summary>
        /// SZOMCU.
        /// </summary>
        public const string SZOMCU = "SZOMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZBREV.
        /// </summary>
        public const string SZBREV = "SZBREV";

        /// <summary>
        /// SZCMRV.
        /// </summary>
        public const string SZCMRV = "SZCMRV";

        /// <summary>
        /// SZRVNO.
        /// </summary>
        public const string SZRVNO = "SZRVNO";

        /// <summary>
        /// SZUUPG.
        /// </summary>
        public const string SZUUPG = "SZUUPG";

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
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZAING.
        /// </summary>
        public const string SZAING = "SZAING";

        /// <summary>
        /// SZSUCO.
        /// </summary>
        public const string SZSUCO = "SZSUCO";

        /// <summary>
        /// SZSTRC.
        /// </summary>
        public const string SZSTRC = "SZSTRC";

        /// <summary>
        /// SZENDC.
        /// </summary>
        public const string SZENDC = "SZENDC";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";

        /// <summary>
        /// SZCPNB.
        /// </summary>
        public const string SZCPNB = "SZCPNB";

        /// <summary>
        /// SZBSEQAN.
        /// </summary>
        public const string SZBSEQAN = "SZBSEQAN";

        /// <summary>
        /// SZBCHAR.
        /// </summary>
        public const string SZBCHAR = "SZBCHAR";

        /// <summary>
        /// SZBOSTR.
        /// </summary>
        public const string SZBOSTR = "SZBOSTR";
    }

    /// <inheritdoc />
    public override string TableName => "F3002Z1";

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
        new JdeField("SZTBM", "SZTBM", JdeDataType.String, 6),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZKITL", "SZKITL", JdeDataType.String, 50),
        new JdeField("SZKITA", "SZKITA", JdeDataType.String, 50),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZCMCU", "SZCMCU", JdeDataType.String, 24),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZSBNT", "SZSBNT", JdeDataType.Numeric),
        new JdeField("SZPRTA", "SZPRTA", JdeDataType.String, 2),
        new JdeField("SZQNTY", "SZQNTY", JdeDataType.Numeric),
        new JdeField("SZUM", "SZUM", JdeDataType.String, 4),
        new JdeField("SZBQTY", "SZBQTY", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZFVBT", "SZFVBT", JdeDataType.String, 2),
        new JdeField("SZEFFF", "SZEFFF", JdeDataType.Numeric),
        new JdeField("SZEFFT", "SZEFFT", JdeDataType.Numeric),
        new JdeField("SZFSER", "SZFSER", JdeDataType.String, 50),
        new JdeField("SZTSER", "SZTSER", JdeDataType.String, 50),
        new JdeField("SZITC", "SZITC", JdeDataType.String, 2),
        new JdeField("SZFTRC", "SZFTRC", JdeDataType.String, 2),
        new JdeField("SZOPTK", "SZOPTK", JdeDataType.String, 2),
        new JdeField("SZFORV", "SZFORV", JdeDataType.String, 2),
        new JdeField("SZCSTM", "SZCSTM", JdeDataType.String, 2),
        new JdeField("SZCSMP", "SZCSMP", JdeDataType.String, 2),
        new JdeField("SZORDW", "SZORDW", JdeDataType.String, 2),
        new JdeField("SZFORQ", "SZFORQ", JdeDataType.String, 2),
        new JdeField("SZCOBY", "SZCOBY", JdeDataType.String, 2),
        new JdeField("SZCOTY", "SZCOTY", JdeDataType.String, 2),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZBSEQ", "SZBSEQ", JdeDataType.Numeric),
        new JdeField("SZFTRP", "SZFTRP", JdeDataType.Numeric),
        new JdeField("SZF$RP", "SZF$RP", JdeDataType.Numeric),
        new JdeField("SZRSCP", "SZRSCP", JdeDataType.Numeric),
        new JdeField("SZSCRP", "SZSCRP", JdeDataType.Numeric),
        new JdeField("SZREWP", "SZREWP", JdeDataType.Numeric),
        new JdeField("SZASIP", "SZASIP", JdeDataType.Numeric),
        new JdeField("SZCPYP", "SZCPYP", JdeDataType.Numeric),
        new JdeField("SZSTPP", "SZSTPP", JdeDataType.Numeric),
        new JdeField("SZLOVD", "SZLOVD", JdeDataType.Numeric),
        new JdeField("SZECO", "SZECO", JdeDataType.String, 24),
        new JdeField("SZECTY", "SZECTY", JdeDataType.String, 4),
        new JdeField("SZECOD", "SZECOD", JdeDataType.Numeric),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZPRIC", "SZPRIC", JdeDataType.Numeric),
        new JdeField("SZUNCS", "SZUNCS", JdeDataType.Numeric),
        new JdeField("SZPCTK", "SZPCTK", JdeDataType.Numeric),
        new JdeField("SZSHNO", "SZSHNO", JdeDataType.String, 20),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZBREV", "SZBREV", JdeDataType.String, 6),
        new JdeField("SZCMRV", "SZCMRV", JdeDataType.String, 6),
        new JdeField("SZRVNO", "SZRVNO", JdeDataType.String, 4),
        new JdeField("SZUUPG", "SZUUPG", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZAING", "SZAING", JdeDataType.String, 2),
        new JdeField("SZSUCO", "SZSUCO", JdeDataType.Numeric),
        new JdeField("SZSTRC", "SZSTRC", JdeDataType.Numeric),
        new JdeField("SZENDC", "SZENDC", JdeDataType.Numeric),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2),
        new JdeField("SZCPNB", "SZCPNB", JdeDataType.Numeric),
        new JdeField("SZBSEQAN", "SZBSEQAN", JdeDataType.String, 10),
        new JdeField("SZBCHAR", "SZBCHAR", JdeDataType.String, 2),
        new JdeField("SZBOSTR", "SZBOSTR", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3002Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3002Z1_11", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F3002Z1_13", "Index on SZEDBT, SZEDTN, SZMMCU, SZKIT, SZTBM, SZBQTY", new[] { "SZEDBT", "SZEDTN", "SZMMCU", "SZKIT", "SZTBM", "SZBQTY" }),
        new JdeIndex("F3002Z1_14", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00095$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00095$" }),
        new JdeIndex("F3002Z1_8", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F3002Z1_9", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" })
    };
}
