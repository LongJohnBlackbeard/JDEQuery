using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I316Y - .
/// </summary>
public class F75I316Y : JdeTable
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
        /// Q2DOC.
        /// </summary>
        public const string Q2DOC = "Q2DOC";

        /// <summary>
        /// Q2KCO.
        /// </summary>
        public const string Q2KCO = "Q2KCO";

        /// <summary>
        /// Q2DCT.
        /// </summary>
        public const string Q2DCT = "Q2DCT";

        /// <summary>
        /// Q2UKID.
        /// </summary>
        public const string Q2UKID = "Q2UKID";

        /// <summary>
        /// Q2MCU.
        /// </summary>
        public const string Q2MCU = "Q2MCU";

        /// <summary>
        /// Q2LOCN.
        /// </summary>
        public const string Q2LOCN = "Q2LOCN";

        /// <summary>
        /// Q2LOTN.
        /// </summary>
        public const string Q2LOTN = "Q2LOTN";

        /// <summary>
        /// Q2TRUM.
        /// </summary>
        public const string Q2TRUM = "Q2TRUM";

        /// <summary>
        /// Q2DOD.
        /// </summary>
        public const string Q2DOD = "Q2DOD";

        /// <summary>
        /// Q2DCTO.
        /// </summary>
        public const string Q2DCTO = "Q2DCTO";

        /// <summary>
        /// Q2ITM.
        /// </summary>
        public const string Q2ITM = "Q2ITM";

        /// <summary>
        /// Q2LITM.
        /// </summary>
        public const string Q2LITM = "Q2LITM";

        /// <summary>
        /// Q2AITM.
        /// </summary>
        public const string Q2AITM = "Q2AITM";

        /// <summary>
        /// Q2STKT.
        /// </summary>
        public const string Q2STKT = "Q2STKT";

        /// <summary>
        /// Q2YCHN.
        /// </summary>
        public const string Q2YCHN = "Q2YCHN";

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
        /// Q2ASVL.
        /// </summary>
        public const string Q2ASVL = "Q2ASVL";

        /// <summary>
        /// Q2YEXA.
        /// </summary>
        public const string Q2YEXA = "Q2YEXA";

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
        /// Q2YODT.
        /// </summary>
        public const string Q2YODT = "Q2YODT";

        /// <summary>
        /// Q2YCDT.
        /// </summary>
        public const string Q2YCDT = "Q2YCDT";

        /// <summary>
        /// Q2UREC.
        /// </summary>
        public const string Q2UREC = "Q2UREC";

        /// <summary>
        /// Q2QTYS.
        /// </summary>
        public const string Q2QTYS = "Q2QTYS";

        /// <summary>
        /// Q2FLAG.
        /// </summary>
        public const string Q2FLAG = "Q2FLAG";

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
    public override string TableName => "F75I316Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2YEXU", "Q2YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YNXP", "Q2YNXP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YDTP", "Q2YDTP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2DOC", "Q2DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2KCO", "Q2KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q2DCT", "Q2DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q2UKID", "Q2UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2MCU", "Q2MCU", JdeDataType.String, 24),
        new JdeField("Q2LOCN", "Q2LOCN", JdeDataType.String, 40),
        new JdeField("Q2LOTN", "Q2LOTN", JdeDataType.String, 60),
        new JdeField("Q2TRUM", "Q2TRUM", JdeDataType.String, 4),
        new JdeField("Q2DOD", "Q2DOD", JdeDataType.Numeric),
        new JdeField("Q2DCTO", "Q2DCTO", JdeDataType.String, 4),
        new JdeField("Q2ITM", "Q2ITM", JdeDataType.Numeric),
        new JdeField("Q2LITM", "Q2LITM", JdeDataType.String, 50),
        new JdeField("Q2AITM", "Q2AITM", JdeDataType.String, 50),
        new JdeField("Q2STKT", "Q2STKT", JdeDataType.String, 2),
        new JdeField("Q2YCHN", "Q2YCHN", JdeDataType.String, 40),
        new JdeField("Q2I75BED", "Q2I75BED", JdeDataType.Numeric),
        new JdeField("Q2I75CESS", "Q2I75CESS", JdeDataType.Numeric),
        new JdeField("Q2I75SED", "Q2I75SED", JdeDataType.Numeric),
        new JdeField("Q2I75AED", "Q2I75AED", JdeDataType.Numeric),
        new JdeField("Q2I75CVD", "Q2I75CVD", JdeDataType.Numeric),
        new JdeField("Q2I75CCS", "Q2I75CCS", JdeDataType.Numeric),
        new JdeField("Q2ASVL", "Q2ASVL", JdeDataType.Numeric),
        new JdeField("Q2YEXA", "Q2YEXA", JdeDataType.Numeric),
        new JdeField("Q2DCPER", "Q2DCPER", JdeDataType.Numeric),
        new JdeField("Q2DCVD", "Q2DCVD", JdeDataType.Numeric),
        new JdeField("Q2YTDU", "Q2YTDU", JdeDataType.Numeric),
        new JdeField("Q2YODT", "Q2YODT", JdeDataType.Numeric),
        new JdeField("Q2YCDT", "Q2YCDT", JdeDataType.Numeric),
        new JdeField("Q2UREC", "Q2UREC", JdeDataType.Numeric),
        new JdeField("Q2QTYS", "Q2QTYS", JdeDataType.Numeric),
        new JdeField("Q2FLAG", "Q2FLAG", JdeDataType.String, 2),
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
        new JdeIndex("F75I316Y_0", "Primary Key on Q2YEXU, Q2YNXP, Q2YDTP, Q2KCO, Q2DOC, Q2DCT, Q2UKID", new[] { "Q2YEXU", "Q2YNXP", "Q2YDTP", "Q2KCO", "Q2DOC", "Q2DCT", "Q2UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I316Y_2", "Index on Q2ITM, Q2KCO, Q2DOC, Q2DCT, Q2LOCN, Q2LOTN", new[] { "Q2ITM", "Q2KCO", "Q2DOC", "Q2DCT", "Q2LOCN", "Q2LOTN" }),
        new JdeIndex("F75I316Y_3", "Index on Q2KCO, Q2DCT, Q2DOC", new[] { "Q2KCO", "Q2DCT", "Q2DOC" })
    };
}
