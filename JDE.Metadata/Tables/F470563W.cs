using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470563W - .
/// </summary>
public class F470563W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D5EDTY.
        /// </summary>
        public const string D5EDTY = "D5EDTY";

        /// <summary>
        /// D5EDSQ.
        /// </summary>
        public const string D5EDSQ = "D5EDSQ";

        /// <summary>
        /// D5EKCO.
        /// </summary>
        public const string D5EKCO = "D5EKCO";

        /// <summary>
        /// D5EDOC.
        /// </summary>
        public const string D5EDOC = "D5EDOC";

        /// <summary>
        /// D5EDCT.
        /// </summary>
        public const string D5EDCT = "D5EDCT";

        /// <summary>
        /// D5EDLN.
        /// </summary>
        public const string D5EDLN = "D5EDLN";

        /// <summary>
        /// D5EDSP.
        /// </summary>
        public const string D5EDSP = "D5EDSP";

        /// <summary>
        /// D5EDBT.
        /// </summary>
        public const string D5EDBT = "D5EDBT";

        /// <summary>
        /// D5ICU.
        /// </summary>
        public const string D5ICU = "D5ICU";

        /// <summary>
        /// D5ICUT.
        /// </summary>
        public const string D5ICUT = "D5ICUT";

        /// <summary>
        /// D5KCO.
        /// </summary>
        public const string D5KCO = "D5KCO";

        /// <summary>
        /// D5CO.
        /// </summary>
        public const string D5CO = "D5CO";

        /// <summary>
        /// D5MCU.
        /// </summary>
        public const string D5MCU = "D5MCU";

        /// <summary>
        /// D5DOCM.
        /// </summary>
        public const string D5DOCM = "D5DOCM";

        /// <summary>
        /// D5DCTM.
        /// </summary>
        public const string D5DCTM = "D5DCTM";

        /// <summary>
        /// D5SFXM.
        /// </summary>
        public const string D5SFXM = "D5SFXM";

        /// <summary>
        /// D5NAID.
        /// </summary>
        public const string D5NAID = "D5NAID";

        /// <summary>
        /// D5AN8.
        /// </summary>
        public const string D5AN8 = "D5AN8";

        /// <summary>
        /// D5AR1.
        /// </summary>
        public const string D5AR1 = "D5AR1";

        /// <summary>
        /// D5PH1.
        /// </summary>
        public const string D5PH1 = "D5PH1";

        /// <summary>
        /// D5AR2.
        /// </summary>
        public const string D5AR2 = "D5AR2";

        /// <summary>
        /// D5PH2.
        /// </summary>
        public const string D5PH2 = "D5PH2";

        /// <summary>
        /// D5ALPH.
        /// </summary>
        public const string D5ALPH = "D5ALPH";

        /// <summary>
        /// D5ADD1.
        /// </summary>
        public const string D5ADD1 = "D5ADD1";

        /// <summary>
        /// D5ADD2.
        /// </summary>
        public const string D5ADD2 = "D5ADD2";

        /// <summary>
        /// D5ADD3.
        /// </summary>
        public const string D5ADD3 = "D5ADD3";

        /// <summary>
        /// D5ADD4.
        /// </summary>
        public const string D5ADD4 = "D5ADD4";

        /// <summary>
        /// D5ADD5.
        /// </summary>
        public const string D5ADD5 = "D5ADD5";

        /// <summary>
        /// D5ADD6.
        /// </summary>
        public const string D5ADD6 = "D5ADD6";

        /// <summary>
        /// D5ADDS.
        /// </summary>
        public const string D5ADDS = "D5ADDS";

        /// <summary>
        /// D5ADDZ.
        /// </summary>
        public const string D5ADDZ = "D5ADDZ";

        /// <summary>
        /// D5CTR.
        /// </summary>
        public const string D5CTR = "D5CTR";

        /// <summary>
        /// D5EDCI.
        /// </summary>
        public const string D5EDCI = "D5EDCI";

        /// <summary>
        /// D5IDC.
        /// </summary>
        public const string D5IDC = "D5IDC";

        /// <summary>
        /// D5DL01.
        /// </summary>
        public const string D5DL01 = "D5DL01";

        /// <summary>
        /// D5CBNK.
        /// </summary>
        public const string D5CBNK = "D5CBNK";

        /// <summary>
        /// D5TNST.
        /// </summary>
        public const string D5TNST = "D5TNST";

        /// <summary>
        /// D5CHKD.
        /// </summary>
        public const string D5CHKD = "D5CHKD";

        /// <summary>
        /// D5TORG.
        /// </summary>
        public const string D5TORG = "D5TORG";

        /// <summary>
        /// D5USER.
        /// </summary>
        public const string D5USER = "D5USER";

        /// <summary>
        /// D5PID.
        /// </summary>
        public const string D5PID = "D5PID";

        /// <summary>
        /// D5JOBN.
        /// </summary>
        public const string D5JOBN = "D5JOBN";

        /// <summary>
        /// D5UPMJ.
        /// </summary>
        public const string D5UPMJ = "D5UPMJ";

        /// <summary>
        /// D5TDAY.
        /// </summary>
        public const string D5TDAY = "D5TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470563W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D5EDTY", "D5EDTY", JdeDataType.String, 2, true, true),
        new JdeField("D5EDSQ", "D5EDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D5EKCO", "D5EKCO", JdeDataType.String, 10, true, true),
        new JdeField("D5EDOC", "D5EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D5EDCT", "D5EDCT", JdeDataType.String, 4, true, true),
        new JdeField("D5EDLN", "D5EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("D5EDSP", "D5EDSP", JdeDataType.String, 2),
        new JdeField("D5EDBT", "D5EDBT", JdeDataType.String, 30),
        new JdeField("D5ICU", "D5ICU", JdeDataType.Numeric),
        new JdeField("D5ICUT", "D5ICUT", JdeDataType.String, 4),
        new JdeField("D5KCO", "D5KCO", JdeDataType.String, 10),
        new JdeField("D5CO", "D5CO", JdeDataType.String, 10),
        new JdeField("D5MCU", "D5MCU", JdeDataType.String, 24),
        new JdeField("D5DOCM", "D5DOCM", JdeDataType.Numeric),
        new JdeField("D5DCTM", "D5DCTM", JdeDataType.String, 4),
        new JdeField("D5SFXM", "D5SFXM", JdeDataType.String, 6),
        new JdeField("D5NAID", "D5NAID", JdeDataType.String, 2),
        new JdeField("D5AN8", "D5AN8", JdeDataType.Numeric),
        new JdeField("D5AR1", "D5AR1", JdeDataType.String, 12),
        new JdeField("D5PH1", "D5PH1", JdeDataType.String, 40),
        new JdeField("D5AR2", "D5AR2", JdeDataType.String, 12),
        new JdeField("D5PH2", "D5PH2", JdeDataType.String, 40),
        new JdeField("D5ALPH", "D5ALPH", JdeDataType.String, 80),
        new JdeField("D5ADD1", "D5ADD1", JdeDataType.String, 80),
        new JdeField("D5ADD2", "D5ADD2", JdeDataType.String, 80),
        new JdeField("D5ADD3", "D5ADD3", JdeDataType.String, 80),
        new JdeField("D5ADD4", "D5ADD4", JdeDataType.String, 80),
        new JdeField("D5ADD5", "D5ADD5", JdeDataType.String, 80),
        new JdeField("D5ADD6", "D5ADD6", JdeDataType.String, 80),
        new JdeField("D5ADDS", "D5ADDS", JdeDataType.String, 6),
        new JdeField("D5ADDZ", "D5ADDZ", JdeDataType.String, 24),
        new JdeField("D5CTR", "D5CTR", JdeDataType.String, 6),
        new JdeField("D5EDCI", "D5EDCI", JdeDataType.String, 2),
        new JdeField("D5IDC", "D5IDC", JdeDataType.String, 20),
        new JdeField("D5DL01", "D5DL01", JdeDataType.String, 60),
        new JdeField("D5CBNK", "D5CBNK", JdeDataType.String, 40),
        new JdeField("D5TNST", "D5TNST", JdeDataType.String, 40),
        new JdeField("D5CHKD", "D5CHKD", JdeDataType.String, 4),
        new JdeField("D5TORG", "D5TORG", JdeDataType.String, 20),
        new JdeField("D5USER", "D5USER", JdeDataType.String, 20),
        new JdeField("D5PID", "D5PID", JdeDataType.String, 20),
        new JdeField("D5JOBN", "D5JOBN", JdeDataType.String, 20),
        new JdeField("D5UPMJ", "D5UPMJ", JdeDataType.Numeric),
        new JdeField("D5TDAY", "D5TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470563W_0", "Primary Key on D5EDTY, D5EDSQ, D5EKCO, D5EDOC, D5EDCT, D5EDLN", new[] { "D5EDTY", "D5EDSQ", "D5EKCO", "D5EDOC", "D5EDCT", "D5EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
