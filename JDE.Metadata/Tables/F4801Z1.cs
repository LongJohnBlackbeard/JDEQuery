using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801Z1 - .
/// </summary>
public class F4801Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYRCD.
        /// </summary>
        public const string SYRCD = "SYRCD";

        /// <summary>
        /// SYDGL.
        /// </summary>
        public const string SYDGL = "SYDGL";

        /// <summary>
        /// SYLOTS.
        /// </summary>
        public const string SYLOTS = "SYLOTS";

        /// <summary>
        /// SYEXPR.
        /// </summary>
        public const string SYEXPR = "SYEXPR";

        /// <summary>
        /// SYLOT1.
        /// </summary>
        public const string SYLOT1 = "SYLOT1";

        /// <summary>
        /// SYLOT2.
        /// </summary>
        public const string SYLOT2 = "SYLOT2";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYSFXO.
        /// </summary>
        public const string SYSFXO = "SYSFXO";

        /// <summary>
        /// SYRCTO.
        /// </summary>
        public const string SYRCTO = "SYRCTO";

        /// <summary>
        /// SYRORN.
        /// </summary>
        public const string SYRORN = "SYRORN";

        /// <summary>
        /// SYLNID.
        /// </summary>
        public const string SYLNID = "SYLNID";

        /// <summary>
        /// SYPTWO.
        /// </summary>
        public const string SYPTWO = "SYPTWO";

        /// <summary>
        /// SYPARS.
        /// </summary>
        public const string SYPARS = "SYPARS";

        /// <summary>
        /// SYTYPS.
        /// </summary>
        public const string SYTYPS = "SYTYPS";

        /// <summary>
        /// SYPRTS.
        /// </summary>
        public const string SYPRTS = "SYPRTS";

        /// <summary>
        /// SYDL01.
        /// </summary>
        public const string SYDL01 = "SYDL01";

        /// <summary>
        /// SYSTCM.
        /// </summary>
        public const string SYSTCM = "SYSTCM";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYMCU.
        /// </summary>
        public const string SYMCU = "SYMCU";

        /// <summary>
        /// SYMMCU.
        /// </summary>
        public const string SYMMCU = "SYMMCU";

        /// <summary>
        /// SYLOCN.
        /// </summary>
        public const string SYLOCN = "SYLOCN";

        /// <summary>
        /// SYAISL.
        /// </summary>
        public const string SYAISL = "SYAISL";

        /// <summary>
        /// SYBIN.
        /// </summary>
        public const string SYBIN = "SYBIN";

        /// <summary>
        /// SYSRST.
        /// </summary>
        public const string SYSRST = "SYSRST";

        /// <summary>
        /// SYDCG.
        /// </summary>
        public const string SYDCG = "SYDCG";

        /// <summary>
        /// SYSUB.
        /// </summary>
        public const string SYSUB = "SYSUB";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYANO.
        /// </summary>
        public const string SYANO = "SYANO";

        /// <summary>
        /// SYANSA.
        /// </summary>
        public const string SYANSA = "SYANSA";

        /// <summary>
        /// SYANPA.
        /// </summary>
        public const string SYANPA = "SYANPA";

        /// <summary>
        /// SYANP.
        /// </summary>
        public const string SYANP = "SYANP";

        /// <summary>
        /// SYDPL.
        /// </summary>
        public const string SYDPL = "SYDPL";

        /// <summary>
        /// SYANT.
        /// </summary>
        public const string SYANT = "SYANT";

        /// <summary>
        /// SYNAN8.
        /// </summary>
        public const string SYNAN8 = "SYNAN8";

        /// <summary>
        /// SYTRDJ.
        /// </summary>
        public const string SYTRDJ = "SYTRDJ";

        /// <summary>
        /// SYSTRT.
        /// </summary>
        public const string SYSTRT = "SYSTRT";

        /// <summary>
        /// SYDRQJ.
        /// </summary>
        public const string SYDRQJ = "SYDRQJ";

        /// <summary>
        /// SYSTRX.
        /// </summary>
        public const string SYSTRX = "SYSTRX";

        /// <summary>
        /// SYDAP.
        /// </summary>
        public const string SYDAP = "SYDAP";

        /// <summary>
        /// SYDAT.
        /// </summary>
        public const string SYDAT = "SYDAT";

        /// <summary>
        /// SYPPDT.
        /// </summary>
        public const string SYPPDT = "SYPPDT";

        /// <summary>
        /// SYWR01.
        /// </summary>
        public const string SYWR01 = "SYWR01";

        /// <summary>
        /// SYWR02.
        /// </summary>
        public const string SYWR02 = "SYWR02";

        /// <summary>
        /// SYWR03.
        /// </summary>
        public const string SYWR03 = "SYWR03";

        /// <summary>
        /// SYWR04.
        /// </summary>
        public const string SYWR04 = "SYWR04";

        /// <summary>
        /// SYWR05.
        /// </summary>
        public const string SYWR05 = "SYWR05";

        /// <summary>
        /// SYWR06.
        /// </summary>
        public const string SYWR06 = "SYWR06";

        /// <summary>
        /// SYWR07.
        /// </summary>
        public const string SYWR07 = "SYWR07";

        /// <summary>
        /// SYWR08.
        /// </summary>
        public const string SYWR08 = "SYWR08";

        /// <summary>
        /// SYWR09.
        /// </summary>
        public const string SYWR09 = "SYWR09";

        /// <summary>
        /// SYWR10.
        /// </summary>
        public const string SYWR10 = "SYWR10";

        /// <summary>
        /// SYVR01.
        /// </summary>
        public const string SYVR01 = "SYVR01";

        /// <summary>
        /// SYVR02.
        /// </summary>
        public const string SYVR02 = "SYVR02";

        /// <summary>
        /// SYAMTO.
        /// </summary>
        public const string SYAMTO = "SYAMTO";

        /// <summary>
        /// SYSETC.
        /// </summary>
        public const string SYSETC = "SYSETC";

        /// <summary>
        /// SYBRT.
        /// </summary>
        public const string SYBRT = "SYBRT";

        /// <summary>
        /// SYPAYT.
        /// </summary>
        public const string SYPAYT = "SYPAYT";

        /// <summary>
        /// SYAMTC.
        /// </summary>
        public const string SYAMTC = "SYAMTC";

        /// <summary>
        /// SYHRSO.
        /// </summary>
        public const string SYHRSO = "SYHRSO";

        /// <summary>
        /// SYHRSC.
        /// </summary>
        public const string SYHRSC = "SYHRSC";

        /// <summary>
        /// SYAMTA.
        /// </summary>
        public const string SYAMTA = "SYAMTA";

        /// <summary>
        /// SYHRSA.
        /// </summary>
        public const string SYHRSA = "SYHRSA";

        /// <summary>
        /// SYITM.
        /// </summary>
        public const string SYITM = "SYITM";

        /// <summary>
        /// SYAITM.
        /// </summary>
        public const string SYAITM = "SYAITM";

        /// <summary>
        /// SYLITM.
        /// </summary>
        public const string SYLITM = "SYLITM";

        /// <summary>
        /// SYNUMB.
        /// </summary>
        public const string SYNUMB = "SYNUMB";

        /// <summary>
        /// SYAPID.
        /// </summary>
        public const string SYAPID = "SYAPID";

        /// <summary>
        /// SYUORG.
        /// </summary>
        public const string SYUORG = "SYUORG";

        /// <summary>
        /// SYSOBK.
        /// </summary>
        public const string SYSOBK = "SYSOBK";

        /// <summary>
        /// SYSOCN.
        /// </summary>
        public const string SYSOCN = "SYSOCN";

        /// <summary>
        /// SYSOQS.
        /// </summary>
        public const string SYSOQS = "SYSOQS";

        /// <summary>
        /// SYQTYT.
        /// </summary>
        public const string SYQTYT = "SYQTYT";

        /// <summary>
        /// SYUOM.
        /// </summary>
        public const string SYUOM = "SYUOM";

        /// <summary>
        /// SYSHNO.
        /// </summary>
        public const string SYSHNO = "SYSHNO";

        /// <summary>
        /// SYPBTM.
        /// </summary>
        public const string SYPBTM = "SYPBTM";

        /// <summary>
        /// SYTBM.
        /// </summary>
        public const string SYTBM = "SYTBM";

        /// <summary>
        /// SYTRT.
        /// </summary>
        public const string SYTRT = "SYTRT";

        /// <summary>
        /// SYSHTY.
        /// </summary>
        public const string SYSHTY = "SYSHTY";

        /// <summary>
        /// SYPEC.
        /// </summary>
        public const string SYPEC = "SYPEC";

        /// <summary>
        /// SYPPFG.
        /// </summary>
        public const string SYPPFG = "SYPPFG";

        /// <summary>
        /// SYBM.
        /// </summary>
        public const string SYBM = "SYBM";

        /// <summary>
        /// SYRTG.
        /// </summary>
        public const string SYRTG = "SYRTG";

        /// <summary>
        /// SYSPRT.
        /// </summary>
        public const string SYSPRT = "SYSPRT";

        /// <summary>
        /// SYUNCD.
        /// </summary>
        public const string SYUNCD = "SYUNCD";

        /// <summary>
        /// SYINDC.
        /// </summary>
        public const string SYINDC = "SYINDC";

        /// <summary>
        /// SYRESC.
        /// </summary>
        public const string SYRESC = "SYRESC";

        /// <summary>
        /// SYMOH.
        /// </summary>
        public const string SYMOH = "SYMOH";

        /// <summary>
        /// SYTDT.
        /// </summary>
        public const string SYTDT = "SYTDT";

        /// <summary>
        /// SYPOU.
        /// </summary>
        public const string SYPOU = "SYPOU";

        /// <summary>
        /// SYPC.
        /// </summary>
        public const string SYPC = "SYPC";

        /// <summary>
        /// SYLTLV.
        /// </summary>
        public const string SYLTLV = "SYLTLV";

        /// <summary>
        /// SYLTCM.
        /// </summary>
        public const string SYLTCM = "SYLTCM";

        /// <summary>
        /// SYCTS1.
        /// </summary>
        public const string SYCTS1 = "SYCTS1";

        /// <summary>
        /// SYLOTN.
        /// </summary>
        public const string SYLOTN = "SYLOTN";

        /// <summary>
        /// SYLOTP.
        /// </summary>
        public const string SYLOTP = "SYLOTP";

        /// <summary>
        /// SYLOTG.
        /// </summary>
        public const string SYLOTG = "SYLOTG";

        /// <summary>
        /// SYRAT1.
        /// </summary>
        public const string SYRAT1 = "SYRAT1";

        /// <summary>
        /// SYRAT2.
        /// </summary>
        public const string SYRAT2 = "SYRAT2";

        /// <summary>
        /// SYDCT.
        /// </summary>
        public const string SYDCT = "SYDCT";

        /// <summary>
        /// SYSBLI.
        /// </summary>
        public const string SYSBLI = "SYSBLI";

        /// <summary>
        /// SYRKCO.
        /// </summary>
        public const string SYRKCO = "SYRKCO";

        /// <summary>
        /// SYBREV.
        /// </summary>
        public const string SYBREV = "SYBREV";

        /// <summary>
        /// SYRREV.
        /// </summary>
        public const string SYRREV = "SYRREV";

        /// <summary>
        /// SYDRWC.
        /// </summary>
        public const string SYDRWC = "SYDRWC";

        /// <summary>
        /// SYRTCH.
        /// </summary>
        public const string SYRTCH = "SYRTCH";

        /// <summary>
        /// SYPNRQ.
        /// </summary>
        public const string SYPNRQ = "SYPNRQ";

        /// <summary>
        /// SYREAS.
        /// </summary>
        public const string SYREAS = "SYREAS";

        /// <summary>
        /// SYPHSE.
        /// </summary>
        public const string SYPHSE = "SYPHSE";

        /// <summary>
        /// SYXDSP.
        /// </summary>
        public const string SYXDSP = "SYXDSP";

        /// <summary>
        /// SYBOMC.
        /// </summary>
        public const string SYBOMC = "SYBOMC";

        /// <summary>
        /// SYAAID.
        /// </summary>
        public const string SYAAID = "SYAAID";

        /// <summary>
        /// SYNTST.
        /// </summary>
        public const string SYNTST = "SYNTST";

        /// <summary>
        /// SYXRTO.
        /// </summary>
        public const string SYXRTO = "SYXRTO";

        /// <summary>
        /// SYESDN.
        /// </summary>
        public const string SYESDN = "SYESDN";

        /// <summary>
        /// SYACDN.
        /// </summary>
        public const string SYACDN = "SYACDN";

        /// <summary>
        /// SYSAID.
        /// </summary>
        public const string SYSAID = "SYSAID";

        /// <summary>
        /// SYMPOS.
        /// </summary>
        public const string SYMPOS = "SYMPOS";

        /// <summary>
        /// SYAPRT.
        /// </summary>
        public const string SYAPRT = "SYAPRT";

        /// <summary>
        /// SYAMLC.
        /// </summary>
        public const string SYAMLC = "SYAMLC";

        /// <summary>
        /// SYAMMC.
        /// </summary>
        public const string SYAMMC = "SYAMMC";

        /// <summary>
        /// SYAMOT.
        /// </summary>
        public const string SYAMOT = "SYAMOT";

        /// <summary>
        /// SYLBAM.
        /// </summary>
        public const string SYLBAM = "SYLBAM";

        /// <summary>
        /// SYMTAM.
        /// </summary>
        public const string SYMTAM = "SYMTAM";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYLINE.
        /// </summary>
        public const string SYLINE = "SYLINE";

        /// <summary>
        /// SYMWDH.
        /// </summary>
        public const string SYMWDH = "SYMWDH";

        /// <summary>
        /// SYSHFT.
        /// </summary>
        public const string SYSHFT = "SYSHFT";

        /// <summary>
        /// SYSCSP.
        /// </summary>
        public const string SYSCSP = "SYSCSP";

        /// <summary>
        /// SYSRCN.
        /// </summary>
        public const string SYSRCN = "SYSRCN";

        /// <summary>
        /// SYLEDG.
        /// </summary>
        public const string SYLEDG = "SYLEDG";

        /// <summary>
        /// SYCTS4.
        /// </summary>
        public const string SYCTS4 = "SYCTS4";

        /// <summary>
        /// SYCTS8.
        /// </summary>
        public const string SYCTS8 = "SYCTS8";

        /// <summary>
        /// SYCTS7.
        /// </summary>
        public const string SYCTS7 = "SYCTS7";

        /// <summary>
        /// SYAID.
        /// </summary>
        public const string SYAID = "SYAID";

        /// <summary>
        /// SYALSE.
        /// </summary>
        public const string SYALSE = "SYALSE";

        /// <summary>
        /// SYASID.
        /// </summary>
        public const string SYASID = "SYASID";

        /// <summary>
        /// SYATST.
        /// </summary>
        public const string SYATST = "SYATST";

        /// <summary>
        /// SYBSEQ.
        /// </summary>
        public const string SYBSEQ = "SYBSEQ";

        /// <summary>
        /// SYCHPR.
        /// </summary>
        public const string SYCHPR = "SYCHPR";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRCE.
        /// </summary>
        public const string SYCRCE = "SYCRCE";

        /// <summary>
        /// SYCRCF.
        /// </summary>
        public const string SYCRCF = "SYCRCF";

        /// <summary>
        /// SYD5J.
        /// </summary>
        public const string SYD5J = "SYD5J";

        /// <summary>
        /// SYD6J.
        /// </summary>
        public const string SYD6J = "SYD6J";

        /// <summary>
        /// SYDRAW.
        /// </summary>
        public const string SYDRAW = "SYDRAW";

        /// <summary>
        /// SYDUAL.
        /// </summary>
        public const string SYDUAL = "SYDUAL";

        /// <summary>
        /// SYMPCE.
        /// </summary>
        public const string SYMPCE = "SYMPCE";

        /// <summary>
        /// SYMPRC.
        /// </summary>
        public const string SYMPRC = "SYMPRC";

        /// <summary>
        /// SYOBJ.
        /// </summary>
        public const string SYOBJ = "SYOBJ";

        /// <summary>
        /// SYOTAM.
        /// </summary>
        public const string SYOTAM = "SYOTAM";

        /// <summary>
        /// SYPRJM.
        /// </summary>
        public const string SYPRJM = "SYPRJM";

        /// <summary>
        /// SYPRRP.
        /// </summary>
        public const string SYPRRP = "SYPRRP";

        /// <summary>
        /// SYSHPP.
        /// </summary>
        public const string SYSHPP = "SYSHPP";

        /// <summary>
        /// SYSQOR.
        /// </summary>
        public const string SYSQOR = "SYSQOR";

        /// <summary>
        /// SYSRKF.
        /// </summary>
        public const string SYSRKF = "SYSRKF";

        /// <summary>
        /// SYSRNK.
        /// </summary>
        public const string SYSRNK = "SYSRNK";

        /// <summary>
        /// SYSSOQ.
        /// </summary>
        public const string SYSSOQ = "SYSSOQ";

        /// <summary>
        /// SYTRAF.
        /// </summary>
        public const string SYTRAF = "SYTRAF";

        /// <summary>
        /// SYUOM2.
        /// </summary>
        public const string SYUOM2 = "SYUOM2";

        /// <summary>
        /// SYWR11.
        /// </summary>
        public const string SYWR11 = "SYWR11";

        /// <summary>
        /// SYWR12.
        /// </summary>
        public const string SYWR12 = "SYWR12";

        /// <summary>
        /// SYWR13.
        /// </summary>
        public const string SYWR13 = "SYWR13";

        /// <summary>
        /// SYWR14.
        /// </summary>
        public const string SYWR14 = "SYWR14";

        /// <summary>
        /// SYWR15.
        /// </summary>
        public const string SYWR15 = "SYWR15";

        /// <summary>
        /// SYWR16.
        /// </summary>
        public const string SYWR16 = "SYWR16";

        /// <summary>
        /// SYWR17.
        /// </summary>
        public const string SYWR17 = "SYWR17";

        /// <summary>
        /// SYWR18.
        /// </summary>
        public const string SYWR18 = "SYWR18";

        /// <summary>
        /// SYWR19.
        /// </summary>
        public const string SYWR19 = "SYWR19";

        /// <summary>
        /// SYWR20.
        /// </summary>
        public const string SYWR20 = "SYWR20";

        /// <summary>
        /// SYVFWO.
        /// </summary>
        public const string SYVFWO = "SYVFWO";

        /// <summary>
        /// SYPMTN.
        /// </summary>
        public const string SYPMTN = "SYPMTN";

        /// <summary>
        /// SYSEST.
        /// </summary>
        public const string SYSEST = "SYSEST";

        /// <summary>
        /// SYSEET.
        /// </summary>
        public const string SYSEET = "SYSEET";

        /// <summary>
        /// SYDSAVNAME.
        /// </summary>
        public const string SYDSAVNAME = "SYDSAVNAME";

        /// <summary>
        /// SYTIMEZONES.
        /// </summary>
        public const string SYTIMEZONES = "SYTIMEZONES";

        /// <summary>
        /// SYSEQN.
        /// </summary>
        public const string SYSEQN = "SYSEQN";

        /// <summary>
        /// SYPLMR.
        /// </summary>
        public const string SYPLMR = "SYPLMR";

        /// <summary>
        /// SYPLLB.
        /// </summary>
        public const string SYPLLB = "SYPLLB";

        /// <summary>
        /// SYPLOS.
        /// </summary>
        public const string SYPLOS = "SYPLOS";

        /// <summary>
        /// SYBGTC.
        /// </summary>
        public const string SYBGTC = "SYBGTC";

        /// <summary>
        /// SYTOEM.
        /// </summary>
        public const string SYTOEM = "SYTOEM";

        /// <summary>
        /// SYTOPL.
        /// </summary>
        public const string SYTOPL = "SYTOPL";

        /// <summary>
        /// SYPLSA.
        /// </summary>
        public const string SYPLSA = "SYPLSA";

        /// <summary>
        /// SYPLSU.
        /// </summary>
        public const string SYPLSU = "SYPLSU";

        /// <summary>
        /// SYESSA.
        /// </summary>
        public const string SYESSA = "SYESSA";

        /// <summary>
        /// SYESSU.
        /// </summary>
        public const string SYESSU = "SYESSU";

        /// <summary>
        /// SYACSA.
        /// </summary>
        public const string SYACSA = "SYACSA";

        /// <summary>
        /// SYACSU.
        /// </summary>
        public const string SYACSU = "SYACSU";

        /// <summary>
        /// SYOACM.
        /// </summary>
        public const string SYOACM = "SYOACM";

        /// <summary>
        /// SYRACM.
        /// </summary>
        public const string SYRACM = "SYRACM";

        /// <summary>
        /// SYLOTC.
        /// </summary>
        public const string SYLOTC = "SYLOTC";

        /// <summary>
        /// SYHPLF.
        /// </summary>
        public const string SYHPLF = "SYHPLF";

        /// <summary>
        /// SYXEVT.
        /// </summary>
        public const string SYXEVT = "SYXEVT";

        /// <summary>
        /// SYMCULT.
        /// </summary>
        public const string SYMCULT = "SYMCULT";

        /// <summary>
        /// SYWSCHF.
        /// </summary>
        public const string SYWSCHF = "SYWSCHF";

        /// <summary>
        /// SYDFMDP.
        /// </summary>
        public const string SYDFMDP = "SYDFMDP";

        /// <summary>
        /// SYPMPN.
        /// </summary>
        public const string SYPMPN = "SYPMPN";

        /// <summary>
        /// SYPNS.
        /// </summary>
        public const string SYPNS = "SYPNS";

        /// <summary>
        /// SYBODJ.
        /// </summary>
        public const string SYBODJ = "SYBODJ";

        /// <summary>
        /// SYDLEJ.
        /// </summary>
        public const string SYDLEJ = "SYDLEJ";

        /// <summary>
        /// SYORIG.
        /// </summary>
        public const string SYORIG = "SYORIG";

        /// <summary>
        /// SYODOC.
        /// </summary>
        public const string SYODOC = "SYODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F4801Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYRCD", "SYRCD", JdeDataType.String, 6),
        new JdeField("SYDGL", "SYDGL", JdeDataType.Numeric),
        new JdeField("SYLOTS", "SYLOTS", JdeDataType.String, 2),
        new JdeField("SYEXPR", "SYEXPR", JdeDataType.Numeric),
        new JdeField("SYLOT1", "SYLOT1", JdeDataType.String, 60),
        new JdeField("SYLOT2", "SYLOT2", JdeDataType.String, 60),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYSFXO", "SYSFXO", JdeDataType.String, 6),
        new JdeField("SYRCTO", "SYRCTO", JdeDataType.String, 4),
        new JdeField("SYRORN", "SYRORN", JdeDataType.String, 16),
        new JdeField("SYLNID", "SYLNID", JdeDataType.Numeric),
        new JdeField("SYPTWO", "SYPTWO", JdeDataType.Numeric),
        new JdeField("SYPARS", "SYPARS", JdeDataType.String, 16),
        new JdeField("SYTYPS", "SYTYPS", JdeDataType.String, 2),
        new JdeField("SYPRTS", "SYPRTS", JdeDataType.String, 2),
        new JdeField("SYDL01", "SYDL01", JdeDataType.String, 60),
        new JdeField("SYSTCM", "SYSTCM", JdeDataType.String, 60),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYMCU", "SYMCU", JdeDataType.String, 24),
        new JdeField("SYMMCU", "SYMMCU", JdeDataType.String, 24),
        new JdeField("SYLOCN", "SYLOCN", JdeDataType.String, 40),
        new JdeField("SYAISL", "SYAISL", JdeDataType.String, 16),
        new JdeField("SYBIN", "SYBIN", JdeDataType.String, 16),
        new JdeField("SYSRST", "SYSRST", JdeDataType.String, 4),
        new JdeField("SYDCG", "SYDCG", JdeDataType.Numeric),
        new JdeField("SYSUB", "SYSUB", JdeDataType.String, 16),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYANO", "SYANO", JdeDataType.Numeric),
        new JdeField("SYANSA", "SYANSA", JdeDataType.Numeric),
        new JdeField("SYANPA", "SYANPA", JdeDataType.Numeric),
        new JdeField("SYANP", "SYANP", JdeDataType.Numeric),
        new JdeField("SYDPL", "SYDPL", JdeDataType.Numeric),
        new JdeField("SYANT", "SYANT", JdeDataType.Numeric),
        new JdeField("SYNAN8", "SYNAN8", JdeDataType.Numeric),
        new JdeField("SYTRDJ", "SYTRDJ", JdeDataType.Numeric),
        new JdeField("SYSTRT", "SYSTRT", JdeDataType.Numeric),
        new JdeField("SYDRQJ", "SYDRQJ", JdeDataType.Numeric),
        new JdeField("SYSTRX", "SYSTRX", JdeDataType.Numeric),
        new JdeField("SYDAP", "SYDAP", JdeDataType.Numeric),
        new JdeField("SYDAT", "SYDAT", JdeDataType.Numeric),
        new JdeField("SYPPDT", "SYPPDT", JdeDataType.Numeric),
        new JdeField("SYWR01", "SYWR01", JdeDataType.String, 8),
        new JdeField("SYWR02", "SYWR02", JdeDataType.String, 6),
        new JdeField("SYWR03", "SYWR03", JdeDataType.String, 6),
        new JdeField("SYWR04", "SYWR04", JdeDataType.String, 6),
        new JdeField("SYWR05", "SYWR05", JdeDataType.String, 6),
        new JdeField("SYWR06", "SYWR06", JdeDataType.String, 6),
        new JdeField("SYWR07", "SYWR07", JdeDataType.String, 6),
        new JdeField("SYWR08", "SYWR08", JdeDataType.String, 6),
        new JdeField("SYWR09", "SYWR09", JdeDataType.String, 6),
        new JdeField("SYWR10", "SYWR10", JdeDataType.String, 6),
        new JdeField("SYVR01", "SYVR01", JdeDataType.String, 50),
        new JdeField("SYVR02", "SYVR02", JdeDataType.String, 50),
        new JdeField("SYAMTO", "SYAMTO", JdeDataType.Numeric),
        new JdeField("SYSETC", "SYSETC", JdeDataType.Numeric),
        new JdeField("SYBRT", "SYBRT", JdeDataType.Numeric),
        new JdeField("SYPAYT", "SYPAYT", JdeDataType.String, 10),
        new JdeField("SYAMTC", "SYAMTC", JdeDataType.Numeric),
        new JdeField("SYHRSO", "SYHRSO", JdeDataType.Numeric),
        new JdeField("SYHRSC", "SYHRSC", JdeDataType.Numeric),
        new JdeField("SYAMTA", "SYAMTA", JdeDataType.Numeric),
        new JdeField("SYHRSA", "SYHRSA", JdeDataType.Numeric),
        new JdeField("SYITM", "SYITM", JdeDataType.Numeric),
        new JdeField("SYAITM", "SYAITM", JdeDataType.String, 50),
        new JdeField("SYLITM", "SYLITM", JdeDataType.String, 50),
        new JdeField("SYNUMB", "SYNUMB", JdeDataType.Numeric),
        new JdeField("SYAPID", "SYAPID", JdeDataType.String, 24),
        new JdeField("SYUORG", "SYUORG", JdeDataType.Numeric),
        new JdeField("SYSOBK", "SYSOBK", JdeDataType.Numeric),
        new JdeField("SYSOCN", "SYSOCN", JdeDataType.Numeric),
        new JdeField("SYSOQS", "SYSOQS", JdeDataType.Numeric),
        new JdeField("SYQTYT", "SYQTYT", JdeDataType.Numeric),
        new JdeField("SYUOM", "SYUOM", JdeDataType.String, 4),
        new JdeField("SYSHNO", "SYSHNO", JdeDataType.String, 20),
        new JdeField("SYPBTM", "SYPBTM", JdeDataType.Numeric),
        new JdeField("SYTBM", "SYTBM", JdeDataType.String, 6),
        new JdeField("SYTRT", "SYTRT", JdeDataType.String, 6),
        new JdeField("SYSHTY", "SYSHTY", JdeDataType.String, 2),
        new JdeField("SYPEC", "SYPEC", JdeDataType.String, 2),
        new JdeField("SYPPFG", "SYPPFG", JdeDataType.String, 2),
        new JdeField("SYBM", "SYBM", JdeDataType.String, 2),
        new JdeField("SYRTG", "SYRTG", JdeDataType.String, 2),
        new JdeField("SYSPRT", "SYSPRT", JdeDataType.String, 2),
        new JdeField("SYUNCD", "SYUNCD", JdeDataType.String, 2),
        new JdeField("SYINDC", "SYINDC", JdeDataType.String, 2),
        new JdeField("SYRESC", "SYRESC", JdeDataType.Numeric),
        new JdeField("SYMOH", "SYMOH", JdeDataType.Numeric),
        new JdeField("SYTDT", "SYTDT", JdeDataType.Numeric),
        new JdeField("SYPOU", "SYPOU", JdeDataType.Numeric),
        new JdeField("SYPC", "SYPC", JdeDataType.Numeric),
        new JdeField("SYLTLV", "SYLTLV", JdeDataType.Numeric),
        new JdeField("SYLTCM", "SYLTCM", JdeDataType.Numeric),
        new JdeField("SYCTS1", "SYCTS1", JdeDataType.Numeric),
        new JdeField("SYLOTN", "SYLOTN", JdeDataType.String, 60),
        new JdeField("SYLOTP", "SYLOTP", JdeDataType.Numeric),
        new JdeField("SYLOTG", "SYLOTG", JdeDataType.String, 6),
        new JdeField("SYRAT1", "SYRAT1", JdeDataType.Numeric),
        new JdeField("SYRAT2", "SYRAT2", JdeDataType.Numeric),
        new JdeField("SYDCT", "SYDCT", JdeDataType.String, 4),
        new JdeField("SYSBLI", "SYSBLI", JdeDataType.String, 2),
        new JdeField("SYRKCO", "SYRKCO", JdeDataType.String, 10),
        new JdeField("SYBREV", "SYBREV", JdeDataType.String, 6),
        new JdeField("SYRREV", "SYRREV", JdeDataType.String, 6),
        new JdeField("SYDRWC", "SYDRWC", JdeDataType.String, 2),
        new JdeField("SYRTCH", "SYRTCH", JdeDataType.String, 2),
        new JdeField("SYPNRQ", "SYPNRQ", JdeDataType.String, 2),
        new JdeField("SYREAS", "SYREAS", JdeDataType.String, 4),
        new JdeField("SYPHSE", "SYPHSE", JdeDataType.String, 6),
        new JdeField("SYXDSP", "SYXDSP", JdeDataType.String, 6),
        new JdeField("SYBOMC", "SYBOMC", JdeDataType.String, 2),
        new JdeField("SYAAID", "SYAAID", JdeDataType.Numeric),
        new JdeField("SYNTST", "SYNTST", JdeDataType.String, 4),
        new JdeField("SYXRTO", "SYXRTO", JdeDataType.Numeric),
        new JdeField("SYESDN", "SYESDN", JdeDataType.Numeric),
        new JdeField("SYACDN", "SYACDN", JdeDataType.Numeric),
        new JdeField("SYSAID", "SYSAID", JdeDataType.Numeric),
        new JdeField("SYMPOS", "SYMPOS", JdeDataType.Numeric),
        new JdeField("SYAPRT", "SYAPRT", JdeDataType.String, 6),
        new JdeField("SYAMLC", "SYAMLC", JdeDataType.Numeric),
        new JdeField("SYAMMC", "SYAMMC", JdeDataType.Numeric),
        new JdeField("SYAMOT", "SYAMOT", JdeDataType.Numeric),
        new JdeField("SYLBAM", "SYLBAM", JdeDataType.Numeric),
        new JdeField("SYMTAM", "SYMTAM", JdeDataType.Numeric),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYLINE", "SYLINE", JdeDataType.String, 24),
        new JdeField("SYMWDH", "SYMWDH", JdeDataType.String, 2),
        new JdeField("SYSHFT", "SYSHFT", JdeDataType.String, 2),
        new JdeField("SYSCSP", "SYSCSP", JdeDataType.Numeric),
        new JdeField("SYSRCN", "SYSRCN", JdeDataType.String, 2),
        new JdeField("SYLEDG", "SYLEDG", JdeDataType.String, 4),
        new JdeField("SYCTS4", "SYCTS4", JdeDataType.Numeric),
        new JdeField("SYCTS8", "SYCTS8", JdeDataType.Numeric),
        new JdeField("SYCTS7", "SYCTS7", JdeDataType.Numeric),
        new JdeField("SYAID", "SYAID", JdeDataType.String, 16),
        new JdeField("SYALSE", "SYALSE", JdeDataType.String, 2),
        new JdeField("SYASID", "SYASID", JdeDataType.String, 50),
        new JdeField("SYATST", "SYATST", JdeDataType.Numeric),
        new JdeField("SYBSEQ", "SYBSEQ", JdeDataType.Numeric),
        new JdeField("SYCHPR", "SYCHPR", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRCE", "SYCRCE", JdeDataType.String, 6),
        new JdeField("SYCRCF", "SYCRCF", JdeDataType.String, 6),
        new JdeField("SYD5J", "SYD5J", JdeDataType.Numeric),
        new JdeField("SYD6J", "SYD6J", JdeDataType.Numeric),
        new JdeField("SYDRAW", "SYDRAW", JdeDataType.String, 40),
        new JdeField("SYDUAL", "SYDUAL", JdeDataType.String, 2),
        new JdeField("SYMPCE", "SYMPCE", JdeDataType.String, 2),
        new JdeField("SYMPRC", "SYMPRC", JdeDataType.String, 2),
        new JdeField("SYOBJ", "SYOBJ", JdeDataType.String, 12),
        new JdeField("SYOTAM", "SYOTAM", JdeDataType.Numeric),
        new JdeField("SYPRJM", "SYPRJM", JdeDataType.Numeric),
        new JdeField("SYPRRP", "SYPRRP", JdeDataType.String, 2),
        new JdeField("SYSHPP", "SYSHPP", JdeDataType.String, 2),
        new JdeField("SYSQOR", "SYSQOR", JdeDataType.Numeric),
        new JdeField("SYSRKF", "SYSRKF", JdeDataType.String, 2),
        new JdeField("SYSRNK", "SYSRNK", JdeDataType.Numeric),
        new JdeField("SYSSOQ", "SYSSOQ", JdeDataType.Numeric),
        new JdeField("SYTRAF", "SYTRAF", JdeDataType.String, 2),
        new JdeField("SYUOM2", "SYUOM2", JdeDataType.String, 4),
        new JdeField("SYWR11", "SYWR11", JdeDataType.String, 6),
        new JdeField("SYWR12", "SYWR12", JdeDataType.String, 6),
        new JdeField("SYWR13", "SYWR13", JdeDataType.String, 6),
        new JdeField("SYWR14", "SYWR14", JdeDataType.String, 6),
        new JdeField("SYWR15", "SYWR15", JdeDataType.String, 6),
        new JdeField("SYWR16", "SYWR16", JdeDataType.String, 6),
        new JdeField("SYWR17", "SYWR17", JdeDataType.String, 6),
        new JdeField("SYWR18", "SYWR18", JdeDataType.String, 6),
        new JdeField("SYWR19", "SYWR19", JdeDataType.String, 6),
        new JdeField("SYWR20", "SYWR20", JdeDataType.String, 6),
        new JdeField("SYVFWO", "SYVFWO", JdeDataType.String, 2),
        new JdeField("SYPMTN", "SYPMTN", JdeDataType.String, 24),
        new JdeField("SYSEST", "SYSEST", JdeDataType.Numeric),
        new JdeField("SYSEET", "SYSEET", JdeDataType.Numeric),
        new JdeField("SYDSAVNAME", "SYDSAVNAME", JdeDataType.String, 20),
        new JdeField("SYTIMEZONES", "SYTIMEZONES", JdeDataType.String, 4),
        new JdeField("SYSEQN", "SYSEQN", JdeDataType.Numeric),
        new JdeField("SYPLMR", "SYPLMR", JdeDataType.Numeric),
        new JdeField("SYPLLB", "SYPLLB", JdeDataType.Numeric),
        new JdeField("SYPLOS", "SYPLOS", JdeDataType.Numeric),
        new JdeField("SYBGTC", "SYBGTC", JdeDataType.Numeric),
        new JdeField("SYTOEM", "SYTOEM", JdeDataType.Numeric),
        new JdeField("SYTOPL", "SYTOPL", JdeDataType.Numeric),
        new JdeField("SYPLSA", "SYPLSA", JdeDataType.Numeric),
        new JdeField("SYPLSU", "SYPLSU", JdeDataType.Numeric),
        new JdeField("SYESSA", "SYESSA", JdeDataType.Numeric),
        new JdeField("SYESSU", "SYESSU", JdeDataType.Numeric),
        new JdeField("SYACSA", "SYACSA", JdeDataType.Numeric),
        new JdeField("SYACSU", "SYACSU", JdeDataType.Numeric),
        new JdeField("SYOACM", "SYOACM", JdeDataType.Numeric),
        new JdeField("SYRACM", "SYRACM", JdeDataType.Numeric),
        new JdeField("SYLOTC", "SYLOTC", JdeDataType.String, 6),
        new JdeField("SYHPLF", "SYHPLF", JdeDataType.String, 2),
        new JdeField("SYXEVT", "SYXEVT", JdeDataType.String, 2),
        new JdeField("SYMCULT", "SYMCULT", JdeDataType.String, 24),
        new JdeField("SYWSCHF", "SYWSCHF", JdeDataType.String, 2),
        new JdeField("SYDFMDP", "SYDFMDP", JdeDataType.String, 2),
        new JdeField("SYPMPN", "SYPMPN", JdeDataType.String, 60),
        new JdeField("SYPNS", "SYPNS", JdeDataType.Numeric),
        new JdeField("SYBODJ", "SYBODJ", JdeDataType.Numeric),
        new JdeField("SYDLEJ", "SYDLEJ", JdeDataType.Numeric),
        new JdeField("SYORIG", "SYORIG", JdeDataType.String, 6),
        new JdeField("SYODOC", "SYODOC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801Z1_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801Z1_2", "Index on SYDOCO, SYEDLN, SYTYTN, SYTNAC, SYDRIN, SYEDDL", new[] { "SYDOCO", "SYEDLN", "SYTYTN", "SYTNAC", "SYDRIN", "SYEDDL" })
    };
}
