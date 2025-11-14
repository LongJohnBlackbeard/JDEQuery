using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502BZ1 - .
/// </summary>
public class F1502BZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBEDUS.
        /// </summary>
        public const string RBEDUS = "RBEDUS";

        /// <summary>
        /// RBEDBT.
        /// </summary>
        public const string RBEDBT = "RBEDBT";

        /// <summary>
        /// RBEDTN.
        /// </summary>
        public const string RBEDTN = "RBEDTN";

        /// <summary>
        /// RBEDLN.
        /// </summary>
        public const string RBEDLN = "RBEDLN";

        /// <summary>
        /// RBEDCT.
        /// </summary>
        public const string RBEDCT = "RBEDCT";

        /// <summary>
        /// RBTYTN.
        /// </summary>
        public const string RBTYTN = "RBTYTN";

        /// <summary>
        /// RBEDFT.
        /// </summary>
        public const string RBEDFT = "RBEDFT";

        /// <summary>
        /// RBEDDT.
        /// </summary>
        public const string RBEDDT = "RBEDDT";

        /// <summary>
        /// RBDRIN.
        /// </summary>
        public const string RBDRIN = "RBDRIN";

        /// <summary>
        /// RBEDDL.
        /// </summary>
        public const string RBEDDL = "RBEDDL";

        /// <summary>
        /// RBEDSP.
        /// </summary>
        public const string RBEDSP = "RBEDSP";

        /// <summary>
        /// RBPNID.
        /// </summary>
        public const string RBPNID = "RBPNID";

        /// <summary>
        /// RBTNAC.
        /// </summary>
        public const string RBTNAC = "RBTNAC";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBPID.
        /// </summary>
        public const string RBPID = "RBPID";

        /// <summary>
        /// RBJOBN.
        /// </summary>
        public const string RBJOBN = "RBJOBN";

        /// <summary>
        /// RBUPMJ.
        /// </summary>
        public const string RBUPMJ = "RBUPMJ";

        /// <summary>
        /// RBTDAY.
        /// </summary>
        public const string RBTDAY = "RBTDAY";

        /// <summary>
        /// RBDOCO.
        /// </summary>
        public const string RBDOCO = "RBDOCO";

        /// <summary>
        /// RBLSET.
        /// </summary>
        public const string RBLSET = "RBLSET";

        /// <summary>
        /// RBLNID.
        /// </summary>
        public const string RBLNID = "RBLNID";

        /// <summary>
        /// RBBLGR.
        /// </summary>
        public const string RBBLGR = "RBBLGR";

        /// <summary>
        /// RBTRAN.
        /// </summary>
        public const string RBTRAN = "RBTRAN";

        /// <summary>
        /// RBGLC.
        /// </summary>
        public const string RBGLC = "RBGLC";

        /// <summary>
        /// RBRMK.
        /// </summary>
        public const string RBRMK = "RBRMK";

        /// <summary>
        /// RBAG.
        /// </summary>
        public const string RBAG = "RBAG";

        /// <summary>
        /// RBEFTB.
        /// </summary>
        public const string RBEFTB = "RBEFTB";

        /// <summary>
        /// RBEFTE.
        /// </summary>
        public const string RBEFTE = "RBEFTE";

        /// <summary>
        /// RBBLFC.
        /// </summary>
        public const string RBBLFC = "RBBLFC";

        /// <summary>
        /// RBBF01.
        /// </summary>
        public const string RBBF01 = "RBBF01";

        /// <summary>
        /// RBBF02.
        /// </summary>
        public const string RBBF02 = "RBBF02";

        /// <summary>
        /// RBBF03.
        /// </summary>
        public const string RBBF03 = "RBBF03";

        /// <summary>
        /// RBBF04.
        /// </summary>
        public const string RBBF04 = "RBBF04";

        /// <summary>
        /// RBBF05.
        /// </summary>
        public const string RBBF05 = "RBBF05";

        /// <summary>
        /// RBBF06.
        /// </summary>
        public const string RBBF06 = "RBBF06";

        /// <summary>
        /// RBBF07.
        /// </summary>
        public const string RBBF07 = "RBBF07";

        /// <summary>
        /// RBBF08.
        /// </summary>
        public const string RBBF08 = "RBBF08";

        /// <summary>
        /// RBBF09.
        /// </summary>
        public const string RBBF09 = "RBBF09";

        /// <summary>
        /// RBBF10.
        /// </summary>
        public const string RBBF10 = "RBBF10";

        /// <summary>
        /// RBBF11.
        /// </summary>
        public const string RBBF11 = "RBBF11";

        /// <summary>
        /// RBBF12.
        /// </summary>
        public const string RBBF12 = "RBBF12";

        /// <summary>
        /// RBBF13.
        /// </summary>
        public const string RBBF13 = "RBBF13";

        /// <summary>
        /// RBMCU.
        /// </summary>
        public const string RBMCU = "RBMCU";

        /// <summary>
        /// RBSBL.
        /// </summary>
        public const string RBSBL = "RBSBL";

        /// <summary>
        /// RBAN8J.
        /// </summary>
        public const string RBAN8J = "RBAN8J";

        /// <summary>
        /// RBUNIT.
        /// </summary>
        public const string RBUNIT = "RBUNIT";

        /// <summary>
        /// RBSMCU.
        /// </summary>
        public const string RBSMCU = "RBSMCU";

        /// <summary>
        /// RBTRAR.
        /// </summary>
        public const string RBTRAR = "RBTRAR";

        /// <summary>
        /// RBSEPI.
        /// </summary>
        public const string RBSEPI = "RBSEPI";

        /// <summary>
        /// RBITMG.
        /// </summary>
        public const string RBITMG = "RBITMG";

        /// <summary>
        /// RBSUSP.
        /// </summary>
        public const string RBSUSP = "RBSUSP";

        /// <summary>
        /// RBDEAL.
        /// </summary>
        public const string RBDEAL = "RBDEAL";

        /// <summary>
        /// RBRN01.
        /// </summary>
        public const string RBRN01 = "RBRN01";

        /// <summary>
        /// RBRN02.
        /// </summary>
        public const string RBRN02 = "RBRN02";

        /// <summary>
        /// RBRN03.
        /// </summary>
        public const string RBRN03 = "RBRN03";

        /// <summary>
        /// RBRN04.
        /// </summary>
        public const string RBRN04 = "RBRN04";

        /// <summary>
        /// RBRN05.
        /// </summary>
        public const string RBRN05 = "RBRN05";

        /// <summary>
        /// RBAGSN.
        /// </summary>
        public const string RBAGSN = "RBAGSN";

        /// <summary>
        /// RBGENT.
        /// </summary>
        public const string RBGENT = "RBGENT";

        /// <summary>
        /// RBBCI.
        /// </summary>
        public const string RBBCI = "RBBCI";

        /// <summary>
        /// RBCRCD.
        /// </summary>
        public const string RBCRCD = "RBCRCD";

        /// <summary>
        /// RBACR.
        /// </summary>
        public const string RBACR = "RBACR";

        /// <summary>
        /// RBTXA1.
        /// </summary>
        public const string RBTXA1 = "RBTXA1";

        /// <summary>
        /// RBEXR1.
        /// </summary>
        public const string RBEXR1 = "RBEXR1";

        /// <summary>
        /// RBSTAM.
        /// </summary>
        public const string RBSTAM = "RBSTAM";

        /// <summary>
        /// RBATXN.
        /// </summary>
        public const string RBATXN = "RBATXN";

        /// <summary>
        /// RBATXA.
        /// </summary>
        public const string RBATXA = "RBATXA";

        /// <summary>
        /// RBSBLT.
        /// </summary>
        public const string RBSBLT = "RBSBLT";

        /// <summary>
        /// RBCRRM.
        /// </summary>
        public const string RBCRRM = "RBCRRM";

        /// <summary>
        /// RBCTAM.
        /// </summary>
        public const string RBCTAM = "RBCTAM";

        /// <summary>
        /// RBCTXA.
        /// </summary>
        public const string RBCTXA = "RBCTXA";

        /// <summary>
        /// RBCTXN.
        /// </summary>
        public const string RBCTXN = "RBCTXN";

        /// <summary>
        /// RBYT.
        /// </summary>
        public const string RBYT = "RBYT";

        /// <summary>
        /// RBLRYF.
        /// </summary>
        public const string RBLRYF = "RBLRYF";

        /// <summary>
        /// RBLRYT.
        /// </summary>
        public const string RBLRYT = "RBLRYT";

        /// <summary>
        /// RBINVP.
        /// </summary>
        public const string RBINVP = "RBINVP";

        /// <summary>
        /// RBDBAN.
        /// </summary>
        public const string RBDBAN = "RBDBAN";

        /// <summary>
        /// RBSUDT.
        /// </summary>
        public const string RBSUDT = "RBSUDT";

        /// <summary>
        /// RBPPNM.
        /// </summary>
        public const string RBPPNM = "RBPPNM";

        /// <summary>
        /// RBALTB.
        /// </summary>
        public const string RBALTB = "RBALTB";

        /// <summary>
        /// RBAPSF.
        /// </summary>
        public const string RBAPSF = "RBAPSF";

        /// <summary>
        /// RBBTDT.
        /// </summary>
        public const string RBBTDT = "RBBTDT";

        /// <summary>
        /// RBRNTA.
        /// </summary>
        public const string RBRNTA = "RBRNTA";

        /// <summary>
        /// RBUNGR.
        /// </summary>
        public const string RBUNGR = "RBUNGR";

        /// <summary>
        /// RBLSVR.
        /// </summary>
        public const string RBLSVR = "RBLSVR";

        /// <summary>
        /// RBBCI3.
        /// </summary>
        public const string RBBCI3 = "RBBCI3";

        /// <summary>
        /// RBVRSC.
        /// </summary>
        public const string RBVRSC = "RBVRSC";

        /// <summary>
        /// RBURCD.
        /// </summary>
        public const string RBURCD = "RBURCD";

        /// <summary>
        /// RBURDT.
        /// </summary>
        public const string RBURDT = "RBURDT";

        /// <summary>
        /// RBURAT.
        /// </summary>
        public const string RBURAT = "RBURAT";

        /// <summary>
        /// RBURAB.
        /// </summary>
        public const string RBURAB = "RBURAB";

        /// <summary>
        /// RBURRF.
        /// </summary>
        public const string RBURRF = "RBURRF";

        /// <summary>
        /// RBENTJ.
        /// </summary>
        public const string RBENTJ = "RBENTJ";

        /// <summary>
        /// RBTORG.
        /// </summary>
        public const string RBTORG = "RBTORG";

        /// <summary>
        /// RBCRR.
        /// </summary>
        public const string RBCRR = "RBCRR";

        /// <summary>
        /// RBLAFF.
        /// </summary>
        public const string RBLAFF = "RBLAFF";

        /// <summary>
        /// RBLELL.
        /// </summary>
        public const string RBLELL = "RBLELL";

        /// <summary>
        /// RBLEPM.
        /// </summary>
        public const string RBLEPM = "RBLEPM";

        /// <summary>
        /// RBOLSE.
        /// </summary>
        public const string RBOLSE = "RBOLSE";

        /// <summary>
        /// RBLZNPA.
        /// </summary>
        public const string RBLZNPA = "RBLZNPA";

        /// <summary>
        /// RBNUMB.
        /// </summary>
        public const string RBNUMB = "RBNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F1502BZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBEDUS", "RBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("RBEDBT", "RBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("RBEDTN", "RBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("RBEDLN", "RBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RBEDCT", "RBEDCT", JdeDataType.String, 4),
        new JdeField("RBTYTN", "RBTYTN", JdeDataType.String, 16),
        new JdeField("RBEDFT", "RBEDFT", JdeDataType.String, 20),
        new JdeField("RBEDDT", "RBEDDT", JdeDataType.Numeric),
        new JdeField("RBDRIN", "RBDRIN", JdeDataType.String, 2),
        new JdeField("RBEDDL", "RBEDDL", JdeDataType.Numeric),
        new JdeField("RBEDSP", "RBEDSP", JdeDataType.String, 2),
        new JdeField("RBPNID", "RBPNID", JdeDataType.String, 30),
        new JdeField("RBTNAC", "RBTNAC", JdeDataType.String, 4),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBTDAY", "RBTDAY", JdeDataType.Numeric),
        new JdeField("RBDOCO", "RBDOCO", JdeDataType.Numeric),
        new JdeField("RBLSET", "RBLSET", JdeDataType.String, 4),
        new JdeField("RBLNID", "RBLNID", JdeDataType.Numeric),
        new JdeField("RBBLGR", "RBBLGR", JdeDataType.String, 24),
        new JdeField("RBTRAN", "RBTRAN", JdeDataType.String, 2),
        new JdeField("RBGLC", "RBGLC", JdeDataType.String, 8),
        new JdeField("RBRMK", "RBRMK", JdeDataType.String, 60),
        new JdeField("RBAG", "RBAG", JdeDataType.Numeric),
        new JdeField("RBEFTB", "RBEFTB", JdeDataType.Numeric),
        new JdeField("RBEFTE", "RBEFTE", JdeDataType.Numeric),
        new JdeField("RBBLFC", "RBBLFC", JdeDataType.String, 2),
        new JdeField("RBBF01", "RBBF01", JdeDataType.String, 2),
        new JdeField("RBBF02", "RBBF02", JdeDataType.String, 2),
        new JdeField("RBBF03", "RBBF03", JdeDataType.String, 2),
        new JdeField("RBBF04", "RBBF04", JdeDataType.String, 2),
        new JdeField("RBBF05", "RBBF05", JdeDataType.String, 2),
        new JdeField("RBBF06", "RBBF06", JdeDataType.String, 2),
        new JdeField("RBBF07", "RBBF07", JdeDataType.String, 2),
        new JdeField("RBBF08", "RBBF08", JdeDataType.String, 2),
        new JdeField("RBBF09", "RBBF09", JdeDataType.String, 2),
        new JdeField("RBBF10", "RBBF10", JdeDataType.String, 2),
        new JdeField("RBBF11", "RBBF11", JdeDataType.String, 2),
        new JdeField("RBBF12", "RBBF12", JdeDataType.String, 2),
        new JdeField("RBBF13", "RBBF13", JdeDataType.String, 2),
        new JdeField("RBMCU", "RBMCU", JdeDataType.String, 24),
        new JdeField("RBSBL", "RBSBL", JdeDataType.String, 16),
        new JdeField("RBAN8J", "RBAN8J", JdeDataType.Numeric),
        new JdeField("RBUNIT", "RBUNIT", JdeDataType.String, 16),
        new JdeField("RBSMCU", "RBSMCU", JdeDataType.String, 24),
        new JdeField("RBTRAR", "RBTRAR", JdeDataType.String, 6),
        new JdeField("RBSEPI", "RBSEPI", JdeDataType.String, 2),
        new JdeField("RBITMG", "RBITMG", JdeDataType.String, 6),
        new JdeField("RBSUSP", "RBSUSP", JdeDataType.String, 2),
        new JdeField("RBDEAL", "RBDEAL", JdeDataType.String, 16),
        new JdeField("RBRN01", "RBRN01", JdeDataType.String, 6),
        new JdeField("RBRN02", "RBRN02", JdeDataType.String, 6),
        new JdeField("RBRN03", "RBRN03", JdeDataType.String, 6),
        new JdeField("RBRN04", "RBRN04", JdeDataType.String, 6),
        new JdeField("RBRN05", "RBRN05", JdeDataType.String, 6),
        new JdeField("RBAGSN", "RBAGSN", JdeDataType.Numeric),
        new JdeField("RBGENT", "RBGENT", JdeDataType.String, 2),
        new JdeField("RBBCI", "RBBCI", JdeDataType.Numeric),
        new JdeField("RBCRCD", "RBCRCD", JdeDataType.String, 6),
        new JdeField("RBACR", "RBACR", JdeDataType.Numeric),
        new JdeField("RBTXA1", "RBTXA1", JdeDataType.String, 20),
        new JdeField("RBEXR1", "RBEXR1", JdeDataType.String, 4),
        new JdeField("RBSTAM", "RBSTAM", JdeDataType.Numeric),
        new JdeField("RBATXN", "RBATXN", JdeDataType.Numeric),
        new JdeField("RBATXA", "RBATXA", JdeDataType.Numeric),
        new JdeField("RBSBLT", "RBSBLT", JdeDataType.String, 2),
        new JdeField("RBCRRM", "RBCRRM", JdeDataType.String, 2),
        new JdeField("RBCTAM", "RBCTAM", JdeDataType.Numeric),
        new JdeField("RBCTXA", "RBCTXA", JdeDataType.Numeric),
        new JdeField("RBCTXN", "RBCTXN", JdeDataType.Numeric),
        new JdeField("RBYT", "RBYT", JdeDataType.String, 2),
        new JdeField("RBLRYF", "RBLRYF", JdeDataType.Numeric),
        new JdeField("RBLRYT", "RBLRYT", JdeDataType.Numeric),
        new JdeField("RBINVP", "RBINVP", JdeDataType.String, 2),
        new JdeField("RBDBAN", "RBDBAN", JdeDataType.Numeric),
        new JdeField("RBSUDT", "RBSUDT", JdeDataType.Numeric),
        new JdeField("RBPPNM", "RBPPNM", JdeDataType.Numeric),
        new JdeField("RBALTB", "RBALTB", JdeDataType.String, 2),
        new JdeField("RBAPSF", "RBAPSF", JdeDataType.Numeric),
        new JdeField("RBBTDT", "RBBTDT", JdeDataType.Numeric),
        new JdeField("RBRNTA", "RBRNTA", JdeDataType.Numeric),
        new JdeField("RBUNGR", "RBUNGR", JdeDataType.String, 2),
        new JdeField("RBLSVR", "RBLSVR", JdeDataType.Numeric),
        new JdeField("RBBCI3", "RBBCI3", JdeDataType.Numeric),
        new JdeField("RBVRSC", "RBVRSC", JdeDataType.String, 2),
        new JdeField("RBURCD", "RBURCD", JdeDataType.String, 4),
        new JdeField("RBURDT", "RBURDT", JdeDataType.Numeric),
        new JdeField("RBURAT", "RBURAT", JdeDataType.Numeric),
        new JdeField("RBURAB", "RBURAB", JdeDataType.Numeric),
        new JdeField("RBURRF", "RBURRF", JdeDataType.String, 30),
        new JdeField("RBENTJ", "RBENTJ", JdeDataType.Numeric),
        new JdeField("RBTORG", "RBTORG", JdeDataType.String, 20),
        new JdeField("RBCRR", "RBCRR", JdeDataType.Numeric),
        new JdeField("RBLAFF", "RBLAFF", JdeDataType.String, 2),
        new JdeField("RBLELL", "RBLELL", JdeDataType.String, 2),
        new JdeField("RBLEPM", "RBLEPM", JdeDataType.String, 2),
        new JdeField("RBOLSE", "RBOLSE", JdeDataType.String, 50),
        new JdeField("RBLZNPA", "RBLZNPA", JdeDataType.String, 2),
        new JdeField("RBNUMB", "RBNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502BZ1_0", "Primary Key on RBEDUS, RBEDBT, RBEDTN, RBEDLN", new[] { "RBEDUS", "RBEDBT", "RBEDTN", "RBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
