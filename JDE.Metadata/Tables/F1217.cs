using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1217 - .
/// </summary>
public class F1217 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WRNUMB.
        /// </summary>
        public const string WRNUMB = "WRNUMB";

        /// <summary>
        /// WRCTR.
        /// </summary>
        public const string WRCTR = "WRCTR";

        /// <summary>
        /// WRCOOWN.
        /// </summary>
        public const string WRCOOWN = "WRCOOWN";

        /// <summary>
        /// WRMMCU.
        /// </summary>
        public const string WRMMCU = "WRMMCU";

        /// <summary>
        /// WRDOCO.
        /// </summary>
        public const string WRDOCO = "WRDOCO";

        /// <summary>
        /// WRDCTO.
        /// </summary>
        public const string WRDCTO = "WRDCTO";

        /// <summary>
        /// WRKCOO.
        /// </summary>
        public const string WRKCOO = "WRKCOO";

        /// <summary>
        /// WRLNID.
        /// </summary>
        public const string WRLNID = "WRLNID";

        /// <summary>
        /// WRORDJ.
        /// </summary>
        public const string WRORDJ = "WRORDJ";

        /// <summary>
        /// WRSHPJ.
        /// </summary>
        public const string WRSHPJ = "WRSHPJ";

        /// <summary>
        /// WRADDJ.
        /// </summary>
        public const string WRADDJ = "WRADDJ";

        /// <summary>
        /// WRSHAN.
        /// </summary>
        public const string WRSHAN = "WRSHAN";

        /// <summary>
        /// WRPA8.
        /// </summary>
        public const string WRPA8 = "WRPA8";

        /// <summary>
        /// WRSLSM.
        /// </summary>
        public const string WRSLSM = "WRSLSM";

        /// <summary>
        /// WRANOB.
        /// </summary>
        public const string WRANOB = "WRANOB";

        /// <summary>
        /// WRRORN.
        /// </summary>
        public const string WRRORN = "WRRORN";

        /// <summary>
        /// WRRCTO.
        /// </summary>
        public const string WRRCTO = "WRRCTO";

        /// <summary>
        /// WRSTRX.
        /// </summary>
        public const string WRSTRX = "WRSTRX";

        /// <summary>
        /// WRVEND.
        /// </summary>
        public const string WRVEND = "WRVEND";

        /// <summary>
        /// WROORN.
        /// </summary>
        public const string WROORN = "WROORN";

        /// <summary>
        /// WROCTO.
        /// </summary>
        public const string WROCTO = "WROCTO";

        /// <summary>
        /// WROKCO.
        /// </summary>
        public const string WROKCO = "WROKCO";

        /// <summary>
        /// WRSFXO.
        /// </summary>
        public const string WRSFXO = "WRSFXO";

        /// <summary>
        /// WROGNO.
        /// </summary>
        public const string WROGNO = "WROGNO";

        /// <summary>
        /// WRPRODF.
        /// </summary>
        public const string WRPRODF = "WRPRODF";

        /// <summary>
        /// WRPRODM.
        /// </summary>
        public const string WRPRODM = "WRPRODM";

        /// <summary>
        /// WRPRODC.
        /// </summary>
        public const string WRPRODC = "WRPRODC";

        /// <summary>
        /// WRCMOD.
        /// </summary>
        public const string WRCMOD = "WRCMOD";

        /// <summary>
        /// WRSYEM.
        /// </summary>
        public const string WRSYEM = "WRSYEM";

        /// <summary>
        /// WRVINNU.
        /// </summary>
        public const string WRVINNU = "WRVINNU";

        /// <summary>
        /// WRREFN.
        /// </summary>
        public const string WRREFN = "WRREFN";

        /// <summary>
        /// WRZE01.
        /// </summary>
        public const string WRZE01 = "WRZE01";

        /// <summary>
        /// WRZE02.
        /// </summary>
        public const string WRZE02 = "WRZE02";

        /// <summary>
        /// WRZE03.
        /// </summary>
        public const string WRZE03 = "WRZE03";

        /// <summary>
        /// WRZE04.
        /// </summary>
        public const string WRZE04 = "WRZE04";

        /// <summary>
        /// WRZE05.
        /// </summary>
        public const string WRZE05 = "WRZE05";

        /// <summary>
        /// WRZE06.
        /// </summary>
        public const string WRZE06 = "WRZE06";

        /// <summary>
        /// WRZE07.
        /// </summary>
        public const string WRZE07 = "WRZE07";

        /// <summary>
        /// WRZE08.
        /// </summary>
        public const string WRZE08 = "WRZE08";

        /// <summary>
        /// WRZE09.
        /// </summary>
        public const string WRZE09 = "WRZE09";

        /// <summary>
        /// WRZE10.
        /// </summary>
        public const string WRZE10 = "WRZE10";

        /// <summary>
        /// WRURCD.
        /// </summary>
        public const string WRURCD = "WRURCD";

        /// <summary>
        /// WRURDT.
        /// </summary>
        public const string WRURDT = "WRURDT";

        /// <summary>
        /// WRURAT.
        /// </summary>
        public const string WRURAT = "WRURAT";

        /// <summary>
        /// WRURAB.
        /// </summary>
        public const string WRURAB = "WRURAB";

        /// <summary>
        /// WRURRF.
        /// </summary>
        public const string WRURRF = "WRURRF";

        /// <summary>
        /// WRCRTU.
        /// </summary>
        public const string WRCRTU = "WRCRTU";

        /// <summary>
        /// WRUSER.
        /// </summary>
        public const string WRUSER = "WRUSER";

        /// <summary>
        /// WRPID.
        /// </summary>
        public const string WRPID = "WRPID";

        /// <summary>
        /// WRJOBN.
        /// </summary>
        public const string WRJOBN = "WRJOBN";

        /// <summary>
        /// WRUPMJ.
        /// </summary>
        public const string WRUPMJ = "WRUPMJ";

        /// <summary>
        /// WRUPMT.
        /// </summary>
        public const string WRUPMT = "WRUPMT";

        /// <summary>
        /// WRLOTN.
        /// </summary>
        public const string WRLOTN = "WRLOTN";

        /// <summary>
        /// WRLOCN.
        /// </summary>
        public const string WRLOCN = "WRLOCN";

        /// <summary>
        /// WRWOD.
        /// </summary>
        public const string WRWOD = "WRWOD";

        /// <summary>
        /// WRBREV.
        /// </summary>
        public const string WRBREV = "WRBREV";

        /// <summary>
        /// WREFFF.
        /// </summary>
        public const string WREFFF = "WREFFF";

        /// <summary>
        /// WRAN8DL.
        /// </summary>
        public const string WRAN8DL = "WRAN8DL";

        /// <summary>
        /// WRAN8AS.
        /// </summary>
        public const string WRAN8AS = "WRAN8AS";

        /// <summary>
        /// WRTERMYN.
        /// </summary>
        public const string WRTERMYN = "WRTERMYN";

        /// <summary>
        /// WRSATYP.
        /// </summary>
        public const string WRSATYP = "WRSATYP";

        /// <summary>
        /// WRINSDTE.
        /// </summary>
        public const string WRINSDTE = "WRINSDTE";

        /// <summary>
        /// WRMCU.
        /// </summary>
        public const string WRMCU = "WRMCU";

        /// <summary>
        /// WRMRRYN.
        /// </summary>
        public const string WRMRRYN = "WRMRRYN";

        /// <summary>
        /// WRREGSTS.
        /// </summary>
        public const string WRREGSTS = "WRREGSTS";

        /// <summary>
        /// WRVMRS31.
        /// </summary>
        public const string WRVMRS31 = "WRVMRS31";

        /// <summary>
        /// WRVMRS32.
        /// </summary>
        public const string WRVMRS32 = "WRVMRS32";

        /// <summary>
        /// WRVMRS34.
        /// </summary>
        public const string WRVMRS34 = "WRVMRS34";

        /// <summary>
        /// WRAN8DR.
        /// </summary>
        public const string WRAN8DR = "WRAN8DR";

        /// <summary>
        /// WREQPN.
        /// </summary>
        public const string WREQPN = "WREQPN";

        /// <summary>
        /// WRMTRYN.
        /// </summary>
        public const string WRMTRYN = "WRMTRYN";
    }

    /// <inheritdoc />
    public override string TableName => "F1217";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WRNUMB", "WRNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("WRCTR", "WRCTR", JdeDataType.String, 6),
        new JdeField("WRCOOWN", "WRCOOWN", JdeDataType.String, 2),
        new JdeField("WRMMCU", "WRMMCU", JdeDataType.String, 24),
        new JdeField("WRDOCO", "WRDOCO", JdeDataType.Numeric),
        new JdeField("WRDCTO", "WRDCTO", JdeDataType.String, 4),
        new JdeField("WRKCOO", "WRKCOO", JdeDataType.String, 10),
        new JdeField("WRLNID", "WRLNID", JdeDataType.Numeric),
        new JdeField("WRORDJ", "WRORDJ", JdeDataType.Numeric),
        new JdeField("WRSHPJ", "WRSHPJ", JdeDataType.Numeric),
        new JdeField("WRADDJ", "WRADDJ", JdeDataType.Numeric),
        new JdeField("WRSHAN", "WRSHAN", JdeDataType.Numeric),
        new JdeField("WRPA8", "WRPA8", JdeDataType.Numeric),
        new JdeField("WRSLSM", "WRSLSM", JdeDataType.Numeric),
        new JdeField("WRANOB", "WRANOB", JdeDataType.Numeric),
        new JdeField("WRRORN", "WRRORN", JdeDataType.String, 16),
        new JdeField("WRRCTO", "WRRCTO", JdeDataType.String, 4),
        new JdeField("WRSTRX", "WRSTRX", JdeDataType.Numeric),
        new JdeField("WRVEND", "WRVEND", JdeDataType.Numeric),
        new JdeField("WROORN", "WROORN", JdeDataType.String, 16),
        new JdeField("WROCTO", "WROCTO", JdeDataType.String, 4),
        new JdeField("WROKCO", "WROKCO", JdeDataType.String, 10),
        new JdeField("WRSFXO", "WRSFXO", JdeDataType.String, 6),
        new JdeField("WROGNO", "WROGNO", JdeDataType.Numeric),
        new JdeField("WRPRODF", "WRPRODF", JdeDataType.String, 16),
        new JdeField("WRPRODM", "WRPRODM", JdeDataType.String, 16),
        new JdeField("WRPRODC", "WRPRODC", JdeDataType.String, 20),
        new JdeField("WRCMOD", "WRCMOD", JdeDataType.String, 50),
        new JdeField("WRSYEM", "WRSYEM", JdeDataType.String, 72),
        new JdeField("WRVINNU", "WRVINNU", JdeDataType.String, 60),
        new JdeField("WRREFN", "WRREFN", JdeDataType.String, 60),
        new JdeField("WRZE01", "WRZE01", JdeDataType.String, 20),
        new JdeField("WRZE02", "WRZE02", JdeDataType.String, 20),
        new JdeField("WRZE03", "WRZE03", JdeDataType.String, 20),
        new JdeField("WRZE04", "WRZE04", JdeDataType.String, 20),
        new JdeField("WRZE05", "WRZE05", JdeDataType.String, 20),
        new JdeField("WRZE06", "WRZE06", JdeDataType.String, 20),
        new JdeField("WRZE07", "WRZE07", JdeDataType.String, 20),
        new JdeField("WRZE08", "WRZE08", JdeDataType.String, 20),
        new JdeField("WRZE09", "WRZE09", JdeDataType.String, 20),
        new JdeField("WRZE10", "WRZE10", JdeDataType.String, 20),
        new JdeField("WRURCD", "WRURCD", JdeDataType.String, 4),
        new JdeField("WRURDT", "WRURDT", JdeDataType.Numeric),
        new JdeField("WRURAT", "WRURAT", JdeDataType.Numeric),
        new JdeField("WRURAB", "WRURAB", JdeDataType.Numeric),
        new JdeField("WRURRF", "WRURRF", JdeDataType.String, 30),
        new JdeField("WRCRTU", "WRCRTU", JdeDataType.String, 20),
        new JdeField("WRUSER", "WRUSER", JdeDataType.String, 20),
        new JdeField("WRPID", "WRPID", JdeDataType.String, 20),
        new JdeField("WRJOBN", "WRJOBN", JdeDataType.String, 20),
        new JdeField("WRUPMJ", "WRUPMJ", JdeDataType.Numeric),
        new JdeField("WRUPMT", "WRUPMT", JdeDataType.Numeric),
        new JdeField("WRLOTN", "WRLOTN", JdeDataType.String, 60),
        new JdeField("WRLOCN", "WRLOCN", JdeDataType.String, 40),
        new JdeField("WRWOD", "WRWOD", JdeDataType.Numeric),
        new JdeField("WRBREV", "WRBREV", JdeDataType.String, 6),
        new JdeField("WREFFF", "WREFFF", JdeDataType.Numeric),
        new JdeField("WRAN8DL", "WRAN8DL", JdeDataType.Numeric),
        new JdeField("WRAN8AS", "WRAN8AS", JdeDataType.Numeric),
        new JdeField("WRTERMYN", "WRTERMYN", JdeDataType.String, 2),
        new JdeField("WRSATYP", "WRSATYP", JdeDataType.String, 6),
        new JdeField("WRINSDTE", "WRINSDTE", JdeDataType.Numeric),
        new JdeField("WRMCU", "WRMCU", JdeDataType.String, 24),
        new JdeField("WRMRRYN", "WRMRRYN", JdeDataType.String, 2),
        new JdeField("WRREGSTS", "WRREGSTS", JdeDataType.String, 6),
        new JdeField("WRVMRS31", "WRVMRS31", JdeDataType.String, 4),
        new JdeField("WRVMRS32", "WRVMRS32", JdeDataType.String, 16),
        new JdeField("WRVMRS34", "WRVMRS34", JdeDataType.String, 20),
        new JdeField("WRAN8DR", "WRAN8DR", JdeDataType.Numeric),
        new JdeField("WREQPN", "WREQPN", JdeDataType.Numeric),
        new JdeField("WRMTRYN", "WRMTRYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1217_0", "Primary Key on WRNUMB", new[] { "WRNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1217_2", "Index on WRKCOO, WRDOCO, WRDCTO, WRLNID", new[] { "WRKCOO", "WRDOCO", "WRDCTO", "WRLNID" })
    };
}
