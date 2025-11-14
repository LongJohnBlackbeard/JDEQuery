using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800609 - .
/// </summary>
public class F0800609 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YIAN8.
        /// </summary>
        public const string YIAN8 = "YIAN8";

        /// <summary>
        /// YIJCC.
        /// </summary>
        public const string YIJCC = "YIJCC";

        /// <summary>
        /// YIEFT.
        /// </summary>
        public const string YIEFT = "YIEFT";

        /// <summary>
        /// YIJCDS.
        /// </summary>
        public const string YIJCDS = "YIJCDS";

        /// <summary>
        /// YICOPTN.
        /// </summary>
        public const string YICOPTN = "YICOPTN";

        /// <summary>
        /// YIRULEN.
        /// </summary>
        public const string YIRULEN = "YIRULEN";

        /// <summary>
        /// YIOTPS.
        /// </summary>
        public const string YIOTPS = "YIOTPS";

        /// <summary>
        /// YIJBCD.
        /// </summary>
        public const string YIJBCD = "YIJBCD";

        /// <summary>
        /// YIJBST.
        /// </summary>
        public const string YIJBST = "YIJBST";

        /// <summary>
        /// YIGAPR.
        /// </summary>
        public const string YIGAPR = "YIGAPR";

        /// <summary>
        /// YIGAPS.
        /// </summary>
        public const string YIGAPS = "YIGAPS";

        /// <summary>
        /// YITINC.
        /// </summary>
        public const string YITINC = "YITINC";

        /// <summary>
        /// YISUMLVL.
        /// </summary>
        public const string YISUMLVL = "YISUMLVL";

        /// <summary>
        /// YICMPE.
        /// </summary>
        public const string YICMPE = "YICMPE";

        /// <summary>
        /// YICTDS.
        /// </summary>
        public const string YICTDS = "YICTDS";

        /// <summary>
        /// YICMPC.
        /// </summary>
        public const string YICMPC = "YICMPC";

        /// <summary>
        /// YICCDS.
        /// </summary>
        public const string YICCDS = "YICCDS";

        /// <summary>
        /// YIREQL.
        /// </summary>
        public const string YIREQL = "YIREQL";

        /// <summary>
        /// YIRQDS.
        /// </summary>
        public const string YIRQDS = "YIRQDS";

        /// <summary>
        /// YILVWT.
        /// </summary>
        public const string YILVWT = "YILVWT";

        /// <summary>
        /// YICMPV.
        /// </summary>
        public const string YICMPV = "YICMPV";

        /// <summary>
        /// YICCMPDS.
        /// </summary>
        public const string YICCMPDS = "YICCMPDS";

        /// <summary>
        /// YISAPL.
        /// </summary>
        public const string YISAPL = "YISAPL";

        /// <summary>
        /// YISAPLDS.
        /// </summary>
        public const string YISAPLDS = "YISAPLDS";

        /// <summary>
        /// YINCMPV.
        /// </summary>
        public const string YINCMPV = "YINCMPV";

        /// <summary>
        /// YINCMPDS.
        /// </summary>
        public const string YINCMPDS = "YINCMPDS";

        /// <summary>
        /// YIPAPL.
        /// </summary>
        public const string YIPAPL = "YIPAPL";

        /// <summary>
        /// YIPAPLDS.
        /// </summary>
        public const string YIPAPLDS = "YIPAPLDS";

        /// <summary>
        /// YILOWC.
        /// </summary>
        public const string YILOWC = "YILOWC";

        /// <summary>
        /// YILODS.
        /// </summary>
        public const string YILODS = "YILODS";

        /// <summary>
        /// YIHIGHC.
        /// </summary>
        public const string YIHIGHC = "YIHIGHC";

        /// <summary>
        /// YIHIDS.
        /// </summary>
        public const string YIHIDS = "YIHIDS";

        /// <summary>
        /// YIJCPCTRQD.
        /// </summary>
        public const string YIJCPCTRQD = "YIJCPCTRQD";

        /// <summary>
        /// YIUSER.
        /// </summary>
        public const string YIUSER = "YIUSER";

        /// <summary>
        /// YIPID.
        /// </summary>
        public const string YIPID = "YIPID";

        /// <summary>
        /// YIJOBN.
        /// </summary>
        public const string YIJOBN = "YIJOBN";

        /// <summary>
        /// YIUPMJ.
        /// </summary>
        public const string YIUPMJ = "YIUPMJ";

        /// <summary>
        /// YIUPMT.
        /// </summary>
        public const string YIUPMT = "YIUPMT";

        /// <summary>
        /// YIACCOMP.
        /// </summary>
        public const string YIACCOMP = "YIACCOMP";
    }

    /// <inheritdoc />
    public override string TableName => "F0800609";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YIAN8", "YIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YIJCC", "YIJCC", JdeDataType.String, 20, true, true),
        new JdeField("YIEFT", "YIEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("YIJCDS", "YIJCDS", JdeDataType.String, 60),
        new JdeField("YICOPTN", "YICOPTN", JdeDataType.String, 6),
        new JdeField("YIRULEN", "YIRULEN", JdeDataType.Numeric, null, true, true),
        new JdeField("YIOTPS", "YIOTPS", JdeDataType.String, 6, true, true),
        new JdeField("YIJBCD", "YIJBCD", JdeDataType.String, 12),
        new JdeField("YIJBST", "YIJBST", JdeDataType.String, 8),
        new JdeField("YIGAPR", "YIGAPR", JdeDataType.String, 6, true, true),
        new JdeField("YIGAPS", "YIGAPS", JdeDataType.String, 6),
        new JdeField("YITINC", "YITINC", JdeDataType.String, 2, true, true),
        new JdeField("YISUMLVL", "YISUMLVL", JdeDataType.Numeric),
        new JdeField("YICMPE", "YICMPE", JdeDataType.String, 6),
        new JdeField("YICTDS", "YICTDS", JdeDataType.String, 60),
        new JdeField("YICMPC", "YICMPC", JdeDataType.String, 20),
        new JdeField("YICCDS", "YICCDS", JdeDataType.String, 60),
        new JdeField("YIREQL", "YIREQL", JdeDataType.Numeric),
        new JdeField("YIRQDS", "YIRQDS", JdeDataType.String, 60),
        new JdeField("YILVWT", "YILVWT", JdeDataType.Numeric),
        new JdeField("YICMPV", "YICMPV", JdeDataType.Numeric),
        new JdeField("YICCMPDS", "YICCMPDS", JdeDataType.String, 60),
        new JdeField("YISAPL", "YISAPL", JdeDataType.Numeric),
        new JdeField("YISAPLDS", "YISAPLDS", JdeDataType.String, 60),
        new JdeField("YINCMPV", "YINCMPV", JdeDataType.Numeric),
        new JdeField("YINCMPDS", "YINCMPDS", JdeDataType.String, 60),
        new JdeField("YIPAPL", "YIPAPL", JdeDataType.Numeric),
        new JdeField("YIPAPLDS", "YIPAPLDS", JdeDataType.String, 60),
        new JdeField("YILOWC", "YILOWC", JdeDataType.Numeric),
        new JdeField("YILODS", "YILODS", JdeDataType.String, 60),
        new JdeField("YIHIGHC", "YIHIGHC", JdeDataType.Numeric),
        new JdeField("YIHIDS", "YIHIDS", JdeDataType.String, 60),
        new JdeField("YIJCPCTRQD", "YIJCPCTRQD", JdeDataType.Numeric),
        new JdeField("YIUSER", "YIUSER", JdeDataType.String, 20),
        new JdeField("YIPID", "YIPID", JdeDataType.String, 20),
        new JdeField("YIJOBN", "YIJOBN", JdeDataType.String, 20),
        new JdeField("YIUPMJ", "YIUPMJ", JdeDataType.Numeric),
        new JdeField("YIUPMT", "YIUPMT", JdeDataType.Numeric),
        new JdeField("YIACCOMP", "YIACCOMP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800609_0", "Primary Key on YIAN8, YIJCC, YIEFT, YIRULEN, YIOTPS, YIGAPR, YITINC", new[] { "YIAN8", "YIJCC", "YIEFT", "YIRULEN", "YIOTPS", "YIGAPR", "YITINC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800609_2", "Index on YIAN8, SYS_NC00040$, YIOTPS, YITINC, YIJCC, YICOPTN, YICMPE, YICMPC", new[] { "YIAN8", "SYS_NC00040$", "YIOTPS", "YITINC", "YIJCC", "YICOPTN", "YICMPE", "YICMPC" }),
        new JdeIndex("F0800609_3", "Index on YIAN8, SYS_NC00040$, YIOTPS, YITINC, YISUMLVL", new[] { "YIAN8", "SYS_NC00040$", "YIOTPS", "YITINC", "YISUMLVL" }),
        new JdeIndex("F0800609_4", "Index on YIAN8, YICMPE, YICMPC", new[] { "YIAN8", "YICMPE", "YICMPC" })
    };
}
