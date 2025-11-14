using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I315Y - .
/// </summary>
public class F75I315Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q2YEXU.
        /// </summary>
        public const string Q2YEXU = "Q2YEXU";

        /// <summary>
        /// Q2YNXP.
        /// </summary>
        public const string Q2YNXP = "Q2YNXP";

        /// <summary>
        /// Q2YDTP.
        /// </summary>
        public const string Q2YDTP = "Q2YDTP";

        /// <summary>
        /// Q2YCHN.
        /// </summary>
        public const string Q2YCHN = "Q2YCHN";

        /// <summary>
        /// Q2MCU.
        /// </summary>
        public const string Q2MCU = "Q2MCU";

        /// <summary>
        /// Q2YIRF.
        /// </summary>
        public const string Q2YIRF = "Q2YIRF";

        /// <summary>
        /// Q2YGPN.
        /// </summary>
        public const string Q2YGPN = "Q2YGPN";

        /// <summary>
        /// Q2YGPD.
        /// </summary>
        public const string Q2YGPD = "Q2YGPD";

        /// <summary>
        /// Q2REMK.
        /// </summary>
        public const string Q2REMK = "Q2REMK";

        /// <summary>
        /// Q2CNID.
        /// </summary>
        public const string Q2CNID = "Q2CNID";

        /// <summary>
        /// Q2YODN.
        /// </summary>
        public const string Q2YODN = "Q2YODN";

        /// <summary>
        /// Q2YOTP.
        /// </summary>
        public const string Q2YOTP = "Q2YOTP";

        /// <summary>
        /// Q2YOCO.
        /// </summary>
        public const string Q2YOCO = "Q2YOCO";

        /// <summary>
        /// Q2IOTY.
        /// </summary>
        public const string Q2IOTY = "Q2IOTY";

        /// <summary>
        /// Q2AN8.
        /// </summary>
        public const string Q2AN8 = "Q2AN8";

        /// <summary>
        /// Q2YREG.
        /// </summary>
        public const string Q2YREG = "Q2YREG";

        /// <summary>
        /// Q2ASVL.
        /// </summary>
        public const string Q2ASVL = "Q2ASVL";

        /// <summary>
        /// Q2I75BED.
        /// </summary>
        public const string Q2I75BED = "Q2I75BED";

        /// <summary>
        /// Q2I75CESS.
        /// </summary>
        public const string Q2I75CESS = "Q2I75CESS";

        /// <summary>
        /// Q2I75SED.
        /// </summary>
        public const string Q2I75SED = "Q2I75SED";

        /// <summary>
        /// Q2I75AED.
        /// </summary>
        public const string Q2I75AED = "Q2I75AED";

        /// <summary>
        /// Q2I75CVD.
        /// </summary>
        public const string Q2I75CVD = "Q2I75CVD";

        /// <summary>
        /// Q2I75CCS.
        /// </summary>
        public const string Q2I75CCS = "Q2I75CCS";

        /// <summary>
        /// Q2YEXA.
        /// </summary>
        public const string Q2YEXA = "Q2YEXA";

        /// <summary>
        /// Q2YCDT.
        /// </summary>
        public const string Q2YCDT = "Q2YCDT";

        /// <summary>
        /// Q2DCPER.
        /// </summary>
        public const string Q2DCPER = "Q2DCPER";

        /// <summary>
        /// Q2DCVD.
        /// </summary>
        public const string Q2DCVD = "Q2DCVD";

        /// <summary>
        /// Q2YTDU.
        /// </summary>
        public const string Q2YTDU = "Q2YTDU";

        /// <summary>
        /// Q2FLAG.
        /// </summary>
        public const string Q2FLAG = "Q2FLAG";

        /// <summary>
        /// Q2YODT.
        /// </summary>
        public const string Q2YODT = "Q2YODT";

        /// <summary>
        /// Q2AM0.
        /// </summary>
        public const string Q2AM0 = "Q2AM0";

        /// <summary>
        /// Q2FLG.
        /// </summary>
        public const string Q2FLG = "Q2FLG";

        /// <summary>
        /// Q2I75FTX1.
        /// </summary>
        public const string Q2I75FTX1 = "Q2I75FTX1";

        /// <summary>
        /// Q2I75FTX2.
        /// </summary>
        public const string Q2I75FTX2 = "Q2I75FTX2";

        /// <summary>
        /// Q2TORG.
        /// </summary>
        public const string Q2TORG = "Q2TORG";

        /// <summary>
        /// Q2USER.
        /// </summary>
        public const string Q2USER = "Q2USER";

        /// <summary>
        /// Q2PID.
        /// </summary>
        public const string Q2PID = "Q2PID";

        /// <summary>
        /// Q2JOBN.
        /// </summary>
        public const string Q2JOBN = "Q2JOBN";

        /// <summary>
        /// Q2UPMJ.
        /// </summary>
        public const string Q2UPMJ = "Q2UPMJ";

        /// <summary>
        /// Q2TDAY.
        /// </summary>
        public const string Q2TDAY = "Q2TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I315Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2YEXU", "Q2YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YNXP", "Q2YNXP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YDTP", "Q2YDTP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YCHN", "Q2YCHN", JdeDataType.String, 40, true, true),
        new JdeField("Q2MCU", "Q2MCU", JdeDataType.String, 24),
        new JdeField("Q2YIRF", "Q2YIRF", JdeDataType.String, 2),
        new JdeField("Q2YGPN", "Q2YGPN", JdeDataType.String, 24),
        new JdeField("Q2YGPD", "Q2YGPD", JdeDataType.Numeric),
        new JdeField("Q2REMK", "Q2REMK", JdeDataType.String, 60),
        new JdeField("Q2CNID", "Q2CNID", JdeDataType.String, 40),
        new JdeField("Q2YODN", "Q2YODN", JdeDataType.Numeric),
        new JdeField("Q2YOTP", "Q2YOTP", JdeDataType.String, 4),
        new JdeField("Q2YOCO", "Q2YOCO", JdeDataType.String, 10),
        new JdeField("Q2IOTY", "Q2IOTY", JdeDataType.String, 2),
        new JdeField("Q2AN8", "Q2AN8", JdeDataType.Numeric),
        new JdeField("Q2YREG", "Q2YREG", JdeDataType.String, 120),
        new JdeField("Q2ASVL", "Q2ASVL", JdeDataType.Numeric),
        new JdeField("Q2I75BED", "Q2I75BED", JdeDataType.Numeric),
        new JdeField("Q2I75CESS", "Q2I75CESS", JdeDataType.Numeric),
        new JdeField("Q2I75SED", "Q2I75SED", JdeDataType.Numeric),
        new JdeField("Q2I75AED", "Q2I75AED", JdeDataType.Numeric),
        new JdeField("Q2I75CVD", "Q2I75CVD", JdeDataType.Numeric),
        new JdeField("Q2I75CCS", "Q2I75CCS", JdeDataType.Numeric),
        new JdeField("Q2YEXA", "Q2YEXA", JdeDataType.Numeric),
        new JdeField("Q2YCDT", "Q2YCDT", JdeDataType.Numeric),
        new JdeField("Q2DCPER", "Q2DCPER", JdeDataType.Numeric),
        new JdeField("Q2DCVD", "Q2DCVD", JdeDataType.Numeric),
        new JdeField("Q2YTDU", "Q2YTDU", JdeDataType.Numeric),
        new JdeField("Q2FLAG", "Q2FLAG", JdeDataType.String, 2),
        new JdeField("Q2YODT", "Q2YODT", JdeDataType.Numeric),
        new JdeField("Q2AM0", "Q2AM0", JdeDataType.Numeric),
        new JdeField("Q2FLG", "Q2FLG", JdeDataType.String, 2),
        new JdeField("Q2I75FTX1", "Q2I75FTX1", JdeDataType.Numeric),
        new JdeField("Q2I75FTX2", "Q2I75FTX2", JdeDataType.Numeric),
        new JdeField("Q2TORG", "Q2TORG", JdeDataType.String, 20),
        new JdeField("Q2USER", "Q2USER", JdeDataType.String, 20),
        new JdeField("Q2PID", "Q2PID", JdeDataType.String, 20),
        new JdeField("Q2JOBN", "Q2JOBN", JdeDataType.String, 20),
        new JdeField("Q2UPMJ", "Q2UPMJ", JdeDataType.Numeric),
        new JdeField("Q2TDAY", "Q2TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I315Y_0", "Primary Key on Q2YEXU, Q2YNXP, Q2YDTP, Q2YCHN", new[] { "Q2YEXU", "Q2YNXP", "Q2YDTP", "Q2YCHN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I315Y_2", "Index on Q2YEXU, Q2YDTP, Q2YNXP, Q2YCHN", new[] { "Q2YEXU", "Q2YDTP", "Q2YNXP", "Q2YCHN" })
    };
}
