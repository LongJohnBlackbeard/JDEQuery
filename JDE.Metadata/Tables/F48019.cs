using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48019 - .
/// </summary>
public class F48019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WXDOCO.
        /// </summary>
        public const string WXDOCO = "WXDOCO";

        /// <summary>
        /// WXDCTO.
        /// </summary>
        public const string WXDCTO = "WXDCTO";

        /// <summary>
        /// WXSFXO.
        /// </summary>
        public const string WXSFXO = "WXSFXO";

        /// <summary>
        /// WXRCTO.
        /// </summary>
        public const string WXRCTO = "WXRCTO";

        /// <summary>
        /// WXRORN.
        /// </summary>
        public const string WXRORN = "WXRORN";

        /// <summary>
        /// WXLNID.
        /// </summary>
        public const string WXLNID = "WXLNID";

        /// <summary>
        /// WXPTWO.
        /// </summary>
        public const string WXPTWO = "WXPTWO";

        /// <summary>
        /// WXPARS.
        /// </summary>
        public const string WXPARS = "WXPARS";

        /// <summary>
        /// WXTYPS.
        /// </summary>
        public const string WXTYPS = "WXTYPS";

        /// <summary>
        /// WXPRTS.
        /// </summary>
        public const string WXPRTS = "WXPRTS";

        /// <summary>
        /// WXDL01.
        /// </summary>
        public const string WXDL01 = "WXDL01";

        /// <summary>
        /// WXSTCM.
        /// </summary>
        public const string WXSTCM = "WXSTCM";

        /// <summary>
        /// WXCO.
        /// </summary>
        public const string WXCO = "WXCO";

        /// <summary>
        /// WXMCU.
        /// </summary>
        public const string WXMCU = "WXMCU";

        /// <summary>
        /// WXMMCU.
        /// </summary>
        public const string WXMMCU = "WXMMCU";

        /// <summary>
        /// WXLOCN.
        /// </summary>
        public const string WXLOCN = "WXLOCN";

        /// <summary>
        /// WXAISL.
        /// </summary>
        public const string WXAISL = "WXAISL";

        /// <summary>
        /// WXBIN.
        /// </summary>
        public const string WXBIN = "WXBIN";

        /// <summary>
        /// WXSRST.
        /// </summary>
        public const string WXSRST = "WXSRST";

        /// <summary>
        /// WXDCG.
        /// </summary>
        public const string WXDCG = "WXDCG";

        /// <summary>
        /// WXSUB.
        /// </summary>
        public const string WXSUB = "WXSUB";

        /// <summary>
        /// WXAN8.
        /// </summary>
        public const string WXAN8 = "WXAN8";

        /// <summary>
        /// WXANO.
        /// </summary>
        public const string WXANO = "WXANO";

        /// <summary>
        /// WXANSA.
        /// </summary>
        public const string WXANSA = "WXANSA";

        /// <summary>
        /// WXANPA.
        /// </summary>
        public const string WXANPA = "WXANPA";

        /// <summary>
        /// WXANP.
        /// </summary>
        public const string WXANP = "WXANP";

        /// <summary>
        /// WXDPL.
        /// </summary>
        public const string WXDPL = "WXDPL";

        /// <summary>
        /// WXANT.
        /// </summary>
        public const string WXANT = "WXANT";

        /// <summary>
        /// WXNAN8.
        /// </summary>
        public const string WXNAN8 = "WXNAN8";

        /// <summary>
        /// WXTRDJ.
        /// </summary>
        public const string WXTRDJ = "WXTRDJ";

        /// <summary>
        /// WXSTRT.
        /// </summary>
        public const string WXSTRT = "WXSTRT";

        /// <summary>
        /// WXDRQJ.
        /// </summary>
        public const string WXDRQJ = "WXDRQJ";

        /// <summary>
        /// WXSTRX.
        /// </summary>
        public const string WXSTRX = "WXSTRX";

        /// <summary>
        /// WXDAP.
        /// </summary>
        public const string WXDAP = "WXDAP";

        /// <summary>
        /// WXDAT.
        /// </summary>
        public const string WXDAT = "WXDAT";

        /// <summary>
        /// WXPPDT.
        /// </summary>
        public const string WXPPDT = "WXPPDT";

        /// <summary>
        /// WXWR01.
        /// </summary>
        public const string WXWR01 = "WXWR01";

        /// <summary>
        /// WXWR02.
        /// </summary>
        public const string WXWR02 = "WXWR02";

        /// <summary>
        /// WXWR03.
        /// </summary>
        public const string WXWR03 = "WXWR03";

        /// <summary>
        /// WXWR04.
        /// </summary>
        public const string WXWR04 = "WXWR04";

        /// <summary>
        /// WXWR05.
        /// </summary>
        public const string WXWR05 = "WXWR05";

        /// <summary>
        /// WXWR06.
        /// </summary>
        public const string WXWR06 = "WXWR06";

        /// <summary>
        /// WXWR07.
        /// </summary>
        public const string WXWR07 = "WXWR07";

        /// <summary>
        /// WXWR08.
        /// </summary>
        public const string WXWR08 = "WXWR08";

        /// <summary>
        /// WXWR09.
        /// </summary>
        public const string WXWR09 = "WXWR09";

        /// <summary>
        /// WXWR10.
        /// </summary>
        public const string WXWR10 = "WXWR10";

        /// <summary>
        /// WXVR01.
        /// </summary>
        public const string WXVR01 = "WXVR01";

        /// <summary>
        /// WXVR02.
        /// </summary>
        public const string WXVR02 = "WXVR02";

        /// <summary>
        /// WXAMTO.
        /// </summary>
        public const string WXAMTO = "WXAMTO";

        /// <summary>
        /// WXSETC.
        /// </summary>
        public const string WXSETC = "WXSETC";

        /// <summary>
        /// WXBRT.
        /// </summary>
        public const string WXBRT = "WXBRT";

        /// <summary>
        /// WXPAYT.
        /// </summary>
        public const string WXPAYT = "WXPAYT";

        /// <summary>
        /// WXAMTC.
        /// </summary>
        public const string WXAMTC = "WXAMTC";

        /// <summary>
        /// WXHRSO.
        /// </summary>
        public const string WXHRSO = "WXHRSO";

        /// <summary>
        /// WXHRSC.
        /// </summary>
        public const string WXHRSC = "WXHRSC";

        /// <summary>
        /// WXAMTA.
        /// </summary>
        public const string WXAMTA = "WXAMTA";

        /// <summary>
        /// WXHRSA.
        /// </summary>
        public const string WXHRSA = "WXHRSA";

        /// <summary>
        /// WXITM.
        /// </summary>
        public const string WXITM = "WXITM";

        /// <summary>
        /// WXAITM.
        /// </summary>
        public const string WXAITM = "WXAITM";

        /// <summary>
        /// WXLITM.
        /// </summary>
        public const string WXLITM = "WXLITM";

        /// <summary>
        /// WXNUMB.
        /// </summary>
        public const string WXNUMB = "WXNUMB";

        /// <summary>
        /// WXAPID.
        /// </summary>
        public const string WXAPID = "WXAPID";

        /// <summary>
        /// WXUORG.
        /// </summary>
        public const string WXUORG = "WXUORG";

        /// <summary>
        /// WXSOBK.
        /// </summary>
        public const string WXSOBK = "WXSOBK";

        /// <summary>
        /// WXSOCN.
        /// </summary>
        public const string WXSOCN = "WXSOCN";

        /// <summary>
        /// WXSOQS.
        /// </summary>
        public const string WXSOQS = "WXSOQS";

        /// <summary>
        /// WXQTYT.
        /// </summary>
        public const string WXQTYT = "WXQTYT";

        /// <summary>
        /// WXUOM.
        /// </summary>
        public const string WXUOM = "WXUOM";

        /// <summary>
        /// WXSHNO.
        /// </summary>
        public const string WXSHNO = "WXSHNO";

        /// <summary>
        /// WXPBTM.
        /// </summary>
        public const string WXPBTM = "WXPBTM";

        /// <summary>
        /// WXTBM.
        /// </summary>
        public const string WXTBM = "WXTBM";

        /// <summary>
        /// WXTRT.
        /// </summary>
        public const string WXTRT = "WXTRT";

        /// <summary>
        /// WXSHTY.
        /// </summary>
        public const string WXSHTY = "WXSHTY";

        /// <summary>
        /// WXPEC.
        /// </summary>
        public const string WXPEC = "WXPEC";

        /// <summary>
        /// WXPPFG.
        /// </summary>
        public const string WXPPFG = "WXPPFG";

        /// <summary>
        /// WXBM.
        /// </summary>
        public const string WXBM = "WXBM";

        /// <summary>
        /// WXRTG.
        /// </summary>
        public const string WXRTG = "WXRTG";

        /// <summary>
        /// WXSPRT.
        /// </summary>
        public const string WXSPRT = "WXSPRT";

        /// <summary>
        /// WXUNCD.
        /// </summary>
        public const string WXUNCD = "WXUNCD";

        /// <summary>
        /// WXINDC.
        /// </summary>
        public const string WXINDC = "WXINDC";

        /// <summary>
        /// WXRESC.
        /// </summary>
        public const string WXRESC = "WXRESC";

        /// <summary>
        /// WXMOH.
        /// </summary>
        public const string WXMOH = "WXMOH";

        /// <summary>
        /// WXTDT.
        /// </summary>
        public const string WXTDT = "WXTDT";

        /// <summary>
        /// WXPOU.
        /// </summary>
        public const string WXPOU = "WXPOU";

        /// <summary>
        /// WXPC.
        /// </summary>
        public const string WXPC = "WXPC";

        /// <summary>
        /// WXLTLV.
        /// </summary>
        public const string WXLTLV = "WXLTLV";

        /// <summary>
        /// WXLTCM.
        /// </summary>
        public const string WXLTCM = "WXLTCM";

        /// <summary>
        /// WXCTS1.
        /// </summary>
        public const string WXCTS1 = "WXCTS1";

        /// <summary>
        /// WXLOTN.
        /// </summary>
        public const string WXLOTN = "WXLOTN";

        /// <summary>
        /// WXLOTP.
        /// </summary>
        public const string WXLOTP = "WXLOTP";

        /// <summary>
        /// WXLOTG.
        /// </summary>
        public const string WXLOTG = "WXLOTG";

        /// <summary>
        /// WXRAT1.
        /// </summary>
        public const string WXRAT1 = "WXRAT1";

        /// <summary>
        /// WXRAT2.
        /// </summary>
        public const string WXRAT2 = "WXRAT2";

        /// <summary>
        /// WXDCT.
        /// </summary>
        public const string WXDCT = "WXDCT";

        /// <summary>
        /// WXSBLI.
        /// </summary>
        public const string WXSBLI = "WXSBLI";

        /// <summary>
        /// WXRKCO.
        /// </summary>
        public const string WXRKCO = "WXRKCO";

        /// <summary>
        /// WXBREV.
        /// </summary>
        public const string WXBREV = "WXBREV";

        /// <summary>
        /// WXRREV.
        /// </summary>
        public const string WXRREV = "WXRREV";

        /// <summary>
        /// WXDRWC.
        /// </summary>
        public const string WXDRWC = "WXDRWC";

        /// <summary>
        /// WXRTCH.
        /// </summary>
        public const string WXRTCH = "WXRTCH";

        /// <summary>
        /// WXPNRQ.
        /// </summary>
        public const string WXPNRQ = "WXPNRQ";

        /// <summary>
        /// WXREAS.
        /// </summary>
        public const string WXREAS = "WXREAS";

        /// <summary>
        /// WXPHSE.
        /// </summary>
        public const string WXPHSE = "WXPHSE";

        /// <summary>
        /// WXXDSP.
        /// </summary>
        public const string WXXDSP = "WXXDSP";

        /// <summary>
        /// WXBOMC.
        /// </summary>
        public const string WXBOMC = "WXBOMC";

        /// <summary>
        /// WXURCD.
        /// </summary>
        public const string WXURCD = "WXURCD";

        /// <summary>
        /// WXURDT.
        /// </summary>
        public const string WXURDT = "WXURDT";

        /// <summary>
        /// WXURAT.
        /// </summary>
        public const string WXURAT = "WXURAT";

        /// <summary>
        /// WXURAB.
        /// </summary>
        public const string WXURAB = "WXURAB";

        /// <summary>
        /// WXURRF.
        /// </summary>
        public const string WXURRF = "WXURRF";

        /// <summary>
        /// WXUSER.
        /// </summary>
        public const string WXUSER = "WXUSER";

        /// <summary>
        /// WXPID.
        /// </summary>
        public const string WXPID = "WXPID";

        /// <summary>
        /// WXJOBN.
        /// </summary>
        public const string WXJOBN = "WXJOBN";

        /// <summary>
        /// WXUPMJ.
        /// </summary>
        public const string WXUPMJ = "WXUPMJ";

        /// <summary>
        /// WXTDAY.
        /// </summary>
        public const string WXTDAY = "WXTDAY";

        /// <summary>
        /// WXAAID.
        /// </summary>
        public const string WXAAID = "WXAAID";

        /// <summary>
        /// WXNTST.
        /// </summary>
        public const string WXNTST = "WXNTST";

        /// <summary>
        /// WXXRTO.
        /// </summary>
        public const string WXXRTO = "WXXRTO";

        /// <summary>
        /// WXESDN.
        /// </summary>
        public const string WXESDN = "WXESDN";

        /// <summary>
        /// WXACDN.
        /// </summary>
        public const string WXACDN = "WXACDN";

        /// <summary>
        /// WXSAID.
        /// </summary>
        public const string WXSAID = "WXSAID";

        /// <summary>
        /// WXMPOS.
        /// </summary>
        public const string WXMPOS = "WXMPOS";

        /// <summary>
        /// WXAPRT.
        /// </summary>
        public const string WXAPRT = "WXAPRT";

        /// <summary>
        /// WXAMLC.
        /// </summary>
        public const string WXAMLC = "WXAMLC";

        /// <summary>
        /// WXAMMC.
        /// </summary>
        public const string WXAMMC = "WXAMMC";

        /// <summary>
        /// WXAMOT.
        /// </summary>
        public const string WXAMOT = "WXAMOT";

        /// <summary>
        /// WXLBAM.
        /// </summary>
        public const string WXLBAM = "WXLBAM";

        /// <summary>
        /// WXMTAM.
        /// </summary>
        public const string WXMTAM = "WXMTAM";

        /// <summary>
        /// WXLINE.
        /// </summary>
        public const string WXLINE = "WXLINE";

        /// <summary>
        /// WXMWDH.
        /// </summary>
        public const string WXMWDH = "WXMWDH";

        /// <summary>
        /// WXSCSP.
        /// </summary>
        public const string WXSCSP = "WXSCSP";

        /// <summary>
        /// WXSHFT.
        /// </summary>
        public const string WXSHFT = "WXSHFT";

        /// <summary>
        /// WXSRCN.
        /// </summary>
        public const string WXSRCN = "WXSRCN";

        /// <summary>
        /// WXLEDG.
        /// </summary>
        public const string WXLEDG = "WXLEDG";

        /// <summary>
        /// WXCTS4.
        /// </summary>
        public const string WXCTS4 = "WXCTS4";

        /// <summary>
        /// WXCTS7.
        /// </summary>
        public const string WXCTS7 = "WXCTS7";

        /// <summary>
        /// WXCTS8.
        /// </summary>
        public const string WXCTS8 = "WXCTS8";

        /// <summary>
        /// WXAID.
        /// </summary>
        public const string WXAID = "WXAID";

        /// <summary>
        /// WXALSE.
        /// </summary>
        public const string WXALSE = "WXALSE";

        /// <summary>
        /// WXASID.
        /// </summary>
        public const string WXASID = "WXASID";

        /// <summary>
        /// WXATST.
        /// </summary>
        public const string WXATST = "WXATST";

        /// <summary>
        /// WXBSEQ.
        /// </summary>
        public const string WXBSEQ = "WXBSEQ";

        /// <summary>
        /// WXCHPR.
        /// </summary>
        public const string WXCHPR = "WXCHPR";

        /// <summary>
        /// WXCRCD.
        /// </summary>
        public const string WXCRCD = "WXCRCD";

        /// <summary>
        /// WXCRCE.
        /// </summary>
        public const string WXCRCE = "WXCRCE";

        /// <summary>
        /// WXCRCF.
        /// </summary>
        public const string WXCRCF = "WXCRCF";

        /// <summary>
        /// WXD5J.
        /// </summary>
        public const string WXD5J = "WXD5J";

        /// <summary>
        /// WXD6J.
        /// </summary>
        public const string WXD6J = "WXD6J";

        /// <summary>
        /// WXDRAW.
        /// </summary>
        public const string WXDRAW = "WXDRAW";

        /// <summary>
        /// WXDUAL.
        /// </summary>
        public const string WXDUAL = "WXDUAL";

        /// <summary>
        /// WXMPCE.
        /// </summary>
        public const string WXMPCE = "WXMPCE";

        /// <summary>
        /// WXMPRC.
        /// </summary>
        public const string WXMPRC = "WXMPRC";

        /// <summary>
        /// WXOBJ.
        /// </summary>
        public const string WXOBJ = "WXOBJ";

        /// <summary>
        /// WXOTAM.
        /// </summary>
        public const string WXOTAM = "WXOTAM";

        /// <summary>
        /// WXPRJM.
        /// </summary>
        public const string WXPRJM = "WXPRJM";

        /// <summary>
        /// WXPRRP.
        /// </summary>
        public const string WXPRRP = "WXPRRP";

        /// <summary>
        /// WXSHPP.
        /// </summary>
        public const string WXSHPP = "WXSHPP";

        /// <summary>
        /// WXSQOR.
        /// </summary>
        public const string WXSQOR = "WXSQOR";

        /// <summary>
        /// WXSRKF.
        /// </summary>
        public const string WXSRKF = "WXSRKF";

        /// <summary>
        /// WXSRNK.
        /// </summary>
        public const string WXSRNK = "WXSRNK";

        /// <summary>
        /// WXSSOQ.
        /// </summary>
        public const string WXSSOQ = "WXSSOQ";

        /// <summary>
        /// WXTRAF.
        /// </summary>
        public const string WXTRAF = "WXTRAF";

        /// <summary>
        /// WXUOM2.
        /// </summary>
        public const string WXUOM2 = "WXUOM2";

        /// <summary>
        /// WXWR11.
        /// </summary>
        public const string WXWR11 = "WXWR11";

        /// <summary>
        /// WXWR12.
        /// </summary>
        public const string WXWR12 = "WXWR12";

        /// <summary>
        /// WXWR13.
        /// </summary>
        public const string WXWR13 = "WXWR13";

        /// <summary>
        /// WXWR14.
        /// </summary>
        public const string WXWR14 = "WXWR14";

        /// <summary>
        /// WXWR15.
        /// </summary>
        public const string WXWR15 = "WXWR15";

        /// <summary>
        /// WXWR16.
        /// </summary>
        public const string WXWR16 = "WXWR16";

        /// <summary>
        /// WXWR17.
        /// </summary>
        public const string WXWR17 = "WXWR17";

        /// <summary>
        /// WXWR18.
        /// </summary>
        public const string WXWR18 = "WXWR18";

        /// <summary>
        /// WXWR19.
        /// </summary>
        public const string WXWR19 = "WXWR19";

        /// <summary>
        /// WXWR20.
        /// </summary>
        public const string WXWR20 = "WXWR20";

        /// <summary>
        /// WXJBCD.
        /// </summary>
        public const string WXJBCD = "WXJBCD";

        /// <summary>
        /// WXVFWO.
        /// </summary>
        public const string WXVFWO = "WXVFWO";

        /// <summary>
        /// WXPMTN.
        /// </summary>
        public const string WXPMTN = "WXPMTN";

        /// <summary>
        /// WXISSUE.
        /// </summary>
        public const string WXISSUE = "WXISSUE";

        /// <summary>
        /// WXPRODM.
        /// </summary>
        public const string WXPRODM = "WXPRODM";

        /// <summary>
        /// WXWHO2.
        /// </summary>
        public const string WXWHO2 = "WXWHO2";

        /// <summary>
        /// WXAR1.
        /// </summary>
        public const string WXAR1 = "WXAR1";

        /// <summary>
        /// WXPHN1.
        /// </summary>
        public const string WXPHN1 = "WXPHN1";

        /// <summary>
        /// WXTMCO.
        /// </summary>
        public const string WXTMCO = "WXTMCO";

        /// <summary>
        /// WXMTHPR.
        /// </summary>
        public const string WXMTHPR = "WXMTHPR";

        /// <summary>
        /// WXENTCK.
        /// </summary>
        public const string WXENTCK = "WXENTCK";

        /// <summary>
        /// WXRYIN.
        /// </summary>
        public const string WXRYIN = "WXRYIN";

        /// <summary>
        /// WXRSTM.
        /// </summary>
        public const string WXRSTM = "WXRSTM";

        /// <summary>
        /// WXCTR.
        /// </summary>
        public const string WXCTR = "WXCTR";

        /// <summary>
        /// WXREGION.
        /// </summary>
        public const string WXREGION = "WXREGION";

        /// <summary>
        /// WXTXA1.
        /// </summary>
        public const string WXTXA1 = "WXTXA1";

        /// <summary>
        /// WXEXR1.
        /// </summary>
        public const string WXEXR1 = "WXEXR1";

        /// <summary>
        /// WXLNGP.
        /// </summary>
        public const string WXLNGP = "WXLNGP";

        /// <summary>
        /// WXGLCCV.
        /// </summary>
        public const string WXGLCCV = "WXGLCCV";

        /// <summary>
        /// WXGLCNC.
        /// </summary>
        public const string WXGLCNC = "WXGLCNC";

        /// <summary>
        /// WXCOVGR.
        /// </summary>
        public const string WXCOVGR = "WXCOVGR";

        /// <summary>
        /// WXASN4.
        /// </summary>
        public const string WXASN4 = "WXASN4";

        /// <summary>
        /// WXASN2.
        /// </summary>
        public const string WXASN2 = "WXASN2";

        /// <summary>
        /// WXSEST.
        /// </summary>
        public const string WXSEST = "WXSEST";

        /// <summary>
        /// WXSEET.
        /// </summary>
        public const string WXSEET = "WXSEET";

        /// <summary>
        /// WXDSAVNAME.
        /// </summary>
        public const string WXDSAVNAME = "WXDSAVNAME";

        /// <summary>
        /// WXTIMEZONES.
        /// </summary>
        public const string WXTIMEZONES = "WXTIMEZONES";

        /// <summary>
        /// WXPRODF.
        /// </summary>
        public const string WXPRODF = "WXPRODF";

        /// <summary>
        /// WXCSLPRT.
        /// </summary>
        public const string WXCSLPRT = "WXCSLPRT";

        /// <summary>
        /// WXMCUCSL.
        /// </summary>
        public const string WXMCUCSL = "WXMCUCSL";

        /// <summary>
        /// WXRLOT.
        /// </summary>
        public const string WXRLOT = "WXRLOT";

        /// <summary>
        /// WXFAILCD.
        /// </summary>
        public const string WXFAILCD = "WXFAILCD";

        /// <summary>
        /// WXFAILDT.
        /// </summary>
        public const string WXFAILDT = "WXFAILDT";

        /// <summary>
        /// WXFAILTM.
        /// </summary>
        public const string WXFAILTM = "WXFAILTM";

        /// <summary>
        /// WXREPDT.
        /// </summary>
        public const string WXREPDT = "WXREPDT";

        /// <summary>
        /// WXREPTM.
        /// </summary>
        public const string WXREPTM = "WXREPTM";

        /// <summary>
        /// WXVEND.
        /// </summary>
        public const string WXVEND = "WXVEND";

        /// <summary>
        /// WXAN8AS.
        /// </summary>
        public const string WXAN8AS = "WXAN8AS";

        /// <summary>
        /// WXAN8SRM.
        /// </summary>
        public const string WXAN8SRM = "WXAN8SRM";

        /// <summary>
        /// WXSRYN.
        /// </summary>
        public const string WXSRYN = "WXSRYN";

        /// <summary>
        /// WXENTCKS.
        /// </summary>
        public const string WXENTCKS = "WXENTCKS";

        /// <summary>
        /// WXCURBALM1.
        /// </summary>
        public const string WXCURBALM1 = "WXCURBALM1";

        /// <summary>
        /// WXCURBALM2.
        /// </summary>
        public const string WXCURBALM2 = "WXCURBALM2";

        /// <summary>
        /// WXCURBALM3.
        /// </summary>
        public const string WXCURBALM3 = "WXCURBALM3";

        /// <summary>
        /// WXCRDC.
        /// </summary>
        public const string WXCRDC = "WXCRDC";

        /// <summary>
        /// WXCRRM.
        /// </summary>
        public const string WXCRRM = "WXCRRM";

        /// <summary>
        /// WXCRR.
        /// </summary>
        public const string WXCRR = "WXCRR";

        /// <summary>
        /// WXVMRS31.
        /// </summary>
        public const string WXVMRS31 = "WXVMRS31";

        /// <summary>
        /// WXVMRS32.
        /// </summary>
        public const string WXVMRS32 = "WXVMRS32";

        /// <summary>
        /// WXSEQN.
        /// </summary>
        public const string WXSEQN = "WXSEQN";

        /// <summary>
        /// WXPLMR.
        /// </summary>
        public const string WXPLMR = "WXPLMR";

        /// <summary>
        /// WXPLLB.
        /// </summary>
        public const string WXPLLB = "WXPLLB";

        /// <summary>
        /// WXPLOS.
        /// </summary>
        public const string WXPLOS = "WXPLOS";

        /// <summary>
        /// WXBGTC.
        /// </summary>
        public const string WXBGTC = "WXBGTC";

        /// <summary>
        /// WXTOEM.
        /// </summary>
        public const string WXTOEM = "WXTOEM";

        /// <summary>
        /// WXTOPL.
        /// </summary>
        public const string WXTOPL = "WXTOPL";

        /// <summary>
        /// WXPLSA.
        /// </summary>
        public const string WXPLSA = "WXPLSA";

        /// <summary>
        /// WXPLSU.
        /// </summary>
        public const string WXPLSU = "WXPLSU";

        /// <summary>
        /// WXESSA.
        /// </summary>
        public const string WXESSA = "WXESSA";

        /// <summary>
        /// WXESSU.
        /// </summary>
        public const string WXESSU = "WXESSU";

        /// <summary>
        /// WXACSA.
        /// </summary>
        public const string WXACSA = "WXACSA";

        /// <summary>
        /// WXACSU.
        /// </summary>
        public const string WXACSU = "WXACSU";

        /// <summary>
        /// WXOACM.
        /// </summary>
        public const string WXOACM = "WXOACM";

        /// <summary>
        /// WXRACM.
        /// </summary>
        public const string WXRACM = "WXRACM";

        /// <summary>
        /// WXHPLF.
        /// </summary>
        public const string WXHPLF = "WXHPLF";

        /// <summary>
        /// WXVMRS33.
        /// </summary>
        public const string WXVMRS33 = "WXVMRS33";

        /// <summary>
        /// WXSCALL.
        /// </summary>
        public const string WXSCALL = "WXSCALL";

        /// <summary>
        /// WXISNO.
        /// </summary>
        public const string WXISNO = "WXISNO";

        /// <summary>
        /// WXRMTHD.
        /// </summary>
        public const string WXRMTHD = "WXRMTHD";

        /// <summary>
        /// WXDOC.
        /// </summary>
        public const string WXDOC = "WXDOC";

        /// <summary>
        /// WXKCO.
        /// </summary>
        public const string WXKCO = "WXKCO";

        /// <summary>
        /// WXCOCH.
        /// </summary>
        public const string WXCOCH = "WXCOCH";

        /// <summary>
        /// WXCRTU.
        /// </summary>
        public const string WXCRTU = "WXCRTU";

        /// <summary>
        /// WXXEVT.
        /// </summary>
        public const string WXXEVT = "WXXEVT";

        /// <summary>
        /// WXMCULT.
        /// </summary>
        public const string WXMCULT = "WXMCULT";

        /// <summary>
        /// WXWSCHF.
        /// </summary>
        public const string WXWSCHF = "WXWSCHF";

        /// <summary>
        /// WXDFMDP.
        /// </summary>
        public const string WXDFMDP = "WXDFMDP";

        /// <summary>
        /// WXPMPN.
        /// </summary>
        public const string WXPMPN = "WXPMPN";

        /// <summary>
        /// WXPNS.
        /// </summary>
        public const string WXPNS = "WXPNS";

        /// <summary>
        /// WXACTN.
        /// </summary>
        public const string WXACTN = "WXACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F48019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WXDOCO", "WXDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WXDCTO", "WXDCTO", JdeDataType.String, 4),
        new JdeField("WXSFXO", "WXSFXO", JdeDataType.String, 6),
        new JdeField("WXRCTO", "WXRCTO", JdeDataType.String, 4),
        new JdeField("WXRORN", "WXRORN", JdeDataType.String, 16),
        new JdeField("WXLNID", "WXLNID", JdeDataType.Numeric),
        new JdeField("WXPTWO", "WXPTWO", JdeDataType.Numeric),
        new JdeField("WXPARS", "WXPARS", JdeDataType.String, 16),
        new JdeField("WXTYPS", "WXTYPS", JdeDataType.String, 2),
        new JdeField("WXPRTS", "WXPRTS", JdeDataType.String, 2),
        new JdeField("WXDL01", "WXDL01", JdeDataType.String, 60),
        new JdeField("WXSTCM", "WXSTCM", JdeDataType.String, 60),
        new JdeField("WXCO", "WXCO", JdeDataType.String, 10),
        new JdeField("WXMCU", "WXMCU", JdeDataType.String, 24),
        new JdeField("WXMMCU", "WXMMCU", JdeDataType.String, 24),
        new JdeField("WXLOCN", "WXLOCN", JdeDataType.String, 40),
        new JdeField("WXAISL", "WXAISL", JdeDataType.String, 16),
        new JdeField("WXBIN", "WXBIN", JdeDataType.String, 16),
        new JdeField("WXSRST", "WXSRST", JdeDataType.String, 4),
        new JdeField("WXDCG", "WXDCG", JdeDataType.Numeric),
        new JdeField("WXSUB", "WXSUB", JdeDataType.String, 16),
        new JdeField("WXAN8", "WXAN8", JdeDataType.Numeric),
        new JdeField("WXANO", "WXANO", JdeDataType.Numeric),
        new JdeField("WXANSA", "WXANSA", JdeDataType.Numeric),
        new JdeField("WXANPA", "WXANPA", JdeDataType.Numeric),
        new JdeField("WXANP", "WXANP", JdeDataType.Numeric),
        new JdeField("WXDPL", "WXDPL", JdeDataType.Numeric),
        new JdeField("WXANT", "WXANT", JdeDataType.Numeric),
        new JdeField("WXNAN8", "WXNAN8", JdeDataType.Numeric),
        new JdeField("WXTRDJ", "WXTRDJ", JdeDataType.Numeric),
        new JdeField("WXSTRT", "WXSTRT", JdeDataType.Numeric),
        new JdeField("WXDRQJ", "WXDRQJ", JdeDataType.Numeric),
        new JdeField("WXSTRX", "WXSTRX", JdeDataType.Numeric),
        new JdeField("WXDAP", "WXDAP", JdeDataType.Numeric),
        new JdeField("WXDAT", "WXDAT", JdeDataType.Numeric),
        new JdeField("WXPPDT", "WXPPDT", JdeDataType.Numeric),
        new JdeField("WXWR01", "WXWR01", JdeDataType.String, 8),
        new JdeField("WXWR02", "WXWR02", JdeDataType.String, 6),
        new JdeField("WXWR03", "WXWR03", JdeDataType.String, 6),
        new JdeField("WXWR04", "WXWR04", JdeDataType.String, 6),
        new JdeField("WXWR05", "WXWR05", JdeDataType.String, 6),
        new JdeField("WXWR06", "WXWR06", JdeDataType.String, 6),
        new JdeField("WXWR07", "WXWR07", JdeDataType.String, 6),
        new JdeField("WXWR08", "WXWR08", JdeDataType.String, 6),
        new JdeField("WXWR09", "WXWR09", JdeDataType.String, 6),
        new JdeField("WXWR10", "WXWR10", JdeDataType.String, 6),
        new JdeField("WXVR01", "WXVR01", JdeDataType.String, 50),
        new JdeField("WXVR02", "WXVR02", JdeDataType.String, 50),
        new JdeField("WXAMTO", "WXAMTO", JdeDataType.Numeric),
        new JdeField("WXSETC", "WXSETC", JdeDataType.Numeric),
        new JdeField("WXBRT", "WXBRT", JdeDataType.Numeric),
        new JdeField("WXPAYT", "WXPAYT", JdeDataType.String, 10),
        new JdeField("WXAMTC", "WXAMTC", JdeDataType.Numeric),
        new JdeField("WXHRSO", "WXHRSO", JdeDataType.Numeric),
        new JdeField("WXHRSC", "WXHRSC", JdeDataType.Numeric),
        new JdeField("WXAMTA", "WXAMTA", JdeDataType.Numeric),
        new JdeField("WXHRSA", "WXHRSA", JdeDataType.Numeric),
        new JdeField("WXITM", "WXITM", JdeDataType.Numeric),
        new JdeField("WXAITM", "WXAITM", JdeDataType.String, 50),
        new JdeField("WXLITM", "WXLITM", JdeDataType.String, 50),
        new JdeField("WXNUMB", "WXNUMB", JdeDataType.Numeric),
        new JdeField("WXAPID", "WXAPID", JdeDataType.String, 24),
        new JdeField("WXUORG", "WXUORG", JdeDataType.Numeric),
        new JdeField("WXSOBK", "WXSOBK", JdeDataType.Numeric),
        new JdeField("WXSOCN", "WXSOCN", JdeDataType.Numeric),
        new JdeField("WXSOQS", "WXSOQS", JdeDataType.Numeric),
        new JdeField("WXQTYT", "WXQTYT", JdeDataType.Numeric),
        new JdeField("WXUOM", "WXUOM", JdeDataType.String, 4),
        new JdeField("WXSHNO", "WXSHNO", JdeDataType.String, 20),
        new JdeField("WXPBTM", "WXPBTM", JdeDataType.Numeric),
        new JdeField("WXTBM", "WXTBM", JdeDataType.String, 6),
        new JdeField("WXTRT", "WXTRT", JdeDataType.String, 6),
        new JdeField("WXSHTY", "WXSHTY", JdeDataType.String, 2),
        new JdeField("WXPEC", "WXPEC", JdeDataType.String, 2),
        new JdeField("WXPPFG", "WXPPFG", JdeDataType.String, 2),
        new JdeField("WXBM", "WXBM", JdeDataType.String, 2),
        new JdeField("WXRTG", "WXRTG", JdeDataType.String, 2),
        new JdeField("WXSPRT", "WXSPRT", JdeDataType.String, 2),
        new JdeField("WXUNCD", "WXUNCD", JdeDataType.String, 2),
        new JdeField("WXINDC", "WXINDC", JdeDataType.String, 2),
        new JdeField("WXRESC", "WXRESC", JdeDataType.Numeric),
        new JdeField("WXMOH", "WXMOH", JdeDataType.Numeric),
        new JdeField("WXTDT", "WXTDT", JdeDataType.Numeric),
        new JdeField("WXPOU", "WXPOU", JdeDataType.Numeric),
        new JdeField("WXPC", "WXPC", JdeDataType.Numeric),
        new JdeField("WXLTLV", "WXLTLV", JdeDataType.Numeric),
        new JdeField("WXLTCM", "WXLTCM", JdeDataType.Numeric),
        new JdeField("WXCTS1", "WXCTS1", JdeDataType.Numeric),
        new JdeField("WXLOTN", "WXLOTN", JdeDataType.String, 60),
        new JdeField("WXLOTP", "WXLOTP", JdeDataType.Numeric),
        new JdeField("WXLOTG", "WXLOTG", JdeDataType.String, 6),
        new JdeField("WXRAT1", "WXRAT1", JdeDataType.Numeric),
        new JdeField("WXRAT2", "WXRAT2", JdeDataType.Numeric),
        new JdeField("WXDCT", "WXDCT", JdeDataType.String, 4),
        new JdeField("WXSBLI", "WXSBLI", JdeDataType.String, 2),
        new JdeField("WXRKCO", "WXRKCO", JdeDataType.String, 10),
        new JdeField("WXBREV", "WXBREV", JdeDataType.String, 6),
        new JdeField("WXRREV", "WXRREV", JdeDataType.String, 6),
        new JdeField("WXDRWC", "WXDRWC", JdeDataType.String, 2),
        new JdeField("WXRTCH", "WXRTCH", JdeDataType.String, 2),
        new JdeField("WXPNRQ", "WXPNRQ", JdeDataType.String, 2),
        new JdeField("WXREAS", "WXREAS", JdeDataType.String, 4),
        new JdeField("WXPHSE", "WXPHSE", JdeDataType.String, 6),
        new JdeField("WXXDSP", "WXXDSP", JdeDataType.String, 6),
        new JdeField("WXBOMC", "WXBOMC", JdeDataType.String, 2),
        new JdeField("WXURCD", "WXURCD", JdeDataType.String, 4),
        new JdeField("WXURDT", "WXURDT", JdeDataType.Numeric),
        new JdeField("WXURAT", "WXURAT", JdeDataType.Numeric),
        new JdeField("WXURAB", "WXURAB", JdeDataType.Numeric),
        new JdeField("WXURRF", "WXURRF", JdeDataType.String, 30),
        new JdeField("WXUSER", "WXUSER", JdeDataType.String, 20, true, true),
        new JdeField("WXPID", "WXPID", JdeDataType.String, 20),
        new JdeField("WXJOBN", "WXJOBN", JdeDataType.String, 20),
        new JdeField("WXUPMJ", "WXUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WXTDAY", "WXTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("WXAAID", "WXAAID", JdeDataType.Numeric),
        new JdeField("WXNTST", "WXNTST", JdeDataType.String, 4),
        new JdeField("WXXRTO", "WXXRTO", JdeDataType.Numeric),
        new JdeField("WXESDN", "WXESDN", JdeDataType.Numeric),
        new JdeField("WXACDN", "WXACDN", JdeDataType.Numeric),
        new JdeField("WXSAID", "WXSAID", JdeDataType.Numeric),
        new JdeField("WXMPOS", "WXMPOS", JdeDataType.Numeric),
        new JdeField("WXAPRT", "WXAPRT", JdeDataType.String, 6),
        new JdeField("WXAMLC", "WXAMLC", JdeDataType.Numeric),
        new JdeField("WXAMMC", "WXAMMC", JdeDataType.Numeric),
        new JdeField("WXAMOT", "WXAMOT", JdeDataType.Numeric),
        new JdeField("WXLBAM", "WXLBAM", JdeDataType.Numeric),
        new JdeField("WXMTAM", "WXMTAM", JdeDataType.Numeric),
        new JdeField("WXLINE", "WXLINE", JdeDataType.String, 24),
        new JdeField("WXMWDH", "WXMWDH", JdeDataType.String, 2),
        new JdeField("WXSCSP", "WXSCSP", JdeDataType.Numeric),
        new JdeField("WXSHFT", "WXSHFT", JdeDataType.String, 2),
        new JdeField("WXSRCN", "WXSRCN", JdeDataType.String, 2),
        new JdeField("WXLEDG", "WXLEDG", JdeDataType.String, 4),
        new JdeField("WXCTS4", "WXCTS4", JdeDataType.Numeric),
        new JdeField("WXCTS7", "WXCTS7", JdeDataType.Numeric),
        new JdeField("WXCTS8", "WXCTS8", JdeDataType.Numeric),
        new JdeField("WXAID", "WXAID", JdeDataType.String, 16),
        new JdeField("WXALSE", "WXALSE", JdeDataType.String, 2),
        new JdeField("WXASID", "WXASID", JdeDataType.String, 50),
        new JdeField("WXATST", "WXATST", JdeDataType.Numeric),
        new JdeField("WXBSEQ", "WXBSEQ", JdeDataType.Numeric),
        new JdeField("WXCHPR", "WXCHPR", JdeDataType.String, 2),
        new JdeField("WXCRCD", "WXCRCD", JdeDataType.String, 6),
        new JdeField("WXCRCE", "WXCRCE", JdeDataType.String, 6),
        new JdeField("WXCRCF", "WXCRCF", JdeDataType.String, 6),
        new JdeField("WXD5J", "WXD5J", JdeDataType.Numeric),
        new JdeField("WXD6J", "WXD6J", JdeDataType.Numeric),
        new JdeField("WXDRAW", "WXDRAW", JdeDataType.String, 40),
        new JdeField("WXDUAL", "WXDUAL", JdeDataType.String, 2),
        new JdeField("WXMPCE", "WXMPCE", JdeDataType.String, 2),
        new JdeField("WXMPRC", "WXMPRC", JdeDataType.String, 2),
        new JdeField("WXOBJ", "WXOBJ", JdeDataType.String, 12),
        new JdeField("WXOTAM", "WXOTAM", JdeDataType.Numeric),
        new JdeField("WXPRJM", "WXPRJM", JdeDataType.Numeric),
        new JdeField("WXPRRP", "WXPRRP", JdeDataType.String, 2),
        new JdeField("WXSHPP", "WXSHPP", JdeDataType.String, 2),
        new JdeField("WXSQOR", "WXSQOR", JdeDataType.Numeric),
        new JdeField("WXSRKF", "WXSRKF", JdeDataType.String, 2),
        new JdeField("WXSRNK", "WXSRNK", JdeDataType.Numeric),
        new JdeField("WXSSOQ", "WXSSOQ", JdeDataType.Numeric),
        new JdeField("WXTRAF", "WXTRAF", JdeDataType.String, 2),
        new JdeField("WXUOM2", "WXUOM2", JdeDataType.String, 4),
        new JdeField("WXWR11", "WXWR11", JdeDataType.String, 6),
        new JdeField("WXWR12", "WXWR12", JdeDataType.String, 6),
        new JdeField("WXWR13", "WXWR13", JdeDataType.String, 6),
        new JdeField("WXWR14", "WXWR14", JdeDataType.String, 6),
        new JdeField("WXWR15", "WXWR15", JdeDataType.String, 6),
        new JdeField("WXWR16", "WXWR16", JdeDataType.String, 6),
        new JdeField("WXWR17", "WXWR17", JdeDataType.String, 6),
        new JdeField("WXWR18", "WXWR18", JdeDataType.String, 6),
        new JdeField("WXWR19", "WXWR19", JdeDataType.String, 6),
        new JdeField("WXWR20", "WXWR20", JdeDataType.String, 6),
        new JdeField("WXJBCD", "WXJBCD", JdeDataType.String, 12),
        new JdeField("WXVFWO", "WXVFWO", JdeDataType.String, 2),
        new JdeField("WXPMTN", "WXPMTN", JdeDataType.String, 24),
        new JdeField("WXISSUE", "WXISSUE", JdeDataType.String, 160),
        new JdeField("WXPRODM", "WXPRODM", JdeDataType.String, 16),
        new JdeField("WXWHO2", "WXWHO2", JdeDataType.String, 80),
        new JdeField("WXAR1", "WXAR1", JdeDataType.String, 12),
        new JdeField("WXPHN1", "WXPHN1", JdeDataType.String, 40),
        new JdeField("WXTMCO", "WXTMCO", JdeDataType.Numeric),
        new JdeField("WXMTHPR", "WXMTHPR", JdeDataType.String, 2),
        new JdeField("WXENTCK", "WXENTCK", JdeDataType.String, 6),
        new JdeField("WXRYIN", "WXRYIN", JdeDataType.String, 2),
        new JdeField("WXRSTM", "WXRSTM", JdeDataType.Numeric),
        new JdeField("WXCTR", "WXCTR", JdeDataType.String, 6),
        new JdeField("WXREGION", "WXREGION", JdeDataType.String, 6),
        new JdeField("WXTXA1", "WXTXA1", JdeDataType.String, 20),
        new JdeField("WXEXR1", "WXEXR1", JdeDataType.String, 4),
        new JdeField("WXLNGP", "WXLNGP", JdeDataType.String, 4),
        new JdeField("WXGLCCV", "WXGLCCV", JdeDataType.String, 8),
        new JdeField("WXGLCNC", "WXGLCNC", JdeDataType.String, 8),
        new JdeField("WXCOVGR", "WXCOVGR", JdeDataType.String, 16),
        new JdeField("WXASN4", "WXASN4", JdeDataType.String, 16),
        new JdeField("WXASN2", "WXASN2", JdeDataType.String, 16),
        new JdeField("WXSEST", "WXSEST", JdeDataType.Numeric),
        new JdeField("WXSEET", "WXSEET", JdeDataType.Numeric),
        new JdeField("WXDSAVNAME", "WXDSAVNAME", JdeDataType.String, 20),
        new JdeField("WXTIMEZONES", "WXTIMEZONES", JdeDataType.String, 4),
        new JdeField("WXPRODF", "WXPRODF", JdeDataType.String, 16),
        new JdeField("WXCSLPRT", "WXCSLPRT", JdeDataType.Numeric),
        new JdeField("WXMCUCSL", "WXMCUCSL", JdeDataType.String, 24),
        new JdeField("WXRLOT", "WXRLOT", JdeDataType.String, 60),
        new JdeField("WXFAILCD", "WXFAILCD", JdeDataType.String, 16),
        new JdeField("WXFAILDT", "WXFAILDT", JdeDataType.Numeric),
        new JdeField("WXFAILTM", "WXFAILTM", JdeDataType.Numeric),
        new JdeField("WXREPDT", "WXREPDT", JdeDataType.Numeric),
        new JdeField("WXREPTM", "WXREPTM", JdeDataType.Numeric),
        new JdeField("WXVEND", "WXVEND", JdeDataType.Numeric),
        new JdeField("WXAN8AS", "WXAN8AS", JdeDataType.Numeric),
        new JdeField("WXAN8SRM", "WXAN8SRM", JdeDataType.Numeric),
        new JdeField("WXSRYN", "WXSRYN", JdeDataType.String, 2),
        new JdeField("WXENTCKS", "WXENTCKS", JdeDataType.String, 6),
        new JdeField("WXCURBALM1", "WXCURBALM1", JdeDataType.Numeric),
        new JdeField("WXCURBALM2", "WXCURBALM2", JdeDataType.Numeric),
        new JdeField("WXCURBALM3", "WXCURBALM3", JdeDataType.Numeric),
        new JdeField("WXCRDC", "WXCRDC", JdeDataType.String, 6),
        new JdeField("WXCRRM", "WXCRRM", JdeDataType.String, 2),
        new JdeField("WXCRR", "WXCRR", JdeDataType.Numeric),
        new JdeField("WXVMRS31", "WXVMRS31", JdeDataType.String, 4),
        new JdeField("WXVMRS32", "WXVMRS32", JdeDataType.String, 16),
        new JdeField("WXSEQN", "WXSEQN", JdeDataType.Numeric),
        new JdeField("WXPLMR", "WXPLMR", JdeDataType.Numeric),
        new JdeField("WXPLLB", "WXPLLB", JdeDataType.Numeric),
        new JdeField("WXPLOS", "WXPLOS", JdeDataType.Numeric),
        new JdeField("WXBGTC", "WXBGTC", JdeDataType.Numeric),
        new JdeField("WXTOEM", "WXTOEM", JdeDataType.Numeric),
        new JdeField("WXTOPL", "WXTOPL", JdeDataType.Numeric),
        new JdeField("WXPLSA", "WXPLSA", JdeDataType.Numeric),
        new JdeField("WXPLSU", "WXPLSU", JdeDataType.Numeric),
        new JdeField("WXESSA", "WXESSA", JdeDataType.Numeric),
        new JdeField("WXESSU", "WXESSU", JdeDataType.Numeric),
        new JdeField("WXACSA", "WXACSA", JdeDataType.Numeric),
        new JdeField("WXACSU", "WXACSU", JdeDataType.Numeric),
        new JdeField("WXOACM", "WXOACM", JdeDataType.Numeric),
        new JdeField("WXRACM", "WXRACM", JdeDataType.Numeric),
        new JdeField("WXHPLF", "WXHPLF", JdeDataType.String, 2),
        new JdeField("WXVMRS33", "WXVMRS33", JdeDataType.String, 20),
        new JdeField("WXSCALL", "WXSCALL", JdeDataType.String, 2),
        new JdeField("WXISNO", "WXISNO", JdeDataType.Numeric),
        new JdeField("WXRMTHD", "WXRMTHD", JdeDataType.String, 2),
        new JdeField("WXDOC", "WXDOC", JdeDataType.Numeric),
        new JdeField("WXKCO", "WXKCO", JdeDataType.String, 10),
        new JdeField("WXCOCH", "WXCOCH", JdeDataType.String, 6),
        new JdeField("WXCRTU", "WXCRTU", JdeDataType.String, 20),
        new JdeField("WXXEVT", "WXXEVT", JdeDataType.String, 2),
        new JdeField("WXMCULT", "WXMCULT", JdeDataType.String, 24),
        new JdeField("WXWSCHF", "WXWSCHF", JdeDataType.String, 2),
        new JdeField("WXDFMDP", "WXDFMDP", JdeDataType.String, 2),
        new JdeField("WXPMPN", "WXPMPN", JdeDataType.String, 60),
        new JdeField("WXPNS", "WXPNS", JdeDataType.Numeric),
        new JdeField("WXACTN", "WXACTN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48019_0", "Primary Key on WXDOCO, WXUSER, WXUPMJ, WXTDAY", new[] { "WXDOCO", "WXUSER", "WXUPMJ", "WXTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
