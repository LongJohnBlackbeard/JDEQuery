using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L301 - .
/// </summary>
public class F15L301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSDOCO.
        /// </summary>
        public const string PSDOCO = "PSDOCO";

        /// <summary>
        /// PSMCU.
        /// </summary>
        public const string PSMCU = "PSMCU";

        /// <summary>
        /// PSUNIT.
        /// </summary>
        public const string PSUNIT = "PSUNIT";

        /// <summary>
        /// PSRVNB.
        /// </summary>
        public const string PSRVNB = "PSRVNB";

        /// <summary>
        /// PSDBAN.
        /// </summary>
        public const string PSDBAN = "PSDBAN";

        /// <summary>
        /// PSPRDC.
        /// </summary>
        public const string PSPRDC = "PSPRDC";

        /// <summary>
        /// PSCTRY.
        /// </summary>
        public const string PSCTRY = "PSCTRY";

        /// <summary>
        /// PSYR.
        /// </summary>
        public const string PSYR = "PSYR";

        /// <summary>
        /// PSSTNR.
        /// </summary>
        public const string PSSTNR = "PSSTNR";

        /// <summary>
        /// PSAN8.
        /// </summary>
        public const string PSAN8 = "PSAN8";

        /// <summary>
        /// PSCO.
        /// </summary>
        public const string PSCO = "PSCO";

        /// <summary>
        /// PSMCUS.
        /// </summary>
        public const string PSMCUS = "PSMCUS";

        /// <summary>
        /// PSULI.
        /// </summary>
        public const string PSULI = "PSULI";

        /// <summary>
        /// PSULI2.
        /// </summary>
        public const string PSULI2 = "PSULI2";

        /// <summary>
        /// PSCMPM.
        /// </summary>
        public const string PSCMPM = "PSCMPM";

        /// <summary>
        /// PSRM11.
        /// </summary>
        public const string PSRM11 = "PSRM11";

        /// <summary>
        /// PSRM12.
        /// </summary>
        public const string PSRM12 = "PSRM12";

        /// <summary>
        /// PSRM13.
        /// </summary>
        public const string PSRM13 = "PSRM13";

        /// <summary>
        /// PSRM14.
        /// </summary>
        public const string PSRM14 = "PSRM14";

        /// <summary>
        /// PSRM15.
        /// </summary>
        public const string PSRM15 = "PSRM15";

        /// <summary>
        /// PSRM21.
        /// </summary>
        public const string PSRM21 = "PSRM21";

        /// <summary>
        /// PSRM22.
        /// </summary>
        public const string PSRM22 = "PSRM22";

        /// <summary>
        /// PSRM23.
        /// </summary>
        public const string PSRM23 = "PSRM23";

        /// <summary>
        /// PSRM24.
        /// </summary>
        public const string PSRM24 = "PSRM24";

        /// <summary>
        /// PSRM25.
        /// </summary>
        public const string PSRM25 = "PSRM25";

        /// <summary>
        /// PSURC1.
        /// </summary>
        public const string PSURC1 = "PSURC1";

        /// <summary>
        /// PSURD.
        /// </summary>
        public const string PSURD = "PSURD";

        /// <summary>
        /// PSUB01.
        /// </summary>
        public const string PSUB01 = "PSUB01";

        /// <summary>
        /// PSUD01.
        /// </summary>
        public const string PSUD01 = "PSUD01";

        /// <summary>
        /// PSES01.
        /// </summary>
        public const string PSES01 = "PSES01";

        /// <summary>
        /// PSES02.
        /// </summary>
        public const string PSES02 = "PSES02";

        /// <summary>
        /// PSES03.
        /// </summary>
        public const string PSES03 = "PSES03";

        /// <summary>
        /// PSES04.
        /// </summary>
        public const string PSES04 = "PSES04";

        /// <summary>
        /// PSES05.
        /// </summary>
        public const string PSES05 = "PSES05";

        /// <summary>
        /// PSES06.
        /// </summary>
        public const string PSES06 = "PSES06";

        /// <summary>
        /// PSES07.
        /// </summary>
        public const string PSES07 = "PSES07";

        /// <summary>
        /// PSES08.
        /// </summary>
        public const string PSES08 = "PSES08";

        /// <summary>
        /// PSES09.
        /// </summary>
        public const string PSES09 = "PSES09";

        /// <summary>
        /// PSES10.
        /// </summary>
        public const string PSES10 = "PSES10";

        /// <summary>
        /// PSES11.
        /// </summary>
        public const string PSES11 = "PSES11";

        /// <summary>
        /// PSES12.
        /// </summary>
        public const string PSES12 = "PSES12";

        /// <summary>
        /// PSAN13.
        /// </summary>
        public const string PSAN13 = "PSAN13";

        /// <summary>
        /// PSBCRC.
        /// </summary>
        public const string PSBCRC = "PSBCRC";

        /// <summary>
        /// PSCRCD.
        /// </summary>
        public const string PSCRCD = "PSCRCD";

        /// <summary>
        /// PSCRRM.
        /// </summary>
        public const string PSCRRM = "PSCRRM";

        /// <summary>
        /// PSCMFG.
        /// </summary>
        public const string PSCMFG = "PSCMFG";

        /// <summary>
        /// PSCRR.
        /// </summary>
        public const string PSCRR = "PSCRR";

        /// <summary>
        /// PSENTJ.
        /// </summary>
        public const string PSENTJ = "PSENTJ";

        /// <summary>
        /// PSURCD.
        /// </summary>
        public const string PSURCD = "PSURCD";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSUPMT.
        /// </summary>
        public const string PSUPMT = "PSUPMT";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSTORG.
        /// </summary>
        public const string PSTORG = "PSTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F15L301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSDOCO", "PSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PSMCU", "PSMCU", JdeDataType.String, 24, true, true),
        new JdeField("PSUNIT", "PSUNIT", JdeDataType.String, 16, true, true),
        new JdeField("PSRVNB", "PSRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PSDBAN", "PSDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("PSPRDC", "PSPRDC", JdeDataType.String, 8, true, true),
        new JdeField("PSCTRY", "PSCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("PSYR", "PSYR", JdeDataType.Numeric, null, true, true),
        new JdeField("PSSTNR", "PSSTNR", JdeDataType.String, 20),
        new JdeField("PSAN8", "PSAN8", JdeDataType.Numeric),
        new JdeField("PSCO", "PSCO", JdeDataType.String, 10),
        new JdeField("PSMCUS", "PSMCUS", JdeDataType.String, 24),
        new JdeField("PSULI", "PSULI", JdeDataType.String, 16),
        new JdeField("PSULI2", "PSULI2", JdeDataType.String, 16),
        new JdeField("PSCMPM", "PSCMPM", JdeDataType.String, 2),
        new JdeField("PSRM11", "PSRM11", JdeDataType.String, 8),
        new JdeField("PSRM12", "PSRM12", JdeDataType.String, 8),
        new JdeField("PSRM13", "PSRM13", JdeDataType.String, 8),
        new JdeField("PSRM14", "PSRM14", JdeDataType.String, 8),
        new JdeField("PSRM15", "PSRM15", JdeDataType.String, 8),
        new JdeField("PSRM21", "PSRM21", JdeDataType.String, 8),
        new JdeField("PSRM22", "PSRM22", JdeDataType.String, 8),
        new JdeField("PSRM23", "PSRM23", JdeDataType.String, 8),
        new JdeField("PSRM24", "PSRM24", JdeDataType.String, 8),
        new JdeField("PSRM25", "PSRM25", JdeDataType.String, 8),
        new JdeField("PSURC1", "PSURC1", JdeDataType.String, 6),
        new JdeField("PSURD", "PSURD", JdeDataType.Numeric),
        new JdeField("PSUB01", "PSUB01", JdeDataType.Numeric),
        new JdeField("PSUD01", "PSUD01", JdeDataType.String, 30),
        new JdeField("PSES01", "PSES01", JdeDataType.Numeric),
        new JdeField("PSES02", "PSES02", JdeDataType.Numeric),
        new JdeField("PSES03", "PSES03", JdeDataType.Numeric),
        new JdeField("PSES04", "PSES04", JdeDataType.Numeric),
        new JdeField("PSES05", "PSES05", JdeDataType.Numeric),
        new JdeField("PSES06", "PSES06", JdeDataType.Numeric),
        new JdeField("PSES07", "PSES07", JdeDataType.Numeric),
        new JdeField("PSES08", "PSES08", JdeDataType.Numeric),
        new JdeField("PSES09", "PSES09", JdeDataType.Numeric),
        new JdeField("PSES10", "PSES10", JdeDataType.Numeric),
        new JdeField("PSES11", "PSES11", JdeDataType.Numeric),
        new JdeField("PSES12", "PSES12", JdeDataType.Numeric),
        new JdeField("PSAN13", "PSAN13", JdeDataType.Numeric),
        new JdeField("PSBCRC", "PSBCRC", JdeDataType.String, 6),
        new JdeField("PSCRCD", "PSCRCD", JdeDataType.String, 6),
        new JdeField("PSCRRM", "PSCRRM", JdeDataType.String, 2),
        new JdeField("PSCMFG", "PSCMFG", JdeDataType.String, 2),
        new JdeField("PSCRR", "PSCRR", JdeDataType.Numeric),
        new JdeField("PSENTJ", "PSENTJ", JdeDataType.Numeric),
        new JdeField("PSURCD", "PSURCD", JdeDataType.String, 4),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSUPMT", "PSUPMT", JdeDataType.Numeric),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSTORG", "PSTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L301_0", "Primary Key on PSDOCO, PSMCU, PSUNIT, PSRVNB, PSDBAN, PSPRDC, PSCTRY, PSYR", new[] { "PSDOCO", "PSMCU", "PSUNIT", "PSRVNB", "PSDBAN", "PSPRDC", "PSCTRY", "PSYR" }, isUnique: true, isPrimaryKey: true)
    };
}
