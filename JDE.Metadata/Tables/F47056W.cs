using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47056W - .
/// </summary>
public class F47056W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1EDTY.
        /// </summary>
        public const string D1EDTY = "D1EDTY";

        /// <summary>
        /// D1EDSQ.
        /// </summary>
        public const string D1EDSQ = "D1EDSQ";

        /// <summary>
        /// D1EKCO.
        /// </summary>
        public const string D1EKCO = "D1EKCO";

        /// <summary>
        /// D1EDOC.
        /// </summary>
        public const string D1EDOC = "D1EDOC";

        /// <summary>
        /// D1EDCT.
        /// </summary>
        public const string D1EDCT = "D1EDCT";

        /// <summary>
        /// D1EDLN.
        /// </summary>
        public const string D1EDLN = "D1EDLN";

        /// <summary>
        /// D1EDST.
        /// </summary>
        public const string D1EDST = "D1EDST";

        /// <summary>
        /// D1EDFT.
        /// </summary>
        public const string D1EDFT = "D1EDFT";

        /// <summary>
        /// D1EDDT.
        /// </summary>
        public const string D1EDDT = "D1EDDT";

        /// <summary>
        /// D1EDER.
        /// </summary>
        public const string D1EDER = "D1EDER";

        /// <summary>
        /// D1EDDL.
        /// </summary>
        public const string D1EDDL = "D1EDDL";

        /// <summary>
        /// D1EDSP.
        /// </summary>
        public const string D1EDSP = "D1EDSP";

        /// <summary>
        /// D1EDBT.
        /// </summary>
        public const string D1EDBT = "D1EDBT";

        /// <summary>
        /// D1PNID.
        /// </summary>
        public const string D1PNID = "D1PNID";

        /// <summary>
        /// D1ICU.
        /// </summary>
        public const string D1ICU = "D1ICU";

        /// <summary>
        /// D1ICUT.
        /// </summary>
        public const string D1ICUT = "D1ICUT";

        /// <summary>
        /// D1KCO.
        /// </summary>
        public const string D1KCO = "D1KCO";

        /// <summary>
        /// D1CO.
        /// </summary>
        public const string D1CO = "D1CO";

        /// <summary>
        /// D1MCU.
        /// </summary>
        public const string D1MCU = "D1MCU";

        /// <summary>
        /// D1DOCM.
        /// </summary>
        public const string D1DOCM = "D1DOCM";

        /// <summary>
        /// D1DCTM.
        /// </summary>
        public const string D1DCTM = "D1DCTM";

        /// <summary>
        /// D1SFXM.
        /// </summary>
        public const string D1SFXM = "D1SFXM";

        /// <summary>
        /// D1DMTJ.
        /// </summary>
        public const string D1DMTJ = "D1DMTJ";

        /// <summary>
        /// D1PYIN.
        /// </summary>
        public const string D1PYIN = "D1PYIN";

        /// <summary>
        /// D1PRMK.
        /// </summary>
        public const string D1PRMK = "D1PRMK";

        /// <summary>
        /// D1AN8.
        /// </summary>
        public const string D1AN8 = "D1AN8";

        /// <summary>
        /// D1PA8.
        /// </summary>
        public const string D1PA8 = "D1PA8";

        /// <summary>
        /// D1CRRM.
        /// </summary>
        public const string D1CRRM = "D1CRRM";

        /// <summary>
        /// D1DMCD.
        /// </summary>
        public const string D1DMCD = "D1DMCD";

        /// <summary>
        /// D1CRCD.
        /// </summary>
        public const string D1CRCD = "D1CRCD";

        /// <summary>
        /// D1CDEC.
        /// </summary>
        public const string D1CDEC = "D1CDEC";

        /// <summary>
        /// D1CRR.
        /// </summary>
        public const string D1CRR = "D1CRR";

        /// <summary>
        /// D1THCD.
        /// </summary>
        public const string D1THCD = "D1THCD";

        /// <summary>
        /// D1DGJ.
        /// </summary>
        public const string D1DGJ = "D1DGJ";

        /// <summary>
        /// D1FY.
        /// </summary>
        public const string D1FY = "D1FY";

        /// <summary>
        /// D1CTRY.
        /// </summary>
        public const string D1CTRY = "D1CTRY";

        /// <summary>
        /// D1PN.
        /// </summary>
        public const string D1PN = "D1PN";

        /// <summary>
        /// D1TTOT.
        /// </summary>
        public const string D1TTOT = "D1TTOT";

        /// <summary>
        /// D1AC01.
        /// </summary>
        public const string D1AC01 = "D1AC01";

        /// <summary>
        /// D1AC02.
        /// </summary>
        public const string D1AC02 = "D1AC02";

        /// <summary>
        /// D1AC03.
        /// </summary>
        public const string D1AC03 = "D1AC03";

        /// <summary>
        /// D1AC04.
        /// </summary>
        public const string D1AC04 = "D1AC04";

        /// <summary>
        /// D1AC05.
        /// </summary>
        public const string D1AC05 = "D1AC05";

        /// <summary>
        /// D1AC06.
        /// </summary>
        public const string D1AC06 = "D1AC06";

        /// <summary>
        /// D1AC07.
        /// </summary>
        public const string D1AC07 = "D1AC07";

        /// <summary>
        /// D1AC08.
        /// </summary>
        public const string D1AC08 = "D1AC08";

        /// <summary>
        /// D1AC09.
        /// </summary>
        public const string D1AC09 = "D1AC09";

        /// <summary>
        /// D1AC10.
        /// </summary>
        public const string D1AC10 = "D1AC10";

        /// <summary>
        /// D1ATE.
        /// </summary>
        public const string D1ATE = "D1ATE";

        /// <summary>
        /// D1ATR.
        /// </summary>
        public const string D1ATR = "D1ATR";

        /// <summary>
        /// D1ATP.
        /// </summary>
        public const string D1ATP = "D1ATP";

        /// <summary>
        /// D1ATO.
        /// </summary>
        public const string D1ATO = "D1ATO";

        /// <summary>
        /// D1ATPR.
        /// </summary>
        public const string D1ATPR = "D1ATPR";

        /// <summary>
        /// D1AT1.
        /// </summary>
        public const string D1AT1 = "D1AT1";

        /// <summary>
        /// D1AT2.
        /// </summary>
        public const string D1AT2 = "D1AT2";

        /// <summary>
        /// D1AT3.
        /// </summary>
        public const string D1AT3 = "D1AT3";

        /// <summary>
        /// D1AT4.
        /// </summary>
        public const string D1AT4 = "D1AT4";

        /// <summary>
        /// D1AT5.
        /// </summary>
        public const string D1AT5 = "D1AT5";

        /// <summary>
        /// D1TNN.
        /// </summary>
        public const string D1TNN = "D1TNN";

        /// <summary>
        /// D1URCD.
        /// </summary>
        public const string D1URCD = "D1URCD";

        /// <summary>
        /// D1URDT.
        /// </summary>
        public const string D1URDT = "D1URDT";

        /// <summary>
        /// D1URAT.
        /// </summary>
        public const string D1URAT = "D1URAT";

        /// <summary>
        /// D1URAB.
        /// </summary>
        public const string D1URAB = "D1URAB";

        /// <summary>
        /// D1URRF.
        /// </summary>
        public const string D1URRF = "D1URRF";

        /// <summary>
        /// D1TORG.
        /// </summary>
        public const string D1TORG = "D1TORG";

        /// <summary>
        /// D1USER.
        /// </summary>
        public const string D1USER = "D1USER";

        /// <summary>
        /// D1PID.
        /// </summary>
        public const string D1PID = "D1PID";

        /// <summary>
        /// D1JOBN.
        /// </summary>
        public const string D1JOBN = "D1JOBN";

        /// <summary>
        /// D1UPMJ.
        /// </summary>
        public const string D1UPMJ = "D1UPMJ";

        /// <summary>
        /// D1TDAY.
        /// </summary>
        public const string D1TDAY = "D1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47056W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1EDTY", "D1EDTY", JdeDataType.String, 2, true, true),
        new JdeField("D1EDSQ", "D1EDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D1EKCO", "D1EKCO", JdeDataType.String, 10, true, true),
        new JdeField("D1EDOC", "D1EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D1EDCT", "D1EDCT", JdeDataType.String, 4, true, true),
        new JdeField("D1EDLN", "D1EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("D1EDST", "D1EDST", JdeDataType.String, 12),
        new JdeField("D1EDFT", "D1EDFT", JdeDataType.String, 20),
        new JdeField("D1EDDT", "D1EDDT", JdeDataType.Numeric),
        new JdeField("D1EDER", "D1EDER", JdeDataType.String, 2),
        new JdeField("D1EDDL", "D1EDDL", JdeDataType.Numeric),
        new JdeField("D1EDSP", "D1EDSP", JdeDataType.String, 2),
        new JdeField("D1EDBT", "D1EDBT", JdeDataType.String, 30),
        new JdeField("D1PNID", "D1PNID", JdeDataType.String, 30),
        new JdeField("D1ICU", "D1ICU", JdeDataType.Numeric),
        new JdeField("D1ICUT", "D1ICUT", JdeDataType.String, 4),
        new JdeField("D1KCO", "D1KCO", JdeDataType.String, 10),
        new JdeField("D1CO", "D1CO", JdeDataType.String, 10),
        new JdeField("D1MCU", "D1MCU", JdeDataType.String, 24),
        new JdeField("D1DOCM", "D1DOCM", JdeDataType.Numeric),
        new JdeField("D1DCTM", "D1DCTM", JdeDataType.String, 4),
        new JdeField("D1SFXM", "D1SFXM", JdeDataType.String, 6),
        new JdeField("D1DMTJ", "D1DMTJ", JdeDataType.Numeric),
        new JdeField("D1PYIN", "D1PYIN", JdeDataType.String, 2),
        new JdeField("D1PRMK", "D1PRMK", JdeDataType.String, 20),
        new JdeField("D1AN8", "D1AN8", JdeDataType.Numeric),
        new JdeField("D1PA8", "D1PA8", JdeDataType.Numeric),
        new JdeField("D1CRRM", "D1CRRM", JdeDataType.String, 2),
        new JdeField("D1DMCD", "D1DMCD", JdeDataType.String, 2),
        new JdeField("D1CRCD", "D1CRCD", JdeDataType.String, 6),
        new JdeField("D1CDEC", "D1CDEC", JdeDataType.String, 2),
        new JdeField("D1CRR", "D1CRR", JdeDataType.Numeric),
        new JdeField("D1THCD", "D1THCD", JdeDataType.String, 2),
        new JdeField("D1DGJ", "D1DGJ", JdeDataType.Numeric),
        new JdeField("D1FY", "D1FY", JdeDataType.Numeric),
        new JdeField("D1CTRY", "D1CTRY", JdeDataType.Numeric),
        new JdeField("D1PN", "D1PN", JdeDataType.Numeric),
        new JdeField("D1TTOT", "D1TTOT", JdeDataType.Numeric),
        new JdeField("D1AC01", "D1AC01", JdeDataType.String, 6),
        new JdeField("D1AC02", "D1AC02", JdeDataType.String, 6),
        new JdeField("D1AC03", "D1AC03", JdeDataType.String, 6),
        new JdeField("D1AC04", "D1AC04", JdeDataType.String, 6),
        new JdeField("D1AC05", "D1AC05", JdeDataType.String, 6),
        new JdeField("D1AC06", "D1AC06", JdeDataType.String, 6),
        new JdeField("D1AC07", "D1AC07", JdeDataType.String, 6),
        new JdeField("D1AC08", "D1AC08", JdeDataType.String, 6),
        new JdeField("D1AC09", "D1AC09", JdeDataType.String, 6),
        new JdeField("D1AC10", "D1AC10", JdeDataType.String, 6),
        new JdeField("D1ATE", "D1ATE", JdeDataType.String, 2),
        new JdeField("D1ATR", "D1ATR", JdeDataType.String, 2),
        new JdeField("D1ATP", "D1ATP", JdeDataType.String, 2),
        new JdeField("D1ATO", "D1ATO", JdeDataType.String, 2),
        new JdeField("D1ATPR", "D1ATPR", JdeDataType.String, 2),
        new JdeField("D1AT1", "D1AT1", JdeDataType.String, 6),
        new JdeField("D1AT2", "D1AT2", JdeDataType.String, 2),
        new JdeField("D1AT3", "D1AT3", JdeDataType.String, 2),
        new JdeField("D1AT4", "D1AT4", JdeDataType.String, 2),
        new JdeField("D1AT5", "D1AT5", JdeDataType.String, 2),
        new JdeField("D1TNN", "D1TNN", JdeDataType.String, 2),
        new JdeField("D1URCD", "D1URCD", JdeDataType.String, 4),
        new JdeField("D1URDT", "D1URDT", JdeDataType.Numeric),
        new JdeField("D1URAT", "D1URAT", JdeDataType.Numeric),
        new JdeField("D1URAB", "D1URAB", JdeDataType.Numeric),
        new JdeField("D1URRF", "D1URRF", JdeDataType.String, 30),
        new JdeField("D1TORG", "D1TORG", JdeDataType.String, 20),
        new JdeField("D1USER", "D1USER", JdeDataType.String, 20),
        new JdeField("D1PID", "D1PID", JdeDataType.String, 20),
        new JdeField("D1JOBN", "D1JOBN", JdeDataType.String, 20),
        new JdeField("D1UPMJ", "D1UPMJ", JdeDataType.Numeric),
        new JdeField("D1TDAY", "D1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47056W_0", "Primary Key on D1EDTY, D1EDSQ, D1EKCO, D1EDOC, D1EDCT, D1EDLN", new[] { "D1EDTY", "D1EDSQ", "D1EKCO", "D1EDOC", "D1EDCT", "D1EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
