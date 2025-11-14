using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW22 - .
/// </summary>
public class FCW22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLITM.
        /// </summary>
        public const string WLITM = "WLITM";

        /// <summary>
        /// WLEV01.
        /// </summary>
        public const string WLEV01 = "WLEV01";

        /// <summary>
        /// WLLOTN.
        /// </summary>
        public const string WLLOTN = "WLLOTN";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLLOCN.
        /// </summary>
        public const string WLLOCN = "WLLOCN";

        /// <summary>
        /// WLLDSC.
        /// </summary>
        public const string WLLDSC = "WLLDSC";

        /// <summary>
        /// WLLOTS.
        /// </summary>
        public const string WLLOTS = "WLLOTS";

        /// <summary>
        /// WLVEND.
        /// </summary>
        public const string WLVEND = "WLVEND";

        /// <summary>
        /// WLKCOO.
        /// </summary>
        public const string WLKCOO = "WLKCOO";

        /// <summary>
        /// WLDOCO.
        /// </summary>
        public const string WLDOCO = "WLDOCO";

        /// <summary>
        /// WLDCTO.
        /// </summary>
        public const string WLDCTO = "WLDCTO";

        /// <summary>
        /// WLRLOT.
        /// </summary>
        public const string WLRLOT = "WLRLOT";

        /// <summary>
        /// WLLOTP.
        /// </summary>
        public const string WLLOTP = "WLLOTP";

        /// <summary>
        /// WLLOTG.
        /// </summary>
        public const string WLLOTG = "WLLOTG";

        /// <summary>
        /// WLMMEJ.
        /// </summary>
        public const string WLMMEJ = "WLMMEJ";

        /// <summary>
        /// WLSERN.
        /// </summary>
        public const string WLSERN = "WLSERN";

        /// <summary>
        /// WLUA01.
        /// </summary>
        public const string WLUA01 = "WLUA01";

        /// <summary>
        /// WLUA02.
        /// </summary>
        public const string WLUA02 = "WLUA02";

        /// <summary>
        /// WLUA03.
        /// </summary>
        public const string WLUA03 = "WLUA03";

        /// <summary>
        /// WLUA04.
        /// </summary>
        public const string WLUA04 = "WLUA04";

        /// <summary>
        /// WLUA05.
        /// </summary>
        public const string WLUA05 = "WLUA05";

        /// <summary>
        /// WLUA06.
        /// </summary>
        public const string WLUA06 = "WLUA06";

        /// <summary>
        /// WLUB01.
        /// </summary>
        public const string WLUB01 = "WLUB01";

        /// <summary>
        /// WLUB02.
        /// </summary>
        public const string WLUB02 = "WLUB02";

        /// <summary>
        /// WLUB03.
        /// </summary>
        public const string WLUB03 = "WLUB03";

        /// <summary>
        /// WLUB04.
        /// </summary>
        public const string WLUB04 = "WLUB04";

        /// <summary>
        /// WLUB05.
        /// </summary>
        public const string WLUB05 = "WLUB05";

        /// <summary>
        /// WLUB06.
        /// </summary>
        public const string WLUB06 = "WLUB06";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLTDAY.
        /// </summary>
        public const string WLTDAY = "WLTDAY";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLLRP1.
        /// </summary>
        public const string WLLRP1 = "WLLRP1";

        /// <summary>
        /// WLLRP2.
        /// </summary>
        public const string WLLRP2 = "WLLRP2";

        /// <summary>
        /// WLLRP3.
        /// </summary>
        public const string WLLRP3 = "WLLRP3";

        /// <summary>
        /// WLLRP4.
        /// </summary>
        public const string WLLRP4 = "WLLRP4";

        /// <summary>
        /// WLLRP5.
        /// </summary>
        public const string WLLRP5 = "WLLRP5";

        /// <summary>
        /// WLLRP6.
        /// </summary>
        public const string WLLRP6 = "WLLRP6";

        /// <summary>
        /// WLLRP7.
        /// </summary>
        public const string WLLRP7 = "WLLRP7";

        /// <summary>
        /// WLLRP8.
        /// </summary>
        public const string WLLRP8 = "WLLRP8";

        /// <summary>
        /// WLLRP9.
        /// </summary>
        public const string WLLRP9 = "WLLRP9";

        /// <summary>
        /// WLLRP0.
        /// </summary>
        public const string WLLRP0 = "WLLRP0";

        /// <summary>
        /// WLLOT1.
        /// </summary>
        public const string WLLOT1 = "WLLOT1";

        /// <summary>
        /// WLLOT2.
        /// </summary>
        public const string WLLOT2 = "WLLOT2";

        /// <summary>
        /// WLLOT3.
        /// </summary>
        public const string WLLOT3 = "WLLOT3";

        /// <summary>
        /// WLBBDJ.
        /// </summary>
        public const string WLBBDJ = "WLBBDJ";

        /// <summary>
        /// WLBODJ.
        /// </summary>
        public const string WLBODJ = "WLBODJ";

        /// <summary>
        /// WLDLEJ.
        /// </summary>
        public const string WLDLEJ = "WLDLEJ";

        /// <summary>
        /// WLOHDJ.
        /// </summary>
        public const string WLOHDJ = "WLOHDJ";

        /// <summary>
        /// WLSBDJ.
        /// </summary>
        public const string WLSBDJ = "WLSBDJ";

        /// <summary>
        /// WLU1DJ.
        /// </summary>
        public const string WLU1DJ = "WLU1DJ";

        /// <summary>
        /// WLU2DJ.
        /// </summary>
        public const string WLU2DJ = "WLU2DJ";

        /// <summary>
        /// WLU3DJ.
        /// </summary>
        public const string WLU3DJ = "WLU3DJ";

        /// <summary>
        /// WLU4DJ.
        /// </summary>
        public const string WLU4DJ = "WLU4DJ";

        /// <summary>
        /// WLU5DJ.
        /// </summary>
        public const string WLU5DJ = "WLU5DJ";

        /// <summary>
        /// WLCHDF.
        /// </summary>
        public const string WLCHDF = "WLCHDF";

        /// <summary>
        /// WLWPDF.
        /// </summary>
        public const string WLWPDF = "WLWPDF";

        /// <summary>
        /// WLDOC1.
        /// </summary>
        public const string WLDOC1 = "WLDOC1";

        /// <summary>
        /// WLLOTR.
        /// </summary>
        public const string WLLOTR = "WLLOTR";

        /// <summary>
        /// WLLOTC.
        /// </summary>
        public const string WLLOTC = "WLLOTC";

        /// <summary>
        /// WLORIG.
        /// </summary>
        public const string WLORIG = "WLORIG";
    }

    /// <inheritdoc />
    public override string TableName => "FCW22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLITM", "WLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WLEV01", "WLEV01", JdeDataType.String, 2, true, true),
        new JdeField("WLLOTN", "WLLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLLOCN", "WLLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WLLDSC", "WLLDSC", JdeDataType.String, 60),
        new JdeField("WLLOTS", "WLLOTS", JdeDataType.String, 2),
        new JdeField("WLVEND", "WLVEND", JdeDataType.Numeric),
        new JdeField("WLKCOO", "WLKCOO", JdeDataType.String, 10),
        new JdeField("WLDOCO", "WLDOCO", JdeDataType.Numeric),
        new JdeField("WLDCTO", "WLDCTO", JdeDataType.String, 4),
        new JdeField("WLRLOT", "WLRLOT", JdeDataType.String, 60),
        new JdeField("WLLOTP", "WLLOTP", JdeDataType.Numeric),
        new JdeField("WLLOTG", "WLLOTG", JdeDataType.String, 6),
        new JdeField("WLMMEJ", "WLMMEJ", JdeDataType.Numeric),
        new JdeField("WLSERN", "WLSERN", JdeDataType.String, 60),
        new JdeField("WLUA01", "WLUA01", JdeDataType.Numeric),
        new JdeField("WLUA02", "WLUA02", JdeDataType.Numeric),
        new JdeField("WLUA03", "WLUA03", JdeDataType.Numeric),
        new JdeField("WLUA04", "WLUA04", JdeDataType.Numeric),
        new JdeField("WLUA05", "WLUA05", JdeDataType.Numeric),
        new JdeField("WLUA06", "WLUA06", JdeDataType.Numeric),
        new JdeField("WLUB01", "WLUB01", JdeDataType.Numeric),
        new JdeField("WLUB02", "WLUB02", JdeDataType.Numeric),
        new JdeField("WLUB03", "WLUB03", JdeDataType.Numeric),
        new JdeField("WLUB04", "WLUB04", JdeDataType.Numeric),
        new JdeField("WLUB05", "WLUB05", JdeDataType.Numeric),
        new JdeField("WLUB06", "WLUB06", JdeDataType.Numeric),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLTDAY", "WLTDAY", JdeDataType.Numeric),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLLRP1", "WLLRP1", JdeDataType.String, 6),
        new JdeField("WLLRP2", "WLLRP2", JdeDataType.String, 6),
        new JdeField("WLLRP3", "WLLRP3", JdeDataType.String, 6),
        new JdeField("WLLRP4", "WLLRP4", JdeDataType.String, 6),
        new JdeField("WLLRP5", "WLLRP5", JdeDataType.String, 6),
        new JdeField("WLLRP6", "WLLRP6", JdeDataType.String, 6),
        new JdeField("WLLRP7", "WLLRP7", JdeDataType.String, 6),
        new JdeField("WLLRP8", "WLLRP8", JdeDataType.String, 6),
        new JdeField("WLLRP9", "WLLRP9", JdeDataType.String, 6),
        new JdeField("WLLRP0", "WLLRP0", JdeDataType.String, 6),
        new JdeField("WLLOT1", "WLLOT1", JdeDataType.String, 60),
        new JdeField("WLLOT2", "WLLOT2", JdeDataType.String, 60),
        new JdeField("WLLOT3", "WLLOT3", JdeDataType.String, 60),
        new JdeField("WLBBDJ", "WLBBDJ", JdeDataType.Numeric),
        new JdeField("WLBODJ", "WLBODJ", JdeDataType.Numeric),
        new JdeField("WLDLEJ", "WLDLEJ", JdeDataType.Numeric),
        new JdeField("WLOHDJ", "WLOHDJ", JdeDataType.Numeric),
        new JdeField("WLSBDJ", "WLSBDJ", JdeDataType.Numeric),
        new JdeField("WLU1DJ", "WLU1DJ", JdeDataType.Numeric),
        new JdeField("WLU2DJ", "WLU2DJ", JdeDataType.Numeric),
        new JdeField("WLU3DJ", "WLU3DJ", JdeDataType.Numeric),
        new JdeField("WLU4DJ", "WLU4DJ", JdeDataType.Numeric),
        new JdeField("WLU5DJ", "WLU5DJ", JdeDataType.Numeric),
        new JdeField("WLCHDF", "WLCHDF", JdeDataType.String, 2),
        new JdeField("WLWPDF", "WLWPDF", JdeDataType.String, 2),
        new JdeField("WLDOC1", "WLDOC1", JdeDataType.Numeric),
        new JdeField("WLLOTR", "WLLOTR", JdeDataType.String, 2),
        new JdeField("WLLOTC", "WLLOTC", JdeDataType.String, 6),
        new JdeField("WLORIG", "WLORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW22_0", "Primary Key on WLITM, WLEV01, WLLOTN, WLMCU, WLLOCN", new[] { "WLITM", "WLEV01", "WLLOTN", "WLMCU", "WLLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
