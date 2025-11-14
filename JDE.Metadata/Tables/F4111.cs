using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4111 - .
/// </summary>
public class F4111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILNLIN.
        /// </summary>
        public const string ILNLIN = "ILNLIN";

        /// <summary>
        /// ILITM.
        /// </summary>
        public const string ILITM = "ILITM";

        /// <summary>
        /// ILLITM.
        /// </summary>
        public const string ILLITM = "ILLITM";

        /// <summary>
        /// ILAITM.
        /// </summary>
        public const string ILAITM = "ILAITM";

        /// <summary>
        /// ILMCU.
        /// </summary>
        public const string ILMCU = "ILMCU";

        /// <summary>
        /// ILLOCN.
        /// </summary>
        public const string ILLOCN = "ILLOCN";

        /// <summary>
        /// ILLOTN.
        /// </summary>
        public const string ILLOTN = "ILLOTN";

        /// <summary>
        /// ILPLOT.
        /// </summary>
        public const string ILPLOT = "ILPLOT";

        /// <summary>
        /// ILSTUN.
        /// </summary>
        public const string ILSTUN = "ILSTUN";

        /// <summary>
        /// ILLDSQ.
        /// </summary>
        public const string ILLDSQ = "ILLDSQ";

        /// <summary>
        /// ILTRNO.
        /// </summary>
        public const string ILTRNO = "ILTRNO";

        /// <summary>
        /// ILFRTO.
        /// </summary>
        public const string ILFRTO = "ILFRTO";

        /// <summary>
        /// ILLMCX.
        /// </summary>
        public const string ILLMCX = "ILLMCX";

        /// <summary>
        /// ILLOTS.
        /// </summary>
        public const string ILLOTS = "ILLOTS";

        /// <summary>
        /// ILLOTP.
        /// </summary>
        public const string ILLOTP = "ILLOTP";

        /// <summary>
        /// ILLOTG.
        /// </summary>
        public const string ILLOTG = "ILLOTG";

        /// <summary>
        /// ILKIT.
        /// </summary>
        public const string ILKIT = "ILKIT";

        /// <summary>
        /// ILMMCU.
        /// </summary>
        public const string ILMMCU = "ILMMCU";

        /// <summary>
        /// ILDMCT.
        /// </summary>
        public const string ILDMCT = "ILDMCT";

        /// <summary>
        /// ILDMCS.
        /// </summary>
        public const string ILDMCS = "ILDMCS";

        /// <summary>
        /// ILKCO.
        /// </summary>
        public const string ILKCO = "ILKCO";

        /// <summary>
        /// ILDOC.
        /// </summary>
        public const string ILDOC = "ILDOC";

        /// <summary>
        /// ILDCT.
        /// </summary>
        public const string ILDCT = "ILDCT";

        /// <summary>
        /// ILSFX.
        /// </summary>
        public const string ILSFX = "ILSFX";

        /// <summary>
        /// ILJELN.
        /// </summary>
        public const string ILJELN = "ILJELN";

        /// <summary>
        /// ILICU.
        /// </summary>
        public const string ILICU = "ILICU";

        /// <summary>
        /// ILDGL.
        /// </summary>
        public const string ILDGL = "ILDGL";

        /// <summary>
        /// ILGLPT.
        /// </summary>
        public const string ILGLPT = "ILGLPT";

        /// <summary>
        /// ILDCTO.
        /// </summary>
        public const string ILDCTO = "ILDCTO";

        /// <summary>
        /// ILDOCO.
        /// </summary>
        public const string ILDOCO = "ILDOCO";

        /// <summary>
        /// ILKCOO.
        /// </summary>
        public const string ILKCOO = "ILKCOO";

        /// <summary>
        /// ILLNID.
        /// </summary>
        public const string ILLNID = "ILLNID";

        /// <summary>
        /// ILIPCD.
        /// </summary>
        public const string ILIPCD = "ILIPCD";

        /// <summary>
        /// ILTRDJ.
        /// </summary>
        public const string ILTRDJ = "ILTRDJ";

        /// <summary>
        /// ILTRUM.
        /// </summary>
        public const string ILTRUM = "ILTRUM";

        /// <summary>
        /// ILAN8.
        /// </summary>
        public const string ILAN8 = "ILAN8";

        /// <summary>
        /// ILTREX.
        /// </summary>
        public const string ILTREX = "ILTREX";

        /// <summary>
        /// ILTREF.
        /// </summary>
        public const string ILTREF = "ILTREF";

        /// <summary>
        /// ILRCD.
        /// </summary>
        public const string ILRCD = "ILRCD";

        /// <summary>
        /// ILTRQT.
        /// </summary>
        public const string ILTRQT = "ILTRQT";

        /// <summary>
        /// ILUNCS.
        /// </summary>
        public const string ILUNCS = "ILUNCS";

        /// <summary>
        /// ILPAID.
        /// </summary>
        public const string ILPAID = "ILPAID";

        /// <summary>
        /// ILTERM.
        /// </summary>
        public const string ILTERM = "ILTERM";

        /// <summary>
        /// ILUKID.
        /// </summary>
        public const string ILUKID = "ILUKID";

        /// <summary>
        /// ILTDAY.
        /// </summary>
        public const string ILTDAY = "ILTDAY";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILPID.
        /// </summary>
        public const string ILPID = "ILPID";

        /// <summary>
        /// ILCRDJ.
        /// </summary>
        public const string ILCRDJ = "ILCRDJ";

        /// <summary>
        /// ILAID.
        /// </summary>
        public const string ILAID = "ILAID";

        /// <summary>
        /// ILASID.
        /// </summary>
        public const string ILASID = "ILASID";

        /// <summary>
        /// ILMCUZ.
        /// </summary>
        public const string ILMCUZ = "ILMCUZ";

        /// <summary>
        /// ILOBJ.
        /// </summary>
        public const string ILOBJ = "ILOBJ";

        /// <summary>
        /// ILSBL.
        /// </summary>
        public const string ILSBL = "ILSBL";

        /// <summary>
        /// ILSUB.
        /// </summary>
        public const string ILSUB = "ILSUB";

        /// <summary>
        /// ILUOM2.
        /// </summary>
        public const string ILUOM2 = "ILUOM2";

        /// <summary>
        /// ILCMOO.
        /// </summary>
        public const string ILCMOO = "ILCMOO";

        /// <summary>
        /// ILRE.
        /// </summary>
        public const string ILRE = "ILRE";

        /// <summary>
        /// ILSBLT.
        /// </summary>
        public const string ILSBLT = "ILSBLT";

        /// <summary>
        /// ILSQOR.
        /// </summary>
        public const string ILSQOR = "ILSQOR";

        /// <summary>
        /// ILVPEJ.
        /// </summary>
        public const string ILVPEJ = "ILVPEJ";

        /// <summary>
        /// ILHDGJ.
        /// </summary>
        public const string ILHDGJ = "ILHDGJ";

        /// <summary>
        /// ILSHAN.
        /// </summary>
        public const string ILSHAN = "ILSHAN";

        /// <summary>
        /// ILOPSQ.
        /// </summary>
        public const string ILOPSQ = "ILOPSQ";

        /// <summary>
        /// ILRFLN.
        /// </summary>
        public const string ILRFLN = "ILRFLN";

        /// <summary>
        /// ILTGN.
        /// </summary>
        public const string ILTGN = "ILTGN";

        /// <summary>
        /// ILLOTC.
        /// </summary>
        public const string ILLOTC = "ILLOTC";

        /// <summary>
        /// ILSVDT.
        /// </summary>
        public const string ILSVDT = "ILSVDT";

        /// <summary>
        /// ILLRCD.
        /// </summary>
        public const string ILLRCD = "ILLRCD";

        /// <summary>
        /// ILRLOT.
        /// </summary>
        public const string ILRLOT = "ILRLOT";

        /// <summary>
        /// ILLPNU.
        /// </summary>
        public const string ILLPNU = "ILLPNU";

        /// <summary>
        /// ILPMPN.
        /// </summary>
        public const string ILPMPN = "ILPMPN";

        /// <summary>
        /// ILPNS.
        /// </summary>
        public const string ILPNS = "ILPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F4111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILNLIN", "ILNLIN", JdeDataType.Numeric),
        new JdeField("ILITM", "ILITM", JdeDataType.Numeric),
        new JdeField("ILLITM", "ILLITM", JdeDataType.String, 50),
        new JdeField("ILAITM", "ILAITM", JdeDataType.String, 50),
        new JdeField("ILMCU", "ILMCU", JdeDataType.String, 24),
        new JdeField("ILLOCN", "ILLOCN", JdeDataType.String, 40),
        new JdeField("ILLOTN", "ILLOTN", JdeDataType.String, 60),
        new JdeField("ILPLOT", "ILPLOT", JdeDataType.String, 60),
        new JdeField("ILSTUN", "ILSTUN", JdeDataType.Numeric),
        new JdeField("ILLDSQ", "ILLDSQ", JdeDataType.Numeric),
        new JdeField("ILTRNO", "ILTRNO", JdeDataType.Numeric),
        new JdeField("ILFRTO", "ILFRTO", JdeDataType.String, 2),
        new JdeField("ILLMCX", "ILLMCX", JdeDataType.String, 2),
        new JdeField("ILLOTS", "ILLOTS", JdeDataType.String, 2),
        new JdeField("ILLOTP", "ILLOTP", JdeDataType.Numeric),
        new JdeField("ILLOTG", "ILLOTG", JdeDataType.String, 6),
        new JdeField("ILKIT", "ILKIT", JdeDataType.Numeric),
        new JdeField("ILMMCU", "ILMMCU", JdeDataType.String, 24),
        new JdeField("ILDMCT", "ILDMCT", JdeDataType.String, 24),
        new JdeField("ILDMCS", "ILDMCS", JdeDataType.Numeric),
        new JdeField("ILKCO", "ILKCO", JdeDataType.String, 10),
        new JdeField("ILDOC", "ILDOC", JdeDataType.Numeric),
        new JdeField("ILDCT", "ILDCT", JdeDataType.String, 4),
        new JdeField("ILSFX", "ILSFX", JdeDataType.String, 6),
        new JdeField("ILJELN", "ILJELN", JdeDataType.Numeric),
        new JdeField("ILICU", "ILICU", JdeDataType.Numeric),
        new JdeField("ILDGL", "ILDGL", JdeDataType.Numeric),
        new JdeField("ILGLPT", "ILGLPT", JdeDataType.String, 8),
        new JdeField("ILDCTO", "ILDCTO", JdeDataType.String, 4),
        new JdeField("ILDOCO", "ILDOCO", JdeDataType.Numeric),
        new JdeField("ILKCOO", "ILKCOO", JdeDataType.String, 10),
        new JdeField("ILLNID", "ILLNID", JdeDataType.Numeric),
        new JdeField("ILIPCD", "ILIPCD", JdeDataType.String, 2),
        new JdeField("ILTRDJ", "ILTRDJ", JdeDataType.Numeric),
        new JdeField("ILTRUM", "ILTRUM", JdeDataType.String, 4),
        new JdeField("ILAN8", "ILAN8", JdeDataType.Numeric),
        new JdeField("ILTREX", "ILTREX", JdeDataType.String, 60),
        new JdeField("ILTREF", "ILTREF", JdeDataType.String, 16),
        new JdeField("ILRCD", "ILRCD", JdeDataType.String, 6),
        new JdeField("ILTRQT", "ILTRQT", JdeDataType.Numeric),
        new JdeField("ILUNCS", "ILUNCS", JdeDataType.Numeric),
        new JdeField("ILPAID", "ILPAID", JdeDataType.Numeric),
        new JdeField("ILTERM", "ILTERM", JdeDataType.String, 20),
        new JdeField("ILUKID", "ILUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ILTDAY", "ILTDAY", JdeDataType.Numeric),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20),
        new JdeField("ILPID", "ILPID", JdeDataType.String, 20),
        new JdeField("ILCRDJ", "ILCRDJ", JdeDataType.Numeric),
        new JdeField("ILAID", "ILAID", JdeDataType.String, 16),
        new JdeField("ILASID", "ILASID", JdeDataType.String, 50),
        new JdeField("ILMCUZ", "ILMCUZ", JdeDataType.String, 24),
        new JdeField("ILOBJ", "ILOBJ", JdeDataType.String, 12),
        new JdeField("ILSBL", "ILSBL", JdeDataType.String, 16),
        new JdeField("ILSUB", "ILSUB", JdeDataType.String, 16),
        new JdeField("ILUOM2", "ILUOM2", JdeDataType.String, 4),
        new JdeField("ILCMOO", "ILCMOO", JdeDataType.String, 2),
        new JdeField("ILRE", "ILRE", JdeDataType.String, 2),
        new JdeField("ILSBLT", "ILSBLT", JdeDataType.String, 2),
        new JdeField("ILSQOR", "ILSQOR", JdeDataType.Numeric),
        new JdeField("ILVPEJ", "ILVPEJ", JdeDataType.Numeric),
        new JdeField("ILHDGJ", "ILHDGJ", JdeDataType.Numeric),
        new JdeField("ILSHAN", "ILSHAN", JdeDataType.Numeric),
        new JdeField("ILOPSQ", "ILOPSQ", JdeDataType.Numeric),
        new JdeField("ILRFLN", "ILRFLN", JdeDataType.Numeric),
        new JdeField("ILTGN", "ILTGN", JdeDataType.Numeric),
        new JdeField("ILLOTC", "ILLOTC", JdeDataType.String, 6),
        new JdeField("ILSVDT", "ILSVDT", JdeDataType.Numeric),
        new JdeField("ILLRCD", "ILLRCD", JdeDataType.String, 6),
        new JdeField("ILRLOT", "ILRLOT", JdeDataType.String, 60),
        new JdeField("ILLPNU", "ILLPNU", JdeDataType.String, 80),
        new JdeField("ILPMPN", "ILPMPN", JdeDataType.String, 60),
        new JdeField("ILPNS", "ILPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4111_0", "Primary Key on ILUKID", new[] { "ILUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4111_10", "Index on ILKCO, SYS_NC00073$, ILUKID", new[] { "ILKCO", "SYS_NC00073$", "ILUKID" }),
        new JdeIndex("F4111_11", "Index on ILPLOT", new[] { "ILPLOT" }),
        new JdeIndex("F4111_12", "Index on ILAN8, ILRLOT, ILITM, ILMCU, ILLOCN, ILLOTN", new[] { "ILAN8", "ILRLOT", "ILITM", "ILMCU", "ILLOCN", "ILLOTN" }),
        new JdeIndex("F4111_13", "Index on ILLOTN", new[] { "ILLOTN" }),
        new JdeIndex("F4111_14", "Index on SYS_NC00074$", new[] { "SYS_NC00074$" }),
        new JdeIndex("F4111_2", "Index on ILDOC, ILDCT, ILKCO, ILDGL, ILJELN", new[] { "ILDOC", "ILDCT", "ILKCO", "ILDGL", "ILJELN" }),
        new JdeIndex("F4111_3", "Index on ILDOC, ILDCT, ILKCO, ILLNID, ILDGL", new[] { "ILDOC", "ILDCT", "ILKCO", "ILLNID", "ILDGL" }),
        new JdeIndex("F4111_4", "Index on ILDOCO, ILDCTO, ILKCOO, ILLNID, ILDGL", new[] { "ILDOCO", "ILDCTO", "ILKCOO", "ILLNID", "ILDGL" }),
        new JdeIndex("F4111_5", "Index on ILITM, ILMMCU, ILTRDJ", new[] { "ILITM", "ILMMCU", "ILTRDJ" }),
        new JdeIndex("F4111_6", "Index on ILMCU, ILITM, ILLOCN, ILLOTN", new[] { "ILMCU", "ILITM", "ILLOCN", "ILLOTN" }),
        new JdeIndex("F4111_7", "Index on ILDOC, ILDCT, ILITM, ILMCU, ILLOTN", new[] { "ILDOC", "ILDCT", "ILITM", "ILMCU", "ILLOTN" }),
        new JdeIndex("F4111_8", "Index on SYS_NC00075$", new[] { "SYS_NC00075$" }),
        new JdeIndex("F4111_9", "Index on ILDCT", new[] { "ILDCT" })
    };
}
