using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47142 - .
/// </summary>
public class F47142 : JdeTable
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
        /// SZCHGC.
        /// </summary>
        public const string SZCHGC = "SZCHGC";

        /// <summary>
        /// SZLSTS.
        /// </summary>
        public const string SZLSTS = "SZLSTS";

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
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

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
        /// SZCNDJ.
        /// </summary>
        public const string SZCNDJ = "SZCNDJ";

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
        /// SZDSVJ.
        /// </summary>
        public const string SZDSVJ = "SZDSVJ";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

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
        /// SZRLIT.
        /// </summary>
        public const string SZRLIT = "SZRLIT";

        /// <summary>
        /// SZPDS1.
        /// </summary>
        public const string SZPDS1 = "SZPDS1";

        /// <summary>
        /// SZPDS2.
        /// </summary>
        public const string SZPDS2 = "SZPDS2";

        /// <summary>
        /// SZPDS3.
        /// </summary>
        public const string SZPDS3 = "SZPDS3";

        /// <summary>
        /// SZPDS4.
        /// </summary>
        public const string SZPDS4 = "SZPDS4";

        /// <summary>
        /// SZPDS5.
        /// </summary>
        public const string SZPDS5 = "SZPDS5";

        /// <summary>
        /// SZPDP1.
        /// </summary>
        public const string SZPDP1 = "SZPDP1";

        /// <summary>
        /// SZPDP2.
        /// </summary>
        public const string SZPDP2 = "SZPDP2";

        /// <summary>
        /// SZPDP3.
        /// </summary>
        public const string SZPDP3 = "SZPDP3";

        /// <summary>
        /// SZPDP4.
        /// </summary>
        public const string SZPDP4 = "SZPDP4";

        /// <summary>
        /// SZPDP5.
        /// </summary>
        public const string SZPDP5 = "SZPDP5";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZUCHG.
        /// </summary>
        public const string SZUCHG = "SZUCHG";

        /// <summary>
        /// SZUOPN.
        /// </summary>
        public const string SZUOPN = "SZUOPN";

        /// <summary>
        /// SZUREC.
        /// </summary>
        public const string SZUREC = "SZUREC";

        /// <summary>
        /// SZCREC.
        /// </summary>
        public const string SZCREC = "SZCREC";

        /// <summary>
        /// SZURLV.
        /// </summary>
        public const string SZURLV = "SZURLV";

        /// <summary>
        /// SZOTQY.
        /// </summary>
        public const string SZOTQY = "SZOTQY";

        /// <summary>
        /// SZPRRC.
        /// </summary>
        public const string SZPRRC = "SZPRRC";

        /// <summary>
        /// SZAEXP.
        /// </summary>
        public const string SZAEXP = "SZAEXP";

        /// <summary>
        /// SZACHG.
        /// </summary>
        public const string SZACHG = "SZACHG";

        /// <summary>
        /// SZAOPN.
        /// </summary>
        public const string SZAOPN = "SZAOPN";

        /// <summary>
        /// SZAREC.
        /// </summary>
        public const string SZAREC = "SZAREC";

        /// <summary>
        /// SZARLV.
        /// </summary>
        public const string SZARLV = "SZARLV";

        /// <summary>
        /// SZFTN1.
        /// </summary>
        public const string SZFTN1 = "SZFTN1";

        /// <summary>
        /// SZTRLV.
        /// </summary>
        public const string SZTRLV = "SZTRLV";

        /// <summary>
        /// SZPROV.
        /// </summary>
        public const string SZPROV = "SZPROV";

        /// <summary>
        /// SZAMC3.
        /// </summary>
        public const string SZAMC3 = "SZAMC3";

        /// <summary>
        /// SZECST.
        /// </summary>
        public const string SZECST = "SZECST";

        /// <summary>
        /// SZCSTO.
        /// </summary>
        public const string SZCSTO = "SZCSTO";

        /// <summary>
        /// SZCSMP.
        /// </summary>
        public const string SZCSMP = "SZCSMP";

        /// <summary>
        /// SZINMG.
        /// </summary>
        public const string SZINMG = "SZINMG";

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
        /// SZCATN.
        /// </summary>
        public const string SZCATN = "SZCATN";

        /// <summary>
        /// SZDSPR.
        /// </summary>
        public const string SZDSPR = "SZDSPR";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZTX.
        /// </summary>
        public const string SZTX = "SZTX";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZATXT.
        /// </summary>
        public const string SZATXT = "SZATXT";

        /// <summary>
        /// SZCNID.
        /// </summary>
        public const string SZCNID = "SZCNID";

        /// <summary>
        /// SZCDCD.
        /// </summary>
        public const string SZCDCD = "SZCDCD";

        /// <summary>
        /// SZNTR.
        /// </summary>
        public const string SZNTR = "SZNTR";

        /// <summary>
        /// SZFRTH.
        /// </summary>
        public const string SZFRTH = "SZFRTH";

        /// <summary>
        /// SZFRTC.
        /// </summary>
        public const string SZFRTC = "SZFRTC";

        /// <summary>
        /// SZZON.
        /// </summary>
        public const string SZZON = "SZZON";

        /// <summary>
        /// SZFRAT.
        /// </summary>
        public const string SZFRAT = "SZFRAT";

        /// <summary>
        /// SZRATT.
        /// </summary>
        public const string SZRATT = "SZRATT";

        /// <summary>
        /// SZANBY.
        /// </summary>
        public const string SZANBY = "SZANBY";

        /// <summary>
        /// SZANCR.
        /// </summary>
        public const string SZANCR = "SZANCR";

        /// <summary>
        /// SZMOT.
        /// </summary>
        public const string SZMOT = "SZMOT";

        /// <summary>
        /// SZCOT.
        /// </summary>
        public const string SZCOT = "SZCOT";

        /// <summary>
        /// SZSHCM.
        /// </summary>
        public const string SZSHCM = "SZSHCM";

        /// <summary>
        /// SZSHCN.
        /// </summary>
        public const string SZSHCN = "SZSHCN";

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
        /// SZUOM3.
        /// </summary>
        public const string SZUOM3 = "SZUOM3";

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
        /// SZFUF1.
        /// </summary>
        public const string SZFUF1 = "SZFUF1";

        /// <summary>
        /// SZFUF2.
        /// </summary>
        public const string SZFUF2 = "SZFUF2";

        /// <summary>
        /// SZGRWT.
        /// </summary>
        public const string SZGRWT = "SZGRWT";

        /// <summary>
        /// SZGWUM.
        /// </summary>
        public const string SZGWUM = "SZGWUM";

        /// <summary>
        /// SZLT.
        /// </summary>
        public const string SZLT = "SZLT";

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
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZASID.
        /// </summary>
        public const string SZASID = "SZASID";

        /// <summary>
        /// SZCCMP.
        /// </summary>
        public const string SZCCMP = "SZCCMP";

        /// <summary>
        /// SZTAG.
        /// </summary>
        public const string SZTAG = "SZTAG";

        /// <summary>
        /// SZWR01.
        /// </summary>
        public const string SZWR01 = "SZWR01";

        /// <summary>
        /// SZPL.
        /// </summary>
        public const string SZPL = "SZPL";

        /// <summary>
        /// SZELEV.
        /// </summary>
        public const string SZELEV = "SZELEV";

        /// <summary>
        /// SZR001.
        /// </summary>
        public const string SZR001 = "SZR001";

        /// <summary>
        /// SZRTNR.
        /// </summary>
        public const string SZRTNR = "SZRTNR";

        /// <summary>
        /// SZLCOD.
        /// </summary>
        public const string SZLCOD = "SZLCOD";

        /// <summary>
        /// SZPURG.
        /// </summary>
        public const string SZPURG = "SZPURG";

        /// <summary>
        /// SZPROM.
        /// </summary>
        public const string SZPROM = "SZPROM";

        /// <summary>
        /// SZFNLP.
        /// </summary>
        public const string SZFNLP = "SZFNLP";

        /// <summary>
        /// SZAVCH.
        /// </summary>
        public const string SZAVCH = "SZAVCH";

        /// <summary>
        /// SZPRPY.
        /// </summary>
        public const string SZPRPY = "SZPRPY";

        /// <summary>
        /// SZUNCD.
        /// </summary>
        public const string SZUNCD = "SZUNCD";

        /// <summary>
        /// SZMATY.
        /// </summary>
        public const string SZMATY = "SZMATY";

        /// <summary>
        /// SZRTGC.
        /// </summary>
        public const string SZRTGC = "SZRTGC";

        /// <summary>
        /// SZRCPF.
        /// </summary>
        public const string SZRCPF = "SZRCPF";

        /// <summary>
        /// SZARTG.
        /// </summary>
        public const string SZARTG = "SZARTG";

        /// <summary>
        /// SZCORD.
        /// </summary>
        public const string SZCORD = "SZCORD";

        /// <summary>
        /// SZCHDT.
        /// </summary>
        public const string SZCHDT = "SZCHDT";

        /// <summary>
        /// SZDOCC.
        /// </summary>
        public const string SZDOCC = "SZDOCC";

        /// <summary>
        /// SZCHLN.
        /// </summary>
        public const string SZCHLN = "SZCHLN";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZFRRC.
        /// </summary>
        public const string SZFRRC = "SZFRRC";

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
        /// SZFCHG.
        /// </summary>
        public const string SZFCHG = "SZFCHG";

        /// <summary>
        /// SZFAP.
        /// </summary>
        public const string SZFAP = "SZFAP";

        /// <summary>
        /// SZFREC.
        /// </summary>
        public const string SZFREC = "SZFREC";

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
        /// SZRSHT.
        /// </summary>
        public const string SZRSHT = "SZRSHT";

        /// <summary>
        /// SZPXDM.
        /// </summary>
        public const string SZPXDM = "SZPXDM";

        /// <summary>
        /// SZPXDD.
        /// </summary>
        public const string SZPXDD = "SZPXDD";

        /// <summary>
        /// SZPS10.
        /// </summary>
        public const string SZPS10 = "SZPS10";

        /// <summary>
        /// SZPS09.
        /// </summary>
        public const string SZPS09 = "SZPS09";

        /// <summary>
        /// SZPS08.
        /// </summary>
        public const string SZPS08 = "SZPS08";

        /// <summary>
        /// SZPS07.
        /// </summary>
        public const string SZPS07 = "SZPS07";

        /// <summary>
        /// SZPS06.
        /// </summary>
        public const string SZPS06 = "SZPS06";

        /// <summary>
        /// SZPS05.
        /// </summary>
        public const string SZPS05 = "SZPS05";

        /// <summary>
        /// SZPS04.
        /// </summary>
        public const string SZPS04 = "SZPS04";

        /// <summary>
        /// SZPS03.
        /// </summary>
        public const string SZPS03 = "SZPS03";

        /// <summary>
        /// SZPS02.
        /// </summary>
        public const string SZPS02 = "SZPS02";

        /// <summary>
        /// SZPS01.
        /// </summary>
        public const string SZPS01 = "SZPS01";

        /// <summary>
        /// SZNDTP.
        /// </summary>
        public const string SZNDTP = "SZNDTP";

        /// <summary>
        /// SZMERL.
        /// </summary>
        public const string SZMERL = "SZMERL";

        /// <summary>
        /// SZMACT.
        /// </summary>
        public const string SZMACT = "SZMACT";

        /// <summary>
        /// SZKTLN.
        /// </summary>
        public const string SZKTLN = "SZKTLN";

        /// <summary>
        /// SZFTRL.
        /// </summary>
        public const string SZFTRL = "SZFTRL";

        /// <summary>
        /// SZDRQT.
        /// </summary>
        public const string SZDRQT = "SZDRQT";

        /// <summary>
        /// SZDCP.
        /// </summary>
        public const string SZDCP = "SZDCP";

        /// <summary>
        /// SZDCD.
        /// </summary>
        public const string SZDCD = "SZDCD";

        /// <summary>
        /// SZCTAM.
        /// </summary>
        public const string SZCTAM = "SZCTAM";

        /// <summary>
        /// SZCRMD.
        /// </summary>
        public const string SZCRMD = "SZCRMD";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZCHT.
        /// </summary>
        public const string SZCHT = "SZCHT";

        /// <summary>
        /// SZCHMJ.
        /// </summary>
        public const string SZCHMJ = "SZCHMJ";

        /// <summary>
        /// SZCHID.
        /// </summary>
        public const string SZCHID = "SZCHID";

        /// <summary>
        /// SZBTAN.
        /// </summary>
        public const string SZBTAN = "SZBTAN";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZBALU.
        /// </summary>
        public const string SZBALU = "SZBALU";

        /// <summary>
        /// SZVR03.
        /// </summary>
        public const string SZVR03 = "SZVR03";

        /// <summary>
        /// SZLDNM.
        /// </summary>
        public const string SZLDNM = "SZLDNM";

        /// <summary>
        /// SZMKFR.
        /// </summary>
        public const string SZMKFR = "SZMKFR";

        /// <summary>
        /// SZGAN8.
        /// </summary>
        public const string SZGAN8 = "SZGAN8";

        /// <summary>
        /// SZGSHAN.
        /// </summary>
        public const string SZGSHAN = "SZGSHAN";

        /// <summary>
        /// SZGCARS.
        /// </summary>
        public const string SZGCARS = "SZGCARS";

        /// <summary>
        /// SZGBTAN.
        /// </summary>
        public const string SZGBTAN = "SZGBTAN";

        /// <summary>
        /// SZGMKFR.
        /// </summary>
        public const string SZGMKFR = "SZGMKFR";
    }

    /// <inheritdoc />
    public override string TableName => "F47142";

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
        new JdeField("SZCHGC", "SZCHGC", JdeDataType.String, 4),
        new JdeField("SZLSTS", "SZLSTS", JdeDataType.String, 4),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
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
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZOPDJ", "SZOPDJ", JdeDataType.Numeric),
        new JdeField("SZADDJ", "SZADDJ", JdeDataType.Numeric),
        new JdeField("SZCNDJ", "SZCNDJ", JdeDataType.Numeric),
        new JdeField("SZPEFJ", "SZPEFJ", JdeDataType.Numeric),
        new JdeField("SZPPDJ", "SZPPDJ", JdeDataType.Numeric),
        new JdeField("SZPSDJ", "SZPSDJ", JdeDataType.Numeric),
        new JdeField("SZDSVJ", "SZDSVJ", JdeDataType.Numeric),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
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
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZNXTR", "SZNXTR", JdeDataType.String, 6),
        new JdeField("SZLTTR", "SZLTTR", JdeDataType.String, 6),
        new JdeField("SZRLIT", "SZRLIT", JdeDataType.String, 16),
        new JdeField("SZPDS1", "SZPDS1", JdeDataType.String, 6),
        new JdeField("SZPDS2", "SZPDS2", JdeDataType.String, 6),
        new JdeField("SZPDS3", "SZPDS3", JdeDataType.String, 6),
        new JdeField("SZPDS4", "SZPDS4", JdeDataType.String, 6),
        new JdeField("SZPDS5", "SZPDS5", JdeDataType.String, 6),
        new JdeField("SZPDP1", "SZPDP1", JdeDataType.String, 6),
        new JdeField("SZPDP2", "SZPDP2", JdeDataType.String, 6),
        new JdeField("SZPDP3", "SZPDP3", JdeDataType.String, 6),
        new JdeField("SZPDP4", "SZPDP4", JdeDataType.String, 6),
        new JdeField("SZPDP5", "SZPDP5", JdeDataType.String, 6),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZUCHG", "SZUCHG", JdeDataType.Numeric),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZUREC", "SZUREC", JdeDataType.Numeric),
        new JdeField("SZCREC", "SZCREC", JdeDataType.Numeric),
        new JdeField("SZURLV", "SZURLV", JdeDataType.Numeric),
        new JdeField("SZOTQY", "SZOTQY", JdeDataType.String, 2),
        new JdeField("SZPRRC", "SZPRRC", JdeDataType.Numeric),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZACHG", "SZACHG", JdeDataType.Numeric),
        new JdeField("SZAOPN", "SZAOPN", JdeDataType.Numeric),
        new JdeField("SZAREC", "SZAREC", JdeDataType.Numeric),
        new JdeField("SZARLV", "SZARLV", JdeDataType.Numeric),
        new JdeField("SZFTN1", "SZFTN1", JdeDataType.Numeric),
        new JdeField("SZTRLV", "SZTRLV", JdeDataType.Numeric),
        new JdeField("SZPROV", "SZPROV", JdeDataType.String, 2),
        new JdeField("SZAMC3", "SZAMC3", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZCSTO", "SZCSTO", JdeDataType.String, 2),
        new JdeField("SZCSMP", "SZCSMP", JdeDataType.String, 2),
        new JdeField("SZINMG", "SZINMG", JdeDataType.String, 20),
        new JdeField("SZASN", "SZASN", JdeDataType.String, 16),
        new JdeField("SZPRGR", "SZPRGR", JdeDataType.String, 16),
        new JdeField("SZCLVL", "SZCLVL", JdeDataType.String, 6),
        new JdeField("SZCATN", "SZCATN", JdeDataType.String, 16),
        new JdeField("SZDSPR", "SZDSPR", JdeDataType.Numeric),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZATXT", "SZATXT", JdeDataType.String, 2),
        new JdeField("SZCNID", "SZCNID", JdeDataType.String, 40),
        new JdeField("SZCDCD", "SZCDCD", JdeDataType.String, 30),
        new JdeField("SZNTR", "SZNTR", JdeDataType.String, 4),
        new JdeField("SZFRTH", "SZFRTH", JdeDataType.String, 6),
        new JdeField("SZFRTC", "SZFRTC", JdeDataType.String, 2),
        new JdeField("SZZON", "SZZON", JdeDataType.String, 6),
        new JdeField("SZFRAT", "SZFRAT", JdeDataType.String, 20),
        new JdeField("SZRATT", "SZRATT", JdeDataType.String, 2),
        new JdeField("SZANBY", "SZANBY", JdeDataType.Numeric),
        new JdeField("SZANCR", "SZANCR", JdeDataType.Numeric),
        new JdeField("SZMOT", "SZMOT", JdeDataType.String, 6),
        new JdeField("SZCOT", "SZCOT", JdeDataType.String, 6),
        new JdeField("SZSHCM", "SZSHCM", JdeDataType.String, 6),
        new JdeField("SZSHCN", "SZSHCN", JdeDataType.String, 6),
        new JdeField("SZUOM1", "SZUOM1", JdeDataType.String, 4),
        new JdeField("SZPQOR", "SZPQOR", JdeDataType.Numeric),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZUOM3", "SZUOM3", JdeDataType.String, 4),
        new JdeField("SZITWT", "SZITWT", JdeDataType.Numeric),
        new JdeField("SZWTUM", "SZWTUM", JdeDataType.String, 4),
        new JdeField("SZITVL", "SZITVL", JdeDataType.Numeric),
        new JdeField("SZVLUM", "SZVLUM", JdeDataType.String, 4),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZSTTS", "SZSTTS", JdeDataType.String, 4),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZFUF1", "SZFUF1", JdeDataType.String, 2),
        new JdeField("SZFUF2", "SZFUF2", JdeDataType.String, 2),
        new JdeField("SZGRWT", "SZGRWT", JdeDataType.Numeric),
        new JdeField("SZGWUM", "SZGWUM", JdeDataType.String, 4),
        new JdeField("SZLT", "SZLT", JdeDataType.String, 4),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZASID", "SZASID", JdeDataType.String, 50),
        new JdeField("SZCCMP", "SZCCMP", JdeDataType.Numeric),
        new JdeField("SZTAG", "SZTAG", JdeDataType.String, 16),
        new JdeField("SZWR01", "SZWR01", JdeDataType.String, 8),
        new JdeField("SZPL", "SZPL", JdeDataType.String, 8),
        new JdeField("SZELEV", "SZELEV", JdeDataType.String, 6),
        new JdeField("SZR001", "SZR001", JdeDataType.String, 6),
        new JdeField("SZRTNR", "SZRTNR", JdeDataType.String, 6),
        new JdeField("SZLCOD", "SZLCOD", JdeDataType.String, 4),
        new JdeField("SZPURG", "SZPURG", JdeDataType.String, 2),
        new JdeField("SZPROM", "SZPROM", JdeDataType.String, 2),
        new JdeField("SZFNLP", "SZFNLP", JdeDataType.String, 2),
        new JdeField("SZAVCH", "SZAVCH", JdeDataType.String, 2),
        new JdeField("SZPRPY", "SZPRPY", JdeDataType.String, 2),
        new JdeField("SZUNCD", "SZUNCD", JdeDataType.String, 2),
        new JdeField("SZMATY", "SZMATY", JdeDataType.String, 2),
        new JdeField("SZRTGC", "SZRTGC", JdeDataType.String, 2),
        new JdeField("SZRCPF", "SZRCPF", JdeDataType.String, 2),
        new JdeField("SZARTG", "SZARTG", JdeDataType.String, 24),
        new JdeField("SZCORD", "SZCORD", JdeDataType.Numeric),
        new JdeField("SZCHDT", "SZCHDT", JdeDataType.String, 4),
        new JdeField("SZDOCC", "SZDOCC", JdeDataType.Numeric),
        new JdeField("SZCHLN", "SZCHLN", JdeDataType.Numeric),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFRRC", "SZFRRC", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFUC", "SZFUC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
        new JdeField("SZFCHG", "SZFCHG", JdeDataType.Numeric),
        new JdeField("SZFAP", "SZFAP", JdeDataType.Numeric),
        new JdeField("SZFREC", "SZFREC", JdeDataType.Numeric),
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
        new JdeField("SZRSHT", "SZRSHT", JdeDataType.Numeric),
        new JdeField("SZPXDM", "SZPXDM", JdeDataType.Numeric),
        new JdeField("SZPXDD", "SZPXDD", JdeDataType.Numeric),
        new JdeField("SZPS10", "SZPS10", JdeDataType.String, 2),
        new JdeField("SZPS09", "SZPS09", JdeDataType.String, 2),
        new JdeField("SZPS08", "SZPS08", JdeDataType.String, 2),
        new JdeField("SZPS07", "SZPS07", JdeDataType.String, 2),
        new JdeField("SZPS06", "SZPS06", JdeDataType.String, 2),
        new JdeField("SZPS05", "SZPS05", JdeDataType.String, 2),
        new JdeField("SZPS04", "SZPS04", JdeDataType.String, 2),
        new JdeField("SZPS03", "SZPS03", JdeDataType.String, 2),
        new JdeField("SZPS02", "SZPS02", JdeDataType.String, 2),
        new JdeField("SZPS01", "SZPS01", JdeDataType.String, 2),
        new JdeField("SZNDTP", "SZNDTP", JdeDataType.Numeric),
        new JdeField("SZMERL", "SZMERL", JdeDataType.String, 6),
        new JdeField("SZMACT", "SZMACT", JdeDataType.String, 2),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZFTRL", "SZFTRL", JdeDataType.Numeric),
        new JdeField("SZDRQT", "SZDRQT", JdeDataType.Numeric),
        new JdeField("SZDCP", "SZDCP", JdeDataType.Numeric),
        new JdeField("SZDCD", "SZDCD", JdeDataType.Numeric),
        new JdeField("SZCTAM", "SZCTAM", JdeDataType.Numeric),
        new JdeField("SZCRMD", "SZCRMD", JdeDataType.String, 2),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZCHT", "SZCHT", JdeDataType.Numeric),
        new JdeField("SZCHMJ", "SZCHMJ", JdeDataType.Numeric),
        new JdeField("SZCHID", "SZCHID", JdeDataType.String, 20),
        new JdeField("SZBTAN", "SZBTAN", JdeDataType.Numeric),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZBALU", "SZBALU", JdeDataType.String, 2),
        new JdeField("SZVR03", "SZVR03", JdeDataType.String, 50),
        new JdeField("SZLDNM", "SZLDNM", JdeDataType.Numeric),
        new JdeField("SZMKFR", "SZMKFR", JdeDataType.Numeric),
        new JdeField("SZGAN8", "SZGAN8", JdeDataType.Numeric),
        new JdeField("SZGSHAN", "SZGSHAN", JdeDataType.Numeric),
        new JdeField("SZGCARS", "SZGCARS", JdeDataType.Numeric),
        new JdeField("SZGBTAN", "SZGBTAN", JdeDataType.Numeric),
        new JdeField("SZGMKFR", "SZGMKFR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47142_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
