using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47042 - .
/// </summary>
public class F47042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDTY.
        /// </summary>
        public const string SZEDTY = "SZEDTY";

        /// <summary>
        /// SZEDSQ.
        /// </summary>
        public const string SZEDSQ = "SZEDSQ";

        /// <summary>
        /// SZEKCO.
        /// </summary>
        public const string SZEKCO = "SZEKCO";

        /// <summary>
        /// SZEDOC.
        /// </summary>
        public const string SZEDOC = "SZEDOC";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDST.
        /// </summary>
        public const string SZEDST = "SZEDST";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZEDER.
        /// </summary>
        public const string SZEDER = "SZEDER";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZACIN.
        /// </summary>
        public const string SZACIN = "SZACIN";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZKCO.
        /// </summary>
        public const string SZKCO = "SZKCO";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDCTV.
        /// </summary>
        public const string SZDCTV = "SZDCTV";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZVINV.
        /// </summary>
        public const string SZVINV = "SZVINV";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZCITM.
        /// </summary>
        public const string SZCITM = "SZCITM";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZDMCT.
        /// </summary>
        public const string SZDMCT = "SZDMCT";

        /// <summary>
        /// SZDMCS.
        /// </summary>
        public const string SZDMCS = "SZDMCS";

        /// <summary>
        /// SZPEFJ.
        /// </summary>
        public const string SZPEFJ = "SZPEFJ";

        /// <summary>
        /// SZFRGD.
        /// </summary>
        public const string SZFRGD = "SZFRGD";

        /// <summary>
        /// SZTHGD.
        /// </summary>
        public const string SZTHGD = "SZTHGD";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZTHRP.
        /// </summary>
        public const string SZTHRP = "SZTHRP";

        /// <summary>
        /// SZASN.
        /// </summary>
        public const string SZASN = "SZASN";

        /// <summary>
        /// SZCATN.
        /// </summary>
        public const string SZCATN = "SZCATN";

        /// <summary>
        /// SZPL.
        /// </summary>
        public const string SZPL = "SZPL";

        /// <summary>
        /// SZELEV.
        /// </summary>
        public const string SZELEV = "SZELEV";

        /// <summary>
        /// SZAVCH.
        /// </summary>
        public const string SZAVCH = "SZAVCH";

        /// <summary>
        /// SZCORD.
        /// </summary>
        public const string SZCORD = "SZCORD";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

        /// <summary>
        /// SZANI.
        /// </summary>
        public const string SZANI = "SZANI";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZPST.
        /// </summary>
        public const string SZPST = "SZPST";

        /// <summary>
        /// SZGLBA.
        /// </summary>
        public const string SZGLBA = "SZGLBA";

        /// <summary>
        /// SZCRC.
        /// </summary>
        public const string SZCRC = "SZCRC";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZUOPN.
        /// </summary>
        public const string SZUOPN = "SZUOPN";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUPRC.
        /// </summary>
        public const string SZUPRC = "SZUPRC";

        /// <summary>
        /// SZAEXP.
        /// </summary>
        public const string SZAEXP = "SZAEXP";

        /// <summary>
        /// SZAG.
        /// </summary>
        public const string SZAG = "SZAG";

        /// <summary>
        /// SZAAP.
        /// </summary>
        public const string SZAAP = "SZAAP";

        /// <summary>
        /// SZADSC.
        /// </summary>
        public const string SZADSC = "SZADSC";

        /// <summary>
        /// SZADSA.
        /// </summary>
        public const string SZADSA = "SZADSA";

        /// <summary>
        /// SZATXA.
        /// </summary>
        public const string SZATXA = "SZATXA";

        /// <summary>
        /// SZATXN.
        /// </summary>
        public const string SZATXN = "SZATXN";

        /// <summary>
        /// SZSTAM.
        /// </summary>
        public const string SZSTAM = "SZSTAM";

        /// <summary>
        /// SZCRRM.
        /// </summary>
        public const string SZCRRM = "SZCRRM";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZFRRC.
        /// </summary>
        public const string SZFRRC = "SZFRRC";

        /// <summary>
        /// SZFEA.
        /// </summary>
        public const string SZFEA = "SZFEA";

        /// <summary>
        /// SZACR.
        /// </summary>
        public const string SZACR = "SZACR";

        /// <summary>
        /// SZFAP.
        /// </summary>
        public const string SZFAP = "SZFAP";

        /// <summary>
        /// SZCDS.
        /// </summary>
        public const string SZCDS = "SZCDS";

        /// <summary>
        /// SZCDSA.
        /// </summary>
        public const string SZCDSA = "SZCDSA";

        /// <summary>
        /// SZCTAM.
        /// </summary>
        public const string SZCTAM = "SZCTAM";

        /// <summary>
        /// SZCTXN.
        /// </summary>
        public const string SZCTXN = "SZCTXN";

        /// <summary>
        /// SZCTXA.
        /// </summary>
        public const string SZCTXA = "SZCTXA";

        /// <summary>
        /// SZTX.
        /// </summary>
        public const string SZTX = "SZTX";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZPTD.
        /// </summary>
        public const string SZPTD = "SZPTD";

        /// <summary>
        /// SZDCP.
        /// </summary>
        public const string SZDCP = "SZDCP";

        /// <summary>
        /// SZDCD.
        /// </summary>
        public const string SZDCD = "SZDCD";

        /// <summary>
        /// SZNDTP.
        /// </summary>
        public const string SZNDTP = "SZNDTP";

        /// <summary>
        /// SZDDJ.
        /// </summary>
        public const string SZDDJ = "SZDDJ";

        /// <summary>
        /// SZRMK.
        /// </summary>
        public const string SZRMK = "SZRMK";

        /// <summary>
        /// SZVRMK.
        /// </summary>
        public const string SZVRMK = "SZVRMK";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZVR02.
        /// </summary>
        public const string SZVR02 = "SZVR02";

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
        /// SZNLIN.
        /// </summary>
        public const string SZNLIN = "SZNLIN";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZSRQTY.
        /// </summary>
        public const string SZSRQTY = "SZSRQTY";

        /// <summary>
        /// SZSRUOM.
        /// </summary>
        public const string SZSRUOM = "SZSRUOM";

        /// <summary>
        /// SZNBRU.
        /// </summary>
        public const string SZNBRU = "SZNBRU";

        /// <summary>
        /// SZNEWR.
        /// </summary>
        public const string SZNEWR = "SZNEWR";

        /// <summary>
        /// SZGAN8.
        /// </summary>
        public const string SZGAN8 = "SZGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F47042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDTY", "SZEDTY", JdeDataType.String, 2),
        new JdeField("SZEDSQ", "SZEDSQ", JdeDataType.Numeric),
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDST", "SZEDST", JdeDataType.String, 12),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZEDER", "SZEDER", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZACIN", "SZACIN", JdeDataType.String, 2),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCTV", "SZDCTV", JdeDataType.String, 4),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZVINV", "SZVINV", JdeDataType.String, 50),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZCITM", "SZCITM", JdeDataType.String, 50),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZDMCT", "SZDMCT", JdeDataType.String, 24),
        new JdeField("SZDMCS", "SZDMCS", JdeDataType.Numeric),
        new JdeField("SZPEFJ", "SZPEFJ", JdeDataType.Numeric),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZASN", "SZASN", JdeDataType.String, 16),
        new JdeField("SZCATN", "SZCATN", JdeDataType.String, 16),
        new JdeField("SZPL", "SZPL", JdeDataType.String, 8),
        new JdeField("SZELEV", "SZELEV", JdeDataType.String, 6),
        new JdeField("SZAVCH", "SZAVCH", JdeDataType.String, 2),
        new JdeField("SZCORD", "SZCORD", JdeDataType.Numeric),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZPST", "SZPST", JdeDataType.String, 2),
        new JdeField("SZGLBA", "SZGLBA", JdeDataType.String, 16),
        new JdeField("SZCRC", "SZCRC", JdeDataType.String, 6),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUPRC", "SZUPRC", JdeDataType.Numeric),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZAG", "SZAG", JdeDataType.Numeric),
        new JdeField("SZAAP", "SZAAP", JdeDataType.Numeric),
        new JdeField("SZADSC", "SZADSC", JdeDataType.Numeric),
        new JdeField("SZADSA", "SZADSA", JdeDataType.Numeric),
        new JdeField("SZATXA", "SZATXA", JdeDataType.Numeric),
        new JdeField("SZATXN", "SZATXN", JdeDataType.Numeric),
        new JdeField("SZSTAM", "SZSTAM", JdeDataType.Numeric),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFRRC", "SZFRRC", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZACR", "SZACR", JdeDataType.Numeric),
        new JdeField("SZFAP", "SZFAP", JdeDataType.Numeric),
        new JdeField("SZCDS", "SZCDS", JdeDataType.Numeric),
        new JdeField("SZCDSA", "SZCDSA", JdeDataType.Numeric),
        new JdeField("SZCTAM", "SZCTAM", JdeDataType.Numeric),
        new JdeField("SZCTXN", "SZCTXN", JdeDataType.Numeric),
        new JdeField("SZCTXA", "SZCTXA", JdeDataType.Numeric),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZPTD", "SZPTD", JdeDataType.String, 60),
        new JdeField("SZDCP", "SZDCP", JdeDataType.Numeric),
        new JdeField("SZDCD", "SZDCD", JdeDataType.Numeric),
        new JdeField("SZNDTP", "SZNDTP", JdeDataType.Numeric),
        new JdeField("SZDDJ", "SZDDJ", JdeDataType.Numeric),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZVRMK", "SZVRMK", JdeDataType.String, 60),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
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
        new JdeField("SZNLIN", "SZNLIN", JdeDataType.Numeric),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZSRQTY", "SZSRQTY", JdeDataType.Numeric),
        new JdeField("SZSRUOM", "SZSRUOM", JdeDataType.String, 4),
        new JdeField("SZNBRU", "SZNBRU", JdeDataType.String, 2),
        new JdeField("SZNEWR", "SZNEWR", JdeDataType.String, 2),
        new JdeField("SZGAN8", "SZGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47042_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
