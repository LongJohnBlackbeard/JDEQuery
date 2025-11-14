using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS01 - .
/// </summary>
public class F54HS01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S1HSINO.
        /// </summary>
        public const string S1HSINO = "S1HSINO";

        /// <summary>
        /// S1HSIDN.
        /// </summary>
        public const string S1HSIDN = "S1HSIDN";

        /// <summary>
        /// S1HSIDT.
        /// </summary>
        public const string S1HSIDT = "S1HSIDT";

        /// <summary>
        /// S1HSITM.
        /// </summary>
        public const string S1HSITM = "S1HSITM";

        /// <summary>
        /// S1HSIDM.
        /// </summary>
        public const string S1HSIDM = "S1HSIDM";

        /// <summary>
        /// S1WKD.
        /// </summary>
        public const string S1WKD = "S1WKD";

        /// <summary>
        /// S1HSIDR.
        /// </summary>
        public const string S1HSIDR = "S1HSIDR";

        /// <summary>
        /// S1HSITR.
        /// </summary>
        public const string S1HSITR = "S1HSITR";

        /// <summary>
        /// S1HSIST.
        /// </summary>
        public const string S1HSIST = "S1HSIST";

        /// <summary>
        /// S1HSISV.
        /// </summary>
        public const string S1HSISV = "S1HSISV";

        /// <summary>
        /// S1HSINOP.
        /// </summary>
        public const string S1HSINOP = "S1HSINOP";

        /// <summary>
        /// S1HSINM.
        /// </summary>
        public const string S1HSINM = "S1HSINM";

        /// <summary>
        /// S1HSIPED.
        /// </summary>
        public const string S1HSIPED = "S1HSIPED";

        /// <summary>
        /// S1HSIMV.
        /// </summary>
        public const string S1HSIMV = "S1HSIMV";

        /// <summary>
        /// S1HSIINJ.
        /// </summary>
        public const string S1HSIINJ = "S1HSIINJ";

        /// <summary>
        /// S1HSIENV.
        /// </summary>
        public const string S1HSIENV = "S1HSIENV";

        /// <summary>
        /// S1HSISEC.
        /// </summary>
        public const string S1HSISEC = "S1HSISEC";

        /// <summary>
        /// S1HSISC.
        /// </summary>
        public const string S1HSISC = "S1HSISC";

        /// <summary>
        /// S1HSIOT.
        /// </summary>
        public const string S1HSIOT = "S1HSIOT";

        /// <summary>
        /// S1HSIOC.
        /// </summary>
        public const string S1HSIOC = "S1HSIOC";

        /// <summary>
        /// S1HSIXS.
        /// </summary>
        public const string S1HSIXS = "S1HSIXS";

        /// <summary>
        /// S1HSIAA.
        /// </summary>
        public const string S1HSIAA = "S1HSIAA";

        /// <summary>
        /// S1HSILN.
        /// </summary>
        public const string S1HSILN = "S1HSILN";

        /// <summary>
        /// S1ESTB.
        /// </summary>
        public const string S1ESTB = "S1ESTB";

        /// <summary>
        /// S1CO.
        /// </summary>
        public const string S1CO = "S1CO";

        /// <summary>
        /// S1MCUS.
        /// </summary>
        public const string S1MCUS = "S1MCUS";

        /// <summary>
        /// S1MCU.
        /// </summary>
        public const string S1MCU = "S1MCU";

        /// <summary>
        /// S1CTR.
        /// </summary>
        public const string S1CTR = "S1CTR";

        /// <summary>
        /// S1ADDS.
        /// </summary>
        public const string S1ADDS = "S1ADDS";

        /// <summary>
        /// S1ADD1.
        /// </summary>
        public const string S1ADD1 = "S1ADD1";

        /// <summary>
        /// S1ADD2.
        /// </summary>
        public const string S1ADD2 = "S1ADD2";

        /// <summary>
        /// S1ADD3.
        /// </summary>
        public const string S1ADD3 = "S1ADD3";

        /// <summary>
        /// S1ADD4.
        /// </summary>
        public const string S1ADD4 = "S1ADD4";

        /// <summary>
        /// S1CTY1.
        /// </summary>
        public const string S1CTY1 = "S1CTY1";

        /// <summary>
        /// S1ADDZ.
        /// </summary>
        public const string S1ADDZ = "S1ADDZ";

        /// <summary>
        /// S1COUN.
        /// </summary>
        public const string S1COUN = "S1COUN";

        /// <summary>
        /// S1LATT.
        /// </summary>
        public const string S1LATT = "S1LATT";

        /// <summary>
        /// S1LONG.
        /// </summary>
        public const string S1LONG = "S1LONG";

        /// <summary>
        /// S1REGION.
        /// </summary>
        public const string S1REGION = "S1REGION";

        /// <summary>
        /// S1DOCO.
        /// </summary>
        public const string S1DOCO = "S1DOCO";

        /// <summary>
        /// S1HSITEC.
        /// </summary>
        public const string S1HSITEC = "S1HSITEC";

        /// <summary>
        /// S1HSITAC.
        /// </summary>
        public const string S1HSITAC = "S1HSITAC";

        /// <summary>
        /// S1CRCD.
        /// </summary>
        public const string S1CRCD = "S1CRCD";

        /// <summary>
        /// S1HSIDA.
        /// </summary>
        public const string S1HSIDA = "S1HSIDA";

        /// <summary>
        /// S1HSIDC.
        /// </summary>
        public const string S1HSIDC = "S1HSIDC";

        /// <summary>
        /// S1HSIDAR.
        /// </summary>
        public const string S1HSIDAR = "S1HSIDAR";

        /// <summary>
        /// S1HSICR.
        /// </summary>
        public const string S1HSICR = "S1HSICR";

        /// <summary>
        /// S1HSICRN.
        /// </summary>
        public const string S1HSICRN = "S1HSICRN";

        /// <summary>
        /// S1HSICRNM.
        /// </summary>
        public const string S1HSICRNM = "S1HSICRNM";

        /// <summary>
        /// S1HSIFR.
        /// </summary>
        public const string S1HSIFR = "S1HSIFR";

        /// <summary>
        /// S1HSIPR.
        /// </summary>
        public const string S1HSIPR = "S1HSIPR";

        /// <summary>
        /// S1HSIPRC.
        /// </summary>
        public const string S1HSIPRC = "S1HSIPRC";

        /// <summary>
        /// S1HSIPRN.
        /// </summary>
        public const string S1HSIPRN = "S1HSIPRN";

        /// <summary>
        /// S1HSIPRNM.
        /// </summary>
        public const string S1HSIPRNM = "S1HSIPRNM";

        /// <summary>
        /// S1HSIDTC.
        /// </summary>
        public const string S1HSIDTC = "S1HSIDTC";

        /// <summary>
        /// S1HSICSF.
        /// </summary>
        public const string S1HSICSF = "S1HSICSF";

        /// <summary>
        /// S1HSIINS.
        /// </summary>
        public const string S1HSIINS = "S1HSIINS";

        /// <summary>
        /// S1HSICIS.
        /// </summary>
        public const string S1HSICIS = "S1HSICIS";

        /// <summary>
        /// S1HSIEF.
        /// </summary>
        public const string S1HSIEF = "S1HSIEF";

        /// <summary>
        /// S1HSIRT.
        /// </summary>
        public const string S1HSIRT = "S1HSIRT";

        /// <summary>
        /// S1HSICMT.
        /// </summary>
        public const string S1HSICMT = "S1HSICMT";

        /// <summary>
        /// S1HSINT.
        /// </summary>
        public const string S1HSINT = "S1HSINT";

        /// <summary>
        /// S1HSIC01.
        /// </summary>
        public const string S1HSIC01 = "S1HSIC01";

        /// <summary>
        /// S1HSIC02.
        /// </summary>
        public const string S1HSIC02 = "S1HSIC02";

        /// <summary>
        /// S1HSIC03.
        /// </summary>
        public const string S1HSIC03 = "S1HSIC03";

        /// <summary>
        /// S1HSIC04.
        /// </summary>
        public const string S1HSIC04 = "S1HSIC04";

        /// <summary>
        /// S1HSIC05.
        /// </summary>
        public const string S1HSIC05 = "S1HSIC05";

        /// <summary>
        /// S1HSIC06.
        /// </summary>
        public const string S1HSIC06 = "S1HSIC06";

        /// <summary>
        /// S1HSIC07.
        /// </summary>
        public const string S1HSIC07 = "S1HSIC07";

        /// <summary>
        /// S1HSIC08.
        /// </summary>
        public const string S1HSIC08 = "S1HSIC08";

        /// <summary>
        /// S1HSIC09.
        /// </summary>
        public const string S1HSIC09 = "S1HSIC09";

        /// <summary>
        /// S1HSIC10.
        /// </summary>
        public const string S1HSIC10 = "S1HSIC10";

        /// <summary>
        /// S1HSIOR.
        /// </summary>
        public const string S1HSIOR = "S1HSIOR";

        /// <summary>
        /// S1HSIRB.
        /// </summary>
        public const string S1HSIRB = "S1HSIRB";

        /// <summary>
        /// S1HSIHR.
        /// </summary>
        public const string S1HSIHR = "S1HSIHR";

        /// <summary>
        /// S1HSIIB.
        /// </summary>
        public const string S1HSIIB = "S1HSIIB";

        /// <summary>
        /// S1KBCO.
        /// </summary>
        public const string S1KBCO = "S1KBCO";

        /// <summary>
        /// S1URAB.
        /// </summary>
        public const string S1URAB = "S1URAB";

        /// <summary>
        /// S1URCD.
        /// </summary>
        public const string S1URCD = "S1URCD";

        /// <summary>
        /// S1URAT.
        /// </summary>
        public const string S1URAT = "S1URAT";

        /// <summary>
        /// S1URDT.
        /// </summary>
        public const string S1URDT = "S1URDT";

        /// <summary>
        /// S1URRF.
        /// </summary>
        public const string S1URRF = "S1URRF";

        /// <summary>
        /// S1USER.
        /// </summary>
        public const string S1USER = "S1USER";

        /// <summary>
        /// S1UPMJ.
        /// </summary>
        public const string S1UPMJ = "S1UPMJ";

        /// <summary>
        /// S1UPMT.
        /// </summary>
        public const string S1UPMT = "S1UPMT";

        /// <summary>
        /// S1JOBN.
        /// </summary>
        public const string S1JOBN = "S1JOBN";

        /// <summary>
        /// S1PID.
        /// </summary>
        public const string S1PID = "S1PID";

        /// <summary>
        /// S1CRTU.
        /// </summary>
        public const string S1CRTU = "S1CRTU";

        /// <summary>
        /// S1HSIC11.
        /// </summary>
        public const string S1HSIC11 = "S1HSIC11";

        /// <summary>
        /// S1HSIC12.
        /// </summary>
        public const string S1HSIC12 = "S1HSIC12";

        /// <summary>
        /// S1HSIC13.
        /// </summary>
        public const string S1HSIC13 = "S1HSIC13";

        /// <summary>
        /// S1HSIC14.
        /// </summary>
        public const string S1HSIC14 = "S1HSIC14";

        /// <summary>
        /// S1HSIC15.
        /// </summary>
        public const string S1HSIC15 = "S1HSIC15";

        /// <summary>
        /// S1HSIC16.
        /// </summary>
        public const string S1HSIC16 = "S1HSIC16";

        /// <summary>
        /// S1HSIC17.
        /// </summary>
        public const string S1HSIC17 = "S1HSIC17";

        /// <summary>
        /// S1HSIC18.
        /// </summary>
        public const string S1HSIC18 = "S1HSIC18";

        /// <summary>
        /// S1HSIC19.
        /// </summary>
        public const string S1HSIC19 = "S1HSIC19";

        /// <summary>
        /// S1HSIC20.
        /// </summary>
        public const string S1HSIC20 = "S1HSIC20";

        /// <summary>
        /// S1HSIIRT.
        /// </summary>
        public const string S1HSIIRT = "S1HSIIRT";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S1HSINO", "S1HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S1HSIDN", "S1HSIDN", JdeDataType.String, 200),
        new JdeField("S1HSIDT", "S1HSIDT", JdeDataType.Numeric),
        new JdeField("S1HSITM", "S1HSITM", JdeDataType.Numeric),
        new JdeField("S1HSIDM", "S1HSIDM", JdeDataType.String, 4),
        new JdeField("S1WKD", "S1WKD", JdeDataType.String, 2),
        new JdeField("S1HSIDR", "S1HSIDR", JdeDataType.Numeric),
        new JdeField("S1HSITR", "S1HSITR", JdeDataType.Numeric),
        new JdeField("S1HSIST", "S1HSIST", JdeDataType.String, 4),
        new JdeField("S1HSISV", "S1HSISV", JdeDataType.String, 4),
        new JdeField("S1HSINOP", "S1HSINOP", JdeDataType.Numeric),
        new JdeField("S1HSINM", "S1HSINM", JdeDataType.Numeric),
        new JdeField("S1HSIPED", "S1HSIPED", JdeDataType.Numeric),
        new JdeField("S1HSIMV", "S1HSIMV", JdeDataType.Numeric),
        new JdeField("S1HSIINJ", "S1HSIINJ", JdeDataType.Numeric),
        new JdeField("S1HSIENV", "S1HSIENV", JdeDataType.Numeric),
        new JdeField("S1HSISEC", "S1HSISEC", JdeDataType.Numeric),
        new JdeField("S1HSISC", "S1HSISC", JdeDataType.String, 4),
        new JdeField("S1HSIOT", "S1HSIOT", JdeDataType.Numeric),
        new JdeField("S1HSIOC", "S1HSIOC", JdeDataType.String, 4),
        new JdeField("S1HSIXS", "S1HSIXS", JdeDataType.Numeric),
        new JdeField("S1HSIAA", "S1HSIAA", JdeDataType.Numeric),
        new JdeField("S1HSILN", "S1HSILN", JdeDataType.String, 400),
        new JdeField("S1ESTB", "S1ESTB", JdeDataType.Numeric),
        new JdeField("S1CO", "S1CO", JdeDataType.String, 10),
        new JdeField("S1MCUS", "S1MCUS", JdeDataType.String, 24),
        new JdeField("S1MCU", "S1MCU", JdeDataType.String, 24),
        new JdeField("S1CTR", "S1CTR", JdeDataType.String, 6),
        new JdeField("S1ADDS", "S1ADDS", JdeDataType.String, 6),
        new JdeField("S1ADD1", "S1ADD1", JdeDataType.String, 80),
        new JdeField("S1ADD2", "S1ADD2", JdeDataType.String, 80),
        new JdeField("S1ADD3", "S1ADD3", JdeDataType.String, 80),
        new JdeField("S1ADD4", "S1ADD4", JdeDataType.String, 80),
        new JdeField("S1CTY1", "S1CTY1", JdeDataType.String, 50),
        new JdeField("S1ADDZ", "S1ADDZ", JdeDataType.String, 24),
        new JdeField("S1COUN", "S1COUN", JdeDataType.String, 50),
        new JdeField("S1LATT", "S1LATT", JdeDataType.String, 50),
        new JdeField("S1LONG", "S1LONG", JdeDataType.String, 50),
        new JdeField("S1REGION", "S1REGION", JdeDataType.String, 6),
        new JdeField("S1DOCO", "S1DOCO", JdeDataType.Numeric),
        new JdeField("S1HSITEC", "S1HSITEC", JdeDataType.Numeric),
        new JdeField("S1HSITAC", "S1HSITAC", JdeDataType.Numeric),
        new JdeField("S1CRCD", "S1CRCD", JdeDataType.String, 6),
        new JdeField("S1HSIDA", "S1HSIDA", JdeDataType.Numeric),
        new JdeField("S1HSIDC", "S1HSIDC", JdeDataType.String, 80),
        new JdeField("S1HSIDAR", "S1HSIDAR", JdeDataType.String, 4),
        new JdeField("S1HSICR", "S1HSICR", JdeDataType.Numeric),
        new JdeField("S1HSICRN", "S1HSICRN", JdeDataType.Numeric),
        new JdeField("S1HSICRNM", "S1HSICRNM", JdeDataType.String, 80),
        new JdeField("S1HSIFR", "S1HSIFR", JdeDataType.String, 4),
        new JdeField("S1HSIPR", "S1HSIPR", JdeDataType.String, 4),
        new JdeField("S1HSIPRC", "S1HSIPRC", JdeDataType.String, 4),
        new JdeField("S1HSIPRN", "S1HSIPRN", JdeDataType.Numeric),
        new JdeField("S1HSIPRNM", "S1HSIPRNM", JdeDataType.String, 80),
        new JdeField("S1HSIDTC", "S1HSIDTC", JdeDataType.String, 80),
        new JdeField("S1HSICSF", "S1HSICSF", JdeDataType.String, 6),
        new JdeField("S1HSIINS", "S1HSIINS", JdeDataType.String, 80),
        new JdeField("S1HSICIS", "S1HSICIS", JdeDataType.String, 4),
        new JdeField("S1HSIEF", "S1HSIEF", JdeDataType.String, 400),
        new JdeField("S1HSIRT", "S1HSIRT", JdeDataType.String, 400),
        new JdeField("S1HSICMT", "S1HSICMT", JdeDataType.String, 400),
        new JdeField("S1HSINT", "S1HSINT", JdeDataType.String, 400),
        new JdeField("S1HSIC01", "S1HSIC01", JdeDataType.String, 6),
        new JdeField("S1HSIC02", "S1HSIC02", JdeDataType.String, 6),
        new JdeField("S1HSIC03", "S1HSIC03", JdeDataType.String, 6),
        new JdeField("S1HSIC04", "S1HSIC04", JdeDataType.String, 6),
        new JdeField("S1HSIC05", "S1HSIC05", JdeDataType.String, 6),
        new JdeField("S1HSIC06", "S1HSIC06", JdeDataType.String, 6),
        new JdeField("S1HSIC07", "S1HSIC07", JdeDataType.String, 6),
        new JdeField("S1HSIC08", "S1HSIC08", JdeDataType.String, 6),
        new JdeField("S1HSIC09", "S1HSIC09", JdeDataType.String, 6),
        new JdeField("S1HSIC10", "S1HSIC10", JdeDataType.String, 6),
        new JdeField("S1HSIOR", "S1HSIOR", JdeDataType.Numeric),
        new JdeField("S1HSIRB", "S1HSIRB", JdeDataType.Numeric),
        new JdeField("S1HSIHR", "S1HSIHR", JdeDataType.Numeric),
        new JdeField("S1HSIIB", "S1HSIIB", JdeDataType.Numeric),
        new JdeField("S1KBCO", "S1KBCO", JdeDataType.String, 30),
        new JdeField("S1URAB", "S1URAB", JdeDataType.Numeric),
        new JdeField("S1URCD", "S1URCD", JdeDataType.String, 4),
        new JdeField("S1URAT", "S1URAT", JdeDataType.Numeric),
        new JdeField("S1URDT", "S1URDT", JdeDataType.Numeric),
        new JdeField("S1URRF", "S1URRF", JdeDataType.String, 30),
        new JdeField("S1USER", "S1USER", JdeDataType.String, 20),
        new JdeField("S1UPMJ", "S1UPMJ", JdeDataType.Numeric),
        new JdeField("S1UPMT", "S1UPMT", JdeDataType.Numeric),
        new JdeField("S1JOBN", "S1JOBN", JdeDataType.String, 20),
        new JdeField("S1PID", "S1PID", JdeDataType.String, 20),
        new JdeField("S1CRTU", "S1CRTU", JdeDataType.String, 20),
        new JdeField("S1HSIC11", "S1HSIC11", JdeDataType.String, 6),
        new JdeField("S1HSIC12", "S1HSIC12", JdeDataType.String, 6),
        new JdeField("S1HSIC13", "S1HSIC13", JdeDataType.String, 6),
        new JdeField("S1HSIC14", "S1HSIC14", JdeDataType.String, 6),
        new JdeField("S1HSIC15", "S1HSIC15", JdeDataType.String, 6),
        new JdeField("S1HSIC16", "S1HSIC16", JdeDataType.String, 6),
        new JdeField("S1HSIC17", "S1HSIC17", JdeDataType.String, 6),
        new JdeField("S1HSIC18", "S1HSIC18", JdeDataType.String, 6),
        new JdeField("S1HSIC19", "S1HSIC19", JdeDataType.String, 6),
        new JdeField("S1HSIC20", "S1HSIC20", JdeDataType.String, 6),
        new JdeField("S1HSIIRT", "S1HSIIRT", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS01_0", "Primary Key on S1HSINO", new[] { "S1HSINO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54HS01_2", "Index on S1HSIDT, S1HSIXS, S1HSINM", new[] { "S1HSIDT", "S1HSIXS", "S1HSINM" }),
        new JdeIndex("F54HS01_3", "Index on S1ESTB", new[] { "S1ESTB" }),
        new JdeIndex("F54HS01_4", "Index on S1CO", new[] { "S1CO" }),
        new JdeIndex("F54HS01_5", "Index on S1MCUS", new[] { "S1MCUS" }),
        new JdeIndex("F54HS01_6", "Index on S1MCU", new[] { "S1MCU" }),
        new JdeIndex("F54HS01_7", "Index on S1HSICRN", new[] { "S1HSICRN" }),
        new JdeIndex("F54HS01_8", "Index on SYS_NC00100$", new[] { "SYS_NC00100$" })
    };
}
