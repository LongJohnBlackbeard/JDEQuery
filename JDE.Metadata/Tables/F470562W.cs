using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470562W - .
/// </summary>
public class F470562W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D4EDTY.
        /// </summary>
        public const string D4EDTY = "D4EDTY";

        /// <summary>
        /// D4EDSQ.
        /// </summary>
        public const string D4EDSQ = "D4EDSQ";

        /// <summary>
        /// D4EKCO.
        /// </summary>
        public const string D4EKCO = "D4EKCO";

        /// <summary>
        /// D4EDOC.
        /// </summary>
        public const string D4EDOC = "D4EDOC";

        /// <summary>
        /// D4EDCT.
        /// </summary>
        public const string D4EDCT = "D4EDCT";

        /// <summary>
        /// D4EDLN.
        /// </summary>
        public const string D4EDLN = "D4EDLN";

        /// <summary>
        /// D4EDSP.
        /// </summary>
        public const string D4EDSP = "D4EDSP";

        /// <summary>
        /// D4EDBT.
        /// </summary>
        public const string D4EDBT = "D4EDBT";

        /// <summary>
        /// D4ICU.
        /// </summary>
        public const string D4ICU = "D4ICU";

        /// <summary>
        /// D4ICUT.
        /// </summary>
        public const string D4ICUT = "D4ICUT";

        /// <summary>
        /// D4KCO.
        /// </summary>
        public const string D4KCO = "D4KCO";

        /// <summary>
        /// D4CO.
        /// </summary>
        public const string D4CO = "D4CO";

        /// <summary>
        /// D4MCU.
        /// </summary>
        public const string D4MCU = "D4MCU";

        /// <summary>
        /// D4DOCM.
        /// </summary>
        public const string D4DOCM = "D4DOCM";

        /// <summary>
        /// D4DCTM.
        /// </summary>
        public const string D4DCTM = "D4DCTM";

        /// <summary>
        /// D4SFXM.
        /// </summary>
        public const string D4SFXM = "D4SFXM";

        /// <summary>
        /// D4NAID.
        /// </summary>
        public const string D4NAID = "D4NAID";

        /// <summary>
        /// D4AN8.
        /// </summary>
        public const string D4AN8 = "D4AN8";

        /// <summary>
        /// D4AR1.
        /// </summary>
        public const string D4AR1 = "D4AR1";

        /// <summary>
        /// D4PH1.
        /// </summary>
        public const string D4PH1 = "D4PH1";

        /// <summary>
        /// D4AR2.
        /// </summary>
        public const string D4AR2 = "D4AR2";

        /// <summary>
        /// D4PH2.
        /// </summary>
        public const string D4PH2 = "D4PH2";

        /// <summary>
        /// D4ALPH.
        /// </summary>
        public const string D4ALPH = "D4ALPH";

        /// <summary>
        /// D4ADD1.
        /// </summary>
        public const string D4ADD1 = "D4ADD1";

        /// <summary>
        /// D4ADD2.
        /// </summary>
        public const string D4ADD2 = "D4ADD2";

        /// <summary>
        /// D4ADD3.
        /// </summary>
        public const string D4ADD3 = "D4ADD3";

        /// <summary>
        /// D4ADD4.
        /// </summary>
        public const string D4ADD4 = "D4ADD4";

        /// <summary>
        /// D4ADD5.
        /// </summary>
        public const string D4ADD5 = "D4ADD5";

        /// <summary>
        /// D4ADD6.
        /// </summary>
        public const string D4ADD6 = "D4ADD6";

        /// <summary>
        /// D4ADDS.
        /// </summary>
        public const string D4ADDS = "D4ADDS";

        /// <summary>
        /// D4ADDZ.
        /// </summary>
        public const string D4ADDZ = "D4ADDZ";

        /// <summary>
        /// D4CTR.
        /// </summary>
        public const string D4CTR = "D4CTR";

        /// <summary>
        /// D4EDCI.
        /// </summary>
        public const string D4EDCI = "D4EDCI";

        /// <summary>
        /// D4IDC.
        /// </summary>
        public const string D4IDC = "D4IDC";

        /// <summary>
        /// D4DL01.
        /// </summary>
        public const string D4DL01 = "D4DL01";

        /// <summary>
        /// D4CBNK.
        /// </summary>
        public const string D4CBNK = "D4CBNK";

        /// <summary>
        /// D4TNST.
        /// </summary>
        public const string D4TNST = "D4TNST";

        /// <summary>
        /// D4CHKD.
        /// </summary>
        public const string D4CHKD = "D4CHKD";

        /// <summary>
        /// D4TORG.
        /// </summary>
        public const string D4TORG = "D4TORG";

        /// <summary>
        /// D4USER.
        /// </summary>
        public const string D4USER = "D4USER";

        /// <summary>
        /// D4PID.
        /// </summary>
        public const string D4PID = "D4PID";

        /// <summary>
        /// D4JOBN.
        /// </summary>
        public const string D4JOBN = "D4JOBN";

        /// <summary>
        /// D4UPMJ.
        /// </summary>
        public const string D4UPMJ = "D4UPMJ";

        /// <summary>
        /// D4TDAY.
        /// </summary>
        public const string D4TDAY = "D4TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470562W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D4EDTY", "D4EDTY", JdeDataType.String, 2, true, true),
        new JdeField("D4EDSQ", "D4EDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D4EKCO", "D4EKCO", JdeDataType.String, 10, true, true),
        new JdeField("D4EDOC", "D4EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D4EDCT", "D4EDCT", JdeDataType.String, 4, true, true),
        new JdeField("D4EDLN", "D4EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("D4EDSP", "D4EDSP", JdeDataType.String, 2),
        new JdeField("D4EDBT", "D4EDBT", JdeDataType.String, 30),
        new JdeField("D4ICU", "D4ICU", JdeDataType.Numeric),
        new JdeField("D4ICUT", "D4ICUT", JdeDataType.String, 4),
        new JdeField("D4KCO", "D4KCO", JdeDataType.String, 10),
        new JdeField("D4CO", "D4CO", JdeDataType.String, 10),
        new JdeField("D4MCU", "D4MCU", JdeDataType.String, 24),
        new JdeField("D4DOCM", "D4DOCM", JdeDataType.Numeric),
        new JdeField("D4DCTM", "D4DCTM", JdeDataType.String, 4),
        new JdeField("D4SFXM", "D4SFXM", JdeDataType.String, 6),
        new JdeField("D4NAID", "D4NAID", JdeDataType.String, 2),
        new JdeField("D4AN8", "D4AN8", JdeDataType.Numeric),
        new JdeField("D4AR1", "D4AR1", JdeDataType.String, 12),
        new JdeField("D4PH1", "D4PH1", JdeDataType.String, 40),
        new JdeField("D4AR2", "D4AR2", JdeDataType.String, 12),
        new JdeField("D4PH2", "D4PH2", JdeDataType.String, 40),
        new JdeField("D4ALPH", "D4ALPH", JdeDataType.String, 80),
        new JdeField("D4ADD1", "D4ADD1", JdeDataType.String, 80),
        new JdeField("D4ADD2", "D4ADD2", JdeDataType.String, 80),
        new JdeField("D4ADD3", "D4ADD3", JdeDataType.String, 80),
        new JdeField("D4ADD4", "D4ADD4", JdeDataType.String, 80),
        new JdeField("D4ADD5", "D4ADD5", JdeDataType.String, 80),
        new JdeField("D4ADD6", "D4ADD6", JdeDataType.String, 80),
        new JdeField("D4ADDS", "D4ADDS", JdeDataType.String, 6),
        new JdeField("D4ADDZ", "D4ADDZ", JdeDataType.String, 24),
        new JdeField("D4CTR", "D4CTR", JdeDataType.String, 6),
        new JdeField("D4EDCI", "D4EDCI", JdeDataType.String, 2),
        new JdeField("D4IDC", "D4IDC", JdeDataType.String, 20),
        new JdeField("D4DL01", "D4DL01", JdeDataType.String, 60),
        new JdeField("D4CBNK", "D4CBNK", JdeDataType.String, 40),
        new JdeField("D4TNST", "D4TNST", JdeDataType.String, 40),
        new JdeField("D4CHKD", "D4CHKD", JdeDataType.String, 4),
        new JdeField("D4TORG", "D4TORG", JdeDataType.String, 20),
        new JdeField("D4USER", "D4USER", JdeDataType.String, 20),
        new JdeField("D4PID", "D4PID", JdeDataType.String, 20),
        new JdeField("D4JOBN", "D4JOBN", JdeDataType.String, 20),
        new JdeField("D4UPMJ", "D4UPMJ", JdeDataType.Numeric),
        new JdeField("D4TDAY", "D4TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470562W_0", "Primary Key on D4EDTY, D4EDSQ, D4EKCO, D4EDOC, D4EDCT, D4EDLN", new[] { "D4EDTY", "D4EDSQ", "D4EKCO", "D4EDOC", "D4EDCT", "D4EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
