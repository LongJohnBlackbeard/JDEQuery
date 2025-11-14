using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L002 - .
/// </summary>
public class FF30L002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHDFTBM.
        /// </summary>
        public const string DHDFTBM = "DHDFTBM";

        /// <summary>
        /// DHDFKIT.
        /// </summary>
        public const string DHDFKIT = "DHDFKIT";

        /// <summary>
        /// DHDFMCU.
        /// </summary>
        public const string DHDFMCU = "DHDFMCU";

        /// <summary>
        /// DHDFITM.
        /// </summary>
        public const string DHDFITM = "DHDFITM";

        /// <summary>
        /// DHDFCMCU.
        /// </summary>
        public const string DHDFCMCU = "DHDFCMCU";

        /// <summary>
        /// DHCPNT.
        /// </summary>
        public const string DHCPNT = "DHCPNT";

        /// <summary>
        /// DHSBNT.
        /// </summary>
        public const string DHSBNT = "DHSBNT";

        /// <summary>
        /// DHPRTA.
        /// </summary>
        public const string DHPRTA = "DHPRTA";

        /// <summary>
        /// DHQNTY.
        /// </summary>
        public const string DHQNTY = "DHQNTY";

        /// <summary>
        /// DHUM.
        /// </summary>
        public const string DHUM = "DHUM";

        /// <summary>
        /// DHBQTY.
        /// </summary>
        public const string DHBQTY = "DHBQTY";

        /// <summary>
        /// DHUOM.
        /// </summary>
        public const string DHUOM = "DHUOM";

        /// <summary>
        /// DHFVBT.
        /// </summary>
        public const string DHFVBT = "DHFVBT";

        /// <summary>
        /// DHEFFF.
        /// </summary>
        public const string DHEFFF = "DHEFFF";

        /// <summary>
        /// DHEFFT.
        /// </summary>
        public const string DHEFFT = "DHEFFT";

        /// <summary>
        /// DHITC.
        /// </summary>
        public const string DHITC = "DHITC";

        /// <summary>
        /// DHFTRC.
        /// </summary>
        public const string DHFTRC = "DHFTRC";

        /// <summary>
        /// DHOPTK.
        /// </summary>
        public const string DHOPTK = "DHOPTK";

        /// <summary>
        /// DHFORV.
        /// </summary>
        public const string DHFORV = "DHFORV";

        /// <summary>
        /// DHCSTM.
        /// </summary>
        public const string DHCSTM = "DHCSTM";

        /// <summary>
        /// DHCSMP.
        /// </summary>
        public const string DHCSMP = "DHCSMP";

        /// <summary>
        /// DHORDW.
        /// </summary>
        public const string DHORDW = "DHORDW";

        /// <summary>
        /// DHFORQ.
        /// </summary>
        public const string DHFORQ = "DHFORQ";

        /// <summary>
        /// DHCOBY.
        /// </summary>
        public const string DHCOBY = "DHCOBY";

        /// <summary>
        /// DHCOTY.
        /// </summary>
        public const string DHCOTY = "DHCOTY";

        /// <summary>
        /// DHFRMP.
        /// </summary>
        public const string DHFRMP = "DHFRMP";

        /// <summary>
        /// DHTHRP.
        /// </summary>
        public const string DHTHRP = "DHTHRP";

        /// <summary>
        /// DHFRGD.
        /// </summary>
        public const string DHFRGD = "DHFRGD";

        /// <summary>
        /// DHTHGD.
        /// </summary>
        public const string DHTHGD = "DHTHGD";

        /// <summary>
        /// DHOPSQ.
        /// </summary>
        public const string DHOPSQ = "DHOPSQ";

        /// <summary>
        /// DHBSEQ.
        /// </summary>
        public const string DHBSEQ = "DHBSEQ";

        /// <summary>
        /// DHFTRP.
        /// </summary>
        public const string DHFTRP = "DHFTRP";

        /// <summary>
        /// DHF$RP.
        /// </summary>
        public const string DHF_RP = "DHF$RP";

        /// <summary>
        /// DHRSCP.
        /// </summary>
        public const string DHRSCP = "DHRSCP";

        /// <summary>
        /// DHSCRP.
        /// </summary>
        public const string DHSCRP = "DHSCRP";

        /// <summary>
        /// DHREWP.
        /// </summary>
        public const string DHREWP = "DHREWP";

        /// <summary>
        /// DHASIP.
        /// </summary>
        public const string DHASIP = "DHASIP";

        /// <summary>
        /// DHCPYP.
        /// </summary>
        public const string DHCPYP = "DHCPYP";

        /// <summary>
        /// DHSTPP.
        /// </summary>
        public const string DHSTPP = "DHSTPP";

        /// <summary>
        /// DHLOVD.
        /// </summary>
        public const string DHLOVD = "DHLOVD";

        /// <summary>
        /// DHECO.
        /// </summary>
        public const string DHECO = "DHECO";

        /// <summary>
        /// DHECTY.
        /// </summary>
        public const string DHECTY = "DHECTY";

        /// <summary>
        /// DHECOD.
        /// </summary>
        public const string DHECOD = "DHECOD";

        /// <summary>
        /// DHDSC1.
        /// </summary>
        public const string DHDSC1 = "DHDSC1";

        /// <summary>
        /// DHLNTY.
        /// </summary>
        public const string DHLNTY = "DHLNTY";

        /// <summary>
        /// DHPRIC.
        /// </summary>
        public const string DHPRIC = "DHPRIC";

        /// <summary>
        /// DHUNCS.
        /// </summary>
        public const string DHUNCS = "DHUNCS";

        /// <summary>
        /// DHPCTK.
        /// </summary>
        public const string DHPCTK = "DHPCTK";

        /// <summary>
        /// DHSHNO.
        /// </summary>
        public const string DHSHNO = "DHSHNO";

        /// <summary>
        /// DHBREV.
        /// </summary>
        public const string DHBREV = "DHBREV";

        /// <summary>
        /// DHCMRV.
        /// </summary>
        public const string DHCMRV = "DHCMRV";

        /// <summary>
        /// DHRVNO.
        /// </summary>
        public const string DHRVNO = "DHRVNO";

        /// <summary>
        /// DHUUPG.
        /// </summary>
        public const string DHUUPG = "DHUUPG";

        /// <summary>
        /// DHAING.
        /// </summary>
        public const string DHAING = "DHAING";

        /// <summary>
        /// DHSUCO.
        /// </summary>
        public const string DHSUCO = "DHSUCO";

        /// <summary>
        /// DHSTRC.
        /// </summary>
        public const string DHSTRC = "DHSTRC";

        /// <summary>
        /// DHENDC.
        /// </summary>
        public const string DHENDC = "DHENDC";

        /// <summary>
        /// DHAPSC.
        /// </summary>
        public const string DHAPSC = "DHAPSC";

        /// <summary>
        /// DHCPNB.
        /// </summary>
        public const string DHCPNB = "DHCPNB";

        /// <summary>
        /// DHBSEQAN.
        /// </summary>
        public const string DHBSEQAN = "DHBSEQAN";

        /// <summary>
        /// DHPKUOM.
        /// </summary>
        public const string DHPKUOM = "DHPKUOM";

        /// <summary>
        /// DHFSCID.
        /// </summary>
        public const string DHFSCID = "DHFSCID";

        /// <summary>
        /// DHBCHAR.
        /// </summary>
        public const string DHBCHAR = "DHBCHAR";

        /// <summary>
        /// DHTYCOMP.
        /// </summary>
        public const string DHTYCOMP = "DHTYCOMP";

        /// <summary>
        /// DHCOLOCN.
        /// </summary>
        public const string DHCOLOCN = "DHCOLOCN";

        /// <summary>
        /// DHIMPM.
        /// </summary>
        public const string DHIMPM = "DHIMPM";

        /// <summary>
        /// DHIFLOCN.
        /// </summary>
        public const string DHIFLOCN = "DHIFLOCN";

        /// <summary>
        /// DHBOSTR.
        /// </summary>
        public const string DHBOSTR = "DHBOSTR";

        /// <summary>
        /// DHURCD.
        /// </summary>
        public const string DHURCD = "DHURCD";

        /// <summary>
        /// DHURDT.
        /// </summary>
        public const string DHURDT = "DHURDT";

        /// <summary>
        /// DHURAT.
        /// </summary>
        public const string DHURAT = "DHURAT";

        /// <summary>
        /// DHURRF.
        /// </summary>
        public const string DHURRF = "DHURRF";

        /// <summary>
        /// DHURAB.
        /// </summary>
        public const string DHURAB = "DHURAB";

        /// <summary>
        /// DHUSER.
        /// </summary>
        public const string DHUSER = "DHUSER";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHMKEY.
        /// </summary>
        public const string DHMKEY = "DHMKEY";

        /// <summary>
        /// DHUUPMJ.
        /// </summary>
        public const string DHUUPMJ = "DHUUPMJ";

        /// <summary>
        /// DHDFUPDA.
        /// </summary>
        public const string DHDFUPDA = "DHDFUPDA";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHDFTBM", "DHDFTBM", JdeDataType.String, 6, true, true),
        new JdeField("DHDFKIT", "DHDFKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("DHDFMCU", "DHDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("DHDFITM", "DHDFITM", JdeDataType.Numeric),
        new JdeField("DHDFCMCU", "DHDFCMCU", JdeDataType.String, 24),
        new JdeField("DHCPNT", "DHCPNT", JdeDataType.Numeric),
        new JdeField("DHSBNT", "DHSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("DHPRTA", "DHPRTA", JdeDataType.String, 2),
        new JdeField("DHQNTY", "DHQNTY", JdeDataType.Numeric),
        new JdeField("DHUM", "DHUM", JdeDataType.String, 4),
        new JdeField("DHBQTY", "DHBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("DHUOM", "DHUOM", JdeDataType.String, 4),
        new JdeField("DHFVBT", "DHFVBT", JdeDataType.String, 2),
        new JdeField("DHEFFF", "DHEFFF", JdeDataType.Numeric),
        new JdeField("DHEFFT", "DHEFFT", JdeDataType.Numeric),
        new JdeField("DHITC", "DHITC", JdeDataType.String, 2),
        new JdeField("DHFTRC", "DHFTRC", JdeDataType.String, 2),
        new JdeField("DHOPTK", "DHOPTK", JdeDataType.String, 2),
        new JdeField("DHFORV", "DHFORV", JdeDataType.String, 2),
        new JdeField("DHCSTM", "DHCSTM", JdeDataType.String, 2),
        new JdeField("DHCSMP", "DHCSMP", JdeDataType.String, 2),
        new JdeField("DHORDW", "DHORDW", JdeDataType.String, 2),
        new JdeField("DHFORQ", "DHFORQ", JdeDataType.String, 2),
        new JdeField("DHCOBY", "DHCOBY", JdeDataType.String, 2, true, true),
        new JdeField("DHCOTY", "DHCOTY", JdeDataType.String, 2),
        new JdeField("DHFRMP", "DHFRMP", JdeDataType.Numeric),
        new JdeField("DHTHRP", "DHTHRP", JdeDataType.Numeric),
        new JdeField("DHFRGD", "DHFRGD", JdeDataType.String, 6),
        new JdeField("DHTHGD", "DHTHGD", JdeDataType.String, 6),
        new JdeField("DHOPSQ", "DHOPSQ", JdeDataType.Numeric),
        new JdeField("DHBSEQ", "DHBSEQ", JdeDataType.Numeric),
        new JdeField("DHFTRP", "DHFTRP", JdeDataType.Numeric),
        new JdeField("DHF$RP", "DHF$RP", JdeDataType.Numeric),
        new JdeField("DHRSCP", "DHRSCP", JdeDataType.Numeric),
        new JdeField("DHSCRP", "DHSCRP", JdeDataType.Numeric),
        new JdeField("DHREWP", "DHREWP", JdeDataType.Numeric),
        new JdeField("DHASIP", "DHASIP", JdeDataType.Numeric),
        new JdeField("DHCPYP", "DHCPYP", JdeDataType.Numeric),
        new JdeField("DHSTPP", "DHSTPP", JdeDataType.Numeric),
        new JdeField("DHLOVD", "DHLOVD", JdeDataType.Numeric),
        new JdeField("DHECO", "DHECO", JdeDataType.String, 24),
        new JdeField("DHECTY", "DHECTY", JdeDataType.String, 4),
        new JdeField("DHECOD", "DHECOD", JdeDataType.Numeric),
        new JdeField("DHDSC1", "DHDSC1", JdeDataType.String, 60),
        new JdeField("DHLNTY", "DHLNTY", JdeDataType.String, 4),
        new JdeField("DHPRIC", "DHPRIC", JdeDataType.Numeric),
        new JdeField("DHUNCS", "DHUNCS", JdeDataType.Numeric),
        new JdeField("DHPCTK", "DHPCTK", JdeDataType.Numeric),
        new JdeField("DHSHNO", "DHSHNO", JdeDataType.String, 20),
        new JdeField("DHBREV", "DHBREV", JdeDataType.String, 6),
        new JdeField("DHCMRV", "DHCMRV", JdeDataType.String, 6),
        new JdeField("DHRVNO", "DHRVNO", JdeDataType.String, 4),
        new JdeField("DHUUPG", "DHUUPG", JdeDataType.Numeric),
        new JdeField("DHAING", "DHAING", JdeDataType.String, 2),
        new JdeField("DHSUCO", "DHSUCO", JdeDataType.Numeric),
        new JdeField("DHSTRC", "DHSTRC", JdeDataType.Numeric),
        new JdeField("DHENDC", "DHENDC", JdeDataType.Numeric),
        new JdeField("DHAPSC", "DHAPSC", JdeDataType.String, 2),
        new JdeField("DHCPNB", "DHCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("DHBSEQAN", "DHBSEQAN", JdeDataType.String, 10),
        new JdeField("DHPKUOM", "DHPKUOM", JdeDataType.String, 4),
        new JdeField("DHFSCID", "DHFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("DHBCHAR", "DHBCHAR", JdeDataType.String, 2),
        new JdeField("DHTYCOMP", "DHTYCOMP", JdeDataType.String, 4),
        new JdeField("DHCOLOCN", "DHCOLOCN", JdeDataType.String, 40),
        new JdeField("DHIMPM", "DHIMPM", JdeDataType.String, 8),
        new JdeField("DHIFLOCN", "DHIFLOCN", JdeDataType.String, 40),
        new JdeField("DHBOSTR", "DHBOSTR", JdeDataType.String, 8),
        new JdeField("DHURCD", "DHURCD", JdeDataType.String, 4),
        new JdeField("DHURDT", "DHURDT", JdeDataType.Numeric),
        new JdeField("DHURAT", "DHURAT", JdeDataType.Numeric),
        new JdeField("DHURRF", "DHURRF", JdeDataType.String, 30),
        new JdeField("DHURAB", "DHURAB", JdeDataType.Numeric),
        new JdeField("DHUSER", "DHUSER", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHMKEY", "DHMKEY", JdeDataType.String, 30),
        new JdeField("DHUUPMJ", "DHUUPMJ", JdeDataType.Date),
        new JdeField("DHDFUPDA", "DHDFUPDA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L002_0", "Primary Key on DHFSCID, DHDFKIT, DHDFMCU, DHDFTBM, DHBQTY, DHCPNB, DHSBNT, DHCOBY", new[] { "DHFSCID", "DHDFKIT", "DHDFMCU", "DHDFTBM", "DHBQTY", "DHCPNB", "DHSBNT", "DHCOBY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L002_2", "Index on DHFSCID", new[] { "DHFSCID" }),
        new JdeIndex("FF30L002_3", "Index on DHFSCID, DHSBNT, DHCOBY, DHDFITM, DHDFCMCU", new[] { "DHFSCID", "DHSBNT", "DHCOBY", "DHDFITM", "DHDFCMCU" }),
        new JdeIndex("FF30L002_4", "Index on DHFSCID, DHDFKIT, DHDFMCU, DHDFTBM, DHBQTY, DHDFITM, DHBOSTR, DHSBNT, DHCOBY", new[] { "DHFSCID", "DHDFKIT", "DHDFMCU", "DHDFTBM", "DHBQTY", "DHDFITM", "DHBOSTR", "DHSBNT", "DHCOBY" }),
        new JdeIndex("FF30L002_5", "Index on DHFSCID, DHDFMCU, DHDFITM", new[] { "DHFSCID", "DHDFMCU", "DHDFITM" }),
        new JdeIndex("FF30L002_6", "Index on DHDFKIT", new[] { "DHDFKIT" })
    };
}
