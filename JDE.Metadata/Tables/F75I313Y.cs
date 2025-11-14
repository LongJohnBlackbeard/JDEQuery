using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I313Y - .
/// </summary>
public class F75I313Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1YEXU.
        /// </summary>
        public const string Q1YEXU = "Q1YEXU";

        /// <summary>
        /// Q1YNXE.
        /// </summary>
        public const string Q1YNXE = "Q1YNXE";

        /// <summary>
        /// Q1YDTA.
        /// </summary>
        public const string Q1YDTA = "Q1YDTA";

        /// <summary>
        /// Q1YCHN.
        /// </summary>
        public const string Q1YCHN = "Q1YCHN";

        /// <summary>
        /// Q1MCU.
        /// </summary>
        public const string Q1MCU = "Q1MCU";

        /// <summary>
        /// Q1YIRF.
        /// </summary>
        public const string Q1YIRF = "Q1YIRF";

        /// <summary>
        /// Q1YGPN.
        /// </summary>
        public const string Q1YGPN = "Q1YGPN";

        /// <summary>
        /// Q1YGPD.
        /// </summary>
        public const string Q1YGPD = "Q1YGPD";

        /// <summary>
        /// Q1CNID.
        /// </summary>
        public const string Q1CNID = "Q1CNID";

        /// <summary>
        /// Q1REMK.
        /// </summary>
        public const string Q1REMK = "Q1REMK";

        /// <summary>
        /// Q1YODN.
        /// </summary>
        public const string Q1YODN = "Q1YODN";

        /// <summary>
        /// Q1YOTP.
        /// </summary>
        public const string Q1YOTP = "Q1YOTP";

        /// <summary>
        /// Q1YOCO.
        /// </summary>
        public const string Q1YOCO = "Q1YOCO";

        /// <summary>
        /// Q1IOTY.
        /// </summary>
        public const string Q1IOTY = "Q1IOTY";

        /// <summary>
        /// Q1AN8V.
        /// </summary>
        public const string Q1AN8V = "Q1AN8V";

        /// <summary>
        /// Q1YREG.
        /// </summary>
        public const string Q1YREG = "Q1YREG";

        /// <summary>
        /// Q1ASVL.
        /// </summary>
        public const string Q1ASVL = "Q1ASVL";

        /// <summary>
        /// Q1I75CESS.
        /// </summary>
        public const string Q1I75CESS = "Q1I75CESS";

        /// <summary>
        /// Q1I75BED.
        /// </summary>
        public const string Q1I75BED = "Q1I75BED";

        /// <summary>
        /// Q1YEXA.
        /// </summary>
        public const string Q1YEXA = "Q1YEXA";

        /// <summary>
        /// Q1I75SED.
        /// </summary>
        public const string Q1I75SED = "Q1I75SED";

        /// <summary>
        /// Q1I75CCS.
        /// </summary>
        public const string Q1I75CCS = "Q1I75CCS";

        /// <summary>
        /// Q1I75AED.
        /// </summary>
        public const string Q1I75AED = "Q1I75AED";

        /// <summary>
        /// Q1I75CVD.
        /// </summary>
        public const string Q1I75CVD = "Q1I75CVD";

        /// <summary>
        /// Q1YCDT.
        /// </summary>
        public const string Q1YCDT = "Q1YCDT";

        /// <summary>
        /// Q1DCPER.
        /// </summary>
        public const string Q1DCPER = "Q1DCPER";

        /// <summary>
        /// Q1DCVD.
        /// </summary>
        public const string Q1DCVD = "Q1DCVD";

        /// <summary>
        /// Q1YTDU.
        /// </summary>
        public const string Q1YTDU = "Q1YTDU";

        /// <summary>
        /// Q1YODT.
        /// </summary>
        public const string Q1YODT = "Q1YODT";

        /// <summary>
        /// Q1AM0.
        /// </summary>
        public const string Q1AM0 = "Q1AM0";

        /// <summary>
        /// Q1FLAG.
        /// </summary>
        public const string Q1FLAG = "Q1FLAG";

        /// <summary>
        /// Q1FLG.
        /// </summary>
        public const string Q1FLG = "Q1FLG";

        /// <summary>
        /// Q1I75FTX1.
        /// </summary>
        public const string Q1I75FTX1 = "Q1I75FTX1";

        /// <summary>
        /// Q1I75FTX2.
        /// </summary>
        public const string Q1I75FTX2 = "Q1I75FTX2";

        /// <summary>
        /// Q1TORG.
        /// </summary>
        public const string Q1TORG = "Q1TORG";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1TDAY.
        /// </summary>
        public const string Q1TDAY = "Q1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I313Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1YEXU", "Q1YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1YNXE", "Q1YNXE", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1YDTA", "Q1YDTA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1YCHN", "Q1YCHN", JdeDataType.String, 40, true, true),
        new JdeField("Q1MCU", "Q1MCU", JdeDataType.String, 24),
        new JdeField("Q1YIRF", "Q1YIRF", JdeDataType.String, 2),
        new JdeField("Q1YGPN", "Q1YGPN", JdeDataType.String, 24),
        new JdeField("Q1YGPD", "Q1YGPD", JdeDataType.Numeric),
        new JdeField("Q1CNID", "Q1CNID", JdeDataType.String, 40, true, true),
        new JdeField("Q1REMK", "Q1REMK", JdeDataType.String, 60),
        new JdeField("Q1YODN", "Q1YODN", JdeDataType.Numeric),
        new JdeField("Q1YOTP", "Q1YOTP", JdeDataType.String, 4),
        new JdeField("Q1YOCO", "Q1YOCO", JdeDataType.String, 10),
        new JdeField("Q1IOTY", "Q1IOTY", JdeDataType.String, 2),
        new JdeField("Q1AN8V", "Q1AN8V", JdeDataType.Numeric),
        new JdeField("Q1YREG", "Q1YREG", JdeDataType.String, 120),
        new JdeField("Q1ASVL", "Q1ASVL", JdeDataType.Numeric),
        new JdeField("Q1I75CESS", "Q1I75CESS", JdeDataType.Numeric),
        new JdeField("Q1I75BED", "Q1I75BED", JdeDataType.Numeric),
        new JdeField("Q1YEXA", "Q1YEXA", JdeDataType.Numeric),
        new JdeField("Q1I75SED", "Q1I75SED", JdeDataType.Numeric),
        new JdeField("Q1I75CCS", "Q1I75CCS", JdeDataType.Numeric),
        new JdeField("Q1I75AED", "Q1I75AED", JdeDataType.Numeric),
        new JdeField("Q1I75CVD", "Q1I75CVD", JdeDataType.Numeric),
        new JdeField("Q1YCDT", "Q1YCDT", JdeDataType.Numeric),
        new JdeField("Q1DCPER", "Q1DCPER", JdeDataType.Numeric),
        new JdeField("Q1DCVD", "Q1DCVD", JdeDataType.Numeric),
        new JdeField("Q1YTDU", "Q1YTDU", JdeDataType.Numeric),
        new JdeField("Q1YODT", "Q1YODT", JdeDataType.Numeric),
        new JdeField("Q1AM0", "Q1AM0", JdeDataType.Numeric),
        new JdeField("Q1FLAG", "Q1FLAG", JdeDataType.String, 2),
        new JdeField("Q1FLG", "Q1FLG", JdeDataType.String, 2),
        new JdeField("Q1I75FTX1", "Q1I75FTX1", JdeDataType.Numeric),
        new JdeField("Q1I75FTX2", "Q1I75FTX2", JdeDataType.Numeric),
        new JdeField("Q1TORG", "Q1TORG", JdeDataType.String, 20),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1TDAY", "Q1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I313Y_0", "Primary Key on Q1YEXU, Q1YNXE, Q1YDTA, Q1YCHN, Q1CNID", new[] { "Q1YEXU", "Q1YNXE", "Q1YDTA", "Q1YCHN", "Q1CNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I313Y_2", "Index on Q1YEXU, Q1CNID, Q1AN8V, Q1YIRF", new[] { "Q1YEXU", "Q1CNID", "Q1AN8V", "Q1YIRF" }),
        new JdeIndex("F75I313Y_3", "Index on Q1YEXU, Q1YDTA, Q1YNXE, Q1YCHN", new[] { "Q1YEXU", "Q1YDTA", "Q1YNXE", "Q1YCHN" })
    };
}
