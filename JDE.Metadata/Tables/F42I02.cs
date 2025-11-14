using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I02 - .
/// </summary>
public class F42I02 : JdeTable
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
        /// OILNTY.
        /// </summary>
        public const string OILNTY = "OILNTY";

        /// <summary>
        /// OISFXO.
        /// </summary>
        public const string OISFXO = "OISFXO";

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
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OISHAN.
        /// </summary>
        public const string OISHAN = "OISHAN";

        /// <summary>
        /// OIPQOR.
        /// </summary>
        public const string OIPQOR = "OIPQOR";

        /// <summary>
        /// OIUOM1.
        /// </summary>
        public const string OIUOM1 = "OIUOM1";

        /// <summary>
        /// OISQOR.
        /// </summary>
        public const string OISQOR = "OISQOR";

        /// <summary>
        /// OIUOM2.
        /// </summary>
        public const string OIUOM2 = "OIUOM2";

        /// <summary>
        /// OIACKQTY.
        /// </summary>
        public const string OIACKQTY = "OIACKQTY";

        /// <summary>
        /// OISACKQTY.
        /// </summary>
        public const string OISACKQTY = "OISACKQTY";

        /// <summary>
        /// OIREMAQTY.
        /// </summary>
        public const string OIREMAQTY = "OIREMAQTY";

        /// <summary>
        /// OISREMQTY.
        /// </summary>
        public const string OISREMQTY = "OISREMQTY";

        /// <summary>
        /// OICONQTY.
        /// </summary>
        public const string OICONQTY = "OICONQTY";

        /// <summary>
        /// OIRLOCN.
        /// </summary>
        public const string OIRLOCN = "OIRLOCN";

        /// <summary>
        /// OISCONQTY.
        /// </summary>
        public const string OISCONQTY = "OISCONQTY";

        /// <summary>
        /// OIRETQTYA.
        /// </summary>
        public const string OIRETQTYA = "OIRETQTYA";

        /// <summary>
        /// OISRETQTYA.
        /// </summary>
        public const string OISRETQTYA = "OISRETQTYA";

        /// <summary>
        /// OIREMCQTY.
        /// </summary>
        public const string OIREMCQTY = "OIREMCQTY";

        /// <summary>
        /// OISREMCQTY.
        /// </summary>
        public const string OISREMCQTY = "OISREMCQTY";

        /// <summary>
        /// OIACKLDT.
        /// </summary>
        public const string OIACKLDT = "OIACKLDT";

        /// <summary>
        /// OIRECVDT.
        /// </summary>
        public const string OIRECVDT = "OIRECVDT";

        /// <summary>
        /// OIRSDJ.
        /// </summary>
        public const string OIRSDJ = "OIRSDJ";

        /// <summary>
        /// OICONSDT.
        /// </summary>
        public const string OICONSDT = "OICONSDT";

        /// <summary>
        /// OI42IRT.
        /// </summary>
        public const string OI42IRT = "OI42IRT";

        /// <summary>
        /// OIPOCUST.
        /// </summary>
        public const string OIPOCUST = "OIPOCUST";

        /// <summary>
        /// OIACKST.
        /// </summary>
        public const string OIACKST = "OIACKST";

        /// <summary>
        /// OICONLNST.
        /// </summary>
        public const string OICONLNST = "OICONLNST";

        /// <summary>
        /// OICRCD.
        /// </summary>
        public const string OICRCD = "OICRCD";

        /// <summary>
        /// OISHPN.
        /// </summary>
        public const string OISHPN = "OISHPN";

        /// <summary>
        /// OISOQS.
        /// </summary>
        public const string OISOQS = "OISOQS";

        /// <summary>
        /// OIKITS.
        /// </summary>
        public const string OIKITS = "OIKITS";

        /// <summary>
        /// OIKITID.
        /// </summary>
        public const string OIKITID = "OIKITID";

        /// <summary>
        /// OIKITDIRTY.
        /// </summary>
        public const string OIKITDIRTY = "OIKITDIRTY";

        /// <summary>
        /// OIRLIT.
        /// </summary>
        public const string OIRLIT = "OIRLIT";

        /// <summary>
        /// OIKTLN.
        /// </summary>
        public const string OIKTLN = "OIKTLN";

        /// <summary>
        /// OICPNT.
        /// </summary>
        public const string OICPNT = "OICPNT";

        /// <summary>
        /// OIRKIT.
        /// </summary>
        public const string OIRKIT = "OIRKIT";

        /// <summary>
        /// OIKTP.
        /// </summary>
        public const string OIKTP = "OIKTP";

        /// <summary>
        /// OIOIPR.
        /// </summary>
        public const string OIOIPR = "OIOIPR";

        /// <summary>
        /// OIPRSEQ.
        /// </summary>
        public const string OIPRSEQ = "OIPRSEQ";

        /// <summary>
        /// OIFUCHAR13.
        /// </summary>
        public const string OIFUCHAR13 = "OIFUCHAR13";

        /// <summary>
        /// OIFUCHAR14.
        /// </summary>
        public const string OIFUCHAR14 = "OIFUCHAR14";

        /// <summary>
        /// OIFUCHAR15.
        /// </summary>
        public const string OIFUCHAR15 = "OIFUCHAR15";

        /// <summary>
        /// OIFUNUM13.
        /// </summary>
        public const string OIFUNUM13 = "OIFUNUM13";

        /// <summary>
        /// OIFUNUM14.
        /// </summary>
        public const string OIFUNUM14 = "OIFUNUM14";

        /// <summary>
        /// OIFUNUM15.
        /// </summary>
        public const string OIFUNUM15 = "OIFUNUM15";

        /// <summary>
        /// OIFUTSTR13.
        /// </summary>
        public const string OIFUTSTR13 = "OIFUTSTR13";

        /// <summary>
        /// OIFUTSTR14.
        /// </summary>
        public const string OIFUTSTR14 = "OIFUTSTR14";

        /// <summary>
        /// OIFUTSTR15.
        /// </summary>
        public const string OIFUTSTR15 = "OIFUTSTR15";

        /// <summary>
        /// OIFUDT6.
        /// </summary>
        public const string OIFUDT6 = "OIFUDT6";

        /// <summary>
        /// OIFUDT20.
        /// </summary>
        public const string OIFUDT20 = "OIFUDT20";

        /// <summary>
        /// OIFUDT30.
        /// </summary>
        public const string OIFUDT30 = "OIFUDT30";

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
    public override string TableName => "F42I02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OILNTY", "OILNTY", JdeDataType.String, 4),
        new JdeField("OISFXO", "OISFXO", JdeDataType.String, 6),
        new JdeField("OIDMCT", "OIDMCT", JdeDataType.String, 24),
        new JdeField("OIDMCS", "OIDMCS", JdeDataType.Numeric),
        new JdeField("OISEQ", "OISEQ", JdeDataType.Numeric),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24),
        new JdeField("OILOCN", "OILOCN", JdeDataType.String, 40),
        new JdeField("OILOTN", "OILOTN", JdeDataType.String, 60),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OISHAN", "OISHAN", JdeDataType.Numeric),
        new JdeField("OIPQOR", "OIPQOR", JdeDataType.Numeric),
        new JdeField("OIUOM1", "OIUOM1", JdeDataType.String, 4),
        new JdeField("OISQOR", "OISQOR", JdeDataType.Numeric),
        new JdeField("OIUOM2", "OIUOM2", JdeDataType.String, 4),
        new JdeField("OIACKQTY", "OIACKQTY", JdeDataType.Numeric),
        new JdeField("OISACKQTY", "OISACKQTY", JdeDataType.Numeric),
        new JdeField("OIREMAQTY", "OIREMAQTY", JdeDataType.Numeric),
        new JdeField("OISREMQTY", "OISREMQTY", JdeDataType.Numeric),
        new JdeField("OICONQTY", "OICONQTY", JdeDataType.Numeric),
        new JdeField("OIRLOCN", "OIRLOCN", JdeDataType.String, 40),
        new JdeField("OISCONQTY", "OISCONQTY", JdeDataType.Numeric),
        new JdeField("OIRETQTYA", "OIRETQTYA", JdeDataType.Numeric),
        new JdeField("OISRETQTYA", "OISRETQTYA", JdeDataType.Numeric),
        new JdeField("OIREMCQTY", "OIREMCQTY", JdeDataType.Numeric),
        new JdeField("OISREMCQTY", "OISREMCQTY", JdeDataType.Numeric),
        new JdeField("OIACKLDT", "OIACKLDT", JdeDataType.Date),
        new JdeField("OIRECVDT", "OIRECVDT", JdeDataType.Date),
        new JdeField("OIRSDJ", "OIRSDJ", JdeDataType.Numeric),
        new JdeField("OICONSDT", "OICONSDT", JdeDataType.Numeric),
        new JdeField("OI42IRT", "OI42IRT", JdeDataType.String, 6),
        new JdeField("OIPOCUST", "OIPOCUST", JdeDataType.String, 50),
        new JdeField("OIACKST", "OIACKST", JdeDataType.Numeric),
        new JdeField("OICONLNST", "OICONLNST", JdeDataType.Numeric),
        new JdeField("OICRCD", "OICRCD", JdeDataType.String, 6),
        new JdeField("OISHPN", "OISHPN", JdeDataType.Numeric),
        new JdeField("OISOQS", "OISOQS", JdeDataType.Numeric),
        new JdeField("OIKITS", "OIKITS", JdeDataType.String, 2),
        new JdeField("OIKITID", "OIKITID", JdeDataType.Numeric),
        new JdeField("OIKITDIRTY", "OIKITDIRTY", JdeDataType.String, 2),
        new JdeField("OIRLIT", "OIRLIT", JdeDataType.String, 16),
        new JdeField("OIKTLN", "OIKTLN", JdeDataType.Numeric),
        new JdeField("OICPNT", "OICPNT", JdeDataType.Numeric),
        new JdeField("OIRKIT", "OIRKIT", JdeDataType.Numeric),
        new JdeField("OIKTP", "OIKTP", JdeDataType.Numeric),
        new JdeField("OIOIPR", "OIOIPR", JdeDataType.String, 16),
        new JdeField("OIPRSEQ", "OIPRSEQ", JdeDataType.Numeric),
        new JdeField("OIFUCHAR13", "OIFUCHAR13", JdeDataType.String, 2),
        new JdeField("OIFUCHAR14", "OIFUCHAR14", JdeDataType.String, 2),
        new JdeField("OIFUCHAR15", "OIFUCHAR15", JdeDataType.String, 2),
        new JdeField("OIFUNUM13", "OIFUNUM13", JdeDataType.Numeric),
        new JdeField("OIFUNUM14", "OIFUNUM14", JdeDataType.Numeric),
        new JdeField("OIFUNUM15", "OIFUNUM15", JdeDataType.Numeric),
        new JdeField("OIFUTSTR13", "OIFUTSTR13", JdeDataType.String, 100),
        new JdeField("OIFUTSTR14", "OIFUTSTR14", JdeDataType.String, 100),
        new JdeField("OIFUTSTR15", "OIFUTSTR15", JdeDataType.String, 100),
        new JdeField("OIFUDT6", "OIFUDT6", JdeDataType.Numeric),
        new JdeField("OIFUDT20", "OIFUDT20", JdeDataType.Numeric),
        new JdeField("OIFUDT30", "OIFUDT30", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OIURAT", "OIURAT", JdeDataType.Numeric),
        new JdeField("OIURCD", "OIURCD", JdeDataType.String, 4),
        new JdeField("OIURDT", "OIURDT", JdeDataType.Numeric),
        new JdeField("OIURAB", "OIURAB", JdeDataType.Numeric),
        new JdeField("OIURRF", "OIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I02_0", "Primary Key on OIDOCO, OIDCTO, OIKCOO, OILNID", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I02_2", "Index on OIDOCO, OIDCTO, OIKCOO, OILNID, OIDMCT, OIDMCS", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID", "OIDMCT", "OIDMCS" }),
        new JdeIndex("F42I02_3", "Index on OIMCU, OIACKST", new[] { "OIMCU", "OIACKST" }),
        new JdeIndex("F42I02_4", "Index on OIDMCT, OIDMCS, OISEQ, OIACKST", new[] { "OIDMCT", "OIDMCS", "OISEQ", "OIACKST" })
    };
}
