using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06350I - .
/// </summary>
public class F06350I : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y4RC.
        /// </summary>
        public const string Y4RC = "Y4RC";

        /// <summary>
        /// Y4YST.
        /// </summary>
        public const string Y4YST = "Y4YST";

        /// <summary>
        /// Y4AN8.
        /// </summary>
        public const string Y4AN8 = "Y4AN8";

        /// <summary>
        /// Y4PALF.
        /// </summary>
        public const string Y4PALF = "Y4PALF";

        /// <summary>
        /// Y4CKCN.
        /// </summary>
        public const string Y4CKCN = "Y4CKCN";

        /// <summary>
        /// Y4SCKC.
        /// </summary>
        public const string Y4SCKC = "Y4SCKC";

        /// <summary>
        /// Y4ATCM.
        /// </summary>
        public const string Y4ATCM = "Y4ATCM";

        /// <summary>
        /// Y4ICC.
        /// </summary>
        public const string Y4ICC = "Y4ICC";

        /// <summary>
        /// Y4ICS.
        /// </summary>
        public const string Y4ICS = "Y4ICS";

        /// <summary>
        /// Y4DOCM.
        /// </summary>
        public const string Y4DOCM = "Y4DOCM";

        /// <summary>
        /// Y4GLBA.
        /// </summary>
        public const string Y4GLBA = "Y4GLBA";

        /// <summary>
        /// Y4CKDT.
        /// </summary>
        public const string Y4CKDT = "Y4CKDT";

        /// <summary>
        /// Y4PPED.
        /// </summary>
        public const string Y4PPED = "Y4PPED";

        /// <summary>
        /// Y4PCK.
        /// </summary>
        public const string Y4PCK = "Y4PCK";

        /// <summary>
        /// Y4PDBA.
        /// </summary>
        public const string Y4PDBA = "Y4PDBA";

        /// <summary>
        /// Y4DISO.
        /// </summary>
        public const string Y4DISO = "Y4DISO";

        /// <summary>
        /// Y4PTCT.
        /// </summary>
        public const string Y4PTCT = "Y4PTCT";

        /// <summary>
        /// Y4PAYG.
        /// </summary>
        public const string Y4PAYG = "Y4PAYG";

        /// <summary>
        /// Y4PAYN.
        /// </summary>
        public const string Y4PAYN = "Y4PAYN";

        /// <summary>
        /// Y4PHRW.
        /// </summary>
        public const string Y4PHRW = "Y4PHRW";

        /// <summary>
        /// Y4PHRT.
        /// </summary>
        public const string Y4PHRT = "Y4PHRT";

        /// <summary>
        /// Y4SHRT.
        /// </summary>
        public const string Y4SHRT = "Y4SHRT";

        /// <summary>
        /// Y4PCUN.
        /// </summary>
        public const string Y4PCUN = "Y4PCUN";

        /// <summary>
        /// Y4UM.
        /// </summary>
        public const string Y4UM = "Y4UM";

        /// <summary>
        /// Y4PPRT.
        /// </summary>
        public const string Y4PPRT = "Y4PPRT";

        /// <summary>
        /// Y4GPA.
        /// </summary>
        public const string Y4GPA = "Y4GPA";

        /// <summary>
        /// Y4WE01.
        /// </summary>
        public const string Y4WE01 = "Y4WE01";

        /// <summary>
        /// Y4WX01.
        /// </summary>
        public const string Y4WX01 = "Y4WX01";

        /// <summary>
        /// Y4YTDG.
        /// </summary>
        public const string Y4YTDG = "Y4YTDG";

        /// <summary>
        /// Y4TARA.
        /// </summary>
        public const string Y4TARA = "Y4TARA";

        /// <summary>
        /// Y4PTAX.
        /// </summary>
        public const string Y4PTAX = "Y4PTAX";

        /// <summary>
        /// Y4G301.
        /// </summary>
        public const string Y4G301 = "Y4G301";

        /// <summary>
        /// Y4YTDT.
        /// </summary>
        public const string Y4YTDT = "Y4YTDT";

        /// <summary>
        /// Y4NPAY.
        /// </summary>
        public const string Y4NPAY = "Y4NPAY";

        /// <summary>
        /// Y4DLSH.
        /// </summary>
        public const string Y4DLSH = "Y4DLSH";

        /// <summary>
        /// Y4HMCO.
        /// </summary>
        public const string Y4HMCO = "Y4HMCO";

        /// <summary>
        /// Y4HMCU.
        /// </summary>
        public const string Y4HMCU = "Y4HMCU";

        /// <summary>
        /// Y4MAIL.
        /// </summary>
        public const string Y4MAIL = "Y4MAIL";

        /// <summary>
        /// Y4SG.
        /// </summary>
        public const string Y4SG = "Y4SG";

        /// <summary>
        /// Y4UN.
        /// </summary>
        public const string Y4UN = "Y4UN";

        /// <summary>
        /// Y4P001.
        /// </summary>
        public const string Y4P001 = "Y4P001";

        /// <summary>
        /// Y4P002.
        /// </summary>
        public const string Y4P002 = "Y4P002";

        /// <summary>
        /// Y4P003.
        /// </summary>
        public const string Y4P003 = "Y4P003";

        /// <summary>
        /// Y4P004.
        /// </summary>
        public const string Y4P004 = "Y4P004";

        /// <summary>
        /// Y4CBAC.
        /// </summary>
        public const string Y4CBAC = "Y4CBAC";

        /// <summary>
        /// Y4PYMH.
        /// </summary>
        public const string Y4PYMH = "Y4PYMH";

        /// <summary>
        /// Y4DTSP.
        /// </summary>
        public const string Y4DTSP = "Y4DTSP";

        /// <summary>
        /// Y4ICU.
        /// </summary>
        public const string Y4ICU = "Y4ICU";

        /// <summary>
        /// Y4THTY.
        /// </summary>
        public const string Y4THTY = "Y4THTY";

        /// <summary>
        /// Y4CKCS.
        /// </summary>
        public const string Y4CKCS = "Y4CKCS";

        /// <summary>
        /// Y4FOA#.
        /// </summary>
        public const string Y4FOA_ = "Y4FOA#";

        /// <summary>
        /// Y4SVH.
        /// </summary>
        public const string Y4SVH = "Y4SVH";

        /// <summary>
        /// Y4ADF.
        /// </summary>
        public const string Y4ADF = "Y4ADF";
    }

    /// <inheritdoc />
    public override string TableName => "F06350I";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y4RC", "Y4RC", JdeDataType.String, 2, true, true),
        new JdeField("Y4YST", "Y4YST", JdeDataType.String, 2),
        new JdeField("Y4AN8", "Y4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y4PALF", "Y4PALF", JdeDataType.String, 24),
        new JdeField("Y4CKCN", "Y4CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y4SCKC", "Y4SCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("Y4ATCM", "Y4ATCM", JdeDataType.String, 2),
        new JdeField("Y4ICC", "Y4ICC", JdeDataType.String, 2),
        new JdeField("Y4ICS", "Y4ICS", JdeDataType.String, 2),
        new JdeField("Y4DOCM", "Y4DOCM", JdeDataType.Numeric),
        new JdeField("Y4GLBA", "Y4GLBA", JdeDataType.String, 16),
        new JdeField("Y4CKDT", "Y4CKDT", JdeDataType.Numeric),
        new JdeField("Y4PPED", "Y4PPED", JdeDataType.Numeric),
        new JdeField("Y4PCK", "Y4PCK", JdeDataType.String, 2),
        new JdeField("Y4PDBA", "Y4PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y4DISO", "Y4DISO", JdeDataType.String, 2),
        new JdeField("Y4PTCT", "Y4PTCT", JdeDataType.String, 2),
        new JdeField("Y4PAYG", "Y4PAYG", JdeDataType.String, 2),
        new JdeField("Y4PAYN", "Y4PAYN", JdeDataType.String, 2),
        new JdeField("Y4PHRW", "Y4PHRW", JdeDataType.Numeric),
        new JdeField("Y4PHRT", "Y4PHRT", JdeDataType.Numeric),
        new JdeField("Y4SHRT", "Y4SHRT", JdeDataType.Numeric),
        new JdeField("Y4PCUN", "Y4PCUN", JdeDataType.Numeric),
        new JdeField("Y4UM", "Y4UM", JdeDataType.String, 4),
        new JdeField("Y4PPRT", "Y4PPRT", JdeDataType.Numeric),
        new JdeField("Y4GPA", "Y4GPA", JdeDataType.Numeric),
        new JdeField("Y4WE01", "Y4WE01", JdeDataType.Numeric),
        new JdeField("Y4WX01", "Y4WX01", JdeDataType.Numeric),
        new JdeField("Y4YTDG", "Y4YTDG", JdeDataType.Numeric),
        new JdeField("Y4TARA", "Y4TARA", JdeDataType.String, 20),
        new JdeField("Y4PTAX", "Y4PTAX", JdeDataType.String, 4),
        new JdeField("Y4G301", "Y4G301", JdeDataType.Numeric),
        new JdeField("Y4YTDT", "Y4YTDT", JdeDataType.Numeric),
        new JdeField("Y4NPAY", "Y4NPAY", JdeDataType.Numeric),
        new JdeField("Y4DLSH", "Y4DLSH", JdeDataType.String, 24),
        new JdeField("Y4HMCO", "Y4HMCO", JdeDataType.String, 10),
        new JdeField("Y4HMCU", "Y4HMCU", JdeDataType.String, 24),
        new JdeField("Y4MAIL", "Y4MAIL", JdeDataType.String, 20),
        new JdeField("Y4SG", "Y4SG", JdeDataType.String, 24),
        new JdeField("Y4UN", "Y4UN", JdeDataType.String, 12),
        new JdeField("Y4P001", "Y4P001", JdeDataType.String, 6),
        new JdeField("Y4P002", "Y4P002", JdeDataType.String, 6),
        new JdeField("Y4P003", "Y4P003", JdeDataType.String, 6),
        new JdeField("Y4P004", "Y4P004", JdeDataType.String, 6),
        new JdeField("Y4CBAC", "Y4CBAC", JdeDataType.Numeric),
        new JdeField("Y4PYMH", "Y4PYMH", JdeDataType.String, 2),
        new JdeField("Y4DTSP", "Y4DTSP", JdeDataType.Numeric),
        new JdeField("Y4ICU", "Y4ICU", JdeDataType.Numeric),
        new JdeField("Y4THTY", "Y4THTY", JdeDataType.String, 2),
        new JdeField("Y4CKCS", "Y4CKCS", JdeDataType.String, 30),
        new JdeField("Y4FOA#", "Y4FOA#", JdeDataType.String, 34),
        new JdeField("Y4SVH", "Y4SVH", JdeDataType.String, 2),
        new JdeField("Y4ADF", "Y4ADF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06350I_0", "Primary Key on Y4AN8, Y4CKCN, Y4PDBA, Y4RC, Y4SCKC", new[] { "Y4AN8", "Y4CKCN", "Y4PDBA", "Y4RC", "Y4SCKC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06350I_2", "Index on Y4AN8, Y4CKCN, SYS_NC00054$, Y4RC", new[] { "Y4AN8", "Y4CKCN", "SYS_NC00054$", "Y4RC" })
    };
}
