using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470561W - .
/// </summary>
public class F470561W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D2EDTY.
        /// </summary>
        public const string D2EDTY = "D2EDTY";

        /// <summary>
        /// D2EDSQ.
        /// </summary>
        public const string D2EDSQ = "D2EDSQ";

        /// <summary>
        /// D2EKCO.
        /// </summary>
        public const string D2EKCO = "D2EKCO";

        /// <summary>
        /// D2EDOC.
        /// </summary>
        public const string D2EDOC = "D2EDOC";

        /// <summary>
        /// D2EDCT.
        /// </summary>
        public const string D2EDCT = "D2EDCT";

        /// <summary>
        /// D2EDLN.
        /// </summary>
        public const string D2EDLN = "D2EDLN";

        /// <summary>
        /// D2EDSP.
        /// </summary>
        public const string D2EDSP = "D2EDSP";

        /// <summary>
        /// D2EDBT.
        /// </summary>
        public const string D2EDBT = "D2EDBT";

        /// <summary>
        /// D2ICU.
        /// </summary>
        public const string D2ICU = "D2ICU";

        /// <summary>
        /// D2ADD6.
        /// </summary>
        public const string D2ADD6 = "D2ADD6";

        /// <summary>
        /// D2ADDS.
        /// </summary>
        public const string D2ADDS = "D2ADDS";

        /// <summary>
        /// D2ICUT.
        /// </summary>
        public const string D2ICUT = "D2ICUT";

        /// <summary>
        /// D2NAID.
        /// </summary>
        public const string D2NAID = "D2NAID";

        /// <summary>
        /// D2KCO.
        /// </summary>
        public const string D2KCO = "D2KCO";

        /// <summary>
        /// D2CO.
        /// </summary>
        public const string D2CO = "D2CO";

        /// <summary>
        /// D2MCU.
        /// </summary>
        public const string D2MCU = "D2MCU";

        /// <summary>
        /// D2DOCM.
        /// </summary>
        public const string D2DOCM = "D2DOCM";

        /// <summary>
        /// D2DCTM.
        /// </summary>
        public const string D2DCTM = "D2DCTM";

        /// <summary>
        /// D2SFXM.
        /// </summary>
        public const string D2SFXM = "D2SFXM";

        /// <summary>
        /// D2AN8.
        /// </summary>
        public const string D2AN8 = "D2AN8";

        /// <summary>
        /// D2AR1.
        /// </summary>
        public const string D2AR1 = "D2AR1";

        /// <summary>
        /// D2PH1.
        /// </summary>
        public const string D2PH1 = "D2PH1";

        /// <summary>
        /// D2AR2.
        /// </summary>
        public const string D2AR2 = "D2AR2";

        /// <summary>
        /// D2PH2.
        /// </summary>
        public const string D2PH2 = "D2PH2";

        /// <summary>
        /// D2ALPH.
        /// </summary>
        public const string D2ALPH = "D2ALPH";

        /// <summary>
        /// D2ADD1.
        /// </summary>
        public const string D2ADD1 = "D2ADD1";

        /// <summary>
        /// D2ADD2.
        /// </summary>
        public const string D2ADD2 = "D2ADD2";

        /// <summary>
        /// D2ADD3.
        /// </summary>
        public const string D2ADD3 = "D2ADD3";

        /// <summary>
        /// D2ADD4.
        /// </summary>
        public const string D2ADD4 = "D2ADD4";

        /// <summary>
        /// D2ADD5.
        /// </summary>
        public const string D2ADD5 = "D2ADD5";

        /// <summary>
        /// D2ADDZ.
        /// </summary>
        public const string D2ADDZ = "D2ADDZ";

        /// <summary>
        /// D2CTR.
        /// </summary>
        public const string D2CTR = "D2CTR";

        /// <summary>
        /// D2EDCI.
        /// </summary>
        public const string D2EDCI = "D2EDCI";

        /// <summary>
        /// D2IDC.
        /// </summary>
        public const string D2IDC = "D2IDC";

        /// <summary>
        /// D2DL01.
        /// </summary>
        public const string D2DL01 = "D2DL01";

        /// <summary>
        /// D2CBNK.
        /// </summary>
        public const string D2CBNK = "D2CBNK";

        /// <summary>
        /// D2TNST.
        /// </summary>
        public const string D2TNST = "D2TNST";

        /// <summary>
        /// D2CHKD.
        /// </summary>
        public const string D2CHKD = "D2CHKD";

        /// <summary>
        /// D2TORG.
        /// </summary>
        public const string D2TORG = "D2TORG";

        /// <summary>
        /// D2USER.
        /// </summary>
        public const string D2USER = "D2USER";

        /// <summary>
        /// D2PID.
        /// </summary>
        public const string D2PID = "D2PID";

        /// <summary>
        /// D2JOBN.
        /// </summary>
        public const string D2JOBN = "D2JOBN";

        /// <summary>
        /// D2UPMJ.
        /// </summary>
        public const string D2UPMJ = "D2UPMJ";

        /// <summary>
        /// D2TDAY.
        /// </summary>
        public const string D2TDAY = "D2TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470561W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D2EDTY", "D2EDTY", JdeDataType.String, 2, true, true),
        new JdeField("D2EDSQ", "D2EDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D2EKCO", "D2EKCO", JdeDataType.String, 10, true, true),
        new JdeField("D2EDOC", "D2EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D2EDCT", "D2EDCT", JdeDataType.String, 4, true, true),
        new JdeField("D2EDLN", "D2EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("D2EDSP", "D2EDSP", JdeDataType.String, 2),
        new JdeField("D2EDBT", "D2EDBT", JdeDataType.String, 30),
        new JdeField("D2ICU", "D2ICU", JdeDataType.Numeric),
        new JdeField("D2ADD6", "D2ADD6", JdeDataType.String, 80),
        new JdeField("D2ADDS", "D2ADDS", JdeDataType.String, 6),
        new JdeField("D2ICUT", "D2ICUT", JdeDataType.String, 4),
        new JdeField("D2NAID", "D2NAID", JdeDataType.String, 2),
        new JdeField("D2KCO", "D2KCO", JdeDataType.String, 10),
        new JdeField("D2CO", "D2CO", JdeDataType.String, 10),
        new JdeField("D2MCU", "D2MCU", JdeDataType.String, 24),
        new JdeField("D2DOCM", "D2DOCM", JdeDataType.Numeric),
        new JdeField("D2DCTM", "D2DCTM", JdeDataType.String, 4),
        new JdeField("D2SFXM", "D2SFXM", JdeDataType.String, 6),
        new JdeField("D2AN8", "D2AN8", JdeDataType.Numeric),
        new JdeField("D2AR1", "D2AR1", JdeDataType.String, 12),
        new JdeField("D2PH1", "D2PH1", JdeDataType.String, 40),
        new JdeField("D2AR2", "D2AR2", JdeDataType.String, 12),
        new JdeField("D2PH2", "D2PH2", JdeDataType.String, 40),
        new JdeField("D2ALPH", "D2ALPH", JdeDataType.String, 80),
        new JdeField("D2ADD1", "D2ADD1", JdeDataType.String, 80),
        new JdeField("D2ADD2", "D2ADD2", JdeDataType.String, 80),
        new JdeField("D2ADD3", "D2ADD3", JdeDataType.String, 80),
        new JdeField("D2ADD4", "D2ADD4", JdeDataType.String, 80),
        new JdeField("D2ADD5", "D2ADD5", JdeDataType.String, 80),
        new JdeField("D2ADDZ", "D2ADDZ", JdeDataType.String, 24),
        new JdeField("D2CTR", "D2CTR", JdeDataType.String, 6),
        new JdeField("D2EDCI", "D2EDCI", JdeDataType.String, 2),
        new JdeField("D2IDC", "D2IDC", JdeDataType.String, 20),
        new JdeField("D2DL01", "D2DL01", JdeDataType.String, 60),
        new JdeField("D2CBNK", "D2CBNK", JdeDataType.String, 40),
        new JdeField("D2TNST", "D2TNST", JdeDataType.String, 40),
        new JdeField("D2CHKD", "D2CHKD", JdeDataType.String, 4),
        new JdeField("D2TORG", "D2TORG", JdeDataType.String, 20),
        new JdeField("D2USER", "D2USER", JdeDataType.String, 20),
        new JdeField("D2PID", "D2PID", JdeDataType.String, 20),
        new JdeField("D2JOBN", "D2JOBN", JdeDataType.String, 20),
        new JdeField("D2UPMJ", "D2UPMJ", JdeDataType.Numeric),
        new JdeField("D2TDAY", "D2TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470561W_0", "Primary Key on D2EDTY, D2EDSQ, D2EKCO, D2EDOC, D2EDCT, D2EDLN", new[] { "D2EDTY", "D2EDSQ", "D2EKCO", "D2EDOC", "D2EDCT", "D2EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
