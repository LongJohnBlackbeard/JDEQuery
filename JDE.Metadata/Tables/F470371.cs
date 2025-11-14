using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470371 - .
/// </summary>
public class F470371 : JdeTable
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
        /// SZEDOC.
        /// </summary>
        public const string SZEDOC = "SZEDOC";

        /// <summary>
        /// SZEKCO.
        /// </summary>
        public const string SZEKCO = "SZEKCO";

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
        /// SZSPID.
        /// </summary>
        public const string SZSPID = "SZSPID";

        /// <summary>
        /// SZHLVL.
        /// </summary>
        public const string SZHLVL = "SZHLVL";

        /// <summary>
        /// SZHL03.
        /// </summary>
        public const string SZHL03 = "SZHL03";

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
        /// SZRQSJ.
        /// </summary>
        public const string SZRQSJ = "SZRQSJ";

        /// <summary>
        /// SZADLJ.
        /// </summary>
        public const string SZADLJ = "SZADLJ";

        /// <summary>
        /// SZDRQT.
        /// </summary>
        public const string SZDRQT = "SZDRQT";

        /// <summary>
        /// SZRSDT.
        /// </summary>
        public const string SZRSDT = "SZRSDT";

        /// <summary>
        /// SZRSHT.
        /// </summary>
        public const string SZRSHT = "SZRSHT";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZVR02.
        /// </summary>
        public const string SZVR02 = "SZVR02";

        /// <summary>
        /// SZVR03.
        /// </summary>
        public const string SZVR03 = "SZVR03";

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
        /// SZACGD.
        /// </summary>
        public const string SZACGD = "SZACGD";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZAPOT.
        /// </summary>
        public const string SZAPOT = "SZAPOT";

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
        /// SZHDBU.
        /// </summary>
        public const string SZHDBU = "SZHDBU";

        /// <summary>
        /// SZSRP2.
        /// </summary>
        public const string SZSRP2 = "SZSRP2";

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
        /// SZDMBU.
        /// </summary>
        public const string SZDMBU = "SZDMBU";

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
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

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
        /// SZDCD.
        /// </summary>
        public const string SZDCD = "SZDCD";

        /// <summary>
        /// SZDCP.
        /// </summary>
        public const string SZDCP = "SZDCP";

        /// <summary>
        /// SZNDTP.
        /// </summary>
        public const string SZNDTP = "SZNDTP";

        /// <summary>
        /// SZPXDD.
        /// </summary>
        public const string SZPXDD = "SZPXDD";

        /// <summary>
        /// SZPXDM.
        /// </summary>
        public const string SZPXDM = "SZPXDM";

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
        /// SZDSPR.
        /// </summary>
        public const string SZDSPR = "SZDSPR";

        /// <summary>
        /// SZDSFT.
        /// </summary>
        public const string SZDSFT = "SZDSFT";

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
        /// SZATXT.
        /// </summary>
        public const string SZATXT = "SZATXT";

        /// <summary>
        /// SZPRIO.
        /// </summary>
        public const string SZPRIO = "SZPRIO";

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
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZSHCN.
        /// </summary>
        public const string SZSHCN = "SZSHCN";

        /// <summary>
        /// SZSERN.
        /// </summary>
        public const string SZSERN = "SZSERN";

        /// <summary>
        /// SZLDNM.
        /// </summary>
        public const string SZLDNM = "SZLDNM";

        /// <summary>
        /// SZTKNR.
        /// </summary>
        public const string SZTKNR = "SZTKNR";

        /// <summary>
        /// SZTKTM.
        /// </summary>
        public const string SZTKTM = "SZTKTM";

        /// <summary>
        /// SZTKDA.
        /// </summary>
        public const string SZTKDA = "SZTKDA";

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
        /// SZLCOD.
        /// </summary>
        public const string SZLCOD = "SZLCOD";

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
        /// SZHLCF.
        /// </summary>
        public const string SZHLCF = "SZHLCF";

        /// <summary>
        /// SZHLSC.
        /// </summary>
        public const string SZHLSC = "SZHLSC";

        /// <summary>
        /// SZPKCD.
        /// </summary>
        public const string SZPKCD = "SZPKCD";

        /// <summary>
        /// SZWGQ.
        /// </summary>
        public const string SZWGQ = "SZWGQ";

        /// <summary>
        /// SZWGTS.
        /// </summary>
        public const string SZWGTS = "SZWGTS";

        /// <summary>
        /// SZWGTU.
        /// </summary>
        public const string SZWGTU = "SZWGTU";

        /// <summary>
        /// SZIDQ1.
        /// </summary>
        public const string SZIDQ1 = "SZIDQ1";

        /// <summary>
        /// SZID1.
        /// </summary>
        public const string SZID1 = "SZID1";

        /// <summary>
        /// SZIDQ2.
        /// </summary>
        public const string SZIDQ2 = "SZIDQ2";

        /// <summary>
        /// SZID2.
        /// </summary>
        public const string SZID2 = "SZID2";

        /// <summary>
        /// SZROTE.
        /// </summary>
        public const string SZROTE = "SZROTE";

        /// <summary>
        /// SZEQCD.
        /// </summary>
        public const string SZEQCD = "SZEQCD";

        /// <summary>
        /// SZEQIN.
        /// </summary>
        public const string SZEQIN = "SZEQIN";

        /// <summary>
        /// SZEQNB.
        /// </summary>
        public const string SZEQNB = "SZEQNB";

        /// <summary>
        /// SZRFQ1.
        /// </summary>
        public const string SZRFQ1 = "SZRFQ1";

        /// <summary>
        /// SZRF1.
        /// </summary>
        public const string SZRF1 = "SZRF1";

        /// <summary>
        /// SZRFQ2.
        /// </summary>
        public const string SZRFQ2 = "SZRFQ2";

        /// <summary>
        /// SZRF2.
        /// </summary>
        public const string SZRF2 = "SZRF2";

        /// <summary>
        /// SZPLT.
        /// </summary>
        public const string SZPLT = "SZPLT";

        /// <summary>
        /// SZPAK.
        /// </summary>
        public const string SZPAK = "SZPAK";

        /// <summary>
        /// SZSCCN.
        /// </summary>
        public const string SZSCCN = "SZSCCN";

        /// <summary>
        /// SZSCCQ.
        /// </summary>
        public const string SZSCCQ = "SZSCCQ";

        /// <summary>
        /// SZSCUM.
        /// </summary>
        public const string SZSCUM = "SZSCUM";

        /// <summary>
        /// SZUPCN.
        /// </summary>
        public const string SZUPCN = "SZUPCN";

        /// <summary>
        /// SZUPQT.
        /// </summary>
        public const string SZUPQT = "SZUPQT";

        /// <summary>
        /// SZUPUM.
        /// </summary>
        public const string SZUPUM = "SZUPUM";

        /// <summary>
        /// SZLINS.
        /// </summary>
        public const string SZLINS = "SZLINS";

        /// <summary>
        /// SZSTPC.
        /// </summary>
        public const string SZSTPC = "SZSTPC";

        /// <summary>
        /// SZANTY.
        /// </summary>
        public const string SZANTY = "SZANTY";

        /// <summary>
        /// SZTXLN.
        /// </summary>
        public const string SZTXLN = "SZTXLN";

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
        /// SZPDTT.
        /// </summary>
        public const string SZPDTT = "SZPDTT";

        /// <summary>
        /// SZOPTT.
        /// </summary>
        public const string SZOPTT = "SZOPTT";

        /// <summary>
        /// SZADTM.
        /// </summary>
        public const string SZADTM = "SZADTM";

        /// <summary>
        /// SZPMDT.
        /// </summary>
        public const string SZPMDT = "SZPMDT";

        /// <summary>
        /// SZPSTM.
        /// </summary>
        public const string SZPSTM = "SZPSTM";

        /// <summary>
        /// SZBSC.
        /// </summary>
        public const string SZBSC = "SZBSC";

        /// <summary>
        /// SZCBSC.
        /// </summary>
        public const string SZCBSC = "SZCBSC";

        /// <summary>
        /// SZDEID.
        /// </summary>
        public const string SZDEID = "SZDEID";

        /// <summary>
        /// SZDUAL.
        /// </summary>
        public const string SZDUAL = "SZDUAL";

        /// <summary>
        /// SZDVAN.
        /// </summary>
        public const string SZDVAN = "SZDVAN";

        /// <summary>
        /// SZHOLD.
        /// </summary>
        public const string SZHOLD = "SZHOLD";

        /// <summary>
        /// SZPMTN.
        /// </summary>
        public const string SZPMTN = "SZPMTN";

        /// <summary>
        /// SZPMTO.
        /// </summary>
        public const string SZPMTO = "SZPMTO";

        /// <summary>
        /// SZPRJM.
        /// </summary>
        public const string SZPRJM = "SZPRJM";

        /// <summary>
        /// SZPSIG.
        /// </summary>
        public const string SZPSIG = "SZPSIG";

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
        /// SZSOOR.
        /// </summary>
        public const string SZSOOR = "SZSOOR";

        /// <summary>
        /// SZCARDNO.
        /// </summary>
        public const string SZCARDNO = "SZCARDNO";

        /// <summary>
        /// SZRTORSQ.
        /// </summary>
        public const string SZRTORSQ = "SZRTORSQ";

        /// <summary>
        /// SZRTGDAT.
        /// </summary>
        public const string SZRTGDAT = "SZRTGDAT";

        /// <summary>
        /// SZRTGTIM.
        /// </summary>
        public const string SZRTGTIM = "SZRTGTIM";

        /// <summary>
        /// SZNCOOC.
        /// </summary>
        public const string SZNCOOC = "SZNCOOC";

        /// <summary>
        /// SZIPPTG.
        /// </summary>
        public const string SZIPPTG = "SZIPPTG";

        /// <summary>
        /// SZIPPRC.
        /// </summary>
        public const string SZIPPRC = "SZIPPRC";

        /// <summary>
        /// SZKBSNO.
        /// </summary>
        public const string SZKBSNO = "SZKBSNO";

        /// <summary>
        /// SZKBENO.
        /// </summary>
        public const string SZKBENO = "SZKBENO";

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
        /// SZGDVAN.
        /// </summary>
        public const string SZGDVAN = "SZGDVAN";

        /// <summary>
        /// SZGCARS.
        /// </summary>
        public const string SZGCARS = "SZGCARS";

        /// <summary>
        /// SZORIG.
        /// </summary>
        public const string SZORIG = "SZORIG";

        /// <summary>
        /// SZOIASN.
        /// </summary>
        public const string SZOIASN = "SZOIASN";

        /// <summary>
        /// SZGSHIB.
        /// </summary>
        public const string SZGSHIB = "SZGSHIB";
    }

    /// <inheritdoc />
    public override string TableName => "F470371";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDTY", "SZEDTY", JdeDataType.String, 2),
        new JdeField("SZEDSQ", "SZEDSQ", JdeDataType.Numeric),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
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
        new JdeField("SZSPID", "SZSPID", JdeDataType.String, 40),
        new JdeField("SZHLVL", "SZHLVL", JdeDataType.Numeric),
        new JdeField("SZHL03", "SZHL03", JdeDataType.String, 4),
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
        new JdeField("SZRQSJ", "SZRQSJ", JdeDataType.Numeric),
        new JdeField("SZADLJ", "SZADLJ", JdeDataType.Numeric),
        new JdeField("SZDRQT", "SZDRQT", JdeDataType.Numeric),
        new JdeField("SZRSDT", "SZRSDT", JdeDataType.Numeric),
        new JdeField("SZRSHT", "SZRSHT", JdeDataType.Numeric),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
        new JdeField("SZVR03", "SZVR03", JdeDataType.String, 50),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZCITM", "SZCITM", JdeDataType.String, 50),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZACGD", "SZACGD", JdeDataType.String, 6),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZAPOT", "SZAPOT", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZEXDP", "SZEXDP", JdeDataType.Numeric),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZNXTR", "SZNXTR", JdeDataType.String, 6),
        new JdeField("SZLTTR", "SZLTTR", JdeDataType.String, 6),
        new JdeField("SZEMCU", "SZEMCU", JdeDataType.String, 24),
        new JdeField("SZHDBU", "SZHDBU", JdeDataType.String, 24),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZRLIT", "SZRLIT", JdeDataType.String, 16),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZRKIT", "SZRKIT", JdeDataType.Numeric),
        new JdeField("SZKTP", "SZKTP", JdeDataType.Numeric),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZDMBU", "SZDMBU", JdeDataType.String, 24),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZPRP1", "SZPRP1", JdeDataType.String, 6),
        new JdeField("SZPRP2", "SZPRP2", JdeDataType.String, 6),
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
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZUPRC", "SZUPRC", JdeDataType.Numeric),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZAOPN", "SZAOPN", JdeDataType.Numeric),
        new JdeField("SZAPUM", "SZAPUM", JdeDataType.String, 4),
        new JdeField("SZLPRC", "SZLPRC", JdeDataType.Numeric),
        new JdeField("SZUNCS", "SZUNCS", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZCSTO", "SZCSTO", JdeDataType.String, 2),
        new JdeField("SZTCST", "SZTCST", JdeDataType.Numeric),
        new JdeField("SZINMG", "SZINMG", JdeDataType.String, 20),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZDCD", "SZDCD", JdeDataType.Numeric),
        new JdeField("SZDCP", "SZDCP", JdeDataType.Numeric),
        new JdeField("SZNDTP", "SZNDTP", JdeDataType.Numeric),
        new JdeField("SZPXDD", "SZPXDD", JdeDataType.Numeric),
        new JdeField("SZPXDM", "SZPXDM", JdeDataType.Numeric),
        new JdeField("SZRYIN", "SZRYIN", JdeDataType.String, 2),
        new JdeField("SZDTBS", "SZDTBS", JdeDataType.String, 2),
        new JdeField("SZTRDC", "SZTRDC", JdeDataType.Numeric),
        new JdeField("SZDSPR", "SZDSPR", JdeDataType.Numeric),
        new JdeField("SZDSFT", "SZDSFT", JdeDataType.String, 2),
        new JdeField("SZCADC", "SZCADC", JdeDataType.Numeric),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZODOC", "SZODOC", JdeDataType.Numeric),
        new JdeField("SZODCT", "SZODCT", JdeDataType.String, 4),
        new JdeField("SZOKC", "SZOKC", JdeDataType.String, 10),
        new JdeField("SZPSN", "SZPSN", JdeDataType.Numeric),
        new JdeField("SZDELN", "SZDELN", JdeDataType.Numeric),
        new JdeField("SZATXT", "SZATXT", JdeDataType.String, 2),
        new JdeField("SZPRIO", "SZPRIO", JdeDataType.String, 2),
        new JdeField("SZAPTS", "SZAPTS", JdeDataType.String, 2),
        new JdeField("SZLOB", "SZLOB", JdeDataType.String, 6),
        new JdeField("SZEUSE", "SZEUSE", JdeDataType.String, 6),
        new JdeField("SZDTYS", "SZDTYS", JdeDataType.String, 4),
        new JdeField("SZNTR", "SZNTR", JdeDataType.String, 4),
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
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZSHCN", "SZSHCN", JdeDataType.String, 6),
        new JdeField("SZSERN", "SZSERN", JdeDataType.String, 60),
        new JdeField("SZLDNM", "SZLDNM", JdeDataType.Numeric),
        new JdeField("SZTKNR", "SZTKNR", JdeDataType.String, 40),
        new JdeField("SZTKTM", "SZTKTM", JdeDataType.Numeric),
        new JdeField("SZTKDA", "SZTKDA", JdeDataType.Numeric),
        new JdeField("SZUOM1", "SZUOM1", JdeDataType.String, 4),
        new JdeField("SZPQOR", "SZPQOR", JdeDataType.Numeric),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZUOM4", "SZUOM4", JdeDataType.String, 4),
        new JdeField("SZITWT", "SZITWT", JdeDataType.Numeric),
        new JdeField("SZWTUM", "SZWTUM", JdeDataType.String, 4),
        new JdeField("SZITVL", "SZITVL", JdeDataType.Numeric),
        new JdeField("SZVLUM", "SZVLUM", JdeDataType.String, 4),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZSTTS", "SZSTTS", JdeDataType.String, 4),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZGRWT", "SZGRWT", JdeDataType.Numeric),
        new JdeField("SZGWUM", "SZGWUM", JdeDataType.String, 4),
        new JdeField("SZLCOD", "SZLCOD", JdeDataType.String, 4),
        new JdeField("SZCRMD", "SZCRMD", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFPRC", "SZFPRC", JdeDataType.Numeric),
        new JdeField("SZFUP", "SZFUP", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFUC", "SZFUC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
        new JdeField("SZHLCF", "SZHLCF", JdeDataType.String, 36),
        new JdeField("SZHLSC", "SZHLSC", JdeDataType.String, 8),
        new JdeField("SZPKCD", "SZPKCD", JdeDataType.String, 10),
        new JdeField("SZWGQ", "SZWGQ", JdeDataType.String, 4),
        new JdeField("SZWGTS", "SZWGTS", JdeDataType.Numeric),
        new JdeField("SZWGTU", "SZWGTU", JdeDataType.String, 4),
        new JdeField("SZIDQ1", "SZIDQ1", JdeDataType.String, 4),
        new JdeField("SZID1", "SZID1", JdeDataType.String, 34),
        new JdeField("SZIDQ2", "SZIDQ2", JdeDataType.String, 4),
        new JdeField("SZID2", "SZID2", JdeDataType.String, 34),
        new JdeField("SZROTE", "SZROTE", JdeDataType.String, 70),
        new JdeField("SZEQCD", "SZEQCD", JdeDataType.String, 4),
        new JdeField("SZEQIN", "SZEQIN", JdeDataType.String, 8),
        new JdeField("SZEQNB", "SZEQNB", JdeDataType.String, 20),
        new JdeField("SZRFQ1", "SZRFQ1", JdeDataType.String, 4),
        new JdeField("SZRF1", "SZRF1", JdeDataType.String, 60),
        new JdeField("SZRFQ2", "SZRFQ2", JdeDataType.String, 4),
        new JdeField("SZRF2", "SZRF2", JdeDataType.String, 60),
        new JdeField("SZPLT", "SZPLT", JdeDataType.String, 36),
        new JdeField("SZPAK", "SZPAK", JdeDataType.String, 36),
        new JdeField("SZSCCN", "SZSCCN", JdeDataType.String, 28),
        new JdeField("SZSCCQ", "SZSCCQ", JdeDataType.Numeric),
        new JdeField("SZSCUM", "SZSCUM", JdeDataType.String, 4),
        new JdeField("SZUPCN", "SZUPCN", JdeDataType.String, 26),
        new JdeField("SZUPQT", "SZUPQT", JdeDataType.Numeric),
        new JdeField("SZUPUM", "SZUPUM", JdeDataType.String, 4),
        new JdeField("SZLINS", "SZLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("SZSTPC", "SZSTPC", JdeDataType.String, 2, true, true),
        new JdeField("SZANTY", "SZANTY", JdeDataType.String, 2, true, true),
        new JdeField("SZTXLN", "SZTXLN", JdeDataType.String, 120),
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
        new JdeField("SZPDTT", "SZPDTT", JdeDataType.Numeric),
        new JdeField("SZOPTT", "SZOPTT", JdeDataType.Numeric),
        new JdeField("SZADTM", "SZADTM", JdeDataType.Numeric),
        new JdeField("SZPMDT", "SZPMDT", JdeDataType.Numeric),
        new JdeField("SZPSTM", "SZPSTM", JdeDataType.Numeric),
        new JdeField("SZBSC", "SZBSC", JdeDataType.String, 20),
        new JdeField("SZCBSC", "SZCBSC", JdeDataType.String, 20),
        new JdeField("SZDEID", "SZDEID", JdeDataType.Numeric),
        new JdeField("SZDUAL", "SZDUAL", JdeDataType.String, 2),
        new JdeField("SZDVAN", "SZDVAN", JdeDataType.Numeric),
        new JdeField("SZHOLD", "SZHOLD", JdeDataType.String, 4),
        new JdeField("SZPMTN", "SZPMTN", JdeDataType.String, 24),
        new JdeField("SZPMTO", "SZPMTO", JdeDataType.String, 2),
        new JdeField("SZPRJM", "SZPRJM", JdeDataType.Numeric),
        new JdeField("SZPSIG", "SZPSIG", JdeDataType.String, 60),
        new JdeField("SZRFRV", "SZRFRV", JdeDataType.String, 6),
        new JdeField("SZRLDJ", "SZRLDJ", JdeDataType.Numeric),
        new JdeField("SZRLNU", "SZRLNU", JdeDataType.String, 20),
        new JdeField("SZRLTM", "SZRLTM", JdeDataType.Numeric),
        new JdeField("SZSOOR", "SZSOOR", JdeDataType.Numeric),
        new JdeField("SZCARDNO", "SZCARDNO", JdeDataType.String, 8),
        new JdeField("SZRTORSQ", "SZRTORSQ", JdeDataType.String, 60),
        new JdeField("SZRTGDAT", "SZRTGDAT", JdeDataType.Numeric),
        new JdeField("SZRTGTIM", "SZRTGTIM", JdeDataType.Numeric),
        new JdeField("SZNCOOC", "SZNCOOC", JdeDataType.String, 6),
        new JdeField("SZIPPTG", "SZIPPTG", JdeDataType.String, 4),
        new JdeField("SZIPPRC", "SZIPPRC", JdeDataType.String, 20),
        new JdeField("SZKBSNO", "SZKBSNO", JdeDataType.String, 30),
        new JdeField("SZKBENO", "SZKBENO", JdeDataType.String, 30),
        new JdeField("SZGAN8", "SZGAN8", JdeDataType.Numeric),
        new JdeField("SZGSHAN", "SZGSHAN", JdeDataType.Numeric),
        new JdeField("SZGPA8", "SZGPA8", JdeDataType.Numeric),
        new JdeField("SZGDVAN", "SZGDVAN", JdeDataType.Numeric),
        new JdeField("SZGCARS", "SZGCARS", JdeDataType.Numeric),
        new JdeField("SZORIG", "SZORIG", JdeDataType.String, 6),
        new JdeField("SZOIASN", "SZOIASN", JdeDataType.String, 100),
        new JdeField("SZGSHIB", "SZGSHIB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470371_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN, SZSTPC, SZANTY, SZLINS", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN", "SZSTPC", "SZANTY", "SZLINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F470371_2", "Index on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }),
        new JdeIndex("F470371_3", "Index on SZSHPN", new[] { "SZSHPN" }),
        new JdeIndex("F470371_4", "Index on SZEDOC, SZEDCT, SZEKCO, SYS_NC00261$", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SYS_NC00261$" })
    };
}
