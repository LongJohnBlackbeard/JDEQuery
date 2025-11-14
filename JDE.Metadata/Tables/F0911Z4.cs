using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911Z4 - .
/// </summary>
public class F0911Z4 : JdeTable
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
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDGJ.
        /// </summary>
        public const string SZDGJ = "SZDGJ";

        /// <summary>
        /// SZJELN.
        /// </summary>
        public const string SZJELN = "SZJELN";

        /// <summary>
        /// SZEXTL.
        /// </summary>
        public const string SZEXTL = "SZEXTL";

        /// <summary>
        /// SZPOST.
        /// </summary>
        public const string SZPOST = "SZPOST";

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
        /// SZDSYJ.
        /// </summary>
        public const string SZDSYJ = "SZDSYJ";

        /// <summary>
        /// SZTICU.
        /// </summary>
        public const string SZTICU = "SZTICU";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZANI.
        /// </summary>
        public const string SZANI = "SZANI";

        /// <summary>
        /// SZAM.
        /// </summary>
        public const string SZAM = "SZAM";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

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
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZLT.
        /// </summary>
        public const string SZLT = "SZLT";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZFQ.
        /// </summary>
        public const string SZFQ = "SZFQ";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZHCRR.
        /// </summary>
        public const string SZHCRR = "SZHCRR";

        /// <summary>
        /// SZHDGJ.
        /// </summary>
        public const string SZHDGJ = "SZHDGJ";

        /// <summary>
        /// SZAA.
        /// </summary>
        public const string SZAA = "SZAA";

        /// <summary>
        /// SZU.
        /// </summary>
        public const string SZU = "SZU";

        /// <summary>
        /// SZUM.
        /// </summary>
        public const string SZUM = "SZUM";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZRE.
        /// </summary>
        public const string SZRE = "SZRE";

        /// <summary>
        /// SZEXA.
        /// </summary>
        public const string SZEXA = "SZEXA";

        /// <summary>
        /// SZEXR.
        /// </summary>
        public const string SZEXR = "SZEXR";

        /// <summary>
        /// SZR1.
        /// </summary>
        public const string SZR1 = "SZR1";

        /// <summary>
        /// SZR2.
        /// </summary>
        public const string SZR2 = "SZR2";

        /// <summary>
        /// SZR3.
        /// </summary>
        public const string SZR3 = "SZR3";

        /// <summary>
        /// SZSFX.
        /// </summary>
        public const string SZSFX = "SZSFX";

        /// <summary>
        /// SZODOC.
        /// </summary>
        public const string SZODOC = "SZODOC";

        /// <summary>
        /// SZODCT.
        /// </summary>
        public const string SZODCT = "SZODCT";

        /// <summary>
        /// SZOSFX.
        /// </summary>
        public const string SZOSFX = "SZOSFX";

        /// <summary>
        /// SZPKCO.
        /// </summary>
        public const string SZPKCO = "SZPKCO";

        /// <summary>
        /// SZOKCO.
        /// </summary>
        public const string SZOKCO = "SZOKCO";

        /// <summary>
        /// SZPDCT.
        /// </summary>
        public const string SZPDCT = "SZPDCT";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZCN.
        /// </summary>
        public const string SZCN = "SZCN";

        /// <summary>
        /// SZDKJ.
        /// </summary>
        public const string SZDKJ = "SZDKJ";

        /// <summary>
        /// SZDKC.
        /// </summary>
        public const string SZDKC = "SZDKC";

        /// <summary>
        /// SZASID.
        /// </summary>
        public const string SZASID = "SZASID";

        /// <summary>
        /// SZBRE.
        /// </summary>
        public const string SZBRE = "SZBRE";

        /// <summary>
        /// SZRCND.
        /// </summary>
        public const string SZRCND = "SZRCND";

        /// <summary>
        /// SZSUMM.
        /// </summary>
        public const string SZSUMM = "SZSUMM";

        /// <summary>
        /// SZPRGE.
        /// </summary>
        public const string SZPRGE = "SZPRGE";

        /// <summary>
        /// SZTNN.
        /// </summary>
        public const string SZTNN = "SZTNN";

        /// <summary>
        /// SZALT1.
        /// </summary>
        public const string SZALT1 = "SZALT1";

        /// <summary>
        /// SZALT2.
        /// </summary>
        public const string SZALT2 = "SZALT2";

        /// <summary>
        /// SZALT3.
        /// </summary>
        public const string SZALT3 = "SZALT3";

        /// <summary>
        /// SZALT4.
        /// </summary>
        public const string SZALT4 = "SZALT4";

        /// <summary>
        /// SZALT5.
        /// </summary>
        public const string SZALT5 = "SZALT5";

        /// <summary>
        /// SZALT6.
        /// </summary>
        public const string SZALT6 = "SZALT6";

        /// <summary>
        /// SZALT7.
        /// </summary>
        public const string SZALT7 = "SZALT7";

        /// <summary>
        /// SZALT8.
        /// </summary>
        public const string SZALT8 = "SZALT8";

        /// <summary>
        /// SZALT9.
        /// </summary>
        public const string SZALT9 = "SZALT9";

        /// <summary>
        /// SZALT0.
        /// </summary>
        public const string SZALT0 = "SZALT0";

        /// <summary>
        /// SZALTT.
        /// </summary>
        public const string SZALTT = "SZALTT";

        /// <summary>
        /// SZALTU.
        /// </summary>
        public const string SZALTU = "SZALTU";

        /// <summary>
        /// SZALTV.
        /// </summary>
        public const string SZALTV = "SZALTV";

        /// <summary>
        /// SZALTW.
        /// </summary>
        public const string SZALTW = "SZALTW";

        /// <summary>
        /// SZALTX.
        /// </summary>
        public const string SZALTX = "SZALTX";

        /// <summary>
        /// SZALTZ.
        /// </summary>
        public const string SZALTZ = "SZALTZ";

        /// <summary>
        /// SZDLNA.
        /// </summary>
        public const string SZDLNA = "SZDLNA";

        /// <summary>
        /// SZCFF1.
        /// </summary>
        public const string SZCFF1 = "SZCFF1";

        /// <summary>
        /// SZCFF2.
        /// </summary>
        public const string SZCFF2 = "SZCFF2";

        /// <summary>
        /// SZASM.
        /// </summary>
        public const string SZASM = "SZASM";

        /// <summary>
        /// SZBC.
        /// </summary>
        public const string SZBC = "SZBC";

        /// <summary>
        /// SZVINV.
        /// </summary>
        public const string SZVINV = "SZVINV";

        /// <summary>
        /// SZIVD.
        /// </summary>
        public const string SZIVD = "SZIVD";

        /// <summary>
        /// SZWR01.
        /// </summary>
        public const string SZWR01 = "SZWR01";

        /// <summary>
        /// SZPO.
        /// </summary>
        public const string SZPO = "SZPO";

        /// <summary>
        /// SZPSFX.
        /// </summary>
        public const string SZPSFX = "SZPSFX";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZWY.
        /// </summary>
        public const string SZWY = "SZWY";

        /// <summary>
        /// SZWN.
        /// </summary>
        public const string SZWN = "SZWN";

        /// <summary>
        /// SZFNLP.
        /// </summary>
        public const string SZFNLP = "SZFNLP";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZJBST.
        /// </summary>
        public const string SZJBST = "SZJBST";

        /// <summary>
        /// SZHMCU.
        /// </summary>
        public const string SZHMCU = "SZHMCU";

        /// <summary>
        /// SZDOI.
        /// </summary>
        public const string SZDOI = "SZDOI";

        /// <summary>
        /// SZALID.
        /// </summary>
        public const string SZALID = "SZALID";

        /// <summary>
        /// SZALTY.
        /// </summary>
        public const string SZALTY = "SZALTY";

        /// <summary>
        /// SZDSVJ.
        /// </summary>
        public const string SZDSVJ = "SZDSVJ";

        /// <summary>
        /// SZREG#.
        /// </summary>
        public const string SZREG_ = "SZREG#";

        /// <summary>
        /// SZPYID.
        /// </summary>
        public const string SZPYID = "SZPYID";

        /// <summary>
        /// SZCRRM.
        /// </summary>
        public const string SZCRRM = "SZCRRM";

        /// <summary>
        /// SZACR.
        /// </summary>
        public const string SZACR = "SZACR";

        /// <summary>
        /// SZCRDC.
        /// </summary>
        public const string SZCRDC = "SZCRDC";

        /// <summary>
        /// SZPYIN.
        /// </summary>
        public const string SZPYIN = "SZPYIN";

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
        /// SZABR1.
        /// </summary>
        public const string SZABR1 = "SZABR1";

        /// <summary>
        /// SZABR2.
        /// </summary>
        public const string SZABR2 = "SZABR2";

        /// <summary>
        /// SZABR3.
        /// </summary>
        public const string SZABR3 = "SZABR3";

        /// <summary>
        /// SZABR4.
        /// </summary>
        public const string SZABR4 = "SZABR4";

        /// <summary>
        /// SZABT1.
        /// </summary>
        public const string SZABT1 = "SZABT1";

        /// <summary>
        /// SZABT2.
        /// </summary>
        public const string SZABT2 = "SZABT2";

        /// <summary>
        /// SZABT3.
        /// </summary>
        public const string SZABT3 = "SZABT3";

        /// <summary>
        /// SZABT4.
        /// </summary>
        public const string SZABT4 = "SZABT4";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZPM01.
        /// </summary>
        public const string SZPM01 = "SZPM01";

        /// <summary>
        /// SZPM02.
        /// </summary>
        public const string SZPM02 = "SZPM02";

        /// <summary>
        /// SZPM03.
        /// </summary>
        public const string SZPM03 = "SZPM03";

        /// <summary>
        /// SZPM04.
        /// </summary>
        public const string SZPM04 = "SZPM04";

        /// <summary>
        /// SZPM05.
        /// </summary>
        public const string SZPM05 = "SZPM05";

        /// <summary>
        /// SZPM06.
        /// </summary>
        public const string SZPM06 = "SZPM06";

        /// <summary>
        /// SZPM07.
        /// </summary>
        public const string SZPM07 = "SZPM07";

        /// <summary>
        /// SZPM08.
        /// </summary>
        public const string SZPM08 = "SZPM08";

        /// <summary>
        /// SZPM09.
        /// </summary>
        public const string SZPM09 = "SZPM09";

        /// <summary>
        /// SZPM10.
        /// </summary>
        public const string SZPM10 = "SZPM10";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZTXITM.
        /// </summary>
        public const string SZTXITM = "SZTXITM";

        /// <summary>
        /// SZACTB.
        /// </summary>
        public const string SZACTB = "SZACTB";

        /// <summary>
        /// SZDLNID.
        /// </summary>
        public const string SZDLNID = "SZDLNID";

        /// <summary>
        /// SZCKNU.
        /// </summary>
        public const string SZCKNU = "SZCKNU";

        /// <summary>
        /// SZBUPC.
        /// </summary>
        public const string SZBUPC = "SZBUPC";

        /// <summary>
        /// SZAHBU.
        /// </summary>
        public const string SZAHBU = "SZAHBU";

        /// <summary>
        /// SZEPGC.
        /// </summary>
        public const string SZEPGC = "SZEPGC";

        /// <summary>
        /// SZJPGC.
        /// </summary>
        public const string SZJPGC = "SZJPGC";

        /// <summary>
        /// SZRC5.
        /// </summary>
        public const string SZRC5 = "SZRC5";

        /// <summary>
        /// SZSFXE.
        /// </summary>
        public const string SZSFXE = "SZSFXE";

        /// <summary>
        /// SZOFM.
        /// </summary>
        public const string SZOFM = "SZOFM";
    }

    /// <inheritdoc />
    public override string TableName => "F0911Z4";

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
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDGJ", "SZDGJ", JdeDataType.Numeric),
        new JdeField("SZJELN", "SZJELN", JdeDataType.Numeric),
        new JdeField("SZEXTL", "SZEXTL", JdeDataType.String, 4),
        new JdeField("SZPOST", "SZPOST", JdeDataType.String, 2),
        new JdeField("SZICU", "SZICU", JdeDataType.Numeric),
        new JdeField("SZICUT", "SZICUT", JdeDataType.String, 4),
        new JdeField("SZDICJ", "SZDICJ", JdeDataType.Numeric),
        new JdeField("SZDSYJ", "SZDSYJ", JdeDataType.Numeric),
        new JdeField("SZTICU", "SZTICU", JdeDataType.Numeric),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZAM", "SZAM", JdeDataType.String, 2),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZLT", "SZLT", JdeDataType.String, 4),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZFQ", "SZFQ", JdeDataType.String, 8),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZHCRR", "SZHCRR", JdeDataType.Numeric),
        new JdeField("SZHDGJ", "SZHDGJ", JdeDataType.Numeric),
        new JdeField("SZAA", "SZAA", JdeDataType.Numeric),
        new JdeField("SZU", "SZU", JdeDataType.Numeric),
        new JdeField("SZUM", "SZUM", JdeDataType.String, 4),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZRE", "SZRE", JdeDataType.String, 2),
        new JdeField("SZEXA", "SZEXA", JdeDataType.String, 60),
        new JdeField("SZEXR", "SZEXR", JdeDataType.String, 60),
        new JdeField("SZR1", "SZR1", JdeDataType.String, 16),
        new JdeField("SZR2", "SZR2", JdeDataType.String, 16),
        new JdeField("SZR3", "SZR3", JdeDataType.String, 16),
        new JdeField("SZSFX", "SZSFX", JdeDataType.String, 6),
        new JdeField("SZODOC", "SZODOC", JdeDataType.Numeric),
        new JdeField("SZODCT", "SZODCT", JdeDataType.String, 4),
        new JdeField("SZOSFX", "SZOSFX", JdeDataType.String, 6),
        new JdeField("SZPKCO", "SZPKCO", JdeDataType.String, 10),
        new JdeField("SZOKCO", "SZOKCO", JdeDataType.String, 10),
        new JdeField("SZPDCT", "SZPDCT", JdeDataType.String, 4),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZCN", "SZCN", JdeDataType.String, 16),
        new JdeField("SZDKJ", "SZDKJ", JdeDataType.Numeric),
        new JdeField("SZDKC", "SZDKC", JdeDataType.Numeric),
        new JdeField("SZASID", "SZASID", JdeDataType.String, 50),
        new JdeField("SZBRE", "SZBRE", JdeDataType.String, 2),
        new JdeField("SZRCND", "SZRCND", JdeDataType.String, 2),
        new JdeField("SZSUMM", "SZSUMM", JdeDataType.String, 2),
        new JdeField("SZPRGE", "SZPRGE", JdeDataType.String, 2),
        new JdeField("SZTNN", "SZTNN", JdeDataType.String, 2),
        new JdeField("SZALT1", "SZALT1", JdeDataType.String, 2),
        new JdeField("SZALT2", "SZALT2", JdeDataType.String, 2),
        new JdeField("SZALT3", "SZALT3", JdeDataType.String, 2),
        new JdeField("SZALT4", "SZALT4", JdeDataType.String, 2),
        new JdeField("SZALT5", "SZALT5", JdeDataType.String, 2),
        new JdeField("SZALT6", "SZALT6", JdeDataType.String, 2),
        new JdeField("SZALT7", "SZALT7", JdeDataType.String, 2),
        new JdeField("SZALT8", "SZALT8", JdeDataType.String, 2),
        new JdeField("SZALT9", "SZALT9", JdeDataType.String, 2),
        new JdeField("SZALT0", "SZALT0", JdeDataType.String, 2),
        new JdeField("SZALTT", "SZALTT", JdeDataType.String, 2),
        new JdeField("SZALTU", "SZALTU", JdeDataType.String, 2),
        new JdeField("SZALTV", "SZALTV", JdeDataType.String, 2),
        new JdeField("SZALTW", "SZALTW", JdeDataType.String, 2),
        new JdeField("SZALTX", "SZALTX", JdeDataType.String, 2),
        new JdeField("SZALTZ", "SZALTZ", JdeDataType.String, 2),
        new JdeField("SZDLNA", "SZDLNA", JdeDataType.String, 2),
        new JdeField("SZCFF1", "SZCFF1", JdeDataType.String, 2),
        new JdeField("SZCFF2", "SZCFF2", JdeDataType.String, 2),
        new JdeField("SZASM", "SZASM", JdeDataType.String, 2),
        new JdeField("SZBC", "SZBC", JdeDataType.String, 2),
        new JdeField("SZVINV", "SZVINV", JdeDataType.String, 50),
        new JdeField("SZIVD", "SZIVD", JdeDataType.Numeric),
        new JdeField("SZWR01", "SZWR01", JdeDataType.String, 8),
        new JdeField("SZPO", "SZPO", JdeDataType.String, 16),
        new JdeField("SZPSFX", "SZPSFX", JdeDataType.String, 6),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZWY", "SZWY", JdeDataType.Numeric),
        new JdeField("SZWN", "SZWN", JdeDataType.Numeric),
        new JdeField("SZFNLP", "SZFNLP", JdeDataType.String, 2),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZJBST", "SZJBST", JdeDataType.String, 8),
        new JdeField("SZHMCU", "SZHMCU", JdeDataType.String, 24),
        new JdeField("SZDOI", "SZDOI", JdeDataType.Numeric),
        new JdeField("SZALID", "SZALID", JdeDataType.String, 50),
        new JdeField("SZALTY", "SZALTY", JdeDataType.String, 4),
        new JdeField("SZDSVJ", "SZDSVJ", JdeDataType.Numeric),
        new JdeField("SZREG#", "SZREG#", JdeDataType.Numeric),
        new JdeField("SZPYID", "SZPYID", JdeDataType.Numeric),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZACR", "SZACR", JdeDataType.Numeric),
        new JdeField("SZCRDC", "SZCRDC", JdeDataType.String, 6),
        new JdeField("SZPYIN", "SZPYIN", JdeDataType.String, 2),
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
        new JdeField("SZABR1", "SZABR1", JdeDataType.String, 24),
        new JdeField("SZABR2", "SZABR2", JdeDataType.String, 24),
        new JdeField("SZABR3", "SZABR3", JdeDataType.String, 24),
        new JdeField("SZABR4", "SZABR4", JdeDataType.String, 24),
        new JdeField("SZABT1", "SZABT1", JdeDataType.String, 2),
        new JdeField("SZABT2", "SZABT2", JdeDataType.String, 2),
        new JdeField("SZABT3", "SZABT3", JdeDataType.String, 2),
        new JdeField("SZABT4", "SZABT4", JdeDataType.String, 2),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZPM01", "SZPM01", JdeDataType.String, 2),
        new JdeField("SZPM02", "SZPM02", JdeDataType.String, 2),
        new JdeField("SZPM03", "SZPM03", JdeDataType.String, 2),
        new JdeField("SZPM04", "SZPM04", JdeDataType.String, 2),
        new JdeField("SZPM05", "SZPM05", JdeDataType.String, 2),
        new JdeField("SZPM06", "SZPM06", JdeDataType.String, 2),
        new JdeField("SZPM07", "SZPM07", JdeDataType.String, 2),
        new JdeField("SZPM08", "SZPM08", JdeDataType.String, 2),
        new JdeField("SZPM09", "SZPM09", JdeDataType.String, 2),
        new JdeField("SZPM10", "SZPM10", JdeDataType.String, 2),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXITM", "SZTXITM", JdeDataType.Numeric),
        new JdeField("SZACTB", "SZACTB", JdeDataType.String, 20),
        new JdeField("SZDLNID", "SZDLNID", JdeDataType.Numeric),
        new JdeField("SZCKNU", "SZCKNU", JdeDataType.String, 50),
        new JdeField("SZBUPC", "SZBUPC", JdeDataType.String, 2),
        new JdeField("SZAHBU", "SZAHBU", JdeDataType.String, 24),
        new JdeField("SZEPGC", "SZEPGC", JdeDataType.String, 6),
        new JdeField("SZJPGC", "SZJPGC", JdeDataType.String, 6),
        new JdeField("SZRC5", "SZRC5", JdeDataType.Numeric),
        new JdeField("SZSFXE", "SZSFXE", JdeDataType.Numeric),
        new JdeField("SZOFM", "SZOFM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911Z4_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
