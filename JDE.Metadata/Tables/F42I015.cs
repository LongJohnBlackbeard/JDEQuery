using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I015 - .
/// </summary>
public class F42I015 : JdeTable
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
        /// OILNTY.
        /// </summary>
        public const string OILNTY = "OILNTY";

        /// <summary>
        /// OILNID.
        /// </summary>
        public const string OILNID = "OILNID";

        /// <summary>
        /// OIPOCUST.
        /// </summary>
        public const string OIPOCUST = "OIPOCUST";

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
        /// OISHAN.
        /// </summary>
        public const string OISHAN = "OISHAN";

        /// <summary>
        /// OISEQ.
        /// </summary>
        public const string OISEQ = "OISEQ";

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
        /// OIOLTY.
        /// </summary>
        public const string OIOLTY = "OIOLTY";

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
        /// OICNQT.
        /// </summary>
        public const string OICNQT = "OICNQT";

        /// <summary>
        /// OIUOMA.
        /// </summary>
        public const string OIUOMA = "OIUOMA";

        /// <summary>
        /// OIQCOM.
        /// </summary>
        public const string OIQCOM = "OIQCOM";

        /// <summary>
        /// OIUPRC.
        /// </summary>
        public const string OIUPRC = "OIUPRC";

        /// <summary>
        /// OIFUP.
        /// </summary>
        public const string OIFUP = "OIFUP";

        /// <summary>
        /// OIAEXP.
        /// </summary>
        public const string OIAEXP = "OIAEXP";

        /// <summary>
        /// OIFEA.
        /// </summary>
        public const string OIFEA = "OIFEA";

        /// <summary>
        /// OITUPRC.
        /// </summary>
        public const string OITUPRC = "OITUPRC";

        /// <summary>
        /// OITAEXP.
        /// </summary>
        public const string OITAEXP = "OITAEXP";

        /// <summary>
        /// OITFUP.
        /// </summary>
        public const string OITFUP = "OITFUP";

        /// <summary>
        /// OITFEA.
        /// </summary>
        public const string OITFEA = "OITFEA";

        /// <summary>
        /// OIUNCS.
        /// </summary>
        public const string OIUNCS = "OIUNCS";

        /// <summary>
        /// OIECST.
        /// </summary>
        public const string OIECST = "OIECST";

        /// <summary>
        /// OIFUC.
        /// </summary>
        public const string OIFUC = "OIFUC";

        /// <summary>
        /// OIFEC.
        /// </summary>
        public const string OIFEC = "OIFEC";

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
        /// OICRCD.
        /// </summary>
        public const string OICRCD = "OICRCD";

        /// <summary>
        /// OIBCRC.
        /// </summary>
        public const string OIBCRC = "OIBCRC";

        /// <summary>
        /// OIOIPR.
        /// </summary>
        public const string OIOIPR = "OIOIPR";

        /// <summary>
        /// OIPRSEQ.
        /// </summary>
        public const string OIPRSEQ = "OIPRSEQ";

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
        /// OIFUCHAR3.
        /// </summary>
        public const string OIFUCHAR3 = "OIFUCHAR3";

        /// <summary>
        /// OIFUCHAR4.
        /// </summary>
        public const string OIFUCHAR4 = "OIFUCHAR4";

        /// <summary>
        /// OIFUCHAR5.
        /// </summary>
        public const string OIFUCHAR5 = "OIFUCHAR5";

        /// <summary>
        /// OIFUTNUM1.
        /// </summary>
        public const string OIFUTNUM1 = "OIFUTNUM1";

        /// <summary>
        /// OIFUTNUM2.
        /// </summary>
        public const string OIFUTNUM2 = "OIFUTNUM2";

        /// <summary>
        /// OIFUTNUM3.
        /// </summary>
        public const string OIFUTNUM3 = "OIFUTNUM3";

        /// <summary>
        /// OIFSTR1.
        /// </summary>
        public const string OIFSTR1 = "OIFSTR1";

        /// <summary>
        /// OIFSTR2.
        /// </summary>
        public const string OIFSTR2 = "OIFSTR2";

        /// <summary>
        /// OIFSTR3.
        /// </summary>
        public const string OIFSTR3 = "OIFSTR3";

        /// <summary>
        /// OIFUDT4.
        /// </summary>
        public const string OIFUDT4 = "OIFUDT4";

        /// <summary>
        /// OIFUDT18.
        /// </summary>
        public const string OIFUDT18 = "OIFUDT18";

        /// <summary>
        /// OIFUDT28.
        /// </summary>
        public const string OIFUDT28 = "OIFUDT28";

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
    public override string TableName => "F42I015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OILNTY", "OILNTY", JdeDataType.String, 4),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIPOCUST", "OIPOCUST", JdeDataType.String, 50),
        new JdeField("OISFXO", "OISFXO", JdeDataType.String, 6),
        new JdeField("OIDMCT", "OIDMCT", JdeDataType.String, 24),
        new JdeField("OIDMCS", "OIDMCS", JdeDataType.Numeric),
        new JdeField("OISHAN", "OISHAN", JdeDataType.Numeric),
        new JdeField("OISEQ", "OISEQ", JdeDataType.Numeric),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OILOCN", "OILOCN", JdeDataType.String, 40),
        new JdeField("OILOTN", "OILOTN", JdeDataType.String, 60),
        new JdeField("OIOLTY", "OIOLTY", JdeDataType.String, 6),
        new JdeField("OIPQOR", "OIPQOR", JdeDataType.Numeric),
        new JdeField("OIUOM1", "OIUOM1", JdeDataType.String, 4),
        new JdeField("OISQOR", "OISQOR", JdeDataType.Numeric),
        new JdeField("OIUOM2", "OIUOM2", JdeDataType.String, 4),
        new JdeField("OICNQT", "OICNQT", JdeDataType.Numeric),
        new JdeField("OIUOMA", "OIUOMA", JdeDataType.String, 4),
        new JdeField("OIQCOM", "OIQCOM", JdeDataType.Numeric),
        new JdeField("OIUPRC", "OIUPRC", JdeDataType.Numeric),
        new JdeField("OIFUP", "OIFUP", JdeDataType.Numeric),
        new JdeField("OIAEXP", "OIAEXP", JdeDataType.Numeric),
        new JdeField("OIFEA", "OIFEA", JdeDataType.Numeric),
        new JdeField("OITUPRC", "OITUPRC", JdeDataType.Numeric),
        new JdeField("OITAEXP", "OITAEXP", JdeDataType.Numeric),
        new JdeField("OITFUP", "OITFUP", JdeDataType.Numeric),
        new JdeField("OITFEA", "OITFEA", JdeDataType.Numeric),
        new JdeField("OIUNCS", "OIUNCS", JdeDataType.Numeric),
        new JdeField("OIECST", "OIECST", JdeDataType.Numeric),
        new JdeField("OIFUC", "OIFUC", JdeDataType.Numeric),
        new JdeField("OIFEC", "OIFEC", JdeDataType.Numeric),
        new JdeField("OIKITS", "OIKITS", JdeDataType.String, 2),
        new JdeField("OIKITID", "OIKITID", JdeDataType.Numeric),
        new JdeField("OIKITDIRTY", "OIKITDIRTY", JdeDataType.String, 2),
        new JdeField("OIRLIT", "OIRLIT", JdeDataType.String, 16),
        new JdeField("OIKTLN", "OIKTLN", JdeDataType.Numeric),
        new JdeField("OICPNT", "OICPNT", JdeDataType.Numeric),
        new JdeField("OIRKIT", "OIRKIT", JdeDataType.Numeric),
        new JdeField("OIKTP", "OIKTP", JdeDataType.Numeric),
        new JdeField("OICRCD", "OICRCD", JdeDataType.String, 6),
        new JdeField("OIBCRC", "OIBCRC", JdeDataType.String, 6),
        new JdeField("OIOIPR", "OIOIPR", JdeDataType.String, 16),
        new JdeField("OIPRSEQ", "OIPRSEQ", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OIFUCHAR3", "OIFUCHAR3", JdeDataType.String, 2),
        new JdeField("OIFUCHAR4", "OIFUCHAR4", JdeDataType.String, 2),
        new JdeField("OIFUCHAR5", "OIFUCHAR5", JdeDataType.String, 2),
        new JdeField("OIFUTNUM1", "OIFUTNUM1", JdeDataType.Numeric),
        new JdeField("OIFUTNUM2", "OIFUTNUM2", JdeDataType.Numeric),
        new JdeField("OIFUTNUM3", "OIFUTNUM3", JdeDataType.Numeric),
        new JdeField("OIFSTR1", "OIFSTR1", JdeDataType.String, 100),
        new JdeField("OIFSTR2", "OIFSTR2", JdeDataType.String, 100),
        new JdeField("OIFSTR3", "OIFSTR3", JdeDataType.String, 100),
        new JdeField("OIFUDT4", "OIFUDT4", JdeDataType.Numeric),
        new JdeField("OIFUDT18", "OIFUDT18", JdeDataType.Numeric),
        new JdeField("OIFUDT28", "OIFUDT28", JdeDataType.Numeric),
        new JdeField("OIURAT", "OIURAT", JdeDataType.Numeric),
        new JdeField("OIURCD", "OIURCD", JdeDataType.String, 4),
        new JdeField("OIURDT", "OIURDT", JdeDataType.Numeric),
        new JdeField("OIURAB", "OIURAB", JdeDataType.Numeric),
        new JdeField("OIURRF", "OIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I015_0", "Primary Key on OIDOCO, OIDCTO, OIKCOO, OILNID", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42I015_2", "Index on OIDOCO, OIDCTO, OIKCOO, OILNID, OIDMCT, OIDMCS", new[] { "OIDOCO", "OIDCTO", "OIKCOO", "OILNID", "OIDMCT", "OIDMCS" }),
        new JdeIndex("F42I015_3", "Index on OIDMCT, OIDMCS, OISEQ, OIDOCO, OIDCTO, OIKCOO, OILNID", new[] { "OIDMCT", "OIDMCS", "OISEQ", "OIDOCO", "OIDCTO", "OIKCOO", "OILNID" }),
        new JdeIndex("F42I015_4", "Index on OIDMCT, OIDMCS, OISEQ", new[] { "OIDMCT", "OIDMCS", "OISEQ" })
    };
}
