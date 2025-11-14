using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1511 - .
/// </summary>
public class F1511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NJGENT.
        /// </summary>
        public const string NJGENT = "NJGENT";

        /// <summary>
        /// NJICU.
        /// </summary>
        public const string NJICU = "NJICU";

        /// <summary>
        /// NJDOC.
        /// </summary>
        public const string NJDOC = "NJDOC";

        /// <summary>
        /// NJSFX.
        /// </summary>
        public const string NJSFX = "NJSFX";

        /// <summary>
        /// NJDOCO.
        /// </summary>
        public const string NJDOCO = "NJDOCO";

        /// <summary>
        /// NJDCTO.
        /// </summary>
        public const string NJDCTO = "NJDCTO";

        /// <summary>
        /// NJSOSQ.
        /// </summary>
        public const string NJSOSQ = "NJSOSQ";

        /// <summary>
        /// NJMCUS.
        /// </summary>
        public const string NJMCUS = "NJMCUS";

        /// <summary>
        /// NJAN8.
        /// </summary>
        public const string NJAN8 = "NJAN8";

        /// <summary>
        /// NJAN8J.
        /// </summary>
        public const string NJAN8J = "NJAN8J";

        /// <summary>
        /// NJDL01.
        /// </summary>
        public const string NJDL01 = "NJDL01";

        /// <summary>
        /// NJMCU.
        /// </summary>
        public const string NJMCU = "NJMCU";

        /// <summary>
        /// NJOBJ.
        /// </summary>
        public const string NJOBJ = "NJOBJ";

        /// <summary>
        /// NJSUB.
        /// </summary>
        public const string NJSUB = "NJSUB";

        /// <summary>
        /// NJSBL.
        /// </summary>
        public const string NJSBL = "NJSBL";

        /// <summary>
        /// NJAID.
        /// </summary>
        public const string NJAID = "NJAID";

        /// <summary>
        /// NJCO.
        /// </summary>
        public const string NJCO = "NJCO";

        /// <summary>
        /// NJDG.
        /// </summary>
        public const string NJDG = "NJDG";

        /// <summary>
        /// NJDSV.
        /// </summary>
        public const string NJDSV = "NJDSV";

        /// <summary>
        /// NJGLC.
        /// </summary>
        public const string NJGLC = "NJGLC";

        /// <summary>
        /// NJBPN.
        /// </summary>
        public const string NJBPN = "NJBPN";

        /// <summary>
        /// NJYR.
        /// </summary>
        public const string NJYR = "NJYR";

        /// <summary>
        /// NJAG.
        /// </summary>
        public const string NJAG = "NJAG";

        /// <summary>
        /// NJAN01.
        /// </summary>
        public const string NJAN01 = "NJAN01";

        /// <summary>
        /// NJDI.
        /// </summary>
        public const string NJDI = "NJDI";

        /// <summary>
        /// NJDD.
        /// </summary>
        public const string NJDD = "NJDD";

        /// <summary>
        /// NJPTC.
        /// </summary>
        public const string NJPTC = "NJPTC";

        /// <summary>
        /// NJTRAN.
        /// </summary>
        public const string NJTRAN = "NJTRAN";

        /// <summary>
        /// NJSEPI.
        /// </summary>
        public const string NJSEPI = "NJSEPI";

        /// <summary>
        /// NJITMG.
        /// </summary>
        public const string NJITMG = "NJITMG";

        /// <summary>
        /// NJLNID.
        /// </summary>
        public const string NJLNID = "NJLNID";

        /// <summary>
        /// NJDIC.
        /// </summary>
        public const string NJDIC = "NJDIC";

        /// <summary>
        /// NJPDUE.
        /// </summary>
        public const string NJPDUE = "NJPDUE";

        /// <summary>
        /// NJEPCL.
        /// </summary>
        public const string NJEPCL = "NJEPCL";

        /// <summary>
        /// NJDPER.
        /// </summary>
        public const string NJDPER = "NJDPER";

        /// <summary>
        /// NJDPAR.
        /// </summary>
        public const string NJDPAR = "NJDPAR";

        /// <summary>
        /// NJEXCD.
        /// </summary>
        public const string NJEXCD = "NJEXCD";

        /// <summary>
        /// NJBCI.
        /// </summary>
        public const string NJBCI = "NJBCI";

        /// <summary>
        /// NJPRDC.
        /// </summary>
        public const string NJPRDC = "NJPRDC";

        /// <summary>
        /// NJYRO.
        /// </summary>
        public const string NJYRO = "NJYRO";

        /// <summary>
        /// NJCTRY.
        /// </summary>
        public const string NJCTRY = "NJCTRY";

        /// <summary>
        /// NJRPRD.
        /// </summary>
        public const string NJRPRD = "NJRPRD";

        /// <summary>
        /// NJCRCD.
        /// </summary>
        public const string NJCRCD = "NJCRCD";

        /// <summary>
        /// NJCRR.
        /// </summary>
        public const string NJCRR = "NJCRR";

        /// <summary>
        /// NJACR.
        /// </summary>
        public const string NJACR = "NJACR";

        /// <summary>
        /// NJTXA1.
        /// </summary>
        public const string NJTXA1 = "NJTXA1";

        /// <summary>
        /// NJEXR1.
        /// </summary>
        public const string NJEXR1 = "NJEXR1";

        /// <summary>
        /// NJSTAM.
        /// </summary>
        public const string NJSTAM = "NJSTAM";

        /// <summary>
        /// NJATXN.
        /// </summary>
        public const string NJATXN = "NJATXN";

        /// <summary>
        /// NJATXA.
        /// </summary>
        public const string NJATXA = "NJATXA";

        /// <summary>
        /// NJUSER.
        /// </summary>
        public const string NJUSER = "NJUSER";

        /// <summary>
        /// NJUPMJ.
        /// </summary>
        public const string NJUPMJ = "NJUPMJ";

        /// <summary>
        /// NJPID.
        /// </summary>
        public const string NJPID = "NJPID";

        /// <summary>
        /// NJJOBN.
        /// </summary>
        public const string NJJOBN = "NJJOBN";

        /// <summary>
        /// NJSBLT.
        /// </summary>
        public const string NJSBLT = "NJSBLT";

        /// <summary>
        /// NJCRRM.
        /// </summary>
        public const string NJCRRM = "NJCRRM";

        /// <summary>
        /// NJFAP.
        /// </summary>
        public const string NJFAP = "NJFAP";

        /// <summary>
        /// NJCDS.
        /// </summary>
        public const string NJCDS = "NJCDS";

        /// <summary>
        /// NJCDSA.
        /// </summary>
        public const string NJCDSA = "NJCDSA";

        /// <summary>
        /// NJCTAM.
        /// </summary>
        public const string NJCTAM = "NJCTAM";

        /// <summary>
        /// NJCTXA.
        /// </summary>
        public const string NJCTXA = "NJCTXA";

        /// <summary>
        /// NJCTXN.
        /// </summary>
        public const string NJCTXN = "NJCTXN";

        /// <summary>
        /// NJMI.
        /// </summary>
        public const string NJMI = "NJMI";

        /// <summary>
        /// NJDBAN.
        /// </summary>
        public const string NJDBAN = "NJDBAN";

        /// <summary>
        /// NJUNIT.
        /// </summary>
        public const string NJUNIT = "NJUNIT";

        /// <summary>
        /// NJBLMR.
        /// </summary>
        public const string NJBLMR = "NJBLMR";

        /// <summary>
        /// NJEFFC.
        /// </summary>
        public const string NJEFFC = "NJEFFC";

        /// <summary>
        /// NJSOBT.
        /// </summary>
        public const string NJSOBT = "NJSOBT";

        /// <summary>
        /// NJSBJR.
        /// </summary>
        public const string NJSBJR = "NJSBJR";

        /// <summary>
        /// NJICB1.
        /// </summary>
        public const string NJICB1 = "NJICB1";

        /// <summary>
        /// NJICB2.
        /// </summary>
        public const string NJICB2 = "NJICB2";

        /// <summary>
        /// NJICB3.
        /// </summary>
        public const string NJICB3 = "NJICB3";

        /// <summary>
        /// NJICB4.
        /// </summary>
        public const string NJICB4 = "NJICB4";

        /// <summary>
        /// NJICB5.
        /// </summary>
        public const string NJICB5 = "NJICB5";

        /// <summary>
        /// NJINVP.
        /// </summary>
        public const string NJINVP = "NJINVP";

        /// <summary>
        /// NJPRRB.
        /// </summary>
        public const string NJPRRB = "NJPRRB";

        /// <summary>
        /// NJBCIR.
        /// </summary>
        public const string NJBCIR = "NJBCIR";

        /// <summary>
        /// NJICBC.
        /// </summary>
        public const string NJICBC = "NJICBC";

        /// <summary>
        /// NJPOST.
        /// </summary>
        public const string NJPOST = "NJPOST";

        /// <summary>
        /// NJSOTY.
        /// </summary>
        public const string NJSOTY = "NJSOTY";

        /// <summary>
        /// NJADSC.
        /// </summary>
        public const string NJADSC = "NJADSC";

        /// <summary>
        /// NJODOC.
        /// </summary>
        public const string NJODOC = "NJODOC";

        /// <summary>
        /// NJODCT.
        /// </summary>
        public const string NJODCT = "NJODCT";

        /// <summary>
        /// NJOSFX.
        /// </summary>
        public const string NJOSFX = "NJOSFX";

        /// <summary>
        /// NJUPMT.
        /// </summary>
        public const string NJUPMT = "NJUPMT";

        /// <summary>
        /// NJKCO.
        /// </summary>
        public const string NJKCO = "NJKCO";

        /// <summary>
        /// NJOKCO.
        /// </summary>
        public const string NJOKCO = "NJOKCO";
    }

    /// <inheritdoc />
    public override string TableName => "F1511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NJGENT", "NJGENT", JdeDataType.String, 2, true, true),
        new JdeField("NJICU", "NJICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NJDOC", "NJDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NJSFX", "NJSFX", JdeDataType.String, 6, true, true),
        new JdeField("NJDOCO", "NJDOCO", JdeDataType.Numeric),
        new JdeField("NJDCTO", "NJDCTO", JdeDataType.String, 4),
        new JdeField("NJSOSQ", "NJSOSQ", JdeDataType.Numeric),
        new JdeField("NJMCUS", "NJMCUS", JdeDataType.String, 24),
        new JdeField("NJAN8", "NJAN8", JdeDataType.Numeric),
        new JdeField("NJAN8J", "NJAN8J", JdeDataType.Numeric),
        new JdeField("NJDL01", "NJDL01", JdeDataType.String, 60),
        new JdeField("NJMCU", "NJMCU", JdeDataType.String, 24),
        new JdeField("NJOBJ", "NJOBJ", JdeDataType.String, 12),
        new JdeField("NJSUB", "NJSUB", JdeDataType.String, 16),
        new JdeField("NJSBL", "NJSBL", JdeDataType.String, 16),
        new JdeField("NJAID", "NJAID", JdeDataType.String, 16),
        new JdeField("NJCO", "NJCO", JdeDataType.String, 10),
        new JdeField("NJDG", "NJDG", JdeDataType.Numeric),
        new JdeField("NJDSV", "NJDSV", JdeDataType.Numeric),
        new JdeField("NJGLC", "NJGLC", JdeDataType.String, 8),
        new JdeField("NJBPN", "NJBPN", JdeDataType.Numeric),
        new JdeField("NJYR", "NJYR", JdeDataType.Numeric),
        new JdeField("NJAG", "NJAG", JdeDataType.Numeric),
        new JdeField("NJAN01", "NJAN01", JdeDataType.Numeric),
        new JdeField("NJDI", "NJDI", JdeDataType.Numeric),
        new JdeField("NJDD", "NJDD", JdeDataType.Numeric),
        new JdeField("NJPTC", "NJPTC", JdeDataType.String, 6),
        new JdeField("NJTRAN", "NJTRAN", JdeDataType.String, 2),
        new JdeField("NJSEPI", "NJSEPI", JdeDataType.String, 2),
        new JdeField("NJITMG", "NJITMG", JdeDataType.String, 6),
        new JdeField("NJLNID", "NJLNID", JdeDataType.Numeric),
        new JdeField("NJDIC", "NJDIC", JdeDataType.Numeric),
        new JdeField("NJPDUE", "NJPDUE", JdeDataType.Numeric),
        new JdeField("NJEPCL", "NJEPCL", JdeDataType.String, 8),
        new JdeField("NJDPER", "NJDPER", JdeDataType.Numeric),
        new JdeField("NJDPAR", "NJDPAR", JdeDataType.Numeric),
        new JdeField("NJEXCD", "NJEXCD", JdeDataType.String, 2),
        new JdeField("NJBCI", "NJBCI", JdeDataType.Numeric),
        new JdeField("NJPRDC", "NJPRDC", JdeDataType.String, 8),
        new JdeField("NJYRO", "NJYRO", JdeDataType.Numeric),
        new JdeField("NJCTRY", "NJCTRY", JdeDataType.Numeric),
        new JdeField("NJRPRD", "NJRPRD", JdeDataType.Numeric),
        new JdeField("NJCRCD", "NJCRCD", JdeDataType.String, 6),
        new JdeField("NJCRR", "NJCRR", JdeDataType.Numeric),
        new JdeField("NJACR", "NJACR", JdeDataType.Numeric),
        new JdeField("NJTXA1", "NJTXA1", JdeDataType.String, 20),
        new JdeField("NJEXR1", "NJEXR1", JdeDataType.String, 4),
        new JdeField("NJSTAM", "NJSTAM", JdeDataType.Numeric),
        new JdeField("NJATXN", "NJATXN", JdeDataType.Numeric),
        new JdeField("NJATXA", "NJATXA", JdeDataType.Numeric),
        new JdeField("NJUSER", "NJUSER", JdeDataType.String, 20),
        new JdeField("NJUPMJ", "NJUPMJ", JdeDataType.Numeric),
        new JdeField("NJPID", "NJPID", JdeDataType.String, 20),
        new JdeField("NJJOBN", "NJJOBN", JdeDataType.String, 20),
        new JdeField("NJSBLT", "NJSBLT", JdeDataType.String, 2),
        new JdeField("NJCRRM", "NJCRRM", JdeDataType.String, 2),
        new JdeField("NJFAP", "NJFAP", JdeDataType.Numeric),
        new JdeField("NJCDS", "NJCDS", JdeDataType.Numeric),
        new JdeField("NJCDSA", "NJCDSA", JdeDataType.Numeric),
        new JdeField("NJCTAM", "NJCTAM", JdeDataType.Numeric),
        new JdeField("NJCTXA", "NJCTXA", JdeDataType.Numeric),
        new JdeField("NJCTXN", "NJCTXN", JdeDataType.Numeric),
        new JdeField("NJMI", "NJMI", JdeDataType.String, 2),
        new JdeField("NJDBAN", "NJDBAN", JdeDataType.Numeric),
        new JdeField("NJUNIT", "NJUNIT", JdeDataType.String, 16),
        new JdeField("NJBLMR", "NJBLMR", JdeDataType.String, 2),
        new JdeField("NJEFFC", "NJEFFC", JdeDataType.String, 2),
        new JdeField("NJSOBT", "NJSOBT", JdeDataType.String, 4),
        new JdeField("NJSBJR", "NJSBJR", JdeDataType.String, 2),
        new JdeField("NJICB1", "NJICB1", JdeDataType.String, 24),
        new JdeField("NJICB2", "NJICB2", JdeDataType.String, 24),
        new JdeField("NJICB3", "NJICB3", JdeDataType.String, 24),
        new JdeField("NJICB4", "NJICB4", JdeDataType.String, 24),
        new JdeField("NJICB5", "NJICB5", JdeDataType.String, 24),
        new JdeField("NJINVP", "NJINVP", JdeDataType.String, 2),
        new JdeField("NJPRRB", "NJPRRB", JdeDataType.String, 2),
        new JdeField("NJBCIR", "NJBCIR", JdeDataType.Numeric),
        new JdeField("NJICBC", "NJICBC", JdeDataType.String, 4),
        new JdeField("NJPOST", "NJPOST", JdeDataType.String, 2),
        new JdeField("NJSOTY", "NJSOTY", JdeDataType.String, 4),
        new JdeField("NJADSC", "NJADSC", JdeDataType.Numeric),
        new JdeField("NJODOC", "NJODOC", JdeDataType.Numeric),
        new JdeField("NJODCT", "NJODCT", JdeDataType.String, 4),
        new JdeField("NJOSFX", "NJOSFX", JdeDataType.String, 6),
        new JdeField("NJUPMT", "NJUPMT", JdeDataType.Numeric),
        new JdeField("NJKCO", "NJKCO", JdeDataType.String, 10, true, true),
        new JdeField("NJOKCO", "NJOKCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1511_0", "Primary Key on NJGENT, NJICU, NJDOC, NJKCO, NJSFX", new[] { "NJGENT", "NJICU", "NJDOC", "NJKCO", "NJSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
