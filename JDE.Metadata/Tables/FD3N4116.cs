using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N4116 - .
/// </summary>
public class FD3N4116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRACTION.
        /// </summary>
        public const string IRACTION = "IRACTION";

        /// <summary>
        /// IRLNID.
        /// </summary>
        public const string IRLNID = "IRLNID";

        /// <summary>
        /// IRBST.
        /// </summary>
        public const string IRBST = "IRBST";

        /// <summary>
        /// IRJOBS.
        /// </summary>
        public const string IRJOBS = "IRJOBS";

        /// <summary>
        /// IRJELN.
        /// </summary>
        public const string IRJELN = "IRJELN";

        /// <summary>
        /// IRKCO.
        /// </summary>
        public const string IRKCO = "IRKCO";

        /// <summary>
        /// IRICU.
        /// </summary>
        public const string IRICU = "IRICU";

        /// <summary>
        /// IRLDSC.
        /// </summary>
        public const string IRLDSC = "IRLDSC";

        /// <summary>
        /// IRMMEJ.
        /// </summary>
        public const string IRMMEJ = "IRMMEJ";

        /// <summary>
        /// IRLOTS.
        /// </summary>
        public const string IRLOTS = "IRLOTS";

        /// <summary>
        /// IRLOT1.
        /// </summary>
        public const string IRLOT1 = "IRLOT1";

        /// <summary>
        /// IRLOTP.
        /// </summary>
        public const string IRLOTP = "IRLOTP";

        /// <summary>
        /// IRLOT2.
        /// </summary>
        public const string IRLOT2 = "IRLOT2";

        /// <summary>
        /// IRLOTG.
        /// </summary>
        public const string IRLOTG = "IRLOTG";

        /// <summary>
        /// IRRCD.
        /// </summary>
        public const string IRRCD = "IRRCD";

        /// <summary>
        /// IRPAID.
        /// </summary>
        public const string IRPAID = "IRPAID";

        /// <summary>
        /// IRUNCS.
        /// </summary>
        public const string IRUNCS = "IRUNCS";

        /// <summary>
        /// IRLOTN.
        /// </summary>
        public const string IRLOTN = "IRLOTN";

        /// <summary>
        /// IRLOCNE1.
        /// </summary>
        public const string IRLOCNE1 = "IRLOCNE1";

        /// <summary>
        /// IRTRUM.
        /// </summary>
        public const string IRTRUM = "IRTRUM";

        /// <summary>
        /// IRTRQT.
        /// </summary>
        public const string IRTRQT = "IRTRQT";

        /// <summary>
        /// IRUITM.
        /// </summary>
        public const string IRUITM = "IRUITM";

        /// <summary>
        /// IRITM.
        /// </summary>
        public const string IRITM = "IRITM";

        /// <summary>
        /// IRTRNO.
        /// </summary>
        public const string IRTRNO = "IRTRNO";

        /// <summary>
        /// IRFRTO.
        /// </summary>
        public const string IRFRTO = "IRFRTO";

        /// <summary>
        /// IRMCUF.
        /// </summary>
        public const string IRMCUF = "IRMCUF";

        /// <summary>
        /// IRMCUT.
        /// </summary>
        public const string IRMCUT = "IRMCUT";

        /// <summary>
        /// IRTRDJ.
        /// </summary>
        public const string IRTRDJ = "IRTRDJ";

        /// <summary>
        /// IRTREX.
        /// </summary>
        public const string IRTREX = "IRTREX";

        /// <summary>
        /// IRDGL.
        /// </summary>
        public const string IRDGL = "IRDGL";

        /// <summary>
        /// IRDCT.
        /// </summary>
        public const string IRDCT = "IRDCT";

        /// <summary>
        /// IRDOC.
        /// </summary>
        public const string IRDOC = "IRDOC";

        /// <summary>
        /// IRVERS.
        /// </summary>
        public const string IRVERS = "IRVERS";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRTDAY.
        /// </summary>
        public const string IRTDAY = "IRTDAY";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IREV09.
        /// </summary>
        public const string IREV09 = "IREV09";

        /// <summary>
        /// IRUKID.
        /// </summary>
        public const string IRUKID = "IRUKID";

        /// <summary>
        /// IRCFRGUID.
        /// </summary>
        public const string IRCFRGUID = "IRCFRGUID";

        /// <summary>
        /// IRUSR1.
        /// </summary>
        public const string IRUSR1 = "IRUSR1";

        /// <summary>
        /// IRFULLNAME1.
        /// </summary>
        public const string IRFULLNAME1 = "IRFULLNAME1";

        /// <summary>
        /// IRUSR2.
        /// </summary>
        public const string IRUSR2 = "IRUSR2";

        /// <summary>
        /// IRFULLNAME2.
        /// </summary>
        public const string IRFULLNAME2 = "IRFULLNAME2";

        /// <summary>
        /// IRREASON1.
        /// </summary>
        public const string IRREASON1 = "IRREASON1";

        /// <summary>
        /// IRCOMMENTS.
        /// </summary>
        public const string IRCOMMENTS = "IRCOMMENTS";

        /// <summary>
        /// IRREASON2.
        /// </summary>
        public const string IRREASON2 = "IRREASON2";

        /// <summary>
        /// IR2COMMENTS.
        /// </summary>
        public const string IR2COMMENTS = "IR2COMMENTS";

        /// <summary>
        /// IRFMNMVERS.
        /// </summary>
        public const string IRFMNMVERS = "IRFMNMVERS";

        /// <summary>
        /// IRTEXTMES.
        /// </summary>
        public const string IRTEXTMES = "IRTEXTMES";

        /// <summary>
        /// IRUOM2.
        /// </summary>
        public const string IRUOM2 = "IRUOM2";

        /// <summary>
        /// IRTGN.
        /// </summary>
        public const string IRTGN = "IRTGN";

        /// <summary>
        /// IRSQOR.
        /// </summary>
        public const string IRSQOR = "IRSQOR";

        /// <summary>
        /// IRRFLN.
        /// </summary>
        public const string IRRFLN = "IRRFLN";

        /// <summary>
        /// IRDLEJ.
        /// </summary>
        public const string IRDLEJ = "IRDLEJ";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N4116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRACTION", "IRACTION", JdeDataType.String, 2),
        new JdeField("IRLNID", "IRLNID", JdeDataType.Numeric),
        new JdeField("IRBST", "IRBST", JdeDataType.String, 2),
        new JdeField("IRJOBS", "IRJOBS", JdeDataType.Numeric),
        new JdeField("IRJELN", "IRJELN", JdeDataType.Numeric),
        new JdeField("IRKCO", "IRKCO", JdeDataType.String, 10),
        new JdeField("IRICU", "IRICU", JdeDataType.Numeric),
        new JdeField("IRLDSC", "IRLDSC", JdeDataType.String, 60),
        new JdeField("IRMMEJ", "IRMMEJ", JdeDataType.Numeric),
        new JdeField("IRLOTS", "IRLOTS", JdeDataType.String, 2),
        new JdeField("IRLOT1", "IRLOT1", JdeDataType.String, 60),
        new JdeField("IRLOTP", "IRLOTP", JdeDataType.Numeric),
        new JdeField("IRLOT2", "IRLOT2", JdeDataType.String, 60),
        new JdeField("IRLOTG", "IRLOTG", JdeDataType.String, 6),
        new JdeField("IRRCD", "IRRCD", JdeDataType.String, 6),
        new JdeField("IRPAID", "IRPAID", JdeDataType.Numeric),
        new JdeField("IRUNCS", "IRUNCS", JdeDataType.Numeric),
        new JdeField("IRLOTN", "IRLOTN", JdeDataType.String, 60),
        new JdeField("IRLOCNE1", "IRLOCNE1", JdeDataType.String, 40),
        new JdeField("IRTRUM", "IRTRUM", JdeDataType.String, 4),
        new JdeField("IRTRQT", "IRTRQT", JdeDataType.Numeric),
        new JdeField("IRUITM", "IRUITM", JdeDataType.String, 52),
        new JdeField("IRITM", "IRITM", JdeDataType.Numeric),
        new JdeField("IRTRNO", "IRTRNO", JdeDataType.Numeric, null, true, true),
        new JdeField("IRFRTO", "IRFRTO", JdeDataType.String, 2),
        new JdeField("IRMCUF", "IRMCUF", JdeDataType.String, 24),
        new JdeField("IRMCUT", "IRMCUT", JdeDataType.String, 24),
        new JdeField("IRTRDJ", "IRTRDJ", JdeDataType.Numeric),
        new JdeField("IRTREX", "IRTREX", JdeDataType.String, 60),
        new JdeField("IRDGL", "IRDGL", JdeDataType.Numeric),
        new JdeField("IRDCT", "IRDCT", JdeDataType.String, 4),
        new JdeField("IRDOC", "IRDOC", JdeDataType.Numeric),
        new JdeField("IRVERS", "IRVERS", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRTDAY", "IRTDAY", JdeDataType.Numeric),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IREV09", "IREV09", JdeDataType.String, 2),
        new JdeField("IRUKID", "IRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IRCFRGUID", "IRCFRGUID", JdeDataType.String, 72),
        new JdeField("IRUSR1", "IRUSR1", JdeDataType.String, 20),
        new JdeField("IRFULLNAME1", "IRFULLNAME1", JdeDataType.String, 100),
        new JdeField("IRUSR2", "IRUSR2", JdeDataType.String, 20),
        new JdeField("IRFULLNAME2", "IRFULLNAME2", JdeDataType.String, 100),
        new JdeField("IRREASON1", "IRREASON1", JdeDataType.Numeric),
        new JdeField("IRCOMMENTS", "IRCOMMENTS", JdeDataType.String, 512),
        new JdeField("IRREASON2", "IRREASON2", JdeDataType.Numeric),
        new JdeField("IR2COMMENTS", "IR2COMMENTS", JdeDataType.String, 512),
        new JdeField("IRFMNMVERS", "IRFMNMVERS", JdeDataType.String, 20),
        new JdeField("IRTEXTMES", "IRTEXTMES", JdeDataType.String, 512),
        new JdeField("IRUOM2", "IRUOM2", JdeDataType.String, 4),
        new JdeField("IRTGN", "IRTGN", JdeDataType.Numeric),
        new JdeField("IRSQOR", "IRSQOR", JdeDataType.Numeric),
        new JdeField("IRRFLN", "IRRFLN", JdeDataType.Numeric),
        new JdeField("IRDLEJ", "IRDLEJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N4116_0", "Primary Key on IRTRNO, IRUKID", new[] { "IRTRNO", "IRUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
