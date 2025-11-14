using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41001 - .
/// </summary>
public class F41001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CIPRIM.
        /// </summary>
        public const string CIPRIM = "CIPRIM";

        /// <summary>
        /// CISYM1.
        /// </summary>
        public const string CISYM1 = "CISYM1";

        /// <summary>
        /// CISYM2.
        /// </summary>
        public const string CISYM2 = "CISYM2";

        /// <summary>
        /// CISYM3.
        /// </summary>
        public const string CISYM3 = "CISYM3";

        /// <summary>
        /// CISYM5.
        /// </summary>
        public const string CISYM5 = "CISYM5";

        /// <summary>
        /// CISECD.
        /// </summary>
        public const string CISECD = "CISECD";

        /// <summary>
        /// CISEPL.
        /// </summary>
        public const string CISEPL = "CISEPL";

        /// <summary>
        /// CISE01.
        /// </summary>
        public const string CISE01 = "CISE01";

        /// <summary>
        /// CISE02.
        /// </summary>
        public const string CISE02 = "CISE02";

        /// <summary>
        /// CISE03.
        /// </summary>
        public const string CISE03 = "CISE03";

        /// <summary>
        /// CISE04.
        /// </summary>
        public const string CISE04 = "CISE04";

        /// <summary>
        /// CISE05.
        /// </summary>
        public const string CISE05 = "CISE05";

        /// <summary>
        /// CISE06.
        /// </summary>
        public const string CISE06 = "CISE06";

        /// <summary>
        /// CISE07.
        /// </summary>
        public const string CISE07 = "CISE07";

        /// <summary>
        /// CISE08.
        /// </summary>
        public const string CISE08 = "CISE08";

        /// <summary>
        /// CISE09.
        /// </summary>
        public const string CISE09 = "CISE09";

        /// <summary>
        /// CISE10.
        /// </summary>
        public const string CISE10 = "CISE10";

        /// <summary>
        /// CILR01.
        /// </summary>
        public const string CILR01 = "CILR01";

        /// <summary>
        /// CILR02.
        /// </summary>
        public const string CILR02 = "CILR02";

        /// <summary>
        /// CILR03.
        /// </summary>
        public const string CILR03 = "CILR03";

        /// <summary>
        /// CILR04.
        /// </summary>
        public const string CILR04 = "CILR04";

        /// <summary>
        /// CILR05.
        /// </summary>
        public const string CILR05 = "CILR05";

        /// <summary>
        /// CILR06.
        /// </summary>
        public const string CILR06 = "CILR06";

        /// <summary>
        /// CILR07.
        /// </summary>
        public const string CILR07 = "CILR07";

        /// <summary>
        /// CILR08.
        /// </summary>
        public const string CILR08 = "CILR08";

        /// <summary>
        /// CILR09.
        /// </summary>
        public const string CILR09 = "CILR09";

        /// <summary>
        /// CILR10.
        /// </summary>
        public const string CILR10 = "CILR10";

        /// <summary>
        /// CIAN8.
        /// </summary>
        public const string CIAN8 = "CIAN8";

        /// <summary>
        /// CIPOCS.
        /// </summary>
        public const string CIPOCS = "CIPOCS";

        /// <summary>
        /// CIINCS.
        /// </summary>
        public const string CIINCS = "CIINCS";

        /// <summary>
        /// CIIALP.
        /// </summary>
        public const string CIIALP = "CIIALP";

        /// <summary>
        /// CIBSDY.
        /// </summary>
        public const string CIBSDY = "CIBSDY";

        /// <summary>
        /// CIIA1.
        /// </summary>
        public const string CIIA1 = "CIIA1";

        /// <summary>
        /// CIIB1.
        /// </summary>
        public const string CIIB1 = "CIIB1";

        /// <summary>
        /// CIIC1.
        /// </summary>
        public const string CIIC1 = "CIIC1";

        /// <summary>
        /// CIIA2.
        /// </summary>
        public const string CIIA2 = "CIIA2";

        /// <summary>
        /// CIIB2.
        /// </summary>
        public const string CIIB2 = "CIIB2";

        /// <summary>
        /// CIIC2.
        /// </summary>
        public const string CIIC2 = "CIIC2";

        /// <summary>
        /// CIIA3.
        /// </summary>
        public const string CIIA3 = "CIIA3";

        /// <summary>
        /// CIIB3.
        /// </summary>
        public const string CIIB3 = "CIIB3";

        /// <summary>
        /// CIIC3.
        /// </summary>
        public const string CIIC3 = "CIIC3";

        /// <summary>
        /// CIPNC.
        /// </summary>
        public const string CIPNC = "CIPNC";

        /// <summary>
        /// CIGLPO.
        /// </summary>
        public const string CIGLPO = "CIGLPO";

        /// <summary>
        /// CIUNGL.
        /// </summary>
        public const string CIUNGL = "CIUNGL";

        /// <summary>
        /// CICMGL.
        /// </summary>
        public const string CICMGL = "CICMGL";

        /// <summary>
        /// CICSMT.
        /// </summary>
        public const string CICSMT = "CICSMT";

        /// <summary>
        /// CIPCSM.
        /// </summary>
        public const string CIPCSM = "CIPCSM";

        /// <summary>
        /// CIBACK.
        /// </summary>
        public const string CIBACK = "CIBACK";

        /// <summary>
        /// CICOMH.
        /// </summary>
        public const string CICOMH = "CICOMH";

        /// <summary>
        /// CIICRI.
        /// </summary>
        public const string CIICRI = "CIICRI";

        /// <summary>
        /// CIIARI.
        /// </summary>
        public const string CIIARI = "CIIARI";

        /// <summary>
        /// CIMATY.
        /// </summary>
        public const string CIMATY = "CIMATY";

        /// <summary>
        /// CIXRT.
        /// </summary>
        public const string CIXRT = "CIXRT";

        /// <summary>
        /// CIXRT2.
        /// </summary>
        public const string CIXRT2 = "CIXRT2";

        /// <summary>
        /// CIARTG.
        /// </summary>
        public const string CIARTG = "CIARTG";

        /// <summary>
        /// CIDA01.
        /// </summary>
        public const string CIDA01 = "CIDA01";

        /// <summary>
        /// CIDA02.
        /// </summary>
        public const string CIDA02 = "CIDA02";

        /// <summary>
        /// CIDA03.
        /// </summary>
        public const string CIDA03 = "CIDA03";

        /// <summary>
        /// CIDA04.
        /// </summary>
        public const string CIDA04 = "CIDA04";

        /// <summary>
        /// CIDA05.
        /// </summary>
        public const string CIDA05 = "CIDA05";

        /// <summary>
        /// CIDA06.
        /// </summary>
        public const string CIDA06 = "CIDA06";

        /// <summary>
        /// CIDA07.
        /// </summary>
        public const string CIDA07 = "CIDA07";

        /// <summary>
        /// CIDA08.
        /// </summary>
        public const string CIDA08 = "CIDA08";

        /// <summary>
        /// CIDA09.
        /// </summary>
        public const string CIDA09 = "CIDA09";

        /// <summary>
        /// CIDA10.
        /// </summary>
        public const string CIDA10 = "CIDA10";

        /// <summary>
        /// CIDA11.
        /// </summary>
        public const string CIDA11 = "CIDA11";

        /// <summary>
        /// CIDA12.
        /// </summary>
        public const string CIDA12 = "CIDA12";

        /// <summary>
        /// CIDA13.
        /// </summary>
        public const string CIDA13 = "CIDA13";

        /// <summary>
        /// CIDA14.
        /// </summary>
        public const string CIDA14 = "CIDA14";

        /// <summary>
        /// CIDA15.
        /// </summary>
        public const string CIDA15 = "CIDA15";

        /// <summary>
        /// CIDA16.
        /// </summary>
        public const string CIDA16 = "CIDA16";

        /// <summary>
        /// CISYM4.
        /// </summary>
        public const string CISYM4 = "CISYM4";

        /// <summary>
        /// CIWIUM.
        /// </summary>
        public const string CIWIUM = "CIWIUM";

        /// <summary>
        /// CIVUMD.
        /// </summary>
        public const string CIVUMD = "CIVUMD";

        /// <summary>
        /// CIUWUM.
        /// </summary>
        public const string CIUWUM = "CIUWUM";

        /// <summary>
        /// CIULOT.
        /// </summary>
        public const string CIULOT = "CIULOT";

        /// <summary>
        /// CILCTL.
        /// </summary>
        public const string CILCTL = "CILCTL";

        /// <summary>
        /// CIWCTL.
        /// </summary>
        public const string CIWCTL = "CIWCTL";

        /// <summary>
        /// CIMVER.
        /// </summary>
        public const string CIMVER = "CIMVER";

        /// <summary>
        /// CICLOC.
        /// </summary>
        public const string CICLOC = "CICLOC";

        /// <summary>
        /// CIXLOC.
        /// </summary>
        public const string CIXLOC = "CIXLOC";

        /// <summary>
        /// CISTPU.
        /// </summary>
        public const string CISTPU = "CISTPU";

        /// <summary>
        /// CIDNTP.
        /// </summary>
        public const string CIDNTP = "CIDNTP";

        /// <summary>
        /// CITMPS.
        /// </summary>
        public const string CITMPS = "CITMPS";

        /// <summary>
        /// CIUSMT.
        /// </summary>
        public const string CIUSMT = "CIUSMT";

        /// <summary>
        /// CIOT1Y.
        /// </summary>
        public const string CIOT1Y = "CIOT1Y";

        /// <summary>
        /// CIOT2Y.
        /// </summary>
        public const string CIOT2Y = "CIOT2Y";

        /// <summary>
        /// CIOT3Y.
        /// </summary>
        public const string CIOT3Y = "CIOT3Y";

        /// <summary>
        /// CIOT4Y.
        /// </summary>
        public const string CIOT4Y = "CIOT4Y";

        /// <summary>
        /// CIOT5Y.
        /// </summary>
        public const string CIOT5Y = "CIOT5Y";

        /// <summary>
        /// CIUSID.
        /// </summary>
        public const string CIUSID = "CIUSID";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";

        /// <summary>
        /// CITDAY.
        /// </summary>
        public const string CITDAY = "CITDAY";

        /// <summary>
        /// CISY.
        /// </summary>
        public const string CISY = "CISY";

        /// <summary>
        /// CIMCU.
        /// </summary>
        public const string CIMCU = "CIMCU";

        /// <summary>
        /// CIOT6Y.
        /// </summary>
        public const string CIOT6Y = "CIOT6Y";

        /// <summary>
        /// CISCTL.
        /// </summary>
        public const string CISCTL = "CISCTL";

        /// <summary>
        /// CISEPS.
        /// </summary>
        public const string CISEPS = "CISEPS";

        /// <summary>
        /// CISYM6.
        /// </summary>
        public const string CISYM6 = "CISYM6";

        /// <summary>
        /// CILAF.
        /// </summary>
        public const string CILAF = "CILAF";

        /// <summary>
        /// CILTFM.
        /// </summary>
        public const string CILTFM = "CILTFM";

        /// <summary>
        /// CIRWLA.
        /// </summary>
        public const string CIRWLA = "CIRWLA";

        /// <summary>
        /// CILNPA.
        /// </summary>
        public const string CILNPA = "CILNPA";

        /// <summary>
        /// CINCOOC.
        /// </summary>
        public const string CINCOOC = "CINCOOC";

        /// <summary>
        /// CICSNBF.
        /// </summary>
        public const string CICSNBF = "CICSNBF";
    }

    /// <inheritdoc />
    public override string TableName => "F41001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CIPRIM", "CIPRIM", JdeDataType.String, 2),
        new JdeField("CISYM1", "CISYM1", JdeDataType.String, 2),
        new JdeField("CISYM2", "CISYM2", JdeDataType.String, 2),
        new JdeField("CISYM3", "CISYM3", JdeDataType.String, 2),
        new JdeField("CISYM5", "CISYM5", JdeDataType.String, 2),
        new JdeField("CISECD", "CISECD", JdeDataType.String, 2),
        new JdeField("CISEPL", "CISEPL", JdeDataType.String, 2),
        new JdeField("CISE01", "CISE01", JdeDataType.Numeric),
        new JdeField("CISE02", "CISE02", JdeDataType.Numeric),
        new JdeField("CISE03", "CISE03", JdeDataType.Numeric),
        new JdeField("CISE04", "CISE04", JdeDataType.Numeric),
        new JdeField("CISE05", "CISE05", JdeDataType.Numeric),
        new JdeField("CISE06", "CISE06", JdeDataType.Numeric),
        new JdeField("CISE07", "CISE07", JdeDataType.Numeric),
        new JdeField("CISE08", "CISE08", JdeDataType.Numeric),
        new JdeField("CISE09", "CISE09", JdeDataType.Numeric),
        new JdeField("CISE10", "CISE10", JdeDataType.Numeric),
        new JdeField("CILR01", "CILR01", JdeDataType.String, 2),
        new JdeField("CILR02", "CILR02", JdeDataType.String, 2),
        new JdeField("CILR03", "CILR03", JdeDataType.String, 2),
        new JdeField("CILR04", "CILR04", JdeDataType.String, 2),
        new JdeField("CILR05", "CILR05", JdeDataType.String, 2),
        new JdeField("CILR06", "CILR06", JdeDataType.String, 2),
        new JdeField("CILR07", "CILR07", JdeDataType.String, 2),
        new JdeField("CILR08", "CILR08", JdeDataType.String, 2),
        new JdeField("CILR09", "CILR09", JdeDataType.String, 2),
        new JdeField("CILR10", "CILR10", JdeDataType.String, 2),
        new JdeField("CIAN8", "CIAN8", JdeDataType.Numeric),
        new JdeField("CIPOCS", "CIPOCS", JdeDataType.Numeric),
        new JdeField("CIINCS", "CIINCS", JdeDataType.Numeric),
        new JdeField("CIIALP", "CIIALP", JdeDataType.Numeric),
        new JdeField("CIBSDY", "CIBSDY", JdeDataType.Numeric),
        new JdeField("CIIA1", "CIIA1", JdeDataType.Numeric),
        new JdeField("CIIB1", "CIIB1", JdeDataType.Numeric),
        new JdeField("CIIC1", "CIIC1", JdeDataType.Numeric),
        new JdeField("CIIA2", "CIIA2", JdeDataType.Numeric),
        new JdeField("CIIB2", "CIIB2", JdeDataType.Numeric),
        new JdeField("CIIC2", "CIIC2", JdeDataType.Numeric),
        new JdeField("CIIA3", "CIIA3", JdeDataType.Numeric),
        new JdeField("CIIB3", "CIIB3", JdeDataType.Numeric),
        new JdeField("CIIC3", "CIIC3", JdeDataType.Numeric),
        new JdeField("CIPNC", "CIPNC", JdeDataType.Numeric),
        new JdeField("CIGLPO", "CIGLPO", JdeDataType.String, 2),
        new JdeField("CIUNGL", "CIUNGL", JdeDataType.String, 2),
        new JdeField("CICMGL", "CICMGL", JdeDataType.String, 2),
        new JdeField("CICSMT", "CICSMT", JdeDataType.String, 4),
        new JdeField("CIPCSM", "CIPCSM", JdeDataType.String, 4),
        new JdeField("CIBACK", "CIBACK", JdeDataType.String, 2),
        new JdeField("CICOMH", "CICOMH", JdeDataType.Numeric),
        new JdeField("CIICRI", "CIICRI", JdeDataType.String, 2),
        new JdeField("CIIARI", "CIIARI", JdeDataType.String, 2),
        new JdeField("CIMATY", "CIMATY", JdeDataType.String, 2),
        new JdeField("CIXRT", "CIXRT", JdeDataType.String, 4),
        new JdeField("CIXRT2", "CIXRT2", JdeDataType.String, 4),
        new JdeField("CIARTG", "CIARTG", JdeDataType.String, 24),
        new JdeField("CIDA01", "CIDA01", JdeDataType.String, 2),
        new JdeField("CIDA02", "CIDA02", JdeDataType.String, 2),
        new JdeField("CIDA03", "CIDA03", JdeDataType.String, 2),
        new JdeField("CIDA04", "CIDA04", JdeDataType.String, 2),
        new JdeField("CIDA05", "CIDA05", JdeDataType.String, 2),
        new JdeField("CIDA06", "CIDA06", JdeDataType.String, 2),
        new JdeField("CIDA07", "CIDA07", JdeDataType.String, 2),
        new JdeField("CIDA08", "CIDA08", JdeDataType.String, 2),
        new JdeField("CIDA09", "CIDA09", JdeDataType.String, 2),
        new JdeField("CIDA10", "CIDA10", JdeDataType.String, 2),
        new JdeField("CIDA11", "CIDA11", JdeDataType.String, 2),
        new JdeField("CIDA12", "CIDA12", JdeDataType.String, 2),
        new JdeField("CIDA13", "CIDA13", JdeDataType.String, 2),
        new JdeField("CIDA14", "CIDA14", JdeDataType.String, 2),
        new JdeField("CIDA15", "CIDA15", JdeDataType.String, 2),
        new JdeField("CIDA16", "CIDA16", JdeDataType.String, 2),
        new JdeField("CISYM4", "CISYM4", JdeDataType.String, 2),
        new JdeField("CIWIUM", "CIWIUM", JdeDataType.String, 4),
        new JdeField("CIVUMD", "CIVUMD", JdeDataType.String, 4),
        new JdeField("CIUWUM", "CIUWUM", JdeDataType.String, 4),
        new JdeField("CIULOT", "CIULOT", JdeDataType.String, 2),
        new JdeField("CILCTL", "CILCTL", JdeDataType.String, 2),
        new JdeField("CIWCTL", "CIWCTL", JdeDataType.String, 2),
        new JdeField("CIMVER", "CIMVER", JdeDataType.String, 6),
        new JdeField("CICLOC", "CICLOC", JdeDataType.String, 40),
        new JdeField("CIXLOC", "CIXLOC", JdeDataType.String, 40),
        new JdeField("CISTPU", "CISTPU", JdeDataType.String, 2),
        new JdeField("CIDNTP", "CIDNTP", JdeDataType.String, 2),
        new JdeField("CITMPS", "CITMPS", JdeDataType.Numeric),
        new JdeField("CIUSMT", "CIUSMT", JdeDataType.String, 2),
        new JdeField("CIOT1Y", "CIOT1Y", JdeDataType.String, 2),
        new JdeField("CIOT2Y", "CIOT2Y", JdeDataType.String, 2),
        new JdeField("CIOT3Y", "CIOT3Y", JdeDataType.String, 2),
        new JdeField("CIOT4Y", "CIOT4Y", JdeDataType.String, 2),
        new JdeField("CIOT5Y", "CIOT5Y", JdeDataType.String, 2),
        new JdeField("CIUSID", "CIUSID", JdeDataType.String, 2),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CITDAY", "CITDAY", JdeDataType.Numeric),
        new JdeField("CISY", "CISY", JdeDataType.String, 8, true, true),
        new JdeField("CIMCU", "CIMCU", JdeDataType.String, 24, true, true),
        new JdeField("CIOT6Y", "CIOT6Y", JdeDataType.String, 2),
        new JdeField("CISCTL", "CISCTL", JdeDataType.String, 2),
        new JdeField("CISEPS", "CISEPS", JdeDataType.String, 2),
        new JdeField("CISYM6", "CISYM6", JdeDataType.String, 2),
        new JdeField("CILAF", "CILAF", JdeDataType.String, 2),
        new JdeField("CILTFM", "CILTFM", JdeDataType.String, 2),
        new JdeField("CIRWLA", "CIRWLA", JdeDataType.String, 2),
        new JdeField("CILNPA", "CILNPA", JdeDataType.String, 2),
        new JdeField("CINCOOC", "CINCOOC", JdeDataType.String, 6),
        new JdeField("CICSNBF", "CICSNBF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41001_0", "Primary Key on CISY, CIMCU", new[] { "CISY", "CIMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41001_2", "Index on CIAN8", new[] { "CIAN8" })
    };
}
