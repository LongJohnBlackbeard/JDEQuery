using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502WC - .
/// </summary>
public class F1502WC : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NLICU.
        /// </summary>
        public const string NLICU = "NLICU";

        /// <summary>
        /// NLDOCO.
        /// </summary>
        public const string NLDOCO = "NLDOCO";

        /// <summary>
        /// NLLSVR.
        /// </summary>
        public const string NLLSVR = "NLLSVR";

        /// <summary>
        /// NLLNID.
        /// </summary>
        public const string NLLNID = "NLLNID";

        /// <summary>
        /// NLMCU.
        /// </summary>
        public const string NLMCU = "NLMCU";

        /// <summary>
        /// NLUNIT.
        /// </summary>
        public const string NLUNIT = "NLUNIT";

        /// <summary>
        /// NLNUMB.
        /// </summary>
        public const string NLNUMB = "NLNUMB";

        /// <summary>
        /// NLEFTB.
        /// </summary>
        public const string NLEFTB = "NLEFTB";

        /// <summary>
        /// NLEFTE.
        /// </summary>
        public const string NLEFTE = "NLEFTE";

        /// <summary>
        /// NLLSET.
        /// </summary>
        public const string NLLSET = "NLLSET";

        /// <summary>
        /// NLBLGR.
        /// </summary>
        public const string NLBLGR = "NLBLGR";

        /// <summary>
        /// NLTRAN.
        /// </summary>
        public const string NLTRAN = "NLTRAN";

        /// <summary>
        /// NLGLC.
        /// </summary>
        public const string NLGLC = "NLGLC";

        /// <summary>
        /// NLRMK.
        /// </summary>
        public const string NLRMK = "NLRMK";

        /// <summary>
        /// NLAG.
        /// </summary>
        public const string NLAG = "NLAG";

        /// <summary>
        /// NLBLFC.
        /// </summary>
        public const string NLBLFC = "NLBLFC";

        /// <summary>
        /// NLBF01.
        /// </summary>
        public const string NLBF01 = "NLBF01";

        /// <summary>
        /// NLBF02.
        /// </summary>
        public const string NLBF02 = "NLBF02";

        /// <summary>
        /// NLBF03.
        /// </summary>
        public const string NLBF03 = "NLBF03";

        /// <summary>
        /// NLBF04.
        /// </summary>
        public const string NLBF04 = "NLBF04";

        /// <summary>
        /// NLBF05.
        /// </summary>
        public const string NLBF05 = "NLBF05";

        /// <summary>
        /// NLBF06.
        /// </summary>
        public const string NLBF06 = "NLBF06";

        /// <summary>
        /// NLBF07.
        /// </summary>
        public const string NLBF07 = "NLBF07";

        /// <summary>
        /// NLBF08.
        /// </summary>
        public const string NLBF08 = "NLBF08";

        /// <summary>
        /// NLBF09.
        /// </summary>
        public const string NLBF09 = "NLBF09";

        /// <summary>
        /// NLBF10.
        /// </summary>
        public const string NLBF10 = "NLBF10";

        /// <summary>
        /// NLBF11.
        /// </summary>
        public const string NLBF11 = "NLBF11";

        /// <summary>
        /// NLBF12.
        /// </summary>
        public const string NLBF12 = "NLBF12";

        /// <summary>
        /// NLBF13.
        /// </summary>
        public const string NLBF13 = "NLBF13";

        /// <summary>
        /// NLSBL.
        /// </summary>
        public const string NLSBL = "NLSBL";

        /// <summary>
        /// NLAN8J.
        /// </summary>
        public const string NLAN8J = "NLAN8J";

        /// <summary>
        /// NLSMCU.
        /// </summary>
        public const string NLSMCU = "NLSMCU";

        /// <summary>
        /// NLTRAR.
        /// </summary>
        public const string NLTRAR = "NLTRAR";

        /// <summary>
        /// NLSEPI.
        /// </summary>
        public const string NLSEPI = "NLSEPI";

        /// <summary>
        /// NLITMG.
        /// </summary>
        public const string NLITMG = "NLITMG";

        /// <summary>
        /// NLSUSP.
        /// </summary>
        public const string NLSUSP = "NLSUSP";

        /// <summary>
        /// NLDEAL.
        /// </summary>
        public const string NLDEAL = "NLDEAL";

        /// <summary>
        /// NLRN01.
        /// </summary>
        public const string NLRN01 = "NLRN01";

        /// <summary>
        /// NLRN02.
        /// </summary>
        public const string NLRN02 = "NLRN02";

        /// <summary>
        /// NLRN03.
        /// </summary>
        public const string NLRN03 = "NLRN03";

        /// <summary>
        /// NLRN04.
        /// </summary>
        public const string NLRN04 = "NLRN04";

        /// <summary>
        /// NLRN05.
        /// </summary>
        public const string NLRN05 = "NLRN05";

        /// <summary>
        /// NLAGSN.
        /// </summary>
        public const string NLAGSN = "NLAGSN";

        /// <summary>
        /// NLGENT.
        /// </summary>
        public const string NLGENT = "NLGENT";

        /// <summary>
        /// NLBCI.
        /// </summary>
        public const string NLBCI = "NLBCI";

        /// <summary>
        /// NLCRCD.
        /// </summary>
        public const string NLCRCD = "NLCRCD";

        /// <summary>
        /// NLCRR.
        /// </summary>
        public const string NLCRR = "NLCRR";

        /// <summary>
        /// NLACR.
        /// </summary>
        public const string NLACR = "NLACR";

        /// <summary>
        /// NLTXA1.
        /// </summary>
        public const string NLTXA1 = "NLTXA1";

        /// <summary>
        /// NLEXR1.
        /// </summary>
        public const string NLEXR1 = "NLEXR1";

        /// <summary>
        /// NLSTAM.
        /// </summary>
        public const string NLSTAM = "NLSTAM";

        /// <summary>
        /// NLATXN.
        /// </summary>
        public const string NLATXN = "NLATXN";

        /// <summary>
        /// NLATXA.
        /// </summary>
        public const string NLATXA = "NLATXA";

        /// <summary>
        /// NLSBLT.
        /// </summary>
        public const string NLSBLT = "NLSBLT";

        /// <summary>
        /// NLCRRM.
        /// </summary>
        public const string NLCRRM = "NLCRRM";

        /// <summary>
        /// NLFAP.
        /// </summary>
        public const string NLFAP = "NLFAP";

        /// <summary>
        /// NLCDS.
        /// </summary>
        public const string NLCDS = "NLCDS";

        /// <summary>
        /// NLCDSA.
        /// </summary>
        public const string NLCDSA = "NLCDSA";

        /// <summary>
        /// NLCTAM.
        /// </summary>
        public const string NLCTAM = "NLCTAM";

        /// <summary>
        /// NLCTXA.
        /// </summary>
        public const string NLCTXA = "NLCTXA";

        /// <summary>
        /// NLCTXN.
        /// </summary>
        public const string NLCTXN = "NLCTXN";

        /// <summary>
        /// NLBCI2.
        /// </summary>
        public const string NLBCI2 = "NLBCI2";

        /// <summary>
        /// NLBPN.
        /// </summary>
        public const string NLBPN = "NLBPN";

        /// <summary>
        /// NLYR.
        /// </summary>
        public const string NLYR = "NLYR";

        /// <summary>
        /// NLBPN#.
        /// </summary>
        public const string NLBPN_ = "NLBPN#";

        /// <summary>
        /// NLTRBM.
        /// </summary>
        public const string NLTRBM = "NLTRBM";

        /// <summary>
        /// NLTRBY.
        /// </summary>
        public const string NLTRBY = "NLTRBY";

        /// <summary>
        /// NLTRB#.
        /// </summary>
        public const string NLTRB_ = "NLTRB#";

        /// <summary>
        /// NLTREM.
        /// </summary>
        public const string NLTREM = "NLTREM";

        /// <summary>
        /// NLTREY.
        /// </summary>
        public const string NLTREY = "NLTREY";

        /// <summary>
        /// NLTRE#.
        /// </summary>
        public const string NLTRE_ = "NLTRE#";

        /// <summary>
        /// NLRNTA.
        /// </summary>
        public const string NLRNTA = "NLRNTA";

        /// <summary>
        /// NLBCI3.
        /// </summary>
        public const string NLBCI3 = "NLBCI3";

        /// <summary>
        /// NLSUDT.
        /// </summary>
        public const string NLSUDT = "NLSUDT";

        /// <summary>
        /// NLUNGR.
        /// </summary>
        public const string NLUNGR = "NLUNGR";

        /// <summary>
        /// NLURCD.
        /// </summary>
        public const string NLURCD = "NLURCD";

        /// <summary>
        /// NLURDT.
        /// </summary>
        public const string NLURDT = "NLURDT";

        /// <summary>
        /// NLURAT.
        /// </summary>
        public const string NLURAT = "NLURAT";

        /// <summary>
        /// NLURAB.
        /// </summary>
        public const string NLURAB = "NLURAB";

        /// <summary>
        /// NLURRF.
        /// </summary>
        public const string NLURRF = "NLURRF";

        /// <summary>
        /// NLUSER.
        /// </summary>
        public const string NLUSER = "NLUSER";

        /// <summary>
        /// NLPID.
        /// </summary>
        public const string NLPID = "NLPID";

        /// <summary>
        /// NLUPMJ.
        /// </summary>
        public const string NLUPMJ = "NLUPMJ";

        /// <summary>
        /// NLUPMT.
        /// </summary>
        public const string NLUPMT = "NLUPMT";

        /// <summary>
        /// NLJOBN.
        /// </summary>
        public const string NLJOBN = "NLJOBN";

        /// <summary>
        /// NLLAFF.
        /// </summary>
        public const string NLLAFF = "NLLAFF";

        /// <summary>
        /// NLLELL.
        /// </summary>
        public const string NLLELL = "NLLELL";

        /// <summary>
        /// NLLEPM.
        /// </summary>
        public const string NLLEPM = "NLLEPM";

        /// <summary>
        /// NLLZNPA.
        /// </summary>
        public const string NLLZNPA = "NLLZNPA";

        /// <summary>
        /// NLLZBBAI.
        /// </summary>
        public const string NLLZBBAI = "NLLZBBAI";

        /// <summary>
        /// NLLZAGBR.
        /// </summary>
        public const string NLLZAGBR = "NLLZAGBR";

        /// <summary>
        /// NLLZRBUA.
        /// </summary>
        public const string NLLZRBUA = "NLLZRBUA";
    }

    /// <inheritdoc />
    public override string TableName => "F1502WC";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NLICU", "NLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NLDOCO", "NLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NLLSVR", "NLLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NLLNID", "NLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NLMCU", "NLMCU", JdeDataType.String, 24),
        new JdeField("NLUNIT", "NLUNIT", JdeDataType.String, 16),
        new JdeField("NLNUMB", "NLNUMB", JdeDataType.Numeric),
        new JdeField("NLEFTB", "NLEFTB", JdeDataType.Numeric),
        new JdeField("NLEFTE", "NLEFTE", JdeDataType.Numeric),
        new JdeField("NLLSET", "NLLSET", JdeDataType.String, 4),
        new JdeField("NLBLGR", "NLBLGR", JdeDataType.String, 24),
        new JdeField("NLTRAN", "NLTRAN", JdeDataType.String, 2),
        new JdeField("NLGLC", "NLGLC", JdeDataType.String, 8),
        new JdeField("NLRMK", "NLRMK", JdeDataType.String, 60),
        new JdeField("NLAG", "NLAG", JdeDataType.Numeric),
        new JdeField("NLBLFC", "NLBLFC", JdeDataType.String, 2),
        new JdeField("NLBF01", "NLBF01", JdeDataType.String, 2),
        new JdeField("NLBF02", "NLBF02", JdeDataType.String, 2),
        new JdeField("NLBF03", "NLBF03", JdeDataType.String, 2),
        new JdeField("NLBF04", "NLBF04", JdeDataType.String, 2),
        new JdeField("NLBF05", "NLBF05", JdeDataType.String, 2),
        new JdeField("NLBF06", "NLBF06", JdeDataType.String, 2),
        new JdeField("NLBF07", "NLBF07", JdeDataType.String, 2),
        new JdeField("NLBF08", "NLBF08", JdeDataType.String, 2),
        new JdeField("NLBF09", "NLBF09", JdeDataType.String, 2),
        new JdeField("NLBF10", "NLBF10", JdeDataType.String, 2),
        new JdeField("NLBF11", "NLBF11", JdeDataType.String, 2),
        new JdeField("NLBF12", "NLBF12", JdeDataType.String, 2),
        new JdeField("NLBF13", "NLBF13", JdeDataType.String, 2),
        new JdeField("NLSBL", "NLSBL", JdeDataType.String, 16),
        new JdeField("NLAN8J", "NLAN8J", JdeDataType.Numeric),
        new JdeField("NLSMCU", "NLSMCU", JdeDataType.String, 24),
        new JdeField("NLTRAR", "NLTRAR", JdeDataType.String, 6),
        new JdeField("NLSEPI", "NLSEPI", JdeDataType.String, 2),
        new JdeField("NLITMG", "NLITMG", JdeDataType.String, 6),
        new JdeField("NLSUSP", "NLSUSP", JdeDataType.String, 2),
        new JdeField("NLDEAL", "NLDEAL", JdeDataType.String, 16),
        new JdeField("NLRN01", "NLRN01", JdeDataType.String, 6),
        new JdeField("NLRN02", "NLRN02", JdeDataType.String, 6),
        new JdeField("NLRN03", "NLRN03", JdeDataType.String, 6),
        new JdeField("NLRN04", "NLRN04", JdeDataType.String, 6),
        new JdeField("NLRN05", "NLRN05", JdeDataType.String, 6),
        new JdeField("NLAGSN", "NLAGSN", JdeDataType.Numeric),
        new JdeField("NLGENT", "NLGENT", JdeDataType.String, 2),
        new JdeField("NLBCI", "NLBCI", JdeDataType.Numeric),
        new JdeField("NLCRCD", "NLCRCD", JdeDataType.String, 6),
        new JdeField("NLCRR", "NLCRR", JdeDataType.Numeric),
        new JdeField("NLACR", "NLACR", JdeDataType.Numeric),
        new JdeField("NLTXA1", "NLTXA1", JdeDataType.String, 20),
        new JdeField("NLEXR1", "NLEXR1", JdeDataType.String, 4),
        new JdeField("NLSTAM", "NLSTAM", JdeDataType.Numeric),
        new JdeField("NLATXN", "NLATXN", JdeDataType.Numeric),
        new JdeField("NLATXA", "NLATXA", JdeDataType.Numeric),
        new JdeField("NLSBLT", "NLSBLT", JdeDataType.String, 2),
        new JdeField("NLCRRM", "NLCRRM", JdeDataType.String, 2),
        new JdeField("NLFAP", "NLFAP", JdeDataType.Numeric),
        new JdeField("NLCDS", "NLCDS", JdeDataType.Numeric),
        new JdeField("NLCDSA", "NLCDSA", JdeDataType.Numeric),
        new JdeField("NLCTAM", "NLCTAM", JdeDataType.Numeric),
        new JdeField("NLCTXA", "NLCTXA", JdeDataType.Numeric),
        new JdeField("NLCTXN", "NLCTXN", JdeDataType.Numeric),
        new JdeField("NLBCI2", "NLBCI2", JdeDataType.Numeric),
        new JdeField("NLBPN", "NLBPN", JdeDataType.Numeric),
        new JdeField("NLYR", "NLYR", JdeDataType.Numeric),
        new JdeField("NLBPN#", "NLBPN#", JdeDataType.Numeric),
        new JdeField("NLTRBM", "NLTRBM", JdeDataType.Numeric),
        new JdeField("NLTRBY", "NLTRBY", JdeDataType.Numeric),
        new JdeField("NLTRB#", "NLTRB#", JdeDataType.Numeric),
        new JdeField("NLTREM", "NLTREM", JdeDataType.Numeric),
        new JdeField("NLTREY", "NLTREY", JdeDataType.Numeric),
        new JdeField("NLTRE#", "NLTRE#", JdeDataType.Numeric),
        new JdeField("NLRNTA", "NLRNTA", JdeDataType.Numeric),
        new JdeField("NLBCI3", "NLBCI3", JdeDataType.Numeric),
        new JdeField("NLSUDT", "NLSUDT", JdeDataType.Numeric),
        new JdeField("NLUNGR", "NLUNGR", JdeDataType.String, 2),
        new JdeField("NLURCD", "NLURCD", JdeDataType.String, 4),
        new JdeField("NLURDT", "NLURDT", JdeDataType.Numeric),
        new JdeField("NLURAT", "NLURAT", JdeDataType.Numeric),
        new JdeField("NLURAB", "NLURAB", JdeDataType.Numeric),
        new JdeField("NLURRF", "NLURRF", JdeDataType.String, 30),
        new JdeField("NLUSER", "NLUSER", JdeDataType.String, 20),
        new JdeField("NLPID", "NLPID", JdeDataType.String, 20),
        new JdeField("NLUPMJ", "NLUPMJ", JdeDataType.Numeric),
        new JdeField("NLUPMT", "NLUPMT", JdeDataType.Numeric),
        new JdeField("NLJOBN", "NLJOBN", JdeDataType.String, 20),
        new JdeField("NLLAFF", "NLLAFF", JdeDataType.String, 2),
        new JdeField("NLLELL", "NLLELL", JdeDataType.String, 2),
        new JdeField("NLLEPM", "NLLEPM", JdeDataType.String, 2),
        new JdeField("NLLZNPA", "NLLZNPA", JdeDataType.String, 2),
        new JdeField("NLLZBBAI", "NLLZBBAI", JdeDataType.String, 2),
        new JdeField("NLLZAGBR", "NLLZAGBR", JdeDataType.String, 2),
        new JdeField("NLLZRBUA", "NLLZRBUA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502WC_0", "Primary Key on NLICU, NLDOCO, NLLSVR, NLLNID", new[] { "NLICU", "NLDOCO", "NLLSVR", "NLLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1502WC_2", "Index on NLICU, NLDOCO, NLLSVR, NLMCU, NLUNIT, NLNUMB, NLEFTB", new[] { "NLICU", "NLDOCO", "NLLSVR", "NLMCU", "NLUNIT", "NLNUMB", "NLEFTB" }),
        new JdeIndex("F1502WC_3", "Index on NLBCI", new[] { "NLBCI" })
    };
}
