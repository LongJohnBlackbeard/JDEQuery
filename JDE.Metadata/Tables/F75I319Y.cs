using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I319Y - .
/// </summary>
public class F75I319Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1MCU.
        /// </summary>
        public const string Q1MCU = "Q1MCU";

        /// <summary>
        /// Q1YEXU.
        /// </summary>
        public const string Q1YEXU = "Q1YEXU";

        /// <summary>
        /// Q1DTE.
        /// </summary>
        public const string Q1DTE = "Q1DTE";

        /// <summary>
        /// Q1KCO.
        /// </summary>
        public const string Q1KCO = "Q1KCO";

        /// <summary>
        /// Q1DCT.
        /// </summary>
        public const string Q1DCT = "Q1DCT";

        /// <summary>
        /// Q1DOC.
        /// </summary>
        public const string Q1DOC = "Q1DOC";

        /// <summary>
        /// Q1DOD.
        /// </summary>
        public const string Q1DOD = "Q1DOD";

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
        /// Q1YCHN.
        /// </summary>
        public const string Q1YCHN = "Q1YCHN";

        /// <summary>
        /// Q1STKT.
        /// </summary>
        public const string Q1STKT = "Q1STKT";

        /// <summary>
        /// Q1TRQT.
        /// </summary>
        public const string Q1TRQT = "Q1TRQT";

        /// <summary>
        /// Q1KCOO.
        /// </summary>
        public const string Q1KCOO = "Q1KCOO";

        /// <summary>
        /// Q1DOCO.
        /// </summary>
        public const string Q1DOCO = "Q1DOCO";

        /// <summary>
        /// Q1DCTO.
        /// </summary>
        public const string Q1DCTO = "Q1DCTO";

        /// <summary>
        /// Q1LNID.
        /// </summary>
        public const string Q1LNID = "Q1LNID";

        /// <summary>
        /// Q1LOCN.
        /// </summary>
        public const string Q1LOCN = "Q1LOCN";

        /// <summary>
        /// Q1LOTN.
        /// </summary>
        public const string Q1LOTN = "Q1LOTN";

        /// <summary>
        /// Q1AN8.
        /// </summary>
        public const string Q1AN8 = "Q1AN8";

        /// <summary>
        /// Q1YGPN.
        /// </summary>
        public const string Q1YGPN = "Q1YGPN";

        /// <summary>
        /// Q1YGPD.
        /// </summary>
        public const string Q1YGPD = "Q1YGPD";

        /// <summary>
        /// Q1YEXA.
        /// </summary>
        public const string Q1YEXA = "Q1YEXA";

        /// <summary>
        /// Q1I75BED.
        /// </summary>
        public const string Q1I75BED = "Q1I75BED";

        /// <summary>
        /// Q1I75CESS.
        /// </summary>
        public const string Q1I75CESS = "Q1I75CESS";

        /// <summary>
        /// Q1I75AED.
        /// </summary>
        public const string Q1I75AED = "Q1I75AED";

        /// <summary>
        /// Q1ASVL.
        /// </summary>
        public const string Q1ASVL = "Q1ASVL";

        /// <summary>
        /// Q1I75SED.
        /// </summary>
        public const string Q1I75SED = "Q1I75SED";

        /// <summary>
        /// Q1YCDT.
        /// </summary>
        public const string Q1YCDT = "Q1YCDT";

        /// <summary>
        /// Q1YFLAG.
        /// </summary>
        public const string Q1YFLAG = "Q1YFLAG";

        /// <summary>
        /// Q1I75FTX1.
        /// </summary>
        public const string Q1I75FTX1 = "Q1I75FTX1";

        /// <summary>
        /// Q1I75FTX2.
        /// </summary>
        public const string Q1I75FTX2 = "Q1I75FTX2";

        /// <summary>
        /// Q1DCVD.
        /// </summary>
        public const string Q1DCVD = "Q1DCVD";

        /// <summary>
        /// Q1YTDU.
        /// </summary>
        public const string Q1YTDU = "Q1YTDU";

        /// <summary>
        /// Q1DCPER.
        /// </summary>
        public const string Q1DCPER = "Q1DCPER";

        /// <summary>
        /// Q1YODT.
        /// </summary>
        public const string Q1YODT = "Q1YODT";

        /// <summary>
        /// Q1TDAY.
        /// </summary>
        public const string Q1TDAY = "Q1TDAY";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1TORG.
        /// </summary>
        public const string Q1TORG = "Q1TORG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I319Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1MCU", "Q1MCU", JdeDataType.String, 24),
        new JdeField("Q1YEXU", "Q1YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1DTE", "Q1DTE", JdeDataType.Numeric),
        new JdeField("Q1KCO", "Q1KCO", JdeDataType.String, 10),
        new JdeField("Q1DCT", "Q1DCT", JdeDataType.String, 4),
        new JdeField("Q1DOC", "Q1DOC", JdeDataType.Numeric),
        new JdeField("Q1DOD", "Q1DOD", JdeDataType.Numeric),
        new JdeField("Q1ITM", "Q1ITM", JdeDataType.Numeric),
        new JdeField("Q1LITM", "Q1LITM", JdeDataType.String, 50),
        new JdeField("Q1AITM", "Q1AITM", JdeDataType.String, 50),
        new JdeField("Q1YCHN", "Q1YCHN", JdeDataType.String, 40),
        new JdeField("Q1STKT", "Q1STKT", JdeDataType.String, 2),
        new JdeField("Q1TRQT", "Q1TRQT", JdeDataType.Numeric),
        new JdeField("Q1KCOO", "Q1KCOO", JdeDataType.String, 10, true, true),
        new JdeField("Q1DOCO", "Q1DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1DCTO", "Q1DCTO", JdeDataType.String, 4, true, true),
        new JdeField("Q1LNID", "Q1LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1LOCN", "Q1LOCN", JdeDataType.String, 40),
        new JdeField("Q1LOTN", "Q1LOTN", JdeDataType.String, 60),
        new JdeField("Q1AN8", "Q1AN8", JdeDataType.Numeric),
        new JdeField("Q1YGPN", "Q1YGPN", JdeDataType.String, 24),
        new JdeField("Q1YGPD", "Q1YGPD", JdeDataType.Numeric),
        new JdeField("Q1YEXA", "Q1YEXA", JdeDataType.Numeric),
        new JdeField("Q1I75BED", "Q1I75BED", JdeDataType.Numeric),
        new JdeField("Q1I75CESS", "Q1I75CESS", JdeDataType.Numeric),
        new JdeField("Q1I75AED", "Q1I75AED", JdeDataType.Numeric),
        new JdeField("Q1ASVL", "Q1ASVL", JdeDataType.Numeric),
        new JdeField("Q1I75SED", "Q1I75SED", JdeDataType.Numeric),
        new JdeField("Q1YCDT", "Q1YCDT", JdeDataType.Numeric),
        new JdeField("Q1YFLAG", "Q1YFLAG", JdeDataType.String, 2),
        new JdeField("Q1I75FTX1", "Q1I75FTX1", JdeDataType.Numeric),
        new JdeField("Q1I75FTX2", "Q1I75FTX2", JdeDataType.Numeric),
        new JdeField("Q1DCVD", "Q1DCVD", JdeDataType.Numeric),
        new JdeField("Q1YTDU", "Q1YTDU", JdeDataType.Numeric),
        new JdeField("Q1DCPER", "Q1DCPER", JdeDataType.Numeric),
        new JdeField("Q1YODT", "Q1YODT", JdeDataType.Numeric),
        new JdeField("Q1TDAY", "Q1TDAY", JdeDataType.Numeric),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1TORG", "Q1TORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I319Y_0", "Primary Key on Q1YEXU, Q1KCOO, Q1DOCO, Q1DCTO, Q1LNID", new[] { "Q1YEXU", "Q1KCOO", "Q1DOCO", "Q1DCTO", "Q1LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
