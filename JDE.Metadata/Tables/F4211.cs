using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211 - .
/// </summary>
public class F4211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SDCO.
        /// </summary>
        public const string SDCO = "SDCO";

        /// <summary>
        /// SDOKCO.
        /// </summary>
        public const string SDOKCO = "SDOKCO";

        /// <summary>
        /// SDOORN.
        /// </summary>
        public const string SDOORN = "SDOORN";

        /// <summary>
        /// SDOCTO.
        /// </summary>
        public const string SDOCTO = "SDOCTO";

        /// <summary>
        /// SDOGNO.
        /// </summary>
        public const string SDOGNO = "SDOGNO";

        /// <summary>
        /// SDRKCO.
        /// </summary>
        public const string SDRKCO = "SDRKCO";

        /// <summary>
        /// SDRORN.
        /// </summary>
        public const string SDRORN = "SDRORN";

        /// <summary>
        /// SDRCTO.
        /// </summary>
        public const string SDRCTO = "SDRCTO";

        /// <summary>
        /// SDRLLN.
        /// </summary>
        public const string SDRLLN = "SDRLLN";

        /// <summary>
        /// SDDMCT.
        /// </summary>
        public const string SDDMCT = "SDDMCT";

        /// <summary>
        /// SDDMCS.
        /// </summary>
        public const string SDDMCS = "SDDMCS";

        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SDSHAN.
        /// </summary>
        public const string SDSHAN = "SDSHAN";

        /// <summary>
        /// SDPA8.
        /// </summary>
        public const string SDPA8 = "SDPA8";

        /// <summary>
        /// SDDRQJ.
        /// </summary>
        public const string SDDRQJ = "SDDRQJ";

        /// <summary>
        /// SDTRDJ.
        /// </summary>
        public const string SDTRDJ = "SDTRDJ";

        /// <summary>
        /// SDPDDJ.
        /// </summary>
        public const string SDPDDJ = "SDPDDJ";

        /// <summary>
        /// SDADDJ.
        /// </summary>
        public const string SDADDJ = "SDADDJ";

        /// <summary>
        /// SDIVD.
        /// </summary>
        public const string SDIVD = "SDIVD";

        /// <summary>
        /// SDCNDJ.
        /// </summary>
        public const string SDCNDJ = "SDCNDJ";

        /// <summary>
        /// SDDGL.
        /// </summary>
        public const string SDDGL = "SDDGL";

        /// <summary>
        /// SDRSDJ.
        /// </summary>
        public const string SDRSDJ = "SDRSDJ";

        /// <summary>
        /// SDPEFJ.
        /// </summary>
        public const string SDPEFJ = "SDPEFJ";

        /// <summary>
        /// SDPPDJ.
        /// </summary>
        public const string SDPPDJ = "SDPPDJ";

        /// <summary>
        /// SDVR01.
        /// </summary>
        public const string SDVR01 = "SDVR01";

        /// <summary>
        /// SDVR02.
        /// </summary>
        public const string SDVR02 = "SDVR02";

        /// <summary>
        /// SDITM.
        /// </summary>
        public const string SDITM = "SDITM";

        /// <summary>
        /// SDLITM.
        /// </summary>
        public const string SDLITM = "SDLITM";

        /// <summary>
        /// SDAITM.
        /// </summary>
        public const string SDAITM = "SDAITM";

        /// <summary>
        /// SDLOCN.
        /// </summary>
        public const string SDLOCN = "SDLOCN";

        /// <summary>
        /// SDLOTN.
        /// </summary>
        public const string SDLOTN = "SDLOTN";

        /// <summary>
        /// SDFRGD.
        /// </summary>
        public const string SDFRGD = "SDFRGD";

        /// <summary>
        /// SDTHGD.
        /// </summary>
        public const string SDTHGD = "SDTHGD";

        /// <summary>
        /// SDFRMP.
        /// </summary>
        public const string SDFRMP = "SDFRMP";

        /// <summary>
        /// SDTHRP.
        /// </summary>
        public const string SDTHRP = "SDTHRP";

        /// <summary>
        /// SDEXDP.
        /// </summary>
        public const string SDEXDP = "SDEXDP";

        /// <summary>
        /// SDDSC1.
        /// </summary>
        public const string SDDSC1 = "SDDSC1";

        /// <summary>
        /// SDDSC2.
        /// </summary>
        public const string SDDSC2 = "SDDSC2";

        /// <summary>
        /// SDLNTY.
        /// </summary>
        public const string SDLNTY = "SDLNTY";

        /// <summary>
        /// SDNXTR.
        /// </summary>
        public const string SDNXTR = "SDNXTR";

        /// <summary>
        /// SDLTTR.
        /// </summary>
        public const string SDLTTR = "SDLTTR";

        /// <summary>
        /// SDEMCU.
        /// </summary>
        public const string SDEMCU = "SDEMCU";

        /// <summary>
        /// SDRLIT.
        /// </summary>
        public const string SDRLIT = "SDRLIT";

        /// <summary>
        /// SDKTLN.
        /// </summary>
        public const string SDKTLN = "SDKTLN";

        /// <summary>
        /// SDCPNT.
        /// </summary>
        public const string SDCPNT = "SDCPNT";

        /// <summary>
        /// SDRKIT.
        /// </summary>
        public const string SDRKIT = "SDRKIT";

        /// <summary>
        /// SDKTP.
        /// </summary>
        public const string SDKTP = "SDKTP";

        /// <summary>
        /// SDSRP1.
        /// </summary>
        public const string SDSRP1 = "SDSRP1";

        /// <summary>
        /// SDSRP2.
        /// </summary>
        public const string SDSRP2 = "SDSRP2";

        /// <summary>
        /// SDSRP3.
        /// </summary>
        public const string SDSRP3 = "SDSRP3";

        /// <summary>
        /// SDSRP4.
        /// </summary>
        public const string SDSRP4 = "SDSRP4";

        /// <summary>
        /// SDSRP5.
        /// </summary>
        public const string SDSRP5 = "SDSRP5";

        /// <summary>
        /// SDPRP1.
        /// </summary>
        public const string SDPRP1 = "SDPRP1";

        /// <summary>
        /// SDPRP2.
        /// </summary>
        public const string SDPRP2 = "SDPRP2";

        /// <summary>
        /// SDPRP3.
        /// </summary>
        public const string SDPRP3 = "SDPRP3";

        /// <summary>
        /// SDPRP4.
        /// </summary>
        public const string SDPRP4 = "SDPRP4";

        /// <summary>
        /// SDPRP5.
        /// </summary>
        public const string SDPRP5 = "SDPRP5";

        /// <summary>
        /// SDUOM.
        /// </summary>
        public const string SDUOM = "SDUOM";

        /// <summary>
        /// SDUORG.
        /// </summary>
        public const string SDUORG = "SDUORG";

        /// <summary>
        /// SDSOQS.
        /// </summary>
        public const string SDSOQS = "SDSOQS";

        /// <summary>
        /// SDSOBK.
        /// </summary>
        public const string SDSOBK = "SDSOBK";

        /// <summary>
        /// SDSOCN.
        /// </summary>
        public const string SDSOCN = "SDSOCN";

        /// <summary>
        /// SDSONE.
        /// </summary>
        public const string SDSONE = "SDSONE";

        /// <summary>
        /// SDUOPN.
        /// </summary>
        public const string SDUOPN = "SDUOPN";

        /// <summary>
        /// SDQTYT.
        /// </summary>
        public const string SDQTYT = "SDQTYT";

        /// <summary>
        /// SDQRLV.
        /// </summary>
        public const string SDQRLV = "SDQRLV";

        /// <summary>
        /// SDCOMM.
        /// </summary>
        public const string SDCOMM = "SDCOMM";

        /// <summary>
        /// SDOTQY.
        /// </summary>
        public const string SDOTQY = "SDOTQY";

        /// <summary>
        /// SDUPRC.
        /// </summary>
        public const string SDUPRC = "SDUPRC";

        /// <summary>
        /// SDAEXP.
        /// </summary>
        public const string SDAEXP = "SDAEXP";

        /// <summary>
        /// SDAOPN.
        /// </summary>
        public const string SDAOPN = "SDAOPN";

        /// <summary>
        /// SDPROV.
        /// </summary>
        public const string SDPROV = "SDPROV";

        /// <summary>
        /// SDTPC.
        /// </summary>
        public const string SDTPC = "SDTPC";

        /// <summary>
        /// SDAPUM.
        /// </summary>
        public const string SDAPUM = "SDAPUM";

        /// <summary>
        /// SDLPRC.
        /// </summary>
        public const string SDLPRC = "SDLPRC";

        /// <summary>
        /// SDUNCS.
        /// </summary>
        public const string SDUNCS = "SDUNCS";

        /// <summary>
        /// SDECST.
        /// </summary>
        public const string SDECST = "SDECST";

        /// <summary>
        /// SDCSTO.
        /// </summary>
        public const string SDCSTO = "SDCSTO";

        /// <summary>
        /// SDTCST.
        /// </summary>
        public const string SDTCST = "SDTCST";

        /// <summary>
        /// SDINMG.
        /// </summary>
        public const string SDINMG = "SDINMG";

        /// <summary>
        /// SDPTC.
        /// </summary>
        public const string SDPTC = "SDPTC";

        /// <summary>
        /// SDRYIN.
        /// </summary>
        public const string SDRYIN = "SDRYIN";

        /// <summary>
        /// SDDTBS.
        /// </summary>
        public const string SDDTBS = "SDDTBS";

        /// <summary>
        /// SDTRDC.
        /// </summary>
        public const string SDTRDC = "SDTRDC";

        /// <summary>
        /// SDFUN2.
        /// </summary>
        public const string SDFUN2 = "SDFUN2";

        /// <summary>
        /// SDASN.
        /// </summary>
        public const string SDASN = "SDASN";

        /// <summary>
        /// SDPRGR.
        /// </summary>
        public const string SDPRGR = "SDPRGR";

        /// <summary>
        /// SDCLVL.
        /// </summary>
        public const string SDCLVL = "SDCLVL";

        /// <summary>
        /// SDCADC.
        /// </summary>
        public const string SDCADC = "SDCADC";

        /// <summary>
        /// SDKCO.
        /// </summary>
        public const string SDKCO = "SDKCO";

        /// <summary>
        /// SDDOC.
        /// </summary>
        public const string SDDOC = "SDDOC";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDODOC.
        /// </summary>
        public const string SDODOC = "SDODOC";

        /// <summary>
        /// SDODCT.
        /// </summary>
        public const string SDODCT = "SDODCT";

        /// <summary>
        /// SDOKC.
        /// </summary>
        public const string SDOKC = "SDOKC";

        /// <summary>
        /// SDPSN.
        /// </summary>
        public const string SDPSN = "SDPSN";

        /// <summary>
        /// SDDELN.
        /// </summary>
        public const string SDDELN = "SDDELN";

        /// <summary>
        /// SDTAX1.
        /// </summary>
        public const string SDTAX1 = "SDTAX1";

        /// <summary>
        /// SDTXA1.
        /// </summary>
        public const string SDTXA1 = "SDTXA1";

        /// <summary>
        /// SDEXR1.
        /// </summary>
        public const string SDEXR1 = "SDEXR1";

        /// <summary>
        /// SDATXT.
        /// </summary>
        public const string SDATXT = "SDATXT";

        /// <summary>
        /// SDPRIO.
        /// </summary>
        public const string SDPRIO = "SDPRIO";

        /// <summary>
        /// SDRESL.
        /// </summary>
        public const string SDRESL = "SDRESL";

        /// <summary>
        /// SDBACK.
        /// </summary>
        public const string SDBACK = "SDBACK";

        /// <summary>
        /// SDSBAL.
        /// </summary>
        public const string SDSBAL = "SDSBAL";

        /// <summary>
        /// SDAPTS.
        /// </summary>
        public const string SDAPTS = "SDAPTS";

        /// <summary>
        /// SDLOB.
        /// </summary>
        public const string SDLOB = "SDLOB";

        /// <summary>
        /// SDEUSE.
        /// </summary>
        public const string SDEUSE = "SDEUSE";

        /// <summary>
        /// SDDTYS.
        /// </summary>
        public const string SDDTYS = "SDDTYS";

        /// <summary>
        /// SDNTR.
        /// </summary>
        public const string SDNTR = "SDNTR";

        /// <summary>
        /// SDVEND.
        /// </summary>
        public const string SDVEND = "SDVEND";

        /// <summary>
        /// SDCARS.
        /// </summary>
        public const string SDCARS = "SDCARS";

        /// <summary>
        /// SDMOT.
        /// </summary>
        public const string SDMOT = "SDMOT";

        /// <summary>
        /// SDROUT.
        /// </summary>
        public const string SDROUT = "SDROUT";

        /// <summary>
        /// SDSTOP.
        /// </summary>
        public const string SDSTOP = "SDSTOP";

        /// <summary>
        /// SDZON.
        /// </summary>
        public const string SDZON = "SDZON";

        /// <summary>
        /// SDCNID.
        /// </summary>
        public const string SDCNID = "SDCNID";

        /// <summary>
        /// SDFRTH.
        /// </summary>
        public const string SDFRTH = "SDFRTH";

        /// <summary>
        /// SDSHCM.
        /// </summary>
        public const string SDSHCM = "SDSHCM";

        /// <summary>
        /// SDSHCN.
        /// </summary>
        public const string SDSHCN = "SDSHCN";

        /// <summary>
        /// SDSERN.
        /// </summary>
        public const string SDSERN = "SDSERN";

        /// <summary>
        /// SDUOM1.
        /// </summary>
        public const string SDUOM1 = "SDUOM1";

        /// <summary>
        /// SDPQOR.
        /// </summary>
        public const string SDPQOR = "SDPQOR";

        /// <summary>
        /// SDUOM2.
        /// </summary>
        public const string SDUOM2 = "SDUOM2";

        /// <summary>
        /// SDSQOR.
        /// </summary>
        public const string SDSQOR = "SDSQOR";

        /// <summary>
        /// SDUOM4.
        /// </summary>
        public const string SDUOM4 = "SDUOM4";

        /// <summary>
        /// SDITWT.
        /// </summary>
        public const string SDITWT = "SDITWT";

        /// <summary>
        /// SDWTUM.
        /// </summary>
        public const string SDWTUM = "SDWTUM";

        /// <summary>
        /// SDITVL.
        /// </summary>
        public const string SDITVL = "SDITVL";

        /// <summary>
        /// SDVLUM.
        /// </summary>
        public const string SDVLUM = "SDVLUM";

        /// <summary>
        /// SDRPRC.
        /// </summary>
        public const string SDRPRC = "SDRPRC";

        /// <summary>
        /// SDORPR.
        /// </summary>
        public const string SDORPR = "SDORPR";

        /// <summary>
        /// SDORP.
        /// </summary>
        public const string SDORP = "SDORP";

        /// <summary>
        /// SDCMGP.
        /// </summary>
        public const string SDCMGP = "SDCMGP";

        /// <summary>
        /// SDGLC.
        /// </summary>
        public const string SDGLC = "SDGLC";

        /// <summary>
        /// SDCTRY.
        /// </summary>
        public const string SDCTRY = "SDCTRY";

        /// <summary>
        /// SDFY.
        /// </summary>
        public const string SDFY = "SDFY";

        /// <summary>
        /// SDSO01.
        /// </summary>
        public const string SDSO01 = "SDSO01";

        /// <summary>
        /// SDSO02.
        /// </summary>
        public const string SDSO02 = "SDSO02";

        /// <summary>
        /// SDSO03.
        /// </summary>
        public const string SDSO03 = "SDSO03";

        /// <summary>
        /// SDSO04.
        /// </summary>
        public const string SDSO04 = "SDSO04";

        /// <summary>
        /// SDSO05.
        /// </summary>
        public const string SDSO05 = "SDSO05";

        /// <summary>
        /// SDSO06.
        /// </summary>
        public const string SDSO06 = "SDSO06";

        /// <summary>
        /// SDSO07.
        /// </summary>
        public const string SDSO07 = "SDSO07";

        /// <summary>
        /// SDSO08.
        /// </summary>
        public const string SDSO08 = "SDSO08";

        /// <summary>
        /// SDSO09.
        /// </summary>
        public const string SDSO09 = "SDSO09";

        /// <summary>
        /// SDSO10.
        /// </summary>
        public const string SDSO10 = "SDSO10";

        /// <summary>
        /// SDSO11.
        /// </summary>
        public const string SDSO11 = "SDSO11";

        /// <summary>
        /// SDSO12.
        /// </summary>
        public const string SDSO12 = "SDSO12";

        /// <summary>
        /// SDSO13.
        /// </summary>
        public const string SDSO13 = "SDSO13";

        /// <summary>
        /// SDSO14.
        /// </summary>
        public const string SDSO14 = "SDSO14";

        /// <summary>
        /// SDSO15.
        /// </summary>
        public const string SDSO15 = "SDSO15";

        /// <summary>
        /// SDACOM.
        /// </summary>
        public const string SDACOM = "SDACOM";

        /// <summary>
        /// SDCMCG.
        /// </summary>
        public const string SDCMCG = "SDCMCG";

        /// <summary>
        /// SDRCD.
        /// </summary>
        public const string SDRCD = "SDRCD";

        /// <summary>
        /// SDGRWT.
        /// </summary>
        public const string SDGRWT = "SDGRWT";

        /// <summary>
        /// SDGWUM.
        /// </summary>
        public const string SDGWUM = "SDGWUM";

        /// <summary>
        /// SDSBL.
        /// </summary>
        public const string SDSBL = "SDSBL";

        /// <summary>
        /// SDSBLT.
        /// </summary>
        public const string SDSBLT = "SDSBLT";

        /// <summary>
        /// SDLCOD.
        /// </summary>
        public const string SDLCOD = "SDLCOD";

        /// <summary>
        /// SDUPC1.
        /// </summary>
        public const string SDUPC1 = "SDUPC1";

        /// <summary>
        /// SDUPC2.
        /// </summary>
        public const string SDUPC2 = "SDUPC2";

        /// <summary>
        /// SDUPC3.
        /// </summary>
        public const string SDUPC3 = "SDUPC3";

        /// <summary>
        /// SDSWMS.
        /// </summary>
        public const string SDSWMS = "SDSWMS";

        /// <summary>
        /// SDUNCD.
        /// </summary>
        public const string SDUNCD = "SDUNCD";

        /// <summary>
        /// SDCRMD.
        /// </summary>
        public const string SDCRMD = "SDCRMD";

        /// <summary>
        /// SDCRCD.
        /// </summary>
        public const string SDCRCD = "SDCRCD";

        /// <summary>
        /// SDCRR.
        /// </summary>
        public const string SDCRR = "SDCRR";

        /// <summary>
        /// SDFPRC.
        /// </summary>
        public const string SDFPRC = "SDFPRC";

        /// <summary>
        /// SDFUP.
        /// </summary>
        public const string SDFUP = "SDFUP";

        /// <summary>
        /// SDFEA.
        /// </summary>
        public const string SDFEA = "SDFEA";

        /// <summary>
        /// SDFUC.
        /// </summary>
        public const string SDFUC = "SDFUC";

        /// <summary>
        /// SDFEC.
        /// </summary>
        public const string SDFEC = "SDFEC";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDTORG.
        /// </summary>
        public const string SDTORG = "SDTORG";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";

        /// <summary>
        /// SDSO16.
        /// </summary>
        public const string SDSO16 = "SDSO16";

        /// <summary>
        /// SDSO17.
        /// </summary>
        public const string SDSO17 = "SDSO17";

        /// <summary>
        /// SDSO18.
        /// </summary>
        public const string SDSO18 = "SDSO18";

        /// <summary>
        /// SDSO19.
        /// </summary>
        public const string SDSO19 = "SDSO19";

        /// <summary>
        /// SDSO20.
        /// </summary>
        public const string SDSO20 = "SDSO20";

        /// <summary>
        /// SDIR01.
        /// </summary>
        public const string SDIR01 = "SDIR01";

        /// <summary>
        /// SDIR02.
        /// </summary>
        public const string SDIR02 = "SDIR02";

        /// <summary>
        /// SDIR03.
        /// </summary>
        public const string SDIR03 = "SDIR03";

        /// <summary>
        /// SDIR04.
        /// </summary>
        public const string SDIR04 = "SDIR04";

        /// <summary>
        /// SDIR05.
        /// </summary>
        public const string SDIR05 = "SDIR05";

        /// <summary>
        /// SDSOOR.
        /// </summary>
        public const string SDSOOR = "SDSOOR";

        /// <summary>
        /// SDVR03.
        /// </summary>
        public const string SDVR03 = "SDVR03";

        /// <summary>
        /// SDDEID.
        /// </summary>
        public const string SDDEID = "SDDEID";

        /// <summary>
        /// SDPSIG.
        /// </summary>
        public const string SDPSIG = "SDPSIG";

        /// <summary>
        /// SDRLNU.
        /// </summary>
        public const string SDRLNU = "SDRLNU";

        /// <summary>
        /// SDPMDT.
        /// </summary>
        public const string SDPMDT = "SDPMDT";

        /// <summary>
        /// SDRLTM.
        /// </summary>
        public const string SDRLTM = "SDRLTM";

        /// <summary>
        /// SDRLDJ.
        /// </summary>
        public const string SDRLDJ = "SDRLDJ";

        /// <summary>
        /// SDDRQT.
        /// </summary>
        public const string SDDRQT = "SDDRQT";

        /// <summary>
        /// SDADTM.
        /// </summary>
        public const string SDADTM = "SDADTM";

        /// <summary>
        /// SDOPTT.
        /// </summary>
        public const string SDOPTT = "SDOPTT";

        /// <summary>
        /// SDPDTT.
        /// </summary>
        public const string SDPDTT = "SDPDTT";

        /// <summary>
        /// SDPSTM.
        /// </summary>
        public const string SDPSTM = "SDPSTM";

        /// <summary>
        /// SDXDCK.
        /// </summary>
        public const string SDXDCK = "SDXDCK";

        /// <summary>
        /// SDXPTY.
        /// </summary>
        public const string SDXPTY = "SDXPTY";

        /// <summary>
        /// SDDUAL.
        /// </summary>
        public const string SDDUAL = "SDDUAL";

        /// <summary>
        /// SDBSC.
        /// </summary>
        public const string SDBSC = "SDBSC";

        /// <summary>
        /// SDCBSC.
        /// </summary>
        public const string SDCBSC = "SDCBSC";

        /// <summary>
        /// SDCORD.
        /// </summary>
        public const string SDCORD = "SDCORD";

        /// <summary>
        /// SDDVAN.
        /// </summary>
        public const string SDDVAN = "SDDVAN";

        /// <summary>
        /// SDPEND.
        /// </summary>
        public const string SDPEND = "SDPEND";

        /// <summary>
        /// SDRFRV.
        /// </summary>
        public const string SDRFRV = "SDRFRV";

        /// <summary>
        /// SDMCLN.
        /// </summary>
        public const string SDMCLN = "SDMCLN";

        /// <summary>
        /// SDSHPN.
        /// </summary>
        public const string SDSHPN = "SDSHPN";

        /// <summary>
        /// SDRSDT.
        /// </summary>
        public const string SDRSDT = "SDRSDT";

        /// <summary>
        /// SDPRJM.
        /// </summary>
        public const string SDPRJM = "SDPRJM";

        /// <summary>
        /// SDOSEQ.
        /// </summary>
        public const string SDOSEQ = "SDOSEQ";

        /// <summary>
        /// SDMERL.
        /// </summary>
        public const string SDMERL = "SDMERL";

        /// <summary>
        /// SDHOLD.
        /// </summary>
        public const string SDHOLD = "SDHOLD";

        /// <summary>
        /// SDHDBU.
        /// </summary>
        public const string SDHDBU = "SDHDBU";

        /// <summary>
        /// SDDMBU.
        /// </summary>
        public const string SDDMBU = "SDDMBU";

        /// <summary>
        /// SDBCRC.
        /// </summary>
        public const string SDBCRC = "SDBCRC";

        /// <summary>
        /// SDODLN.
        /// </summary>
        public const string SDODLN = "SDODLN";

        /// <summary>
        /// SDOPDJ.
        /// </summary>
        public const string SDOPDJ = "SDOPDJ";

        /// <summary>
        /// SDXKCO.
        /// </summary>
        public const string SDXKCO = "SDXKCO";

        /// <summary>
        /// SDXORN.
        /// </summary>
        public const string SDXORN = "SDXORN";

        /// <summary>
        /// SDXCTO.
        /// </summary>
        public const string SDXCTO = "SDXCTO";

        /// <summary>
        /// SDXLLN.
        /// </summary>
        public const string SDXLLN = "SDXLLN";

        /// <summary>
        /// SDXSFX.
        /// </summary>
        public const string SDXSFX = "SDXSFX";

        /// <summary>
        /// SDPOE.
        /// </summary>
        public const string SDPOE = "SDPOE";

        /// <summary>
        /// SDPMTO.
        /// </summary>
        public const string SDPMTO = "SDPMTO";

        /// <summary>
        /// SDANBY.
        /// </summary>
        public const string SDANBY = "SDANBY";

        /// <summary>
        /// SDPMTN.
        /// </summary>
        public const string SDPMTN = "SDPMTN";

        /// <summary>
        /// SDNUMB.
        /// </summary>
        public const string SDNUMB = "SDNUMB";

        /// <summary>
        /// SDAAID.
        /// </summary>
        public const string SDAAID = "SDAAID";

        /// <summary>
        /// SDSPATTN.
        /// </summary>
        public const string SDSPATTN = "SDSPATTN";

        /// <summary>
        /// SDPRAN8.
        /// </summary>
        public const string SDPRAN8 = "SDPRAN8";

        /// <summary>
        /// SDPRCIDLN.
        /// </summary>
        public const string SDPRCIDLN = "SDPRCIDLN";

        /// <summary>
        /// SDCCIDLN.
        /// </summary>
        public const string SDCCIDLN = "SDCCIDLN";

        /// <summary>
        /// SDSHCCIDLN.
        /// </summary>
        public const string SDSHCCIDLN = "SDSHCCIDLN";

        /// <summary>
        /// SDOPPID.
        /// </summary>
        public const string SDOPPID = "SDOPPID";

        /// <summary>
        /// SDOSTP.
        /// </summary>
        public const string SDOSTP = "SDOSTP";

        /// <summary>
        /// SDUKID.
        /// </summary>
        public const string SDUKID = "SDUKID";

        /// <summary>
        /// SDCATNM.
        /// </summary>
        public const string SDCATNM = "SDCATNM";

        /// <summary>
        /// SDALLOC.
        /// </summary>
        public const string SDALLOC = "SDALLOC";

        /// <summary>
        /// SDFULPID.
        /// </summary>
        public const string SDFULPID = "SDFULPID";

        /// <summary>
        /// SDALLSTS.
        /// </summary>
        public const string SDALLSTS = "SDALLSTS";

        /// <summary>
        /// SDOSCORE.
        /// </summary>
        public const string SDOSCORE = "SDOSCORE";

        /// <summary>
        /// SDOSCOREO.
        /// </summary>
        public const string SDOSCOREO = "SDOSCOREO";

        /// <summary>
        /// SDCMCO.
        /// </summary>
        public const string SDCMCO = "SDCMCO";

        /// <summary>
        /// SDKITID.
        /// </summary>
        public const string SDKITID = "SDKITID";

        /// <summary>
        /// SDKITAMTDOM.
        /// </summary>
        public const string SDKITAMTDOM = "SDKITAMTDOM";

        /// <summary>
        /// SDKITAMTFOR.
        /// </summary>
        public const string SDKITAMTFOR = "SDKITAMTFOR";

        /// <summary>
        /// SDKITDIRTY.
        /// </summary>
        public const string SDKITDIRTY = "SDKITDIRTY";

        /// <summary>
        /// SDOCITT.
        /// </summary>
        public const string SDOCITT = "SDOCITT";

        /// <summary>
        /// SDOCCARDNO.
        /// </summary>
        public const string SDOCCARDNO = "SDOCCARDNO";

        /// <summary>
        /// SDPMPN.
        /// </summary>
        public const string SDPMPN = "SDPMPN";

        /// <summary>
        /// SDPNS.
        /// </summary>
        public const string SDPNS = "SDPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F4211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6),
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24),
        new JdeField("SDCO", "SDCO", JdeDataType.String, 10),
        new JdeField("SDOKCO", "SDOKCO", JdeDataType.String, 10),
        new JdeField("SDOORN", "SDOORN", JdeDataType.String, 16),
        new JdeField("SDOCTO", "SDOCTO", JdeDataType.String, 4),
        new JdeField("SDOGNO", "SDOGNO", JdeDataType.Numeric),
        new JdeField("SDRKCO", "SDRKCO", JdeDataType.String, 10),
        new JdeField("SDRORN", "SDRORN", JdeDataType.String, 16),
        new JdeField("SDRCTO", "SDRCTO", JdeDataType.String, 4),
        new JdeField("SDRLLN", "SDRLLN", JdeDataType.Numeric),
        new JdeField("SDDMCT", "SDDMCT", JdeDataType.String, 24),
        new JdeField("SDDMCS", "SDDMCS", JdeDataType.Numeric),
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric),
        new JdeField("SDSHAN", "SDSHAN", JdeDataType.Numeric),
        new JdeField("SDPA8", "SDPA8", JdeDataType.Numeric),
        new JdeField("SDDRQJ", "SDDRQJ", JdeDataType.Numeric),
        new JdeField("SDTRDJ", "SDTRDJ", JdeDataType.Numeric),
        new JdeField("SDPDDJ", "SDPDDJ", JdeDataType.Numeric),
        new JdeField("SDADDJ", "SDADDJ", JdeDataType.Numeric),
        new JdeField("SDIVD", "SDIVD", JdeDataType.Numeric),
        new JdeField("SDCNDJ", "SDCNDJ", JdeDataType.Numeric),
        new JdeField("SDDGL", "SDDGL", JdeDataType.Numeric),
        new JdeField("SDRSDJ", "SDRSDJ", JdeDataType.Numeric),
        new JdeField("SDPEFJ", "SDPEFJ", JdeDataType.Numeric),
        new JdeField("SDPPDJ", "SDPPDJ", JdeDataType.Numeric),
        new JdeField("SDVR01", "SDVR01", JdeDataType.String, 50),
        new JdeField("SDVR02", "SDVR02", JdeDataType.String, 50),
        new JdeField("SDITM", "SDITM", JdeDataType.Numeric),
        new JdeField("SDLITM", "SDLITM", JdeDataType.String, 50),
        new JdeField("SDAITM", "SDAITM", JdeDataType.String, 50),
        new JdeField("SDLOCN", "SDLOCN", JdeDataType.String, 40),
        new JdeField("SDLOTN", "SDLOTN", JdeDataType.String, 60),
        new JdeField("SDFRGD", "SDFRGD", JdeDataType.String, 6),
        new JdeField("SDTHGD", "SDTHGD", JdeDataType.String, 6),
        new JdeField("SDFRMP", "SDFRMP", JdeDataType.Numeric),
        new JdeField("SDTHRP", "SDTHRP", JdeDataType.Numeric),
        new JdeField("SDEXDP", "SDEXDP", JdeDataType.Numeric),
        new JdeField("SDDSC1", "SDDSC1", JdeDataType.String, 60),
        new JdeField("SDDSC2", "SDDSC2", JdeDataType.String, 60),
        new JdeField("SDLNTY", "SDLNTY", JdeDataType.String, 4),
        new JdeField("SDNXTR", "SDNXTR", JdeDataType.String, 6),
        new JdeField("SDLTTR", "SDLTTR", JdeDataType.String, 6),
        new JdeField("SDEMCU", "SDEMCU", JdeDataType.String, 24),
        new JdeField("SDRLIT", "SDRLIT", JdeDataType.String, 16),
        new JdeField("SDKTLN", "SDKTLN", JdeDataType.Numeric),
        new JdeField("SDCPNT", "SDCPNT", JdeDataType.Numeric),
        new JdeField("SDRKIT", "SDRKIT", JdeDataType.Numeric),
        new JdeField("SDKTP", "SDKTP", JdeDataType.Numeric),
        new JdeField("SDSRP1", "SDSRP1", JdeDataType.String, 6),
        new JdeField("SDSRP2", "SDSRP2", JdeDataType.String, 6),
        new JdeField("SDSRP3", "SDSRP3", JdeDataType.String, 6),
        new JdeField("SDSRP4", "SDSRP4", JdeDataType.String, 6),
        new JdeField("SDSRP5", "SDSRP5", JdeDataType.String, 6),
        new JdeField("SDPRP1", "SDPRP1", JdeDataType.String, 6),
        new JdeField("SDPRP2", "SDPRP2", JdeDataType.String, 6),
        new JdeField("SDPRP3", "SDPRP3", JdeDataType.String, 6),
        new JdeField("SDPRP4", "SDPRP4", JdeDataType.String, 6),
        new JdeField("SDPRP5", "SDPRP5", JdeDataType.String, 6),
        new JdeField("SDUOM", "SDUOM", JdeDataType.String, 4),
        new JdeField("SDUORG", "SDUORG", JdeDataType.Numeric),
        new JdeField("SDSOQS", "SDSOQS", JdeDataType.Numeric),
        new JdeField("SDSOBK", "SDSOBK", JdeDataType.Numeric),
        new JdeField("SDSOCN", "SDSOCN", JdeDataType.Numeric),
        new JdeField("SDSONE", "SDSONE", JdeDataType.Numeric),
        new JdeField("SDUOPN", "SDUOPN", JdeDataType.Numeric),
        new JdeField("SDQTYT", "SDQTYT", JdeDataType.Numeric),
        new JdeField("SDQRLV", "SDQRLV", JdeDataType.Numeric),
        new JdeField("SDCOMM", "SDCOMM", JdeDataType.String, 2),
        new JdeField("SDOTQY", "SDOTQY", JdeDataType.String, 2),
        new JdeField("SDUPRC", "SDUPRC", JdeDataType.Numeric),
        new JdeField("SDAEXP", "SDAEXP", JdeDataType.Numeric),
        new JdeField("SDAOPN", "SDAOPN", JdeDataType.Numeric),
        new JdeField("SDPROV", "SDPROV", JdeDataType.String, 2),
        new JdeField("SDTPC", "SDTPC", JdeDataType.String, 2),
        new JdeField("SDAPUM", "SDAPUM", JdeDataType.String, 4),
        new JdeField("SDLPRC", "SDLPRC", JdeDataType.Numeric),
        new JdeField("SDUNCS", "SDUNCS", JdeDataType.Numeric),
        new JdeField("SDECST", "SDECST", JdeDataType.Numeric),
        new JdeField("SDCSTO", "SDCSTO", JdeDataType.String, 2),
        new JdeField("SDTCST", "SDTCST", JdeDataType.Numeric),
        new JdeField("SDINMG", "SDINMG", JdeDataType.String, 20),
        new JdeField("SDPTC", "SDPTC", JdeDataType.String, 6),
        new JdeField("SDRYIN", "SDRYIN", JdeDataType.String, 2),
        new JdeField("SDDTBS", "SDDTBS", JdeDataType.String, 2),
        new JdeField("SDTRDC", "SDTRDC", JdeDataType.Numeric),
        new JdeField("SDFUN2", "SDFUN2", JdeDataType.Numeric),
        new JdeField("SDASN", "SDASN", JdeDataType.String, 16),
        new JdeField("SDPRGR", "SDPRGR", JdeDataType.String, 16),
        new JdeField("SDCLVL", "SDCLVL", JdeDataType.String, 6),
        new JdeField("SDCADC", "SDCADC", JdeDataType.Numeric),
        new JdeField("SDKCO", "SDKCO", JdeDataType.String, 10),
        new JdeField("SDDOC", "SDDOC", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDODOC", "SDODOC", JdeDataType.Numeric),
        new JdeField("SDODCT", "SDODCT", JdeDataType.String, 4),
        new JdeField("SDOKC", "SDOKC", JdeDataType.String, 10),
        new JdeField("SDPSN", "SDPSN", JdeDataType.Numeric),
        new JdeField("SDDELN", "SDDELN", JdeDataType.Numeric),
        new JdeField("SDTAX1", "SDTAX1", JdeDataType.String, 2),
        new JdeField("SDTXA1", "SDTXA1", JdeDataType.String, 20),
        new JdeField("SDEXR1", "SDEXR1", JdeDataType.String, 4),
        new JdeField("SDATXT", "SDATXT", JdeDataType.String, 2),
        new JdeField("SDPRIO", "SDPRIO", JdeDataType.String, 2),
        new JdeField("SDRESL", "SDRESL", JdeDataType.String, 2),
        new JdeField("SDBACK", "SDBACK", JdeDataType.String, 2),
        new JdeField("SDSBAL", "SDSBAL", JdeDataType.String, 2),
        new JdeField("SDAPTS", "SDAPTS", JdeDataType.String, 2),
        new JdeField("SDLOB", "SDLOB", JdeDataType.String, 6),
        new JdeField("SDEUSE", "SDEUSE", JdeDataType.String, 6),
        new JdeField("SDDTYS", "SDDTYS", JdeDataType.String, 4),
        new JdeField("SDNTR", "SDNTR", JdeDataType.String, 4),
        new JdeField("SDVEND", "SDVEND", JdeDataType.Numeric),
        new JdeField("SDCARS", "SDCARS", JdeDataType.Numeric),
        new JdeField("SDMOT", "SDMOT", JdeDataType.String, 6),
        new JdeField("SDROUT", "SDROUT", JdeDataType.String, 6),
        new JdeField("SDSTOP", "SDSTOP", JdeDataType.String, 6),
        new JdeField("SDZON", "SDZON", JdeDataType.String, 6),
        new JdeField("SDCNID", "SDCNID", JdeDataType.String, 40),
        new JdeField("SDFRTH", "SDFRTH", JdeDataType.String, 6),
        new JdeField("SDSHCM", "SDSHCM", JdeDataType.String, 6),
        new JdeField("SDSHCN", "SDSHCN", JdeDataType.String, 6),
        new JdeField("SDSERN", "SDSERN", JdeDataType.String, 60),
        new JdeField("SDUOM1", "SDUOM1", JdeDataType.String, 4),
        new JdeField("SDPQOR", "SDPQOR", JdeDataType.Numeric),
        new JdeField("SDUOM2", "SDUOM2", JdeDataType.String, 4),
        new JdeField("SDSQOR", "SDSQOR", JdeDataType.Numeric),
        new JdeField("SDUOM4", "SDUOM4", JdeDataType.String, 4),
        new JdeField("SDITWT", "SDITWT", JdeDataType.Numeric),
        new JdeField("SDWTUM", "SDWTUM", JdeDataType.String, 4),
        new JdeField("SDITVL", "SDITVL", JdeDataType.Numeric),
        new JdeField("SDVLUM", "SDVLUM", JdeDataType.String, 4),
        new JdeField("SDRPRC", "SDRPRC", JdeDataType.String, 16),
        new JdeField("SDORPR", "SDORPR", JdeDataType.String, 16),
        new JdeField("SDORP", "SDORP", JdeDataType.String, 2),
        new JdeField("SDCMGP", "SDCMGP", JdeDataType.String, 4),
        new JdeField("SDGLC", "SDGLC", JdeDataType.String, 8),
        new JdeField("SDCTRY", "SDCTRY", JdeDataType.Numeric),
        new JdeField("SDFY", "SDFY", JdeDataType.Numeric),
        new JdeField("SDSO01", "SDSO01", JdeDataType.String, 2),
        new JdeField("SDSO02", "SDSO02", JdeDataType.String, 2),
        new JdeField("SDSO03", "SDSO03", JdeDataType.String, 2),
        new JdeField("SDSO04", "SDSO04", JdeDataType.String, 2),
        new JdeField("SDSO05", "SDSO05", JdeDataType.String, 2),
        new JdeField("SDSO06", "SDSO06", JdeDataType.String, 2),
        new JdeField("SDSO07", "SDSO07", JdeDataType.String, 2),
        new JdeField("SDSO08", "SDSO08", JdeDataType.String, 2),
        new JdeField("SDSO09", "SDSO09", JdeDataType.String, 2),
        new JdeField("SDSO10", "SDSO10", JdeDataType.String, 2),
        new JdeField("SDSO11", "SDSO11", JdeDataType.String, 2),
        new JdeField("SDSO12", "SDSO12", JdeDataType.String, 2),
        new JdeField("SDSO13", "SDSO13", JdeDataType.String, 2),
        new JdeField("SDSO14", "SDSO14", JdeDataType.String, 2),
        new JdeField("SDSO15", "SDSO15", JdeDataType.String, 2),
        new JdeField("SDACOM", "SDACOM", JdeDataType.String, 2),
        new JdeField("SDCMCG", "SDCMCG", JdeDataType.String, 16),
        new JdeField("SDRCD", "SDRCD", JdeDataType.String, 6),
        new JdeField("SDGRWT", "SDGRWT", JdeDataType.Numeric),
        new JdeField("SDGWUM", "SDGWUM", JdeDataType.String, 4),
        new JdeField("SDSBL", "SDSBL", JdeDataType.String, 16),
        new JdeField("SDSBLT", "SDSBLT", JdeDataType.String, 2),
        new JdeField("SDLCOD", "SDLCOD", JdeDataType.String, 4),
        new JdeField("SDUPC1", "SDUPC1", JdeDataType.String, 4),
        new JdeField("SDUPC2", "SDUPC2", JdeDataType.String, 4),
        new JdeField("SDUPC3", "SDUPC3", JdeDataType.String, 4),
        new JdeField("SDSWMS", "SDSWMS", JdeDataType.String, 2),
        new JdeField("SDUNCD", "SDUNCD", JdeDataType.String, 2),
        new JdeField("SDCRMD", "SDCRMD", JdeDataType.String, 2),
        new JdeField("SDCRCD", "SDCRCD", JdeDataType.String, 6),
        new JdeField("SDCRR", "SDCRR", JdeDataType.Numeric),
        new JdeField("SDFPRC", "SDFPRC", JdeDataType.Numeric),
        new JdeField("SDFUP", "SDFUP", JdeDataType.Numeric),
        new JdeField("SDFEA", "SDFEA", JdeDataType.Numeric),
        new JdeField("SDFUC", "SDFUC", JdeDataType.Numeric),
        new JdeField("SDFEC", "SDFEC", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDTORG", "SDTORG", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric),
        new JdeField("SDSO16", "SDSO16", JdeDataType.String, 2),
        new JdeField("SDSO17", "SDSO17", JdeDataType.String, 2),
        new JdeField("SDSO18", "SDSO18", JdeDataType.String, 2),
        new JdeField("SDSO19", "SDSO19", JdeDataType.String, 2),
        new JdeField("SDSO20", "SDSO20", JdeDataType.String, 2),
        new JdeField("SDIR01", "SDIR01", JdeDataType.String, 60),
        new JdeField("SDIR02", "SDIR02", JdeDataType.String, 60),
        new JdeField("SDIR03", "SDIR03", JdeDataType.String, 60),
        new JdeField("SDIR04", "SDIR04", JdeDataType.String, 60),
        new JdeField("SDIR05", "SDIR05", JdeDataType.String, 60),
        new JdeField("SDSOOR", "SDSOOR", JdeDataType.Numeric),
        new JdeField("SDVR03", "SDVR03", JdeDataType.String, 50),
        new JdeField("SDDEID", "SDDEID", JdeDataType.Numeric),
        new JdeField("SDPSIG", "SDPSIG", JdeDataType.String, 60),
        new JdeField("SDRLNU", "SDRLNU", JdeDataType.String, 20),
        new JdeField("SDPMDT", "SDPMDT", JdeDataType.Numeric),
        new JdeField("SDRLTM", "SDRLTM", JdeDataType.Numeric),
        new JdeField("SDRLDJ", "SDRLDJ", JdeDataType.Numeric),
        new JdeField("SDDRQT", "SDDRQT", JdeDataType.Numeric),
        new JdeField("SDADTM", "SDADTM", JdeDataType.Numeric),
        new JdeField("SDOPTT", "SDOPTT", JdeDataType.Numeric),
        new JdeField("SDPDTT", "SDPDTT", JdeDataType.Numeric),
        new JdeField("SDPSTM", "SDPSTM", JdeDataType.Numeric),
        new JdeField("SDXDCK", "SDXDCK", JdeDataType.String, 2),
        new JdeField("SDXPTY", "SDXPTY", JdeDataType.Numeric),
        new JdeField("SDDUAL", "SDDUAL", JdeDataType.String, 2),
        new JdeField("SDBSC", "SDBSC", JdeDataType.String, 20),
        new JdeField("SDCBSC", "SDCBSC", JdeDataType.String, 20),
        new JdeField("SDCORD", "SDCORD", JdeDataType.Numeric),
        new JdeField("SDDVAN", "SDDVAN", JdeDataType.Numeric),
        new JdeField("SDPEND", "SDPEND", JdeDataType.String, 2),
        new JdeField("SDRFRV", "SDRFRV", JdeDataType.String, 6),
        new JdeField("SDMCLN", "SDMCLN", JdeDataType.Numeric),
        new JdeField("SDSHPN", "SDSHPN", JdeDataType.Numeric),
        new JdeField("SDRSDT", "SDRSDT", JdeDataType.Numeric),
        new JdeField("SDPRJM", "SDPRJM", JdeDataType.Numeric),
        new JdeField("SDOSEQ", "SDOSEQ", JdeDataType.Numeric),
        new JdeField("SDMERL", "SDMERL", JdeDataType.String, 6),
        new JdeField("SDHOLD", "SDHOLD", JdeDataType.String, 4),
        new JdeField("SDHDBU", "SDHDBU", JdeDataType.String, 24),
        new JdeField("SDDMBU", "SDDMBU", JdeDataType.String, 24),
        new JdeField("SDBCRC", "SDBCRC", JdeDataType.String, 6),
        new JdeField("SDODLN", "SDODLN", JdeDataType.Numeric),
        new JdeField("SDOPDJ", "SDOPDJ", JdeDataType.Numeric),
        new JdeField("SDXKCO", "SDXKCO", JdeDataType.String, 10),
        new JdeField("SDXORN", "SDXORN", JdeDataType.Numeric),
        new JdeField("SDXCTO", "SDXCTO", JdeDataType.String, 4),
        new JdeField("SDXLLN", "SDXLLN", JdeDataType.Numeric),
        new JdeField("SDXSFX", "SDXSFX", JdeDataType.String, 6),
        new JdeField("SDPOE", "SDPOE", JdeDataType.String, 12),
        new JdeField("SDPMTO", "SDPMTO", JdeDataType.String, 2),
        new JdeField("SDANBY", "SDANBY", JdeDataType.Numeric),
        new JdeField("SDPMTN", "SDPMTN", JdeDataType.String, 24),
        new JdeField("SDNUMB", "SDNUMB", JdeDataType.Numeric),
        new JdeField("SDAAID", "SDAAID", JdeDataType.Numeric),
        new JdeField("SDSPATTN", "SDSPATTN", JdeDataType.String, 100),
        new JdeField("SDPRAN8", "SDPRAN8", JdeDataType.Numeric),
        new JdeField("SDPRCIDLN", "SDPRCIDLN", JdeDataType.Numeric),
        new JdeField("SDCCIDLN", "SDCCIDLN", JdeDataType.Numeric),
        new JdeField("SDSHCCIDLN", "SDSHCCIDLN", JdeDataType.Numeric),
        new JdeField("SDOPPID", "SDOPPID", JdeDataType.Numeric),
        new JdeField("SDOSTP", "SDOSTP", JdeDataType.String, 6),
        new JdeField("SDUKID", "SDUKID", JdeDataType.Numeric),
        new JdeField("SDCATNM", "SDCATNM", JdeDataType.String, 60),
        new JdeField("SDALLOC", "SDALLOC", JdeDataType.String, 2),
        new JdeField("SDFULPID", "SDFULPID", JdeDataType.Numeric),
        new JdeField("SDALLSTS", "SDALLSTS", JdeDataType.String, 60),
        new JdeField("SDOSCORE", "SDOSCORE", JdeDataType.Numeric),
        new JdeField("SDOSCOREO", "SDOSCOREO", JdeDataType.String, 2),
        new JdeField("SDCMCO", "SDCMCO", JdeDataType.String, 10),
        new JdeField("SDKITID", "SDKITID", JdeDataType.Numeric),
        new JdeField("SDKITAMTDOM", "SDKITAMTDOM", JdeDataType.Numeric),
        new JdeField("SDKITAMTFOR", "SDKITAMTFOR", JdeDataType.Numeric),
        new JdeField("SDKITDIRTY", "SDKITDIRTY", JdeDataType.String, 2),
        new JdeField("SDOCITT", "SDOCITT", JdeDataType.String, 2),
        new JdeField("SDOCCARDNO", "SDOCCARDNO", JdeDataType.Numeric),
        new JdeField("SDPMPN", "SDPMPN", JdeDataType.String, 60),
        new JdeField("SDPNS", "SDPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211_0", "Primary Key on SDDOCO, SDDCTO, SDKCOO, SDLNID", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4211_10", "Index on SDOORN, SDOCTO, SDOKCO", new[] { "SDOORN", "SDOCTO", "SDOKCO" }),
        new JdeIndex("F4211_11", "Index on SDXORN, SDXCTO, SDXKCO, SDXSFX, SDXLLN, SDXPTY", new[] { "SDXORN", "SDXCTO", "SDXKCO", "SDXSFX", "SDXLLN", "SDXPTY" }),
        new JdeIndex("F4211_12", "Index on SDMCU, SDAN8, SDSHAN, SDPPDJ, SDPMDT, SDVR01", new[] { "SDMCU", "SDAN8", "SDSHAN", "SDPPDJ", "SDPMDT", "SDVR01" }),
        new JdeIndex("F4211_13", "Index on SDDEID", new[] { "SDDEID" }),
        new JdeIndex("F4211_14", "Index on SDDOC, SDDCT, SDKCO", new[] { "SDDOC", "SDDCT", "SDKCO" }),
        new JdeIndex("F4211_15", "Index on SDDOCO, SDSO16", new[] { "SDDOCO", "SDSO16" }),
        new JdeIndex("F4211_16", "Index on SDDOCO, SDDCTO, SDKCOO, SDKITID, SDLNID", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDKITID", "SDLNID" }),
        new JdeIndex("F4211_17", "Index on SDFULPID, SDOSCORE", new[] { "SDFULPID", "SDOSCORE" }),
        new JdeIndex("F4211_18", "Index on SDTRDJ, SDAN8, SDITM, SDUPRC, SDUNCS, SDAEXP, SDECST, SDDOCO, SDMCU, SDUOM4, SDCMCO, SDKCOO, SDKTLN, SDUORG, SDLTTR, SDDCTO", new[] { "SDTRDJ", "SDAN8", "SDITM", "SDUPRC", "SDUNCS", "SDAEXP", "SDECST", "SDDOCO", "SDMCU", "SDUOM4", "SDCMCO", "SDKCOO", "SDKTLN", "SDUORG", "SDLTTR", "SDDCTO" }),
        new JdeIndex("F4211_19", "Index on SDITM, SDMCU, SDALLOC, SDKTLN, SDOSCORE, SDUOM, SDALLSTS, SDSOQS, SDSONE", new[] { "SDITM", "SDMCU", "SDALLOC", "SDKTLN", "SDOSCORE", "SDUOM", "SDALLSTS", "SDSOQS", "SDSONE" }),
        new JdeIndex("F4211_2", "Index on SDDCTO, SDNXTR, SDLNTY", new[] { "SDDCTO", "SDNXTR", "SDLNTY" }),
        new JdeIndex("F4211_20", "Index on SDAN8, SDITM, SYS_NC00269$, SDDOCO", new[] { "SDAN8", "SDITM", "SYS_NC00269$", "SDDOCO" }),
        new JdeIndex("F4211_21", "Index on SDDOCO, SDDCTO", new[] { "SDDOCO", "SDDCTO" }),
        new JdeIndex("F4211_22", "Index on SDRORN", new[] { "SDRORN" }),
        new JdeIndex("F4211_3", "Index on SDAN8, SDTRDJ", new[] { "SDAN8", "SDTRDJ" }),
        new JdeIndex("F4211_4", "Index on SDSHAN", new[] { "SDSHAN" }),
        new JdeIndex("F4211_5", "Index on SDPSN", new[] { "SDPSN" }),
        new JdeIndex("F4211_6", "Index on SDITM, SDMCU, SDPDDJ, SDPDTT", new[] { "SDITM", "SDMCU", "SDPDDJ", "SDPDTT" }),
        new JdeIndex("F4211_7", "Index on SDAN8, SDITM, SDUOM, SDCRCD, SDOTQY, SDDCTO, SDDOCO", new[] { "SDAN8", "SDITM", "SDUOM", "SDCRCD", "SDOTQY", "SDDCTO", "SDDOCO" }),
        new JdeIndex("F4211_8", "Index on SDSHPN, SDDOCO, SDDCTO, SDKCOO, SDLNID", new[] { "SDSHPN", "SDDOCO", "SDDCTO", "SDKCOO", "SDLNID" }),
        new JdeIndex("F4211_9", "Index on SDITM, SDMCU, SDDRQJ", new[] { "SDITM", "SDMCU", "SDDRQJ" })
    };
}
