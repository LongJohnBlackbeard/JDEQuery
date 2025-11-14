using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3002 - .
/// </summary>
public class F3002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IXTBM.
        /// </summary>
        public const string IXTBM = "IXTBM";

        /// <summary>
        /// IXKIT.
        /// </summary>
        public const string IXKIT = "IXKIT";

        /// <summary>
        /// IXKITL.
        /// </summary>
        public const string IXKITL = "IXKITL";

        /// <summary>
        /// IXKITA.
        /// </summary>
        public const string IXKITA = "IXKITA";

        /// <summary>
        /// IXMMCU.
        /// </summary>
        public const string IXMMCU = "IXMMCU";

        /// <summary>
        /// IXITM.
        /// </summary>
        public const string IXITM = "IXITM";

        /// <summary>
        /// IXLITM.
        /// </summary>
        public const string IXLITM = "IXLITM";

        /// <summary>
        /// IXAITM.
        /// </summary>
        public const string IXAITM = "IXAITM";

        /// <summary>
        /// IXCMCU.
        /// </summary>
        public const string IXCMCU = "IXCMCU";

        /// <summary>
        /// IXCPNT.
        /// </summary>
        public const string IXCPNT = "IXCPNT";

        /// <summary>
        /// IXSBNT.
        /// </summary>
        public const string IXSBNT = "IXSBNT";

        /// <summary>
        /// IXPRTA.
        /// </summary>
        public const string IXPRTA = "IXPRTA";

        /// <summary>
        /// IXQNTY.
        /// </summary>
        public const string IXQNTY = "IXQNTY";

        /// <summary>
        /// IXUM.
        /// </summary>
        public const string IXUM = "IXUM";

        /// <summary>
        /// IXBQTY.
        /// </summary>
        public const string IXBQTY = "IXBQTY";

        /// <summary>
        /// IXUOM.
        /// </summary>
        public const string IXUOM = "IXUOM";

        /// <summary>
        /// IXFVBT.
        /// </summary>
        public const string IXFVBT = "IXFVBT";

        /// <summary>
        /// IXEFFF.
        /// </summary>
        public const string IXEFFF = "IXEFFF";

        /// <summary>
        /// IXEFFT.
        /// </summary>
        public const string IXEFFT = "IXEFFT";

        /// <summary>
        /// IXFSER.
        /// </summary>
        public const string IXFSER = "IXFSER";

        /// <summary>
        /// IXTSER.
        /// </summary>
        public const string IXTSER = "IXTSER";

        /// <summary>
        /// IXITC.
        /// </summary>
        public const string IXITC = "IXITC";

        /// <summary>
        /// IXFTRC.
        /// </summary>
        public const string IXFTRC = "IXFTRC";

        /// <summary>
        /// IXOPTK.
        /// </summary>
        public const string IXOPTK = "IXOPTK";

        /// <summary>
        /// IXFORV.
        /// </summary>
        public const string IXFORV = "IXFORV";

        /// <summary>
        /// IXCSTM.
        /// </summary>
        public const string IXCSTM = "IXCSTM";

        /// <summary>
        /// IXCSMP.
        /// </summary>
        public const string IXCSMP = "IXCSMP";

        /// <summary>
        /// IXORDW.
        /// </summary>
        public const string IXORDW = "IXORDW";

        /// <summary>
        /// IXFORQ.
        /// </summary>
        public const string IXFORQ = "IXFORQ";

        /// <summary>
        /// IXCOBY.
        /// </summary>
        public const string IXCOBY = "IXCOBY";

        /// <summary>
        /// IXCOTY.
        /// </summary>
        public const string IXCOTY = "IXCOTY";

        /// <summary>
        /// IXFRMP.
        /// </summary>
        public const string IXFRMP = "IXFRMP";

        /// <summary>
        /// IXTHRP.
        /// </summary>
        public const string IXTHRP = "IXTHRP";

        /// <summary>
        /// IXFRGD.
        /// </summary>
        public const string IXFRGD = "IXFRGD";

        /// <summary>
        /// IXTHGD.
        /// </summary>
        public const string IXTHGD = "IXTHGD";

        /// <summary>
        /// IXOPSQ.
        /// </summary>
        public const string IXOPSQ = "IXOPSQ";

        /// <summary>
        /// IXBSEQ.
        /// </summary>
        public const string IXBSEQ = "IXBSEQ";

        /// <summary>
        /// IXFTRP.
        /// </summary>
        public const string IXFTRP = "IXFTRP";

        /// <summary>
        /// IXF$RP.
        /// </summary>
        public const string IXF_RP = "IXF$RP";

        /// <summary>
        /// IXRSCP.
        /// </summary>
        public const string IXRSCP = "IXRSCP";

        /// <summary>
        /// IXSCRP.
        /// </summary>
        public const string IXSCRP = "IXSCRP";

        /// <summary>
        /// IXREWP.
        /// </summary>
        public const string IXREWP = "IXREWP";

        /// <summary>
        /// IXASIP.
        /// </summary>
        public const string IXASIP = "IXASIP";

        /// <summary>
        /// IXCPYP.
        /// </summary>
        public const string IXCPYP = "IXCPYP";

        /// <summary>
        /// IXSTPP.
        /// </summary>
        public const string IXSTPP = "IXSTPP";

        /// <summary>
        /// IXLOVD.
        /// </summary>
        public const string IXLOVD = "IXLOVD";

        /// <summary>
        /// IXECO.
        /// </summary>
        public const string IXECO = "IXECO";

        /// <summary>
        /// IXECTY.
        /// </summary>
        public const string IXECTY = "IXECTY";

        /// <summary>
        /// IXECOD.
        /// </summary>
        public const string IXECOD = "IXECOD";

        /// <summary>
        /// IXDSC1.
        /// </summary>
        public const string IXDSC1 = "IXDSC1";

        /// <summary>
        /// IXLNTY.
        /// </summary>
        public const string IXLNTY = "IXLNTY";

        /// <summary>
        /// IXPRIC.
        /// </summary>
        public const string IXPRIC = "IXPRIC";

        /// <summary>
        /// IXUNCS.
        /// </summary>
        public const string IXUNCS = "IXUNCS";

        /// <summary>
        /// IXPCTK.
        /// </summary>
        public const string IXPCTK = "IXPCTK";

        /// <summary>
        /// IXSHNO.
        /// </summary>
        public const string IXSHNO = "IXSHNO";

        /// <summary>
        /// IXOMCU.
        /// </summary>
        public const string IXOMCU = "IXOMCU";

        /// <summary>
        /// IXOBJ.
        /// </summary>
        public const string IXOBJ = "IXOBJ";

        /// <summary>
        /// IXSUB.
        /// </summary>
        public const string IXSUB = "IXSUB";

        /// <summary>
        /// IXBREV.
        /// </summary>
        public const string IXBREV = "IXBREV";

        /// <summary>
        /// IXCMRV.
        /// </summary>
        public const string IXCMRV = "IXCMRV";

        /// <summary>
        /// IXRVNO.
        /// </summary>
        public const string IXRVNO = "IXRVNO";

        /// <summary>
        /// IXUUPG.
        /// </summary>
        public const string IXUUPG = "IXUUPG";

        /// <summary>
        /// IXURCD.
        /// </summary>
        public const string IXURCD = "IXURCD";

        /// <summary>
        /// IXURDT.
        /// </summary>
        public const string IXURDT = "IXURDT";

        /// <summary>
        /// IXURAT.
        /// </summary>
        public const string IXURAT = "IXURAT";

        /// <summary>
        /// IXURRF.
        /// </summary>
        public const string IXURRF = "IXURRF";

        /// <summary>
        /// IXURAB.
        /// </summary>
        public const string IXURAB = "IXURAB";

        /// <summary>
        /// IXUSER.
        /// </summary>
        public const string IXUSER = "IXUSER";

        /// <summary>
        /// IXPID.
        /// </summary>
        public const string IXPID = "IXPID";

        /// <summary>
        /// IXJOBN.
        /// </summary>
        public const string IXJOBN = "IXJOBN";

        /// <summary>
        /// IXUPMJ.
        /// </summary>
        public const string IXUPMJ = "IXUPMJ";

        /// <summary>
        /// IXTDAY.
        /// </summary>
        public const string IXTDAY = "IXTDAY";

        /// <summary>
        /// IXAING.
        /// </summary>
        public const string IXAING = "IXAING";

        /// <summary>
        /// IXSUCO.
        /// </summary>
        public const string IXSUCO = "IXSUCO";

        /// <summary>
        /// IXSTRC.
        /// </summary>
        public const string IXSTRC = "IXSTRC";

        /// <summary>
        /// IXENDC.
        /// </summary>
        public const string IXENDC = "IXENDC";

        /// <summary>
        /// IXAPSC.
        /// </summary>
        public const string IXAPSC = "IXAPSC";

        /// <summary>
        /// IXCPNB.
        /// </summary>
        public const string IXCPNB = "IXCPNB";

        /// <summary>
        /// IXBSEQAN.
        /// </summary>
        public const string IXBSEQAN = "IXBSEQAN";

        /// <summary>
        /// IXBCHAR.
        /// </summary>
        public const string IXBCHAR = "IXBCHAR";

        /// <summary>
        /// IXBOSTR.
        /// </summary>
        public const string IXBOSTR = "IXBOSTR";
    }

    /// <inheritdoc />
    public override string TableName => "F3002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IXTBM", "IXTBM", JdeDataType.String, 6, true, true),
        new JdeField("IXKIT", "IXKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("IXKITL", "IXKITL", JdeDataType.String, 50),
        new JdeField("IXKITA", "IXKITA", JdeDataType.String, 50),
        new JdeField("IXMMCU", "IXMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IXITM", "IXITM", JdeDataType.Numeric),
        new JdeField("IXLITM", "IXLITM", JdeDataType.String, 50),
        new JdeField("IXAITM", "IXAITM", JdeDataType.String, 50),
        new JdeField("IXCMCU", "IXCMCU", JdeDataType.String, 24),
        new JdeField("IXCPNT", "IXCPNT", JdeDataType.Numeric),
        new JdeField("IXSBNT", "IXSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("IXPRTA", "IXPRTA", JdeDataType.String, 2),
        new JdeField("IXQNTY", "IXQNTY", JdeDataType.Numeric),
        new JdeField("IXUM", "IXUM", JdeDataType.String, 4),
        new JdeField("IXBQTY", "IXBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("IXUOM", "IXUOM", JdeDataType.String, 4),
        new JdeField("IXFVBT", "IXFVBT", JdeDataType.String, 2),
        new JdeField("IXEFFF", "IXEFFF", JdeDataType.Numeric),
        new JdeField("IXEFFT", "IXEFFT", JdeDataType.Numeric),
        new JdeField("IXFSER", "IXFSER", JdeDataType.String, 50),
        new JdeField("IXTSER", "IXTSER", JdeDataType.String, 50),
        new JdeField("IXITC", "IXITC", JdeDataType.String, 2),
        new JdeField("IXFTRC", "IXFTRC", JdeDataType.String, 2),
        new JdeField("IXOPTK", "IXOPTK", JdeDataType.String, 2),
        new JdeField("IXFORV", "IXFORV", JdeDataType.String, 2),
        new JdeField("IXCSTM", "IXCSTM", JdeDataType.String, 2),
        new JdeField("IXCSMP", "IXCSMP", JdeDataType.String, 2),
        new JdeField("IXORDW", "IXORDW", JdeDataType.String, 2),
        new JdeField("IXFORQ", "IXFORQ", JdeDataType.String, 2),
        new JdeField("IXCOBY", "IXCOBY", JdeDataType.String, 2, true, true),
        new JdeField("IXCOTY", "IXCOTY", JdeDataType.String, 2),
        new JdeField("IXFRMP", "IXFRMP", JdeDataType.Numeric),
        new JdeField("IXTHRP", "IXTHRP", JdeDataType.Numeric),
        new JdeField("IXFRGD", "IXFRGD", JdeDataType.String, 6),
        new JdeField("IXTHGD", "IXTHGD", JdeDataType.String, 6),
        new JdeField("IXOPSQ", "IXOPSQ", JdeDataType.Numeric),
        new JdeField("IXBSEQ", "IXBSEQ", JdeDataType.Numeric),
        new JdeField("IXFTRP", "IXFTRP", JdeDataType.Numeric),
        new JdeField("IXF$RP", "IXF$RP", JdeDataType.Numeric),
        new JdeField("IXRSCP", "IXRSCP", JdeDataType.Numeric),
        new JdeField("IXSCRP", "IXSCRP", JdeDataType.Numeric),
        new JdeField("IXREWP", "IXREWP", JdeDataType.Numeric),
        new JdeField("IXASIP", "IXASIP", JdeDataType.Numeric),
        new JdeField("IXCPYP", "IXCPYP", JdeDataType.Numeric),
        new JdeField("IXSTPP", "IXSTPP", JdeDataType.Numeric),
        new JdeField("IXLOVD", "IXLOVD", JdeDataType.Numeric),
        new JdeField("IXECO", "IXECO", JdeDataType.String, 24),
        new JdeField("IXECTY", "IXECTY", JdeDataType.String, 4),
        new JdeField("IXECOD", "IXECOD", JdeDataType.Numeric),
        new JdeField("IXDSC1", "IXDSC1", JdeDataType.String, 60),
        new JdeField("IXLNTY", "IXLNTY", JdeDataType.String, 4),
        new JdeField("IXPRIC", "IXPRIC", JdeDataType.Numeric),
        new JdeField("IXUNCS", "IXUNCS", JdeDataType.Numeric),
        new JdeField("IXPCTK", "IXPCTK", JdeDataType.Numeric),
        new JdeField("IXSHNO", "IXSHNO", JdeDataType.String, 20),
        new JdeField("IXOMCU", "IXOMCU", JdeDataType.String, 24),
        new JdeField("IXOBJ", "IXOBJ", JdeDataType.String, 12),
        new JdeField("IXSUB", "IXSUB", JdeDataType.String, 16),
        new JdeField("IXBREV", "IXBREV", JdeDataType.String, 6),
        new JdeField("IXCMRV", "IXCMRV", JdeDataType.String, 6),
        new JdeField("IXRVNO", "IXRVNO", JdeDataType.String, 4),
        new JdeField("IXUUPG", "IXUUPG", JdeDataType.Numeric),
        new JdeField("IXURCD", "IXURCD", JdeDataType.String, 4),
        new JdeField("IXURDT", "IXURDT", JdeDataType.Numeric),
        new JdeField("IXURAT", "IXURAT", JdeDataType.Numeric),
        new JdeField("IXURRF", "IXURRF", JdeDataType.String, 30),
        new JdeField("IXURAB", "IXURAB", JdeDataType.Numeric),
        new JdeField("IXUSER", "IXUSER", JdeDataType.String, 20),
        new JdeField("IXPID", "IXPID", JdeDataType.String, 20),
        new JdeField("IXJOBN", "IXJOBN", JdeDataType.String, 20),
        new JdeField("IXUPMJ", "IXUPMJ", JdeDataType.Numeric),
        new JdeField("IXTDAY", "IXTDAY", JdeDataType.Numeric),
        new JdeField("IXAING", "IXAING", JdeDataType.String, 2),
        new JdeField("IXSUCO", "IXSUCO", JdeDataType.Numeric),
        new JdeField("IXSTRC", "IXSTRC", JdeDataType.Numeric),
        new JdeField("IXENDC", "IXENDC", JdeDataType.Numeric),
        new JdeField("IXAPSC", "IXAPSC", JdeDataType.String, 2),
        new JdeField("IXCPNB", "IXCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("IXBSEQAN", "IXBSEQAN", JdeDataType.String, 10),
        new JdeField("IXBCHAR", "IXBCHAR", JdeDataType.String, 2),
        new JdeField("IXBOSTR", "IXBOSTR", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3002_0", "Primary Key on IXKIT, IXMMCU, IXTBM, IXBQTY, IXCPNB, IXSBNT, IXCOBY", new[] { "IXKIT", "IXMMCU", "IXTBM", "IXBQTY", "IXCPNB", "IXSBNT", "IXCOBY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3002_10", "Index on IXCOBY, IXMMCU, IXKIT, IXTBM, IXBQTY, IXOPSQ, IXCPNB, IXSBNT", new[] { "IXCOBY", "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "IXOPSQ", "IXCPNB", "IXSBNT" }),
        new JdeIndex("F3002_11", "Index on IXMMCU, IXKIT, IXTBM, IXBQTY, IXCPNB", new[] { "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "IXCPNB" }),
        new JdeIndex("F3002_12", "Index on IXMMCU, IXKIT, IXTBM, IXBQTY, SYS_NC00082$, IXLNTY", new[] { "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "SYS_NC00082$", "IXLNTY" }),
        new JdeIndex("F3002_13", "Index on IXKIT, IXMMCU, IXTBM, IXBQTY, IXCOBY, IXCPNB, IXSBNT", new[] { "IXKIT", "IXMMCU", "IXTBM", "IXBQTY", "IXCOBY", "IXCPNB", "IXSBNT" }),
        new JdeIndex("F3002_14", "Index on IXCOBY, IXMMCU, IXKIT, IXTBM, IXBQTY, SYS_NC00082$, SYS_NC00083$", new[] { "IXCOBY", "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "SYS_NC00082$", "SYS_NC00083$" }),
        new JdeIndex("F3002_16", "Index on IXMMCU, IXKIT, IXTBM, IXBQTY, IXCOBY", new[] { "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "IXCOBY" }),
        new JdeIndex("F3002_17", "Index on IXMMCU, IXKIT, IXTBM, IXBQTY", new[] { "IXMMCU", "IXKIT", "IXTBM", "IXBQTY" }),
        new JdeIndex("F3002_18", "Index on IXTBM, IXKIT, IXMMCU, IXBQTY, IXBREV, IXEFFF, IXEFFT, IXOPSQ", new[] { "IXTBM", "IXKIT", "IXMMCU", "IXBQTY", "IXBREV", "IXEFFF", "IXEFFT", "IXOPSQ" }),
        new JdeIndex("F3002_19", "Index on IXTBM, IXKIT, IXMMCU", new[] { "IXTBM", "IXKIT", "IXMMCU" }),
        new JdeIndex("F3002_2", "Index on IXCMCU, IXITM, IXKIT, IXMMCU, IXTBM, IXBQTY", new[] { "IXCMCU", "IXITM", "IXKIT", "IXMMCU", "IXTBM", "IXBQTY" }),
        new JdeIndex("F3002_20", "Index on IXURAB", new[] { "IXURAB" }),
        new JdeIndex("F3002_3", "Index on IXMMCU, IXKIT, IXTBM, IXBQTY, IXITM, IXCMCU, IXOPSQ, IXEFFT", new[] { "IXMMCU", "IXKIT", "IXTBM", "IXBQTY", "IXITM", "IXCMCU", "IXOPSQ", "IXEFFT" }),
        new JdeIndex("F3002_4", "Index on IXTBM, IXKIT, IXMMCU, IXBQTY, IXITM, IXCMCU, IXCPNB, IXEFFT", new[] { "IXTBM", "IXKIT", "IXMMCU", "IXBQTY", "IXITM", "IXCMCU", "IXCPNB", "IXEFFT" }),
        new JdeIndex("F3002_5", "Index on IXKIT, IXMMCU, IXTBM, IXBQTY, IXOPSQ, IXCPNB", new[] { "IXKIT", "IXMMCU", "IXTBM", "IXBQTY", "IXOPSQ", "IXCPNB" }),
        new JdeIndex("F3002_6", "Index on IXTBM, IXMMCU, IXKIT, IXCOBY", new[] { "IXTBM", "IXMMCU", "IXKIT", "IXCOBY" }),
        new JdeIndex("F3002_7", "Index on IXITM, IXCMCU, IXTBM, IXQNTY, IXUM, IXOPSQ, IXCPNB", new[] { "IXITM", "IXCMCU", "IXTBM", "IXQNTY", "IXUM", "IXOPSQ", "IXCPNB" }),
        new JdeIndex("F3002_8", "Index on IXCOBY, IXKIT, IXMMCU, IXTBM, IXBQTY, IXOPSQ, IXCPNB", new[] { "IXCOBY", "IXKIT", "IXMMCU", "IXTBM", "IXBQTY", "IXOPSQ", "IXCPNB" }),
        new JdeIndex("F3002_9", "Index on IXCOBY, IXITM, IXCMCU, IXTBM, IXQNTY, IXUM, IXOPSQ", new[] { "IXCOBY", "IXITM", "IXCMCU", "IXTBM", "IXQNTY", "IXUM", "IXOPSQ" })
    };
}
