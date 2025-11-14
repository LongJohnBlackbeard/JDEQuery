using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I03 - .
/// </summary>
public class F42I03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// OICNUKID.
        /// </summary>
        public const string OICNUKID = "OICNUKID";

        /// <summary>
        /// OICONSTYP.
        /// </summary>
        public const string OICONSTYP = "OICONSTYP";

        /// <summary>
        /// OIOCONBN.
        /// </summary>
        public const string OIOCONBN = "OIOCONBN";

        /// <summary>
        /// OIREVQTY.
        /// </summary>
        public const string OIREVQTY = "OIREVQTY";

        /// <summary>
        /// OISREVQTY.
        /// </summary>
        public const string OISREVQTY = "OISREVQTY";

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
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OISHAN.
        /// </summary>
        public const string OISHAN = "OISHAN";

        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OIITM.
        /// </summary>
        public const string OIITM = "OIITM";

        /// <summary>
        /// OILITM.
        /// </summary>
        public const string OILITM = "OILITM";

        /// <summary>
        /// OILOCN.
        /// </summary>
        public const string OILOCN = "OILOCN";

        /// <summary>
        /// OILOTN.
        /// </summary>
        public const string OILOTN = "OILOTN";

        /// <summary>
        /// OICONQTY.
        /// </summary>
        public const string OICONQTY = "OICONQTY";

        /// <summary>
        /// OIUOM.
        /// </summary>
        public const string OIUOM = "OIUOM";

        /// <summary>
        /// OISCONQTY.
        /// </summary>
        public const string OISCONQTY = "OISCONQTY";

        /// <summary>
        /// OIUOM2.
        /// </summary>
        public const string OIUOM2 = "OIUOM2";

        /// <summary>
        /// OICONSDT.
        /// </summary>
        public const string OICONSDT = "OICONSDT";

        /// <summary>
        /// OICONBN.
        /// </summary>
        public const string OICONBN = "OICONBN";

        /// <summary>
        /// OIPOCUST.
        /// </summary>
        public const string OIPOCUST = "OIPOCUST";

        /// <summary>
        /// OIREPLFLG.
        /// </summary>
        public const string OIREPLFLG = "OIREPLFLG";

        /// <summary>
        /// OIREPLDT.
        /// </summary>
        public const string OIREPLDT = "OIREPLDT";

        /// <summary>
        /// OIBILLFLG.
        /// </summary>
        public const string OIBILLFLG = "OIBILLFLG";

        /// <summary>
        /// OIBILLDT.
        /// </summary>
        public const string OIBILLDT = "OIBILLDT";

        /// <summary>
        /// OIRLINVFLG.
        /// </summary>
        public const string OIRLINVFLG = "OIRLINVFLG";

        /// <summary>
        /// OIDOC.
        /// </summary>
        public const string OIDOC = "OIDOC";

        /// <summary>
        /// OIDCT.
        /// </summary>
        public const string OIDCT = "OIDCT";

        /// <summary>
        /// OIKCO.
        /// </summary>
        public const string OIKCO = "OIKCO";

        /// <summary>
        /// OIRRDOCO.
        /// </summary>
        public const string OIRRDOCO = "OIRRDOCO";

        /// <summary>
        /// OIRRDCTO.
        /// </summary>
        public const string OIRRDCTO = "OIRRDCTO";

        /// <summary>
        /// OIRRKCOO.
        /// </summary>
        public const string OIRRKCOO = "OIRRKCOO";

        /// <summary>
        /// OIRRLNID.
        /// </summary>
        public const string OIRRLNID = "OIRRLNID";

        /// <summary>
        /// OIRBDOCO.
        /// </summary>
        public const string OIRBDOCO = "OIRBDOCO";

        /// <summary>
        /// OIRBDCTO.
        /// </summary>
        public const string OIRBDCTO = "OIRBDCTO";

        /// <summary>
        /// OICRCD.
        /// </summary>
        public const string OICRCD = "OICRCD";

        /// <summary>
        /// OIRBKCOO.
        /// </summary>
        public const string OIRBKCOO = "OIRBKCOO";

        /// <summary>
        /// OIRBLNID.
        /// </summary>
        public const string OIRBLNID = "OIRBLNID";

        /// <summary>
        /// OIRCONDATE.
        /// </summary>
        public const string OIRCONDATE = "OIRCONDATE";

        /// <summary>
        /// OIOVPRFLG.
        /// </summary>
        public const string OIOVPRFLG = "OIOVPRFLG";

        /// <summary>
        /// OIOVRQFLG.
        /// </summary>
        public const string OIOVRQFLG = "OIOVRQFLG";

        /// <summary>
        /// OICONSMDE.
        /// </summary>
        public const string OICONSMDE = "OICONSMDE";

        /// <summary>
        /// OIOIPR.
        /// </summary>
        public const string OIOIPR = "OIOIPR";

        /// <summary>
        /// OIPRSEQ.
        /// </summary>
        public const string OIPRSEQ = "OIPRSEQ";

        /// <summary>
        /// OIFRSCHE.
        /// </summary>
        public const string OIFRSCHE = "OIFRSCHE";

        /// <summary>
        /// OIRFC5.
        /// </summary>
        public const string OIRFC5 = "OIRFC5";

        /// <summary>
        /// OIRFC6.
        /// </summary>
        public const string OIRFC6 = "OIRFC6";

        /// <summary>
        /// OIRFC7.
        /// </summary>
        public const string OIRFC7 = "OIRFC7";

        /// <summary>
        /// OIRFC8.
        /// </summary>
        public const string OIRFC8 = "OIRFC8";

        /// <summary>
        /// OIFUCHAR16.
        /// </summary>
        public const string OIFUCHAR16 = "OIFUCHAR16";

        /// <summary>
        /// OIFUCHAR17.
        /// </summary>
        public const string OIFUCHAR17 = "OIFUCHAR17";

        /// <summary>
        /// OIFUCHAR18.
        /// </summary>
        public const string OIFUCHAR18 = "OIFUCHAR18";

        /// <summary>
        /// OIFUNUM16.
        /// </summary>
        public const string OIFUNUM16 = "OIFUNUM16";

        /// <summary>
        /// OIFUNUM17.
        /// </summary>
        public const string OIFUNUM17 = "OIFUNUM17";

        /// <summary>
        /// OIFUNUM18.
        /// </summary>
        public const string OIFUNUM18 = "OIFUNUM18";

        /// <summary>
        /// OIFUTSTR16.
        /// </summary>
        public const string OIFUTSTR16 = "OIFUTSTR16";

        /// <summary>
        /// OIFUTSTR17.
        /// </summary>
        public const string OIFUTSTR17 = "OIFUTSTR17";

        /// <summary>
        /// OIFUTSTR18.
        /// </summary>
        public const string OIFUTSTR18 = "OIFUTSTR18";

        /// <summary>
        /// OIFUDT7.
        /// </summary>
        public const string OIFUDT7 = "OIFUDT7";

        /// <summary>
        /// OIFUDT11.
        /// </summary>
        public const string OIFUDT11 = "OIFUDT11";

        /// <summary>
        /// OIFUDT21.
        /// </summary>
        public const string OIFUDT21 = "OIFUDT21";

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
        /// OITDAY.
        /// </summary>
        public const string OITDAY = "OITDAY";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

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
    public override string TableName => "F42I03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OICNUKID", "OICNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OICONSTYP", "OICONSTYP", JdeDataType.String, 4),
        new JdeField("OIOCONBN", "OIOCONBN", JdeDataType.Numeric),
        new JdeField("OIREVQTY", "OIREVQTY", JdeDataType.Numeric),
        new JdeField("OISREVQTY", "OISREVQTY", JdeDataType.Numeric),
        new JdeField("OIDMCT", "OIDMCT", JdeDataType.String, 24),
        new JdeField("OIDMCS", "OIDMCS", JdeDataType.Numeric),
        new JdeField("OISEQ", "OISEQ", JdeDataType.Numeric),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OISHAN", "OISHAN", JdeDataType.Numeric),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OILOCN", "OILOCN", JdeDataType.String, 40),
        new JdeField("OILOTN", "OILOTN", JdeDataType.String, 60),
        new JdeField("OICONQTY", "OICONQTY", JdeDataType.Numeric),
        new JdeField("OIUOM", "OIUOM", JdeDataType.String, 4),
        new JdeField("OISCONQTY", "OISCONQTY", JdeDataType.Numeric),
        new JdeField("OIUOM2", "OIUOM2", JdeDataType.String, 4),
        new JdeField("OICONSDT", "OICONSDT", JdeDataType.Numeric),
        new JdeField("OICONBN", "OICONBN", JdeDataType.Numeric),
        new JdeField("OIPOCUST", "OIPOCUST", JdeDataType.String, 50),
        new JdeField("OIREPLFLG", "OIREPLFLG", JdeDataType.String, 2),
        new JdeField("OIREPLDT", "OIREPLDT", JdeDataType.Numeric),
        new JdeField("OIBILLFLG", "OIBILLFLG", JdeDataType.String, 2),
        new JdeField("OIBILLDT", "OIBILLDT", JdeDataType.Numeric),
        new JdeField("OIRLINVFLG", "OIRLINVFLG", JdeDataType.String, 2),
        new JdeField("OIDOC", "OIDOC", JdeDataType.Numeric),
        new JdeField("OIDCT", "OIDCT", JdeDataType.String, 4),
        new JdeField("OIKCO", "OIKCO", JdeDataType.String, 10),
        new JdeField("OIRRDOCO", "OIRRDOCO", JdeDataType.Numeric),
        new JdeField("OIRRDCTO", "OIRRDCTO", JdeDataType.String, 4),
        new JdeField("OIRRKCOO", "OIRRKCOO", JdeDataType.String, 10),
        new JdeField("OIRRLNID", "OIRRLNID", JdeDataType.Numeric),
        new JdeField("OIRBDOCO", "OIRBDOCO", JdeDataType.Numeric),
        new JdeField("OIRBDCTO", "OIRBDCTO", JdeDataType.String, 4),
        new JdeField("OICRCD", "OICRCD", JdeDataType.String, 6),
        new JdeField("OIRBKCOO", "OIRBKCOO", JdeDataType.String, 10),
        new JdeField("OIRBLNID", "OIRBLNID", JdeDataType.Numeric),
        new JdeField("OIRCONDATE", "OIRCONDATE", JdeDataType.Numeric),
        new JdeField("OIOVPRFLG", "OIOVPRFLG", JdeDataType.String, 2),
        new JdeField("OIOVRQFLG", "OIOVRQFLG", JdeDataType.String, 2),
        new JdeField("OICONSMDE", "OICONSMDE", JdeDataType.String, 2),
        new JdeField("OIOIPR", "OIOIPR", JdeDataType.String, 16),
        new JdeField("OIPRSEQ", "OIPRSEQ", JdeDataType.Numeric),
        new JdeField("OIFRSCHE", "OIFRSCHE", JdeDataType.String, 2),
        new JdeField("OIRFC5", "OIRFC5", JdeDataType.String, 50),
        new JdeField("OIRFC6", "OIRFC6", JdeDataType.String, 50),
        new JdeField("OIRFC7", "OIRFC7", JdeDataType.String, 50),
        new JdeField("OIRFC8", "OIRFC8", JdeDataType.String, 50),
        new JdeField("OIFUCHAR16", "OIFUCHAR16", JdeDataType.String, 2),
        new JdeField("OIFUCHAR17", "OIFUCHAR17", JdeDataType.String, 2),
        new JdeField("OIFUCHAR18", "OIFUCHAR18", JdeDataType.String, 2),
        new JdeField("OIFUNUM16", "OIFUNUM16", JdeDataType.Numeric),
        new JdeField("OIFUNUM17", "OIFUNUM17", JdeDataType.Numeric),
        new JdeField("OIFUNUM18", "OIFUNUM18", JdeDataType.Numeric),
        new JdeField("OIFUTSTR16", "OIFUTSTR16", JdeDataType.String, 100),
        new JdeField("OIFUTSTR17", "OIFUTSTR17", JdeDataType.String, 100),
        new JdeField("OIFUTSTR18", "OIFUTSTR18", JdeDataType.String, 100),
        new JdeField("OIFUDT7", "OIFUDT7", JdeDataType.Numeric),
        new JdeField("OIFUDT11", "OIFUDT11", JdeDataType.Numeric),
        new JdeField("OIFUDT21", "OIFUDT21", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OIURAT", "OIURAT", JdeDataType.Numeric),
        new JdeField("OIURCD", "OIURCD", JdeDataType.String, 4),
        new JdeField("OIURDT", "OIURDT", JdeDataType.Numeric),
        new JdeField("OIURAB", "OIURAB", JdeDataType.Numeric),
        new JdeField("OIURRF", "OIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I03_0", "Primary Key on OIDOCO, OIDCTO, OIKCOO, OILNID, OICNUKID", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID", "OICNUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I03_2", "Index on OIDOCO, OIDCTO, OIKCOO, OILNID, OIDMCT, OIDMCS", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID", "OIDMCT", "OIDMCS" }),
        new JdeIndex("F42I03_3", "Index on OIRBDOCO, OIRBDCTO, OIRBKCOO, OIRBLNID", new[] { "OIRBDOCO", "OIRBDCTO", "OIRBKCOO", "OIRBLNID" }),
        new JdeIndex("F42I03_4", "Index on OIDMCT, OIDMCS, OISEQ", new[] { "OIDMCT", "OIDMCS", "OISEQ" })
    };
}
