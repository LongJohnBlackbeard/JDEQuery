using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B14Z2 - .
/// </summary>
public class F03B14Z2 : JdeTable
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
        /// SZPYID.
        /// </summary>
        public const string SZPYID = "SZPYID";

        /// <summary>
        /// SZRC5.
        /// </summary>
        public const string SZRC5 = "SZRC5";

        /// <summary>
        /// SZCKNU.
        /// </summary>
        public const string SZCKNU = "SZCKNU";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZKCO.
        /// </summary>
        public const string SZKCO = "SZKCO";

        /// <summary>
        /// SZSFX.
        /// </summary>
        public const string SZSFX = "SZSFX";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZDCTM.
        /// </summary>
        public const string SZDCTM = "SZDCTM";

        /// <summary>
        /// SZDMTJ.
        /// </summary>
        public const string SZDMTJ = "SZDMTJ";

        /// <summary>
        /// SZDGJ.
        /// </summary>
        public const string SZDGJ = "SZDGJ";

        /// <summary>
        /// SZPOST.
        /// </summary>
        public const string SZPOST = "SZPOST";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZICUT.
        /// </summary>
        public const string SZICUT = "SZICUT";

        /// <summary>
        /// SZICU.
        /// </summary>
        public const string SZICU = "SZICU";

        /// <summary>
        /// SZDICJ.
        /// </summary>
        public const string SZDICJ = "SZDICJ";

        /// <summary>
        /// SZPA8.
        /// </summary>
        public const string SZPA8 = "SZPA8";

        /// <summary>
        /// SZRPID.
        /// </summary>
        public const string SZRPID = "SZRPID";

        /// <summary>
        /// SZRLIN.
        /// </summary>
        public const string SZRLIN = "SZRLIN";

        /// <summary>
        /// SZPAAP.
        /// </summary>
        public const string SZPAAP = "SZPAAP";

        /// <summary>
        /// SZADSC.
        /// </summary>
        public const string SZADSC = "SZADSC";

        /// <summary>
        /// SZADSA.
        /// </summary>
        public const string SZADSA = "SZADSA";

        /// <summary>
        /// SZAAAJ.
        /// </summary>
        public const string SZAAAJ = "SZAAAJ";

        /// <summary>
        /// SZECBA.
        /// </summary>
        public const string SZECBA = "SZECBA";

        /// <summary>
        /// SZDDA.
        /// </summary>
        public const string SZDDA = "SZDDA";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

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
        /// SZPFAP.
        /// </summary>
        public const string SZPFAP = "SZPFAP";

        /// <summary>
        /// SZCDS.
        /// </summary>
        public const string SZCDS = "SZCDS";

        /// <summary>
        /// SZCDSA.
        /// </summary>
        public const string SZCDSA = "SZCDSA";

        /// <summary>
        /// SZFCHG.
        /// </summary>
        public const string SZFCHG = "SZFCHG";

        /// <summary>
        /// SZECBF.
        /// </summary>
        public const string SZECBF = "SZECBF";

        /// <summary>
        /// SZFDA.
        /// </summary>
        public const string SZFDA = "SZFDA";

        /// <summary>
        /// SZAGL.
        /// </summary>
        public const string SZAGL = "SZAGL";

        /// <summary>
        /// SZAIDT.
        /// </summary>
        public const string SZAIDT = "SZAIDT";

        /// <summary>
        /// SZTCRC.
        /// </summary>
        public const string SZTCRC = "SZTCRC";

        /// <summary>
        /// SZTAAP.
        /// </summary>
        public const string SZTAAP = "SZTAAP";

        /// <summary>
        /// SZTADA.
        /// </summary>
        public const string SZTADA = "SZTADA";

        /// <summary>
        /// SZTAAJ.
        /// </summary>
        public const string SZTAAJ = "SZTAAJ";

        /// <summary>
        /// SZTCBA.
        /// </summary>
        public const string SZTCBA = "SZTCBA";

        /// <summary>
        /// SZTDA.
        /// </summary>
        public const string SZTDA = "SZTDA";

        /// <summary>
        /// SZACRR.
        /// </summary>
        public const string SZACRR = "SZACRR";

        /// <summary>
        /// SZACR1.
        /// </summary>
        public const string SZACR1 = "SZACR1";

        /// <summary>
        /// SZACR2.
        /// </summary>
        public const string SZACR2 = "SZACR2";

        /// <summary>
        /// SZACRM.
        /// </summary>
        public const string SZACRM = "SZACRM";

        /// <summary>
        /// SZAGLA.
        /// </summary>
        public const string SZAGLA = "SZAGLA";

        /// <summary>
        /// SZAIDA.
        /// </summary>
        public const string SZAIDA = "SZAIDA";

        /// <summary>
        /// SZAIDD.
        /// </summary>
        public const string SZAIDD = "SZAIDD";

        /// <summary>
        /// SZRSCO.
        /// </summary>
        public const string SZRSCO = "SZRSCO";

        /// <summary>
        /// SZAIDW.
        /// </summary>
        public const string SZAIDW = "SZAIDW";

        /// <summary>
        /// SZECBR.
        /// </summary>
        public const string SZECBR = "SZECBR";

        /// <summary>
        /// SZGLCC.
        /// </summary>
        public const string SZGLCC = "SZGLCC";

        /// <summary>
        /// SZAIDC.
        /// </summary>
        public const string SZAIDC = "SZAIDC";

        /// <summary>
        /// SZDDEX.
        /// </summary>
        public const string SZDDEX = "SZDDEX";

        /// <summary>
        /// SZDAID.
        /// </summary>
        public const string SZDAID = "SZDAID";

        /// <summary>
        /// SZTYIN.
        /// </summary>
        public const string SZTYIN = "SZTYIN";

        /// <summary>
        /// SZUTIC.
        /// </summary>
        public const string SZUTIC = "SZUTIC";

        /// <summary>
        /// SZUCTF.
        /// </summary>
        public const string SZUCTF = "SZUCTF";

        /// <summary>
        /// SZAID2.
        /// </summary>
        public const string SZAID2 = "SZAID2";

        /// <summary>
        /// SZAM2.
        /// </summary>
        public const string SZAM2 = "SZAM2";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZPKCO.
        /// </summary>
        public const string SZPKCO = "SZPKCO";

        /// <summary>
        /// SZPO.
        /// </summary>
        public const string SZPO = "SZPO";

        /// <summary>
        /// SZPDCT.
        /// </summary>
        public const string SZPDCT = "SZPDCT";

        /// <summary>
        /// SZNUMB.
        /// </summary>
        public const string SZNUMB = "SZNUMB";

        /// <summary>
        /// SZUNIT.
        /// </summary>
        public const string SZUNIT = "SZUNIT";

        /// <summary>
        /// SZMCU2.
        /// </summary>
        public const string SZMCU2 = "SZMCU2";

        /// <summary>
        /// SZRMK.
        /// </summary>
        public const string SZRMK = "SZRMK";

        /// <summary>
        /// SZFNLP.
        /// </summary>
        public const string SZFNLP = "SZFNLP";

        /// <summary>
        /// SZALT6.
        /// </summary>
        public const string SZALT6 = "SZALT6";

        /// <summary>
        /// SZODOC.
        /// </summary>
        public const string SZODOC = "SZODOC";

        /// <summary>
        /// SZODCT.
        /// </summary>
        public const string SZODCT = "SZODCT";

        /// <summary>
        /// SZOKCO.
        /// </summary>
        public const string SZOKCO = "SZOKCO";

        /// <summary>
        /// SZOSFX.
        /// </summary>
        public const string SZOSFX = "SZOSFX";

        /// <summary>
        /// SZGDOC.
        /// </summary>
        public const string SZGDOC = "SZGDOC";

        /// <summary>
        /// SZGDCT.
        /// </summary>
        public const string SZGDCT = "SZGDCT";

        /// <summary>
        /// SZGKCO.
        /// </summary>
        public const string SZGKCO = "SZGKCO";

        /// <summary>
        /// SZGSFX.
        /// </summary>
        public const string SZGSFX = "SZGSFX";

        /// <summary>
        /// SZDCTG.
        /// </summary>
        public const string SZDCTG = "SZDCTG";

        /// <summary>
        /// SZDOCG.
        /// </summary>
        public const string SZDOCG = "SZDOCG";

        /// <summary>
        /// SZKCOG.
        /// </summary>
        public const string SZKCOG = "SZKCOG";

        /// <summary>
        /// SZCTL.
        /// </summary>
        public const string SZCTL = "SZCTL";

        /// <summary>
        /// SZSMTJ.
        /// </summary>
        public const string SZSMTJ = "SZSMTJ";

        /// <summary>
        /// SZVDGJ.
        /// </summary>
        public const string SZVDGJ = "SZVDGJ";

        /// <summary>
        /// SZVRE.
        /// </summary>
        public const string SZVRE = "SZVRE";

        /// <summary>
        /// SZNFVD.
        /// </summary>
        public const string SZNFVD = "SZNFVD";

        /// <summary>
        /// SZHCRR.
        /// </summary>
        public const string SZHCRR = "SZHCRR";

        /// <summary>
        /// SZISTC.
        /// </summary>
        public const string SZISTC = "SZISTC";

        /// <summary>
        /// SZLFCJ.
        /// </summary>
        public const string SZLFCJ = "SZLFCJ";

        /// <summary>
        /// SZPDLT.
        /// </summary>
        public const string SZPDLT = "SZPDLT";

        /// <summary>
        /// SZDDJ.
        /// </summary>
        public const string SZDDJ = "SZDDJ";

        /// <summary>
        /// SZDDNJ.
        /// </summary>
        public const string SZDDNJ = "SZDDNJ";

        /// <summary>
        /// SZIDGJ.
        /// </summary>
        public const string SZIDGJ = "SZIDGJ";

        /// <summary>
        /// SZDDST.
        /// </summary>
        public const string SZDDST = "SZDDST";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZRFID.
        /// </summary>
        public const string SZRFID = "SZRFID";

        /// <summary>
        /// SZRIDC.
        /// </summary>
        public const string SZRIDC = "SZRIDC";

        /// <summary>
        /// SZPRGF.
        /// </summary>
        public const string SZPRGF = "SZPRGF";

        /// <summary>
        /// SZGFL1.
        /// </summary>
        public const string SZGFL1 = "SZGFL1";

        /// <summary>
        /// SZRNID.
        /// </summary>
        public const string SZRNID = "SZRNID";

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
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZRASI.
        /// </summary>
        public const string SZRASI = "SZRASI";

        /// <summary>
        /// SZRAMT.
        /// </summary>
        public const string SZRAMT = "SZRAMT";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZGFL2.
        /// </summary>
        public const string SZGFL2 = "SZGFL2";

        /// <summary>
        /// SZOMOD.
        /// </summary>
        public const string SZOMOD = "SZOMOD";

        /// <summary>
        /// SZLRFL.
        /// </summary>
        public const string SZLRFL = "SZLRFL";

        /// <summary>
        /// SZDRCO.
        /// </summary>
        public const string SZDRCO = "SZDRCO";

        /// <summary>
        /// SZURC1.
        /// </summary>
        public const string SZURC1 = "SZURC1";

        /// <summary>
        /// SZNETTCID.
        /// </summary>
        public const string SZNETTCID = "SZNETTCID";

        /// <summary>
        /// SZNETDOC.
        /// </summary>
        public const string SZNETDOC = "SZNETDOC";

        /// <summary>
        /// SZNETRC5.
        /// </summary>
        public const string SZNETRC5 = "SZNETRC5";

        /// <summary>
        /// SZADGJ.
        /// </summary>
        public const string SZADGJ = "SZADGJ";
    }

    /// <inheritdoc />
    public override string TableName => "F03B14Z2";

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
        new JdeField("SZPYID", "SZPYID", JdeDataType.Numeric),
        new JdeField("SZRC5", "SZRC5", JdeDataType.Numeric),
        new JdeField("SZCKNU", "SZCKNU", JdeDataType.String, 50),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZSFX", "SZSFX", JdeDataType.String, 6),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZDCTM", "SZDCTM", JdeDataType.String, 4),
        new JdeField("SZDMTJ", "SZDMTJ", JdeDataType.Numeric),
        new JdeField("SZDGJ", "SZDGJ", JdeDataType.Numeric),
        new JdeField("SZPOST", "SZPOST", JdeDataType.String, 2),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZICUT", "SZICUT", JdeDataType.String, 4),
        new JdeField("SZICU", "SZICU", JdeDataType.Numeric),
        new JdeField("SZDICJ", "SZDICJ", JdeDataType.Numeric),
        new JdeField("SZPA8", "SZPA8", JdeDataType.Numeric),
        new JdeField("SZRPID", "SZRPID", JdeDataType.Numeric),
        new JdeField("SZRLIN", "SZRLIN", JdeDataType.Numeric),
        new JdeField("SZPAAP", "SZPAAP", JdeDataType.Numeric),
        new JdeField("SZADSC", "SZADSC", JdeDataType.Numeric),
        new JdeField("SZADSA", "SZADSA", JdeDataType.Numeric),
        new JdeField("SZAAAJ", "SZAAAJ", JdeDataType.Numeric),
        new JdeField("SZECBA", "SZECBA", JdeDataType.Numeric),
        new JdeField("SZDDA", "SZDDA", JdeDataType.Numeric),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZPFAP", "SZPFAP", JdeDataType.Numeric),
        new JdeField("SZCDS", "SZCDS", JdeDataType.Numeric),
        new JdeField("SZCDSA", "SZCDSA", JdeDataType.Numeric),
        new JdeField("SZFCHG", "SZFCHG", JdeDataType.Numeric),
        new JdeField("SZECBF", "SZECBF", JdeDataType.Numeric),
        new JdeField("SZFDA", "SZFDA", JdeDataType.Numeric),
        new JdeField("SZAGL", "SZAGL", JdeDataType.Numeric),
        new JdeField("SZAIDT", "SZAIDT", JdeDataType.String, 16),
        new JdeField("SZTCRC", "SZTCRC", JdeDataType.String, 6),
        new JdeField("SZTAAP", "SZTAAP", JdeDataType.Numeric),
        new JdeField("SZTADA", "SZTADA", JdeDataType.Numeric),
        new JdeField("SZTAAJ", "SZTAAJ", JdeDataType.Numeric),
        new JdeField("SZTCBA", "SZTCBA", JdeDataType.Numeric),
        new JdeField("SZTDA", "SZTDA", JdeDataType.Numeric),
        new JdeField("SZACRR", "SZACRR", JdeDataType.Numeric),
        new JdeField("SZACR1", "SZACR1", JdeDataType.Numeric),
        new JdeField("SZACR2", "SZACR2", JdeDataType.Numeric),
        new JdeField("SZACRM", "SZACRM", JdeDataType.String, 2),
        new JdeField("SZAGLA", "SZAGLA", JdeDataType.Numeric),
        new JdeField("SZAIDA", "SZAIDA", JdeDataType.String, 16),
        new JdeField("SZAIDD", "SZAIDD", JdeDataType.String, 16),
        new JdeField("SZRSCO", "SZRSCO", JdeDataType.String, 4),
        new JdeField("SZAIDW", "SZAIDW", JdeDataType.String, 16),
        new JdeField("SZECBR", "SZECBR", JdeDataType.String, 4),
        new JdeField("SZGLCC", "SZGLCC", JdeDataType.String, 8),
        new JdeField("SZAIDC", "SZAIDC", JdeDataType.String, 16),
        new JdeField("SZDDEX", "SZDDEX", JdeDataType.String, 4),
        new JdeField("SZDAID", "SZDAID", JdeDataType.String, 16),
        new JdeField("SZTYIN", "SZTYIN", JdeDataType.String, 2),
        new JdeField("SZUTIC", "SZUTIC", JdeDataType.String, 4),
        new JdeField("SZUCTF", "SZUCTF", JdeDataType.String, 2),
        new JdeField("SZAID2", "SZAID2", JdeDataType.String, 16),
        new JdeField("SZAM2", "SZAM2", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZPKCO", "SZPKCO", JdeDataType.String, 10),
        new JdeField("SZPO", "SZPO", JdeDataType.String, 16),
        new JdeField("SZPDCT", "SZPDCT", JdeDataType.String, 4),
        new JdeField("SZNUMB", "SZNUMB", JdeDataType.Numeric),
        new JdeField("SZUNIT", "SZUNIT", JdeDataType.String, 16),
        new JdeField("SZMCU2", "SZMCU2", JdeDataType.String, 24),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZFNLP", "SZFNLP", JdeDataType.String, 2),
        new JdeField("SZALT6", "SZALT6", JdeDataType.String, 2),
        new JdeField("SZODOC", "SZODOC", JdeDataType.Numeric),
        new JdeField("SZODCT", "SZODCT", JdeDataType.String, 4),
        new JdeField("SZOKCO", "SZOKCO", JdeDataType.String, 10),
        new JdeField("SZOSFX", "SZOSFX", JdeDataType.String, 6),
        new JdeField("SZGDOC", "SZGDOC", JdeDataType.Numeric),
        new JdeField("SZGDCT", "SZGDCT", JdeDataType.String, 4),
        new JdeField("SZGKCO", "SZGKCO", JdeDataType.String, 10),
        new JdeField("SZGSFX", "SZGSFX", JdeDataType.String, 6),
        new JdeField("SZDCTG", "SZDCTG", JdeDataType.String, 4),
        new JdeField("SZDOCG", "SZDOCG", JdeDataType.Numeric),
        new JdeField("SZKCOG", "SZKCOG", JdeDataType.String, 10),
        new JdeField("SZCTL", "SZCTL", JdeDataType.String, 26),
        new JdeField("SZSMTJ", "SZSMTJ", JdeDataType.Numeric),
        new JdeField("SZVDGJ", "SZVDGJ", JdeDataType.Numeric),
        new JdeField("SZVRE", "SZVRE", JdeDataType.String, 6),
        new JdeField("SZNFVD", "SZNFVD", JdeDataType.String, 2),
        new JdeField("SZHCRR", "SZHCRR", JdeDataType.Numeric),
        new JdeField("SZISTC", "SZISTC", JdeDataType.String, 2),
        new JdeField("SZLFCJ", "SZLFCJ", JdeDataType.Numeric),
        new JdeField("SZPDLT", "SZPDLT", JdeDataType.String, 2),
        new JdeField("SZDDJ", "SZDDJ", JdeDataType.Numeric),
        new JdeField("SZDDNJ", "SZDDNJ", JdeDataType.Numeric),
        new JdeField("SZIDGJ", "SZIDGJ", JdeDataType.Numeric),
        new JdeField("SZDDST", "SZDDST", JdeDataType.String, 2),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZRFID", "SZRFID", JdeDataType.Numeric),
        new JdeField("SZRIDC", "SZRIDC", JdeDataType.String, 2),
        new JdeField("SZPRGF", "SZPRGF", JdeDataType.String, 2),
        new JdeField("SZGFL1", "SZGFL1", JdeDataType.String, 2),
        new JdeField("SZRNID", "SZRNID", JdeDataType.Numeric),
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
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZRASI", "SZRASI", JdeDataType.String, 16),
        new JdeField("SZRAMT", "SZRAMT", JdeDataType.Numeric),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZGFL2", "SZGFL2", JdeDataType.String, 2),
        new JdeField("SZOMOD", "SZOMOD", JdeDataType.String, 2),
        new JdeField("SZLRFL", "SZLRFL", JdeDataType.String, 2),
        new JdeField("SZDRCO", "SZDRCO", JdeDataType.String, 6),
        new JdeField("SZURC1", "SZURC1", JdeDataType.String, 6),
        new JdeField("SZNETTCID", "SZNETTCID", JdeDataType.Numeric),
        new JdeField("SZNETDOC", "SZNETDOC", JdeDataType.Numeric),
        new JdeField("SZNETRC5", "SZNETRC5", JdeDataType.Numeric),
        new JdeField("SZADGJ", "SZADGJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B14Z2_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B14Z2_2", "Index on SZPYID, SZRC5", new[] { "SZPYID", "SZRC5" })
    };
}
