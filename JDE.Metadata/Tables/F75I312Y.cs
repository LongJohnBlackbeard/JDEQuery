using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I312Y - .
/// </summary>
public class F75I312Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1SADJ.
        /// </summary>
        public const string Q1SADJ = "Q1SADJ";

        /// <summary>
        /// Q1BAL.
        /// </summary>
        public const string Q1BAL = "Q1BAL";

        /// <summary>
        /// Q1MCU.
        /// </summary>
        public const string Q1MCU = "Q1MCU";

        /// <summary>
        /// Q1KCO.
        /// </summary>
        public const string Q1KCO = "Q1KCO";

        /// <summary>
        /// Q1DOC.
        /// </summary>
        public const string Q1DOC = "Q1DOC";

        /// <summary>
        /// Q1DCT.
        /// </summary>
        public const string Q1DCT = "Q1DCT";

        /// <summary>
        /// Q1DCTO.
        /// </summary>
        public const string Q1DCTO = "Q1DCTO";

        /// <summary>
        /// Q1DOCO.
        /// </summary>
        public const string Q1DOCO = "Q1DOCO";

        /// <summary>
        /// Q1KCOO.
        /// </summary>
        public const string Q1KCOO = "Q1KCOO";

        /// <summary>
        /// Q1TRDJ.
        /// </summary>
        public const string Q1TRDJ = "Q1TRDJ";

        /// <summary>
        /// Q1YCHN.
        /// </summary>
        public const string Q1YCHN = "Q1YCHN";

        /// <summary>
        /// Q1ITM.
        /// </summary>
        public const string Q1ITM = "Q1ITM";

        /// <summary>
        /// Q1LITM.
        /// </summary>
        public const string Q1LITM = "Q1LITM";

        /// <summary>
        /// Q1AITM.
        /// </summary>
        public const string Q1AITM = "Q1AITM";

        /// <summary>
        /// Q1LOCN.
        /// </summary>
        public const string Q1LOCN = "Q1LOCN";

        /// <summary>
        /// Q1LOTN.
        /// </summary>
        public const string Q1LOTN = "Q1LOTN";

        /// <summary>
        /// Q1TRUM.
        /// </summary>
        public const string Q1TRUM = "Q1TRUM";

        /// <summary>
        /// Q1TRQT.
        /// </summary>
        public const string Q1TRQT = "Q1TRQT";

        /// <summary>
        /// Q1UKID.
        /// </summary>
        public const string Q1UKID = "Q1UKID";

        /// <summary>
        /// Q1AN8.
        /// </summary>
        public const string Q1AN8 = "Q1AN8";

        /// <summary>
        /// Q1YEXU.
        /// </summary>
        public const string Q1YEXU = "Q1YEXU";

        /// <summary>
        /// Q1YNXP.
        /// </summary>
        public const string Q1YNXP = "Q1YNXP";

        /// <summary>
        /// Q1YDTP.
        /// </summary>
        public const string Q1YDTP = "Q1YDTP";

        /// <summary>
        /// Q1YPLBEDDR.
        /// </summary>
        public const string Q1YPLBEDDR = "Q1YPLBEDDR";

        /// <summary>
        /// Q1YPLSEDDR.
        /// </summary>
        public const string Q1YPLSEDDR = "Q1YPLSEDDR";

        /// <summary>
        /// Q1YPLAEDDR.
        /// </summary>
        public const string Q1YPLAEDDR = "Q1YPLAEDDR";

        /// <summary>
        /// Q1YPLNCDDR.
        /// </summary>
        public const string Q1YPLNCDDR = "Q1YPLNCDDR";

        /// <summary>
        /// Q1YNXE.
        /// </summary>
        public const string Q1YNXE = "Q1YNXE";

        /// <summary>
        /// Q1YDTA.
        /// </summary>
        public const string Q1YDTA = "Q1YDTA";

        /// <summary>
        /// Q1YA2BEDDR.
        /// </summary>
        public const string Q1YA2BEDDR = "Q1YA2BEDDR";

        /// <summary>
        /// Q1YA2SEDDR.
        /// </summary>
        public const string Q1YA2SEDDR = "Q1YA2SEDDR";

        /// <summary>
        /// Q1YA2AEDDR.
        /// </summary>
        public const string Q1YA2AEDDR = "Q1YA2AEDDR";

        /// <summary>
        /// Q1YA2NCDDR.
        /// </summary>
        public const string Q1YA2NCDDR = "Q1YA2NCDDR";

        /// <summary>
        /// Q1YCXP.
        /// </summary>
        public const string Q1YCXP = "Q1YCXP";

        /// <summary>
        /// Q1YDTC.
        /// </summary>
        public const string Q1YDTC = "Q1YDTC";

        /// <summary>
        /// Q1YC2BEDDR.
        /// </summary>
        public const string Q1YC2BEDDR = "Q1YC2BEDDR";

        /// <summary>
        /// Q1YC2SEDDR.
        /// </summary>
        public const string Q1YC2SEDDR = "Q1YC2SEDDR";

        /// <summary>
        /// Q1YC2AEDDR.
        /// </summary>
        public const string Q1YC2AEDDR = "Q1YC2AEDDR";

        /// <summary>
        /// Q1YC2NCDDR.
        /// </summary>
        public const string Q1YC2NCDDR = "Q1YC2NCDDR";

        /// <summary>
        /// Q1YDXP.
        /// </summary>
        public const string Q1YDXP = "Q1YDXP";

        /// <summary>
        /// Q1YDTD.
        /// </summary>
        public const string Q1YDTD = "Q1YDTD";

        /// <summary>
        /// Q1YDEC.
        /// </summary>
        public const string Q1YDEC = "Q1YDEC";

        /// <summary>
        /// Q1ASVL.
        /// </summary>
        public const string Q1ASVL = "Q1ASVL";

        /// <summary>
        /// Q1YCHL.
        /// </summary>
        public const string Q1YCHL = "Q1YCHL";

        /// <summary>
        /// Q1PRCS.
        /// </summary>
        public const string Q1PRCS = "Q1PRCS";

        /// <summary>
        /// Q1PRTF.
        /// </summary>
        public const string Q1PRTF = "Q1PRTF";

        /// <summary>
        /// Q1QOREC.
        /// </summary>
        public const string Q1QOREC = "Q1QOREC";

        /// <summary>
        /// Q1QTYC.
        /// </summary>
        public const string Q1QTYC = "Q1QTYC";

        /// <summary>
        /// Q1YENO.
        /// </summary>
        public const string Q1YENO = "Q1YENO";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1CRDJ.
        /// </summary>
        public const string Q1CRDJ = "Q1CRDJ";

        /// <summary>
        /// Q1TDAY.
        /// </summary>
        public const string Q1TDAY = "Q1TDAY";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

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
        /// Q1YEXA.
        /// </summary>
        public const string Q1YEXA = "Q1YEXA";

        /// <summary>
        /// Q1TREX.
        /// </summary>
        public const string Q1TREX = "Q1TREX";

        /// <summary>
        /// Q1ATTL.
        /// </summary>
        public const string Q1ATTL = "Q1ATTL";
    }

    /// <inheritdoc />
    public override string TableName => "F75I312Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1SADJ", "Q1SADJ", JdeDataType.String, 2),
        new JdeField("Q1BAL", "Q1BAL", JdeDataType.String, 2),
        new JdeField("Q1MCU", "Q1MCU", JdeDataType.String, 24, true, true),
        new JdeField("Q1KCO", "Q1KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q1DOC", "Q1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1DCT", "Q1DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q1DCTO", "Q1DCTO", JdeDataType.String, 4),
        new JdeField("Q1DOCO", "Q1DOCO", JdeDataType.Numeric),
        new JdeField("Q1KCOO", "Q1KCOO", JdeDataType.String, 10),
        new JdeField("Q1TRDJ", "Q1TRDJ", JdeDataType.Numeric),
        new JdeField("Q1YCHN", "Q1YCHN", JdeDataType.String, 40),
        new JdeField("Q1ITM", "Q1ITM", JdeDataType.Numeric),
        new JdeField("Q1LITM", "Q1LITM", JdeDataType.String, 50),
        new JdeField("Q1AITM", "Q1AITM", JdeDataType.String, 50),
        new JdeField("Q1LOCN", "Q1LOCN", JdeDataType.String, 40),
        new JdeField("Q1LOTN", "Q1LOTN", JdeDataType.String, 60),
        new JdeField("Q1TRUM", "Q1TRUM", JdeDataType.String, 4),
        new JdeField("Q1TRQT", "Q1TRQT", JdeDataType.Numeric),
        new JdeField("Q1UKID", "Q1UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1AN8", "Q1AN8", JdeDataType.Numeric),
        new JdeField("Q1YEXU", "Q1YEXU", JdeDataType.Numeric),
        new JdeField("Q1YNXP", "Q1YNXP", JdeDataType.Numeric),
        new JdeField("Q1YDTP", "Q1YDTP", JdeDataType.Numeric),
        new JdeField("Q1YPLBEDDR", "Q1YPLBEDDR", JdeDataType.Numeric),
        new JdeField("Q1YPLSEDDR", "Q1YPLSEDDR", JdeDataType.Numeric),
        new JdeField("Q1YPLAEDDR", "Q1YPLAEDDR", JdeDataType.Numeric),
        new JdeField("Q1YPLNCDDR", "Q1YPLNCDDR", JdeDataType.Numeric),
        new JdeField("Q1YNXE", "Q1YNXE", JdeDataType.Numeric),
        new JdeField("Q1YDTA", "Q1YDTA", JdeDataType.Numeric),
        new JdeField("Q1YA2BEDDR", "Q1YA2BEDDR", JdeDataType.Numeric),
        new JdeField("Q1YA2SEDDR", "Q1YA2SEDDR", JdeDataType.Numeric),
        new JdeField("Q1YA2AEDDR", "Q1YA2AEDDR", JdeDataType.Numeric),
        new JdeField("Q1YA2NCDDR", "Q1YA2NCDDR", JdeDataType.Numeric),
        new JdeField("Q1YCXP", "Q1YCXP", JdeDataType.Numeric),
        new JdeField("Q1YDTC", "Q1YDTC", JdeDataType.Numeric),
        new JdeField("Q1YC2BEDDR", "Q1YC2BEDDR", JdeDataType.Numeric),
        new JdeField("Q1YC2SEDDR", "Q1YC2SEDDR", JdeDataType.Numeric),
        new JdeField("Q1YC2AEDDR", "Q1YC2AEDDR", JdeDataType.Numeric),
        new JdeField("Q1YC2NCDDR", "Q1YC2NCDDR", JdeDataType.Numeric),
        new JdeField("Q1YDXP", "Q1YDXP", JdeDataType.Numeric),
        new JdeField("Q1YDTD", "Q1YDTD", JdeDataType.Numeric),
        new JdeField("Q1YDEC", "Q1YDEC", JdeDataType.Numeric),
        new JdeField("Q1ASVL", "Q1ASVL", JdeDataType.Numeric),
        new JdeField("Q1YCHL", "Q1YCHL", JdeDataType.Numeric),
        new JdeField("Q1PRCS", "Q1PRCS", JdeDataType.String, 2),
        new JdeField("Q1PRTF", "Q1PRTF", JdeDataType.String, 2),
        new JdeField("Q1QOREC", "Q1QOREC", JdeDataType.Numeric),
        new JdeField("Q1QTYC", "Q1QTYC", JdeDataType.Numeric),
        new JdeField("Q1YENO", "Q1YENO", JdeDataType.Numeric),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1CRDJ", "Q1CRDJ", JdeDataType.Numeric),
        new JdeField("Q1TDAY", "Q1TDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1DCPER", "Q1DCPER", JdeDataType.Numeric),
        new JdeField("Q1DCVD", "Q1DCVD", JdeDataType.Numeric),
        new JdeField("Q1YTDU", "Q1YTDU", JdeDataType.Numeric),
        new JdeField("Q1YODT", "Q1YODT", JdeDataType.Numeric),
        new JdeField("Q1YEXA", "Q1YEXA", JdeDataType.Numeric),
        new JdeField("Q1TREX", "Q1TREX", JdeDataType.String, 60),
        new JdeField("Q1ATTL", "Q1ATTL", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I312Y_0", "Primary Key on Q1KCO, Q1DCT, Q1DOC, Q1UKID, Q1UPMJ, Q1TDAY, Q1MCU", new[] { "Q1KCO", "Q1DCT", "Q1DOC", "Q1UKID", "Q1UPMJ", "Q1TDAY", "Q1MCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I312Y_2", "Index on Q1MCU, Q1AN8, Q1YCHL", new[] { "Q1MCU", "Q1AN8", "Q1YCHL" }),
        new JdeIndex("F75I312Y_3", "Index on Q1UKID", new[] { "Q1UKID" }),
        new JdeIndex("F75I312Y_4", "Index on Q1PRCS, Q1JOBN, Q1YCHN", new[] { "Q1PRCS", "Q1JOBN", "Q1YCHN" }),
        new JdeIndex("F75I312Y_5", "Index on Q1UKID, Q1JOBN, Q1PRCS", new[] { "Q1UKID", "Q1JOBN", "Q1PRCS" }),
        new JdeIndex("F75I312Y_6", "Index on Q1KCO, Q1DCT, Q1DOC, Q1MCU, Q1UKID, Q1PRCS", new[] { "Q1KCO", "Q1DCT", "Q1DOC", "Q1MCU", "Q1UKID", "Q1PRCS" })
    };
}
