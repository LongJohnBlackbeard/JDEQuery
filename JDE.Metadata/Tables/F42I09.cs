using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I09 - .
/// </summary>
public class F42I09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIDMCT.
        /// </summary>
        public const string OIDMCT = "OIDMCT";

        /// <summary>
        /// OIDMCS.
        /// </summary>
        public const string OIDMCS = "OIDMCS";

        /// <summary>
        /// OISEQ.
        /// </summary>
        public const string OISEQ = "OISEQ";

        /// <summary>
        /// OIDOCRET.
        /// </summary>
        public const string OIDOCRET = "OIDOCRET";

        /// <summary>
        /// OIRETLNID.
        /// </summary>
        public const string OIRETLNID = "OIRETLNID";

        /// <summary>
        /// OIDOCO.
        /// </summary>
        public const string OIDOCO = "OIDOCO";

        /// <summary>
        /// OIDCTO.
        /// </summary>
        public const string OIDCTO = "OIDCTO";

        /// <summary>
        /// OIKCOO.
        /// </summary>
        public const string OIKCOO = "OIKCOO";

        /// <summary>
        /// OILNID.
        /// </summary>
        public const string OILNID = "OILNID";

        /// <summary>
        /// OILNTY.
        /// </summary>
        public const string OILNTY = "OILNTY";

        /// <summary>
        /// OISFXO.
        /// </summary>
        public const string OISFXO = "OISFXO";

        /// <summary>
        /// OIITM.
        /// </summary>
        public const string OIITM = "OIITM";

        /// <summary>
        /// OILITM.
        /// </summary>
        public const string OILITM = "OILITM";

        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OILOCN.
        /// </summary>
        public const string OILOCN = "OILOCN";

        /// <summary>
        /// OILOTN.
        /// </summary>
        public const string OILOTN = "OILOTN";

        /// <summary>
        /// OILOCNTO.
        /// </summary>
        public const string OILOCNTO = "OILOCNTO";

        /// <summary>
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OISHAN.
        /// </summary>
        public const string OISHAN = "OISHAN";

        /// <summary>
        /// OITRAQTY.
        /// </summary>
        public const string OITRAQTY = "OITRAQTY";

        /// <summary>
        /// OIUOM1.
        /// </summary>
        public const string OIUOM1 = "OIUOM1";

        /// <summary>
        /// OISTRAQTY.
        /// </summary>
        public const string OISTRAQTY = "OISTRAQTY";

        /// <summary>
        /// OIUOM2.
        /// </summary>
        public const string OIUOM2 = "OIUOM2";

        /// <summary>
        /// OI42IRT.
        /// </summary>
        public const string OI42IRT = "OI42IRT";

        /// <summary>
        /// OIPOCUST.
        /// </summary>
        public const string OIPOCUST = "OIPOCUST";

        /// <summary>
        /// OIRORN.
        /// </summary>
        public const string OIRORN = "OIRORN";

        /// <summary>
        /// OIRCTO.
        /// </summary>
        public const string OIRCTO = "OIRCTO";

        /// <summary>
        /// OIRKCO.
        /// </summary>
        public const string OIRKCO = "OIRKCO";

        /// <summary>
        /// OIRLLN.
        /// </summary>
        public const string OIRLLN = "OIRLLN";

        /// <summary>
        /// OIPODOCO.
        /// </summary>
        public const string OIPODOCO = "OIPODOCO";

        /// <summary>
        /// OIOCTO.
        /// </summary>
        public const string OIOCTO = "OIOCTO";

        /// <summary>
        /// OIOKCO.
        /// </summary>
        public const string OIOKCO = "OIOKCO";

        /// <summary>
        /// OIPOLN.
        /// </summary>
        public const string OIPOLN = "OIPOLN";

        /// <summary>
        /// OISODOCO.
        /// </summary>
        public const string OISODOCO = "OISODOCO";

        /// <summary>
        /// OIRETST.
        /// </summary>
        public const string OIRETST = "OIRETST";

        /// <summary>
        /// OIOLTY.
        /// </summary>
        public const string OIOLTY = "OIOLTY";

        /// <summary>
        /// OIOIPR.
        /// </summary>
        public const string OIOIPR = "OIOIPR";

        /// <summary>
        /// OIPRSEQ.
        /// </summary>
        public const string OIPRSEQ = "OIPRSEQ";

        /// <summary>
        /// OITRADT.
        /// </summary>
        public const string OITRADT = "OITRADT";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OITDAY.
        /// </summary>
        public const string OITDAY = "OITDAY";

        /// <summary>
        /// OIFUTNUM13.
        /// </summary>
        public const string OIFUTNUM13 = "OIFUTNUM13";

        /// <summary>
        /// OIFUTNUM14.
        /// </summary>
        public const string OIFUTNUM14 = "OIFUTNUM14";

        /// <summary>
        /// OIFUTNUM15.
        /// </summary>
        public const string OIFUTNUM15 = "OIFUTNUM15";

        /// <summary>
        /// OIFUCHAR25.
        /// </summary>
        public const string OIFUCHAR25 = "OIFUCHAR25";

        /// <summary>
        /// OIFUCHAR26.
        /// </summary>
        public const string OIFUCHAR26 = "OIFUCHAR26";

        /// <summary>
        /// OIFUCHAR27.
        /// </summary>
        public const string OIFUCHAR27 = "OIFUCHAR27";

        /// <summary>
        /// OIFUTSTR22.
        /// </summary>
        public const string OIFUTSTR22 = "OIFUTSTR22";

        /// <summary>
        /// OIFUTSTR23.
        /// </summary>
        public const string OIFUTSTR23 = "OIFUTSTR23";

        /// <summary>
        /// OIFUTSTR24.
        /// </summary>
        public const string OIFUTSTR24 = "OIFUTSTR24";

        /// <summary>
        /// OIFUDT32.
        /// </summary>
        public const string OIFUDT32 = "OIFUDT32";

        /// <summary>
        /// OIFUDT33.
        /// </summary>
        public const string OIFUDT33 = "OIFUDT33";

        /// <summary>
        /// OIFUDT34.
        /// </summary>
        public const string OIFUDT34 = "OIFUDT34";

        /// <summary>
        /// OIURAT.
        /// </summary>
        public const string OIURAT = "OIURAT";

        /// <summary>
        /// OIURCD.
        /// </summary>
        public const string OIURCD = "OIURCD";

        /// <summary>
        /// OIURDT.
        /// </summary>
        public const string OIURDT = "OIURDT";

        /// <summary>
        /// OIURAB.
        /// </summary>
        public const string OIURAB = "OIURAB";

        /// <summary>
        /// OIURRF.
        /// </summary>
        public const string OIURRF = "OIURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIDMCT", "OIDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OIDMCS", "OIDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OISEQ", "OISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDOCRET", "OIDOCRET", JdeDataType.Numeric, null, true, true),
        new JdeField("OIRETLNID", "OIRETLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric),
        new JdeField("OILNTY", "OILNTY", JdeDataType.String, 4),
        new JdeField("OISFXO", "OISFXO", JdeDataType.String, 6),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24),
        new JdeField("OILOCN", "OILOCN", JdeDataType.String, 40),
        new JdeField("OILOTN", "OILOTN", JdeDataType.String, 60),
        new JdeField("OILOCNTO", "OILOCNTO", JdeDataType.String, 40),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OISHAN", "OISHAN", JdeDataType.Numeric),
        new JdeField("OITRAQTY", "OITRAQTY", JdeDataType.Numeric),
        new JdeField("OIUOM1", "OIUOM1", JdeDataType.String, 4),
        new JdeField("OISTRAQTY", "OISTRAQTY", JdeDataType.Numeric),
        new JdeField("OIUOM2", "OIUOM2", JdeDataType.String, 4),
        new JdeField("OI42IRT", "OI42IRT", JdeDataType.String, 6),
        new JdeField("OIPOCUST", "OIPOCUST", JdeDataType.String, 50),
        new JdeField("OIRORN", "OIRORN", JdeDataType.String, 16),
        new JdeField("OIRCTO", "OIRCTO", JdeDataType.String, 4),
        new JdeField("OIRKCO", "OIRKCO", JdeDataType.String, 10),
        new JdeField("OIRLLN", "OIRLLN", JdeDataType.Numeric),
        new JdeField("OIPODOCO", "OIPODOCO", JdeDataType.Numeric),
        new JdeField("OIOCTO", "OIOCTO", JdeDataType.String, 4),
        new JdeField("OIOKCO", "OIOKCO", JdeDataType.String, 10),
        new JdeField("OIPOLN", "OIPOLN", JdeDataType.Numeric),
        new JdeField("OISODOCO", "OISODOCO", JdeDataType.Numeric),
        new JdeField("OIRETST", "OIRETST", JdeDataType.Numeric),
        new JdeField("OIOLTY", "OIOLTY", JdeDataType.String, 6),
        new JdeField("OIOIPR", "OIOIPR", JdeDataType.String, 16),
        new JdeField("OIPRSEQ", "OIPRSEQ", JdeDataType.Numeric),
        new JdeField("OITRADT", "OITRADT", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OIFUTNUM13", "OIFUTNUM13", JdeDataType.Numeric),
        new JdeField("OIFUTNUM14", "OIFUTNUM14", JdeDataType.Numeric),
        new JdeField("OIFUTNUM15", "OIFUTNUM15", JdeDataType.Numeric),
        new JdeField("OIFUCHAR25", "OIFUCHAR25", JdeDataType.String, 2),
        new JdeField("OIFUCHAR26", "OIFUCHAR26", JdeDataType.String, 2),
        new JdeField("OIFUCHAR27", "OIFUCHAR27", JdeDataType.String, 2),
        new JdeField("OIFUTSTR22", "OIFUTSTR22", JdeDataType.String, 100),
        new JdeField("OIFUTSTR23", "OIFUTSTR23", JdeDataType.String, 100),
        new JdeField("OIFUTSTR24", "OIFUTSTR24", JdeDataType.String, 100),
        new JdeField("OIFUDT32", "OIFUDT32", JdeDataType.Numeric),
        new JdeField("OIFUDT33", "OIFUDT33", JdeDataType.Numeric),
        new JdeField("OIFUDT34", "OIFUDT34", JdeDataType.Numeric),
        new JdeField("OIURAT", "OIURAT", JdeDataType.Numeric),
        new JdeField("OIURCD", "OIURCD", JdeDataType.String, 4),
        new JdeField("OIURDT", "OIURDT", JdeDataType.Numeric),
        new JdeField("OIURAB", "OIURAB", JdeDataType.Numeric),
        new JdeField("OIURRF", "OIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I09_0", "Primary Key on OIDMCS, OIDMCT, OISEQ, OIDOCRET, OIRETLNID", new[] { "OIDMCS", "OIDMCT", "OISEQ", "OIDOCRET", "OIRETLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I09_2", "Index on OIRORN, OIRCTO, OIRKCO, OIRLLN", new[] { "OIRORN", "OIRCTO", "OIRKCO", "OIRLLN" }),
        new JdeIndex("F42I09_3", "Index on OIPODOCO, OIOCTO, OIOKCO, OIPOLN", new[] { "OIPODOCO", "OIOCTO", "OIOKCO", "OIPOLN" }),
        new JdeIndex("F42I09_4", "Index on OIDOCO, OIDCTO, OIKCOO, OILNID", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID" })
    };
}
