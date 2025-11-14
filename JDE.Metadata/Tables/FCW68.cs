using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW68 - .
/// </summary>
public class FCW68 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLJOBS.
        /// </summary>
        public const string WLJOBS = "WLJOBS";

        /// <summary>
        /// WLC9LANC.
        /// </summary>
        public const string WLC9LANC = "WLC9LANC";

        /// <summary>
        /// WLDCTO.
        /// </summary>
        public const string WLDCTO = "WLDCTO";

        /// <summary>
        /// WLSFXO.
        /// </summary>
        public const string WLSFXO = "WLSFXO";

        /// <summary>
        /// WLTRT.
        /// </summary>
        public const string WLTRT = "WLTRT";

        /// <summary>
        /// WLKIT.
        /// </summary>
        public const string WLKIT = "WLKIT";

        /// <summary>
        /// WLKITL.
        /// </summary>
        public const string WLKITL = "WLKITL";

        /// <summary>
        /// WLKITA.
        /// </summary>
        public const string WLKITA = "WLKITA";

        /// <summary>
        /// WLMMCU.
        /// </summary>
        public const string WLMMCU = "WLMMCU";

        /// <summary>
        /// WLLINE.
        /// </summary>
        public const string WLLINE = "WLLINE";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLALD.
        /// </summary>
        public const string WLALD = "WLALD";

        /// <summary>
        /// WLDSC1.
        /// </summary>
        public const string WLDSC1 = "WLDSC1";

        /// <summary>
        /// WLOPSQ.
        /// </summary>
        public const string WLOPSQ = "WLOPSQ";

        /// <summary>
        /// WLOPSC.
        /// </summary>
        public const string WLOPSC = "WLOPSC";

        /// <summary>
        /// WLOPST.
        /// </summary>
        public const string WLOPST = "WLOPST";

        /// <summary>
        /// WLINPE.
        /// </summary>
        public const string WLINPE = "WLINPE";

        /// <summary>
        /// WLTIMB.
        /// </summary>
        public const string WLTIMB = "WLTIMB";

        /// <summary>
        /// WLLAMC.
        /// </summary>
        public const string WLLAMC = "WLLAMC";

        /// <summary>
        /// WLBFPF.
        /// </summary>
        public const string WLBFPF = "WLBFPF";

        /// <summary>
        /// WLPPRF.
        /// </summary>
        public const string WLPPRF = "WLPPRF";

        /// <summary>
        /// WLJBCD.
        /// </summary>
        public const string WLJBCD = "WLJBCD";

        /// <summary>
        /// WLAN8.
        /// </summary>
        public const string WLAN8 = "WLAN8";

        /// <summary>
        /// WLCRTR.
        /// </summary>
        public const string WLCRTR = "WLCRTR";

        /// <summary>
        /// WLSLTR.
        /// </summary>
        public const string WLSLTR = "WLSLTR";

        /// <summary>
        /// WLTRDJ.
        /// </summary>
        public const string WLTRDJ = "WLTRDJ";

        /// <summary>
        /// WLDRQJ.
        /// </summary>
        public const string WLDRQJ = "WLDRQJ";

        /// <summary>
        /// WLSTRT.
        /// </summary>
        public const string WLSTRT = "WLSTRT";

        /// <summary>
        /// WLSTRX.
        /// </summary>
        public const string WLSTRX = "WLSTRX";

        /// <summary>
        /// WLPBTM.
        /// </summary>
        public const string WLPBTM = "WLPBTM";

        /// <summary>
        /// WLPETM.
        /// </summary>
        public const string WLPETM = "WLPETM";

        /// <summary>
        /// WLRSFT.
        /// </summary>
        public const string WLRSFT = "WLRSFT";

        /// <summary>
        /// WLSSFT.
        /// </summary>
        public const string WLSSFT = "WLSSFT";

        /// <summary>
        /// WLCSFT.
        /// </summary>
        public const string WLCSFT = "WLCSFT";

        /// <summary>
        /// WLLTPC.
        /// </summary>
        public const string WLLTPC = "WLLTPC";

        /// <summary>
        /// WLPOVR.
        /// </summary>
        public const string WLPOVR = "WLPOVR";

        /// <summary>
        /// WLOPYP.
        /// </summary>
        public const string WLOPYP = "WLOPYP";

        /// <summary>
        /// WLCPYP.
        /// </summary>
        public const string WLCPYP = "WLCPYP";

        /// <summary>
        /// WLNXOP.
        /// </summary>
        public const string WLNXOP = "WLNXOP";

        /// <summary>
        /// WLSETC.
        /// </summary>
        public const string WLSETC = "WLSETC";

        /// <summary>
        /// WLMOVD.
        /// </summary>
        public const string WLMOVD = "WLMOVD";

        /// <summary>
        /// WLQUED.
        /// </summary>
        public const string WLQUED = "WLQUED";

        /// <summary>
        /// WLRUNM.
        /// </summary>
        public const string WLRUNM = "WLRUNM";

        /// <summary>
        /// WLRUNL.
        /// </summary>
        public const string WLRUNL = "WLRUNL";

        /// <summary>
        /// WLSETL.
        /// </summary>
        public const string WLSETL = "WLSETL";

        /// <summary>
        /// WLMACA.
        /// </summary>
        public const string WLMACA = "WLMACA";

        /// <summary>
        /// WLLABA.
        /// </summary>
        public const string WLLABA = "WLLABA";

        /// <summary>
        /// WLSETA.
        /// </summary>
        public const string WLSETA = "WLSETA";

        /// <summary>
        /// WLOPSR.
        /// </summary>
        public const string WLOPSR = "WLOPSR";

        /// <summary>
        /// WLUORG.
        /// </summary>
        public const string WLUORG = "WLUORG";

        /// <summary>
        /// WLSOCN.
        /// </summary>
        public const string WLSOCN = "WLSOCN";

        /// <summary>
        /// WLSOQS.
        /// </summary>
        public const string WLSOQS = "WLSOQS";

        /// <summary>
        /// WLQMTO.
        /// </summary>
        public const string WLQMTO = "WLQMTO";

        /// <summary>
        /// WLPWRT.
        /// </summary>
        public const string WLPWRT = "WLPWRT";

        /// <summary>
        /// WLUOM.
        /// </summary>
        public const string WLUOM = "WLUOM";

        /// <summary>
        /// WLCTS1.
        /// </summary>
        public const string WLCTS1 = "WLCTS1";

        /// <summary>
        /// WLCTS2.
        /// </summary>
        public const string WLCTS2 = "WLCTS2";

        /// <summary>
        /// WLCTS3.
        /// </summary>
        public const string WLCTS3 = "WLCTS3";

        /// <summary>
        /// WLCTS4.
        /// </summary>
        public const string WLCTS4 = "WLCTS4";

        /// <summary>
        /// WLCTS5.
        /// </summary>
        public const string WLCTS5 = "WLCTS5";

        /// <summary>
        /// WLCTS6.
        /// </summary>
        public const string WLCTS6 = "WLCTS6";

        /// <summary>
        /// WLAPID.
        /// </summary>
        public const string WLAPID = "WLAPID";

        /// <summary>
        /// WLSHNO.
        /// </summary>
        public const string WLSHNO = "WLSHNO";

        /// <summary>
        /// WLOMCU.
        /// </summary>
        public const string WLOMCU = "WLOMCU";

        /// <summary>
        /// WLOBJ.
        /// </summary>
        public const string WLOBJ = "WLOBJ";

        /// <summary>
        /// WLSUB.
        /// </summary>
        public const string WLSUB = "WLSUB";

        /// <summary>
        /// WLVEND.
        /// </summary>
        public const string WLVEND = "WLVEND";

        /// <summary>
        /// WLRKCO.
        /// </summary>
        public const string WLRKCO = "WLRKCO";

        /// <summary>
        /// WLRORN.
        /// </summary>
        public const string WLRORN = "WLRORN";

        /// <summary>
        /// WLRCTO.
        /// </summary>
        public const string WLRCTO = "WLRCTO";

        /// <summary>
        /// WLRLLN.
        /// </summary>
        public const string WLRLLN = "WLRLLN";

        /// <summary>
        /// WLDCT.
        /// </summary>
        public const string WLDCT = "WLDCT";

        /// <summary>
        /// WLURCD.
        /// </summary>
        public const string WLURCD = "WLURCD";

        /// <summary>
        /// WLURDT.
        /// </summary>
        public const string WLURDT = "WLURDT";

        /// <summary>
        /// WLURAT.
        /// </summary>
        public const string WLURAT = "WLURAT";

        /// <summary>
        /// WLURRF.
        /// </summary>
        public const string WLURRF = "WLURRF";

        /// <summary>
        /// WLURAB.
        /// </summary>
        public const string WLURAB = "WLURAB";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLTDAY.
        /// </summary>
        public const string WLTDAY = "WLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW68";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLJOBS", "WLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WLC9LANC", "WLC9LANC", JdeDataType.Numeric),
        new JdeField("WLDCTO", "WLDCTO", JdeDataType.String, 4),
        new JdeField("WLSFXO", "WLSFXO", JdeDataType.String, 6),
        new JdeField("WLTRT", "WLTRT", JdeDataType.String, 6),
        new JdeField("WLKIT", "WLKIT", JdeDataType.Numeric),
        new JdeField("WLKITL", "WLKITL", JdeDataType.String, 50),
        new JdeField("WLKITA", "WLKITA", JdeDataType.String, 50),
        new JdeField("WLMMCU", "WLMMCU", JdeDataType.String, 24),
        new JdeField("WLLINE", "WLLINE", JdeDataType.String, 24),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLALD", "WLALD", JdeDataType.String, 8),
        new JdeField("WLDSC1", "WLDSC1", JdeDataType.String, 60),
        new JdeField("WLOPSQ", "WLOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WLOPSC", "WLOPSC", JdeDataType.String, 4, true, true),
        new JdeField("WLOPST", "WLOPST", JdeDataType.String, 4),
        new JdeField("WLINPE", "WLINPE", JdeDataType.String, 4),
        new JdeField("WLTIMB", "WLTIMB", JdeDataType.String, 2),
        new JdeField("WLLAMC", "WLLAMC", JdeDataType.String, 2),
        new JdeField("WLBFPF", "WLBFPF", JdeDataType.String, 2),
        new JdeField("WLPPRF", "WLPPRF", JdeDataType.String, 2),
        new JdeField("WLJBCD", "WLJBCD", JdeDataType.String, 12),
        new JdeField("WLAN8", "WLAN8", JdeDataType.Numeric),
        new JdeField("WLCRTR", "WLCRTR", JdeDataType.Numeric),
        new JdeField("WLSLTR", "WLSLTR", JdeDataType.Numeric),
        new JdeField("WLTRDJ", "WLTRDJ", JdeDataType.Numeric),
        new JdeField("WLDRQJ", "WLDRQJ", JdeDataType.Numeric),
        new JdeField("WLSTRT", "WLSTRT", JdeDataType.Numeric),
        new JdeField("WLSTRX", "WLSTRX", JdeDataType.Numeric),
        new JdeField("WLPBTM", "WLPBTM", JdeDataType.Numeric),
        new JdeField("WLPETM", "WLPETM", JdeDataType.Numeric),
        new JdeField("WLRSFT", "WLRSFT", JdeDataType.String, 2),
        new JdeField("WLSSFT", "WLSSFT", JdeDataType.String, 2),
        new JdeField("WLCSFT", "WLCSFT", JdeDataType.String, 2),
        new JdeField("WLLTPC", "WLLTPC", JdeDataType.Numeric),
        new JdeField("WLPOVR", "WLPOVR", JdeDataType.Numeric),
        new JdeField("WLOPYP", "WLOPYP", JdeDataType.Numeric),
        new JdeField("WLCPYP", "WLCPYP", JdeDataType.Numeric),
        new JdeField("WLNXOP", "WLNXOP", JdeDataType.Numeric),
        new JdeField("WLSETC", "WLSETC", JdeDataType.Numeric),
        new JdeField("WLMOVD", "WLMOVD", JdeDataType.Numeric),
        new JdeField("WLQUED", "WLQUED", JdeDataType.Numeric),
        new JdeField("WLRUNM", "WLRUNM", JdeDataType.Numeric),
        new JdeField("WLRUNL", "WLRUNL", JdeDataType.Numeric),
        new JdeField("WLSETL", "WLSETL", JdeDataType.Numeric),
        new JdeField("WLMACA", "WLMACA", JdeDataType.Numeric),
        new JdeField("WLLABA", "WLLABA", JdeDataType.Numeric),
        new JdeField("WLSETA", "WLSETA", JdeDataType.Numeric),
        new JdeField("WLOPSR", "WLOPSR", JdeDataType.Numeric),
        new JdeField("WLUORG", "WLUORG", JdeDataType.Numeric),
        new JdeField("WLSOCN", "WLSOCN", JdeDataType.Numeric),
        new JdeField("WLSOQS", "WLSOQS", JdeDataType.Numeric),
        new JdeField("WLQMTO", "WLQMTO", JdeDataType.Numeric),
        new JdeField("WLPWRT", "WLPWRT", JdeDataType.Numeric),
        new JdeField("WLUOM", "WLUOM", JdeDataType.String, 4),
        new JdeField("WLCTS1", "WLCTS1", JdeDataType.Numeric),
        new JdeField("WLCTS2", "WLCTS2", JdeDataType.Numeric),
        new JdeField("WLCTS3", "WLCTS3", JdeDataType.Numeric),
        new JdeField("WLCTS4", "WLCTS4", JdeDataType.Numeric),
        new JdeField("WLCTS5", "WLCTS5", JdeDataType.Numeric),
        new JdeField("WLCTS6", "WLCTS6", JdeDataType.Numeric),
        new JdeField("WLAPID", "WLAPID", JdeDataType.String, 24),
        new JdeField("WLSHNO", "WLSHNO", JdeDataType.String, 20),
        new JdeField("WLOMCU", "WLOMCU", JdeDataType.String, 24),
        new JdeField("WLOBJ", "WLOBJ", JdeDataType.String, 12),
        new JdeField("WLSUB", "WLSUB", JdeDataType.String, 16),
        new JdeField("WLVEND", "WLVEND", JdeDataType.Numeric),
        new JdeField("WLRKCO", "WLRKCO", JdeDataType.String, 10),
        new JdeField("WLRORN", "WLRORN", JdeDataType.String, 16),
        new JdeField("WLRCTO", "WLRCTO", JdeDataType.String, 4),
        new JdeField("WLRLLN", "WLRLLN", JdeDataType.Numeric),
        new JdeField("WLDCT", "WLDCT", JdeDataType.String, 4),
        new JdeField("WLURCD", "WLURCD", JdeDataType.String, 4),
        new JdeField("WLURDT", "WLURDT", JdeDataType.Numeric),
        new JdeField("WLURAT", "WLURAT", JdeDataType.Numeric),
        new JdeField("WLURRF", "WLURRF", JdeDataType.String, 30),
        new JdeField("WLURAB", "WLURAB", JdeDataType.Numeric),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLTDAY", "WLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW68_0", "Primary Key on WLJOBS, WLOPSQ, WLOPSC, WLMCU", new[] { "WLJOBS", "WLOPSQ", "WLOPSC", "WLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
