using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I317Y - .
/// </summary>
public class F75I317Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3YEXU.
        /// </summary>
        public const string Q3YEXU = "Q3YEXU";

        /// <summary>
        /// Q3YCXP.
        /// </summary>
        public const string Q3YCXP = "Q3YCXP";

        /// <summary>
        /// Q3YDTC.
        /// </summary>
        public const string Q3YDTC = "Q3YDTC";

        /// <summary>
        /// Q3YCHN.
        /// </summary>
        public const string Q3YCHN = "Q3YCHN";

        /// <summary>
        /// Q3MCU.
        /// </summary>
        public const string Q3MCU = "Q3MCU";

        /// <summary>
        /// Q3YIRF.
        /// </summary>
        public const string Q3YIRF = "Q3YIRF";

        /// <summary>
        /// Q3YGPN.
        /// </summary>
        public const string Q3YGPN = "Q3YGPN";

        /// <summary>
        /// Q3YGPD.
        /// </summary>
        public const string Q3YGPD = "Q3YGPD";

        /// <summary>
        /// Q3CNID.
        /// </summary>
        public const string Q3CNID = "Q3CNID";

        /// <summary>
        /// Q3REMK.
        /// </summary>
        public const string Q3REMK = "Q3REMK";

        /// <summary>
        /// Q3YODN.
        /// </summary>
        public const string Q3YODN = "Q3YODN";

        /// <summary>
        /// Q3YOTP.
        /// </summary>
        public const string Q3YOTP = "Q3YOTP";

        /// <summary>
        /// Q3IOTY.
        /// </summary>
        public const string Q3IOTY = "Q3IOTY";

        /// <summary>
        /// Q3AN8.
        /// </summary>
        public const string Q3AN8 = "Q3AN8";

        /// <summary>
        /// Q3YREG.
        /// </summary>
        public const string Q3YREG = "Q3YREG";

        /// <summary>
        /// Q3ASVL.
        /// </summary>
        public const string Q3ASVL = "Q3ASVL";

        /// <summary>
        /// Q3I75BED.
        /// </summary>
        public const string Q3I75BED = "Q3I75BED";

        /// <summary>
        /// Q3I75CESS.
        /// </summary>
        public const string Q3I75CESS = "Q3I75CESS";

        /// <summary>
        /// Q3I75SED.
        /// </summary>
        public const string Q3I75SED = "Q3I75SED";

        /// <summary>
        /// Q3I75AED.
        /// </summary>
        public const string Q3I75AED = "Q3I75AED";

        /// <summary>
        /// Q3I75CVD.
        /// </summary>
        public const string Q3I75CVD = "Q3I75CVD";

        /// <summary>
        /// Q3I75CCS.
        /// </summary>
        public const string Q3I75CCS = "Q3I75CCS";

        /// <summary>
        /// Q3YEXA.
        /// </summary>
        public const string Q3YEXA = "Q3YEXA";

        /// <summary>
        /// Q3YCDT.
        /// </summary>
        public const string Q3YCDT = "Q3YCDT";

        /// <summary>
        /// Q3AM0.
        /// </summary>
        public const string Q3AM0 = "Q3AM0";

        /// <summary>
        /// Q3TORG.
        /// </summary>
        public const string Q3TORG = "Q3TORG";

        /// <summary>
        /// Q3USER.
        /// </summary>
        public const string Q3USER = "Q3USER";

        /// <summary>
        /// Q3PID.
        /// </summary>
        public const string Q3PID = "Q3PID";

        /// <summary>
        /// Q3JOBN.
        /// </summary>
        public const string Q3JOBN = "Q3JOBN";

        /// <summary>
        /// Q3UPMJ.
        /// </summary>
        public const string Q3UPMJ = "Q3UPMJ";

        /// <summary>
        /// Q3TDAY.
        /// </summary>
        public const string Q3TDAY = "Q3TDAY";

        /// <summary>
        /// Q3DCPER.
        /// </summary>
        public const string Q3DCPER = "Q3DCPER";

        /// <summary>
        /// Q3DCVD.
        /// </summary>
        public const string Q3DCVD = "Q3DCVD";

        /// <summary>
        /// Q3YODT.
        /// </summary>
        public const string Q3YODT = "Q3YODT";

        /// <summary>
        /// Q3YTDU.
        /// </summary>
        public const string Q3YTDU = "Q3YTDU";

        /// <summary>
        /// Q3FLAG.
        /// </summary>
        public const string Q3FLAG = "Q3FLAG";

        /// <summary>
        /// Q3FLG.
        /// </summary>
        public const string Q3FLG = "Q3FLG";

        /// <summary>
        /// Q3I75FTX1.
        /// </summary>
        public const string Q3I75FTX1 = "Q3I75FTX1";

        /// <summary>
        /// Q3I75FTX2.
        /// </summary>
        public const string Q3I75FTX2 = "Q3I75FTX2";
    }

    /// <inheritdoc />
    public override string TableName => "F75I317Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3YEXU", "Q3YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YCXP", "Q3YCXP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YDTC", "Q3YDTC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YCHN", "Q3YCHN", JdeDataType.String, 40, true, true),
        new JdeField("Q3MCU", "Q3MCU", JdeDataType.String, 24),
        new JdeField("Q3YIRF", "Q3YIRF", JdeDataType.String, 2),
        new JdeField("Q3YGPN", "Q3YGPN", JdeDataType.String, 24),
        new JdeField("Q3YGPD", "Q3YGPD", JdeDataType.Numeric),
        new JdeField("Q3CNID", "Q3CNID", JdeDataType.String, 40, true, true),
        new JdeField("Q3REMK", "Q3REMK", JdeDataType.String, 60),
        new JdeField("Q3YODN", "Q3YODN", JdeDataType.Numeric),
        new JdeField("Q3YOTP", "Q3YOTP", JdeDataType.String, 4),
        new JdeField("Q3IOTY", "Q3IOTY", JdeDataType.String, 2),
        new JdeField("Q3AN8", "Q3AN8", JdeDataType.Numeric),
        new JdeField("Q3YREG", "Q3YREG", JdeDataType.String, 120),
        new JdeField("Q3ASVL", "Q3ASVL", JdeDataType.Numeric),
        new JdeField("Q3I75BED", "Q3I75BED", JdeDataType.Numeric),
        new JdeField("Q3I75CESS", "Q3I75CESS", JdeDataType.Numeric),
        new JdeField("Q3I75SED", "Q3I75SED", JdeDataType.Numeric),
        new JdeField("Q3I75AED", "Q3I75AED", JdeDataType.Numeric),
        new JdeField("Q3I75CVD", "Q3I75CVD", JdeDataType.Numeric),
        new JdeField("Q3I75CCS", "Q3I75CCS", JdeDataType.Numeric),
        new JdeField("Q3YEXA", "Q3YEXA", JdeDataType.Numeric),
        new JdeField("Q3YCDT", "Q3YCDT", JdeDataType.Numeric),
        new JdeField("Q3AM0", "Q3AM0", JdeDataType.Numeric),
        new JdeField("Q3TORG", "Q3TORG", JdeDataType.String, 20),
        new JdeField("Q3USER", "Q3USER", JdeDataType.String, 20),
        new JdeField("Q3PID", "Q3PID", JdeDataType.String, 20),
        new JdeField("Q3JOBN", "Q3JOBN", JdeDataType.String, 20),
        new JdeField("Q3UPMJ", "Q3UPMJ", JdeDataType.Numeric),
        new JdeField("Q3TDAY", "Q3TDAY", JdeDataType.Numeric),
        new JdeField("Q3DCPER", "Q3DCPER", JdeDataType.Numeric),
        new JdeField("Q3DCVD", "Q3DCVD", JdeDataType.Numeric),
        new JdeField("Q3YODT", "Q3YODT", JdeDataType.Numeric),
        new JdeField("Q3YTDU", "Q3YTDU", JdeDataType.Numeric),
        new JdeField("Q3FLAG", "Q3FLAG", JdeDataType.String, 2),
        new JdeField("Q3FLG", "Q3FLG", JdeDataType.String, 2),
        new JdeField("Q3I75FTX1", "Q3I75FTX1", JdeDataType.Numeric),
        new JdeField("Q3I75FTX2", "Q3I75FTX2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I317Y_0", "Primary Key on Q3YEXU, Q3YCXP, Q3YDTC, Q3YCHN, Q3CNID", new[] { "Q3YEXU", "Q3YCXP", "Q3YDTC", "Q3YCHN", "Q3CNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I317Y_3", "Index on Q3YEXU, Q3YDTC, Q3YCXP", new[] { "Q3YEXU", "Q3YDTC", "Q3YCXP" })
    };
}
