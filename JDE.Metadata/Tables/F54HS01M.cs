using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS01M - .
/// </summary>
public class F54HS01M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I1HSINO.
        /// </summary>
        public const string I1HSINO = "I1HSINO";

        /// <summary>
        /// I1HSIMN.
        /// </summary>
        public const string I1HSIMN = "I1HSIMN";

        /// <summary>
        /// I1HSIMT.
        /// </summary>
        public const string I1HSIMT = "I1HSIMT";

        /// <summary>
        /// I1MODDT.
        /// </summary>
        public const string I1MODDT = "I1MODDT";

        /// <summary>
        /// I1HSIDN.
        /// </summary>
        public const string I1HSIDN = "I1HSIDN";

        /// <summary>
        /// I1HSIDT.
        /// </summary>
        public const string I1HSIDT = "I1HSIDT";

        /// <summary>
        /// I1HSITM.
        /// </summary>
        public const string I1HSITM = "I1HSITM";

        /// <summary>
        /// I1HSIDM.
        /// </summary>
        public const string I1HSIDM = "I1HSIDM";

        /// <summary>
        /// I1WKD.
        /// </summary>
        public const string I1WKD = "I1WKD";

        /// <summary>
        /// I1HSIDR.
        /// </summary>
        public const string I1HSIDR = "I1HSIDR";

        /// <summary>
        /// I1HSITR.
        /// </summary>
        public const string I1HSITR = "I1HSITR";

        /// <summary>
        /// I1HSIST.
        /// </summary>
        public const string I1HSIST = "I1HSIST";

        /// <summary>
        /// I1HSISV.
        /// </summary>
        public const string I1HSISV = "I1HSISV";

        /// <summary>
        /// I1HSINOP.
        /// </summary>
        public const string I1HSINOP = "I1HSINOP";

        /// <summary>
        /// I1HSINM.
        /// </summary>
        public const string I1HSINM = "I1HSINM";

        /// <summary>
        /// I1HSIPED.
        /// </summary>
        public const string I1HSIPED = "I1HSIPED";

        /// <summary>
        /// I1HSIMV.
        /// </summary>
        public const string I1HSIMV = "I1HSIMV";

        /// <summary>
        /// I1HSIINJ.
        /// </summary>
        public const string I1HSIINJ = "I1HSIINJ";

        /// <summary>
        /// I1HSIENV.
        /// </summary>
        public const string I1HSIENV = "I1HSIENV";

        /// <summary>
        /// I1HSISEC.
        /// </summary>
        public const string I1HSISEC = "I1HSISEC";

        /// <summary>
        /// I1HSISC.
        /// </summary>
        public const string I1HSISC = "I1HSISC";

        /// <summary>
        /// I1HSIOT.
        /// </summary>
        public const string I1HSIOT = "I1HSIOT";

        /// <summary>
        /// I1HSIOC.
        /// </summary>
        public const string I1HSIOC = "I1HSIOC";

        /// <summary>
        /// I1HSIXS.
        /// </summary>
        public const string I1HSIXS = "I1HSIXS";

        /// <summary>
        /// I1HSIAA.
        /// </summary>
        public const string I1HSIAA = "I1HSIAA";

        /// <summary>
        /// I1HSILN.
        /// </summary>
        public const string I1HSILN = "I1HSILN";

        /// <summary>
        /// I1ESTB.
        /// </summary>
        public const string I1ESTB = "I1ESTB";

        /// <summary>
        /// I1CO.
        /// </summary>
        public const string I1CO = "I1CO";

        /// <summary>
        /// I1MCUS.
        /// </summary>
        public const string I1MCUS = "I1MCUS";

        /// <summary>
        /// I1MCU.
        /// </summary>
        public const string I1MCU = "I1MCU";

        /// <summary>
        /// I1CTR.
        /// </summary>
        public const string I1CTR = "I1CTR";

        /// <summary>
        /// I1ADDS.
        /// </summary>
        public const string I1ADDS = "I1ADDS";

        /// <summary>
        /// I1ADD1.
        /// </summary>
        public const string I1ADD1 = "I1ADD1";

        /// <summary>
        /// I1ADD2.
        /// </summary>
        public const string I1ADD2 = "I1ADD2";

        /// <summary>
        /// I1ADD3.
        /// </summary>
        public const string I1ADD3 = "I1ADD3";

        /// <summary>
        /// I1ADD4.
        /// </summary>
        public const string I1ADD4 = "I1ADD4";

        /// <summary>
        /// I1CTY1.
        /// </summary>
        public const string I1CTY1 = "I1CTY1";

        /// <summary>
        /// I1ADDZ.
        /// </summary>
        public const string I1ADDZ = "I1ADDZ";

        /// <summary>
        /// I1COUN.
        /// </summary>
        public const string I1COUN = "I1COUN";

        /// <summary>
        /// I1LATT.
        /// </summary>
        public const string I1LATT = "I1LATT";

        /// <summary>
        /// I1LONG.
        /// </summary>
        public const string I1LONG = "I1LONG";

        /// <summary>
        /// I1REGION.
        /// </summary>
        public const string I1REGION = "I1REGION";

        /// <summary>
        /// I1DOCO.
        /// </summary>
        public const string I1DOCO = "I1DOCO";

        /// <summary>
        /// I1HSITEC.
        /// </summary>
        public const string I1HSITEC = "I1HSITEC";

        /// <summary>
        /// I1HSITAC.
        /// </summary>
        public const string I1HSITAC = "I1HSITAC";

        /// <summary>
        /// I1CRCD.
        /// </summary>
        public const string I1CRCD = "I1CRCD";

        /// <summary>
        /// I1HSIDA.
        /// </summary>
        public const string I1HSIDA = "I1HSIDA";

        /// <summary>
        /// I1HSIDC.
        /// </summary>
        public const string I1HSIDC = "I1HSIDC";

        /// <summary>
        /// I1HSIDAR.
        /// </summary>
        public const string I1HSIDAR = "I1HSIDAR";

        /// <summary>
        /// I1HSICR.
        /// </summary>
        public const string I1HSICR = "I1HSICR";

        /// <summary>
        /// I1HSICRN.
        /// </summary>
        public const string I1HSICRN = "I1HSICRN";

        /// <summary>
        /// I1HSICRNM.
        /// </summary>
        public const string I1HSICRNM = "I1HSICRNM";

        /// <summary>
        /// I1HSIFR.
        /// </summary>
        public const string I1HSIFR = "I1HSIFR";

        /// <summary>
        /// I1HSIPR.
        /// </summary>
        public const string I1HSIPR = "I1HSIPR";

        /// <summary>
        /// I1HSIPRC.
        /// </summary>
        public const string I1HSIPRC = "I1HSIPRC";

        /// <summary>
        /// I1HSIPRN.
        /// </summary>
        public const string I1HSIPRN = "I1HSIPRN";

        /// <summary>
        /// I1HSIPRNM.
        /// </summary>
        public const string I1HSIPRNM = "I1HSIPRNM";

        /// <summary>
        /// I1HSIDTC.
        /// </summary>
        public const string I1HSIDTC = "I1HSIDTC";

        /// <summary>
        /// I1HSICSF.
        /// </summary>
        public const string I1HSICSF = "I1HSICSF";

        /// <summary>
        /// I1HSIINS.
        /// </summary>
        public const string I1HSIINS = "I1HSIINS";

        /// <summary>
        /// I1HSICIS.
        /// </summary>
        public const string I1HSICIS = "I1HSICIS";

        /// <summary>
        /// I1HSIEF.
        /// </summary>
        public const string I1HSIEF = "I1HSIEF";

        /// <summary>
        /// I1HSIRT.
        /// </summary>
        public const string I1HSIRT = "I1HSIRT";

        /// <summary>
        /// I1HSICMT.
        /// </summary>
        public const string I1HSICMT = "I1HSICMT";

        /// <summary>
        /// I1HSINT.
        /// </summary>
        public const string I1HSINT = "I1HSINT";

        /// <summary>
        /// I1HSIC01.
        /// </summary>
        public const string I1HSIC01 = "I1HSIC01";

        /// <summary>
        /// I1HSIC02.
        /// </summary>
        public const string I1HSIC02 = "I1HSIC02";

        /// <summary>
        /// I1HSIC03.
        /// </summary>
        public const string I1HSIC03 = "I1HSIC03";

        /// <summary>
        /// I1HSIC04.
        /// </summary>
        public const string I1HSIC04 = "I1HSIC04";

        /// <summary>
        /// I1HSIC05.
        /// </summary>
        public const string I1HSIC05 = "I1HSIC05";

        /// <summary>
        /// I1HSIC06.
        /// </summary>
        public const string I1HSIC06 = "I1HSIC06";

        /// <summary>
        /// I1HSIC07.
        /// </summary>
        public const string I1HSIC07 = "I1HSIC07";

        /// <summary>
        /// I1HSIC08.
        /// </summary>
        public const string I1HSIC08 = "I1HSIC08";

        /// <summary>
        /// I1HSIC09.
        /// </summary>
        public const string I1HSIC09 = "I1HSIC09";

        /// <summary>
        /// I1HSIC10.
        /// </summary>
        public const string I1HSIC10 = "I1HSIC10";

        /// <summary>
        /// I1HSIOR.
        /// </summary>
        public const string I1HSIOR = "I1HSIOR";

        /// <summary>
        /// I1HSIRB.
        /// </summary>
        public const string I1HSIRB = "I1HSIRB";

        /// <summary>
        /// I1HSIHR.
        /// </summary>
        public const string I1HSIHR = "I1HSIHR";

        /// <summary>
        /// I1HSIIB.
        /// </summary>
        public const string I1HSIIB = "I1HSIIB";

        /// <summary>
        /// I1KBCO.
        /// </summary>
        public const string I1KBCO = "I1KBCO";

        /// <summary>
        /// I1URAB.
        /// </summary>
        public const string I1URAB = "I1URAB";

        /// <summary>
        /// I1URCD.
        /// </summary>
        public const string I1URCD = "I1URCD";

        /// <summary>
        /// I1URAT.
        /// </summary>
        public const string I1URAT = "I1URAT";

        /// <summary>
        /// I1URDT.
        /// </summary>
        public const string I1URDT = "I1URDT";

        /// <summary>
        /// I1URRF.
        /// </summary>
        public const string I1URRF = "I1URRF";

        /// <summary>
        /// I1USER.
        /// </summary>
        public const string I1USER = "I1USER";

        /// <summary>
        /// I1UPMJ.
        /// </summary>
        public const string I1UPMJ = "I1UPMJ";

        /// <summary>
        /// I1UPMT.
        /// </summary>
        public const string I1UPMT = "I1UPMT";

        /// <summary>
        /// I1JOBN.
        /// </summary>
        public const string I1JOBN = "I1JOBN";

        /// <summary>
        /// I1PID.
        /// </summary>
        public const string I1PID = "I1PID";

        /// <summary>
        /// I1CRTU.
        /// </summary>
        public const string I1CRTU = "I1CRTU";

        /// <summary>
        /// I1HSIC11.
        /// </summary>
        public const string I1HSIC11 = "I1HSIC11";

        /// <summary>
        /// I1HSIC12.
        /// </summary>
        public const string I1HSIC12 = "I1HSIC12";

        /// <summary>
        /// I1HSIC13.
        /// </summary>
        public const string I1HSIC13 = "I1HSIC13";

        /// <summary>
        /// I1HSIC14.
        /// </summary>
        public const string I1HSIC14 = "I1HSIC14";

        /// <summary>
        /// I1HSIC15.
        /// </summary>
        public const string I1HSIC15 = "I1HSIC15";

        /// <summary>
        /// I1HSIC16.
        /// </summary>
        public const string I1HSIC16 = "I1HSIC16";

        /// <summary>
        /// I1HSIC17.
        /// </summary>
        public const string I1HSIC17 = "I1HSIC17";

        /// <summary>
        /// I1HSIC18.
        /// </summary>
        public const string I1HSIC18 = "I1HSIC18";

        /// <summary>
        /// I1HSIC19.
        /// </summary>
        public const string I1HSIC19 = "I1HSIC19";

        /// <summary>
        /// I1HSIC20.
        /// </summary>
        public const string I1HSIC20 = "I1HSIC20";

        /// <summary>
        /// I1HSIIRT.
        /// </summary>
        public const string I1HSIIRT = "I1HSIIRT";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS01M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I1HSINO", "I1HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I1HSIMN", "I1HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I1HSIMT", "I1HSIMT", JdeDataType.String, 2),
        new JdeField("I1MODDT", "I1MODDT", JdeDataType.Numeric),
        new JdeField("I1HSIDN", "I1HSIDN", JdeDataType.String, 200),
        new JdeField("I1HSIDT", "I1HSIDT", JdeDataType.Numeric),
        new JdeField("I1HSITM", "I1HSITM", JdeDataType.Numeric),
        new JdeField("I1HSIDM", "I1HSIDM", JdeDataType.String, 4),
        new JdeField("I1WKD", "I1WKD", JdeDataType.String, 2),
        new JdeField("I1HSIDR", "I1HSIDR", JdeDataType.Numeric),
        new JdeField("I1HSITR", "I1HSITR", JdeDataType.Numeric),
        new JdeField("I1HSIST", "I1HSIST", JdeDataType.String, 4),
        new JdeField("I1HSISV", "I1HSISV", JdeDataType.String, 4),
        new JdeField("I1HSINOP", "I1HSINOP", JdeDataType.Numeric),
        new JdeField("I1HSINM", "I1HSINM", JdeDataType.Numeric),
        new JdeField("I1HSIPED", "I1HSIPED", JdeDataType.Numeric),
        new JdeField("I1HSIMV", "I1HSIMV", JdeDataType.Numeric),
        new JdeField("I1HSIINJ", "I1HSIINJ", JdeDataType.Numeric),
        new JdeField("I1HSIENV", "I1HSIENV", JdeDataType.Numeric),
        new JdeField("I1HSISEC", "I1HSISEC", JdeDataType.Numeric),
        new JdeField("I1HSISC", "I1HSISC", JdeDataType.String, 4),
        new JdeField("I1HSIOT", "I1HSIOT", JdeDataType.Numeric),
        new JdeField("I1HSIOC", "I1HSIOC", JdeDataType.String, 4),
        new JdeField("I1HSIXS", "I1HSIXS", JdeDataType.Numeric),
        new JdeField("I1HSIAA", "I1HSIAA", JdeDataType.Numeric),
        new JdeField("I1HSILN", "I1HSILN", JdeDataType.String, 400),
        new JdeField("I1ESTB", "I1ESTB", JdeDataType.Numeric),
        new JdeField("I1CO", "I1CO", JdeDataType.String, 10),
        new JdeField("I1MCUS", "I1MCUS", JdeDataType.String, 24),
        new JdeField("I1MCU", "I1MCU", JdeDataType.String, 24),
        new JdeField("I1CTR", "I1CTR", JdeDataType.String, 6),
        new JdeField("I1ADDS", "I1ADDS", JdeDataType.String, 6),
        new JdeField("I1ADD1", "I1ADD1", JdeDataType.String, 80),
        new JdeField("I1ADD2", "I1ADD2", JdeDataType.String, 80),
        new JdeField("I1ADD3", "I1ADD3", JdeDataType.String, 80),
        new JdeField("I1ADD4", "I1ADD4", JdeDataType.String, 80),
        new JdeField("I1CTY1", "I1CTY1", JdeDataType.String, 50),
        new JdeField("I1ADDZ", "I1ADDZ", JdeDataType.String, 24),
        new JdeField("I1COUN", "I1COUN", JdeDataType.String, 50),
        new JdeField("I1LATT", "I1LATT", JdeDataType.String, 50),
        new JdeField("I1LONG", "I1LONG", JdeDataType.String, 50),
        new JdeField("I1REGION", "I1REGION", JdeDataType.String, 6),
        new JdeField("I1DOCO", "I1DOCO", JdeDataType.Numeric),
        new JdeField("I1HSITEC", "I1HSITEC", JdeDataType.Numeric),
        new JdeField("I1HSITAC", "I1HSITAC", JdeDataType.Numeric),
        new JdeField("I1CRCD", "I1CRCD", JdeDataType.String, 6),
        new JdeField("I1HSIDA", "I1HSIDA", JdeDataType.Numeric),
        new JdeField("I1HSIDC", "I1HSIDC", JdeDataType.String, 80),
        new JdeField("I1HSIDAR", "I1HSIDAR", JdeDataType.String, 4),
        new JdeField("I1HSICR", "I1HSICR", JdeDataType.Numeric),
        new JdeField("I1HSICRN", "I1HSICRN", JdeDataType.Numeric),
        new JdeField("I1HSICRNM", "I1HSICRNM", JdeDataType.String, 80),
        new JdeField("I1HSIFR", "I1HSIFR", JdeDataType.String, 4),
        new JdeField("I1HSIPR", "I1HSIPR", JdeDataType.String, 4),
        new JdeField("I1HSIPRC", "I1HSIPRC", JdeDataType.String, 4),
        new JdeField("I1HSIPRN", "I1HSIPRN", JdeDataType.Numeric),
        new JdeField("I1HSIPRNM", "I1HSIPRNM", JdeDataType.String, 80),
        new JdeField("I1HSIDTC", "I1HSIDTC", JdeDataType.String, 80),
        new JdeField("I1HSICSF", "I1HSICSF", JdeDataType.String, 6),
        new JdeField("I1HSIINS", "I1HSIINS", JdeDataType.String, 80),
        new JdeField("I1HSICIS", "I1HSICIS", JdeDataType.String, 4),
        new JdeField("I1HSIEF", "I1HSIEF", JdeDataType.String, 400),
        new JdeField("I1HSIRT", "I1HSIRT", JdeDataType.String, 400),
        new JdeField("I1HSICMT", "I1HSICMT", JdeDataType.String, 400),
        new JdeField("I1HSINT", "I1HSINT", JdeDataType.String, 400),
        new JdeField("I1HSIC01", "I1HSIC01", JdeDataType.String, 6),
        new JdeField("I1HSIC02", "I1HSIC02", JdeDataType.String, 6),
        new JdeField("I1HSIC03", "I1HSIC03", JdeDataType.String, 6),
        new JdeField("I1HSIC04", "I1HSIC04", JdeDataType.String, 6),
        new JdeField("I1HSIC05", "I1HSIC05", JdeDataType.String, 6),
        new JdeField("I1HSIC06", "I1HSIC06", JdeDataType.String, 6),
        new JdeField("I1HSIC07", "I1HSIC07", JdeDataType.String, 6),
        new JdeField("I1HSIC08", "I1HSIC08", JdeDataType.String, 6),
        new JdeField("I1HSIC09", "I1HSIC09", JdeDataType.String, 6),
        new JdeField("I1HSIC10", "I1HSIC10", JdeDataType.String, 6),
        new JdeField("I1HSIOR", "I1HSIOR", JdeDataType.Numeric),
        new JdeField("I1HSIRB", "I1HSIRB", JdeDataType.Numeric),
        new JdeField("I1HSIHR", "I1HSIHR", JdeDataType.Numeric),
        new JdeField("I1HSIIB", "I1HSIIB", JdeDataType.Numeric),
        new JdeField("I1KBCO", "I1KBCO", JdeDataType.String, 30),
        new JdeField("I1URAB", "I1URAB", JdeDataType.Numeric),
        new JdeField("I1URCD", "I1URCD", JdeDataType.String, 4),
        new JdeField("I1URAT", "I1URAT", JdeDataType.Numeric),
        new JdeField("I1URDT", "I1URDT", JdeDataType.Numeric),
        new JdeField("I1URRF", "I1URRF", JdeDataType.String, 30),
        new JdeField("I1USER", "I1USER", JdeDataType.String, 20),
        new JdeField("I1UPMJ", "I1UPMJ", JdeDataType.Numeric),
        new JdeField("I1UPMT", "I1UPMT", JdeDataType.Numeric),
        new JdeField("I1JOBN", "I1JOBN", JdeDataType.String, 20),
        new JdeField("I1PID", "I1PID", JdeDataType.String, 20),
        new JdeField("I1CRTU", "I1CRTU", JdeDataType.String, 20),
        new JdeField("I1HSIC11", "I1HSIC11", JdeDataType.String, 6),
        new JdeField("I1HSIC12", "I1HSIC12", JdeDataType.String, 6),
        new JdeField("I1HSIC13", "I1HSIC13", JdeDataType.String, 6),
        new JdeField("I1HSIC14", "I1HSIC14", JdeDataType.String, 6),
        new JdeField("I1HSIC15", "I1HSIC15", JdeDataType.String, 6),
        new JdeField("I1HSIC16", "I1HSIC16", JdeDataType.String, 6),
        new JdeField("I1HSIC17", "I1HSIC17", JdeDataType.String, 6),
        new JdeField("I1HSIC18", "I1HSIC18", JdeDataType.String, 6),
        new JdeField("I1HSIC19", "I1HSIC19", JdeDataType.String, 6),
        new JdeField("I1HSIC20", "I1HSIC20", JdeDataType.String, 6),
        new JdeField("I1HSIIRT", "I1HSIIRT", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS01M_0", "Primary Key on I1HSINO, I1HSIMN", new[] { "I1HSINO", "I1HSIMN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54HS01M_2", "Index on I1HSINO, SYS_NC00103$, SYS_NC00104$", new[] { "I1HSINO", "SYS_NC00103$", "SYS_NC00104$" })
    };
}
