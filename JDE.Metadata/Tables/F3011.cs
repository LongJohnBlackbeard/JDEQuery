using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3011 - .
/// </summary>
public class F3011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IZTBM.
        /// </summary>
        public const string IZTBM = "IZTBM";

        /// <summary>
        /// IZKIT.
        /// </summary>
        public const string IZKIT = "IZKIT";

        /// <summary>
        /// IZKITL.
        /// </summary>
        public const string IZKITL = "IZKITL";

        /// <summary>
        /// IZKITA.
        /// </summary>
        public const string IZKITA = "IZKITA";

        /// <summary>
        /// IZMMCU.
        /// </summary>
        public const string IZMMCU = "IZMMCU";

        /// <summary>
        /// IZITM.
        /// </summary>
        public const string IZITM = "IZITM";

        /// <summary>
        /// IZLITM.
        /// </summary>
        public const string IZLITM = "IZLITM";

        /// <summary>
        /// IZAITM.
        /// </summary>
        public const string IZAITM = "IZAITM";

        /// <summary>
        /// IZCMCU.
        /// </summary>
        public const string IZCMCU = "IZCMCU";

        /// <summary>
        /// IZCPNT.
        /// </summary>
        public const string IZCPNT = "IZCPNT";

        /// <summary>
        /// IZSBNT.
        /// </summary>
        public const string IZSBNT = "IZSBNT";

        /// <summary>
        /// IZPRTA.
        /// </summary>
        public const string IZPRTA = "IZPRTA";

        /// <summary>
        /// IZQNTY.
        /// </summary>
        public const string IZQNTY = "IZQNTY";

        /// <summary>
        /// IZUM.
        /// </summary>
        public const string IZUM = "IZUM";

        /// <summary>
        /// IZBQTY.
        /// </summary>
        public const string IZBQTY = "IZBQTY";

        /// <summary>
        /// IZUOM.
        /// </summary>
        public const string IZUOM = "IZUOM";

        /// <summary>
        /// IZFVBT.
        /// </summary>
        public const string IZFVBT = "IZFVBT";

        /// <summary>
        /// IZEFFF.
        /// </summary>
        public const string IZEFFF = "IZEFFF";

        /// <summary>
        /// IZEFFT.
        /// </summary>
        public const string IZEFFT = "IZEFFT";

        /// <summary>
        /// IZFSER.
        /// </summary>
        public const string IZFSER = "IZFSER";

        /// <summary>
        /// IZTSER.
        /// </summary>
        public const string IZTSER = "IZTSER";

        /// <summary>
        /// IZITC.
        /// </summary>
        public const string IZITC = "IZITC";

        /// <summary>
        /// IZFTRC.
        /// </summary>
        public const string IZFTRC = "IZFTRC";

        /// <summary>
        /// IZOPTK.
        /// </summary>
        public const string IZOPTK = "IZOPTK";

        /// <summary>
        /// IZFORV.
        /// </summary>
        public const string IZFORV = "IZFORV";

        /// <summary>
        /// IZCSTM.
        /// </summary>
        public const string IZCSTM = "IZCSTM";

        /// <summary>
        /// IZCSMP.
        /// </summary>
        public const string IZCSMP = "IZCSMP";

        /// <summary>
        /// IZORDW.
        /// </summary>
        public const string IZORDW = "IZORDW";

        /// <summary>
        /// IZFORQ.
        /// </summary>
        public const string IZFORQ = "IZFORQ";

        /// <summary>
        /// IZCOBY.
        /// </summary>
        public const string IZCOBY = "IZCOBY";

        /// <summary>
        /// IZCOTY.
        /// </summary>
        public const string IZCOTY = "IZCOTY";

        /// <summary>
        /// IZFRMP.
        /// </summary>
        public const string IZFRMP = "IZFRMP";

        /// <summary>
        /// IZTHRP.
        /// </summary>
        public const string IZTHRP = "IZTHRP";

        /// <summary>
        /// IZFRGD.
        /// </summary>
        public const string IZFRGD = "IZFRGD";

        /// <summary>
        /// IZTHGD.
        /// </summary>
        public const string IZTHGD = "IZTHGD";

        /// <summary>
        /// IZOPSQ.
        /// </summary>
        public const string IZOPSQ = "IZOPSQ";

        /// <summary>
        /// IZBSEQ.
        /// </summary>
        public const string IZBSEQ = "IZBSEQ";

        /// <summary>
        /// IZFTRP.
        /// </summary>
        public const string IZFTRP = "IZFTRP";

        /// <summary>
        /// IZF$RP.
        /// </summary>
        public const string IZF_RP = "IZF$RP";

        /// <summary>
        /// IZRSCP.
        /// </summary>
        public const string IZRSCP = "IZRSCP";

        /// <summary>
        /// IZSCRP.
        /// </summary>
        public const string IZSCRP = "IZSCRP";

        /// <summary>
        /// IZREWP.
        /// </summary>
        public const string IZREWP = "IZREWP";

        /// <summary>
        /// IZASIP.
        /// </summary>
        public const string IZASIP = "IZASIP";

        /// <summary>
        /// IZCPYP.
        /// </summary>
        public const string IZCPYP = "IZCPYP";

        /// <summary>
        /// IZSTPP.
        /// </summary>
        public const string IZSTPP = "IZSTPP";

        /// <summary>
        /// IZLOVD.
        /// </summary>
        public const string IZLOVD = "IZLOVD";

        /// <summary>
        /// IZECO.
        /// </summary>
        public const string IZECO = "IZECO";

        /// <summary>
        /// IZECTY.
        /// </summary>
        public const string IZECTY = "IZECTY";

        /// <summary>
        /// IZECOD.
        /// </summary>
        public const string IZECOD = "IZECOD";

        /// <summary>
        /// IZDSC1.
        /// </summary>
        public const string IZDSC1 = "IZDSC1";

        /// <summary>
        /// IZLNTY.
        /// </summary>
        public const string IZLNTY = "IZLNTY";

        /// <summary>
        /// IZPRIC.
        /// </summary>
        public const string IZPRIC = "IZPRIC";

        /// <summary>
        /// IZUNCS.
        /// </summary>
        public const string IZUNCS = "IZUNCS";

        /// <summary>
        /// IZPCTK.
        /// </summary>
        public const string IZPCTK = "IZPCTK";

        /// <summary>
        /// IZSHNO.
        /// </summary>
        public const string IZSHNO = "IZSHNO";

        /// <summary>
        /// IZOMCU.
        /// </summary>
        public const string IZOMCU = "IZOMCU";

        /// <summary>
        /// IZOBJ.
        /// </summary>
        public const string IZOBJ = "IZOBJ";

        /// <summary>
        /// IZSUB.
        /// </summary>
        public const string IZSUB = "IZSUB";

        /// <summary>
        /// IZBREV.
        /// </summary>
        public const string IZBREV = "IZBREV";

        /// <summary>
        /// IZCMRV.
        /// </summary>
        public const string IZCMRV = "IZCMRV";

        /// <summary>
        /// IZRVNO.
        /// </summary>
        public const string IZRVNO = "IZRVNO";

        /// <summary>
        /// IZUUPG.
        /// </summary>
        public const string IZUUPG = "IZUUPG";

        /// <summary>
        /// IZURCD.
        /// </summary>
        public const string IZURCD = "IZURCD";

        /// <summary>
        /// IZURDT.
        /// </summary>
        public const string IZURDT = "IZURDT";

        /// <summary>
        /// IZURAT.
        /// </summary>
        public const string IZURAT = "IZURAT";

        /// <summary>
        /// IZURRF.
        /// </summary>
        public const string IZURRF = "IZURRF";

        /// <summary>
        /// IZURAB.
        /// </summary>
        public const string IZURAB = "IZURAB";

        /// <summary>
        /// IZUSER.
        /// </summary>
        public const string IZUSER = "IZUSER";

        /// <summary>
        /// IZPID.
        /// </summary>
        public const string IZPID = "IZPID";

        /// <summary>
        /// IZJOBN.
        /// </summary>
        public const string IZJOBN = "IZJOBN";

        /// <summary>
        /// IZUPMJ.
        /// </summary>
        public const string IZUPMJ = "IZUPMJ";

        /// <summary>
        /// IZTDAY.
        /// </summary>
        public const string IZTDAY = "IZTDAY";

        /// <summary>
        /// IZAING.
        /// </summary>
        public const string IZAING = "IZAING";

        /// <summary>
        /// IZSUCO.
        /// </summary>
        public const string IZSUCO = "IZSUCO";

        /// <summary>
        /// IZSTRC.
        /// </summary>
        public const string IZSTRC = "IZSTRC";

        /// <summary>
        /// IZENDC.
        /// </summary>
        public const string IZENDC = "IZENDC";

        /// <summary>
        /// IZAPSC.
        /// </summary>
        public const string IZAPSC = "IZAPSC";

        /// <summary>
        /// IZCPNB.
        /// </summary>
        public const string IZCPNB = "IZCPNB";

        /// <summary>
        /// IZBSEQAN.
        /// </summary>
        public const string IZBSEQAN = "IZBSEQAN";

        /// <summary>
        /// IZBCHAR.
        /// </summary>
        public const string IZBCHAR = "IZBCHAR";

        /// <summary>
        /// IZBOSTR.
        /// </summary>
        public const string IZBOSTR = "IZBOSTR";

        /// <summary>
        /// IZACTN.
        /// </summary>
        public const string IZACTN = "IZACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F3011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IZTBM", "IZTBM", JdeDataType.String, 6, true, true),
        new JdeField("IZKIT", "IZKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("IZKITL", "IZKITL", JdeDataType.String, 50),
        new JdeField("IZKITA", "IZKITA", JdeDataType.String, 50),
        new JdeField("IZMMCU", "IZMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IZITM", "IZITM", JdeDataType.Numeric),
        new JdeField("IZLITM", "IZLITM", JdeDataType.String, 50),
        new JdeField("IZAITM", "IZAITM", JdeDataType.String, 50),
        new JdeField("IZCMCU", "IZCMCU", JdeDataType.String, 24),
        new JdeField("IZCPNT", "IZCPNT", JdeDataType.Numeric),
        new JdeField("IZSBNT", "IZSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("IZPRTA", "IZPRTA", JdeDataType.String, 2),
        new JdeField("IZQNTY", "IZQNTY", JdeDataType.Numeric),
        new JdeField("IZUM", "IZUM", JdeDataType.String, 4),
        new JdeField("IZBQTY", "IZBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("IZUOM", "IZUOM", JdeDataType.String, 4),
        new JdeField("IZFVBT", "IZFVBT", JdeDataType.String, 2),
        new JdeField("IZEFFF", "IZEFFF", JdeDataType.Numeric),
        new JdeField("IZEFFT", "IZEFFT", JdeDataType.Numeric),
        new JdeField("IZFSER", "IZFSER", JdeDataType.String, 50),
        new JdeField("IZTSER", "IZTSER", JdeDataType.String, 50),
        new JdeField("IZITC", "IZITC", JdeDataType.String, 2),
        new JdeField("IZFTRC", "IZFTRC", JdeDataType.String, 2),
        new JdeField("IZOPTK", "IZOPTK", JdeDataType.String, 2),
        new JdeField("IZFORV", "IZFORV", JdeDataType.String, 2),
        new JdeField("IZCSTM", "IZCSTM", JdeDataType.String, 2),
        new JdeField("IZCSMP", "IZCSMP", JdeDataType.String, 2),
        new JdeField("IZORDW", "IZORDW", JdeDataType.String, 2),
        new JdeField("IZFORQ", "IZFORQ", JdeDataType.String, 2),
        new JdeField("IZCOBY", "IZCOBY", JdeDataType.String, 2),
        new JdeField("IZCOTY", "IZCOTY", JdeDataType.String, 2),
        new JdeField("IZFRMP", "IZFRMP", JdeDataType.Numeric),
        new JdeField("IZTHRP", "IZTHRP", JdeDataType.Numeric),
        new JdeField("IZFRGD", "IZFRGD", JdeDataType.String, 6),
        new JdeField("IZTHGD", "IZTHGD", JdeDataType.String, 6),
        new JdeField("IZOPSQ", "IZOPSQ", JdeDataType.Numeric),
        new JdeField("IZBSEQ", "IZBSEQ", JdeDataType.Numeric),
        new JdeField("IZFTRP", "IZFTRP", JdeDataType.Numeric),
        new JdeField("IZF$RP", "IZF$RP", JdeDataType.Numeric),
        new JdeField("IZRSCP", "IZRSCP", JdeDataType.Numeric),
        new JdeField("IZSCRP", "IZSCRP", JdeDataType.Numeric),
        new JdeField("IZREWP", "IZREWP", JdeDataType.Numeric),
        new JdeField("IZASIP", "IZASIP", JdeDataType.Numeric),
        new JdeField("IZCPYP", "IZCPYP", JdeDataType.Numeric),
        new JdeField("IZSTPP", "IZSTPP", JdeDataType.Numeric),
        new JdeField("IZLOVD", "IZLOVD", JdeDataType.Numeric),
        new JdeField("IZECO", "IZECO", JdeDataType.String, 24),
        new JdeField("IZECTY", "IZECTY", JdeDataType.String, 4),
        new JdeField("IZECOD", "IZECOD", JdeDataType.Numeric),
        new JdeField("IZDSC1", "IZDSC1", JdeDataType.String, 60),
        new JdeField("IZLNTY", "IZLNTY", JdeDataType.String, 4),
        new JdeField("IZPRIC", "IZPRIC", JdeDataType.Numeric),
        new JdeField("IZUNCS", "IZUNCS", JdeDataType.Numeric),
        new JdeField("IZPCTK", "IZPCTK", JdeDataType.Numeric),
        new JdeField("IZSHNO", "IZSHNO", JdeDataType.String, 20),
        new JdeField("IZOMCU", "IZOMCU", JdeDataType.String, 24),
        new JdeField("IZOBJ", "IZOBJ", JdeDataType.String, 12),
        new JdeField("IZSUB", "IZSUB", JdeDataType.String, 16),
        new JdeField("IZBREV", "IZBREV", JdeDataType.String, 6),
        new JdeField("IZCMRV", "IZCMRV", JdeDataType.String, 6),
        new JdeField("IZRVNO", "IZRVNO", JdeDataType.String, 4),
        new JdeField("IZUUPG", "IZUUPG", JdeDataType.Numeric),
        new JdeField("IZURCD", "IZURCD", JdeDataType.String, 4),
        new JdeField("IZURDT", "IZURDT", JdeDataType.Numeric),
        new JdeField("IZURAT", "IZURAT", JdeDataType.Numeric),
        new JdeField("IZURRF", "IZURRF", JdeDataType.String, 30),
        new JdeField("IZURAB", "IZURAB", JdeDataType.Numeric),
        new JdeField("IZUSER", "IZUSER", JdeDataType.String, 20),
        new JdeField("IZPID", "IZPID", JdeDataType.String, 20),
        new JdeField("IZJOBN", "IZJOBN", JdeDataType.String, 20),
        new JdeField("IZUPMJ", "IZUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IZTDAY", "IZTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("IZAING", "IZAING", JdeDataType.String, 2),
        new JdeField("IZSUCO", "IZSUCO", JdeDataType.Numeric),
        new JdeField("IZSTRC", "IZSTRC", JdeDataType.Numeric),
        new JdeField("IZENDC", "IZENDC", JdeDataType.Numeric),
        new JdeField("IZAPSC", "IZAPSC", JdeDataType.String, 2),
        new JdeField("IZCPNB", "IZCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("IZBSEQAN", "IZBSEQAN", JdeDataType.String, 10),
        new JdeField("IZBCHAR", "IZBCHAR", JdeDataType.String, 2),
        new JdeField("IZBOSTR", "IZBOSTR", JdeDataType.String, 8),
        new JdeField("IZACTN", "IZACTN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3011_0", "Primary Key on IZMMCU, IZTDAY, IZKIT, IZBQTY, IZTBM, IZCPNB, IZSBNT, IZUPMJ", new[] { "IZMMCU", "IZTDAY", "IZKIT", "IZBQTY", "IZTBM", "IZCPNB", "IZSBNT", "IZUPMJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3011_7", "Index on IZITM", new[] { "IZITM" }),
        new JdeIndex("F3011_8", "Index on IZKIT", new[] { "IZKIT" })
    };
}
