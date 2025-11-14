using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411Z3 - .
/// </summary>
public class F0411Z3 : JdeTable
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
        /// SZEDTY.
        /// </summary>
        public const string SZEDTY = "SZEDTY";

        /// <summary>
        /// SZEDSQ.
        /// </summary>
        public const string SZEDSQ = "SZEDSQ";

        /// <summary>
        /// SZEDTS.
        /// </summary>
        public const string SZEDTS = "SZEDTS";

        /// <summary>
        /// SZEDER.
        /// </summary>
        public const string SZEDER = "SZEDER";

        /// <summary>
        /// SZEDTC.
        /// </summary>
        public const string SZEDTC = "SZEDTC";

        /// <summary>
        /// SZEDTR.
        /// </summary>
        public const string SZEDTR = "SZEDTR";

        /// <summary>
        /// SZEDGL.
        /// </summary>
        public const string SZEDGL = "SZEDGL";

        /// <summary>
        /// SZEDDH.
        /// </summary>
        public const string SZEDDH = "SZEDDH";

        /// <summary>
        /// SZEDAN.
        /// </summary>
        public const string SZEDAN = "SZEDAN";

        /// <summary>
        /// SZKCO.
        /// </summary>
        public const string SZKCO = "SZKCO";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZSFX.
        /// </summary>
        public const string SZSFX = "SZSFX";

        /// <summary>
        /// SZSFXE.
        /// </summary>
        public const string SZSFXE = "SZSFXE";

        /// <summary>
        /// SZDCTA.
        /// </summary>
        public const string SZDCTA = "SZDCTA";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZPYE.
        /// </summary>
        public const string SZPYE = "SZPYE";

        /// <summary>
        /// SZSNTO.
        /// </summary>
        public const string SZSNTO = "SZSNTO";

        /// <summary>
        /// SZDIVJ.
        /// </summary>
        public const string SZDIVJ = "SZDIVJ";

        /// <summary>
        /// SZDSVJ.
        /// </summary>
        public const string SZDSVJ = "SZDSVJ";

        /// <summary>
        /// SZDDJ.
        /// </summary>
        public const string SZDDJ = "SZDDJ";

        /// <summary>
        /// SZDDNJ.
        /// </summary>
        public const string SZDDNJ = "SZDDNJ";

        /// <summary>
        /// SZDGJ.
        /// </summary>
        public const string SZDGJ = "SZDGJ";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZICU.
        /// </summary>
        public const string SZICU = "SZICU";

        /// <summary>
        /// SZICUT.
        /// </summary>
        public const string SZICUT = "SZICUT";

        /// <summary>
        /// SZDICJ.
        /// </summary>
        public const string SZDICJ = "SZDICJ";

        /// <summary>
        /// SZBALJ.
        /// </summary>
        public const string SZBALJ = "SZBALJ";

        /// <summary>
        /// SZPST.
        /// </summary>
        public const string SZPST = "SZPST";

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
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZCRRM.
        /// </summary>
        public const string SZCRRM = "SZCRRM";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRDC.
        /// </summary>
        public const string SZCRDC = "SZCRDC";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

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
        /// SZCTXA.
        /// </summary>
        public const string SZCTXA = "SZCTXA";

        /// <summary>
        /// SZCTXN.
        /// </summary>
        public const string SZCTXN = "SZCTXN";

        /// <summary>
        /// SZCTAM.
        /// </summary>
        public const string SZCTAM = "SZCTAM";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZGLBA.
        /// </summary>
        public const string SZGLBA = "SZGLBA";

        /// <summary>
        /// SZPOST.
        /// </summary>
        public const string SZPOST = "SZPOST";

        /// <summary>
        /// SZAM.
        /// </summary>
        public const string SZAM = "SZAM";

        /// <summary>
        /// SZAID2.
        /// </summary>
        public const string SZAID2 = "SZAID2";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZBAID.
        /// </summary>
        public const string SZBAID = "SZBAID";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZVOD.
        /// </summary>
        public const string SZVOD = "SZVOD";

        /// <summary>
        /// SZOKCO.
        /// </summary>
        public const string SZOKCO = "SZOKCO";

        /// <summary>
        /// SZODCT.
        /// </summary>
        public const string SZODCT = "SZODCT";

        /// <summary>
        /// SZODOC.
        /// </summary>
        public const string SZODOC = "SZODOC";

        /// <summary>
        /// SZOSFX.
        /// </summary>
        public const string SZOSFX = "SZOSFX";

        /// <summary>
        /// SZCRC.
        /// </summary>
        public const string SZCRC = "SZCRC";

        /// <summary>
        /// SZVINV.
        /// </summary>
        public const string SZVINV = "SZVINV";

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
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

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
        /// SZRF.
        /// </summary>
        public const string SZRF = "SZRF";

        /// <summary>
        /// SZDRF.
        /// </summary>
        public const string SZDRF = "SZDRF";

        /// <summary>
        /// SZCTL.
        /// </summary>
        public const string SZCTL = "SZCTL";

        /// <summary>
        /// SZFNLP.
        /// </summary>
        public const string SZFNLP = "SZFNLP";

        /// <summary>
        /// SZU.
        /// </summary>
        public const string SZU = "SZU";

        /// <summary>
        /// SZUM.
        /// </summary>
        public const string SZUM = "SZUM";

        /// <summary>
        /// SZPYIN.
        /// </summary>
        public const string SZPYIN = "SZPYIN";

        /// <summary>
        /// SZTXA3.
        /// </summary>
        public const string SZTXA3 = "SZTXA3";

        /// <summary>
        /// SZEXR3.
        /// </summary>
        public const string SZEXR3 = "SZEXR3";

        /// <summary>
        /// SZRP1.
        /// </summary>
        public const string SZRP1 = "SZRP1";

        /// <summary>
        /// SZRP2.
        /// </summary>
        public const string SZRP2 = "SZRP2";

        /// <summary>
        /// SZRP3.
        /// </summary>
        public const string SZRP3 = "SZRP3";

        /// <summary>
        /// SZAC07.
        /// </summary>
        public const string SZAC07 = "SZAC07";

        /// <summary>
        /// SZTNN.
        /// </summary>
        public const string SZTNN = "SZTNN";

        /// <summary>
        /// SZDMCD.
        /// </summary>
        public const string SZDMCD = "SZDMCD";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZHCRR.
        /// </summary>
        public const string SZHCRR = "SZHCRR";

        /// <summary>
        /// SZHDGJ.
        /// </summary>
        public const string SZHDGJ = "SZHDGJ";

        /// <summary>
        /// SZDIM.
        /// </summary>
        public const string SZDIM = "SZDIM";

        /// <summary>
        /// SZDID.
        /// </summary>
        public const string SZDID = "SZDID";

        /// <summary>
        /// SZDIY.
        /// </summary>
        public const string SZDIY = "SZDIY";

        /// <summary>
        /// SZDI#.
        /// </summary>
        public const string SZDI_ = "SZDI#";

        /// <summary>
        /// SZDSVM.
        /// </summary>
        public const string SZDSVM = "SZDSVM";

        /// <summary>
        /// SZDSVD.
        /// </summary>
        public const string SZDSVD = "SZDSVD";

        /// <summary>
        /// SZDSVY.
        /// </summary>
        public const string SZDSVY = "SZDSVY";

        /// <summary>
        /// SZDSY#.
        /// </summary>
        public const string SZDSY_ = "SZDSY#";

        /// <summary>
        /// SZDDM.
        /// </summary>
        public const string SZDDM = "SZDDM";

        /// <summary>
        /// SZDDD.
        /// </summary>
        public const string SZDDD = "SZDDD";

        /// <summary>
        /// SZDDY.
        /// </summary>
        public const string SZDDY = "SZDDY";

        /// <summary>
        /// SZDD#.
        /// </summary>
        public const string SZDD_ = "SZDD#";

        /// <summary>
        /// SZDDNM.
        /// </summary>
        public const string SZDDNM = "SZDDNM";

        /// <summary>
        /// SZDDND.
        /// </summary>
        public const string SZDDND = "SZDDND";

        /// <summary>
        /// SZDDNY.
        /// </summary>
        public const string SZDDNY = "SZDDNY";

        /// <summary>
        /// SZDDN#.
        /// </summary>
        public const string SZDDN_ = "SZDDN#";

        /// <summary>
        /// SZDGM.
        /// </summary>
        public const string SZDGM = "SZDGM";

        /// <summary>
        /// SZDGD.
        /// </summary>
        public const string SZDGD = "SZDGD";

        /// <summary>
        /// SZDGY.
        /// </summary>
        public const string SZDGY = "SZDGY";

        /// <summary>
        /// SZDG#.
        /// </summary>
        public const string SZDG_ = "SZDG#";

        /// <summary>
        /// SZDICM.
        /// </summary>
        public const string SZDICM = "SZDICM";

        /// <summary>
        /// SZDICD.
        /// </summary>
        public const string SZDICD = "SZDICD";

        /// <summary>
        /// SZDICY.
        /// </summary>
        public const string SZDICY = "SZDICY";

        /// <summary>
        /// SZDIC#.
        /// </summary>
        public const string SZDIC_ = "SZDIC#";

        /// <summary>
        /// SZHDGM.
        /// </summary>
        public const string SZHDGM = "SZHDGM";

        /// <summary>
        /// SZHDGD.
        /// </summary>
        public const string SZHDGD = "SZHDGD";

        /// <summary>
        /// SZHDGY.
        /// </summary>
        public const string SZHDGY = "SZHDGY";

        /// <summary>
        /// SZHDG#.
        /// </summary>
        public const string SZHDG_ = "SZHDG#";

        /// <summary>
        /// SZDOCM.
        /// </summary>
        public const string SZDOCM = "SZDOCM";

        /// <summary>
        /// SZURC1.
        /// </summary>
        public const string SZURC1 = "SZURC1";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

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
        /// SZTNST.
        /// </summary>
        public const string SZTNST = "SZTNST";

        /// <summary>
        /// SZYC01.
        /// </summary>
        public const string SZYC01 = "SZYC01";

        /// <summary>
        /// SZYC02.
        /// </summary>
        public const string SZYC02 = "SZYC02";

        /// <summary>
        /// SZYC03.
        /// </summary>
        public const string SZYC03 = "SZYC03";

        /// <summary>
        /// SZYC04.
        /// </summary>
        public const string SZYC04 = "SZYC04";

        /// <summary>
        /// SZYC05.
        /// </summary>
        public const string SZYC05 = "SZYC05";

        /// <summary>
        /// SZYC06.
        /// </summary>
        public const string SZYC06 = "SZYC06";

        /// <summary>
        /// SZYC07.
        /// </summary>
        public const string SZYC07 = "SZYC07";

        /// <summary>
        /// SZYC08.
        /// </summary>
        public const string SZYC08 = "SZYC08";

        /// <summary>
        /// SZYC09.
        /// </summary>
        public const string SZYC09 = "SZYC09";

        /// <summary>
        /// SZYC10.
        /// </summary>
        public const string SZYC10 = "SZYC10";

        /// <summary>
        /// SZDTXS.
        /// </summary>
        public const string SZDTXS = "SZDTXS";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZATAD.
        /// </summary>
        public const string SZATAD = "SZATAD";

        /// <summary>
        /// SZCTAD.
        /// </summary>
        public const string SZCTAD = "SZCTAD";

        /// <summary>
        /// SZNRTA.
        /// </summary>
        public const string SZNRTA = "SZNRTA";

        /// <summary>
        /// SZFNRT.
        /// </summary>
        public const string SZFNRT = "SZFNRT";

        /// <summary>
        /// SZTAXP.
        /// </summary>
        public const string SZTAXP = "SZTAXP";

        /// <summary>
        /// SZPRGF.
        /// </summary>
        public const string SZPRGF = "SZPRGF";

        /// <summary>
        /// SZGFL5.
        /// </summary>
        public const string SZGFL5 = "SZGFL5";

        /// <summary>
        /// SZGFL6.
        /// </summary>
        public const string SZGFL6 = "SZGFL6";

        /// <summary>
        /// SZGAM1.
        /// </summary>
        public const string SZGAM1 = "SZGAM1";

        /// <summary>
        /// SZGAM2.
        /// </summary>
        public const string SZGAM2 = "SZGAM2";

        /// <summary>
        /// SZGEN4.
        /// </summary>
        public const string SZGEN4 = "SZGEN4";

        /// <summary>
        /// SZGEN5.
        /// </summary>
        public const string SZGEN5 = "SZGEN5";

        /// <summary>
        /// SZWTAD.
        /// </summary>
        public const string SZWTAD = "SZWTAD";

        /// <summary>
        /// SZWTAF.
        /// </summary>
        public const string SZWTAF = "SZWTAF";

        /// <summary>
        /// SZSMMF.
        /// </summary>
        public const string SZSMMF = "SZSMMF";

        /// <summary>
        /// SZPYWP.
        /// </summary>
        public const string SZPYWP = "SZPYWP";

        /// <summary>
        /// SZPWPG.
        /// </summary>
        public const string SZPWPG = "SZPWPG";

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
        /// SZNETST.
        /// </summary>
        public const string SZNETST = "SZNETST";

        /// <summary>
        /// SZCNTRTID.
        /// </summary>
        public const string SZCNTRTID = "SZCNTRTID";

        /// <summary>
        /// SZCNTRTCD.
        /// </summary>
        public const string SZCNTRTCD = "SZCNTRTCD";

        /// <summary>
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZBLSCD2.
        /// </summary>
        public const string SZBLSCD2 = "SZBLSCD2";

        /// <summary>
        /// SZHARPER.
        /// </summary>
        public const string SZHARPER = "SZHARPER";

        /// <summary>
        /// SZHARSFX.
        /// </summary>
        public const string SZHARSFX = "SZHARSFX";

        /// <summary>
        /// SZDDRL.
        /// </summary>
        public const string SZDDRL = "SZDDRL";

        /// <summary>
        /// SZSEQN.
        /// </summary>
        public const string SZSEQN = "SZSEQN";
    }

    /// <inheritdoc />
    public override string TableName => "F0411Z3";

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
        new JdeField("SZEDTY", "SZEDTY", JdeDataType.String, 2),
        new JdeField("SZEDSQ", "SZEDSQ", JdeDataType.Numeric),
        new JdeField("SZEDTS", "SZEDTS", JdeDataType.String, 12),
        new JdeField("SZEDER", "SZEDER", JdeDataType.String, 2),
        new JdeField("SZEDTC", "SZEDTC", JdeDataType.String, 2),
        new JdeField("SZEDTR", "SZEDTR", JdeDataType.String, 2),
        new JdeField("SZEDGL", "SZEDGL", JdeDataType.String, 2),
        new JdeField("SZEDDH", "SZEDDH", JdeDataType.String, 2),
        new JdeField("SZEDAN", "SZEDAN", JdeDataType.Numeric),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZSFX", "SZSFX", JdeDataType.String, 6),
        new JdeField("SZSFXE", "SZSFXE", JdeDataType.Numeric),
        new JdeField("SZDCTA", "SZDCTA", JdeDataType.String, 4),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZPYE", "SZPYE", JdeDataType.Numeric),
        new JdeField("SZSNTO", "SZSNTO", JdeDataType.Numeric),
        new JdeField("SZDIVJ", "SZDIVJ", JdeDataType.Numeric),
        new JdeField("SZDSVJ", "SZDSVJ", JdeDataType.Numeric),
        new JdeField("SZDDJ", "SZDDJ", JdeDataType.Numeric),
        new JdeField("SZDDNJ", "SZDDNJ", JdeDataType.Numeric),
        new JdeField("SZDGJ", "SZDGJ", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZICU", "SZICU", JdeDataType.Numeric),
        new JdeField("SZICUT", "SZICUT", JdeDataType.String, 4),
        new JdeField("SZDICJ", "SZDICJ", JdeDataType.Numeric),
        new JdeField("SZBALJ", "SZBALJ", JdeDataType.String, 2),
        new JdeField("SZPST", "SZPST", JdeDataType.String, 2),
        new JdeField("SZAG", "SZAG", JdeDataType.Numeric),
        new JdeField("SZAAP", "SZAAP", JdeDataType.Numeric),
        new JdeField("SZADSC", "SZADSC", JdeDataType.Numeric),
        new JdeField("SZADSA", "SZADSA", JdeDataType.Numeric),
        new JdeField("SZATXA", "SZATXA", JdeDataType.Numeric),
        new JdeField("SZATXN", "SZATXN", JdeDataType.Numeric),
        new JdeField("SZSTAM", "SZSTAM", JdeDataType.Numeric),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRDC", "SZCRDC", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZACR", "SZACR", JdeDataType.Numeric),
        new JdeField("SZFAP", "SZFAP", JdeDataType.Numeric),
        new JdeField("SZCDS", "SZCDS", JdeDataType.Numeric),
        new JdeField("SZCDSA", "SZCDSA", JdeDataType.Numeric),
        new JdeField("SZCTXA", "SZCTXA", JdeDataType.Numeric),
        new JdeField("SZCTXN", "SZCTXN", JdeDataType.Numeric),
        new JdeField("SZCTAM", "SZCTAM", JdeDataType.Numeric),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZGLBA", "SZGLBA", JdeDataType.String, 16),
        new JdeField("SZPOST", "SZPOST", JdeDataType.String, 2),
        new JdeField("SZAM", "SZAM", JdeDataType.String, 2),
        new JdeField("SZAID2", "SZAID2", JdeDataType.String, 16),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZBAID", "SZBAID", JdeDataType.String, 16),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZVOD", "SZVOD", JdeDataType.String, 2),
        new JdeField("SZOKCO", "SZOKCO", JdeDataType.String, 10),
        new JdeField("SZODCT", "SZODCT", JdeDataType.String, 4),
        new JdeField("SZODOC", "SZODOC", JdeDataType.Numeric),
        new JdeField("SZOSFX", "SZOSFX", JdeDataType.String, 6),
        new JdeField("SZCRC", "SZCRC", JdeDataType.String, 6),
        new JdeField("SZVINV", "SZVINV", JdeDataType.String, 50),
        new JdeField("SZPKCO", "SZPKCO", JdeDataType.String, 10),
        new JdeField("SZPO", "SZPO", JdeDataType.String, 16),
        new JdeField("SZPDCT", "SZPDCT", JdeDataType.String, 4),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZUNIT", "SZUNIT", JdeDataType.String, 16),
        new JdeField("SZMCU2", "SZMCU2", JdeDataType.String, 24),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZRF", "SZRF", JdeDataType.String, 4),
        new JdeField("SZDRF", "SZDRF", JdeDataType.Numeric),
        new JdeField("SZCTL", "SZCTL", JdeDataType.String, 26),
        new JdeField("SZFNLP", "SZFNLP", JdeDataType.String, 2),
        new JdeField("SZU", "SZU", JdeDataType.Numeric),
        new JdeField("SZUM", "SZUM", JdeDataType.String, 4),
        new JdeField("SZPYIN", "SZPYIN", JdeDataType.String, 2),
        new JdeField("SZTXA3", "SZTXA3", JdeDataType.String, 20),
        new JdeField("SZEXR3", "SZEXR3", JdeDataType.String, 4),
        new JdeField("SZRP1", "SZRP1", JdeDataType.String, 2),
        new JdeField("SZRP2", "SZRP2", JdeDataType.String, 2),
        new JdeField("SZRP3", "SZRP3", JdeDataType.String, 2),
        new JdeField("SZAC07", "SZAC07", JdeDataType.String, 6),
        new JdeField("SZTNN", "SZTNN", JdeDataType.String, 2),
        new JdeField("SZDMCD", "SZDMCD", JdeDataType.String, 2),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZHCRR", "SZHCRR", JdeDataType.Numeric),
        new JdeField("SZHDGJ", "SZHDGJ", JdeDataType.Numeric),
        new JdeField("SZDIM", "SZDIM", JdeDataType.Numeric),
        new JdeField("SZDID", "SZDID", JdeDataType.Numeric),
        new JdeField("SZDIY", "SZDIY", JdeDataType.Numeric),
        new JdeField("SZDI#", "SZDI#", JdeDataType.Numeric),
        new JdeField("SZDSVM", "SZDSVM", JdeDataType.Numeric),
        new JdeField("SZDSVD", "SZDSVD", JdeDataType.Numeric),
        new JdeField("SZDSVY", "SZDSVY", JdeDataType.Numeric),
        new JdeField("SZDSY#", "SZDSY#", JdeDataType.Numeric),
        new JdeField("SZDDM", "SZDDM", JdeDataType.Numeric),
        new JdeField("SZDDD", "SZDDD", JdeDataType.Numeric),
        new JdeField("SZDDY", "SZDDY", JdeDataType.Numeric),
        new JdeField("SZDD#", "SZDD#", JdeDataType.Numeric),
        new JdeField("SZDDNM", "SZDDNM", JdeDataType.Numeric),
        new JdeField("SZDDND", "SZDDND", JdeDataType.Numeric),
        new JdeField("SZDDNY", "SZDDNY", JdeDataType.Numeric),
        new JdeField("SZDDN#", "SZDDN#", JdeDataType.Numeric),
        new JdeField("SZDGM", "SZDGM", JdeDataType.Numeric),
        new JdeField("SZDGD", "SZDGD", JdeDataType.Numeric),
        new JdeField("SZDGY", "SZDGY", JdeDataType.Numeric),
        new JdeField("SZDG#", "SZDG#", JdeDataType.Numeric),
        new JdeField("SZDICM", "SZDICM", JdeDataType.Numeric),
        new JdeField("SZDICD", "SZDICD", JdeDataType.Numeric),
        new JdeField("SZDICY", "SZDICY", JdeDataType.Numeric),
        new JdeField("SZDIC#", "SZDIC#", JdeDataType.Numeric),
        new JdeField("SZHDGM", "SZHDGM", JdeDataType.Numeric),
        new JdeField("SZHDGD", "SZHDGD", JdeDataType.Numeric),
        new JdeField("SZHDGY", "SZHDGY", JdeDataType.Numeric),
        new JdeField("SZHDG#", "SZHDG#", JdeDataType.Numeric),
        new JdeField("SZDOCM", "SZDOCM", JdeDataType.Numeric),
        new JdeField("SZURC1", "SZURC1", JdeDataType.String, 6),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
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
        new JdeField("SZTNST", "SZTNST", JdeDataType.String, 40),
        new JdeField("SZYC01", "SZYC01", JdeDataType.String, 6),
        new JdeField("SZYC02", "SZYC02", JdeDataType.String, 6),
        new JdeField("SZYC03", "SZYC03", JdeDataType.String, 6),
        new JdeField("SZYC04", "SZYC04", JdeDataType.String, 6),
        new JdeField("SZYC05", "SZYC05", JdeDataType.String, 6),
        new JdeField("SZYC06", "SZYC06", JdeDataType.String, 6),
        new JdeField("SZYC07", "SZYC07", JdeDataType.String, 6),
        new JdeField("SZYC08", "SZYC08", JdeDataType.String, 6),
        new JdeField("SZYC09", "SZYC09", JdeDataType.String, 6),
        new JdeField("SZYC10", "SZYC10", JdeDataType.String, 6),
        new JdeField("SZDTXS", "SZDTXS", JdeDataType.String, 2),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZATAD", "SZATAD", JdeDataType.Numeric),
        new JdeField("SZCTAD", "SZCTAD", JdeDataType.Numeric),
        new JdeField("SZNRTA", "SZNRTA", JdeDataType.Numeric),
        new JdeField("SZFNRT", "SZFNRT", JdeDataType.Numeric),
        new JdeField("SZTAXP", "SZTAXP", JdeDataType.String, 2),
        new JdeField("SZPRGF", "SZPRGF", JdeDataType.String, 2),
        new JdeField("SZGFL5", "SZGFL5", JdeDataType.String, 2),
        new JdeField("SZGFL6", "SZGFL6", JdeDataType.String, 2),
        new JdeField("SZGAM1", "SZGAM1", JdeDataType.Numeric),
        new JdeField("SZGAM2", "SZGAM2", JdeDataType.Numeric),
        new JdeField("SZGEN4", "SZGEN4", JdeDataType.String, 50),
        new JdeField("SZGEN5", "SZGEN5", JdeDataType.String, 50),
        new JdeField("SZWTAD", "SZWTAD", JdeDataType.Numeric),
        new JdeField("SZWTAF", "SZWTAF", JdeDataType.Numeric),
        new JdeField("SZSMMF", "SZSMMF", JdeDataType.String, 2),
        new JdeField("SZPYWP", "SZPYWP", JdeDataType.String, 2),
        new JdeField("SZPWPG", "SZPWPG", JdeDataType.Numeric),
        new JdeField("SZNETTCID", "SZNETTCID", JdeDataType.Numeric),
        new JdeField("SZNETDOC", "SZNETDOC", JdeDataType.Numeric),
        new JdeField("SZNETRC5", "SZNETRC5", JdeDataType.Numeric),
        new JdeField("SZNETST", "SZNETST", JdeDataType.String, 2),
        new JdeField("SZCNTRTID", "SZCNTRTID", JdeDataType.Numeric),
        new JdeField("SZCNTRTCD", "SZCNTRTCD", JdeDataType.String, 24),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZBLSCD2", "SZBLSCD2", JdeDataType.String, 20),
        new JdeField("SZHARPER", "SZHARPER", JdeDataType.String, 12),
        new JdeField("SZHARSFX", "SZHARSFX", JdeDataType.String, 20),
        new JdeField("SZDDRL", "SZDDRL", JdeDataType.String, 10),
        new JdeField("SZSEQN", "SZSEQN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411Z3_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0411Z3_2", "Index on SZDOC, SZDCT, SZKCO, SZSFX", new[] { "SZDOC", "SZDCT", "SZKCO", "SZSFX" })
    };
}
