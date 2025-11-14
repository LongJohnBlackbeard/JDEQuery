using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H611 - .
/// </summary>
public class F76H611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALNLIN.
        /// </summary>
        public const string ALNLIN = "ALNLIN";

        /// <summary>
        /// ALITM.
        /// </summary>
        public const string ALITM = "ALITM";

        /// <summary>
        /// ALLITM.
        /// </summary>
        public const string ALLITM = "ALLITM";

        /// <summary>
        /// ALAITM.
        /// </summary>
        public const string ALAITM = "ALAITM";

        /// <summary>
        /// ALMCU.
        /// </summary>
        public const string ALMCU = "ALMCU";

        /// <summary>
        /// ALLOCN.
        /// </summary>
        public const string ALLOCN = "ALLOCN";

        /// <summary>
        /// ALLOTN.
        /// </summary>
        public const string ALLOTN = "ALLOTN";

        /// <summary>
        /// ALPLOT.
        /// </summary>
        public const string ALPLOT = "ALPLOT";

        /// <summary>
        /// ALSTUN.
        /// </summary>
        public const string ALSTUN = "ALSTUN";

        /// <summary>
        /// ALLDSQ.
        /// </summary>
        public const string ALLDSQ = "ALLDSQ";

        /// <summary>
        /// ALTRNO.
        /// </summary>
        public const string ALTRNO = "ALTRNO";

        /// <summary>
        /// ALFRTO.
        /// </summary>
        public const string ALFRTO = "ALFRTO";

        /// <summary>
        /// ALLMCX.
        /// </summary>
        public const string ALLMCX = "ALLMCX";

        /// <summary>
        /// ALLOTS.
        /// </summary>
        public const string ALLOTS = "ALLOTS";

        /// <summary>
        /// ALLOTP.
        /// </summary>
        public const string ALLOTP = "ALLOTP";

        /// <summary>
        /// ALLOTG.
        /// </summary>
        public const string ALLOTG = "ALLOTG";

        /// <summary>
        /// ALKIT.
        /// </summary>
        public const string ALKIT = "ALKIT";

        /// <summary>
        /// ALMMCU.
        /// </summary>
        public const string ALMMCU = "ALMMCU";

        /// <summary>
        /// ALDMCT.
        /// </summary>
        public const string ALDMCT = "ALDMCT";

        /// <summary>
        /// ALDMCS.
        /// </summary>
        public const string ALDMCS = "ALDMCS";

        /// <summary>
        /// ALBALU.
        /// </summary>
        public const string ALBALU = "ALBALU";

        /// <summary>
        /// ALKCO.
        /// </summary>
        public const string ALKCO = "ALKCO";

        /// <summary>
        /// ALDOC.
        /// </summary>
        public const string ALDOC = "ALDOC";

        /// <summary>
        /// ALDCT.
        /// </summary>
        public const string ALDCT = "ALDCT";

        /// <summary>
        /// ALSFX.
        /// </summary>
        public const string ALSFX = "ALSFX";

        /// <summary>
        /// ALJELN.
        /// </summary>
        public const string ALJELN = "ALJELN";

        /// <summary>
        /// ALICU.
        /// </summary>
        public const string ALICU = "ALICU";

        /// <summary>
        /// ALDGL.
        /// </summary>
        public const string ALDGL = "ALDGL";

        /// <summary>
        /// ALGLPT.
        /// </summary>
        public const string ALGLPT = "ALGLPT";

        /// <summary>
        /// ALDCTO.
        /// </summary>
        public const string ALDCTO = "ALDCTO";

        /// <summary>
        /// ALDOCO.
        /// </summary>
        public const string ALDOCO = "ALDOCO";

        /// <summary>
        /// ALKCOO.
        /// </summary>
        public const string ALKCOO = "ALKCOO";

        /// <summary>
        /// ALLNID.
        /// </summary>
        public const string ALLNID = "ALLNID";

        /// <summary>
        /// ALIPCD.
        /// </summary>
        public const string ALIPCD = "ALIPCD";

        /// <summary>
        /// ALTRDJ.
        /// </summary>
        public const string ALTRDJ = "ALTRDJ";

        /// <summary>
        /// ALTRUM.
        /// </summary>
        public const string ALTRUM = "ALTRUM";

        /// <summary>
        /// ALAN8.
        /// </summary>
        public const string ALAN8 = "ALAN8";

        /// <summary>
        /// ALTREX.
        /// </summary>
        public const string ALTREX = "ALTREX";

        /// <summary>
        /// ALTREF.
        /// </summary>
        public const string ALTREF = "ALTREF";

        /// <summary>
        /// ALRCD.
        /// </summary>
        public const string ALRCD = "ALRCD";

        /// <summary>
        /// ALTRQT.
        /// </summary>
        public const string ALTRQT = "ALTRQT";

        /// <summary>
        /// ALUNCS.
        /// </summary>
        public const string ALUNCS = "ALUNCS";

        /// <summary>
        /// ALPAID.
        /// </summary>
        public const string ALPAID = "ALPAID";

        /// <summary>
        /// ALTERM.
        /// </summary>
        public const string ALTERM = "ALTERM";

        /// <summary>
        /// ALUKID.
        /// </summary>
        public const string ALUKID = "ALUKID";

        /// <summary>
        /// ALTDAY.
        /// </summary>
        public const string ALTDAY = "ALTDAY";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALCRDJ.
        /// </summary>
        public const string ALCRDJ = "ALCRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76H611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALNLIN", "ALNLIN", JdeDataType.Numeric),
        new JdeField("ALITM", "ALITM", JdeDataType.Numeric),
        new JdeField("ALLITM", "ALLITM", JdeDataType.String, 50),
        new JdeField("ALAITM", "ALAITM", JdeDataType.String, 50),
        new JdeField("ALMCU", "ALMCU", JdeDataType.String, 24),
        new JdeField("ALLOCN", "ALLOCN", JdeDataType.String, 40),
        new JdeField("ALLOTN", "ALLOTN", JdeDataType.String, 60),
        new JdeField("ALPLOT", "ALPLOT", JdeDataType.String, 60),
        new JdeField("ALSTUN", "ALSTUN", JdeDataType.Numeric),
        new JdeField("ALLDSQ", "ALLDSQ", JdeDataType.Numeric),
        new JdeField("ALTRNO", "ALTRNO", JdeDataType.Numeric),
        new JdeField("ALFRTO", "ALFRTO", JdeDataType.String, 2),
        new JdeField("ALLMCX", "ALLMCX", JdeDataType.String, 2),
        new JdeField("ALLOTS", "ALLOTS", JdeDataType.String, 2),
        new JdeField("ALLOTP", "ALLOTP", JdeDataType.Numeric),
        new JdeField("ALLOTG", "ALLOTG", JdeDataType.String, 6),
        new JdeField("ALKIT", "ALKIT", JdeDataType.Numeric),
        new JdeField("ALMMCU", "ALMMCU", JdeDataType.String, 24),
        new JdeField("ALDMCT", "ALDMCT", JdeDataType.String, 24),
        new JdeField("ALDMCS", "ALDMCS", JdeDataType.Numeric),
        new JdeField("ALBALU", "ALBALU", JdeDataType.String, 2),
        new JdeField("ALKCO", "ALKCO", JdeDataType.String, 10),
        new JdeField("ALDOC", "ALDOC", JdeDataType.Numeric),
        new JdeField("ALDCT", "ALDCT", JdeDataType.String, 4),
        new JdeField("ALSFX", "ALSFX", JdeDataType.String, 6),
        new JdeField("ALJELN", "ALJELN", JdeDataType.Numeric),
        new JdeField("ALICU", "ALICU", JdeDataType.Numeric),
        new JdeField("ALDGL", "ALDGL", JdeDataType.Numeric),
        new JdeField("ALGLPT", "ALGLPT", JdeDataType.String, 8),
        new JdeField("ALDCTO", "ALDCTO", JdeDataType.String, 4),
        new JdeField("ALDOCO", "ALDOCO", JdeDataType.Numeric),
        new JdeField("ALKCOO", "ALKCOO", JdeDataType.String, 10),
        new JdeField("ALLNID", "ALLNID", JdeDataType.Numeric),
        new JdeField("ALIPCD", "ALIPCD", JdeDataType.String, 2),
        new JdeField("ALTRDJ", "ALTRDJ", JdeDataType.Numeric),
        new JdeField("ALTRUM", "ALTRUM", JdeDataType.String, 4),
        new JdeField("ALAN8", "ALAN8", JdeDataType.Numeric),
        new JdeField("ALTREX", "ALTREX", JdeDataType.String, 60),
        new JdeField("ALTREF", "ALTREF", JdeDataType.String, 16),
        new JdeField("ALRCD", "ALRCD", JdeDataType.String, 6),
        new JdeField("ALTRQT", "ALTRQT", JdeDataType.Numeric),
        new JdeField("ALUNCS", "ALUNCS", JdeDataType.Numeric),
        new JdeField("ALPAID", "ALPAID", JdeDataType.Numeric),
        new JdeField("ALTERM", "ALTERM", JdeDataType.String, 20),
        new JdeField("ALUKID", "ALUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALTDAY", "ALTDAY", JdeDataType.Numeric),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALCRDJ", "ALCRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H611_0", "Primary Key on ALUKID", new[] { "ALUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H611_10", "Index on ALKCO, SYS_NC00051$, ALUKID", new[] { "ALKCO", "SYS_NC00051$", "ALUKID" }),
        new JdeIndex("F76H611_2", "Index on ALDOC, ALDCT, ALKCO, ALDGL, ALJELN", new[] { "ALDOC", "ALDCT", "ALKCO", "ALDGL", "ALJELN" }),
        new JdeIndex("F76H611_3", "Index on ALDOC, ALDCT, ALKCO, ALLNID, ALDGL", new[] { "ALDOC", "ALDCT", "ALKCO", "ALLNID", "ALDGL" }),
        new JdeIndex("F76H611_4", "Index on ALDOCO, ALDCTO, ALKCOO, ALLNID, ALDGL", new[] { "ALDOCO", "ALDCTO", "ALKCOO", "ALLNID", "ALDGL" }),
        new JdeIndex("F76H611_5", "Index on ALITM, ALMMCU, ALTRDJ", new[] { "ALITM", "ALMMCU", "ALTRDJ" }),
        new JdeIndex("F76H611_6", "Index on ALMCU, ALITM, ALLOCN, ALLOTN", new[] { "ALMCU", "ALITM", "ALLOCN", "ALLOTN" }),
        new JdeIndex("F76H611_7", "Index on ALDOC, ALDCT, ALITM, ALMCU, ALLOTN", new[] { "ALDOC", "ALDCT", "ALITM", "ALMCU", "ALLOTN" }),
        new JdeIndex("F76H611_8", "Index on SYS_NC00050$", new[] { "SYS_NC00050$" }),
        new JdeIndex("F76H611_9", "Index on ALDCT", new[] { "ALDCT" })
    };
}
