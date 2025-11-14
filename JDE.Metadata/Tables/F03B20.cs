using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B20 - .
/// </summary>
public class F03B20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZRUKID.
        /// </summary>
        public const string ZRUKID = "ZRUKID";

        /// <summary>
        /// ZRCTL.
        /// </summary>
        public const string ZRCTL = "ZRCTL";

        /// <summary>
        /// ZRPLY.
        /// </summary>
        public const string ZRPLY = "ZRPLY";

        /// <summary>
        /// ZRLNID.
        /// </summary>
        public const string ZRLNID = "ZRLNID";

        /// <summary>
        /// ZRRMTA.
        /// </summary>
        public const string ZRRMTA = "ZRRMTA";

        /// <summary>
        /// ZRAN8.
        /// </summary>
        public const string ZRAN8 = "ZRAN8";

        /// <summary>
        /// ZRCO.
        /// </summary>
        public const string ZRCO = "ZRCO";

        /// <summary>
        /// ZRAVID.
        /// </summary>
        public const string ZRAVID = "ZRAVID";

        /// <summary>
        /// ZRNOTJ.
        /// </summary>
        public const string ZRNOTJ = "ZRNOTJ";

        /// <summary>
        /// ZRDT1J.
        /// </summary>
        public const string ZRDT1J = "ZRDT1J";

        /// <summary>
        /// ZRNOT.
        /// </summary>
        public const string ZRNOT = "ZRNOT";

        /// <summary>
        /// ZRAGEM.
        /// </summary>
        public const string ZRAGEM = "ZRAGEM";

        /// <summary>
        /// ZRAGE.
        /// </summary>
        public const string ZRAGE = "ZRAGE";

        /// <summary>
        /// ZRCRDY.
        /// </summary>
        public const string ZRCRDY = "ZRCRDY";

        /// <summary>
        /// ZRAGR1.
        /// </summary>
        public const string ZRAGR1 = "ZRAGR1";

        /// <summary>
        /// ZRAGR2.
        /// </summary>
        public const string ZRAGR2 = "ZRAGR2";

        /// <summary>
        /// ZRAGR3.
        /// </summary>
        public const string ZRAGR3 = "ZRAGR3";

        /// <summary>
        /// ZRAGR4.
        /// </summary>
        public const string ZRAGR4 = "ZRAGR4";

        /// <summary>
        /// ZRAGR5.
        /// </summary>
        public const string ZRAGR5 = "ZRAGR5";

        /// <summary>
        /// ZRAGR6.
        /// </summary>
        public const string ZRAGR6 = "ZRAGR6";

        /// <summary>
        /// ZRAGR7.
        /// </summary>
        public const string ZRAGR7 = "ZRAGR7";

        /// <summary>
        /// ZRAAP.
        /// </summary>
        public const string ZRAAP = "ZRAAP";

        /// <summary>
        /// ZRADSA.
        /// </summary>
        public const string ZRADSA = "ZRADSA";

        /// <summary>
        /// ZRPYRD.
        /// </summary>
        public const string ZRPYRD = "ZRPYRD";

        /// <summary>
        /// ZRADJ.
        /// </summary>
        public const string ZRADJ = "ZRADJ";

        /// <summary>
        /// ZRADJD.
        /// </summary>
        public const string ZRADJD = "ZRADJD";

        /// <summary>
        /// ZRCAD.
        /// </summary>
        public const string ZRCAD = "ZRCAD";

        /// <summary>
        /// ZRPAD.
        /// </summary>
        public const string ZRPAD = "ZRPAD";

        /// <summary>
        /// ZRATXA.
        /// </summary>
        public const string ZRATXA = "ZRATXA";

        /// <summary>
        /// ZRATXN.
        /// </summary>
        public const string ZRATXN = "ZRATXN";

        /// <summary>
        /// ZRSTAM.
        /// </summary>
        public const string ZRSTAM = "ZRSTAM";

        /// <summary>
        /// ZRODAM.
        /// </summary>
        public const string ZRODAM = "ZRODAM";

        /// <summary>
        /// ZRCRCD.
        /// </summary>
        public const string ZRCRCD = "ZRCRCD";

        /// <summary>
        /// ZRTCRC.
        /// </summary>
        public const string ZRTCRC = "ZRTCRC";

        /// <summary>
        /// ZRTADA.
        /// </summary>
        public const string ZRTADA = "ZRTADA";

        /// <summary>
        /// ZRTAAP.
        /// </summary>
        public const string ZRTAAP = "ZRTAAP";

        /// <summary>
        /// ZRTAAJ.
        /// </summary>
        public const string ZRTAAJ = "ZRTAAJ";

        /// <summary>
        /// ZRPTC.
        /// </summary>
        public const string ZRPTC = "ZRPTC";

        /// <summary>
        /// ZRCLMG.
        /// </summary>
        public const string ZRCLMG = "ZRCLMG";

        /// <summary>
        /// ZRLTNA.
        /// </summary>
        public const string ZRLTNA = "ZRLTNA";

        /// <summary>
        /// ZRLTTY.
        /// </summary>
        public const string ZRLTTY = "ZRLTTY";

        /// <summary>
        /// ZRFTR.
        /// </summary>
        public const string ZRFTR = "ZRFTR";

        /// <summary>
        /// ZRCURR.
        /// </summary>
        public const string ZRCURR = "ZRCURR";

        /// <summary>
        /// ZRAG1.
        /// </summary>
        public const string ZRAG1 = "ZRAG1";

        /// <summary>
        /// ZRAG2.
        /// </summary>
        public const string ZRAG2 = "ZRAG2";

        /// <summary>
        /// ZRAG3.
        /// </summary>
        public const string ZRAG3 = "ZRAG3";

        /// <summary>
        /// ZRAG4.
        /// </summary>
        public const string ZRAG4 = "ZRAG4";

        /// <summary>
        /// ZRAG5.
        /// </summary>
        public const string ZRAG5 = "ZRAG5";

        /// <summary>
        /// ZRAG6.
        /// </summary>
        public const string ZRAG6 = "ZRAG6";

        /// <summary>
        /// ZRAG7.
        /// </summary>
        public const string ZRAG7 = "ZRAG7";

        /// <summary>
        /// ZRACL.
        /// </summary>
        public const string ZRACL = "ZRACL";

        /// <summary>
        /// ZRNAPR.
        /// </summary>
        public const string ZRNAPR = "ZRNAPR";

        /// <summary>
        /// ZRSERK.
        /// </summary>
        public const string ZRSERK = "ZRSERK";

        /// <summary>
        /// ZRRNID.
        /// </summary>
        public const string ZRRNID = "ZRRNID";

        /// <summary>
        /// ZRSTMPP.
        /// </summary>
        public const string ZRSTMPP = "ZRSTMPP";

        /// <summary>
        /// ZRVERAR.
        /// </summary>
        public const string ZRVERAR = "ZRVERAR";

        /// <summary>
        /// ZRUSER.
        /// </summary>
        public const string ZRUSER = "ZRUSER";

        /// <summary>
        /// ZRPID.
        /// </summary>
        public const string ZRPID = "ZRPID";

        /// <summary>
        /// ZRUPMJ.
        /// </summary>
        public const string ZRUPMJ = "ZRUPMJ";

        /// <summary>
        /// ZRUPMT.
        /// </summary>
        public const string ZRUPMT = "ZRUPMT";

        /// <summary>
        /// ZRJOBN.
        /// </summary>
        public const string ZRJOBN = "ZRJOBN";

        /// <summary>
        /// ZRAG.
        /// </summary>
        public const string ZRAG = "ZRAG";
    }

    /// <inheritdoc />
    public override string TableName => "F03B20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZRUKID", "ZRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZRCTL", "ZRCTL", JdeDataType.String, 26),
        new JdeField("ZRPLY", "ZRPLY", JdeDataType.Numeric),
        new JdeField("ZRLNID", "ZRLNID", JdeDataType.Numeric),
        new JdeField("ZRRMTA", "ZRRMTA", JdeDataType.Numeric),
        new JdeField("ZRAN8", "ZRAN8", JdeDataType.Numeric),
        new JdeField("ZRCO", "ZRCO", JdeDataType.String, 10),
        new JdeField("ZRAVID", "ZRAVID", JdeDataType.Numeric),
        new JdeField("ZRNOTJ", "ZRNOTJ", JdeDataType.Numeric),
        new JdeField("ZRDT1J", "ZRDT1J", JdeDataType.Numeric),
        new JdeField("ZRNOT", "ZRNOT", JdeDataType.String, 4),
        new JdeField("ZRAGEM", "ZRAGEM", JdeDataType.String, 2),
        new JdeField("ZRAGE", "ZRAGE", JdeDataType.String, 2),
        new JdeField("ZRCRDY", "ZRCRDY", JdeDataType.Numeric),
        new JdeField("ZRAGR1", "ZRAGR1", JdeDataType.Numeric),
        new JdeField("ZRAGR2", "ZRAGR2", JdeDataType.Numeric),
        new JdeField("ZRAGR3", "ZRAGR3", JdeDataType.Numeric),
        new JdeField("ZRAGR4", "ZRAGR4", JdeDataType.Numeric),
        new JdeField("ZRAGR5", "ZRAGR5", JdeDataType.Numeric),
        new JdeField("ZRAGR6", "ZRAGR6", JdeDataType.Numeric),
        new JdeField("ZRAGR7", "ZRAGR7", JdeDataType.Numeric),
        new JdeField("ZRAAP", "ZRAAP", JdeDataType.Numeric),
        new JdeField("ZRADSA", "ZRADSA", JdeDataType.Numeric),
        new JdeField("ZRPYRD", "ZRPYRD", JdeDataType.Numeric),
        new JdeField("ZRADJ", "ZRADJ", JdeDataType.Numeric),
        new JdeField("ZRADJD", "ZRADJD", JdeDataType.Numeric),
        new JdeField("ZRCAD", "ZRCAD", JdeDataType.Numeric),
        new JdeField("ZRPAD", "ZRPAD", JdeDataType.Numeric),
        new JdeField("ZRATXA", "ZRATXA", JdeDataType.Numeric),
        new JdeField("ZRATXN", "ZRATXN", JdeDataType.Numeric),
        new JdeField("ZRSTAM", "ZRSTAM", JdeDataType.Numeric),
        new JdeField("ZRODAM", "ZRODAM", JdeDataType.Numeric),
        new JdeField("ZRCRCD", "ZRCRCD", JdeDataType.String, 6),
        new JdeField("ZRTCRC", "ZRTCRC", JdeDataType.String, 6),
        new JdeField("ZRTADA", "ZRTADA", JdeDataType.Numeric),
        new JdeField("ZRTAAP", "ZRTAAP", JdeDataType.Numeric),
        new JdeField("ZRTAAJ", "ZRTAAJ", JdeDataType.Numeric),
        new JdeField("ZRPTC", "ZRPTC", JdeDataType.String, 6),
        new JdeField("ZRCLMG", "ZRCLMG", JdeDataType.String, 20),
        new JdeField("ZRLTNA", "ZRLTNA", JdeDataType.String, 20),
        new JdeField("ZRLTTY", "ZRLTTY", JdeDataType.String, 2),
        new JdeField("ZRFTR", "ZRFTR", JdeDataType.Numeric),
        new JdeField("ZRCURR", "ZRCURR", JdeDataType.Numeric),
        new JdeField("ZRAG1", "ZRAG1", JdeDataType.Numeric),
        new JdeField("ZRAG2", "ZRAG2", JdeDataType.Numeric),
        new JdeField("ZRAG3", "ZRAG3", JdeDataType.Numeric),
        new JdeField("ZRAG4", "ZRAG4", JdeDataType.Numeric),
        new JdeField("ZRAG5", "ZRAG5", JdeDataType.Numeric),
        new JdeField("ZRAG6", "ZRAG6", JdeDataType.Numeric),
        new JdeField("ZRAG7", "ZRAG7", JdeDataType.Numeric),
        new JdeField("ZRACL", "ZRACL", JdeDataType.Numeric),
        new JdeField("ZRNAPR", "ZRNAPR", JdeDataType.String, 2),
        new JdeField("ZRSERK", "ZRSERK", JdeDataType.Numeric),
        new JdeField("ZRRNID", "ZRRNID", JdeDataType.Numeric),
        new JdeField("ZRSTMPP", "ZRSTMPP", JdeDataType.String, 20),
        new JdeField("ZRVERAR", "ZRVERAR", JdeDataType.String, 20),
        new JdeField("ZRUSER", "ZRUSER", JdeDataType.String, 20),
        new JdeField("ZRPID", "ZRPID", JdeDataType.String, 20),
        new JdeField("ZRUPMJ", "ZRUPMJ", JdeDataType.Numeric),
        new JdeField("ZRUPMT", "ZRUPMT", JdeDataType.Numeric),
        new JdeField("ZRJOBN", "ZRJOBN", JdeDataType.String, 20),
        new JdeField("ZRAG", "ZRAG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B20_0", "Primary Key on ZRUKID", new[] { "ZRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B20_2", "Index on ZRPLY, ZRLNID", new[] { "ZRPLY", "ZRLNID" }),
        new JdeIndex("F03B20_3", "Index on ZRCO", new[] { "ZRCO" }),
        new JdeIndex("F03B20_4", "Index on ZRAN8, SYS_NC00063$, SYS_NC00064$", new[] { "ZRAN8", "SYS_NC00063$", "SYS_NC00064$" })
    };
}
