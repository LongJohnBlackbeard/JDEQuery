using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F300211 - .
/// </summary>
public class F300211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDUKID.
        /// </summary>
        public const string EDUKID = "EDUKID";

        /// <summary>
        /// EDOKIT.
        /// </summary>
        public const string EDOKIT = "EDOKIT";

        /// <summary>
        /// EDMCU0.
        /// </summary>
        public const string EDMCU0 = "EDMCU0";

        /// <summary>
        /// EDOTBM.
        /// </summary>
        public const string EDOTBM = "EDOTBM";

        /// <summary>
        /// ED#BQT.
        /// </summary>
        public const string ED_BQT = "ED#BQT";

        /// <summary>
        /// EDKIT.
        /// </summary>
        public const string EDKIT = "EDKIT";

        /// <summary>
        /// EDTBM.
        /// </summary>
        public const string EDTBM = "EDTBM";

        /// <summary>
        /// EDMMCU.
        /// </summary>
        public const string EDMMCU = "EDMMCU";

        /// <summary>
        /// EDLBQTY.
        /// </summary>
        public const string EDLBQTY = "EDLBQTY";

        /// <summary>
        /// EDITM.
        /// </summary>
        public const string EDITM = "EDITM";

        /// <summary>
        /// EDCMCU.
        /// </summary>
        public const string EDCMCU = "EDCMCU";

        /// <summary>
        /// EDBQTE1.
        /// </summary>
        public const string EDBQTE1 = "EDBQTE1";

        /// <summary>
        /// EDUOM1.
        /// </summary>
        public const string EDUOM1 = "EDUOM1";

        /// <summary>
        /// EDCPNT.
        /// </summary>
        public const string EDCPNT = "EDCPNT";

        /// <summary>
        /// EDBRVN.
        /// </summary>
        public const string EDBRVN = "EDBRVN";

        /// <summary>
        /// EDDFMLINE.
        /// </summary>
        public const string EDDFMLINE = "EDDFMLINE";

        /// <summary>
        /// EDOPSQ.
        /// </summary>
        public const string EDOPSQ = "EDOPSQ";

        /// <summary>
        /// EDLBOM.
        /// </summary>
        public const string EDLBOM = "EDLBOM";

        /// <summary>
        /// EDSTKT.
        /// </summary>
        public const string EDSTKT = "EDSTKT";

        /// <summary>
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDLQNTY.
        /// </summary>
        public const string EDLQNTY = "EDLQNTY";

        /// <summary>
        /// EDQNTY.
        /// </summary>
        public const string EDQNTY = "EDQNTY";

        /// <summary>
        /// EDUM.
        /// </summary>
        public const string EDUM = "EDUM";

        /// <summary>
        /// EDOPSC.
        /// </summary>
        public const string EDOPSC = "EDOPSC";

        /// <summary>
        /// EDTYCOMP.
        /// </summary>
        public const string EDTYCOMP = "EDTYCOMP";

        /// <summary>
        /// EDBOSTR.
        /// </summary>
        public const string EDBOSTR = "EDBOSTR";

        /// <summary>
        /// EDSBNT.
        /// </summary>
        public const string EDSBNT = "EDSBNT";

        /// <summary>
        /// EDPRTA.
        /// </summary>
        public const string EDPRTA = "EDPRTA";

        /// <summary>
        /// EDFVBT.
        /// </summary>
        public const string EDFVBT = "EDFVBT";

        /// <summary>
        /// EDUEFFD.
        /// </summary>
        public const string EDUEFFD = "EDUEFFD";

        /// <summary>
        /// EDUEFTD.
        /// </summary>
        public const string EDUEFTD = "EDUEFTD";

        /// <summary>
        /// EDFSER.
        /// </summary>
        public const string EDFSER = "EDFSER";

        /// <summary>
        /// EDTSER.
        /// </summary>
        public const string EDTSER = "EDTSER";

        /// <summary>
        /// EDFTRC.
        /// </summary>
        public const string EDFTRC = "EDFTRC";

        /// <summary>
        /// EDITC.
        /// </summary>
        public const string EDITC = "EDITC";

        /// <summary>
        /// EDOPTK.
        /// </summary>
        public const string EDOPTK = "EDOPTK";

        /// <summary>
        /// EDFORV.
        /// </summary>
        public const string EDFORV = "EDFORV";

        /// <summary>
        /// EDCSTM.
        /// </summary>
        public const string EDCSTM = "EDCSTM";

        /// <summary>
        /// EDCSMP.
        /// </summary>
        public const string EDCSMP = "EDCSMP";

        /// <summary>
        /// EDORDW.
        /// </summary>
        public const string EDORDW = "EDORDW";

        /// <summary>
        /// EDFORQ.
        /// </summary>
        public const string EDFORQ = "EDFORQ";

        /// <summary>
        /// EDCOBY.
        /// </summary>
        public const string EDCOBY = "EDCOBY";

        /// <summary>
        /// EDCOTY.
        /// </summary>
        public const string EDCOTY = "EDCOTY";

        /// <summary>
        /// EDFRGD.
        /// </summary>
        public const string EDFRGD = "EDFRGD";

        /// <summary>
        /// EDTHGD.
        /// </summary>
        public const string EDTHGD = "EDTHGD";

        /// <summary>
        /// EDFRMP.
        /// </summary>
        public const string EDFRMP = "EDFRMP";

        /// <summary>
        /// EDTHRP.
        /// </summary>
        public const string EDTHRP = "EDTHRP";

        /// <summary>
        /// EDFTRP.
        /// </summary>
        public const string EDFTRP = "EDFTRP";

        /// <summary>
        /// EDRSCP.
        /// </summary>
        public const string EDRSCP = "EDRSCP";

        /// <summary>
        /// EDF$RP.
        /// </summary>
        public const string EDF_RP = "EDF$RP";

        /// <summary>
        /// EDSTPP.
        /// </summary>
        public const string EDSTPP = "EDSTPP";

        /// <summary>
        /// EDSCRP.
        /// </summary>
        public const string EDSCRP = "EDSCRP";

        /// <summary>
        /// EDREWP.
        /// </summary>
        public const string EDREWP = "EDREWP";

        /// <summary>
        /// EDASIP.
        /// </summary>
        public const string EDASIP = "EDASIP";

        /// <summary>
        /// EDCPYP.
        /// </summary>
        public const string EDCPYP = "EDCPYP";

        /// <summary>
        /// EDLOVD.
        /// </summary>
        public const string EDLOVD = "EDLOVD";

        /// <summary>
        /// EDECO.
        /// </summary>
        public const string EDECO = "EDECO";

        /// <summary>
        /// EDECOD.
        /// </summary>
        public const string EDECOD = "EDECOD";

        /// <summary>
        /// EDDSC1.
        /// </summary>
        public const string EDDSC1 = "EDDSC1";

        /// <summary>
        /// EDIFLOCN.
        /// </summary>
        public const string EDIFLOCN = "EDIFLOCN";

        /// <summary>
        /// EDLOCN.
        /// </summary>
        public const string EDLOCN = "EDLOCN";

        /// <summary>
        /// EDLOTN.
        /// </summary>
        public const string EDLOTN = "EDLOTN";

        /// <summary>
        /// EDAING.
        /// </summary>
        public const string EDAING = "EDAING";

        /// <summary>
        /// EDBSEQ.
        /// </summary>
        public const string EDBSEQ = "EDBSEQ";

        /// <summary>
        /// EDSUBAF.
        /// </summary>
        public const string EDSUBAF = "EDSUBAF";

        /// <summary>
        /// EDEBTKID.
        /// </summary>
        public const string EDEBTKID = "EDEBTKID";

        /// <summary>
        /// EDSRNK.
        /// </summary>
        public const string EDSRNK = "EDSRNK";

        /// <summary>
        /// EDSRKF.
        /// </summary>
        public const string EDSRKF = "EDSRKF";

        /// <summary>
        /// EDDRAW.
        /// </summary>
        public const string EDDRAW = "EDDRAW";

        /// <summary>
        /// EDLNTY.
        /// </summary>
        public const string EDLNTY = "EDLNTY";

        /// <summary>
        /// EDPRIC.
        /// </summary>
        public const string EDPRIC = "EDPRIC";

        /// <summary>
        /// EDSHNO.
        /// </summary>
        public const string EDSHNO = "EDSHNO";

        /// <summary>
        /// EDPCTK.
        /// </summary>
        public const string EDPCTK = "EDPCTK";

        /// <summary>
        /// EDUNCS.
        /// </summary>
        public const string EDUNCS = "EDUNCS";

        /// <summary>
        /// EDOMCU.
        /// </summary>
        public const string EDOMCU = "EDOMCU";

        /// <summary>
        /// EDOBJ.
        /// </summary>
        public const string EDOBJ = "EDOBJ";

        /// <summary>
        /// EDSUB.
        /// </summary>
        public const string EDSUB = "EDSUB";

        /// <summary>
        /// EDBREV.
        /// </summary>
        public const string EDBREV = "EDBREV";

        /// <summary>
        /// EDCMRV.
        /// </summary>
        public const string EDCMRV = "EDCMRV";

        /// <summary>
        /// EDRVNO.
        /// </summary>
        public const string EDRVNO = "EDRVNO";

        /// <summary>
        /// EDUUPG.
        /// </summary>
        public const string EDUUPG = "EDUUPG";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDSUCO.
        /// </summary>
        public const string EDSUCO = "EDSUCO";

        /// <summary>
        /// EDSTRC.
        /// </summary>
        public const string EDSTRC = "EDSTRC";

        /// <summary>
        /// EDENDC.
        /// </summary>
        public const string EDENDC = "EDENDC";

        /// <summary>
        /// EDCPNB.
        /// </summary>
        public const string EDCPNB = "EDCPNB";

        /// <summary>
        /// EDBSEQAN.
        /// </summary>
        public const string EDBSEQAN = "EDBSEQAN";

        /// <summary>
        /// EDAPSC.
        /// </summary>
        public const string EDAPSC = "EDAPSC";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDMKEY.
        /// </summary>
        public const string EDMKEY = "EDMKEY";

        /// <summary>
        /// EDUUPMJ.
        /// </summary>
        public const string EDUUPMJ = "EDUUPMJ";

        /// <summary>
        /// EDPRUKID.
        /// </summary>
        public const string EDPRUKID = "EDPRUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F300211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDUKID", "EDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EDOKIT", "EDOKIT", JdeDataType.Numeric),
        new JdeField("EDMCU0", "EDMCU0", JdeDataType.String, 24),
        new JdeField("EDOTBM", "EDOTBM", JdeDataType.String, 6),
        new JdeField("ED#BQT", "ED#BQT", JdeDataType.Numeric),
        new JdeField("EDKIT", "EDKIT", JdeDataType.Numeric),
        new JdeField("EDTBM", "EDTBM", JdeDataType.String, 6),
        new JdeField("EDMMCU", "EDMMCU", JdeDataType.String, 24),
        new JdeField("EDLBQTY", "EDLBQTY", JdeDataType.Numeric),
        new JdeField("EDITM", "EDITM", JdeDataType.Numeric),
        new JdeField("EDCMCU", "EDCMCU", JdeDataType.String, 24),
        new JdeField("EDBQTE1", "EDBQTE1", JdeDataType.Numeric),
        new JdeField("EDUOM1", "EDUOM1", JdeDataType.String, 4),
        new JdeField("EDCPNT", "EDCPNT", JdeDataType.Numeric),
        new JdeField("EDBRVN", "EDBRVN", JdeDataType.Numeric),
        new JdeField("EDDFMLINE", "EDDFMLINE", JdeDataType.String, 24),
        new JdeField("EDOPSQ", "EDOPSQ", JdeDataType.Numeric),
        new JdeField("EDLBOM", "EDLBOM", JdeDataType.Numeric),
        new JdeField("EDSTKT", "EDSTKT", JdeDataType.String, 2),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDLQNTY", "EDLQNTY", JdeDataType.Numeric),
        new JdeField("EDQNTY", "EDQNTY", JdeDataType.Numeric),
        new JdeField("EDUM", "EDUM", JdeDataType.String, 4),
        new JdeField("EDOPSC", "EDOPSC", JdeDataType.String, 4),
        new JdeField("EDTYCOMP", "EDTYCOMP", JdeDataType.String, 4),
        new JdeField("EDBOSTR", "EDBOSTR", JdeDataType.String, 8),
        new JdeField("EDSBNT", "EDSBNT", JdeDataType.Numeric),
        new JdeField("EDPRTA", "EDPRTA", JdeDataType.String, 2),
        new JdeField("EDFVBT", "EDFVBT", JdeDataType.String, 2),
        new JdeField("EDUEFFD", "EDUEFFD", JdeDataType.Date),
        new JdeField("EDUEFTD", "EDUEFTD", JdeDataType.Date),
        new JdeField("EDFSER", "EDFSER", JdeDataType.String, 50),
        new JdeField("EDTSER", "EDTSER", JdeDataType.String, 50),
        new JdeField("EDFTRC", "EDFTRC", JdeDataType.String, 2),
        new JdeField("EDITC", "EDITC", JdeDataType.String, 2),
        new JdeField("EDOPTK", "EDOPTK", JdeDataType.String, 2),
        new JdeField("EDFORV", "EDFORV", JdeDataType.String, 2),
        new JdeField("EDCSTM", "EDCSTM", JdeDataType.String, 2),
        new JdeField("EDCSMP", "EDCSMP", JdeDataType.String, 2),
        new JdeField("EDORDW", "EDORDW", JdeDataType.String, 2),
        new JdeField("EDFORQ", "EDFORQ", JdeDataType.String, 2),
        new JdeField("EDCOBY", "EDCOBY", JdeDataType.String, 2),
        new JdeField("EDCOTY", "EDCOTY", JdeDataType.String, 2),
        new JdeField("EDFRGD", "EDFRGD", JdeDataType.String, 6),
        new JdeField("EDTHGD", "EDTHGD", JdeDataType.String, 6),
        new JdeField("EDFRMP", "EDFRMP", JdeDataType.Numeric),
        new JdeField("EDTHRP", "EDTHRP", JdeDataType.Numeric),
        new JdeField("EDFTRP", "EDFTRP", JdeDataType.Numeric),
        new JdeField("EDRSCP", "EDRSCP", JdeDataType.Numeric),
        new JdeField("EDF$RP", "EDF$RP", JdeDataType.Numeric),
        new JdeField("EDSTPP", "EDSTPP", JdeDataType.Numeric),
        new JdeField("EDSCRP", "EDSCRP", JdeDataType.Numeric),
        new JdeField("EDREWP", "EDREWP", JdeDataType.Numeric),
        new JdeField("EDASIP", "EDASIP", JdeDataType.Numeric),
        new JdeField("EDCPYP", "EDCPYP", JdeDataType.Numeric),
        new JdeField("EDLOVD", "EDLOVD", JdeDataType.Numeric),
        new JdeField("EDECO", "EDECO", JdeDataType.String, 24),
        new JdeField("EDECOD", "EDECOD", JdeDataType.Numeric),
        new JdeField("EDDSC1", "EDDSC1", JdeDataType.String, 60),
        new JdeField("EDIFLOCN", "EDIFLOCN", JdeDataType.String, 40),
        new JdeField("EDLOCN", "EDLOCN", JdeDataType.String, 40),
        new JdeField("EDLOTN", "EDLOTN", JdeDataType.String, 60),
        new JdeField("EDAING", "EDAING", JdeDataType.String, 2),
        new JdeField("EDBSEQ", "EDBSEQ", JdeDataType.Numeric),
        new JdeField("EDSUBAF", "EDSUBAF", JdeDataType.String, 2),
        new JdeField("EDEBTKID", "EDEBTKID", JdeDataType.String, 64),
        new JdeField("EDSRNK", "EDSRNK", JdeDataType.Numeric),
        new JdeField("EDSRKF", "EDSRKF", JdeDataType.String, 2),
        new JdeField("EDDRAW", "EDDRAW", JdeDataType.String, 40),
        new JdeField("EDLNTY", "EDLNTY", JdeDataType.String, 4),
        new JdeField("EDPRIC", "EDPRIC", JdeDataType.Numeric),
        new JdeField("EDSHNO", "EDSHNO", JdeDataType.String, 20),
        new JdeField("EDPCTK", "EDPCTK", JdeDataType.Numeric),
        new JdeField("EDUNCS", "EDUNCS", JdeDataType.Numeric),
        new JdeField("EDOMCU", "EDOMCU", JdeDataType.String, 24),
        new JdeField("EDOBJ", "EDOBJ", JdeDataType.String, 12),
        new JdeField("EDSUB", "EDSUB", JdeDataType.String, 16),
        new JdeField("EDBREV", "EDBREV", JdeDataType.String, 6),
        new JdeField("EDCMRV", "EDCMRV", JdeDataType.String, 6),
        new JdeField("EDRVNO", "EDRVNO", JdeDataType.String, 4),
        new JdeField("EDUUPG", "EDUUPG", JdeDataType.Numeric),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDSUCO", "EDSUCO", JdeDataType.Numeric),
        new JdeField("EDSTRC", "EDSTRC", JdeDataType.Numeric),
        new JdeField("EDENDC", "EDENDC", JdeDataType.Numeric),
        new JdeField("EDCPNB", "EDCPNB", JdeDataType.Numeric),
        new JdeField("EDBSEQAN", "EDBSEQAN", JdeDataType.String, 10),
        new JdeField("EDAPSC", "EDAPSC", JdeDataType.String, 2),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDMKEY", "EDMKEY", JdeDataType.String, 30),
        new JdeField("EDUUPMJ", "EDUUPMJ", JdeDataType.Date),
        new JdeField("EDPRUKID", "EDPRUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F300211_0", "Primary Key on EDUKID", new[] { "EDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F300211_2", "Index on EDKIT, EDTBM, EDMMCU, EDITM, EDOPSQ", new[] { "EDKIT", "EDTBM", "EDMMCU", "EDITM", "EDOPSQ" }),
        new JdeIndex("F300211_3", "Index on EDKIT, EDMMCU, EDBRVN, EDLBOM", new[] { "EDKIT", "EDMMCU", "EDBRVN", "EDLBOM" }),
        new JdeIndex("F300211_4", "Index on EDOKIT, EDMCU0, EDOTBM, ED#BQT, EDDFMLINE", new[] { "EDOKIT", "EDMCU0", "EDOTBM", "ED#BQT", "EDDFMLINE" }),
        new JdeIndex("F300211_5", "Index on EDOKIT, EDMCU0, EDOTBM, ED#BQT, EDKIT, EDMMCU, EDTBM, EDLBQTY, EDDFMLINE, EDUOM", new[] { "EDOKIT", "EDMCU0", "EDOTBM", "ED#BQT", "EDKIT", "EDMMCU", "EDTBM", "EDLBQTY", "EDDFMLINE", "EDUOM" }),
        new JdeIndex("F300211_6", "Index on EDPRUKID", new[] { "EDPRUKID" })
    };
}
