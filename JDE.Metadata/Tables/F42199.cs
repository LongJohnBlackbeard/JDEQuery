using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42199 - .
/// </summary>
public class F42199 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SLKCOO.
        /// </summary>
        public const string SLKCOO = "SLKCOO";

        /// <summary>
        /// SLDOCO.
        /// </summary>
        public const string SLDOCO = "SLDOCO";

        /// <summary>
        /// SLDCTO.
        /// </summary>
        public const string SLDCTO = "SLDCTO";

        /// <summary>
        /// SLLNID.
        /// </summary>
        public const string SLLNID = "SLLNID";

        /// <summary>
        /// SLSFXO.
        /// </summary>
        public const string SLSFXO = "SLSFXO";

        /// <summary>
        /// SLMCU.
        /// </summary>
        public const string SLMCU = "SLMCU";

        /// <summary>
        /// SLCO.
        /// </summary>
        public const string SLCO = "SLCO";

        /// <summary>
        /// SLOKCO.
        /// </summary>
        public const string SLOKCO = "SLOKCO";

        /// <summary>
        /// SLOORN.
        /// </summary>
        public const string SLOORN = "SLOORN";

        /// <summary>
        /// SLOCTO.
        /// </summary>
        public const string SLOCTO = "SLOCTO";

        /// <summary>
        /// SLOGNO.
        /// </summary>
        public const string SLOGNO = "SLOGNO";

        /// <summary>
        /// SLRKCO.
        /// </summary>
        public const string SLRKCO = "SLRKCO";

        /// <summary>
        /// SLRORN.
        /// </summary>
        public const string SLRORN = "SLRORN";

        /// <summary>
        /// SLRCTO.
        /// </summary>
        public const string SLRCTO = "SLRCTO";

        /// <summary>
        /// SLRLLN.
        /// </summary>
        public const string SLRLLN = "SLRLLN";

        /// <summary>
        /// SLDMCT.
        /// </summary>
        public const string SLDMCT = "SLDMCT";

        /// <summary>
        /// SLDMCS.
        /// </summary>
        public const string SLDMCS = "SLDMCS";

        /// <summary>
        /// SLAN8.
        /// </summary>
        public const string SLAN8 = "SLAN8";

        /// <summary>
        /// SLSHAN.
        /// </summary>
        public const string SLSHAN = "SLSHAN";

        /// <summary>
        /// SLPA8.
        /// </summary>
        public const string SLPA8 = "SLPA8";

        /// <summary>
        /// SLDRQJ.
        /// </summary>
        public const string SLDRQJ = "SLDRQJ";

        /// <summary>
        /// SLTRDJ.
        /// </summary>
        public const string SLTRDJ = "SLTRDJ";

        /// <summary>
        /// SLPDDJ.
        /// </summary>
        public const string SLPDDJ = "SLPDDJ";

        /// <summary>
        /// SLADDJ.
        /// </summary>
        public const string SLADDJ = "SLADDJ";

        /// <summary>
        /// SLIVD.
        /// </summary>
        public const string SLIVD = "SLIVD";

        /// <summary>
        /// SLCNDJ.
        /// </summary>
        public const string SLCNDJ = "SLCNDJ";

        /// <summary>
        /// SLDGL.
        /// </summary>
        public const string SLDGL = "SLDGL";

        /// <summary>
        /// SLRSDJ.
        /// </summary>
        public const string SLRSDJ = "SLRSDJ";

        /// <summary>
        /// SLPEFJ.
        /// </summary>
        public const string SLPEFJ = "SLPEFJ";

        /// <summary>
        /// SLPPDJ.
        /// </summary>
        public const string SLPPDJ = "SLPPDJ";

        /// <summary>
        /// SLVR01.
        /// </summary>
        public const string SLVR01 = "SLVR01";

        /// <summary>
        /// SLVR02.
        /// </summary>
        public const string SLVR02 = "SLVR02";

        /// <summary>
        /// SLITM.
        /// </summary>
        public const string SLITM = "SLITM";

        /// <summary>
        /// SLLITM.
        /// </summary>
        public const string SLLITM = "SLLITM";

        /// <summary>
        /// SLAITM.
        /// </summary>
        public const string SLAITM = "SLAITM";

        /// <summary>
        /// SLLOCN.
        /// </summary>
        public const string SLLOCN = "SLLOCN";

        /// <summary>
        /// SLLOTN.
        /// </summary>
        public const string SLLOTN = "SLLOTN";

        /// <summary>
        /// SLFRGD.
        /// </summary>
        public const string SLFRGD = "SLFRGD";

        /// <summary>
        /// SLTHGD.
        /// </summary>
        public const string SLTHGD = "SLTHGD";

        /// <summary>
        /// SLFRMP.
        /// </summary>
        public const string SLFRMP = "SLFRMP";

        /// <summary>
        /// SLTHRP.
        /// </summary>
        public const string SLTHRP = "SLTHRP";

        /// <summary>
        /// SLEXDP.
        /// </summary>
        public const string SLEXDP = "SLEXDP";

        /// <summary>
        /// SLDSC1.
        /// </summary>
        public const string SLDSC1 = "SLDSC1";

        /// <summary>
        /// SLDSC2.
        /// </summary>
        public const string SLDSC2 = "SLDSC2";

        /// <summary>
        /// SLLNTY.
        /// </summary>
        public const string SLLNTY = "SLLNTY";

        /// <summary>
        /// SLNXTR.
        /// </summary>
        public const string SLNXTR = "SLNXTR";

        /// <summary>
        /// SLLTTR.
        /// </summary>
        public const string SLLTTR = "SLLTTR";

        /// <summary>
        /// SLEMCU.
        /// </summary>
        public const string SLEMCU = "SLEMCU";

        /// <summary>
        /// SLRLIT.
        /// </summary>
        public const string SLRLIT = "SLRLIT";

        /// <summary>
        /// SLKTLN.
        /// </summary>
        public const string SLKTLN = "SLKTLN";

        /// <summary>
        /// SLCPNT.
        /// </summary>
        public const string SLCPNT = "SLCPNT";

        /// <summary>
        /// SLRKIT.
        /// </summary>
        public const string SLRKIT = "SLRKIT";

        /// <summary>
        /// SLKTP.
        /// </summary>
        public const string SLKTP = "SLKTP";

        /// <summary>
        /// SLSRP1.
        /// </summary>
        public const string SLSRP1 = "SLSRP1";

        /// <summary>
        /// SLSRP2.
        /// </summary>
        public const string SLSRP2 = "SLSRP2";

        /// <summary>
        /// SLSRP3.
        /// </summary>
        public const string SLSRP3 = "SLSRP3";

        /// <summary>
        /// SLSRP4.
        /// </summary>
        public const string SLSRP4 = "SLSRP4";

        /// <summary>
        /// SLSRP5.
        /// </summary>
        public const string SLSRP5 = "SLSRP5";

        /// <summary>
        /// SLPRP1.
        /// </summary>
        public const string SLPRP1 = "SLPRP1";

        /// <summary>
        /// SLPRP2.
        /// </summary>
        public const string SLPRP2 = "SLPRP2";

        /// <summary>
        /// SLPRP3.
        /// </summary>
        public const string SLPRP3 = "SLPRP3";

        /// <summary>
        /// SLPRP4.
        /// </summary>
        public const string SLPRP4 = "SLPRP4";

        /// <summary>
        /// SLPRP5.
        /// </summary>
        public const string SLPRP5 = "SLPRP5";

        /// <summary>
        /// SLUOM.
        /// </summary>
        public const string SLUOM = "SLUOM";

        /// <summary>
        /// SLUORG.
        /// </summary>
        public const string SLUORG = "SLUORG";

        /// <summary>
        /// SLSOQS.
        /// </summary>
        public const string SLSOQS = "SLSOQS";

        /// <summary>
        /// SLSOBK.
        /// </summary>
        public const string SLSOBK = "SLSOBK";

        /// <summary>
        /// SLSOCN.
        /// </summary>
        public const string SLSOCN = "SLSOCN";

        /// <summary>
        /// SLSONE.
        /// </summary>
        public const string SLSONE = "SLSONE";

        /// <summary>
        /// SLUOPN.
        /// </summary>
        public const string SLUOPN = "SLUOPN";

        /// <summary>
        /// SLQTYT.
        /// </summary>
        public const string SLQTYT = "SLQTYT";

        /// <summary>
        /// SLQRLV.
        /// </summary>
        public const string SLQRLV = "SLQRLV";

        /// <summary>
        /// SLCOMM.
        /// </summary>
        public const string SLCOMM = "SLCOMM";

        /// <summary>
        /// SLOTQY.
        /// </summary>
        public const string SLOTQY = "SLOTQY";

        /// <summary>
        /// SLUPRC.
        /// </summary>
        public const string SLUPRC = "SLUPRC";

        /// <summary>
        /// SLAEXP.
        /// </summary>
        public const string SLAEXP = "SLAEXP";

        /// <summary>
        /// SLAOPN.
        /// </summary>
        public const string SLAOPN = "SLAOPN";

        /// <summary>
        /// SLPROV.
        /// </summary>
        public const string SLPROV = "SLPROV";

        /// <summary>
        /// SLTPC.
        /// </summary>
        public const string SLTPC = "SLTPC";

        /// <summary>
        /// SLAPUM.
        /// </summary>
        public const string SLAPUM = "SLAPUM";

        /// <summary>
        /// SLLPRC.
        /// </summary>
        public const string SLLPRC = "SLLPRC";

        /// <summary>
        /// SLUNCS.
        /// </summary>
        public const string SLUNCS = "SLUNCS";

        /// <summary>
        /// SLECST.
        /// </summary>
        public const string SLECST = "SLECST";

        /// <summary>
        /// SLCSTO.
        /// </summary>
        public const string SLCSTO = "SLCSTO";

        /// <summary>
        /// SLTCST.
        /// </summary>
        public const string SLTCST = "SLTCST";

        /// <summary>
        /// SLINMG.
        /// </summary>
        public const string SLINMG = "SLINMG";

        /// <summary>
        /// SLPTC.
        /// </summary>
        public const string SLPTC = "SLPTC";

        /// <summary>
        /// SLRYIN.
        /// </summary>
        public const string SLRYIN = "SLRYIN";

        /// <summary>
        /// SLDTBS.
        /// </summary>
        public const string SLDTBS = "SLDTBS";

        /// <summary>
        /// SLTRDC.
        /// </summary>
        public const string SLTRDC = "SLTRDC";

        /// <summary>
        /// SLFUN2.
        /// </summary>
        public const string SLFUN2 = "SLFUN2";

        /// <summary>
        /// SLASN.
        /// </summary>
        public const string SLASN = "SLASN";

        /// <summary>
        /// SLPRGR.
        /// </summary>
        public const string SLPRGR = "SLPRGR";

        /// <summary>
        /// SLCLVL.
        /// </summary>
        public const string SLCLVL = "SLCLVL";

        /// <summary>
        /// SLCADC.
        /// </summary>
        public const string SLCADC = "SLCADC";

        /// <summary>
        /// SLKCO.
        /// </summary>
        public const string SLKCO = "SLKCO";

        /// <summary>
        /// SLDOC.
        /// </summary>
        public const string SLDOC = "SLDOC";

        /// <summary>
        /// SLDCT.
        /// </summary>
        public const string SLDCT = "SLDCT";

        /// <summary>
        /// SLODOC.
        /// </summary>
        public const string SLODOC = "SLODOC";

        /// <summary>
        /// SLODCT.
        /// </summary>
        public const string SLODCT = "SLODCT";

        /// <summary>
        /// SLOKC.
        /// </summary>
        public const string SLOKC = "SLOKC";

        /// <summary>
        /// SLPSN.
        /// </summary>
        public const string SLPSN = "SLPSN";

        /// <summary>
        /// SLDELN.
        /// </summary>
        public const string SLDELN = "SLDELN";

        /// <summary>
        /// SLTAX1.
        /// </summary>
        public const string SLTAX1 = "SLTAX1";

        /// <summary>
        /// SLTXA1.
        /// </summary>
        public const string SLTXA1 = "SLTXA1";

        /// <summary>
        /// SLEXR1.
        /// </summary>
        public const string SLEXR1 = "SLEXR1";

        /// <summary>
        /// SLATXT.
        /// </summary>
        public const string SLATXT = "SLATXT";

        /// <summary>
        /// SLPRIO.
        /// </summary>
        public const string SLPRIO = "SLPRIO";

        /// <summary>
        /// SLRESL.
        /// </summary>
        public const string SLRESL = "SLRESL";

        /// <summary>
        /// SLBACK.
        /// </summary>
        public const string SLBACK = "SLBACK";

        /// <summary>
        /// SLSBAL.
        /// </summary>
        public const string SLSBAL = "SLSBAL";

        /// <summary>
        /// SLAPTS.
        /// </summary>
        public const string SLAPTS = "SLAPTS";

        /// <summary>
        /// SLLOB.
        /// </summary>
        public const string SLLOB = "SLLOB";

        /// <summary>
        /// SLEUSE.
        /// </summary>
        public const string SLEUSE = "SLEUSE";

        /// <summary>
        /// SLDTYS.
        /// </summary>
        public const string SLDTYS = "SLDTYS";

        /// <summary>
        /// SLNTR.
        /// </summary>
        public const string SLNTR = "SLNTR";

        /// <summary>
        /// SLVEND.
        /// </summary>
        public const string SLVEND = "SLVEND";

        /// <summary>
        /// SLCARS.
        /// </summary>
        public const string SLCARS = "SLCARS";

        /// <summary>
        /// SLMOT.
        /// </summary>
        public const string SLMOT = "SLMOT";

        /// <summary>
        /// SLROUT.
        /// </summary>
        public const string SLROUT = "SLROUT";

        /// <summary>
        /// SLSTOP.
        /// </summary>
        public const string SLSTOP = "SLSTOP";

        /// <summary>
        /// SLZON.
        /// </summary>
        public const string SLZON = "SLZON";

        /// <summary>
        /// SLCNID.
        /// </summary>
        public const string SLCNID = "SLCNID";

        /// <summary>
        /// SLFRTH.
        /// </summary>
        public const string SLFRTH = "SLFRTH";

        /// <summary>
        /// SLSHCM.
        /// </summary>
        public const string SLSHCM = "SLSHCM";

        /// <summary>
        /// SLSHCN.
        /// </summary>
        public const string SLSHCN = "SLSHCN";

        /// <summary>
        /// SLSERN.
        /// </summary>
        public const string SLSERN = "SLSERN";

        /// <summary>
        /// SLUOM1.
        /// </summary>
        public const string SLUOM1 = "SLUOM1";

        /// <summary>
        /// SLPQOR.
        /// </summary>
        public const string SLPQOR = "SLPQOR";

        /// <summary>
        /// SLUOM2.
        /// </summary>
        public const string SLUOM2 = "SLUOM2";

        /// <summary>
        /// SLSQOR.
        /// </summary>
        public const string SLSQOR = "SLSQOR";

        /// <summary>
        /// SLUOM4.
        /// </summary>
        public const string SLUOM4 = "SLUOM4";

        /// <summary>
        /// SLITWT.
        /// </summary>
        public const string SLITWT = "SLITWT";

        /// <summary>
        /// SLWTUM.
        /// </summary>
        public const string SLWTUM = "SLWTUM";

        /// <summary>
        /// SLITVL.
        /// </summary>
        public const string SLITVL = "SLITVL";

        /// <summary>
        /// SLVLUM.
        /// </summary>
        public const string SLVLUM = "SLVLUM";

        /// <summary>
        /// SLRPRC.
        /// </summary>
        public const string SLRPRC = "SLRPRC";

        /// <summary>
        /// SLORPR.
        /// </summary>
        public const string SLORPR = "SLORPR";

        /// <summary>
        /// SLORP.
        /// </summary>
        public const string SLORP = "SLORP";

        /// <summary>
        /// SLCMGP.
        /// </summary>
        public const string SLCMGP = "SLCMGP";

        /// <summary>
        /// SLGLC.
        /// </summary>
        public const string SLGLC = "SLGLC";

        /// <summary>
        /// SLCTRY.
        /// </summary>
        public const string SLCTRY = "SLCTRY";

        /// <summary>
        /// SLFY.
        /// </summary>
        public const string SLFY = "SLFY";

        /// <summary>
        /// SLSO01.
        /// </summary>
        public const string SLSO01 = "SLSO01";

        /// <summary>
        /// SLSO02.
        /// </summary>
        public const string SLSO02 = "SLSO02";

        /// <summary>
        /// SLSO03.
        /// </summary>
        public const string SLSO03 = "SLSO03";

        /// <summary>
        /// SLSO04.
        /// </summary>
        public const string SLSO04 = "SLSO04";

        /// <summary>
        /// SLSO05.
        /// </summary>
        public const string SLSO05 = "SLSO05";

        /// <summary>
        /// SLSO06.
        /// </summary>
        public const string SLSO06 = "SLSO06";

        /// <summary>
        /// SLSO07.
        /// </summary>
        public const string SLSO07 = "SLSO07";

        /// <summary>
        /// SLSO08.
        /// </summary>
        public const string SLSO08 = "SLSO08";

        /// <summary>
        /// SLSO09.
        /// </summary>
        public const string SLSO09 = "SLSO09";

        /// <summary>
        /// SLSO10.
        /// </summary>
        public const string SLSO10 = "SLSO10";

        /// <summary>
        /// SLSO11.
        /// </summary>
        public const string SLSO11 = "SLSO11";

        /// <summary>
        /// SLSO12.
        /// </summary>
        public const string SLSO12 = "SLSO12";

        /// <summary>
        /// SLSO13.
        /// </summary>
        public const string SLSO13 = "SLSO13";

        /// <summary>
        /// SLSO14.
        /// </summary>
        public const string SLSO14 = "SLSO14";

        /// <summary>
        /// SLSO15.
        /// </summary>
        public const string SLSO15 = "SLSO15";

        /// <summary>
        /// SLACOM.
        /// </summary>
        public const string SLACOM = "SLACOM";

        /// <summary>
        /// SLCMCG.
        /// </summary>
        public const string SLCMCG = "SLCMCG";

        /// <summary>
        /// SLRCD.
        /// </summary>
        public const string SLRCD = "SLRCD";

        /// <summary>
        /// SLGRWT.
        /// </summary>
        public const string SLGRWT = "SLGRWT";

        /// <summary>
        /// SLGWUM.
        /// </summary>
        public const string SLGWUM = "SLGWUM";

        /// <summary>
        /// SLSBL.
        /// </summary>
        public const string SLSBL = "SLSBL";

        /// <summary>
        /// SLSBLT.
        /// </summary>
        public const string SLSBLT = "SLSBLT";

        /// <summary>
        /// SLLCOD.
        /// </summary>
        public const string SLLCOD = "SLLCOD";

        /// <summary>
        /// SLUPC1.
        /// </summary>
        public const string SLUPC1 = "SLUPC1";

        /// <summary>
        /// SLUPC2.
        /// </summary>
        public const string SLUPC2 = "SLUPC2";

        /// <summary>
        /// SLUPC3.
        /// </summary>
        public const string SLUPC3 = "SLUPC3";

        /// <summary>
        /// SLSWMS.
        /// </summary>
        public const string SLSWMS = "SLSWMS";

        /// <summary>
        /// SLUNCD.
        /// </summary>
        public const string SLUNCD = "SLUNCD";

        /// <summary>
        /// SLCRMD.
        /// </summary>
        public const string SLCRMD = "SLCRMD";

        /// <summary>
        /// SLCRCD.
        /// </summary>
        public const string SLCRCD = "SLCRCD";

        /// <summary>
        /// SLCRR.
        /// </summary>
        public const string SLCRR = "SLCRR";

        /// <summary>
        /// SLFPRC.
        /// </summary>
        public const string SLFPRC = "SLFPRC";

        /// <summary>
        /// SLFUP.
        /// </summary>
        public const string SLFUP = "SLFUP";

        /// <summary>
        /// SLFEA.
        /// </summary>
        public const string SLFEA = "SLFEA";

        /// <summary>
        /// SLFUC.
        /// </summary>
        public const string SLFUC = "SLFUC";

        /// <summary>
        /// SLFEC.
        /// </summary>
        public const string SLFEC = "SLFEC";

        /// <summary>
        /// SLURCD.
        /// </summary>
        public const string SLURCD = "SLURCD";

        /// <summary>
        /// SLURDT.
        /// </summary>
        public const string SLURDT = "SLURDT";

        /// <summary>
        /// SLURAT.
        /// </summary>
        public const string SLURAT = "SLURAT";

        /// <summary>
        /// SLURAB.
        /// </summary>
        public const string SLURAB = "SLURAB";

        /// <summary>
        /// SLURRF.
        /// </summary>
        public const string SLURRF = "SLURRF";

        /// <summary>
        /// SLTORG.
        /// </summary>
        public const string SLTORG = "SLTORG";

        /// <summary>
        /// SLUSER.
        /// </summary>
        public const string SLUSER = "SLUSER";

        /// <summary>
        /// SLPID.
        /// </summary>
        public const string SLPID = "SLPID";

        /// <summary>
        /// SLJOBN.
        /// </summary>
        public const string SLJOBN = "SLJOBN";

        /// <summary>
        /// SLUPMJ.
        /// </summary>
        public const string SLUPMJ = "SLUPMJ";

        /// <summary>
        /// SLTDAY.
        /// </summary>
        public const string SLTDAY = "SLTDAY";

        /// <summary>
        /// SLSO16.
        /// </summary>
        public const string SLSO16 = "SLSO16";

        /// <summary>
        /// SLSO17.
        /// </summary>
        public const string SLSO17 = "SLSO17";

        /// <summary>
        /// SLSO18.
        /// </summary>
        public const string SLSO18 = "SLSO18";

        /// <summary>
        /// SLSO19.
        /// </summary>
        public const string SLSO19 = "SLSO19";

        /// <summary>
        /// SLSO20.
        /// </summary>
        public const string SLSO20 = "SLSO20";

        /// <summary>
        /// SLIR01.
        /// </summary>
        public const string SLIR01 = "SLIR01";

        /// <summary>
        /// SLIR02.
        /// </summary>
        public const string SLIR02 = "SLIR02";

        /// <summary>
        /// SLIR03.
        /// </summary>
        public const string SLIR03 = "SLIR03";

        /// <summary>
        /// SLIR04.
        /// </summary>
        public const string SLIR04 = "SLIR04";

        /// <summary>
        /// SLIR05.
        /// </summary>
        public const string SLIR05 = "SLIR05";

        /// <summary>
        /// SLSOOR.
        /// </summary>
        public const string SLSOOR = "SLSOOR";

        /// <summary>
        /// SLVR03.
        /// </summary>
        public const string SLVR03 = "SLVR03";

        /// <summary>
        /// SLDEID.
        /// </summary>
        public const string SLDEID = "SLDEID";

        /// <summary>
        /// SLPSIG.
        /// </summary>
        public const string SLPSIG = "SLPSIG";

        /// <summary>
        /// SLRLNU.
        /// </summary>
        public const string SLRLNU = "SLRLNU";

        /// <summary>
        /// SLPMDT.
        /// </summary>
        public const string SLPMDT = "SLPMDT";

        /// <summary>
        /// SLRLTM.
        /// </summary>
        public const string SLRLTM = "SLRLTM";

        /// <summary>
        /// SLRLDJ.
        /// </summary>
        public const string SLRLDJ = "SLRLDJ";

        /// <summary>
        /// SLDRQT.
        /// </summary>
        public const string SLDRQT = "SLDRQT";

        /// <summary>
        /// SLADTM.
        /// </summary>
        public const string SLADTM = "SLADTM";

        /// <summary>
        /// SLOPTT.
        /// </summary>
        public const string SLOPTT = "SLOPTT";

        /// <summary>
        /// SLPDTT.
        /// </summary>
        public const string SLPDTT = "SLPDTT";

        /// <summary>
        /// SLPSTM.
        /// </summary>
        public const string SLPSTM = "SLPSTM";

        /// <summary>
        /// SLXDCK.
        /// </summary>
        public const string SLXDCK = "SLXDCK";

        /// <summary>
        /// SLXPTY.
        /// </summary>
        public const string SLXPTY = "SLXPTY";

        /// <summary>
        /// SLDUAL.
        /// </summary>
        public const string SLDUAL = "SLDUAL";

        /// <summary>
        /// SLBSC.
        /// </summary>
        public const string SLBSC = "SLBSC";

        /// <summary>
        /// SLCBSC.
        /// </summary>
        public const string SLCBSC = "SLCBSC";

        /// <summary>
        /// SLCORD.
        /// </summary>
        public const string SLCORD = "SLCORD";

        /// <summary>
        /// SLDVAN.
        /// </summary>
        public const string SLDVAN = "SLDVAN";

        /// <summary>
        /// SLPEND.
        /// </summary>
        public const string SLPEND = "SLPEND";

        /// <summary>
        /// SLRFRV.
        /// </summary>
        public const string SLRFRV = "SLRFRV";

        /// <summary>
        /// SLMCLN.
        /// </summary>
        public const string SLMCLN = "SLMCLN";

        /// <summary>
        /// SLSHPN.
        /// </summary>
        public const string SLSHPN = "SLSHPN";

        /// <summary>
        /// SLRSDT.
        /// </summary>
        public const string SLRSDT = "SLRSDT";

        /// <summary>
        /// SLPRJM.
        /// </summary>
        public const string SLPRJM = "SLPRJM";

        /// <summary>
        /// SLOSEQ.
        /// </summary>
        public const string SLOSEQ = "SLOSEQ";

        /// <summary>
        /// SLMERL.
        /// </summary>
        public const string SLMERL = "SLMERL";

        /// <summary>
        /// SLHOLD.
        /// </summary>
        public const string SLHOLD = "SLHOLD";

        /// <summary>
        /// SLHDBU.
        /// </summary>
        public const string SLHDBU = "SLHDBU";

        /// <summary>
        /// SLDMBU.
        /// </summary>
        public const string SLDMBU = "SLDMBU";

        /// <summary>
        /// SLBCRC.
        /// </summary>
        public const string SLBCRC = "SLBCRC";

        /// <summary>
        /// SLODLN.
        /// </summary>
        public const string SLODLN = "SLODLN";

        /// <summary>
        /// SLOPDJ.
        /// </summary>
        public const string SLOPDJ = "SLOPDJ";

        /// <summary>
        /// SLXKCO.
        /// </summary>
        public const string SLXKCO = "SLXKCO";

        /// <summary>
        /// SLXORN.
        /// </summary>
        public const string SLXORN = "SLXORN";

        /// <summary>
        /// SLXCTO.
        /// </summary>
        public const string SLXCTO = "SLXCTO";

        /// <summary>
        /// SLXLLN.
        /// </summary>
        public const string SLXLLN = "SLXLLN";

        /// <summary>
        /// SLXSFX.
        /// </summary>
        public const string SLXSFX = "SLXSFX";

        /// <summary>
        /// SLPOE.
        /// </summary>
        public const string SLPOE = "SLPOE";

        /// <summary>
        /// SLPMTO.
        /// </summary>
        public const string SLPMTO = "SLPMTO";

        /// <summary>
        /// SLANBY.
        /// </summary>
        public const string SLANBY = "SLANBY";

        /// <summary>
        /// SLPMTN.
        /// </summary>
        public const string SLPMTN = "SLPMTN";

        /// <summary>
        /// SLNUMB.
        /// </summary>
        public const string SLNUMB = "SLNUMB";

        /// <summary>
        /// SLAAID.
        /// </summary>
        public const string SLAAID = "SLAAID";

        /// <summary>
        /// SLPRAN8.
        /// </summary>
        public const string SLPRAN8 = "SLPRAN8";

        /// <summary>
        /// SLSPATTN.
        /// </summary>
        public const string SLSPATTN = "SLSPATTN";

        /// <summary>
        /// SLPRCIDLN.
        /// </summary>
        public const string SLPRCIDLN = "SLPRCIDLN";

        /// <summary>
        /// SLCCIDLN.
        /// </summary>
        public const string SLCCIDLN = "SLCCIDLN";

        /// <summary>
        /// SLSHCCIDLN.
        /// </summary>
        public const string SLSHCCIDLN = "SLSHCCIDLN";

        /// <summary>
        /// SLOPPID.
        /// </summary>
        public const string SLOPPID = "SLOPPID";

        /// <summary>
        /// SLOSTP.
        /// </summary>
        public const string SLOSTP = "SLOSTP";

        /// <summary>
        /// SLUKID.
        /// </summary>
        public const string SLUKID = "SLUKID";

        /// <summary>
        /// SLCATNM.
        /// </summary>
        public const string SLCATNM = "SLCATNM";

        /// <summary>
        /// SLALLOC.
        /// </summary>
        public const string SLALLOC = "SLALLOC";

        /// <summary>
        /// SLFULPID.
        /// </summary>
        public const string SLFULPID = "SLFULPID";

        /// <summary>
        /// SLALLSTS.
        /// </summary>
        public const string SLALLSTS = "SLALLSTS";

        /// <summary>
        /// SLOSCORE.
        /// </summary>
        public const string SLOSCORE = "SLOSCORE";

        /// <summary>
        /// SLOSCOREO.
        /// </summary>
        public const string SLOSCOREO = "SLOSCOREO";

        /// <summary>
        /// SLCMCO.
        /// </summary>
        public const string SLCMCO = "SLCMCO";

        /// <summary>
        /// SLKITID.
        /// </summary>
        public const string SLKITID = "SLKITID";

        /// <summary>
        /// SLKITAMTDOM.
        /// </summary>
        public const string SLKITAMTDOM = "SLKITAMTDOM";

        /// <summary>
        /// SLKITAMTFOR.
        /// </summary>
        public const string SLKITAMTFOR = "SLKITAMTFOR";

        /// <summary>
        /// SLKITDIRTY.
        /// </summary>
        public const string SLKITDIRTY = "SLKITDIRTY";

        /// <summary>
        /// SLOCITT.
        /// </summary>
        public const string SLOCITT = "SLOCITT";

        /// <summary>
        /// SLOCCARDNO.
        /// </summary>
        public const string SLOCCARDNO = "SLOCCARDNO";

        /// <summary>
        /// SLPMPN.
        /// </summary>
        public const string SLPMPN = "SLPMPN";

        /// <summary>
        /// SLPNS.
        /// </summary>
        public const string SLPNS = "SLPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F42199";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SLKCOO", "SLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SLDOCO", "SLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SLDCTO", "SLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SLLNID", "SLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SLSFXO", "SLSFXO", JdeDataType.String, 6),
        new JdeField("SLMCU", "SLMCU", JdeDataType.String, 24),
        new JdeField("SLCO", "SLCO", JdeDataType.String, 10),
        new JdeField("SLOKCO", "SLOKCO", JdeDataType.String, 10),
        new JdeField("SLOORN", "SLOORN", JdeDataType.String, 16),
        new JdeField("SLOCTO", "SLOCTO", JdeDataType.String, 4),
        new JdeField("SLOGNO", "SLOGNO", JdeDataType.Numeric),
        new JdeField("SLRKCO", "SLRKCO", JdeDataType.String, 10),
        new JdeField("SLRORN", "SLRORN", JdeDataType.String, 16),
        new JdeField("SLRCTO", "SLRCTO", JdeDataType.String, 4),
        new JdeField("SLRLLN", "SLRLLN", JdeDataType.Numeric),
        new JdeField("SLDMCT", "SLDMCT", JdeDataType.String, 24),
        new JdeField("SLDMCS", "SLDMCS", JdeDataType.Numeric),
        new JdeField("SLAN8", "SLAN8", JdeDataType.Numeric),
        new JdeField("SLSHAN", "SLSHAN", JdeDataType.Numeric),
        new JdeField("SLPA8", "SLPA8", JdeDataType.Numeric),
        new JdeField("SLDRQJ", "SLDRQJ", JdeDataType.Numeric),
        new JdeField("SLTRDJ", "SLTRDJ", JdeDataType.Numeric),
        new JdeField("SLPDDJ", "SLPDDJ", JdeDataType.Numeric),
        new JdeField("SLADDJ", "SLADDJ", JdeDataType.Numeric),
        new JdeField("SLIVD", "SLIVD", JdeDataType.Numeric),
        new JdeField("SLCNDJ", "SLCNDJ", JdeDataType.Numeric),
        new JdeField("SLDGL", "SLDGL", JdeDataType.Numeric),
        new JdeField("SLRSDJ", "SLRSDJ", JdeDataType.Numeric),
        new JdeField("SLPEFJ", "SLPEFJ", JdeDataType.Numeric),
        new JdeField("SLPPDJ", "SLPPDJ", JdeDataType.Numeric),
        new JdeField("SLVR01", "SLVR01", JdeDataType.String, 50),
        new JdeField("SLVR02", "SLVR02", JdeDataType.String, 50),
        new JdeField("SLITM", "SLITM", JdeDataType.Numeric),
        new JdeField("SLLITM", "SLLITM", JdeDataType.String, 50),
        new JdeField("SLAITM", "SLAITM", JdeDataType.String, 50),
        new JdeField("SLLOCN", "SLLOCN", JdeDataType.String, 40),
        new JdeField("SLLOTN", "SLLOTN", JdeDataType.String, 60),
        new JdeField("SLFRGD", "SLFRGD", JdeDataType.String, 6),
        new JdeField("SLTHGD", "SLTHGD", JdeDataType.String, 6),
        new JdeField("SLFRMP", "SLFRMP", JdeDataType.Numeric),
        new JdeField("SLTHRP", "SLTHRP", JdeDataType.Numeric),
        new JdeField("SLEXDP", "SLEXDP", JdeDataType.Numeric),
        new JdeField("SLDSC1", "SLDSC1", JdeDataType.String, 60),
        new JdeField("SLDSC2", "SLDSC2", JdeDataType.String, 60),
        new JdeField("SLLNTY", "SLLNTY", JdeDataType.String, 4),
        new JdeField("SLNXTR", "SLNXTR", JdeDataType.String, 6),
        new JdeField("SLLTTR", "SLLTTR", JdeDataType.String, 6),
        new JdeField("SLEMCU", "SLEMCU", JdeDataType.String, 24),
        new JdeField("SLRLIT", "SLRLIT", JdeDataType.String, 16),
        new JdeField("SLKTLN", "SLKTLN", JdeDataType.Numeric),
        new JdeField("SLCPNT", "SLCPNT", JdeDataType.Numeric),
        new JdeField("SLRKIT", "SLRKIT", JdeDataType.Numeric),
        new JdeField("SLKTP", "SLKTP", JdeDataType.Numeric),
        new JdeField("SLSRP1", "SLSRP1", JdeDataType.String, 6),
        new JdeField("SLSRP2", "SLSRP2", JdeDataType.String, 6),
        new JdeField("SLSRP3", "SLSRP3", JdeDataType.String, 6),
        new JdeField("SLSRP4", "SLSRP4", JdeDataType.String, 6),
        new JdeField("SLSRP5", "SLSRP5", JdeDataType.String, 6),
        new JdeField("SLPRP1", "SLPRP1", JdeDataType.String, 6),
        new JdeField("SLPRP2", "SLPRP2", JdeDataType.String, 6),
        new JdeField("SLPRP3", "SLPRP3", JdeDataType.String, 6),
        new JdeField("SLPRP4", "SLPRP4", JdeDataType.String, 6),
        new JdeField("SLPRP5", "SLPRP5", JdeDataType.String, 6),
        new JdeField("SLUOM", "SLUOM", JdeDataType.String, 4),
        new JdeField("SLUORG", "SLUORG", JdeDataType.Numeric),
        new JdeField("SLSOQS", "SLSOQS", JdeDataType.Numeric),
        new JdeField("SLSOBK", "SLSOBK", JdeDataType.Numeric),
        new JdeField("SLSOCN", "SLSOCN", JdeDataType.Numeric),
        new JdeField("SLSONE", "SLSONE", JdeDataType.Numeric),
        new JdeField("SLUOPN", "SLUOPN", JdeDataType.Numeric),
        new JdeField("SLQTYT", "SLQTYT", JdeDataType.Numeric),
        new JdeField("SLQRLV", "SLQRLV", JdeDataType.Numeric),
        new JdeField("SLCOMM", "SLCOMM", JdeDataType.String, 2),
        new JdeField("SLOTQY", "SLOTQY", JdeDataType.String, 2),
        new JdeField("SLUPRC", "SLUPRC", JdeDataType.Numeric),
        new JdeField("SLAEXP", "SLAEXP", JdeDataType.Numeric),
        new JdeField("SLAOPN", "SLAOPN", JdeDataType.Numeric),
        new JdeField("SLPROV", "SLPROV", JdeDataType.String, 2),
        new JdeField("SLTPC", "SLTPC", JdeDataType.String, 2),
        new JdeField("SLAPUM", "SLAPUM", JdeDataType.String, 4),
        new JdeField("SLLPRC", "SLLPRC", JdeDataType.Numeric),
        new JdeField("SLUNCS", "SLUNCS", JdeDataType.Numeric),
        new JdeField("SLECST", "SLECST", JdeDataType.Numeric),
        new JdeField("SLCSTO", "SLCSTO", JdeDataType.String, 2),
        new JdeField("SLTCST", "SLTCST", JdeDataType.Numeric),
        new JdeField("SLINMG", "SLINMG", JdeDataType.String, 20),
        new JdeField("SLPTC", "SLPTC", JdeDataType.String, 6),
        new JdeField("SLRYIN", "SLRYIN", JdeDataType.String, 2),
        new JdeField("SLDTBS", "SLDTBS", JdeDataType.String, 2),
        new JdeField("SLTRDC", "SLTRDC", JdeDataType.Numeric),
        new JdeField("SLFUN2", "SLFUN2", JdeDataType.Numeric),
        new JdeField("SLASN", "SLASN", JdeDataType.String, 16),
        new JdeField("SLPRGR", "SLPRGR", JdeDataType.String, 16),
        new JdeField("SLCLVL", "SLCLVL", JdeDataType.String, 6),
        new JdeField("SLCADC", "SLCADC", JdeDataType.Numeric),
        new JdeField("SLKCO", "SLKCO", JdeDataType.String, 10),
        new JdeField("SLDOC", "SLDOC", JdeDataType.Numeric),
        new JdeField("SLDCT", "SLDCT", JdeDataType.String, 4),
        new JdeField("SLODOC", "SLODOC", JdeDataType.Numeric),
        new JdeField("SLODCT", "SLODCT", JdeDataType.String, 4),
        new JdeField("SLOKC", "SLOKC", JdeDataType.String, 10),
        new JdeField("SLPSN", "SLPSN", JdeDataType.Numeric),
        new JdeField("SLDELN", "SLDELN", JdeDataType.Numeric),
        new JdeField("SLTAX1", "SLTAX1", JdeDataType.String, 2),
        new JdeField("SLTXA1", "SLTXA1", JdeDataType.String, 20),
        new JdeField("SLEXR1", "SLEXR1", JdeDataType.String, 4),
        new JdeField("SLATXT", "SLATXT", JdeDataType.String, 2),
        new JdeField("SLPRIO", "SLPRIO", JdeDataType.String, 2),
        new JdeField("SLRESL", "SLRESL", JdeDataType.String, 2),
        new JdeField("SLBACK", "SLBACK", JdeDataType.String, 2),
        new JdeField("SLSBAL", "SLSBAL", JdeDataType.String, 2),
        new JdeField("SLAPTS", "SLAPTS", JdeDataType.String, 2),
        new JdeField("SLLOB", "SLLOB", JdeDataType.String, 6),
        new JdeField("SLEUSE", "SLEUSE", JdeDataType.String, 6),
        new JdeField("SLDTYS", "SLDTYS", JdeDataType.String, 4),
        new JdeField("SLNTR", "SLNTR", JdeDataType.String, 4),
        new JdeField("SLVEND", "SLVEND", JdeDataType.Numeric),
        new JdeField("SLCARS", "SLCARS", JdeDataType.Numeric),
        new JdeField("SLMOT", "SLMOT", JdeDataType.String, 6),
        new JdeField("SLROUT", "SLROUT", JdeDataType.String, 6),
        new JdeField("SLSTOP", "SLSTOP", JdeDataType.String, 6),
        new JdeField("SLZON", "SLZON", JdeDataType.String, 6),
        new JdeField("SLCNID", "SLCNID", JdeDataType.String, 40),
        new JdeField("SLFRTH", "SLFRTH", JdeDataType.String, 6),
        new JdeField("SLSHCM", "SLSHCM", JdeDataType.String, 6),
        new JdeField("SLSHCN", "SLSHCN", JdeDataType.String, 6),
        new JdeField("SLSERN", "SLSERN", JdeDataType.String, 60),
        new JdeField("SLUOM1", "SLUOM1", JdeDataType.String, 4),
        new JdeField("SLPQOR", "SLPQOR", JdeDataType.Numeric),
        new JdeField("SLUOM2", "SLUOM2", JdeDataType.String, 4),
        new JdeField("SLSQOR", "SLSQOR", JdeDataType.Numeric),
        new JdeField("SLUOM4", "SLUOM4", JdeDataType.String, 4),
        new JdeField("SLITWT", "SLITWT", JdeDataType.Numeric),
        new JdeField("SLWTUM", "SLWTUM", JdeDataType.String, 4),
        new JdeField("SLITVL", "SLITVL", JdeDataType.Numeric),
        new JdeField("SLVLUM", "SLVLUM", JdeDataType.String, 4),
        new JdeField("SLRPRC", "SLRPRC", JdeDataType.String, 16),
        new JdeField("SLORPR", "SLORPR", JdeDataType.String, 16),
        new JdeField("SLORP", "SLORP", JdeDataType.String, 2),
        new JdeField("SLCMGP", "SLCMGP", JdeDataType.String, 4),
        new JdeField("SLGLC", "SLGLC", JdeDataType.String, 8),
        new JdeField("SLCTRY", "SLCTRY", JdeDataType.Numeric),
        new JdeField("SLFY", "SLFY", JdeDataType.Numeric),
        new JdeField("SLSO01", "SLSO01", JdeDataType.String, 2),
        new JdeField("SLSO02", "SLSO02", JdeDataType.String, 2),
        new JdeField("SLSO03", "SLSO03", JdeDataType.String, 2),
        new JdeField("SLSO04", "SLSO04", JdeDataType.String, 2),
        new JdeField("SLSO05", "SLSO05", JdeDataType.String, 2),
        new JdeField("SLSO06", "SLSO06", JdeDataType.String, 2),
        new JdeField("SLSO07", "SLSO07", JdeDataType.String, 2),
        new JdeField("SLSO08", "SLSO08", JdeDataType.String, 2),
        new JdeField("SLSO09", "SLSO09", JdeDataType.String, 2),
        new JdeField("SLSO10", "SLSO10", JdeDataType.String, 2),
        new JdeField("SLSO11", "SLSO11", JdeDataType.String, 2),
        new JdeField("SLSO12", "SLSO12", JdeDataType.String, 2),
        new JdeField("SLSO13", "SLSO13", JdeDataType.String, 2),
        new JdeField("SLSO14", "SLSO14", JdeDataType.String, 2),
        new JdeField("SLSO15", "SLSO15", JdeDataType.String, 2),
        new JdeField("SLACOM", "SLACOM", JdeDataType.String, 2),
        new JdeField("SLCMCG", "SLCMCG", JdeDataType.String, 16),
        new JdeField("SLRCD", "SLRCD", JdeDataType.String, 6),
        new JdeField("SLGRWT", "SLGRWT", JdeDataType.Numeric),
        new JdeField("SLGWUM", "SLGWUM", JdeDataType.String, 4),
        new JdeField("SLSBL", "SLSBL", JdeDataType.String, 16),
        new JdeField("SLSBLT", "SLSBLT", JdeDataType.String, 2),
        new JdeField("SLLCOD", "SLLCOD", JdeDataType.String, 4),
        new JdeField("SLUPC1", "SLUPC1", JdeDataType.String, 4),
        new JdeField("SLUPC2", "SLUPC2", JdeDataType.String, 4),
        new JdeField("SLUPC3", "SLUPC3", JdeDataType.String, 4),
        new JdeField("SLSWMS", "SLSWMS", JdeDataType.String, 2),
        new JdeField("SLUNCD", "SLUNCD", JdeDataType.String, 2),
        new JdeField("SLCRMD", "SLCRMD", JdeDataType.String, 2),
        new JdeField("SLCRCD", "SLCRCD", JdeDataType.String, 6),
        new JdeField("SLCRR", "SLCRR", JdeDataType.Numeric),
        new JdeField("SLFPRC", "SLFPRC", JdeDataType.Numeric),
        new JdeField("SLFUP", "SLFUP", JdeDataType.Numeric),
        new JdeField("SLFEA", "SLFEA", JdeDataType.Numeric),
        new JdeField("SLFUC", "SLFUC", JdeDataType.Numeric),
        new JdeField("SLFEC", "SLFEC", JdeDataType.Numeric),
        new JdeField("SLURCD", "SLURCD", JdeDataType.String, 4),
        new JdeField("SLURDT", "SLURDT", JdeDataType.Numeric),
        new JdeField("SLURAT", "SLURAT", JdeDataType.Numeric),
        new JdeField("SLURAB", "SLURAB", JdeDataType.Numeric),
        new JdeField("SLURRF", "SLURRF", JdeDataType.String, 30),
        new JdeField("SLTORG", "SLTORG", JdeDataType.String, 20),
        new JdeField("SLUSER", "SLUSER", JdeDataType.String, 20),
        new JdeField("SLPID", "SLPID", JdeDataType.String, 20),
        new JdeField("SLJOBN", "SLJOBN", JdeDataType.String, 20),
        new JdeField("SLUPMJ", "SLUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SLTDAY", "SLTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("SLSO16", "SLSO16", JdeDataType.String, 2),
        new JdeField("SLSO17", "SLSO17", JdeDataType.String, 2),
        new JdeField("SLSO18", "SLSO18", JdeDataType.String, 2),
        new JdeField("SLSO19", "SLSO19", JdeDataType.String, 2),
        new JdeField("SLSO20", "SLSO20", JdeDataType.String, 2),
        new JdeField("SLIR01", "SLIR01", JdeDataType.String, 60),
        new JdeField("SLIR02", "SLIR02", JdeDataType.String, 60),
        new JdeField("SLIR03", "SLIR03", JdeDataType.String, 60),
        new JdeField("SLIR04", "SLIR04", JdeDataType.String, 60),
        new JdeField("SLIR05", "SLIR05", JdeDataType.String, 60),
        new JdeField("SLSOOR", "SLSOOR", JdeDataType.Numeric),
        new JdeField("SLVR03", "SLVR03", JdeDataType.String, 50),
        new JdeField("SLDEID", "SLDEID", JdeDataType.Numeric),
        new JdeField("SLPSIG", "SLPSIG", JdeDataType.String, 60),
        new JdeField("SLRLNU", "SLRLNU", JdeDataType.String, 20),
        new JdeField("SLPMDT", "SLPMDT", JdeDataType.Numeric),
        new JdeField("SLRLTM", "SLRLTM", JdeDataType.Numeric),
        new JdeField("SLRLDJ", "SLRLDJ", JdeDataType.Numeric),
        new JdeField("SLDRQT", "SLDRQT", JdeDataType.Numeric),
        new JdeField("SLADTM", "SLADTM", JdeDataType.Numeric),
        new JdeField("SLOPTT", "SLOPTT", JdeDataType.Numeric),
        new JdeField("SLPDTT", "SLPDTT", JdeDataType.Numeric),
        new JdeField("SLPSTM", "SLPSTM", JdeDataType.Numeric),
        new JdeField("SLXDCK", "SLXDCK", JdeDataType.String, 2),
        new JdeField("SLXPTY", "SLXPTY", JdeDataType.Numeric),
        new JdeField("SLDUAL", "SLDUAL", JdeDataType.String, 2),
        new JdeField("SLBSC", "SLBSC", JdeDataType.String, 20),
        new JdeField("SLCBSC", "SLCBSC", JdeDataType.String, 20),
        new JdeField("SLCORD", "SLCORD", JdeDataType.Numeric),
        new JdeField("SLDVAN", "SLDVAN", JdeDataType.Numeric),
        new JdeField("SLPEND", "SLPEND", JdeDataType.String, 2),
        new JdeField("SLRFRV", "SLRFRV", JdeDataType.String, 6),
        new JdeField("SLMCLN", "SLMCLN", JdeDataType.Numeric),
        new JdeField("SLSHPN", "SLSHPN", JdeDataType.Numeric),
        new JdeField("SLRSDT", "SLRSDT", JdeDataType.Numeric),
        new JdeField("SLPRJM", "SLPRJM", JdeDataType.Numeric),
        new JdeField("SLOSEQ", "SLOSEQ", JdeDataType.Numeric),
        new JdeField("SLMERL", "SLMERL", JdeDataType.String, 6),
        new JdeField("SLHOLD", "SLHOLD", JdeDataType.String, 4),
        new JdeField("SLHDBU", "SLHDBU", JdeDataType.String, 24),
        new JdeField("SLDMBU", "SLDMBU", JdeDataType.String, 24),
        new JdeField("SLBCRC", "SLBCRC", JdeDataType.String, 6),
        new JdeField("SLODLN", "SLODLN", JdeDataType.Numeric),
        new JdeField("SLOPDJ", "SLOPDJ", JdeDataType.Numeric),
        new JdeField("SLXKCO", "SLXKCO", JdeDataType.String, 10),
        new JdeField("SLXORN", "SLXORN", JdeDataType.Numeric),
        new JdeField("SLXCTO", "SLXCTO", JdeDataType.String, 4),
        new JdeField("SLXLLN", "SLXLLN", JdeDataType.Numeric),
        new JdeField("SLXSFX", "SLXSFX", JdeDataType.String, 6),
        new JdeField("SLPOE", "SLPOE", JdeDataType.String, 12),
        new JdeField("SLPMTO", "SLPMTO", JdeDataType.String, 2),
        new JdeField("SLANBY", "SLANBY", JdeDataType.Numeric),
        new JdeField("SLPMTN", "SLPMTN", JdeDataType.String, 24),
        new JdeField("SLNUMB", "SLNUMB", JdeDataType.Numeric),
        new JdeField("SLAAID", "SLAAID", JdeDataType.Numeric),
        new JdeField("SLPRAN8", "SLPRAN8", JdeDataType.Numeric),
        new JdeField("SLSPATTN", "SLSPATTN", JdeDataType.String, 100),
        new JdeField("SLPRCIDLN", "SLPRCIDLN", JdeDataType.Numeric),
        new JdeField("SLCCIDLN", "SLCCIDLN", JdeDataType.Numeric),
        new JdeField("SLSHCCIDLN", "SLSHCCIDLN", JdeDataType.Numeric),
        new JdeField("SLOPPID", "SLOPPID", JdeDataType.Numeric),
        new JdeField("SLOSTP", "SLOSTP", JdeDataType.String, 6),
        new JdeField("SLUKID", "SLUKID", JdeDataType.Numeric),
        new JdeField("SLCATNM", "SLCATNM", JdeDataType.String, 60),
        new JdeField("SLALLOC", "SLALLOC", JdeDataType.String, 2),
        new JdeField("SLFULPID", "SLFULPID", JdeDataType.Numeric),
        new JdeField("SLALLSTS", "SLALLSTS", JdeDataType.String, 60),
        new JdeField("SLOSCORE", "SLOSCORE", JdeDataType.Numeric),
        new JdeField("SLOSCOREO", "SLOSCOREO", JdeDataType.String, 2),
        new JdeField("SLCMCO", "SLCMCO", JdeDataType.String, 10),
        new JdeField("SLKITID", "SLKITID", JdeDataType.Numeric),
        new JdeField("SLKITAMTDOM", "SLKITAMTDOM", JdeDataType.Numeric),
        new JdeField("SLKITAMTFOR", "SLKITAMTFOR", JdeDataType.Numeric),
        new JdeField("SLKITDIRTY", "SLKITDIRTY", JdeDataType.String, 2),
        new JdeField("SLOCITT", "SLOCITT", JdeDataType.String, 2),
        new JdeField("SLOCCARDNO", "SLOCCARDNO", JdeDataType.Numeric),
        new JdeField("SLPMPN", "SLPMPN", JdeDataType.String, 60),
        new JdeField("SLPNS", "SLPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42199_0", "Primary Key on SLDOCO, SLDCTO, SLKCOO, SLLNID, SLUPMJ, SLTDAY", new[] { "SLDOCO", "SLDCTO", "SLKCOO", "SLLNID", "SLUPMJ", "SLTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42199_2", "Index on SLKCOO, SLDOCO, SLDCTO, SLLNID, SLKCO, SLDOC, SLDCT, SLUPMJ, SLTDAY", new[] { "SLKCOO", "SLDOCO", "SLDCTO", "SLLNID", "SLKCO", "SLDOC", "SLDCT", "SLUPMJ", "SLTDAY" })
    };
}
