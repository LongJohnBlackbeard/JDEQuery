using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B70 - .
/// </summary>
public class F31B70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VAWOPID.
        /// </summary>
        public const string VAWOPID = "VAWOPID";

        /// <summary>
        /// VAWFTF.
        /// </summary>
        public const string VAWFTF = "VAWFTF";

        /// <summary>
        /// VAWVSEQ.
        /// </summary>
        public const string VAWVSEQ = "VAWVSEQ";

        /// <summary>
        /// VAWVTY.
        /// </summary>
        public const string VAWVTY = "VAWVTY";

        /// <summary>
        /// VAWVID.
        /// </summary>
        public const string VAWVID = "VAWVID";

        /// <summary>
        /// VAWBID.
        /// </summary>
        public const string VAWBID = "VAWBID";

        /// <summary>
        /// VAWSVT.
        /// </summary>
        public const string VAWSVT = "VAWSVT";

        /// <summary>
        /// VAWVLOCN.
        /// </summary>
        public const string VAWVLOCN = "VAWVLOCN";

        /// <summary>
        /// VAWBLOTN.
        /// </summary>
        public const string VAWBLOTN = "VAWBLOTN";

        /// <summary>
        /// VAWALOTN.
        /// </summary>
        public const string VAWALOTN = "VAWALOTN";

        /// <summary>
        /// VAWPSD.
        /// </summary>
        public const string VAWPSD = "VAWPSD";

        /// <summary>
        /// VAWIAV.
        /// </summary>
        public const string VAWIAV = "VAWIAV";

        /// <summary>
        /// VAWIMV.
        /// </summary>
        public const string VAWIMV = "VAWIMV";

        /// <summary>
        /// VAWVUM.
        /// </summary>
        public const string VAWVUM = "VAWVUM";

        /// <summary>
        /// VATDPT.
        /// </summary>
        public const string VATDPT = "VATDPT";

        /// <summary>
        /// VAWIAD.
        /// </summary>
        public const string VAWIAD = "VAWIAD";

        /// <summary>
        /// VAWDUM.
        /// </summary>
        public const string VAWDUM = "VAWDUM";

        /// <summary>
        /// VAWPAD.
        /// </summary>
        public const string VAWPAD = "VAWPAD";

        /// <summary>
        /// VAWCBQ.
        /// </summary>
        public const string VAWCBQ = "VAWCBQ";

        /// <summary>
        /// VASB4Q.
        /// </summary>
        public const string VASB4Q = "VASB4Q";

        /// <summary>
        /// VASB4BID.
        /// </summary>
        public const string VASB4BID = "VASB4BID";

        /// <summary>
        /// VASB4WS.
        /// </summary>
        public const string VASB4WS = "VASB4WS";

        /// <summary>
        /// VASB4MT.
        /// </summary>
        public const string VASB4MT = "VASB4MT";

        /// <summary>
        /// VAWSGTCHGF.
        /// </summary>
        public const string VAWSGTCHGF = "VAWSGTCHGF";

        /// <summary>
        /// VAVVI.
        /// </summary>
        public const string VAVVI = "VAVVI";

        /// <summary>
        /// VAWRF.
        /// </summary>
        public const string VAWRF = "VAWRF";

        /// <summary>
        /// VAWCD.
        /// </summary>
        public const string VAWCD = "VAWCD";

        /// <summary>
        /// VAWAB.
        /// </summary>
        public const string VAWAB = "VAWAB";

        /// <summary>
        /// VAWNUM.
        /// </summary>
        public const string VAWNUM = "VAWNUM";

        /// <summary>
        /// VAWMDT.
        /// </summary>
        public const string VAWMDT = "VAWMDT";

        /// <summary>
        /// VAURCD.
        /// </summary>
        public const string VAURCD = "VAURCD";

        /// <summary>
        /// VAURDT.
        /// </summary>
        public const string VAURDT = "VAURDT";

        /// <summary>
        /// VAURRF.
        /// </summary>
        public const string VAURRF = "VAURRF";

        /// <summary>
        /// VAURAT.
        /// </summary>
        public const string VAURAT = "VAURAT";

        /// <summary>
        /// VAURAB.
        /// </summary>
        public const string VAURAB = "VAURAB";

        /// <summary>
        /// VAUSER.
        /// </summary>
        public const string VAUSER = "VAUSER";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VATDAY.
        /// </summary>
        public const string VATDAY = "VATDAY";

        /// <summary>
        /// VAWGAGDOC.
        /// </summary>
        public const string VAWGAGDOC = "VAWGAGDOC";

        /// <summary>
        /// VAMCUREC.
        /// </summary>
        public const string VAMCUREC = "VAMCUREC";

        /// <summary>
        /// VASBLUID.
        /// </summary>
        public const string VASBLUID = "VASBLUID";

        /// <summary>
        /// VAWTEMP.
        /// </summary>
        public const string VAWTEMP = "VAWTEMP";

        /// <summary>
        /// VATEMPUOM.
        /// </summary>
        public const string VATEMPUOM = "VATEMPUOM";

        /// <summary>
        /// VAWATF.
        /// </summary>
        public const string VAWATF = "VAWATF";

        /// <summary>
        /// VATRTAREA.
        /// </summary>
        public const string VATRTAREA = "VATRTAREA";

        /// <summary>
        /// VAAREAUOM.
        /// </summary>
        public const string VAAREAUOM = "VAAREAUOM";

        /// <summary>
        /// VAGRECID.
        /// </summary>
        public const string VAGRECID = "VAGRECID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VAWOPID", "VAWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("VAWFTF", "VAWFTF", JdeDataType.String, 2, true, true),
        new JdeField("VAWVSEQ", "VAWVSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("VAWVTY", "VAWVTY", JdeDataType.String, 2),
        new JdeField("VAWVID", "VAWVID", JdeDataType.Numeric),
        new JdeField("VAWBID", "VAWBID", JdeDataType.String, 60),
        new JdeField("VAWSVT", "VAWSVT", JdeDataType.String, 8),
        new JdeField("VAWVLOCN", "VAWVLOCN", JdeDataType.String, 40),
        new JdeField("VAWBLOTN", "VAWBLOTN", JdeDataType.String, 60),
        new JdeField("VAWALOTN", "VAWALOTN", JdeDataType.String, 60),
        new JdeField("VAWPSD", "VAWPSD", JdeDataType.String, 2),
        new JdeField("VAWIAV", "VAWIAV", JdeDataType.Numeric),
        new JdeField("VAWIMV", "VAWIMV", JdeDataType.Numeric),
        new JdeField("VAWVUM", "VAWVUM", JdeDataType.String, 6),
        new JdeField("VATDPT", "VATDPT", JdeDataType.String, 2),
        new JdeField("VAWIAD", "VAWIAD", JdeDataType.Numeric),
        new JdeField("VAWDUM", "VAWDUM", JdeDataType.String, 6),
        new JdeField("VAWPAD", "VAWPAD", JdeDataType.String, 2),
        new JdeField("VAWCBQ", "VAWCBQ", JdeDataType.Numeric),
        new JdeField("VASB4Q", "VASB4Q", JdeDataType.Numeric),
        new JdeField("VASB4BID", "VASB4BID", JdeDataType.String, 60),
        new JdeField("VASB4WS", "VASB4WS", JdeDataType.String, 12),
        new JdeField("VASB4MT", "VASB4MT", JdeDataType.String, 8),
        new JdeField("VAWSGTCHGF", "VAWSGTCHGF", JdeDataType.String, 2),
        new JdeField("VAVVI", "VAVVI", JdeDataType.String, 2),
        new JdeField("VAWRF", "VAWRF", JdeDataType.String, 60),
        new JdeField("VAWCD", "VAWCD", JdeDataType.String, 6),
        new JdeField("VAWAB", "VAWAB", JdeDataType.Numeric),
        new JdeField("VAWNUM", "VAWNUM", JdeDataType.Numeric),
        new JdeField("VAWMDT", "VAWMDT", JdeDataType.Numeric),
        new JdeField("VAURCD", "VAURCD", JdeDataType.String, 4),
        new JdeField("VAURDT", "VAURDT", JdeDataType.Numeric),
        new JdeField("VAURRF", "VAURRF", JdeDataType.String, 30),
        new JdeField("VAURAT", "VAURAT", JdeDataType.Numeric),
        new JdeField("VAURAB", "VAURAB", JdeDataType.Numeric),
        new JdeField("VAUSER", "VAUSER", JdeDataType.String, 20),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VATDAY", "VATDAY", JdeDataType.Numeric),
        new JdeField("VAWGAGDOC", "VAWGAGDOC", JdeDataType.String, 60),
        new JdeField("VAMCUREC", "VAMCUREC", JdeDataType.String, 24),
        new JdeField("VASBLUID", "VASBLUID", JdeDataType.Numeric),
        new JdeField("VAWTEMP", "VAWTEMP", JdeDataType.Numeric),
        new JdeField("VATEMPUOM", "VATEMPUOM", JdeDataType.String, 4),
        new JdeField("VAWATF", "VAWATF", JdeDataType.String, 2),
        new JdeField("VATRTAREA", "VATRTAREA", JdeDataType.Numeric),
        new JdeField("VAAREAUOM", "VAAREAUOM", JdeDataType.String, 4),
        new JdeField("VAGRECID", "VAGRECID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B70_0", "Primary Key on VAWOPID, VAWFTF, VAWVSEQ", new[] { "VAWOPID", "VAWFTF", "VAWVSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B70_2", "Index on VAWOPID, VAWFTF, VAWVID", new[] { "VAWOPID", "VAWFTF", "VAWVID" }),
        new JdeIndex("F31B70_3", "Index on VAWVID, VAWOPID", new[] { "VAWVID", "VAWOPID" }),
        new JdeIndex("F31B70_4", "Index on VAWVID, VAWALOTN", new[] { "VAWVID", "VAWALOTN" })
    };
}
