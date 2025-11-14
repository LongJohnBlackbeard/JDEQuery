using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41UI001 - .
/// </summary>
public class F41UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITCTID.
        /// </summary>
        public const string ITCTID = "ITCTID";

        /// <summary>
        /// ITJOBS.
        /// </summary>
        public const string ITJOBS = "ITJOBS";

        /// <summary>
        /// ITLNID.
        /// </summary>
        public const string ITLNID = "ITLNID";

        /// <summary>
        /// ITNLIN.
        /// </summary>
        public const string ITNLIN = "ITNLIN";

        /// <summary>
        /// ITACTN.
        /// </summary>
        public const string ITACTN = "ITACTN";

        /// <summary>
        /// ITDOC.
        /// </summary>
        public const string ITDOC = "ITDOC";

        /// <summary>
        /// ITDCT.
        /// </summary>
        public const string ITDCT = "ITDCT";

        /// <summary>
        /// ITKCO.
        /// </summary>
        public const string ITKCO = "ITKCO";

        /// <summary>
        /// ITSFX.
        /// </summary>
        public const string ITSFX = "ITSFX";

        /// <summary>
        /// ITICU.
        /// </summary>
        public const string ITICU = "ITICU";

        /// <summary>
        /// ITICUT.
        /// </summary>
        public const string ITICUT = "ITICUT";

        /// <summary>
        /// ITIST.
        /// </summary>
        public const string ITIST = "ITIST";

        /// <summary>
        /// ITITM.
        /// </summary>
        public const string ITITM = "ITITM";

        /// <summary>
        /// ITLITM.
        /// </summary>
        public const string ITLITM = "ITLITM";

        /// <summary>
        /// ITAITM.
        /// </summary>
        public const string ITAITM = "ITAITM";

        /// <summary>
        /// ITMCU.
        /// </summary>
        public const string ITMCU = "ITMCU";

        /// <summary>
        /// ITLOCN.
        /// </summary>
        public const string ITLOCN = "ITLOCN";

        /// <summary>
        /// ITLOTN.
        /// </summary>
        public const string ITLOTN = "ITLOTN";

        /// <summary>
        /// ITTRQT.
        /// </summary>
        public const string ITTRQT = "ITTRQT";

        /// <summary>
        /// ITUNCS.
        /// </summary>
        public const string ITUNCS = "ITUNCS";

        /// <summary>
        /// ITPAID.
        /// </summary>
        public const string ITPAID = "ITPAID";

        /// <summary>
        /// ITPRRC.
        /// </summary>
        public const string ITPRRC = "ITPRRC";

        /// <summary>
        /// ITTRUM.
        /// </summary>
        public const string ITTRUM = "ITTRUM";

        /// <summary>
        /// ITTRDJ.
        /// </summary>
        public const string ITTRDJ = "ITTRDJ";

        /// <summary>
        /// ITDGL.
        /// </summary>
        public const string ITDGL = "ITDGL";

        /// <summary>
        /// ITGLPT.
        /// </summary>
        public const string ITGLPT = "ITGLPT";

        /// <summary>
        /// ITPLOT.
        /// </summary>
        public const string ITPLOT = "ITPLOT";

        /// <summary>
        /// ITLDSQ.
        /// </summary>
        public const string ITLDSQ = "ITLDSQ";

        /// <summary>
        /// ITTRNO.
        /// </summary>
        public const string ITTRNO = "ITTRNO";

        /// <summary>
        /// ITFRTO.
        /// </summary>
        public const string ITFRTO = "ITFRTO";

        /// <summary>
        /// ITLMCX.
        /// </summary>
        public const string ITLMCX = "ITLMCX";

        /// <summary>
        /// ITLOTS.
        /// </summary>
        public const string ITLOTS = "ITLOTS";

        /// <summary>
        /// ITLOTP.
        /// </summary>
        public const string ITLOTP = "ITLOTP";

        /// <summary>
        /// ITLOTG.
        /// </summary>
        public const string ITLOTG = "ITLOTG";

        /// <summary>
        /// ITKIT.
        /// </summary>
        public const string ITKIT = "ITKIT";

        /// <summary>
        /// ITMMCU.
        /// </summary>
        public const string ITMMCU = "ITMMCU";

        /// <summary>
        /// ITDMCT.
        /// </summary>
        public const string ITDMCT = "ITDMCT";

        /// <summary>
        /// ITDMCS.
        /// </summary>
        public const string ITDMCS = "ITDMCS";

        /// <summary>
        /// ITBALU.
        /// </summary>
        public const string ITBALU = "ITBALU";

        /// <summary>
        /// ITDCTO.
        /// </summary>
        public const string ITDCTO = "ITDCTO";

        /// <summary>
        /// ITDOCO.
        /// </summary>
        public const string ITDOCO = "ITDOCO";

        /// <summary>
        /// ITKCOO.
        /// </summary>
        public const string ITKCOO = "ITKCOO";

        /// <summary>
        /// ITSFXO.
        /// </summary>
        public const string ITSFXO = "ITSFXO";

        /// <summary>
        /// ITIPCD.
        /// </summary>
        public const string ITIPCD = "ITIPCD";

        /// <summary>
        /// ITAN8.
        /// </summary>
        public const string ITAN8 = "ITAN8";

        /// <summary>
        /// ITTREF.
        /// </summary>
        public const string ITTREF = "ITTREF";

        /// <summary>
        /// ITTREX.
        /// </summary>
        public const string ITTREX = "ITTREX";

        /// <summary>
        /// ITRCD.
        /// </summary>
        public const string ITRCD = "ITRCD";

        /// <summary>
        /// ITSRP1.
        /// </summary>
        public const string ITSRP1 = "ITSRP1";

        /// <summary>
        /// ITSRP2.
        /// </summary>
        public const string ITSRP2 = "ITSRP2";

        /// <summary>
        /// ITSRP3.
        /// </summary>
        public const string ITSRP3 = "ITSRP3";

        /// <summary>
        /// ITSRP4.
        /// </summary>
        public const string ITSRP4 = "ITSRP4";

        /// <summary>
        /// ITSRP5.
        /// </summary>
        public const string ITSRP5 = "ITSRP5";

        /// <summary>
        /// ITSRP6.
        /// </summary>
        public const string ITSRP6 = "ITSRP6";

        /// <summary>
        /// ITSRP7.
        /// </summary>
        public const string ITSRP7 = "ITSRP7";

        /// <summary>
        /// ITSRP8.
        /// </summary>
        public const string ITSRP8 = "ITSRP8";

        /// <summary>
        /// ITSRP9.
        /// </summary>
        public const string ITSRP9 = "ITSRP9";

        /// <summary>
        /// ITSRP0.
        /// </summary>
        public const string ITSRP0 = "ITSRP0";

        /// <summary>
        /// ITPRP1.
        /// </summary>
        public const string ITPRP1 = "ITPRP1";

        /// <summary>
        /// ITPRP2.
        /// </summary>
        public const string ITPRP2 = "ITPRP2";

        /// <summary>
        /// ITPRP3.
        /// </summary>
        public const string ITPRP3 = "ITPRP3";

        /// <summary>
        /// ITPRP4.
        /// </summary>
        public const string ITPRP4 = "ITPRP4";

        /// <summary>
        /// ITPRP5.
        /// </summary>
        public const string ITPRP5 = "ITPRP5";

        /// <summary>
        /// ITPRP6.
        /// </summary>
        public const string ITPRP6 = "ITPRP6";

        /// <summary>
        /// ITPRP7.
        /// </summary>
        public const string ITPRP7 = "ITPRP7";

        /// <summary>
        /// ITPRP8.
        /// </summary>
        public const string ITPRP8 = "ITPRP8";

        /// <summary>
        /// ITPRP9.
        /// </summary>
        public const string ITPRP9 = "ITPRP9";

        /// <summary>
        /// ITPRP0.
        /// </summary>
        public const string ITPRP0 = "ITPRP0";

        /// <summary>
        /// ITFIFO.
        /// </summary>
        public const string ITFIFO = "ITFIFO";

        /// <summary>
        /// ITBUYR.
        /// </summary>
        public const string ITBUYR = "ITBUYR";

        /// <summary>
        /// ITPRGR.
        /// </summary>
        public const string ITPRGR = "ITPRGR";

        /// <summary>
        /// ITRPRC.
        /// </summary>
        public const string ITRPRC = "ITRPRC";

        /// <summary>
        /// ITORPR.
        /// </summary>
        public const string ITORPR = "ITORPR";

        /// <summary>
        /// ITCARP.
        /// </summary>
        public const string ITCARP = "ITCARP";

        /// <summary>
        /// ITCARS.
        /// </summary>
        public const string ITCARS = "ITCARS";

        /// <summary>
        /// ITSHCN.
        /// </summary>
        public const string ITSHCN = "ITSHCN";

        /// <summary>
        /// ITSHCM.
        /// </summary>
        public const string ITSHCM = "ITSHCM";

        /// <summary>
        /// ITCYCL.
        /// </summary>
        public const string ITCYCL = "ITCYCL";

        /// <summary>
        /// ITSTKT.
        /// </summary>
        public const string ITSTKT = "ITSTKT";

        /// <summary>
        /// ITBACK.
        /// </summary>
        public const string ITBACK = "ITBACK";

        /// <summary>
        /// ITINMG.
        /// </summary>
        public const string ITINMG = "ITINMG";

        /// <summary>
        /// ITABCS.
        /// </summary>
        public const string ITABCS = "ITABCS";

        /// <summary>
        /// ITABCM.
        /// </summary>
        public const string ITABCM = "ITABCM";

        /// <summary>
        /// ITABCI.
        /// </summary>
        public const string ITABCI = "ITABCI";

        /// <summary>
        /// ITOVR.
        /// </summary>
        public const string ITOVR = "ITOVR";

        /// <summary>
        /// ITSRNR.
        /// </summary>
        public const string ITSRNR = "ITSRNR";

        /// <summary>
        /// ITTAX1.
        /// </summary>
        public const string ITTAX1 = "ITTAX1";

        /// <summary>
        /// ITLTLV.
        /// </summary>
        public const string ITLTLV = "ITLTLV";

        /// <summary>
        /// ITLTMF.
        /// </summary>
        public const string ITLTMF = "ITLTMF";

        /// <summary>
        /// ITLTCM.
        /// </summary>
        public const string ITLTCM = "ITLTCM";

        /// <summary>
        /// ITANPL.
        /// </summary>
        public const string ITANPL = "ITANPL";

        /// <summary>
        /// ITOPC.
        /// </summary>
        public const string ITOPC = "ITOPC";

        /// <summary>
        /// ITOPV.
        /// </summary>
        public const string ITOPV = "ITOPV";

        /// <summary>
        /// ITACQ.
        /// </summary>
        public const string ITACQ = "ITACQ";

        /// <summary>
        /// ITMLQ.
        /// </summary>
        public const string ITMLQ = "ITMLQ";

        /// <summary>
        /// ITLLX.
        /// </summary>
        public const string ITLLX = "ITLLX";

        /// <summary>
        /// ITLTPU.
        /// </summary>
        public const string ITLTPU = "ITLTPU";

        /// <summary>
        /// ITMPST.
        /// </summary>
        public const string ITMPST = "ITMPST";

        /// <summary>
        /// ITMPSP.
        /// </summary>
        public const string ITMPSP = "ITMPSP";

        /// <summary>
        /// ITMRPP.
        /// </summary>
        public const string ITMRPP = "ITMRPP";

        /// <summary>
        /// ITSLD.
        /// </summary>
        public const string ITSLD = "ITSLD";

        /// <summary>
        /// ITITC.
        /// </summary>
        public const string ITITC = "ITITC";

        /// <summary>
        /// ITSNS.
        /// </summary>
        public const string ITSNS = "ITSNS";

        /// <summary>
        /// ITPCTM.
        /// </summary>
        public const string ITPCTM = "ITPCTM";

        /// <summary>
        /// ITMMPC.
        /// </summary>
        public const string ITMMPC = "ITMMPC";

        /// <summary>
        /// ITCDCD.
        /// </summary>
        public const string ITCDCD = "ITCDCD";

        /// <summary>
        /// ITSTDP.
        /// </summary>
        public const string ITSTDP = "ITSTDP";

        /// <summary>
        /// ITFRMP.
        /// </summary>
        public const string ITFRMP = "ITFRMP";

        /// <summary>
        /// ITCOTY.
        /// </summary>
        public const string ITCOTY = "ITCOTY";

        /// <summary>
        /// ITTHRP.
        /// </summary>
        public const string ITTHRP = "ITTHRP";

        /// <summary>
        /// ITOT1Y.
        /// </summary>
        public const string ITOT1Y = "ITOT1Y";

        /// <summary>
        /// ITOT2Y.
        /// </summary>
        public const string ITOT2Y = "ITOT2Y";

        /// <summary>
        /// ITFRGD.
        /// </summary>
        public const string ITFRGD = "ITFRGD";

        /// <summary>
        /// ITTHGD.
        /// </summary>
        public const string ITTHGD = "ITTHGD";

        /// <summary>
        /// ITSTDG.
        /// </summary>
        public const string ITSTDG = "ITSTDG";

        /// <summary>
        /// ITORDW.
        /// </summary>
        public const string ITORDW = "ITORDW";

        /// <summary>
        /// ITMTF1.
        /// </summary>
        public const string ITMTF1 = "ITMTF1";

        /// <summary>
        /// ITMTF2.
        /// </summary>
        public const string ITMTF2 = "ITMTF2";

        /// <summary>
        /// ITMTF3.
        /// </summary>
        public const string ITMTF3 = "ITMTF3";

        /// <summary>
        /// ITMTF4.
        /// </summary>
        public const string ITMTF4 = "ITMTF4";

        /// <summary>
        /// ITMTF5.
        /// </summary>
        public const string ITMTF5 = "ITMTF5";

        /// <summary>
        /// ITEXPD.
        /// </summary>
        public const string ITEXPD = "ITEXPD";

        /// <summary>
        /// ITDEFD.
        /// </summary>
        public const string ITDEFD = "ITDEFD";

        /// <summary>
        /// ITSFLT.
        /// </summary>
        public const string ITSFLT = "ITSFLT";

        /// <summary>
        /// ITMAKE.
        /// </summary>
        public const string ITMAKE = "ITMAKE";

        /// <summary>
        /// ITSRCE.
        /// </summary>
        public const string ITSRCE = "ITSRCE";

        /// <summary>
        /// ITPBIN.
        /// </summary>
        public const string ITPBIN = "ITPBIN";

        /// <summary>
        /// ITPQOH.
        /// </summary>
        public const string ITPQOH = "ITPQOH";

        /// <summary>
        /// ITPBCK.
        /// </summary>
        public const string ITPBCK = "ITPBCK";

        /// <summary>
        /// ITPREQ.
        /// </summary>
        public const string ITPREQ = "ITPREQ";

        /// <summary>
        /// ITQWBO.
        /// </summary>
        public const string ITQWBO = "ITQWBO";

        /// <summary>
        /// ITOT1P.
        /// </summary>
        public const string ITOT1P = "ITOT1P";

        /// <summary>
        /// ITOT2P.
        /// </summary>
        public const string ITOT2P = "ITOT2P";

        /// <summary>
        /// ITOT1A.
        /// </summary>
        public const string ITOT1A = "ITOT1A";

        /// <summary>
        /// ITHCOM.
        /// </summary>
        public const string ITHCOM = "ITHCOM";

        /// <summary>
        /// ITPCOM.
        /// </summary>
        public const string ITPCOM = "ITPCOM";

        /// <summary>
        /// ITFCOM.
        /// </summary>
        public const string ITFCOM = "ITFCOM";

        /// <summary>
        /// ITFUN1.
        /// </summary>
        public const string ITFUN1 = "ITFUN1";

        /// <summary>
        /// ITQOWO.
        /// </summary>
        public const string ITQOWO = "ITQOWO";

        /// <summary>
        /// ITQTTR.
        /// </summary>
        public const string ITQTTR = "ITQTTR";

        /// <summary>
        /// ITQTIN.
        /// </summary>
        public const string ITQTIN = "ITQTIN";

        /// <summary>
        /// ITQTO1.
        /// </summary>
        public const string ITQTO1 = "ITQTO1";

        /// <summary>
        /// ITQTO2.
        /// </summary>
        public const string ITQTO2 = "ITQTO2";

        /// <summary>
        /// ITQONL.
        /// </summary>
        public const string ITQONL = "ITQONL";

        /// <summary>
        /// ITQTRI.
        /// </summary>
        public const string ITQTRI = "ITQTRI";

        /// <summary>
        /// ITQTRO.
        /// </summary>
        public const string ITQTRO = "ITQTRO";

        /// <summary>
        /// ITQTY1.
        /// </summary>
        public const string ITQTY1 = "ITQTY1";

        /// <summary>
        /// ITQTY2.
        /// </summary>
        public const string ITQTY2 = "ITQTY2";

        /// <summary>
        /// ITLRCJ.
        /// </summary>
        public const string ITLRCJ = "ITLRCJ";

        /// <summary>
        /// ITNCDJ.
        /// </summary>
        public const string ITNCDJ = "ITNCDJ";

        /// <summary>
        /// ITURCD.
        /// </summary>
        public const string ITURCD = "ITURCD";

        /// <summary>
        /// ITURDT.
        /// </summary>
        public const string ITURDT = "ITURDT";

        /// <summary>
        /// ITURAT.
        /// </summary>
        public const string ITURAT = "ITURAT";

        /// <summary>
        /// ITURAB.
        /// </summary>
        public const string ITURAB = "ITURAB";

        /// <summary>
        /// ITURRF.
        /// </summary>
        public const string ITURRF = "ITURRF";

        /// <summary>
        /// ITLDSC.
        /// </summary>
        public const string ITLDSC = "ITLDSC";

        /// <summary>
        /// ITMMEJ.
        /// </summary>
        public const string ITMMEJ = "ITMMEJ";

        /// <summary>
        /// ITPN.
        /// </summary>
        public const string ITPN = "ITPN";

        /// <summary>
        /// ITFY.
        /// </summary>
        public const string ITFY = "ITFY";

        /// <summary>
        /// ITDSC1.
        /// </summary>
        public const string ITDSC1 = "ITDSC1";

        /// <summary>
        /// ITCLEV.
        /// </summary>
        public const string ITCLEV = "ITCLEV";

        /// <summary>
        /// ITPLEV.
        /// </summary>
        public const string ITPLEV = "ITPLEV";

        /// <summary>
        /// ITUOM1.
        /// </summary>
        public const string ITUOM1 = "ITUOM1";

        /// <summary>
        /// ITLEDG.
        /// </summary>
        public const string ITLEDG = "ITLEDG";

        /// <summary>
        /// ITANI.
        /// </summary>
        public const string ITANI = "ITANI";

        /// <summary>
        /// ITSBL.
        /// </summary>
        public const string ITSBL = "ITSBL";

        /// <summary>
        /// ITSBLT.
        /// </summary>
        public const string ITSBLT = "ITSBLT";

        /// <summary>
        /// ITWR01.
        /// </summary>
        public const string ITWR01 = "ITWR01";

        /// <summary>
        /// ITASII.
        /// </summary>
        public const string ITASII = "ITASII";

        /// <summary>
        /// ITICOS.
        /// </summary>
        public const string ITICOS = "ITICOS";

        /// <summary>
        /// ITLQOH.
        /// </summary>
        public const string ITLQOH = "ITLQOH";

        /// <summary>
        /// ITTQOH.
        /// </summary>
        public const string ITTQOH = "ITTQOH";

        /// <summary>
        /// ITTVIA.
        /// </summary>
        public const string ITTVIA = "ITTVIA";

        /// <summary>
        /// ITLINN.
        /// </summary>
        public const string ITLINN = "ITLINN";

        /// <summary>
        /// ITVARA.
        /// </summary>
        public const string ITVARA = "ITVARA";

        /// <summary>
        /// ITCSMT.
        /// </summary>
        public const string ITCSMT = "ITCSMT";

        /// <summary>
        /// ITPCSM.
        /// </summary>
        public const string ITPCSM = "ITPCSM";

        /// <summary>
        /// ITCSMF.
        /// </summary>
        public const string ITCSMF = "ITCSMF";

        /// <summary>
        /// ITPCSF.
        /// </summary>
        public const string ITPCSF = "ITPCSF";

        /// <summary>
        /// ITABRN.
        /// </summary>
        public const string ITABRN = "ITABRN";

        /// <summary>
        /// ITALON.
        /// </summary>
        public const string ITALON = "ITALON";

        /// <summary>
        /// ITACOS.
        /// </summary>
        public const string ITACOS = "ITACOS";

        /// <summary>
        /// ITAPRI.
        /// </summary>
        public const string ITAPRI = "ITAPRI";

        /// <summary>
        /// ITRLOT.
        /// </summary>
        public const string ITRLOT = "ITRLOT";

        /// <summary>
        /// ITLOT1.
        /// </summary>
        public const string ITLOT1 = "ITLOT1";

        /// <summary>
        /// ITLOT2.
        /// </summary>
        public const string ITLOT2 = "ITLOT2";

        /// <summary>
        /// ITLOT3.
        /// </summary>
        public const string ITLOT3 = "ITLOT3";

        /// <summary>
        /// ITMCUF.
        /// </summary>
        public const string ITMCUF = "ITMCUF";

        /// <summary>
        /// ITLOTF.
        /// </summary>
        public const string ITLOTF = "ITLOTF";

        /// <summary>
        /// ITLOCF.
        /// </summary>
        public const string ITLOCF = "ITLOCF";

        /// <summary>
        /// ITFTRN.
        /// </summary>
        public const string ITFTRN = "ITFTRN";

        /// <summary>
        /// ITENTC.
        /// </summary>
        public const string ITENTC = "ITENTC";

        /// <summary>
        /// ITAEXP.
        /// </summary>
        public const string ITAEXP = "ITAEXP";

        /// <summary>
        /// ITCYNO.
        /// </summary>
        public const string ITCYNO = "ITCYNO";

        /// <summary>
        /// ITTGG.
        /// </summary>
        public const string ITTGG = "ITTGG";

        /// <summary>
        /// ITSLAT.
        /// </summary>
        public const string ITSLAT = "ITSLAT";

        /// <summary>
        /// ITSDCT.
        /// </summary>
        public const string ITSDCT = "ITSDCT";

        /// <summary>
        /// ITJEL1.
        /// </summary>
        public const string ITJEL1 = "ITJEL1";

        /// <summary>
        /// ITJEL2.
        /// </summary>
        public const string ITJEL2 = "ITJEL2";

        /// <summary>
        /// ITJEL3.
        /// </summary>
        public const string ITJEL3 = "ITJEL3";

        /// <summary>
        /// ITJEL4.
        /// </summary>
        public const string ITJEL4 = "ITJEL4";

        /// <summary>
        /// ITJEL5.
        /// </summary>
        public const string ITJEL5 = "ITJEL5";

        /// <summary>
        /// ITJEL6.
        /// </summary>
        public const string ITJEL6 = "ITJEL6";

        /// <summary>
        /// ITVUIL.
        /// </summary>
        public const string ITVUIL = "ITVUIL";

        /// <summary>
        /// ITBPFG.
        /// </summary>
        public const string ITBPFG = "ITBPFG";

        /// <summary>
        /// ITOT5Y.
        /// </summary>
        public const string ITOT5Y = "ITOT5Y";

        /// <summary>
        /// ITAGSQ.
        /// </summary>
        public const string ITAGSQ = "ITAGSQ";

        /// <summary>
        /// ITMODE.
        /// </summary>
        public const string ITMODE = "ITMODE";

        /// <summary>
        /// ITDTO.
        /// </summary>
        public const string ITDTO = "ITDTO";

        /// <summary>
        /// ITPSR.
        /// </summary>
        public const string ITPSR = "ITPSR";

        /// <summary>
        /// ITPSRY.
        /// </summary>
        public const string ITPSRY = "ITPSRY";

        /// <summary>
        /// ITSHAN.
        /// </summary>
        public const string ITSHAN = "ITSHAN";

        /// <summary>
        /// ITDSC2.
        /// </summary>
        public const string ITDSC2 = "ITDSC2";

        /// <summary>
        /// ITDUAL.
        /// </summary>
        public const string ITDUAL = "ITDUAL";

        /// <summary>
        /// ITSREQ.
        /// </summary>
        public const string ITSREQ = "ITSREQ";

        /// <summary>
        /// ITSQWO.
        /// </summary>
        public const string ITSQWO = "ITSQWO";

        /// <summary>
        /// ITHCMS.
        /// </summary>
        public const string ITHCMS = "ITHCMS";

        /// <summary>
        /// ITSCMS.
        /// </summary>
        public const string ITSCMS = "ITSCMS";

        /// <summary>
        /// ITSWSC.
        /// </summary>
        public const string ITSWSC = "ITSWSC";

        /// <summary>
        /// ITSWHC.
        /// </summary>
        public const string ITSWHC = "ITSWHC";

        /// <summary>
        /// ITSIBW.
        /// </summary>
        public const string ITSIBW = "ITSIBW";

        /// <summary>
        /// ITSOBW.
        /// </summary>
        public const string ITSOBW = "ITSOBW";

        /// <summary>
        /// ITUOM2.
        /// </summary>
        public const string ITUOM2 = "ITUOM2";

        /// <summary>
        /// ITBODJ.
        /// </summary>
        public const string ITBODJ = "ITBODJ";

        /// <summary>
        /// ITOHDJ.
        /// </summary>
        public const string ITOHDJ = "ITOHDJ";

        /// <summary>
        /// ITDLEJ.
        /// </summary>
        public const string ITDLEJ = "ITDLEJ";

        /// <summary>
        /// ITSBDJ.
        /// </summary>
        public const string ITSBDJ = "ITSBDJ";

        /// <summary>
        /// ITBBDJ.
        /// </summary>
        public const string ITBBDJ = "ITBBDJ";

        /// <summary>
        /// ITU1DJ.
        /// </summary>
        public const string ITU1DJ = "ITU1DJ";

        /// <summary>
        /// ITU2DJ.
        /// </summary>
        public const string ITU2DJ = "ITU2DJ";

        /// <summary>
        /// ITU3DJ.
        /// </summary>
        public const string ITU3DJ = "ITU3DJ";

        /// <summary>
        /// ITU4DJ.
        /// </summary>
        public const string ITU4DJ = "ITU4DJ";

        /// <summary>
        /// ITU5DJ.
        /// </summary>
        public const string ITU5DJ = "ITU5DJ";

        /// <summary>
        /// ITLOTC.
        /// </summary>
        public const string ITLOTC = "ITLOTC";

        /// <summary>
        /// ITPJCM.
        /// </summary>
        public const string ITPJCM = "ITPJCM";

        /// <summary>
        /// ITPRJM.
        /// </summary>
        public const string ITPRJM = "ITPRJM";

        /// <summary>
        /// ITCFGSID.
        /// </summary>
        public const string ITCFGSID = "ITCFGSID";

        /// <summary>
        /// ITPJDM.
        /// </summary>
        public const string ITPJDM = "ITPJDM";

        /// <summary>
        /// ITCCFL.
        /// </summary>
        public const string ITCCFL = "ITCCFL";

        /// <summary>
        /// ITDOC1.
        /// </summary>
        public const string ITDOC1 = "ITDOC1";

        /// <summary>
        /// ITCONV.
        /// </summary>
        public const string ITCONV = "ITCONV";

        /// <summary>
        /// ITCNV1.
        /// </summary>
        public const string ITCNV1 = "ITCNV1";

        /// <summary>
        /// ITJEL7.
        /// </summary>
        public const string ITJEL7 = "ITJEL7";

        /// <summary>
        /// ITJEL8.
        /// </summary>
        public const string ITJEL8 = "ITJEL8";

        /// <summary>
        /// ITTGN.
        /// </summary>
        public const string ITTGN = "ITTGN";

        /// <summary>
        /// ITRFLN.
        /// </summary>
        public const string ITRFLN = "ITRFLN";

        /// <summary>
        /// ITORIG.
        /// </summary>
        public const string ITORIG = "ITORIG";

        /// <summary>
        /// ITOILNTY.
        /// </summary>
        public const string ITOILNTY = "ITOILNTY";
    }

    /// <inheritdoc />
    public override string TableName => "F41UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITCTID", "ITCTID", JdeDataType.String, 30, true, true),
        new JdeField("ITJOBS", "ITJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ITLNID", "ITLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ITNLIN", "ITNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ITACTN", "ITACTN", JdeDataType.String, 2),
        new JdeField("ITDOC", "ITDOC", JdeDataType.Numeric),
        new JdeField("ITDCT", "ITDCT", JdeDataType.String, 4),
        new JdeField("ITKCO", "ITKCO", JdeDataType.String, 10),
        new JdeField("ITSFX", "ITSFX", JdeDataType.String, 6),
        new JdeField("ITICU", "ITICU", JdeDataType.Numeric),
        new JdeField("ITICUT", "ITICUT", JdeDataType.String, 4),
        new JdeField("ITIST", "ITIST", JdeDataType.String, 2),
        new JdeField("ITITM", "ITITM", JdeDataType.Numeric),
        new JdeField("ITLITM", "ITLITM", JdeDataType.String, 50),
        new JdeField("ITAITM", "ITAITM", JdeDataType.String, 50),
        new JdeField("ITMCU", "ITMCU", JdeDataType.String, 24),
        new JdeField("ITLOCN", "ITLOCN", JdeDataType.String, 40),
        new JdeField("ITLOTN", "ITLOTN", JdeDataType.String, 60),
        new JdeField("ITTRQT", "ITTRQT", JdeDataType.Numeric),
        new JdeField("ITUNCS", "ITUNCS", JdeDataType.Numeric),
        new JdeField("ITPAID", "ITPAID", JdeDataType.Numeric),
        new JdeField("ITPRRC", "ITPRRC", JdeDataType.Numeric),
        new JdeField("ITTRUM", "ITTRUM", JdeDataType.String, 4),
        new JdeField("ITTRDJ", "ITTRDJ", JdeDataType.Numeric),
        new JdeField("ITDGL", "ITDGL", JdeDataType.Numeric),
        new JdeField("ITGLPT", "ITGLPT", JdeDataType.String, 8),
        new JdeField("ITPLOT", "ITPLOT", JdeDataType.String, 60),
        new JdeField("ITLDSQ", "ITLDSQ", JdeDataType.Numeric),
        new JdeField("ITTRNO", "ITTRNO", JdeDataType.Numeric),
        new JdeField("ITFRTO", "ITFRTO", JdeDataType.String, 2),
        new JdeField("ITLMCX", "ITLMCX", JdeDataType.String, 2),
        new JdeField("ITLOTS", "ITLOTS", JdeDataType.String, 2),
        new JdeField("ITLOTP", "ITLOTP", JdeDataType.Numeric),
        new JdeField("ITLOTG", "ITLOTG", JdeDataType.String, 6),
        new JdeField("ITKIT", "ITKIT", JdeDataType.Numeric),
        new JdeField("ITMMCU", "ITMMCU", JdeDataType.String, 24),
        new JdeField("ITDMCT", "ITDMCT", JdeDataType.String, 24),
        new JdeField("ITDMCS", "ITDMCS", JdeDataType.Numeric),
        new JdeField("ITBALU", "ITBALU", JdeDataType.String, 2),
        new JdeField("ITDCTO", "ITDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ITDOCO", "ITDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ITKCOO", "ITKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ITSFXO", "ITSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ITIPCD", "ITIPCD", JdeDataType.String, 2),
        new JdeField("ITAN8", "ITAN8", JdeDataType.Numeric),
        new JdeField("ITTREF", "ITTREF", JdeDataType.String, 16),
        new JdeField("ITTREX", "ITTREX", JdeDataType.String, 60),
        new JdeField("ITRCD", "ITRCD", JdeDataType.String, 6),
        new JdeField("ITSRP1", "ITSRP1", JdeDataType.String, 6),
        new JdeField("ITSRP2", "ITSRP2", JdeDataType.String, 6),
        new JdeField("ITSRP3", "ITSRP3", JdeDataType.String, 6),
        new JdeField("ITSRP4", "ITSRP4", JdeDataType.String, 6),
        new JdeField("ITSRP5", "ITSRP5", JdeDataType.String, 6),
        new JdeField("ITSRP6", "ITSRP6", JdeDataType.String, 12),
        new JdeField("ITSRP7", "ITSRP7", JdeDataType.String, 12),
        new JdeField("ITSRP8", "ITSRP8", JdeDataType.String, 12),
        new JdeField("ITSRP9", "ITSRP9", JdeDataType.String, 12),
        new JdeField("ITSRP0", "ITSRP0", JdeDataType.String, 12),
        new JdeField("ITPRP1", "ITPRP1", JdeDataType.String, 6),
        new JdeField("ITPRP2", "ITPRP2", JdeDataType.String, 6),
        new JdeField("ITPRP3", "ITPRP3", JdeDataType.String, 6),
        new JdeField("ITPRP4", "ITPRP4", JdeDataType.String, 6),
        new JdeField("ITPRP5", "ITPRP5", JdeDataType.String, 6),
        new JdeField("ITPRP6", "ITPRP6", JdeDataType.String, 12),
        new JdeField("ITPRP7", "ITPRP7", JdeDataType.String, 12),
        new JdeField("ITPRP8", "ITPRP8", JdeDataType.String, 12),
        new JdeField("ITPRP9", "ITPRP9", JdeDataType.String, 12),
        new JdeField("ITPRP0", "ITPRP0", JdeDataType.String, 12),
        new JdeField("ITFIFO", "ITFIFO", JdeDataType.String, 2),
        new JdeField("ITBUYR", "ITBUYR", JdeDataType.Numeric),
        new JdeField("ITPRGR", "ITPRGR", JdeDataType.String, 16),
        new JdeField("ITRPRC", "ITRPRC", JdeDataType.String, 16),
        new JdeField("ITORPR", "ITORPR", JdeDataType.String, 16),
        new JdeField("ITCARP", "ITCARP", JdeDataType.Numeric),
        new JdeField("ITCARS", "ITCARS", JdeDataType.Numeric),
        new JdeField("ITSHCN", "ITSHCN", JdeDataType.String, 6),
        new JdeField("ITSHCM", "ITSHCM", JdeDataType.String, 6),
        new JdeField("ITCYCL", "ITCYCL", JdeDataType.String, 6),
        new JdeField("ITSTKT", "ITSTKT", JdeDataType.String, 2),
        new JdeField("ITBACK", "ITBACK", JdeDataType.String, 2),
        new JdeField("ITINMG", "ITINMG", JdeDataType.String, 20),
        new JdeField("ITABCS", "ITABCS", JdeDataType.String, 2),
        new JdeField("ITABCM", "ITABCM", JdeDataType.String, 2),
        new JdeField("ITABCI", "ITABCI", JdeDataType.String, 2),
        new JdeField("ITOVR", "ITOVR", JdeDataType.String, 2),
        new JdeField("ITSRNR", "ITSRNR", JdeDataType.String, 2),
        new JdeField("ITTAX1", "ITTAX1", JdeDataType.String, 2),
        new JdeField("ITLTLV", "ITLTLV", JdeDataType.Numeric),
        new JdeField("ITLTMF", "ITLTMF", JdeDataType.Numeric),
        new JdeField("ITLTCM", "ITLTCM", JdeDataType.Numeric),
        new JdeField("ITANPL", "ITANPL", JdeDataType.Numeric),
        new JdeField("ITOPC", "ITOPC", JdeDataType.String, 2),
        new JdeField("ITOPV", "ITOPV", JdeDataType.Numeric),
        new JdeField("ITACQ", "ITACQ", JdeDataType.Numeric),
        new JdeField("ITMLQ", "ITMLQ", JdeDataType.Numeric),
        new JdeField("ITLLX", "ITLLX", JdeDataType.Numeric),
        new JdeField("ITLTPU", "ITLTPU", JdeDataType.Numeric),
        new JdeField("ITMPST", "ITMPST", JdeDataType.String, 2),
        new JdeField("ITMPSP", "ITMPSP", JdeDataType.String, 2),
        new JdeField("ITMRPP", "ITMRPP", JdeDataType.String, 2),
        new JdeField("ITSLD", "ITSLD", JdeDataType.Numeric),
        new JdeField("ITITC", "ITITC", JdeDataType.String, 2),
        new JdeField("ITSNS", "ITSNS", JdeDataType.String, 2),
        new JdeField("ITPCTM", "ITPCTM", JdeDataType.Numeric),
        new JdeField("ITMMPC", "ITMMPC", JdeDataType.Numeric),
        new JdeField("ITCDCD", "ITCDCD", JdeDataType.String, 30),
        new JdeField("ITSTDP", "ITSTDP", JdeDataType.Numeric),
        new JdeField("ITFRMP", "ITFRMP", JdeDataType.Numeric),
        new JdeField("ITCOTY", "ITCOTY", JdeDataType.String, 2),
        new JdeField("ITTHRP", "ITTHRP", JdeDataType.Numeric),
        new JdeField("ITOT1Y", "ITOT1Y", JdeDataType.String, 2),
        new JdeField("ITOT2Y", "ITOT2Y", JdeDataType.String, 2),
        new JdeField("ITFRGD", "ITFRGD", JdeDataType.String, 6),
        new JdeField("ITTHGD", "ITTHGD", JdeDataType.String, 6),
        new JdeField("ITSTDG", "ITSTDG", JdeDataType.String, 6),
        new JdeField("ITORDW", "ITORDW", JdeDataType.String, 2),
        new JdeField("ITMTF1", "ITMTF1", JdeDataType.Numeric),
        new JdeField("ITMTF2", "ITMTF2", JdeDataType.Numeric),
        new JdeField("ITMTF3", "ITMTF3", JdeDataType.Numeric),
        new JdeField("ITMTF4", "ITMTF4", JdeDataType.Numeric),
        new JdeField("ITMTF5", "ITMTF5", JdeDataType.Numeric),
        new JdeField("ITEXPD", "ITEXPD", JdeDataType.Numeric),
        new JdeField("ITDEFD", "ITDEFD", JdeDataType.Numeric),
        new JdeField("ITSFLT", "ITSFLT", JdeDataType.Numeric),
        new JdeField("ITMAKE", "ITMAKE", JdeDataType.String, 2),
        new JdeField("ITSRCE", "ITSRCE", JdeDataType.String, 2),
        new JdeField("ITPBIN", "ITPBIN", JdeDataType.String, 2),
        new JdeField("ITPQOH", "ITPQOH", JdeDataType.Numeric),
        new JdeField("ITPBCK", "ITPBCK", JdeDataType.Numeric),
        new JdeField("ITPREQ", "ITPREQ", JdeDataType.Numeric),
        new JdeField("ITQWBO", "ITQWBO", JdeDataType.Numeric),
        new JdeField("ITOT1P", "ITOT1P", JdeDataType.Numeric),
        new JdeField("ITOT2P", "ITOT2P", JdeDataType.Numeric),
        new JdeField("ITOT1A", "ITOT1A", JdeDataType.Numeric),
        new JdeField("ITHCOM", "ITHCOM", JdeDataType.Numeric),
        new JdeField("ITPCOM", "ITPCOM", JdeDataType.Numeric),
        new JdeField("ITFCOM", "ITFCOM", JdeDataType.Numeric),
        new JdeField("ITFUN1", "ITFUN1", JdeDataType.Numeric),
        new JdeField("ITQOWO", "ITQOWO", JdeDataType.Numeric),
        new JdeField("ITQTTR", "ITQTTR", JdeDataType.Numeric),
        new JdeField("ITQTIN", "ITQTIN", JdeDataType.Numeric),
        new JdeField("ITQTO1", "ITQTO1", JdeDataType.Numeric),
        new JdeField("ITQTO2", "ITQTO2", JdeDataType.Numeric),
        new JdeField("ITQONL", "ITQONL", JdeDataType.Numeric),
        new JdeField("ITQTRI", "ITQTRI", JdeDataType.Numeric),
        new JdeField("ITQTRO", "ITQTRO", JdeDataType.Numeric),
        new JdeField("ITQTY1", "ITQTY1", JdeDataType.Numeric),
        new JdeField("ITQTY2", "ITQTY2", JdeDataType.Numeric),
        new JdeField("ITLRCJ", "ITLRCJ", JdeDataType.Numeric),
        new JdeField("ITNCDJ", "ITNCDJ", JdeDataType.Numeric),
        new JdeField("ITURCD", "ITURCD", JdeDataType.String, 4),
        new JdeField("ITURDT", "ITURDT", JdeDataType.Numeric),
        new JdeField("ITURAT", "ITURAT", JdeDataType.Numeric),
        new JdeField("ITURAB", "ITURAB", JdeDataType.Numeric),
        new JdeField("ITURRF", "ITURRF", JdeDataType.String, 30),
        new JdeField("ITLDSC", "ITLDSC", JdeDataType.String, 60),
        new JdeField("ITMMEJ", "ITMMEJ", JdeDataType.Numeric),
        new JdeField("ITPN", "ITPN", JdeDataType.Numeric),
        new JdeField("ITFY", "ITFY", JdeDataType.Numeric),
        new JdeField("ITDSC1", "ITDSC1", JdeDataType.String, 60),
        new JdeField("ITCLEV", "ITCLEV", JdeDataType.String, 2),
        new JdeField("ITPLEV", "ITPLEV", JdeDataType.String, 2),
        new JdeField("ITUOM1", "ITUOM1", JdeDataType.String, 4),
        new JdeField("ITLEDG", "ITLEDG", JdeDataType.String, 4),
        new JdeField("ITANI", "ITANI", JdeDataType.String, 58),
        new JdeField("ITSBL", "ITSBL", JdeDataType.String, 16),
        new JdeField("ITSBLT", "ITSBLT", JdeDataType.String, 2),
        new JdeField("ITWR01", "ITWR01", JdeDataType.String, 8),
        new JdeField("ITASII", "ITASII", JdeDataType.String, 52),
        new JdeField("ITICOS", "ITICOS", JdeDataType.Numeric),
        new JdeField("ITLQOH", "ITLQOH", JdeDataType.Numeric),
        new JdeField("ITTQOH", "ITTQOH", JdeDataType.Numeric),
        new JdeField("ITTVIA", "ITTVIA", JdeDataType.Numeric),
        new JdeField("ITLINN", "ITLINN", JdeDataType.Numeric),
        new JdeField("ITVARA", "ITVARA", JdeDataType.Numeric),
        new JdeField("ITCSMT", "ITCSMT", JdeDataType.String, 4),
        new JdeField("ITPCSM", "ITPCSM", JdeDataType.String, 4),
        new JdeField("ITCSMF", "ITCSMF", JdeDataType.String, 4),
        new JdeField("ITPCSF", "ITPCSF", JdeDataType.String, 4),
        new JdeField("ITABRN", "ITABRN", JdeDataType.String, 2),
        new JdeField("ITALON", "ITALON", JdeDataType.String, 2),
        new JdeField("ITACOS", "ITACOS", JdeDataType.String, 2),
        new JdeField("ITAPRI", "ITAPRI", JdeDataType.String, 2),
        new JdeField("ITRLOT", "ITRLOT", JdeDataType.String, 60),
        new JdeField("ITLOT1", "ITLOT1", JdeDataType.String, 60),
        new JdeField("ITLOT2", "ITLOT2", JdeDataType.String, 60),
        new JdeField("ITLOT3", "ITLOT3", JdeDataType.String, 60),
        new JdeField("ITMCUF", "ITMCUF", JdeDataType.String, 24),
        new JdeField("ITLOTF", "ITLOTF", JdeDataType.String, 60),
        new JdeField("ITLOCF", "ITLOCF", JdeDataType.String, 40),
        new JdeField("ITFTRN", "ITFTRN", JdeDataType.String, 2),
        new JdeField("ITENTC", "ITENTC", JdeDataType.String, 2),
        new JdeField("ITAEXP", "ITAEXP", JdeDataType.Numeric),
        new JdeField("ITCYNO", "ITCYNO", JdeDataType.Numeric),
        new JdeField("ITTGG", "ITTGG", JdeDataType.Numeric),
        new JdeField("ITSLAT", "ITSLAT", JdeDataType.Numeric),
        new JdeField("ITSDCT", "ITSDCT", JdeDataType.String, 4),
        new JdeField("ITJEL1", "ITJEL1", JdeDataType.Numeric),
        new JdeField("ITJEL2", "ITJEL2", JdeDataType.Numeric),
        new JdeField("ITJEL3", "ITJEL3", JdeDataType.Numeric),
        new JdeField("ITJEL4", "ITJEL4", JdeDataType.Numeric),
        new JdeField("ITJEL5", "ITJEL5", JdeDataType.Numeric),
        new JdeField("ITJEL6", "ITJEL6", JdeDataType.Numeric),
        new JdeField("ITVUIL", "ITVUIL", JdeDataType.String, 2),
        new JdeField("ITBPFG", "ITBPFG", JdeDataType.String, 2),
        new JdeField("ITOT5Y", "ITOT5Y", JdeDataType.String, 2),
        new JdeField("ITAGSQ", "ITAGSQ", JdeDataType.Numeric),
        new JdeField("ITMODE", "ITMODE", JdeDataType.String, 2),
        new JdeField("ITDTO", "ITDTO", JdeDataType.String, 2),
        new JdeField("ITPSR", "ITPSR", JdeDataType.String, 24),
        new JdeField("ITPSRY", "ITPSRY", JdeDataType.String, 4),
        new JdeField("ITSHAN", "ITSHAN", JdeDataType.Numeric),
        new JdeField("ITDSC2", "ITDSC2", JdeDataType.String, 60),
        new JdeField("ITDUAL", "ITDUAL", JdeDataType.String, 2),
        new JdeField("ITSREQ", "ITSREQ", JdeDataType.Numeric),
        new JdeField("ITSQWO", "ITSQWO", JdeDataType.Numeric),
        new JdeField("ITHCMS", "ITHCMS", JdeDataType.Numeric),
        new JdeField("ITSCMS", "ITSCMS", JdeDataType.Numeric),
        new JdeField("ITSWSC", "ITSWSC", JdeDataType.Numeric),
        new JdeField("ITSWHC", "ITSWHC", JdeDataType.Numeric),
        new JdeField("ITSIBW", "ITSIBW", JdeDataType.Numeric),
        new JdeField("ITSOBW", "ITSOBW", JdeDataType.Numeric),
        new JdeField("ITUOM2", "ITUOM2", JdeDataType.String, 4),
        new JdeField("ITBODJ", "ITBODJ", JdeDataType.Numeric),
        new JdeField("ITOHDJ", "ITOHDJ", JdeDataType.Numeric),
        new JdeField("ITDLEJ", "ITDLEJ", JdeDataType.Numeric),
        new JdeField("ITSBDJ", "ITSBDJ", JdeDataType.Numeric),
        new JdeField("ITBBDJ", "ITBBDJ", JdeDataType.Numeric),
        new JdeField("ITU1DJ", "ITU1DJ", JdeDataType.Numeric),
        new JdeField("ITU2DJ", "ITU2DJ", JdeDataType.Numeric),
        new JdeField("ITU3DJ", "ITU3DJ", JdeDataType.Numeric),
        new JdeField("ITU4DJ", "ITU4DJ", JdeDataType.Numeric),
        new JdeField("ITU5DJ", "ITU5DJ", JdeDataType.Numeric),
        new JdeField("ITLOTC", "ITLOTC", JdeDataType.String, 6),
        new JdeField("ITPJCM", "ITPJCM", JdeDataType.Numeric),
        new JdeField("ITPRJM", "ITPRJM", JdeDataType.Numeric),
        new JdeField("ITCFGSID", "ITCFGSID", JdeDataType.String, 64),
        new JdeField("ITPJDM", "ITPJDM", JdeDataType.Numeric),
        new JdeField("ITCCFL", "ITCCFL", JdeDataType.String, 2),
        new JdeField("ITDOC1", "ITDOC1", JdeDataType.Numeric),
        new JdeField("ITCONV", "ITCONV", JdeDataType.Numeric),
        new JdeField("ITCNV1", "ITCNV1", JdeDataType.Numeric),
        new JdeField("ITJEL7", "ITJEL7", JdeDataType.Numeric),
        new JdeField("ITJEL8", "ITJEL8", JdeDataType.Numeric),
        new JdeField("ITTGN", "ITTGN", JdeDataType.Numeric),
        new JdeField("ITRFLN", "ITRFLN", JdeDataType.Numeric),
        new JdeField("ITORIG", "ITORIG", JdeDataType.String, 6),
        new JdeField("ITOILNTY", "ITOILNTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41UI001_0", "Primary Key on ITCTID, ITJOBS, ITLNID, ITNLIN, ITDCTO, ITDOCO, ITKCOO, ITSFXO", new[] { "ITCTID", "ITJOBS", "ITLNID", "ITNLIN", "ITDCTO", "ITDOCO", "ITKCOO", "ITSFXO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41UI001_2", "Index on ITJOBS", new[] { "ITJOBS" })
    };
}
