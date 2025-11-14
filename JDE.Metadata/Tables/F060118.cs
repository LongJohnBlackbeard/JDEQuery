using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060118 - .
/// </summary>
public class F060118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YEAN8.
        /// </summary>
        public const string YEAN8 = "YEAN8";

        /// <summary>
        /// YEHMCU.
        /// </summary>
        public const string YEHMCU = "YEHMCU";

        /// <summary>
        /// YEJBCD.
        /// </summary>
        public const string YEJBCD = "YEJBCD";

        /// <summary>
        /// YEJBST.
        /// </summary>
        public const string YEJBST = "YEJBST";

        /// <summary>
        /// YEPOS.
        /// </summary>
        public const string YEPOS = "YEPOS";

        /// <summary>
        /// YEEJPF.
        /// </summary>
        public const string YEEJPF = "YEEJPF";

        /// <summary>
        /// YEPSDT.
        /// </summary>
        public const string YEPSDT = "YEPSDT";

        /// <summary>
        /// YEPTDT.
        /// </summary>
        public const string YEPTDT = "YEPTDT";

        /// <summary>
        /// YEUN.
        /// </summary>
        public const string YEUN = "YEUN";

        /// <summary>
        /// YESAL.
        /// </summary>
        public const string YESAL = "YESAL";

        /// <summary>
        /// YEPHRT.
        /// </summary>
        public const string YEPHRT = "YEPHRT";

        /// <summary>
        /// YEATPY.
        /// </summary>
        public const string YEATPY = "YEATPY";

        /// <summary>
        /// YESLOC.
        /// </summary>
        public const string YESLOC = "YESLOC";

        /// <summary>
        /// YESHFT.
        /// </summary>
        public const string YESHFT = "YESHFT";

        /// <summary>
        /// YEWCMP.
        /// </summary>
        public const string YEWCMP = "YEWCMP";

        /// <summary>
        /// YEWET.
        /// </summary>
        public const string YEWET = "YEWET";

        /// <summary>
        /// YEPGRD.
        /// </summary>
        public const string YEPGRD = "YEPGRD";

        /// <summary>
        /// YEPGRS.
        /// </summary>
        public const string YEPGRS = "YEPGRS";

        /// <summary>
        /// YEFLSA.
        /// </summary>
        public const string YEFLSA = "YEFLSA";

        /// <summary>
        /// YEEEOJ.
        /// </summary>
        public const string YEEEOJ = "YEEEOJ";

        /// <summary>
        /// YEANPA.
        /// </summary>
        public const string YEANPA = "YEANPA";

        /// <summary>
        /// YEEST.
        /// </summary>
        public const string YEEST = "YEEST";

        /// <summary>
        /// YECMPA.
        /// </summary>
        public const string YECMPA = "YECMPA";

        /// <summary>
        /// YESALY.
        /// </summary>
        public const string YESALY = "YESALY";

        /// <summary>
        /// YENRVW.
        /// </summary>
        public const string YENRVW = "YENRVW";

        /// <summary>
        /// YETINC.
        /// </summary>
        public const string YETINC = "YETINC";

        /// <summary>
        /// YEP001.
        /// </summary>
        public const string YEP001 = "YEP001";

        /// <summary>
        /// YEP002.
        /// </summary>
        public const string YEP002 = "YEP002";

        /// <summary>
        /// YEP003.
        /// </summary>
        public const string YEP003 = "YEP003";

        /// <summary>
        /// YEP004.
        /// </summary>
        public const string YEP004 = "YEP004";

        /// <summary>
        /// YEP005.
        /// </summary>
        public const string YEP005 = "YEP005";

        /// <summary>
        /// YEP006.
        /// </summary>
        public const string YEP006 = "YEP006";

        /// <summary>
        /// YEP007.
        /// </summary>
        public const string YEP007 = "YEP007";

        /// <summary>
        /// YEP008.
        /// </summary>
        public const string YEP008 = "YEP008";

        /// <summary>
        /// YEP009.
        /// </summary>
        public const string YEP009 = "YEP009";

        /// <summary>
        /// YEP010.
        /// </summary>
        public const string YEP010 = "YEP010";

        /// <summary>
        /// YEED01.
        /// </summary>
        public const string YEED01 = "YEED01";

        /// <summary>
        /// YEED02.
        /// </summary>
        public const string YEED02 = "YEED02";

        /// <summary>
        /// YEED03.
        /// </summary>
        public const string YEED03 = "YEED03";

        /// <summary>
        /// YEED04.
        /// </summary>
        public const string YEED04 = "YEED04";

        /// <summary>
        /// YEED05.
        /// </summary>
        public const string YEED05 = "YEED05";

        /// <summary>
        /// YEED06.
        /// </summary>
        public const string YEED06 = "YEED06";

        /// <summary>
        /// YEED07.
        /// </summary>
        public const string YEED07 = "YEED07";

        /// <summary>
        /// YEED08.
        /// </summary>
        public const string YEED08 = "YEED08";

        /// <summary>
        /// YEED09.
        /// </summary>
        public const string YEED09 = "YEED09";

        /// <summary>
        /// YEED10.
        /// </summary>
        public const string YEED10 = "YEED10";

        /// <summary>
        /// YEFTE.
        /// </summary>
        public const string YEFTE = "YEFTE";

        /// <summary>
        /// YESMOY.
        /// </summary>
        public const string YESMOY = "YESMOY";

        /// <summary>
        /// YEIH.
        /// </summary>
        public const string YEIH = "YEIH";

        /// <summary>
        /// YESTDD.
        /// </summary>
        public const string YESTDD = "YESTDD";

        /// <summary>
        /// YESDYY.
        /// </summary>
        public const string YESDYY = "YESDYY";

        /// <summary>
        /// YESTDH.
        /// </summary>
        public const string YESTDH = "YESTDH";

        /// <summary>
        /// YEDTSF.
        /// </summary>
        public const string YEDTSF = "YEDTSF";

        /// <summary>
        /// YETRS.
        /// </summary>
        public const string YETRS = "YETRS";

        /// <summary>
        /// YEUSER.
        /// </summary>
        public const string YEUSER = "YEUSER";

        /// <summary>
        /// YEPID.
        /// </summary>
        public const string YEPID = "YEPID";

        /// <summary>
        /// YEJOBN.
        /// </summary>
        public const string YEJOBN = "YEJOBN";

        /// <summary>
        /// YEUPMJ.
        /// </summary>
        public const string YEUPMJ = "YEUPMJ";

        /// <summary>
        /// YEEFTO.
        /// </summary>
        public const string YEEFTO = "YEEFTO";
    }

    /// <inheritdoc />
    public override string TableName => "F060118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YEAN8", "YEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YEHMCU", "YEHMCU", JdeDataType.String, 24, true, true),
        new JdeField("YEJBCD", "YEJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YEJBST", "YEJBST", JdeDataType.String, 8, true, true),
        new JdeField("YEPOS", "YEPOS", JdeDataType.String, 16),
        new JdeField("YEEJPF", "YEEJPF", JdeDataType.String, 2),
        new JdeField("YEPSDT", "YEPSDT", JdeDataType.Numeric),
        new JdeField("YEPTDT", "YEPTDT", JdeDataType.Numeric, null, true, true),
        new JdeField("YEUN", "YEUN", JdeDataType.String, 12),
        new JdeField("YESAL", "YESAL", JdeDataType.Numeric),
        new JdeField("YEPHRT", "YEPHRT", JdeDataType.Numeric),
        new JdeField("YEATPY", "YEATPY", JdeDataType.Numeric),
        new JdeField("YESLOC", "YESLOC", JdeDataType.String, 16),
        new JdeField("YESHFT", "YESHFT", JdeDataType.String, 2),
        new JdeField("YEWCMP", "YEWCMP", JdeDataType.String, 8),
        new JdeField("YEWET", "YEWET", JdeDataType.String, 2),
        new JdeField("YEPGRD", "YEPGRD", JdeDataType.String, 12),
        new JdeField("YEPGRS", "YEPGRS", JdeDataType.String, 8),
        new JdeField("YEFLSA", "YEFLSA", JdeDataType.String, 2),
        new JdeField("YEEEOJ", "YEEEOJ", JdeDataType.String, 6),
        new JdeField("YEANPA", "YEANPA", JdeDataType.Numeric),
        new JdeField("YEEST", "YEEST", JdeDataType.String, 2),
        new JdeField("YECMPA", "YECMPA", JdeDataType.Numeric),
        new JdeField("YESALY", "YESALY", JdeDataType.String, 2),
        new JdeField("YENRVW", "YENRVW", JdeDataType.Numeric),
        new JdeField("YETINC", "YETINC", JdeDataType.String, 2),
        new JdeField("YEP001", "YEP001", JdeDataType.String, 6),
        new JdeField("YEP002", "YEP002", JdeDataType.String, 6),
        new JdeField("YEP003", "YEP003", JdeDataType.String, 6),
        new JdeField("YEP004", "YEP004", JdeDataType.String, 6),
        new JdeField("YEP005", "YEP005", JdeDataType.String, 6),
        new JdeField("YEP006", "YEP006", JdeDataType.String, 6),
        new JdeField("YEP007", "YEP007", JdeDataType.String, 6),
        new JdeField("YEP008", "YEP008", JdeDataType.String, 6),
        new JdeField("YEP009", "YEP009", JdeDataType.String, 6),
        new JdeField("YEP010", "YEP010", JdeDataType.String, 6),
        new JdeField("YEED01", "YEED01", JdeDataType.Numeric),
        new JdeField("YEED02", "YEED02", JdeDataType.Numeric),
        new JdeField("YEED03", "YEED03", JdeDataType.Numeric),
        new JdeField("YEED04", "YEED04", JdeDataType.Numeric),
        new JdeField("YEED05", "YEED05", JdeDataType.Numeric),
        new JdeField("YEED06", "YEED06", JdeDataType.Numeric),
        new JdeField("YEED07", "YEED07", JdeDataType.Numeric),
        new JdeField("YEED08", "YEED08", JdeDataType.Numeric),
        new JdeField("YEED09", "YEED09", JdeDataType.Numeric),
        new JdeField("YEED10", "YEED10", JdeDataType.Numeric),
        new JdeField("YEFTE", "YEFTE", JdeDataType.Numeric),
        new JdeField("YESMOY", "YESMOY", JdeDataType.Numeric),
        new JdeField("YEIH", "YEIH", JdeDataType.Numeric),
        new JdeField("YESTDD", "YESTDD", JdeDataType.Numeric),
        new JdeField("YESDYY", "YESDYY", JdeDataType.Numeric),
        new JdeField("YESTDH", "YESTDH", JdeDataType.Numeric),
        new JdeField("YEDTSF", "YEDTSF", JdeDataType.Numeric),
        new JdeField("YETRS", "YETRS", JdeDataType.String, 6),
        new JdeField("YEUSER", "YEUSER", JdeDataType.String, 20),
        new JdeField("YEPID", "YEPID", JdeDataType.String, 20),
        new JdeField("YEJOBN", "YEJOBN", JdeDataType.String, 20),
        new JdeField("YEUPMJ", "YEUPMJ", JdeDataType.Numeric),
        new JdeField("YEEFTO", "YEEFTO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060118_0", "Primary Key on YEAN8, YEHMCU, YEJBCD, YEJBST, YEPTDT", new[] { "YEAN8", "YEHMCU", "YEJBCD", "YEJBST", "YEPTDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F060118_2", "Index on YEAN8, SYS_NC00060$", new[] { "YEAN8", "SYS_NC00060$" }),
        new JdeIndex("F060118_3", "Index on YEAN8, YEJBCD, YEJBST", new[] { "YEAN8", "YEJBCD", "YEJBST" }),
        new JdeIndex("F060118_4", "Index on YEAN8, YEHMCU, YEPOS", new[] { "YEAN8", "YEHMCU", "YEPOS" })
    };
}
