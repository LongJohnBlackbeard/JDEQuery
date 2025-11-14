using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47107 - .
/// </summary>
public class F47107 : JdeTable
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
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZOKCO.
        /// </summary>
        public const string SZOKCO = "SZOKCO";

        /// <summary>
        /// SZOORN.
        /// </summary>
        public const string SZOORN = "SZOORN";

        /// <summary>
        /// SZOCTO.
        /// </summary>
        public const string SZOCTO = "SZOCTO";

        /// <summary>
        /// SZOGNO.
        /// </summary>
        public const string SZOGNO = "SZOGNO";

        /// <summary>
        /// SZRKCO.
        /// </summary>
        public const string SZRKCO = "SZRKCO";

        /// <summary>
        /// SZRORN.
        /// </summary>
        public const string SZRORN = "SZRORN";

        /// <summary>
        /// SZRCTO.
        /// </summary>
        public const string SZRCTO = "SZRCTO";

        /// <summary>
        /// SZRLLN.
        /// </summary>
        public const string SZRLLN = "SZRLLN";

        /// <summary>
        /// SZDMCT.
        /// </summary>
        public const string SZDMCT = "SZDMCT";

        /// <summary>
        /// SZDMCS.
        /// </summary>
        public const string SZDMCS = "SZDMCS";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZSHAN.
        /// </summary>
        public const string SZSHAN = "SZSHAN";

        /// <summary>
        /// SZPA8.
        /// </summary>
        public const string SZPA8 = "SZPA8";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZPDDJ.
        /// </summary>
        public const string SZPDDJ = "SZPDDJ";

        /// <summary>
        /// SZOPDJ.
        /// </summary>
        public const string SZOPDJ = "SZOPDJ";

        /// <summary>
        /// SZADDJ.
        /// </summary>
        public const string SZADDJ = "SZADDJ";

        /// <summary>
        /// SZIVD.
        /// </summary>
        public const string SZIVD = "SZIVD";

        /// <summary>
        /// SZCNDJ.
        /// </summary>
        public const string SZCNDJ = "SZCNDJ";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZRSDJ.
        /// </summary>
        public const string SZRSDJ = "SZRSDJ";

        /// <summary>
        /// SZPEFJ.
        /// </summary>
        public const string SZPEFJ = "SZPEFJ";

        /// <summary>
        /// SZPPDJ.
        /// </summary>
        public const string SZPPDJ = "SZPPDJ";

        /// <summary>
        /// SZPSDJ.
        /// </summary>
        public const string SZPSDJ = "SZPSDJ";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZVR02.
        /// </summary>
        public const string SZVR02 = "SZVR02";

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
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

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
        /// SZEXDP.
        /// </summary>
        public const string SZEXDP = "SZEXDP";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZNXTR.
        /// </summary>
        public const string SZNXTR = "SZNXTR";

        /// <summary>
        /// SZLTTR.
        /// </summary>
        public const string SZLTTR = "SZLTTR";

        /// <summary>
        /// SZEMCU.
        /// </summary>
        public const string SZEMCU = "SZEMCU";

        /// <summary>
        /// SZRLIT.
        /// </summary>
        public const string SZRLIT = "SZRLIT";

        /// <summary>
        /// SZKTLN.
        /// </summary>
        public const string SZKTLN = "SZKTLN";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZRKIT.
        /// </summary>
        public const string SZRKIT = "SZRKIT";

        /// <summary>
        /// SZKTP.
        /// </summary>
        public const string SZKTP = "SZKTP";

        /// <summary>
        /// SZSRP1.
        /// </summary>
        public const string SZSRP1 = "SZSRP1";

        /// <summary>
        /// SZSRP2.
        /// </summary>
        public const string SZSRP2 = "SZSRP2";

        /// <summary>
        /// SZSRP3.
        /// </summary>
        public const string SZSRP3 = "SZSRP3";

        /// <summary>
        /// SZSRP4.
        /// </summary>
        public const string SZSRP4 = "SZSRP4";

        /// <summary>
        /// SZSRP5.
        /// </summary>
        public const string SZSRP5 = "SZSRP5";

        /// <summary>
        /// SZPRP1.
        /// </summary>
        public const string SZPRP1 = "SZPRP1";

        /// <summary>
        /// SZPRP2.
        /// </summary>
        public const string SZPRP2 = "SZPRP2";

        /// <summary>
        /// SZPRP3.
        /// </summary>
        public const string SZPRP3 = "SZPRP3";

        /// <summary>
        /// SZPRP4.
        /// </summary>
        public const string SZPRP4 = "SZPRP4";

        /// <summary>
        /// SZPRP5.
        /// </summary>
        public const string SZPRP5 = "SZPRP5";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZSOQS.
        /// </summary>
        public const string SZSOQS = "SZSOQS";

        /// <summary>
        /// SZSOBK.
        /// </summary>
        public const string SZSOBK = "SZSOBK";

        /// <summary>
        /// SZSOCN.
        /// </summary>
        public const string SZSOCN = "SZSOCN";

        /// <summary>
        /// SZSONE.
        /// </summary>
        public const string SZSONE = "SZSONE";

        /// <summary>
        /// SZUOPN.
        /// </summary>
        public const string SZUOPN = "SZUOPN";

        /// <summary>
        /// SZQTYT.
        /// </summary>
        public const string SZQTYT = "SZQTYT";

        /// <summary>
        /// SZQRLV.
        /// </summary>
        public const string SZQRLV = "SZQRLV";

        /// <summary>
        /// SZCOMM.
        /// </summary>
        public const string SZCOMM = "SZCOMM";

        /// <summary>
        /// SZOTQY.
        /// </summary>
        public const string SZOTQY = "SZOTQY";

        /// <summary>
        /// SZUPRC.
        /// </summary>
        public const string SZUPRC = "SZUPRC";

        /// <summary>
        /// SZAEXP.
        /// </summary>
        public const string SZAEXP = "SZAEXP";

        /// <summary>
        /// SZAOPN.
        /// </summary>
        public const string SZAOPN = "SZAOPN";

        /// <summary>
        /// SZPROV.
        /// </summary>
        public const string SZPROV = "SZPROV";

        /// <summary>
        /// SZTPC.
        /// </summary>
        public const string SZTPC = "SZTPC";

        /// <summary>
        /// SZAPUM.
        /// </summary>
        public const string SZAPUM = "SZAPUM";

        /// <summary>
        /// SZLPRC.
        /// </summary>
        public const string SZLPRC = "SZLPRC";

        /// <summary>
        /// SZUNCS.
        /// </summary>
        public const string SZUNCS = "SZUNCS";

        /// <summary>
        /// SZECST.
        /// </summary>
        public const string SZECST = "SZECST";

        /// <summary>
        /// SZCSTO.
        /// </summary>
        public const string SZCSTO = "SZCSTO";

        /// <summary>
        /// SZTCST.
        /// </summary>
        public const string SZTCST = "SZTCST";

        /// <summary>
        /// SZINMG.
        /// </summary>
        public const string SZINMG = "SZINMG";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZRYIN.
        /// </summary>
        public const string SZRYIN = "SZRYIN";

        /// <summary>
        /// SZDTBS.
        /// </summary>
        public const string SZDTBS = "SZDTBS";

        /// <summary>
        /// SZTRDC.
        /// </summary>
        public const string SZTRDC = "SZTRDC";

        /// <summary>
        /// SZFUN2.
        /// </summary>
        public const string SZFUN2 = "SZFUN2";

        /// <summary>
        /// SZASN.
        /// </summary>
        public const string SZASN = "SZASN";

        /// <summary>
        /// SZPRGR.
        /// </summary>
        public const string SZPRGR = "SZPRGR";

        /// <summary>
        /// SZCLVL.
        /// </summary>
        public const string SZCLVL = "SZCLVL";

        /// <summary>
        /// SZDSPR.
        /// </summary>
        public const string SZDSPR = "SZDSPR";

        /// <summary>
        /// SZDSFT.
        /// </summary>
        public const string SZDSFT = "SZDSFT";

        /// <summary>
        /// SZFAPP.
        /// </summary>
        public const string SZFAPP = "SZFAPP";

        /// <summary>
        /// SZCADC.
        /// </summary>
        public const string SZCADC = "SZCADC";

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
        /// SZODOC.
        /// </summary>
        public const string SZODOC = "SZODOC";

        /// <summary>
        /// SZODCT.
        /// </summary>
        public const string SZODCT = "SZODCT";

        /// <summary>
        /// SZOKC.
        /// </summary>
        public const string SZOKC = "SZOKC";

        /// <summary>
        /// SZPSN.
        /// </summary>
        public const string SZPSN = "SZPSN";

        /// <summary>
        /// SZDELN.
        /// </summary>
        public const string SZDELN = "SZDELN";

        /// <summary>
        /// SZTAX1.
        /// </summary>
        public const string SZTAX1 = "SZTAX1";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZATXT.
        /// </summary>
        public const string SZATXT = "SZATXT";

        /// <summary>
        /// SZPRIO.
        /// </summary>
        public const string SZPRIO = "SZPRIO";

        /// <summary>
        /// SZRESL.
        /// </summary>
        public const string SZRESL = "SZRESL";

        /// <summary>
        /// SZBACK.
        /// </summary>
        public const string SZBACK = "SZBACK";

        /// <summary>
        /// SZSBAL.
        /// </summary>
        public const string SZSBAL = "SZSBAL";

        /// <summary>
        /// SZAPTS.
        /// </summary>
        public const string SZAPTS = "SZAPTS";

        /// <summary>
        /// SZLOB.
        /// </summary>
        public const string SZLOB = "SZLOB";

        /// <summary>
        /// SZEUSE.
        /// </summary>
        public const string SZEUSE = "SZEUSE";

        /// <summary>
        /// SZDTYS.
        /// </summary>
        public const string SZDTYS = "SZDTYS";

        /// <summary>
        /// SZNTR.
        /// </summary>
        public const string SZNTR = "SZNTR";

        /// <summary>
        /// SZVEND.
        /// </summary>
        public const string SZVEND = "SZVEND";

        /// <summary>
        /// SZANBY.
        /// </summary>
        public const string SZANBY = "SZANBY";

        /// <summary>
        /// SZCARS.
        /// </summary>
        public const string SZCARS = "SZCARS";

        /// <summary>
        /// SZMOT.
        /// </summary>
        public const string SZMOT = "SZMOT";

        /// <summary>
        /// SZCOT.
        /// </summary>
        public const string SZCOT = "SZCOT";

        /// <summary>
        /// SZROUT.
        /// </summary>
        public const string SZROUT = "SZROUT";

        /// <summary>
        /// SZSTOP.
        /// </summary>
        public const string SZSTOP = "SZSTOP";

        /// <summary>
        /// SZZON.
        /// </summary>
        public const string SZZON = "SZZON";

        /// <summary>
        /// SZCNID.
        /// </summary>
        public const string SZCNID = "SZCNID";

        /// <summary>
        /// SZFRTH.
        /// </summary>
        public const string SZFRTH = "SZFRTH";

        /// <summary>
        /// SZAFT.
        /// </summary>
        public const string SZAFT = "SZAFT";

        /// <summary>
        /// SZFUF1.
        /// </summary>
        public const string SZFUF1 = "SZFUF1";

        /// <summary>
        /// SZFRTC.
        /// </summary>
        public const string SZFRTC = "SZFRTC";

        /// <summary>
        /// SZFRAT.
        /// </summary>
        public const string SZFRAT = "SZFRAT";

        /// <summary>
        /// SZRATT.
        /// </summary>
        public const string SZRATT = "SZRATT";

        /// <summary>
        /// SZSHCM.
        /// </summary>
        public const string SZSHCM = "SZSHCM";

        /// <summary>
        /// SZSHCN.
        /// </summary>
        public const string SZSHCN = "SZSHCN";

        /// <summary>
        /// SZSERN.
        /// </summary>
        public const string SZSERN = "SZSERN";

        /// <summary>
        /// SZUOM1.
        /// </summary>
        public const string SZUOM1 = "SZUOM1";

        /// <summary>
        /// SZPQOR.
        /// </summary>
        public const string SZPQOR = "SZPQOR";

        /// <summary>
        /// SZUOM2.
        /// </summary>
        public const string SZUOM2 = "SZUOM2";

        /// <summary>
        /// SZSQOR.
        /// </summary>
        public const string SZSQOR = "SZSQOR";

        /// <summary>
        /// SZUOM4.
        /// </summary>
        public const string SZUOM4 = "SZUOM4";

        /// <summary>
        /// SZITWT.
        /// </summary>
        public const string SZITWT = "SZITWT";

        /// <summary>
        /// SZWTUM.
        /// </summary>
        public const string SZWTUM = "SZWTUM";

        /// <summary>
        /// SZITVL.
        /// </summary>
        public const string SZITVL = "SZITVL";

        /// <summary>
        /// SZVLUM.
        /// </summary>
        public const string SZVLUM = "SZVLUM";

        /// <summary>
        /// SZRPRC.
        /// </summary>
        public const string SZRPRC = "SZRPRC";

        /// <summary>
        /// SZORPR.
        /// </summary>
        public const string SZORPR = "SZORPR";

        /// <summary>
        /// SZORP.
        /// </summary>
        public const string SZORP = "SZORP";

        /// <summary>
        /// SZCMGP.
        /// </summary>
        public const string SZCMGP = "SZCMGP";

        /// <summary>
        /// SZCMGL.
        /// </summary>
        public const string SZCMGL = "SZCMGL";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZSTTS.
        /// </summary>
        public const string SZSTTS = "SZSTTS";

        /// <summary>
        /// SZSO01.
        /// </summary>
        public const string SZSO01 = "SZSO01";

        /// <summary>
        /// SZSO02.
        /// </summary>
        public const string SZSO02 = "SZSO02";

        /// <summary>
        /// SZSO03.
        /// </summary>
        public const string SZSO03 = "SZSO03";

        /// <summary>
        /// SZSO04.
        /// </summary>
        public const string SZSO04 = "SZSO04";

        /// <summary>
        /// SZSO05.
        /// </summary>
        public const string SZSO05 = "SZSO05";

        /// <summary>
        /// SZSO06.
        /// </summary>
        public const string SZSO06 = "SZSO06";

        /// <summary>
        /// SZSO07.
        /// </summary>
        public const string SZSO07 = "SZSO07";

        /// <summary>
        /// SZSO08.
        /// </summary>
        public const string SZSO08 = "SZSO08";

        /// <summary>
        /// SZSO09.
        /// </summary>
        public const string SZSO09 = "SZSO09";

        /// <summary>
        /// SZSO10.
        /// </summary>
        public const string SZSO10 = "SZSO10";

        /// <summary>
        /// SZSO11.
        /// </summary>
        public const string SZSO11 = "SZSO11";

        /// <summary>
        /// SZSO12.
        /// </summary>
        public const string SZSO12 = "SZSO12";

        /// <summary>
        /// SZSO14.
        /// </summary>
        public const string SZSO14 = "SZSO14";

        /// <summary>
        /// SZSO15.
        /// </summary>
        public const string SZSO15 = "SZSO15";

        /// <summary>
        /// SZACOM.
        /// </summary>
        public const string SZACOM = "SZACOM";

        /// <summary>
        /// SZCMCG.
        /// </summary>
        public const string SZCMCG = "SZCMCG";

        /// <summary>
        /// SZRCD.
        /// </summary>
        public const string SZRCD = "SZRCD";

        /// <summary>
        /// SZGRWT.
        /// </summary>
        public const string SZGRWT = "SZGRWT";

        /// <summary>
        /// SZGWUM.
        /// </summary>
        public const string SZGWUM = "SZGWUM";

        /// <summary>
        /// SZANI.
        /// </summary>
        public const string SZANI = "SZANI";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

        /// <summary>
        /// SZOMCU.
        /// </summary>
        public const string SZOMCU = "SZOMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZLT.
        /// </summary>
        public const string SZLT = "SZLT";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZLCOD.
        /// </summary>
        public const string SZLCOD = "SZLCOD";

        /// <summary>
        /// SZUPC1.
        /// </summary>
        public const string SZUPC1 = "SZUPC1";

        /// <summary>
        /// SZUPC2.
        /// </summary>
        public const string SZUPC2 = "SZUPC2";

        /// <summary>
        /// SZUPC3.
        /// </summary>
        public const string SZUPC3 = "SZUPC3";

        /// <summary>
        /// SZSWMS.
        /// </summary>
        public const string SZSWMS = "SZSWMS";

        /// <summary>
        /// SZUNCD.
        /// </summary>
        public const string SZUNCD = "SZUNCD";

        /// <summary>
        /// SZCRMD.
        /// </summary>
        public const string SZCRMD = "SZCRMD";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZFPRC.
        /// </summary>
        public const string SZFPRC = "SZFPRC";

        /// <summary>
        /// SZFUP.
        /// </summary>
        public const string SZFUP = "SZFUP";

        /// <summary>
        /// SZFEA.
        /// </summary>
        public const string SZFEA = "SZFEA";

        /// <summary>
        /// SZFUC.
        /// </summary>
        public const string SZFUC = "SZFUC";

        /// <summary>
        /// SZFEC.
        /// </summary>
        public const string SZFEC = "SZFEC";

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
        /// SZADTM.
        /// </summary>
        public const string SZADTM = "SZADTM";

        /// <summary>
        /// SZBSC.
        /// </summary>
        public const string SZBSC = "SZBSC";

        /// <summary>
        /// SZCBSC.
        /// </summary>
        public const string SZCBSC = "SZCBSC";

        /// <summary>
        /// SZDVAN.
        /// </summary>
        public const string SZDVAN = "SZDVAN";

        /// <summary>
        /// SZDEID.
        /// </summary>
        public const string SZDEID = "SZDEID";

        /// <summary>
        /// SZDUAL.
        /// </summary>
        public const string SZDUAL = "SZDUAL";

        /// <summary>
        /// SZOPTT.
        /// </summary>
        public const string SZOPTT = "SZOPTT";

        /// <summary>
        /// SZPDTT.
        /// </summary>
        public const string SZPDTT = "SZPDTT";

        /// <summary>
        /// SZPRJM.
        /// </summary>
        public const string SZPRJM = "SZPRJM";

        /// <summary>
        /// SZPMTN.
        /// </summary>
        public const string SZPMTN = "SZPMTN";

        /// <summary>
        /// SZPSIG.
        /// </summary>
        public const string SZPSIG = "SZPSIG";

        /// <summary>
        /// SZPSTM.
        /// </summary>
        public const string SZPSTM = "SZPSTM";

        /// <summary>
        /// SZRFRV.
        /// </summary>
        public const string SZRFRV = "SZRFRV";

        /// <summary>
        /// SZRLDJ.
        /// </summary>
        public const string SZRLDJ = "SZRLDJ";

        /// <summary>
        /// SZRLNU.
        /// </summary>
        public const string SZRLNU = "SZRLNU";

        /// <summary>
        /// SZRLTM.
        /// </summary>
        public const string SZRLTM = "SZRLTM";

        /// <summary>
        /// SZPMDT.
        /// </summary>
        public const string SZPMDT = "SZPMDT";

        /// <summary>
        /// SZSOOR.
        /// </summary>
        public const string SZSOOR = "SZSOOR";

        /// <summary>
        /// SZIR01.
        /// </summary>
        public const string SZIR01 = "SZIR01";

        /// <summary>
        /// SZIR02.
        /// </summary>
        public const string SZIR02 = "SZIR02";

        /// <summary>
        /// SZIR03.
        /// </summary>
        public const string SZIR03 = "SZIR03";

        /// <summary>
        /// SZIR04.
        /// </summary>
        public const string SZIR04 = "SZIR04";

        /// <summary>
        /// SZIR05.
        /// </summary>
        public const string SZIR05 = "SZIR05";

        /// <summary>
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZSO13.
        /// </summary>
        public const string SZSO13 = "SZSO13";

        /// <summary>
        /// SZDRQT.
        /// </summary>
        public const string SZDRQT = "SZDRQT";

        /// <summary>
        /// SZHOLD.
        /// </summary>
        public const string SZHOLD = "SZHOLD";

        /// <summary>
        /// SZPMTO.
        /// </summary>
        public const string SZPMTO = "SZPMTO";

        /// <summary>
        /// SZGAN8.
        /// </summary>
        public const string SZGAN8 = "SZGAN8";

        /// <summary>
        /// SZGSHAN.
        /// </summary>
        public const string SZGSHAN = "SZGSHAN";

        /// <summary>
        /// SZGPA8.
        /// </summary>
        public const string SZGPA8 = "SZGPA8";

        /// <summary>
        /// SZGCARS.
        /// </summary>
        public const string SZGCARS = "SZGCARS";

        /// <summary>
        /// SZGDVAN.
        /// </summary>
        public const string SZGDVAN = "SZGDVAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47107";

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
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZOKCO", "SZOKCO", JdeDataType.String, 10),
        new JdeField("SZOORN", "SZOORN", JdeDataType.String, 16),
        new JdeField("SZOCTO", "SZOCTO", JdeDataType.String, 4),
        new JdeField("SZOGNO", "SZOGNO", JdeDataType.Numeric),
        new JdeField("SZRKCO", "SZRKCO", JdeDataType.String, 10),
        new JdeField("SZRORN", "SZRORN", JdeDataType.String, 16),
        new JdeField("SZRCTO", "SZRCTO", JdeDataType.String, 4),
        new JdeField("SZRLLN", "SZRLLN", JdeDataType.Numeric),
        new JdeField("SZDMCT", "SZDMCT", JdeDataType.String, 24),
        new JdeField("SZDMCS", "SZDMCS", JdeDataType.Numeric),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZSHAN", "SZSHAN", JdeDataType.Numeric),
        new JdeField("SZPA8", "SZPA8", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZOPDJ", "SZOPDJ", JdeDataType.Numeric),
        new JdeField("SZADDJ", "SZADDJ", JdeDataType.Numeric),
        new JdeField("SZIVD", "SZIVD", JdeDataType.Numeric),
        new JdeField("SZCNDJ", "SZCNDJ", JdeDataType.Numeric),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZRSDJ", "SZRSDJ", JdeDataType.Numeric),
        new JdeField("SZPEFJ", "SZPEFJ", JdeDataType.Numeric),
        new JdeField("SZPPDJ", "SZPPDJ", JdeDataType.Numeric),
        new JdeField("SZPSDJ", "SZPSDJ", JdeDataType.Numeric),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZCITM", "SZCITM", JdeDataType.String, 50),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZEXDP", "SZEXDP", JdeDataType.Numeric),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZNXTR", "SZNXTR", JdeDataType.String, 6),
        new JdeField("SZLTTR", "SZLTTR", JdeDataType.String, 6),
        new JdeField("SZEMCU", "SZEMCU", JdeDataType.String, 24),
        new JdeField("SZRLIT", "SZRLIT", JdeDataType.String, 16),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZRKIT", "SZRKIT", JdeDataType.Numeric),
        new JdeField("SZKTP", "SZKTP", JdeDataType.Numeric),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZPRP1", "SZPRP1", JdeDataType.String, 6),
        new JdeField("SZPRP2", "SZPRP2", JdeDataType.String, 6),
        new JdeField("SZPRP3", "SZPRP3", JdeDataType.String, 6),
        new JdeField("SZPRP4", "SZPRP4", JdeDataType.String, 6),
        new JdeField("SZPRP5", "SZPRP5", JdeDataType.String, 6),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZSOQS", "SZSOQS", JdeDataType.Numeric),
        new JdeField("SZSOBK", "SZSOBK", JdeDataType.Numeric),
        new JdeField("SZSOCN", "SZSOCN", JdeDataType.Numeric),
        new JdeField("SZSONE", "SZSONE", JdeDataType.Numeric),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZQTYT", "SZQTYT", JdeDataType.Numeric),
        new JdeField("SZQRLV", "SZQRLV", JdeDataType.Numeric),
        new JdeField("SZCOMM", "SZCOMM", JdeDataType.String, 2),
        new JdeField("SZOTQY", "SZOTQY", JdeDataType.String, 2),
        new JdeField("SZUPRC", "SZUPRC", JdeDataType.Numeric),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZAOPN", "SZAOPN", JdeDataType.Numeric),
        new JdeField("SZPROV", "SZPROV", JdeDataType.String, 2),
        new JdeField("SZTPC", "SZTPC", JdeDataType.String, 2),
        new JdeField("SZAPUM", "SZAPUM", JdeDataType.String, 4),
        new JdeField("SZLPRC", "SZLPRC", JdeDataType.Numeric),
        new JdeField("SZUNCS", "SZUNCS", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZCSTO", "SZCSTO", JdeDataType.String, 2),
        new JdeField("SZTCST", "SZTCST", JdeDataType.Numeric),
        new JdeField("SZINMG", "SZINMG", JdeDataType.String, 20),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZRYIN", "SZRYIN", JdeDataType.String, 2),
        new JdeField("SZDTBS", "SZDTBS", JdeDataType.String, 2),
        new JdeField("SZTRDC", "SZTRDC", JdeDataType.Numeric),
        new JdeField("SZFUN2", "SZFUN2", JdeDataType.Numeric),
        new JdeField("SZASN", "SZASN", JdeDataType.String, 16),
        new JdeField("SZPRGR", "SZPRGR", JdeDataType.String, 16),
        new JdeField("SZCLVL", "SZCLVL", JdeDataType.String, 6),
        new JdeField("SZDSPR", "SZDSPR", JdeDataType.Numeric),
        new JdeField("SZDSFT", "SZDSFT", JdeDataType.String, 2),
        new JdeField("SZFAPP", "SZFAPP", JdeDataType.String, 2),
        new JdeField("SZCADC", "SZCADC", JdeDataType.Numeric),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZODOC", "SZODOC", JdeDataType.Numeric),
        new JdeField("SZODCT", "SZODCT", JdeDataType.String, 4),
        new JdeField("SZOKC", "SZOKC", JdeDataType.String, 10),
        new JdeField("SZPSN", "SZPSN", JdeDataType.Numeric),
        new JdeField("SZDELN", "SZDELN", JdeDataType.Numeric),
        new JdeField("SZTAX1", "SZTAX1", JdeDataType.String, 2),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZATXT", "SZATXT", JdeDataType.String, 2),
        new JdeField("SZPRIO", "SZPRIO", JdeDataType.String, 2),
        new JdeField("SZRESL", "SZRESL", JdeDataType.String, 2),
        new JdeField("SZBACK", "SZBACK", JdeDataType.String, 2),
        new JdeField("SZSBAL", "SZSBAL", JdeDataType.String, 2),
        new JdeField("SZAPTS", "SZAPTS", JdeDataType.String, 2),
        new JdeField("SZLOB", "SZLOB", JdeDataType.String, 6),
        new JdeField("SZEUSE", "SZEUSE", JdeDataType.String, 6),
        new JdeField("SZDTYS", "SZDTYS", JdeDataType.String, 4),
        new JdeField("SZNTR", "SZNTR", JdeDataType.String, 4),
        new JdeField("SZVEND", "SZVEND", JdeDataType.Numeric),
        new JdeField("SZANBY", "SZANBY", JdeDataType.Numeric),
        new JdeField("SZCARS", "SZCARS", JdeDataType.Numeric),
        new JdeField("SZMOT", "SZMOT", JdeDataType.String, 6),
        new JdeField("SZCOT", "SZCOT", JdeDataType.String, 6),
        new JdeField("SZROUT", "SZROUT", JdeDataType.String, 6),
        new JdeField("SZSTOP", "SZSTOP", JdeDataType.String, 6),
        new JdeField("SZZON", "SZZON", JdeDataType.String, 6),
        new JdeField("SZCNID", "SZCNID", JdeDataType.String, 40),
        new JdeField("SZFRTH", "SZFRTH", JdeDataType.String, 6),
        new JdeField("SZAFT", "SZAFT", JdeDataType.String, 2),
        new JdeField("SZFUF1", "SZFUF1", JdeDataType.String, 2),
        new JdeField("SZFRTC", "SZFRTC", JdeDataType.String, 2),
        new JdeField("SZFRAT", "SZFRAT", JdeDataType.String, 20),
        new JdeField("SZRATT", "SZRATT", JdeDataType.String, 2),
        new JdeField("SZSHCM", "SZSHCM", JdeDataType.String, 6),
        new JdeField("SZSHCN", "SZSHCN", JdeDataType.String, 6),
        new JdeField("SZSERN", "SZSERN", JdeDataType.String, 60),
        new JdeField("SZUOM1", "SZUOM1", JdeDataType.String, 4),
        new JdeField("SZPQOR", "SZPQOR", JdeDataType.Numeric),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZUOM4", "SZUOM4", JdeDataType.String, 4),
        new JdeField("SZITWT", "SZITWT", JdeDataType.Numeric),
        new JdeField("SZWTUM", "SZWTUM", JdeDataType.String, 4),
        new JdeField("SZITVL", "SZITVL", JdeDataType.Numeric),
        new JdeField("SZVLUM", "SZVLUM", JdeDataType.String, 4),
        new JdeField("SZRPRC", "SZRPRC", JdeDataType.String, 16),
        new JdeField("SZORPR", "SZORPR", JdeDataType.String, 16),
        new JdeField("SZORP", "SZORP", JdeDataType.String, 2),
        new JdeField("SZCMGP", "SZCMGP", JdeDataType.String, 4),
        new JdeField("SZCMGL", "SZCMGL", JdeDataType.String, 2),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZSTTS", "SZSTTS", JdeDataType.String, 4),
        new JdeField("SZSO01", "SZSO01", JdeDataType.String, 2),
        new JdeField("SZSO02", "SZSO02", JdeDataType.String, 2),
        new JdeField("SZSO03", "SZSO03", JdeDataType.String, 2),
        new JdeField("SZSO04", "SZSO04", JdeDataType.String, 2),
        new JdeField("SZSO05", "SZSO05", JdeDataType.String, 2),
        new JdeField("SZSO06", "SZSO06", JdeDataType.String, 2),
        new JdeField("SZSO07", "SZSO07", JdeDataType.String, 2),
        new JdeField("SZSO08", "SZSO08", JdeDataType.String, 2),
        new JdeField("SZSO09", "SZSO09", JdeDataType.String, 2),
        new JdeField("SZSO10", "SZSO10", JdeDataType.String, 2),
        new JdeField("SZSO11", "SZSO11", JdeDataType.String, 2),
        new JdeField("SZSO12", "SZSO12", JdeDataType.String, 2),
        new JdeField("SZSO14", "SZSO14", JdeDataType.String, 2),
        new JdeField("SZSO15", "SZSO15", JdeDataType.String, 2),
        new JdeField("SZACOM", "SZACOM", JdeDataType.String, 2),
        new JdeField("SZCMCG", "SZCMCG", JdeDataType.String, 16),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZGRWT", "SZGRWT", JdeDataType.Numeric),
        new JdeField("SZGWUM", "SZGWUM", JdeDataType.String, 4),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZLT", "SZLT", JdeDataType.String, 4),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZLCOD", "SZLCOD", JdeDataType.String, 4),
        new JdeField("SZUPC1", "SZUPC1", JdeDataType.String, 4),
        new JdeField("SZUPC2", "SZUPC2", JdeDataType.String, 4),
        new JdeField("SZUPC3", "SZUPC3", JdeDataType.String, 4),
        new JdeField("SZSWMS", "SZSWMS", JdeDataType.String, 2),
        new JdeField("SZUNCD", "SZUNCD", JdeDataType.String, 2),
        new JdeField("SZCRMD", "SZCRMD", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFPRC", "SZFPRC", JdeDataType.Numeric),
        new JdeField("SZFUP", "SZFUP", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFUC", "SZFUC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
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
        new JdeField("SZADTM", "SZADTM", JdeDataType.Numeric),
        new JdeField("SZBSC", "SZBSC", JdeDataType.String, 20),
        new JdeField("SZCBSC", "SZCBSC", JdeDataType.String, 20),
        new JdeField("SZDVAN", "SZDVAN", JdeDataType.Numeric),
        new JdeField("SZDEID", "SZDEID", JdeDataType.Numeric),
        new JdeField("SZDUAL", "SZDUAL", JdeDataType.String, 2),
        new JdeField("SZOPTT", "SZOPTT", JdeDataType.Numeric),
        new JdeField("SZPDTT", "SZPDTT", JdeDataType.Numeric),
        new JdeField("SZPRJM", "SZPRJM", JdeDataType.Numeric),
        new JdeField("SZPMTN", "SZPMTN", JdeDataType.String, 24),
        new JdeField("SZPSIG", "SZPSIG", JdeDataType.String, 60),
        new JdeField("SZPSTM", "SZPSTM", JdeDataType.Numeric),
        new JdeField("SZRFRV", "SZRFRV", JdeDataType.String, 6),
        new JdeField("SZRLDJ", "SZRLDJ", JdeDataType.Numeric),
        new JdeField("SZRLNU", "SZRLNU", JdeDataType.String, 20),
        new JdeField("SZRLTM", "SZRLTM", JdeDataType.Numeric),
        new JdeField("SZPMDT", "SZPMDT", JdeDataType.Numeric),
        new JdeField("SZSOOR", "SZSOOR", JdeDataType.Numeric),
        new JdeField("SZIR01", "SZIR01", JdeDataType.String, 60),
        new JdeField("SZIR02", "SZIR02", JdeDataType.String, 60),
        new JdeField("SZIR03", "SZIR03", JdeDataType.String, 60),
        new JdeField("SZIR04", "SZIR04", JdeDataType.String, 60),
        new JdeField("SZIR05", "SZIR05", JdeDataType.String, 60),
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZSO13", "SZSO13", JdeDataType.String, 2),
        new JdeField("SZDRQT", "SZDRQT", JdeDataType.Numeric),
        new JdeField("SZHOLD", "SZHOLD", JdeDataType.String, 4),
        new JdeField("SZPMTO", "SZPMTO", JdeDataType.String, 2),
        new JdeField("SZGAN8", "SZGAN8", JdeDataType.Numeric),
        new JdeField("SZGSHAN", "SZGSHAN", JdeDataType.Numeric),
        new JdeField("SZGPA8", "SZGPA8", JdeDataType.Numeric),
        new JdeField("SZGCARS", "SZGCARS", JdeDataType.Numeric),
        new JdeField("SZGDVAN", "SZGDVAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47107_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
