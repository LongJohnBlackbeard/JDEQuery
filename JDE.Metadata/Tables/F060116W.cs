using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060116W - .
/// </summary>
public class F060116W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YAAN8.
        /// </summary>
        public const string YAAN8 = "YAAN8";

        /// <summary>
        /// YAALPH.
        /// </summary>
        public const string YAALPH = "YAALPH";

        /// <summary>
        /// YASSN.
        /// </summary>
        public const string YASSN = "YASSN";

        /// <summary>
        /// YAOEMP.
        /// </summary>
        public const string YAOEMP = "YAOEMP";

        /// <summary>
        /// YASEX.
        /// </summary>
        public const string YASEX = "YASEX";

        /// <summary>
        /// YAMSTX.
        /// </summary>
        public const string YAMSTX = "YAMSTX";

        /// <summary>
        /// YAMSTI.
        /// </summary>
        public const string YAMSTI = "YAMSTI";

        /// <summary>
        /// YAWSPS.
        /// </summary>
        public const string YAWSPS = "YAWSPS";

        /// <summary>
        /// YAEIC.
        /// </summary>
        public const string YAEIC = "YAEIC";

        /// <summary>
        /// YANDEP.
        /// </summary>
        public const string YANDEP = "YANDEP";

        /// <summary>
        /// YAEST.
        /// </summary>
        public const string YAEST = "YAEST";

        /// <summary>
        /// YAECNT.
        /// </summary>
        public const string YAECNT = "YAECNT";

        /// <summary>
        /// YATARR.
        /// </summary>
        public const string YATARR = "YATARR";

        /// <summary>
        /// YATARA.
        /// </summary>
        public const string YATARA = "YATARA";

        /// <summary>
        /// YASCDC.
        /// </summary>
        public const string YASCDC = "YASCDC";

        /// <summary>
        /// YAHMST.
        /// </summary>
        public const string YAHMST = "YAHMST";

        /// <summary>
        /// YAWKSE.
        /// </summary>
        public const string YAWKSE = "YAWKSE";

        /// <summary>
        /// YAHMLC.
        /// </summary>
        public const string YAHMLC = "YAHMLC";

        /// <summary>
        /// YALWK1.
        /// </summary>
        public const string YALWK1 = "YALWK1";

        /// <summary>
        /// YALWK2.
        /// </summary>
        public const string YALWK2 = "YALWK2";

        /// <summary>
        /// YAHMCO.
        /// </summary>
        public const string YAHMCO = "YAHMCO";

        /// <summary>
        /// YAMCU.
        /// </summary>
        public const string YAMCU = "YAMCU";

        /// <summary>
        /// YAHMCU.
        /// </summary>
        public const string YAHMCU = "YAHMCU";

        /// <summary>
        /// YASG.
        /// </summary>
        public const string YASG = "YASG";

        /// <summary>
        /// YAMAIL.
        /// </summary>
        public const string YAMAIL = "YAMAIL";

        /// <summary>
        /// YAPAST.
        /// </summary>
        public const string YAPAST = "YAPAST";

        /// <summary>
        /// YAPFRQ.
        /// </summary>
        public const string YAPFRQ = "YAPFRQ";

        /// <summary>
        /// YASALY.
        /// </summary>
        public const string YASALY = "YASALY";

        /// <summary>
        /// YAPYCB.
        /// </summary>
        public const string YAPYCB = "YAPYCB";

        /// <summary>
        /// YABCB.
        /// </summary>
        public const string YABCB = "YABCB";

        /// <summary>
        /// YAUN.
        /// </summary>
        public const string YAUN = "YAUN";

        /// <summary>
        /// YAJBCD.
        /// </summary>
        public const string YAJBCD = "YAJBCD";

        /// <summary>
        /// YAJBST.
        /// </summary>
        public const string YAJBST = "YAJBST";

        /// <summary>
        /// YAEEOJ.
        /// </summary>
        public const string YAEEOJ = "YAEEOJ";

        /// <summary>
        /// YAEEOM.
        /// </summary>
        public const string YAEEOM = "YAEEOM";

        /// <summary>
        /// YATRS.
        /// </summary>
        public const string YATRS = "YATRS";

        /// <summary>
        /// YAWCMP.
        /// </summary>
        public const string YAWCMP = "YAWCMP";

        /// <summary>
        /// YAFLSA.
        /// </summary>
        public const string YAFLSA = "YAFLSA";

        /// <summary>
        /// YAWS.
        /// </summary>
        public const string YAWS = "YAWS";

        /// <summary>
        /// YASHFT.
        /// </summary>
        public const string YASHFT = "YASHFT";

        /// <summary>
        /// YALMTH.
        /// </summary>
        public const string YALMTH = "YALMTH";

        /// <summary>
        /// YAPBRT.
        /// </summary>
        public const string YAPBRT = "YAPBRT";

        /// <summary>
        /// YALF.
        /// </summary>
        public const string YALF = "YALF";

        /// <summary>
        /// YASAL.
        /// </summary>
        public const string YASAL = "YASAL";

        /// <summary>
        /// YAPHRT.
        /// </summary>
        public const string YAPHRT = "YAPHRT";

        /// <summary>
        /// YAPPRT.
        /// </summary>
        public const string YAPPRT = "YAPPRT";

        /// <summary>
        /// YAPWRN.
        /// </summary>
        public const string YAPWRN = "YAPWRN";

        /// <summary>
        /// YAHRTN.
        /// </summary>
        public const string YAHRTN = "YAHRTN";

        /// <summary>
        /// YABRTN.
        /// </summary>
        public const string YABRTN = "YABRTN";

        /// <summary>
        /// YASALN.
        /// </summary>
        public const string YASALN = "YASALN";

        /// <summary>
        /// YASTDH.
        /// </summary>
        public const string YASTDH = "YASTDH";

        /// <summary>
        /// YASTDD.
        /// </summary>
        public const string YASTDD = "YASTDD";

        /// <summary>
        /// YASDYY.
        /// </summary>
        public const string YASDYY = "YASDYY";

        /// <summary>
        /// YAUSR.
        /// </summary>
        public const string YAUSR = "YAUSR";

        /// <summary>
        /// YAUFLG.
        /// </summary>
        public const string YAUFLG = "YAUFLG";

        /// <summary>
        /// YANS.
        /// </summary>
        public const string YANS = "YANS";

        /// <summary>
        /// YAIFN.
        /// </summary>
        public const string YAIFN = "YAIFN";

        /// <summary>
        /// YAIMN.
        /// </summary>
        public const string YAIMN = "YAIMN";

        /// <summary>
        /// YADOB.
        /// </summary>
        public const string YADOB = "YADOB";

        /// <summary>
        /// YADSI.
        /// </summary>
        public const string YADSI = "YADSI";

        /// <summary>
        /// YADT.
        /// </summary>
        public const string YADT = "YADT";

        /// <summary>
        /// YADST.
        /// </summary>
        public const string YADST = "YADST";

        /// <summary>
        /// YAPSDT.
        /// </summary>
        public const string YAPSDT = "YAPSDT";

        /// <summary>
        /// YAPTDT.
        /// </summary>
        public const string YAPTDT = "YAPTDT";

        /// <summary>
        /// YANRDT.
        /// </summary>
        public const string YANRDT = "YANRDT";

        /// <summary>
        /// YANBDT.
        /// </summary>
        public const string YANBDT = "YANBDT";

        /// <summary>
        /// YANPDT.
        /// </summary>
        public const string YANPDT = "YANPDT";

        /// <summary>
        /// YALCDT.
        /// </summary>
        public const string YALCDT = "YALCDT";

        /// <summary>
        /// YADR.
        /// </summary>
        public const string YADR = "YADR";

        /// <summary>
        /// YACTDT.
        /// </summary>
        public const string YACTDT = "YACTDT";

        /// <summary>
        /// YALADT.
        /// </summary>
        public const string YALADT = "YALADT";

        /// <summary>
        /// YABSDT.
        /// </summary>
        public const string YABSDT = "YABSDT";

        /// <summary>
        /// YACPDT.
        /// </summary>
        public const string YACPDT = "YACPDT";

        /// <summary>
        /// YAFICM.
        /// </summary>
        public const string YAFICM = "YAFICM";

        /// <summary>
        /// YAP001.
        /// </summary>
        public const string YAP001 = "YAP001";

        /// <summary>
        /// YAP002.
        /// </summary>
        public const string YAP002 = "YAP002";

        /// <summary>
        /// YAP003.
        /// </summary>
        public const string YAP003 = "YAP003";

        /// <summary>
        /// YAP004.
        /// </summary>
        public const string YAP004 = "YAP004";

        /// <summary>
        /// YAP005.
        /// </summary>
        public const string YAP005 = "YAP005";

        /// <summary>
        /// YAP006.
        /// </summary>
        public const string YAP006 = "YAP006";

        /// <summary>
        /// YAP007.
        /// </summary>
        public const string YAP007 = "YAP007";

        /// <summary>
        /// YAP008.
        /// </summary>
        public const string YAP008 = "YAP008";

        /// <summary>
        /// YAP009.
        /// </summary>
        public const string YAP009 = "YAP009";

        /// <summary>
        /// YAP010.
        /// </summary>
        public const string YAP010 = "YAP010";

        /// <summary>
        /// YAP011.
        /// </summary>
        public const string YAP011 = "YAP011";

        /// <summary>
        /// YAP012.
        /// </summary>
        public const string YAP012 = "YAP012";

        /// <summary>
        /// YAP013.
        /// </summary>
        public const string YAP013 = "YAP013";

        /// <summary>
        /// YAP014.
        /// </summary>
        public const string YAP014 = "YAP014";

        /// <summary>
        /// YAP015.
        /// </summary>
        public const string YAP015 = "YAP015";

        /// <summary>
        /// YAP016.
        /// </summary>
        public const string YAP016 = "YAP016";

        /// <summary>
        /// YAP017.
        /// </summary>
        public const string YAP017 = "YAP017";

        /// <summary>
        /// YAP018.
        /// </summary>
        public const string YAP018 = "YAP018";

        /// <summary>
        /// YAP019.
        /// </summary>
        public const string YAP019 = "YAP019";

        /// <summary>
        /// YAP020.
        /// </summary>
        public const string YAP020 = "YAP020";

        /// <summary>
        /// YAE001.
        /// </summary>
        public const string YAE001 = "YAE001";

        /// <summary>
        /// YAE002.
        /// </summary>
        public const string YAE002 = "YAE002";

        /// <summary>
        /// YAE003.
        /// </summary>
        public const string YAE003 = "YAE003";

        /// <summary>
        /// YAE004.
        /// </summary>
        public const string YAE004 = "YAE004";

        /// <summary>
        /// YAE005.
        /// </summary>
        public const string YAE005 = "YAE005";

        /// <summary>
        /// YAE006.
        /// </summary>
        public const string YAE006 = "YAE006";

        /// <summary>
        /// YAE007.
        /// </summary>
        public const string YAE007 = "YAE007";

        /// <summary>
        /// YAE008.
        /// </summary>
        public const string YAE008 = "YAE008";

        /// <summary>
        /// YAE009.
        /// </summary>
        public const string YAE009 = "YAE009";

        /// <summary>
        /// YAE010.
        /// </summary>
        public const string YAE010 = "YAE010";

        /// <summary>
        /// YAICC.
        /// </summary>
        public const string YAICC = "YAICC";

        /// <summary>
        /// YANMAX.
        /// </summary>
        public const string YANMAX = "YANMAX";

        /// <summary>
        /// YASOCC.
        /// </summary>
        public const string YASOCC = "YASOCC";

        /// <summary>
        /// YAIUSR.
        /// </summary>
        public const string YAIUSR = "YAIUSR";

        /// <summary>
        /// YAITRM.
        /// </summary>
        public const string YAITRM = "YAITRM";

        /// <summary>
        /// YAINBT.
        /// </summary>
        public const string YAINBT = "YAINBT";

        /// <summary>
        /// YAREGN.
        /// </summary>
        public const string YAREGN = "YAREGN";

        /// <summary>
        /// YAPSTP.
        /// </summary>
        public const string YAPSTP = "YAPSTP";

        /// <summary>
        /// YAIH.
        /// </summary>
        public const string YAIH = "YAIH";

        /// <summary>
        /// YACCPR.
        /// </summary>
        public const string YACCPR = "YACCPR";

        /// <summary>
        /// YAADPN.
        /// </summary>
        public const string YAADPN = "YAADPN";

        /// <summary>
        /// YATCNF.
        /// </summary>
        public const string YATCNF = "YATCNF";

        /// <summary>
        /// YARAF.
        /// </summary>
        public const string YARAF = "YARAF";

        /// <summary>
        /// YATIPE.
        /// </summary>
        public const string YATIPE = "YATIPE";

        /// <summary>
        /// YARCCD.
        /// </summary>
        public const string YARCCD = "YARCCD";

        /// <summary>
        /// YABDRT.
        /// </summary>
        public const string YABDRT = "YABDRT";

        /// <summary>
        /// YABORN.
        /// </summary>
        public const string YABORN = "YABORN";

        /// <summary>
        /// YANBDR.
        /// </summary>
        public const string YANBDR = "YANBDR";

        /// <summary>
        /// YAWET.
        /// </summary>
        public const string YAWET = "YAWET";

        /// <summary>
        /// YAAFLG.
        /// </summary>
        public const string YAAFLG = "YAAFLG";

        /// <summary>
        /// YARMST.
        /// </summary>
        public const string YARMST = "YARMST";

        /// <summary>
        /// YALMST.
        /// </summary>
        public const string YALMST = "YALMST";

        /// <summary>
        /// YASMKR.
        /// </summary>
        public const string YASMKR = "YASMKR";

        /// <summary>
        /// YACBAC.
        /// </summary>
        public const string YACBAC = "YACBAC";

        /// <summary>
        /// YACBAF.
        /// </summary>
        public const string YACBAF = "YACBAF";

        /// <summary>
        /// YAPCCD.
        /// </summary>
        public const string YAPCCD = "YAPCCD";

        /// <summary>
        /// YARCDT.
        /// </summary>
        public const string YARCDT = "YARCDT";

        /// <summary>
        /// YALSDT.
        /// </summary>
        public const string YALSDT = "YALSDT";

        /// <summary>
        /// YAPADT.
        /// </summary>
        public const string YAPADT = "YAPADT";

        /// <summary>
        /// YAPYMH.
        /// </summary>
        public const string YAPYMH = "YAPYMH";

        /// <summary>
        /// YAUYST.
        /// </summary>
        public const string YAUYST = "YAUYST";

        /// <summary>
        /// YADTSP.
        /// </summary>
        public const string YADTSP = "YADTSP";

        /// <summary>
        /// YAANN8.
        /// </summary>
        public const string YAANN8 = "YAANN8";

        /// <summary>
        /// YAPPNB.
        /// </summary>
        public const string YAPPNB = "YAPPNB";

        /// <summary>
        /// YAPYDT.
        /// </summary>
        public const string YAPYDT = "YAPYDT";

        /// <summary>
        /// YACBEN.
        /// </summary>
        public const string YACBEN = "YACBEN";

        /// <summary>
        /// YADOBM.
        /// </summary>
        public const string YADOBM = "YADOBM";

        /// <summary>
        /// YADSTM.
        /// </summary>
        public const string YADSTM = "YADSTM";

        /// <summary>
        /// YAPSAL.
        /// </summary>
        public const string YAPSAL = "YAPSAL";

        /// <summary>
        /// YAHIPN.
        /// </summary>
        public const string YAHIPN = "YAHIPN";

        /// <summary>
        /// YACM.
        /// </summary>
        public const string YACM = "YACM";

        /// <summary>
        /// YALSAL.
        /// </summary>
        public const string YALSAL = "YALSAL";

        /// <summary>
        /// YADIVC.
        /// </summary>
        public const string YADIVC = "YADIVC";

        /// <summary>
        /// YAVSHF.
        /// </summary>
        public const string YAVSHF = "YAVSHF";

        /// <summary>
        /// YAPYRV.
        /// </summary>
        public const string YAPYRV = "YAPYRV";

        /// <summary>
        /// YAANPA.
        /// </summary>
        public const string YAANPA = "YAANPA";

        /// <summary>
        /// YAPGRD.
        /// </summary>
        public const string YAPGRD = "YAPGRD";

        /// <summary>
        /// YAPGRS.
        /// </summary>
        public const string YAPGRS = "YAPGRS";

        /// <summary>
        /// YASLOC.
        /// </summary>
        public const string YASLOC = "YASLOC";

        /// <summary>
        /// YANRVW.
        /// </summary>
        public const string YANRVW = "YANRVW";

        /// <summary>
        /// YATINC.
        /// </summary>
        public const string YATINC = "YATINC";

        /// <summary>
        /// YAHM01.
        /// </summary>
        public const string YAHM01 = "YAHM01";

        /// <summary>
        /// YAHM02.
        /// </summary>
        public const string YAHM02 = "YAHM02";

        /// <summary>
        /// YAHM03.
        /// </summary>
        public const string YAHM03 = "YAHM03";

        /// <summary>
        /// YAHM04.
        /// </summary>
        public const string YAHM04 = "YAHM04";

        /// <summary>
        /// YAPOS.
        /// </summary>
        public const string YAPOS = "YAPOS";

        /// <summary>
        /// YAED01.
        /// </summary>
        public const string YAED01 = "YAED01";

        /// <summary>
        /// YAED02.
        /// </summary>
        public const string YAED02 = "YAED02";

        /// <summary>
        /// YAED03.
        /// </summary>
        public const string YAED03 = "YAED03";

        /// <summary>
        /// YAED04.
        /// </summary>
        public const string YAED04 = "YAED04";

        /// <summary>
        /// YAED05.
        /// </summary>
        public const string YAED05 = "YAED05";

        /// <summary>
        /// YAED06.
        /// </summary>
        public const string YAED06 = "YAED06";

        /// <summary>
        /// YAED07.
        /// </summary>
        public const string YAED07 = "YAED07";

        /// <summary>
        /// YAED08.
        /// </summary>
        public const string YAED08 = "YAED08";

        /// <summary>
        /// YAED09.
        /// </summary>
        public const string YAED09 = "YAED09";

        /// <summary>
        /// YAED10.
        /// </summary>
        public const string YAED10 = "YAED10";

        /// <summary>
        /// YAED11.
        /// </summary>
        public const string YAED11 = "YAED11";

        /// <summary>
        /// YAED12.
        /// </summary>
        public const string YAED12 = "YAED12";

        /// <summary>
        /// YAED13.
        /// </summary>
        public const string YAED13 = "YAED13";

        /// <summary>
        /// YAED14.
        /// </summary>
        public const string YAED14 = "YAED14";

        /// <summary>
        /// YAED15.
        /// </summary>
        public const string YAED15 = "YAED15";

        /// <summary>
        /// YAED16.
        /// </summary>
        public const string YAED16 = "YAED16";

        /// <summary>
        /// YAED17.
        /// </summary>
        public const string YAED17 = "YAED17";

        /// <summary>
        /// YAED18.
        /// </summary>
        public const string YAED18 = "YAED18";

        /// <summary>
        /// YAED19.
        /// </summary>
        public const string YAED19 = "YAED19";

        /// <summary>
        /// YAED20.
        /// </summary>
        public const string YAED20 = "YAED20";

        /// <summary>
        /// YADEPT.
        /// </summary>
        public const string YADEPT = "YADEPT";

        /// <summary>
        /// YAFAGE.
        /// </summary>
        public const string YAFAGE = "YAFAGE";

        /// <summary>
        /// YAFSAL.
        /// </summary>
        public const string YAFSAL = "YAFSAL";

        /// <summary>
        /// YAADSD.
        /// </summary>
        public const string YAADSD = "YAADSD";

        /// <summary>
        /// YACMPA.
        /// </summary>
        public const string YACMPA = "YACMPA";

        /// <summary>
        /// YAEPNT.
        /// </summary>
        public const string YAEPNT = "YAEPNT";

        /// <summary>
        /// YAJOBN.
        /// </summary>
        public const string YAJOBN = "YAJOBN";

        /// <summary>
        /// YAUSER.
        /// </summary>
        public const string YAUSER = "YAUSER";

        /// <summary>
        /// YAPID.
        /// </summary>
        public const string YAPID = "YAPID";

        /// <summary>
        /// YAUPMJ.
        /// </summary>
        public const string YAUPMJ = "YAUPMJ";

        /// <summary>
        /// YAK001.
        /// </summary>
        public const string YAK001 = "YAK001";

        /// <summary>
        /// YAK002.
        /// </summary>
        public const string YAK002 = "YAK002";

        /// <summary>
        /// YAK003.
        /// </summary>
        public const string YAK003 = "YAK003";

        /// <summary>
        /// YAK004.
        /// </summary>
        public const string YAK004 = "YAK004";

        /// <summary>
        /// YAK005.
        /// </summary>
        public const string YAK005 = "YAK005";

        /// <summary>
        /// YAK006.
        /// </summary>
        public const string YAK006 = "YAK006";

        /// <summary>
        /// YAK007.
        /// </summary>
        public const string YAK007 = "YAK007";

        /// <summary>
        /// YAK008.
        /// </summary>
        public const string YAK008 = "YAK008";

        /// <summary>
        /// YAK009.
        /// </summary>
        public const string YAK009 = "YAK009";

        /// <summary>
        /// YAK010.
        /// </summary>
        public const string YAK010 = "YAK010";

        /// <summary>
        /// YAATPY.
        /// </summary>
        public const string YAATPY = "YAATPY";

        /// <summary>
        /// YAPENS.
        /// </summary>
        public const string YAPENS = "YAPENS";

        /// <summary>
        /// YAORG.
        /// </summary>
        public const string YAORG = "YAORG";

        /// <summary>
        /// YABENS.
        /// </summary>
        public const string YABENS = "YABENS";

        /// <summary>
        /// YAFTE.
        /// </summary>
        public const string YAFTE = "YAFTE";

        /// <summary>
        /// YAAAF.
        /// </summary>
        public const string YAAAF = "YAAAF";

        /// <summary>
        /// YASUI.
        /// </summary>
        public const string YASUI = "YASUI";

        /// <summary>
        /// YADTSF.
        /// </summary>
        public const string YADTSF = "YADTSF";

        /// <summary>
        /// YASMOY.
        /// </summary>
        public const string YASMOY = "YASMOY";

        /// <summary>
        /// YAUSD1.
        /// </summary>
        public const string YAUSD1 = "YAUSD1";

        /// <summary>
        /// YAUSD2.
        /// </summary>
        public const string YAUSD2 = "YAUSD2";

        /// <summary>
        /// YAUSD3.
        /// </summary>
        public const string YAUSD3 = "YAUSD3";

        /// <summary>
        /// YAUSD4.
        /// </summary>
        public const string YAUSD4 = "YAUSD4";

        /// <summary>
        /// YAUSD5.
        /// </summary>
        public const string YAUSD5 = "YAUSD5";

        /// <summary>
        /// YAMATH01.
        /// </summary>
        public const string YAMATH01 = "YAMATH01";

        /// <summary>
        /// YAMATH02.
        /// </summary>
        public const string YAMATH02 = "YAMATH02";

        /// <summary>
        /// YAMATH03.
        /// </summary>
        public const string YAMATH03 = "YAMATH03";

        /// <summary>
        /// YAMATH04.
        /// </summary>
        public const string YAMATH04 = "YAMATH04";

        /// <summary>
        /// YAMATH05.
        /// </summary>
        public const string YAMATH05 = "YAMATH05";

        /// <summary>
        /// YAET01.
        /// </summary>
        public const string YAET01 = "YAET01";

        /// <summary>
        /// YAET02.
        /// </summary>
        public const string YAET02 = "YAET02";

        /// <summary>
        /// YAET03.
        /// </summary>
        public const string YAET03 = "YAET03";

        /// <summary>
        /// YAET04.
        /// </summary>
        public const string YAET04 = "YAET04";

        /// <summary>
        /// YAET05.
        /// </summary>
        public const string YAET05 = "YAET05";

        /// <summary>
        /// YADL01.
        /// </summary>
        public const string YADL01 = "YADL01";

        /// <summary>
        /// YADL02.
        /// </summary>
        public const string YADL02 = "YADL02";

        /// <summary>
        /// YADL03.
        /// </summary>
        public const string YADL03 = "YADL03";

        /// <summary>
        /// YADL04.
        /// </summary>
        public const string YADL04 = "YADL04";

        /// <summary>
        /// YADL05.
        /// </summary>
        public const string YADL05 = "YADL05";
    }

    /// <inheritdoc />
    public override string TableName => "F060116W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YAAN8", "YAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YAALPH", "YAALPH", JdeDataType.String, 80),
        new JdeField("YASSN", "YASSN", JdeDataType.String, 40),
        new JdeField("YAOEMP", "YAOEMP", JdeDataType.String, 16),
        new JdeField("YASEX", "YASEX", JdeDataType.String, 2),
        new JdeField("YAMSTX", "YAMSTX", JdeDataType.String, 2),
        new JdeField("YAMSTI", "YAMSTI", JdeDataType.String, 2),
        new JdeField("YAWSPS", "YAWSPS", JdeDataType.String, 2),
        new JdeField("YAEIC", "YAEIC", JdeDataType.String, 2),
        new JdeField("YANDEP", "YANDEP", JdeDataType.Numeric),
        new JdeField("YAEST", "YAEST", JdeDataType.String, 2),
        new JdeField("YAECNT", "YAECNT", JdeDataType.String, 2),
        new JdeField("YATARR", "YATARR", JdeDataType.String, 20),
        new JdeField("YATARA", "YATARA", JdeDataType.String, 20),
        new JdeField("YASCDC", "YASCDC", JdeDataType.Numeric),
        new JdeField("YAHMST", "YAHMST", JdeDataType.String, 6),
        new JdeField("YAWKSE", "YAWKSE", JdeDataType.String, 6),
        new JdeField("YAHMLC", "YAHMLC", JdeDataType.String, 6),
        new JdeField("YALWK1", "YALWK1", JdeDataType.String, 6),
        new JdeField("YALWK2", "YALWK2", JdeDataType.String, 6),
        new JdeField("YAHMCO", "YAHMCO", JdeDataType.String, 10),
        new JdeField("YAMCU", "YAMCU", JdeDataType.String, 24),
        new JdeField("YAHMCU", "YAHMCU", JdeDataType.String, 24),
        new JdeField("YASG", "YASG", JdeDataType.String, 24),
        new JdeField("YAMAIL", "YAMAIL", JdeDataType.String, 20),
        new JdeField("YAPAST", "YAPAST", JdeDataType.String, 2),
        new JdeField("YAPFRQ", "YAPFRQ", JdeDataType.String, 2),
        new JdeField("YASALY", "YASALY", JdeDataType.String, 2),
        new JdeField("YAPYCB", "YAPYCB", JdeDataType.Numeric),
        new JdeField("YABCB", "YABCB", JdeDataType.Numeric),
        new JdeField("YAUN", "YAUN", JdeDataType.String, 12),
        new JdeField("YAJBCD", "YAJBCD", JdeDataType.String, 12),
        new JdeField("YAJBST", "YAJBST", JdeDataType.String, 8),
        new JdeField("YAEEOJ", "YAEEOJ", JdeDataType.String, 6),
        new JdeField("YAEEOM", "YAEEOM", JdeDataType.String, 4),
        new JdeField("YATRS", "YATRS", JdeDataType.String, 6),
        new JdeField("YAWCMP", "YAWCMP", JdeDataType.String, 8),
        new JdeField("YAFLSA", "YAFLSA", JdeDataType.String, 2),
        new JdeField("YAWS", "YAWS", JdeDataType.String, 2),
        new JdeField("YASHFT", "YASHFT", JdeDataType.String, 2),
        new JdeField("YALMTH", "YALMTH", JdeDataType.String, 2),
        new JdeField("YAPBRT", "YAPBRT", JdeDataType.Numeric),
        new JdeField("YALF", "YALF", JdeDataType.Numeric),
        new JdeField("YASAL", "YASAL", JdeDataType.Numeric),
        new JdeField("YAPHRT", "YAPHRT", JdeDataType.Numeric),
        new JdeField("YAPPRT", "YAPPRT", JdeDataType.Numeric),
        new JdeField("YAPWRN", "YAPWRN", JdeDataType.Numeric),
        new JdeField("YAHRTN", "YAHRTN", JdeDataType.Numeric),
        new JdeField("YABRTN", "YABRTN", JdeDataType.Numeric),
        new JdeField("YASALN", "YASALN", JdeDataType.Numeric),
        new JdeField("YASTDH", "YASTDH", JdeDataType.Numeric),
        new JdeField("YASTDD", "YASTDD", JdeDataType.Numeric),
        new JdeField("YASDYY", "YASDYY", JdeDataType.Numeric),
        new JdeField("YAUSR", "YAUSR", JdeDataType.String, 36),
        new JdeField("YAUFLG", "YAUFLG", JdeDataType.String, 2),
        new JdeField("YANS", "YANS", JdeDataType.String, 2),
        new JdeField("YAIFN", "YAIFN", JdeDataType.String, 2),
        new JdeField("YAIMN", "YAIMN", JdeDataType.String, 2),
        new JdeField("YADOB", "YADOB", JdeDataType.Numeric),
        new JdeField("YADSI", "YADSI", JdeDataType.Numeric),
        new JdeField("YADT", "YADT", JdeDataType.Numeric),
        new JdeField("YADST", "YADST", JdeDataType.Numeric),
        new JdeField("YAPSDT", "YAPSDT", JdeDataType.Numeric),
        new JdeField("YAPTDT", "YAPTDT", JdeDataType.Numeric),
        new JdeField("YANRDT", "YANRDT", JdeDataType.Numeric),
        new JdeField("YANBDT", "YANBDT", JdeDataType.Numeric),
        new JdeField("YANPDT", "YANPDT", JdeDataType.Numeric),
        new JdeField("YALCDT", "YALCDT", JdeDataType.Numeric),
        new JdeField("YADR", "YADR", JdeDataType.Numeric),
        new JdeField("YACTDT", "YACTDT", JdeDataType.Numeric),
        new JdeField("YALADT", "YALADT", JdeDataType.Numeric),
        new JdeField("YABSDT", "YABSDT", JdeDataType.Numeric),
        new JdeField("YACPDT", "YACPDT", JdeDataType.Numeric),
        new JdeField("YAFICM", "YAFICM", JdeDataType.String, 2),
        new JdeField("YAP001", "YAP001", JdeDataType.String, 6),
        new JdeField("YAP002", "YAP002", JdeDataType.String, 6),
        new JdeField("YAP003", "YAP003", JdeDataType.String, 6),
        new JdeField("YAP004", "YAP004", JdeDataType.String, 6),
        new JdeField("YAP005", "YAP005", JdeDataType.String, 6),
        new JdeField("YAP006", "YAP006", JdeDataType.String, 6),
        new JdeField("YAP007", "YAP007", JdeDataType.String, 6),
        new JdeField("YAP008", "YAP008", JdeDataType.String, 6),
        new JdeField("YAP009", "YAP009", JdeDataType.String, 6),
        new JdeField("YAP010", "YAP010", JdeDataType.String, 6),
        new JdeField("YAP011", "YAP011", JdeDataType.String, 6),
        new JdeField("YAP012", "YAP012", JdeDataType.String, 6),
        new JdeField("YAP013", "YAP013", JdeDataType.String, 6),
        new JdeField("YAP014", "YAP014", JdeDataType.String, 6),
        new JdeField("YAP015", "YAP015", JdeDataType.String, 6),
        new JdeField("YAP016", "YAP016", JdeDataType.String, 6),
        new JdeField("YAP017", "YAP017", JdeDataType.String, 6),
        new JdeField("YAP018", "YAP018", JdeDataType.String, 6),
        new JdeField("YAP019", "YAP019", JdeDataType.String, 6),
        new JdeField("YAP020", "YAP020", JdeDataType.String, 6),
        new JdeField("YAE001", "YAE001", JdeDataType.String, 2),
        new JdeField("YAE002", "YAE002", JdeDataType.String, 2),
        new JdeField("YAE003", "YAE003", JdeDataType.String, 2),
        new JdeField("YAE004", "YAE004", JdeDataType.String, 2),
        new JdeField("YAE005", "YAE005", JdeDataType.String, 2),
        new JdeField("YAE006", "YAE006", JdeDataType.String, 2),
        new JdeField("YAE007", "YAE007", JdeDataType.String, 2),
        new JdeField("YAE008", "YAE008", JdeDataType.String, 2),
        new JdeField("YAE009", "YAE009", JdeDataType.String, 2),
        new JdeField("YAE010", "YAE010", JdeDataType.String, 2),
        new JdeField("YAICC", "YAICC", JdeDataType.String, 2),
        new JdeField("YANMAX", "YANMAX", JdeDataType.Numeric),
        new JdeField("YASOCC", "YASOCC", JdeDataType.String, 8),
        new JdeField("YAIUSR", "YAIUSR", JdeDataType.String, 20),
        new JdeField("YAITRM", "YAITRM", JdeDataType.String, 20),
        new JdeField("YAINBT", "YAINBT", JdeDataType.String, 2),
        new JdeField("YAREGN", "YAREGN", JdeDataType.String, 6),
        new JdeField("YAPSTP", "YAPSTP", JdeDataType.String, 8),
        new JdeField("YAIH", "YAIH", JdeDataType.Numeric),
        new JdeField("YACCPR", "YACCPR", JdeDataType.String, 6),
        new JdeField("YAADPN", "YAADPN", JdeDataType.String, 2),
        new JdeField("YATCNF", "YATCNF", JdeDataType.String, 2),
        new JdeField("YARAF", "YARAF", JdeDataType.String, 2),
        new JdeField("YATIPE", "YATIPE", JdeDataType.String, 2),
        new JdeField("YARCCD", "YARCCD", JdeDataType.String, 2),
        new JdeField("YABDRT", "YABDRT", JdeDataType.Numeric),
        new JdeField("YABORN", "YABORN", JdeDataType.Numeric),
        new JdeField("YANBDR", "YANBDR", JdeDataType.Numeric),
        new JdeField("YAWET", "YAWET", JdeDataType.String, 2),
        new JdeField("YAAFLG", "YAAFLG", JdeDataType.String, 2),
        new JdeField("YARMST", "YARMST", JdeDataType.String, 2),
        new JdeField("YALMST", "YALMST", JdeDataType.String, 2),
        new JdeField("YASMKR", "YASMKR", JdeDataType.String, 4),
        new JdeField("YACBAC", "YACBAC", JdeDataType.Numeric),
        new JdeField("YACBAF", "YACBAF", JdeDataType.String, 2),
        new JdeField("YAPCCD", "YAPCCD", JdeDataType.String, 10),
        new JdeField("YARCDT", "YARCDT", JdeDataType.Numeric),
        new JdeField("YALSDT", "YALSDT", JdeDataType.Numeric),
        new JdeField("YAPADT", "YAPADT", JdeDataType.Numeric),
        new JdeField("YAPYMH", "YAPYMH", JdeDataType.String, 2),
        new JdeField("YAUYST", "YAUYST", JdeDataType.String, 2),
        new JdeField("YADTSP", "YADTSP", JdeDataType.Numeric),
        new JdeField("YAANN8", "YAANN8", JdeDataType.Numeric),
        new JdeField("YAPPNB", "YAPPNB", JdeDataType.String, 6),
        new JdeField("YAPYDT", "YAPYDT", JdeDataType.Numeric),
        new JdeField("YACBEN", "YACBEN", JdeDataType.String, 2),
        new JdeField("YADOBM", "YADOBM", JdeDataType.Numeric),
        new JdeField("YADSTM", "YADSTM", JdeDataType.Numeric),
        new JdeField("YAPSAL", "YAPSAL", JdeDataType.Numeric),
        new JdeField("YAHIPN", "YAHIPN", JdeDataType.String, 22),
        new JdeField("YACM", "YACM", JdeDataType.String, 4),
        new JdeField("YALSAL", "YALSAL", JdeDataType.Numeric),
        new JdeField("YADIVC", "YADIVC", JdeDataType.String, 12),
        new JdeField("YAVSHF", "YAVSHF", JdeDataType.String, 2),
        new JdeField("YAPYRV", "YAPYRV", JdeDataType.Numeric),
        new JdeField("YAANPA", "YAANPA", JdeDataType.Numeric),
        new JdeField("YAPGRD", "YAPGRD", JdeDataType.String, 12),
        new JdeField("YAPGRS", "YAPGRS", JdeDataType.String, 8),
        new JdeField("YASLOC", "YASLOC", JdeDataType.String, 16),
        new JdeField("YANRVW", "YANRVW", JdeDataType.Numeric),
        new JdeField("YATINC", "YATINC", JdeDataType.String, 2),
        new JdeField("YAHM01", "YAHM01", JdeDataType.String, 2),
        new JdeField("YAHM02", "YAHM02", JdeDataType.String, 2),
        new JdeField("YAHM03", "YAHM03", JdeDataType.String, 2),
        new JdeField("YAHM04", "YAHM04", JdeDataType.String, 2),
        new JdeField("YAPOS", "YAPOS", JdeDataType.String, 16),
        new JdeField("YAED01", "YAED01", JdeDataType.Numeric),
        new JdeField("YAED02", "YAED02", JdeDataType.Numeric),
        new JdeField("YAED03", "YAED03", JdeDataType.Numeric),
        new JdeField("YAED04", "YAED04", JdeDataType.Numeric),
        new JdeField("YAED05", "YAED05", JdeDataType.Numeric),
        new JdeField("YAED06", "YAED06", JdeDataType.Numeric),
        new JdeField("YAED07", "YAED07", JdeDataType.Numeric),
        new JdeField("YAED08", "YAED08", JdeDataType.Numeric),
        new JdeField("YAED09", "YAED09", JdeDataType.Numeric),
        new JdeField("YAED10", "YAED10", JdeDataType.Numeric),
        new JdeField("YAED11", "YAED11", JdeDataType.Numeric),
        new JdeField("YAED12", "YAED12", JdeDataType.Numeric),
        new JdeField("YAED13", "YAED13", JdeDataType.Numeric),
        new JdeField("YAED14", "YAED14", JdeDataType.Numeric),
        new JdeField("YAED15", "YAED15", JdeDataType.Numeric),
        new JdeField("YAED16", "YAED16", JdeDataType.Numeric),
        new JdeField("YAED17", "YAED17", JdeDataType.Numeric),
        new JdeField("YAED18", "YAED18", JdeDataType.Numeric),
        new JdeField("YAED19", "YAED19", JdeDataType.Numeric),
        new JdeField("YAED20", "YAED20", JdeDataType.Numeric),
        new JdeField("YADEPT", "YADEPT", JdeDataType.String, 24),
        new JdeField("YAFAGE", "YAFAGE", JdeDataType.Numeric),
        new JdeField("YAFSAL", "YAFSAL", JdeDataType.Numeric),
        new JdeField("YAADSD", "YAADSD", JdeDataType.Numeric),
        new JdeField("YACMPA", "YACMPA", JdeDataType.Numeric),
        new JdeField("YAEPNT", "YAEPNT", JdeDataType.Numeric),
        new JdeField("YAJOBN", "YAJOBN", JdeDataType.String, 20),
        new JdeField("YAUSER", "YAUSER", JdeDataType.String, 20),
        new JdeField("YAPID", "YAPID", JdeDataType.String, 20),
        new JdeField("YAUPMJ", "YAUPMJ", JdeDataType.Numeric),
        new JdeField("YAK001", "YAK001", JdeDataType.String, 2),
        new JdeField("YAK002", "YAK002", JdeDataType.String, 2),
        new JdeField("YAK003", "YAK003", JdeDataType.String, 2),
        new JdeField("YAK004", "YAK004", JdeDataType.String, 2),
        new JdeField("YAK005", "YAK005", JdeDataType.String, 2),
        new JdeField("YAK006", "YAK006", JdeDataType.String, 2),
        new JdeField("YAK007", "YAK007", JdeDataType.String, 2),
        new JdeField("YAK008", "YAK008", JdeDataType.String, 2),
        new JdeField("YAK009", "YAK009", JdeDataType.String, 2),
        new JdeField("YAK010", "YAK010", JdeDataType.String, 2),
        new JdeField("YAATPY", "YAATPY", JdeDataType.Numeric),
        new JdeField("YAPENS", "YAPENS", JdeDataType.String, 2),
        new JdeField("YAORG", "YAORG", JdeDataType.String, 2),
        new JdeField("YABENS", "YABENS", JdeDataType.String, 2),
        new JdeField("YAFTE", "YAFTE", JdeDataType.Numeric),
        new JdeField("YAAAF", "YAAAF", JdeDataType.String, 2),
        new JdeField("YASUI", "YASUI", JdeDataType.String, 2),
        new JdeField("YADTSF", "YADTSF", JdeDataType.Numeric),
        new JdeField("YASMOY", "YASMOY", JdeDataType.Numeric),
        new JdeField("YAUSD1", "YAUSD1", JdeDataType.Numeric),
        new JdeField("YAUSD2", "YAUSD2", JdeDataType.Numeric),
        new JdeField("YAUSD3", "YAUSD3", JdeDataType.Numeric),
        new JdeField("YAUSD4", "YAUSD4", JdeDataType.Numeric),
        new JdeField("YAUSD5", "YAUSD5", JdeDataType.Numeric),
        new JdeField("YAMATH01", "YAMATH01", JdeDataType.Numeric),
        new JdeField("YAMATH02", "YAMATH02", JdeDataType.Numeric),
        new JdeField("YAMATH03", "YAMATH03", JdeDataType.Numeric),
        new JdeField("YAMATH04", "YAMATH04", JdeDataType.Numeric),
        new JdeField("YAMATH05", "YAMATH05", JdeDataType.Numeric),
        new JdeField("YAET01", "YAET01", JdeDataType.String, 2),
        new JdeField("YAET02", "YAET02", JdeDataType.String, 2),
        new JdeField("YAET03", "YAET03", JdeDataType.String, 2),
        new JdeField("YAET04", "YAET04", JdeDataType.String, 2),
        new JdeField("YAET05", "YAET05", JdeDataType.String, 2),
        new JdeField("YADL01", "YADL01", JdeDataType.String, 60),
        new JdeField("YADL02", "YADL02", JdeDataType.String, 60),
        new JdeField("YADL03", "YADL03", JdeDataType.String, 60),
        new JdeField("YADL04", "YADL04", JdeDataType.String, 60),
        new JdeField("YADL05", "YADL05", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060116W_0", "Primary Key on YAAN8", new[] { "YAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
