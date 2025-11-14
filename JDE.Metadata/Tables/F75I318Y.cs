using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I318Y - .
/// </summary>
public class F75I318Y : JdeTable
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
        /// Q3KCO.
        /// </summary>
        public const string Q3KCO = "Q3KCO";

        /// <summary>
        /// Q3DOC.
        /// </summary>
        public const string Q3DOC = "Q3DOC";

        /// <summary>
        /// Q3DCT.
        /// </summary>
        public const string Q3DCT = "Q3DCT";

        /// <summary>
        /// Q3UKID.
        /// </summary>
        public const string Q3UKID = "Q3UKID";

        /// <summary>
        /// Q3MCU.
        /// </summary>
        public const string Q3MCU = "Q3MCU";

        /// <summary>
        /// Q3LOCN.
        /// </summary>
        public const string Q3LOCN = "Q3LOCN";

        /// <summary>
        /// Q3LOTN.
        /// </summary>
        public const string Q3LOTN = "Q3LOTN";

        /// <summary>
        /// Q3TRUM.
        /// </summary>
        public const string Q3TRUM = "Q3TRUM";

        /// <summary>
        /// Q3DOD.
        /// </summary>
        public const string Q3DOD = "Q3DOD";

        /// <summary>
        /// Q3DCTO.
        /// </summary>
        public const string Q3DCTO = "Q3DCTO";

        /// <summary>
        /// Q3ITM.
        /// </summary>
        public const string Q3ITM = "Q3ITM";

        /// <summary>
        /// Q3LITM.
        /// </summary>
        public const string Q3LITM = "Q3LITM";

        /// <summary>
        /// Q3AITM.
        /// </summary>
        public const string Q3AITM = "Q3AITM";

        /// <summary>
        /// Q3STKT.
        /// </summary>
        public const string Q3STKT = "Q3STKT";

        /// <summary>
        /// Q3YCHN.
        /// </summary>
        public const string Q3YCHN = "Q3YCHN";

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
        /// Q3I75AED.
        /// </summary>
        public const string Q3I75AED = "Q3I75AED";

        /// <summary>
        /// Q3I75SED.
        /// </summary>
        public const string Q3I75SED = "Q3I75SED";

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
        /// Q3UREC.
        /// </summary>
        public const string Q3UREC = "Q3UREC";

        /// <summary>
        /// Q3QTYS.
        /// </summary>
        public const string Q3QTYS = "Q3QTYS";

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
    public override string TableName => "F75I318Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3YEXU", "Q3YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YCXP", "Q3YCXP", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3YDTC", "Q3YDTC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3KCO", "Q3KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q3DOC", "Q3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3DCT", "Q3DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q3UKID", "Q3UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3MCU", "Q3MCU", JdeDataType.String, 24),
        new JdeField("Q3LOCN", "Q3LOCN", JdeDataType.String, 40),
        new JdeField("Q3LOTN", "Q3LOTN", JdeDataType.String, 60),
        new JdeField("Q3TRUM", "Q3TRUM", JdeDataType.String, 4),
        new JdeField("Q3DOD", "Q3DOD", JdeDataType.Numeric),
        new JdeField("Q3DCTO", "Q3DCTO", JdeDataType.String, 4),
        new JdeField("Q3ITM", "Q3ITM", JdeDataType.Numeric),
        new JdeField("Q3LITM", "Q3LITM", JdeDataType.String, 50),
        new JdeField("Q3AITM", "Q3AITM", JdeDataType.String, 50),
        new JdeField("Q3STKT", "Q3STKT", JdeDataType.String, 2),
        new JdeField("Q3YCHN", "Q3YCHN", JdeDataType.String, 40),
        new JdeField("Q3ASVL", "Q3ASVL", JdeDataType.Numeric),
        new JdeField("Q3I75BED", "Q3I75BED", JdeDataType.Numeric),
        new JdeField("Q3I75CESS", "Q3I75CESS", JdeDataType.Numeric),
        new JdeField("Q3I75AED", "Q3I75AED", JdeDataType.Numeric),
        new JdeField("Q3I75SED", "Q3I75SED", JdeDataType.Numeric),
        new JdeField("Q3I75CVD", "Q3I75CVD", JdeDataType.Numeric),
        new JdeField("Q3I75CCS", "Q3I75CCS", JdeDataType.Numeric),
        new JdeField("Q3YEXA", "Q3YEXA", JdeDataType.Numeric),
        new JdeField("Q3YCDT", "Q3YCDT", JdeDataType.Numeric),
        new JdeField("Q3UREC", "Q3UREC", JdeDataType.Numeric),
        new JdeField("Q3QTYS", "Q3QTYS", JdeDataType.Numeric),
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
        new JdeIndex("F75I318Y_0", "Primary Key on Q3YEXU, Q3YCXP, Q3YDTC, Q3KCO, Q3DOC, Q3DCT, Q3UKID", new[] { "Q3YEXU", "Q3YCXP", "Q3YDTC", "Q3KCO", "Q3DOC", "Q3DCT", "Q3UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I318Y_2", "Index on Q3ITM, Q3KCO, Q3DOC, Q3DCT, Q3LOCN, Q3LOTN", new[] { "Q3ITM", "Q3KCO", "Q3DOC", "Q3DCT", "Q3LOCN", "Q3LOTN" }),
        new JdeIndex("F75I318Y_3", "Index on Q3KCO, Q3DCT, Q3DOC", new[] { "Q3KCO", "Q3DCT", "Q3DOC" })
    };
}
