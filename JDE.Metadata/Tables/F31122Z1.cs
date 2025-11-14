using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31122Z1 - .
/// </summary>
public class F31122Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZYST.
        /// </summary>
        public const string SZYST = "SZYST";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZPRTR.
        /// </summary>
        public const string SZPRTR = "SZPRTR";

        /// <summary>
        /// SZKIT.
        /// </summary>
        public const string SZKIT = "SZKIT";

        /// <summary>
        /// SZKITL.
        /// </summary>
        public const string SZKITL = "SZKITL";

        /// <summary>
        /// SZKITA.
        /// </summary>
        public const string SZKITA = "SZKITA";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZOPST.
        /// </summary>
        public const string SZOPST = "SZOPST";

        /// <summary>
        /// SZTYR.
        /// </summary>
        public const string SZTYR = "SZTYR";

        /// <summary>
        /// SZEXR.
        /// </summary>
        public const string SZEXR = "SZEXR";

        /// <summary>
        /// SZICU.
        /// </summary>
        public const string SZICU = "SZICU";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZPBDT.
        /// </summary>
        public const string SZPBDT = "SZPBDT";

        /// <summary>
        /// SZPBTM.
        /// </summary>
        public const string SZPBTM = "SZPBTM";

        /// <summary>
        /// SZPETM.
        /// </summary>
        public const string SZPETM = "SZPETM";

        /// <summary>
        /// SZSHFT.
        /// </summary>
        public const string SZSHFT = "SZSHFT";

        /// <summary>
        /// SZAPID.
        /// </summary>
        public const string SZAPID = "SZAPID";

        /// <summary>
        /// SZEBRT.
        /// </summary>
        public const string SZEBRT = "SZEBRT";

        /// <summary>
        /// SZHRT.
        /// </summary>
        public const string SZHRT = "SZHRT";

        /// <summary>
        /// SZHRW.
        /// </summary>
        public const string SZHRW = "SZHRW";

        /// <summary>
        /// SZHREQ.
        /// </summary>
        public const string SZHREQ = "SZHREQ";

        /// <summary>
        /// SZGPAY.
        /// </summary>
        public const string SZGPAY = "SZGPAY";

        /// <summary>
        /// SZEPAY.
        /// </summary>
        public const string SZEPAY = "SZEPAY";

        /// <summary>
        /// SZSOQS.
        /// </summary>
        public const string SZSOQS = "SZSOQS";

        /// <summary>
        /// SZSOCN.
        /// </summary>
        public const string SZSOCN = "SZSOCN";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZSUMR.
        /// </summary>
        public const string SZSUMR = "SZSUMR";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZSTH.
        /// </summary>
        public const string SZSTH = "SZSTH";

        /// <summary>
        /// SZLINE.
        /// </summary>
        public const string SZLINE = "SZLINE";

        /// <summary>
        /// SZRCD.
        /// </summary>
        public const string SZRCD = "SZRCD";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZNUMB.
        /// </summary>
        public const string SZNUMB = "SZNUMB";

        /// <summary>
        /// SZACTB.
        /// </summary>
        public const string SZACTB = "SZACTB";

        /// <summary>
        /// SZSOHR.
        /// </summary>
        public const string SZSOHR = "SZSOHR";

        /// <summary>
        /// SZSORE.
        /// </summary>
        public const string SZSORE = "SZSORE";
    }

    /// <inheritdoc />
    public override string TableName => "F31122Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZYST", "SZYST", JdeDataType.String, 2),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZPRTR", "SZPRTR", JdeDataType.Numeric),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZKITL", "SZKITL", JdeDataType.String, 50),
        new JdeField("SZKITA", "SZKITA", JdeDataType.String, 50),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZOPST", "SZOPST", JdeDataType.String, 4),
        new JdeField("SZTYR", "SZTYR", JdeDataType.String, 2),
        new JdeField("SZEXR", "SZEXR", JdeDataType.String, 60),
        new JdeField("SZICU", "SZICU", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZPBDT", "SZPBDT", JdeDataType.Numeric),
        new JdeField("SZPBTM", "SZPBTM", JdeDataType.Numeric),
        new JdeField("SZPETM", "SZPETM", JdeDataType.Numeric),
        new JdeField("SZSHFT", "SZSHFT", JdeDataType.String, 2),
        new JdeField("SZAPID", "SZAPID", JdeDataType.String, 24),
        new JdeField("SZEBRT", "SZEBRT", JdeDataType.Numeric),
        new JdeField("SZHRT", "SZHRT", JdeDataType.Numeric),
        new JdeField("SZHRW", "SZHRW", JdeDataType.Numeric),
        new JdeField("SZHREQ", "SZHREQ", JdeDataType.Numeric),
        new JdeField("SZGPAY", "SZGPAY", JdeDataType.Numeric),
        new JdeField("SZEPAY", "SZEPAY", JdeDataType.Numeric),
        new JdeField("SZSOQS", "SZSOQS", JdeDataType.Numeric),
        new JdeField("SZSOCN", "SZSOCN", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZSUMR", "SZSUMR", JdeDataType.String, 2),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric),
        new JdeField("SZSTH", "SZSTH", JdeDataType.Numeric),
        new JdeField("SZLINE", "SZLINE", JdeDataType.String, 24),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZNUMB", "SZNUMB", JdeDataType.Numeric),
        new JdeField("SZACTB", "SZACTB", JdeDataType.String, 20),
        new JdeField("SZSOHR", "SZSOHR", JdeDataType.String, 2),
        new JdeField("SZSORE", "SZSORE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31122Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
