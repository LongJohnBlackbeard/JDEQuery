using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T005Z - .
/// </summary>
public class F75T005Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDUSER.
        /// </summary>
        public const string ZDUSER = "ZDUSER";

        /// <summary>
        /// ZDJOBN.
        /// </summary>
        public const string ZDJOBN = "ZDJOBN";

        /// <summary>
        /// ZDOKCO.
        /// </summary>
        public const string ZDOKCO = "ZDOKCO";

        /// <summary>
        /// ZDODCT.
        /// </summary>
        public const string ZDODCT = "ZDODCT";

        /// <summary>
        /// ZDODOC.
        /// </summary>
        public const string ZDODOC = "ZDODOC";

        /// <summary>
        /// ZD75TDCT.
        /// </summary>
        public const string ZD75TDCT = "ZD75TDCT";

        /// <summary>
        /// ZD75TTXT.
        /// </summary>
        public const string ZD75TTXT = "ZD75TTXT";

        /// <summary>
        /// ZD75TPGN.
        /// </summary>
        public const string ZD75TPGN = "ZD75TPGN";

        /// <summary>
        /// ZD75TLID.
        /// </summary>
        public const string ZD75TLID = "ZD75TLID";

        /// <summary>
        /// ZD75TLNID.
        /// </summary>
        public const string ZD75TLNID = "ZD75TLNID";

        /// <summary>
        /// ZD75TYMH.
        /// </summary>
        public const string ZD75TYMH = "ZD75TYMH";

        /// <summary>
        /// ZD75TVTT.
        /// </summary>
        public const string ZD75TVTT = "ZD75TVTT";

        /// <summary>
        /// ZDITM.
        /// </summary>
        public const string ZDITM = "ZDITM";

        /// <summary>
        /// ZDLITM.
        /// </summary>
        public const string ZDLITM = "ZDLITM";

        /// <summary>
        /// ZDAITM.
        /// </summary>
        public const string ZDAITM = "ZDAITM";

        /// <summary>
        /// ZDDSC1.
        /// </summary>
        public const string ZDDSC1 = "ZDDSC1";

        /// <summary>
        /// ZDUOM.
        /// </summary>
        public const string ZDUOM = "ZDUOM";

        /// <summary>
        /// ZDUORG.
        /// </summary>
        public const string ZDUORG = "ZDUORG";

        /// <summary>
        /// ZDTAX1.
        /// </summary>
        public const string ZDTAX1 = "ZDTAX1";

        /// <summary>
        /// ZDEXR1.
        /// </summary>
        public const string ZDEXR1 = "ZDEXR1";

        /// <summary>
        /// ZDTXA1.
        /// </summary>
        public const string ZDTXA1 = "ZDTXA1";

        /// <summary>
        /// ZDBCRC.
        /// </summary>
        public const string ZDBCRC = "ZDBCRC";

        /// <summary>
        /// ZDUPRC.
        /// </summary>
        public const string ZDUPRC = "ZDUPRC";

        /// <summary>
        /// ZDATXA.
        /// </summary>
        public const string ZDATXA = "ZDATXA";

        /// <summary>
        /// ZDSTAM.
        /// </summary>
        public const string ZDSTAM = "ZDSTAM";

        /// <summary>
        /// ZDAAP.
        /// </summary>
        public const string ZDAAP = "ZDAAP";

        /// <summary>
        /// ZDT75ATXA.
        /// </summary>
        public const string ZDT75ATXA = "ZDT75ATXA";

        /// <summary>
        /// ZDT75STAM.
        /// </summary>
        public const string ZDT75STAM = "ZDT75STAM";

        /// <summary>
        /// ZDT75AAP.
        /// </summary>
        public const string ZDT75AAP = "ZDT75AAP";

        /// <summary>
        /// ZDCRCD.
        /// </summary>
        public const string ZDCRCD = "ZDCRCD";

        /// <summary>
        /// ZDCRR.
        /// </summary>
        public const string ZDCRR = "ZDCRR";

        /// <summary>
        /// ZDT75ANTX.
        /// </summary>
        public const string ZDT75ANTX = "ZDT75ANTX";

        /// <summary>
        /// ZDT75FONT.
        /// </summary>
        public const string ZDT75FONT = "ZDT75FONT";

        /// <summary>
        /// ZDT75AONT.
        /// </summary>
        public const string ZDT75AONT = "ZDT75AONT";

        /// <summary>
        /// ZDT75FNTX.
        /// </summary>
        public const string ZDT75FNTX = "ZDT75FNTX";

        /// <summary>
        /// ZDFUP.
        /// </summary>
        public const string ZDFUP = "ZDFUP";

        /// <summary>
        /// ZDCTXA.
        /// </summary>
        public const string ZDCTXA = "ZDCTXA";

        /// <summary>
        /// ZDCTAM.
        /// </summary>
        public const string ZDCTAM = "ZDCTAM";

        /// <summary>
        /// ZDFAP.
        /// </summary>
        public const string ZDFAP = "ZDFAP";

        /// <summary>
        /// ZDT75FOTA.
        /// </summary>
        public const string ZDT75FOTA = "ZDT75FOTA";

        /// <summary>
        /// ZDT75FOTX.
        /// </summary>
        public const string ZDT75FOTX = "ZDT75FOTX";

        /// <summary>
        /// ZDT75FOAP.
        /// </summary>
        public const string ZDT75FOAP = "ZDT75FOAP";

        /// <summary>
        /// ZDKCO.
        /// </summary>
        public const string ZDKCO = "ZDKCO";

        /// <summary>
        /// ZDDCT.
        /// </summary>
        public const string ZDDCT = "ZDDCT";

        /// <summary>
        /// ZDDOC.
        /// </summary>
        public const string ZDDOC = "ZDDOC";

        /// <summary>
        /// ZDJELN.
        /// </summary>
        public const string ZDJELN = "ZDJELN";

        /// <summary>
        /// ZDSFX.
        /// </summary>
        public const string ZDSFX = "ZDSFX";

        /// <summary>
        /// ZDKCOO.
        /// </summary>
        public const string ZDKCOO = "ZDKCOO";

        /// <summary>
        /// ZDDCTO.
        /// </summary>
        public const string ZDDCTO = "ZDDCTO";

        /// <summary>
        /// ZDDOCO.
        /// </summary>
        public const string ZDDOCO = "ZDDOCO";

        /// <summary>
        /// ZDLNID.
        /// </summary>
        public const string ZDLNID = "ZDLNID";

        /// <summary>
        /// ZDUPMJ.
        /// </summary>
        public const string ZDUPMJ = "ZDUPMJ";

        /// <summary>
        /// ZDTDAY.
        /// </summary>
        public const string ZDTDAY = "ZDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T005Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDUSER", "ZDUSER", JdeDataType.String, 20, true, true),
        new JdeField("ZDJOBN", "ZDJOBN", JdeDataType.String, 20, true, true),
        new JdeField("ZDOKCO", "ZDOKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZDODCT", "ZDODCT", JdeDataType.String, 4, true, true),
        new JdeField("ZDODOC", "ZDODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZD75TDCT", "ZD75TDCT", JdeDataType.String, 6, true, true),
        new JdeField("ZD75TTXT", "ZD75TTXT", JdeDataType.String, 2, true, true),
        new JdeField("ZD75TPGN", "ZD75TPGN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZD75TLID", "ZD75TLID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZD75TLNID", "ZD75TLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZD75TYMH", "ZD75TYMH", JdeDataType.Numeric),
        new JdeField("ZD75TVTT", "ZD75TVTT", JdeDataType.String, 6),
        new JdeField("ZDITM", "ZDITM", JdeDataType.Numeric),
        new JdeField("ZDLITM", "ZDLITM", JdeDataType.String, 50),
        new JdeField("ZDAITM", "ZDAITM", JdeDataType.String, 50),
        new JdeField("ZDDSC1", "ZDDSC1", JdeDataType.String, 60),
        new JdeField("ZDUOM", "ZDUOM", JdeDataType.String, 4),
        new JdeField("ZDUORG", "ZDUORG", JdeDataType.Numeric),
        new JdeField("ZDTAX1", "ZDTAX1", JdeDataType.String, 2),
        new JdeField("ZDEXR1", "ZDEXR1", JdeDataType.String, 4),
        new JdeField("ZDTXA1", "ZDTXA1", JdeDataType.String, 20),
        new JdeField("ZDBCRC", "ZDBCRC", JdeDataType.String, 6),
        new JdeField("ZDUPRC", "ZDUPRC", JdeDataType.Numeric),
        new JdeField("ZDATXA", "ZDATXA", JdeDataType.Numeric),
        new JdeField("ZDSTAM", "ZDSTAM", JdeDataType.Numeric),
        new JdeField("ZDAAP", "ZDAAP", JdeDataType.Numeric),
        new JdeField("ZDT75ATXA", "ZDT75ATXA", JdeDataType.Numeric),
        new JdeField("ZDT75STAM", "ZDT75STAM", JdeDataType.Numeric),
        new JdeField("ZDT75AAP", "ZDT75AAP", JdeDataType.Numeric),
        new JdeField("ZDCRCD", "ZDCRCD", JdeDataType.String, 6),
        new JdeField("ZDCRR", "ZDCRR", JdeDataType.Numeric),
        new JdeField("ZDT75ANTX", "ZDT75ANTX", JdeDataType.Numeric),
        new JdeField("ZDT75FONT", "ZDT75FONT", JdeDataType.Numeric),
        new JdeField("ZDT75AONT", "ZDT75AONT", JdeDataType.Numeric),
        new JdeField("ZDT75FNTX", "ZDT75FNTX", JdeDataType.Numeric),
        new JdeField("ZDFUP", "ZDFUP", JdeDataType.Numeric),
        new JdeField("ZDCTXA", "ZDCTXA", JdeDataType.Numeric),
        new JdeField("ZDCTAM", "ZDCTAM", JdeDataType.Numeric),
        new JdeField("ZDFAP", "ZDFAP", JdeDataType.Numeric),
        new JdeField("ZDT75FOTA", "ZDT75FOTA", JdeDataType.Numeric),
        new JdeField("ZDT75FOTX", "ZDT75FOTX", JdeDataType.Numeric),
        new JdeField("ZDT75FOAP", "ZDT75FOAP", JdeDataType.Numeric),
        new JdeField("ZDKCO", "ZDKCO", JdeDataType.String, 10),
        new JdeField("ZDDCT", "ZDDCT", JdeDataType.String, 4),
        new JdeField("ZDDOC", "ZDDOC", JdeDataType.Numeric),
        new JdeField("ZDJELN", "ZDJELN", JdeDataType.Numeric),
        new JdeField("ZDSFX", "ZDSFX", JdeDataType.String, 6),
        new JdeField("ZDKCOO", "ZDKCOO", JdeDataType.String, 10),
        new JdeField("ZDDCTO", "ZDDCTO", JdeDataType.String, 4),
        new JdeField("ZDDOCO", "ZDDOCO", JdeDataType.Numeric),
        new JdeField("ZDLNID", "ZDLNID", JdeDataType.Numeric),
        new JdeField("ZDUPMJ", "ZDUPMJ", JdeDataType.Numeric),
        new JdeField("ZDTDAY", "ZDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T005Z_0", "Primary Key on ZDUSER, ZDJOBN, ZDOKCO, ZDODCT, ZDODOC, ZD75TDCT, ZD75TTXT, ZD75TPGN, ZD75TLID, ZD75TLNID", new[] { "ZDUSER", "ZDJOBN", "ZDOKCO", "ZDODCT", "ZDODOC", "ZD75TDCT", "ZD75TTXT", "ZD75TPGN", "ZD75TLID", "ZD75TLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
