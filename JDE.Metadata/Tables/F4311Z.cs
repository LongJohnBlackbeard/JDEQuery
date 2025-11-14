using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4311Z - .
/// </summary>
public class F4311Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWCTID.
        /// </summary>
        public const string PWCTID = "PWCTID";

        /// <summary>
        /// PWJOBS.
        /// </summary>
        public const string PWJOBS = "PWJOBS";

        /// <summary>
        /// PWACTN.
        /// </summary>
        public const string PWACTN = "PWACTN";

        /// <summary>
        /// PWEDFL.
        /// </summary>
        public const string PWEDFL = "PWEDFL";

        /// <summary>
        /// PWKCOO.
        /// </summary>
        public const string PWKCOO = "PWKCOO";

        /// <summary>
        /// PWDOCO.
        /// </summary>
        public const string PWDOCO = "PWDOCO";

        /// <summary>
        /// PWDCTO.
        /// </summary>
        public const string PWDCTO = "PWDCTO";

        /// <summary>
        /// PWSFXO.
        /// </summary>
        public const string PWSFXO = "PWSFXO";

        /// <summary>
        /// PWLNID.
        /// </summary>
        public const string PWLNID = "PWLNID";

        /// <summary>
        /// PWMCU.
        /// </summary>
        public const string PWMCU = "PWMCU";

        /// <summary>
        /// PWCO.
        /// </summary>
        public const string PWCO = "PWCO";

        /// <summary>
        /// PWOKCO.
        /// </summary>
        public const string PWOKCO = "PWOKCO";

        /// <summary>
        /// PWOORN.
        /// </summary>
        public const string PWOORN = "PWOORN";

        /// <summary>
        /// PWOCTO.
        /// </summary>
        public const string PWOCTO = "PWOCTO";

        /// <summary>
        /// PWOGNO.
        /// </summary>
        public const string PWOGNO = "PWOGNO";

        /// <summary>
        /// PWRKCO.
        /// </summary>
        public const string PWRKCO = "PWRKCO";

        /// <summary>
        /// PWRORN.
        /// </summary>
        public const string PWRORN = "PWRORN";

        /// <summary>
        /// PWRCTO.
        /// </summary>
        public const string PWRCTO = "PWRCTO";

        /// <summary>
        /// PWRLLN.
        /// </summary>
        public const string PWRLLN = "PWRLLN";

        /// <summary>
        /// PWDMCT.
        /// </summary>
        public const string PWDMCT = "PWDMCT";

        /// <summary>
        /// PWDMCS.
        /// </summary>
        public const string PWDMCS = "PWDMCS";

        /// <summary>
        /// PWBALU.
        /// </summary>
        public const string PWBALU = "PWBALU";

        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWSHAN.
        /// </summary>
        public const string PWSHAN = "PWSHAN";

        /// <summary>
        /// PWDRQJ.
        /// </summary>
        public const string PWDRQJ = "PWDRQJ";

        /// <summary>
        /// PWTRDJ.
        /// </summary>
        public const string PWTRDJ = "PWTRDJ";

        /// <summary>
        /// PWPDDJ.
        /// </summary>
        public const string PWPDDJ = "PWPDDJ";

        /// <summary>
        /// PWOPDJ.
        /// </summary>
        public const string PWOPDJ = "PWOPDJ";

        /// <summary>
        /// PWADDJ.
        /// </summary>
        public const string PWADDJ = "PWADDJ";

        /// <summary>
        /// PWCNDJ.
        /// </summary>
        public const string PWCNDJ = "PWCNDJ";

        /// <summary>
        /// PWPEFJ.
        /// </summary>
        public const string PWPEFJ = "PWPEFJ";

        /// <summary>
        /// PWPPDJ.
        /// </summary>
        public const string PWPPDJ = "PWPPDJ";

        /// <summary>
        /// PWPSDJ.
        /// </summary>
        public const string PWPSDJ = "PWPSDJ";

        /// <summary>
        /// PWDSVJ.
        /// </summary>
        public const string PWDSVJ = "PWDSVJ";

        /// <summary>
        /// PWDGL.
        /// </summary>
        public const string PWDGL = "PWDGL";

        /// <summary>
        /// PWPN.
        /// </summary>
        public const string PWPN = "PWPN";

        /// <summary>
        /// PWVR01.
        /// </summary>
        public const string PWVR01 = "PWVR01";

        /// <summary>
        /// PWVR02.
        /// </summary>
        public const string PWVR02 = "PWVR02";

        /// <summary>
        /// PWITM.
        /// </summary>
        public const string PWITM = "PWITM";

        /// <summary>
        /// PWLITM.
        /// </summary>
        public const string PWLITM = "PWLITM";

        /// <summary>
        /// PWAITM.
        /// </summary>
        public const string PWAITM = "PWAITM";

        /// <summary>
        /// PWLOCN.
        /// </summary>
        public const string PWLOCN = "PWLOCN";

        /// <summary>
        /// PWLOTN.
        /// </summary>
        public const string PWLOTN = "PWLOTN";

        /// <summary>
        /// PWFRGD.
        /// </summary>
        public const string PWFRGD = "PWFRGD";

        /// <summary>
        /// PWTHGD.
        /// </summary>
        public const string PWTHGD = "PWTHGD";

        /// <summary>
        /// PWFRMP.
        /// </summary>
        public const string PWFRMP = "PWFRMP";

        /// <summary>
        /// PWTHRP.
        /// </summary>
        public const string PWTHRP = "PWTHRP";

        /// <summary>
        /// PWDSC1.
        /// </summary>
        public const string PWDSC1 = "PWDSC1";

        /// <summary>
        /// PWDSC2.
        /// </summary>
        public const string PWDSC2 = "PWDSC2";

        /// <summary>
        /// PWLNTY.
        /// </summary>
        public const string PWLNTY = "PWLNTY";

        /// <summary>
        /// PWNXTR.
        /// </summary>
        public const string PWNXTR = "PWNXTR";

        /// <summary>
        /// PWLTTR.
        /// </summary>
        public const string PWLTTR = "PWLTTR";

        /// <summary>
        /// PWRLIT.
        /// </summary>
        public const string PWRLIT = "PWRLIT";

        /// <summary>
        /// PWPDS1.
        /// </summary>
        public const string PWPDS1 = "PWPDS1";

        /// <summary>
        /// PWPDS2.
        /// </summary>
        public const string PWPDS2 = "PWPDS2";

        /// <summary>
        /// PWPDS3.
        /// </summary>
        public const string PWPDS3 = "PWPDS3";

        /// <summary>
        /// PWPDS4.
        /// </summary>
        public const string PWPDS4 = "PWPDS4";

        /// <summary>
        /// PWPDS5.
        /// </summary>
        public const string PWPDS5 = "PWPDS5";

        /// <summary>
        /// PWPDP1.
        /// </summary>
        public const string PWPDP1 = "PWPDP1";

        /// <summary>
        /// PWPDP2.
        /// </summary>
        public const string PWPDP2 = "PWPDP2";

        /// <summary>
        /// PWPDP3.
        /// </summary>
        public const string PWPDP3 = "PWPDP3";

        /// <summary>
        /// PWPDP4.
        /// </summary>
        public const string PWPDP4 = "PWPDP4";

        /// <summary>
        /// PWPDP5.
        /// </summary>
        public const string PWPDP5 = "PWPDP5";

        /// <summary>
        /// PWUOM.
        /// </summary>
        public const string PWUOM = "PWUOM";

        /// <summary>
        /// PWUORG.
        /// </summary>
        public const string PWUORG = "PWUORG";

        /// <summary>
        /// PWUCHG.
        /// </summary>
        public const string PWUCHG = "PWUCHG";

        /// <summary>
        /// PWUOPN.
        /// </summary>
        public const string PWUOPN = "PWUOPN";

        /// <summary>
        /// PWUREC.
        /// </summary>
        public const string PWUREC = "PWUREC";

        /// <summary>
        /// PWCREC.
        /// </summary>
        public const string PWCREC = "PWCREC";

        /// <summary>
        /// PWURLV.
        /// </summary>
        public const string PWURLV = "PWURLV";

        /// <summary>
        /// PWOTQY.
        /// </summary>
        public const string PWOTQY = "PWOTQY";

        /// <summary>
        /// PWPRRC.
        /// </summary>
        public const string PWPRRC = "PWPRRC";

        /// <summary>
        /// PWAEXP.
        /// </summary>
        public const string PWAEXP = "PWAEXP";

        /// <summary>
        /// PWACHG.
        /// </summary>
        public const string PWACHG = "PWACHG";

        /// <summary>
        /// PWAOPN.
        /// </summary>
        public const string PWAOPN = "PWAOPN";

        /// <summary>
        /// PWAREC.
        /// </summary>
        public const string PWAREC = "PWAREC";

        /// <summary>
        /// PWARLV.
        /// </summary>
        public const string PWARLV = "PWARLV";

        /// <summary>
        /// PWFTN1.
        /// </summary>
        public const string PWFTN1 = "PWFTN1";

        /// <summary>
        /// PWTRLV.
        /// </summary>
        public const string PWTRLV = "PWTRLV";

        /// <summary>
        /// PWPROV.
        /// </summary>
        public const string PWPROV = "PWPROV";

        /// <summary>
        /// PWAMC3.
        /// </summary>
        public const string PWAMC3 = "PWAMC3";

        /// <summary>
        /// PWECST.
        /// </summary>
        public const string PWECST = "PWECST";

        /// <summary>
        /// PWCSTO.
        /// </summary>
        public const string PWCSTO = "PWCSTO";

        /// <summary>
        /// PWCSMP.
        /// </summary>
        public const string PWCSMP = "PWCSMP";

        /// <summary>
        /// PWINMG.
        /// </summary>
        public const string PWINMG = "PWINMG";

        /// <summary>
        /// PWASN.
        /// </summary>
        public const string PWASN = "PWASN";

        /// <summary>
        /// PWPRGR.
        /// </summary>
        public const string PWPRGR = "PWPRGR";

        /// <summary>
        /// PWCLVL.
        /// </summary>
        public const string PWCLVL = "PWCLVL";

        /// <summary>
        /// PWCATN.
        /// </summary>
        public const string PWCATN = "PWCATN";

        /// <summary>
        /// PWDSPR.
        /// </summary>
        public const string PWDSPR = "PWDSPR";

        /// <summary>
        /// PWPTC.
        /// </summary>
        public const string PWPTC = "PWPTC";

        /// <summary>
        /// PWTX.
        /// </summary>
        public const string PWTX = "PWTX";

        /// <summary>
        /// PWEXR1.
        /// </summary>
        public const string PWEXR1 = "PWEXR1";

        /// <summary>
        /// PWTXA1.
        /// </summary>
        public const string PWTXA1 = "PWTXA1";

        /// <summary>
        /// PWATXT.
        /// </summary>
        public const string PWATXT = "PWATXT";

        /// <summary>
        /// PWCNID.
        /// </summary>
        public const string PWCNID = "PWCNID";

        /// <summary>
        /// PWCDCD.
        /// </summary>
        public const string PWCDCD = "PWCDCD";

        /// <summary>
        /// PWNTR.
        /// </summary>
        public const string PWNTR = "PWNTR";

        /// <summary>
        /// PWFRTH.
        /// </summary>
        public const string PWFRTH = "PWFRTH";

        /// <summary>
        /// PWFRTC.
        /// </summary>
        public const string PWFRTC = "PWFRTC";

        /// <summary>
        /// PWZON.
        /// </summary>
        public const string PWZON = "PWZON";

        /// <summary>
        /// PWFRAT.
        /// </summary>
        public const string PWFRAT = "PWFRAT";

        /// <summary>
        /// PWRATT.
        /// </summary>
        public const string PWRATT = "PWRATT";

        /// <summary>
        /// PWANBY.
        /// </summary>
        public const string PWANBY = "PWANBY";

        /// <summary>
        /// PWANCR.
        /// </summary>
        public const string PWANCR = "PWANCR";

        /// <summary>
        /// PWMOT.
        /// </summary>
        public const string PWMOT = "PWMOT";

        /// <summary>
        /// PWCOT.
        /// </summary>
        public const string PWCOT = "PWCOT";

        /// <summary>
        /// PWSHCM.
        /// </summary>
        public const string PWSHCM = "PWSHCM";

        /// <summary>
        /// PWSHCN.
        /// </summary>
        public const string PWSHCN = "PWSHCN";

        /// <summary>
        /// PWUOM1.
        /// </summary>
        public const string PWUOM1 = "PWUOM1";

        /// <summary>
        /// PWPQOR.
        /// </summary>
        public const string PWPQOR = "PWPQOR";

        /// <summary>
        /// PWUOM2.
        /// </summary>
        public const string PWUOM2 = "PWUOM2";

        /// <summary>
        /// PWSQOR.
        /// </summary>
        public const string PWSQOR = "PWSQOR";

        /// <summary>
        /// PWUOM3.
        /// </summary>
        public const string PWUOM3 = "PWUOM3";

        /// <summary>
        /// PWITWT.
        /// </summary>
        public const string PWITWT = "PWITWT";

        /// <summary>
        /// PWWTUM.
        /// </summary>
        public const string PWWTUM = "PWWTUM";

        /// <summary>
        /// PWITVL.
        /// </summary>
        public const string PWITVL = "PWITVL";

        /// <summary>
        /// PWVLUM.
        /// </summary>
        public const string PWVLUM = "PWVLUM";

        /// <summary>
        /// PWGLC.
        /// </summary>
        public const string PWGLC = "PWGLC";

        /// <summary>
        /// PWCTRY.
        /// </summary>
        public const string PWCTRY = "PWCTRY";

        /// <summary>
        /// PWFY.
        /// </summary>
        public const string PWFY = "PWFY";

        /// <summary>
        /// PWSTTS.
        /// </summary>
        public const string PWSTTS = "PWSTTS";

        /// <summary>
        /// PWRCD.
        /// </summary>
        public const string PWRCD = "PWRCD";

        /// <summary>
        /// PWFUF1.
        /// </summary>
        public const string PWFUF1 = "PWFUF1";

        /// <summary>
        /// PWFUF2.
        /// </summary>
        public const string PWFUF2 = "PWFUF2";

        /// <summary>
        /// PWGRWT.
        /// </summary>
        public const string PWGRWT = "PWGRWT";

        /// <summary>
        /// PWGWUM.
        /// </summary>
        public const string PWGWUM = "PWGWUM";

        /// <summary>
        /// PWLT.
        /// </summary>
        public const string PWLT = "PWLT";

        /// <summary>
        /// PWANI.
        /// </summary>
        public const string PWANI = "PWANI";

        /// <summary>
        /// PWAID.
        /// </summary>
        public const string PWAID = "PWAID";

        /// <summary>
        /// PWOMCU.
        /// </summary>
        public const string PWOMCU = "PWOMCU";

        /// <summary>
        /// PWOBJ.
        /// </summary>
        public const string PWOBJ = "PWOBJ";

        /// <summary>
        /// PWSUB.
        /// </summary>
        public const string PWSUB = "PWSUB";

        /// <summary>
        /// PWSBLT.
        /// </summary>
        public const string PWSBLT = "PWSBLT";

        /// <summary>
        /// PWSBL.
        /// </summary>
        public const string PWSBL = "PWSBL";

        /// <summary>
        /// PWASID.
        /// </summary>
        public const string PWASID = "PWASID";

        /// <summary>
        /// PWCCMP.
        /// </summary>
        public const string PWCCMP = "PWCCMP";

        /// <summary>
        /// PWTAG.
        /// </summary>
        public const string PWTAG = "PWTAG";

        /// <summary>
        /// PWWR01.
        /// </summary>
        public const string PWWR01 = "PWWR01";

        /// <summary>
        /// PWPL.
        /// </summary>
        public const string PWPL = "PWPL";

        /// <summary>
        /// PWELEV.
        /// </summary>
        public const string PWELEV = "PWELEV";

        /// <summary>
        /// PWR001.
        /// </summary>
        public const string PWR001 = "PWR001";

        /// <summary>
        /// PWRTNR.
        /// </summary>
        public const string PWRTNR = "PWRTNR";

        /// <summary>
        /// PWLCOD.
        /// </summary>
        public const string PWLCOD = "PWLCOD";

        /// <summary>
        /// PWPURG.
        /// </summary>
        public const string PWPURG = "PWPURG";

        /// <summary>
        /// PWPROM.
        /// </summary>
        public const string PWPROM = "PWPROM";

        /// <summary>
        /// PWFNLP.
        /// </summary>
        public const string PWFNLP = "PWFNLP";

        /// <summary>
        /// PWAVCH.
        /// </summary>
        public const string PWAVCH = "PWAVCH";

        /// <summary>
        /// PWPRPY.
        /// </summary>
        public const string PWPRPY = "PWPRPY";

        /// <summary>
        /// PWUNCD.
        /// </summary>
        public const string PWUNCD = "PWUNCD";

        /// <summary>
        /// PWMATY.
        /// </summary>
        public const string PWMATY = "PWMATY";

        /// <summary>
        /// PWRTGC.
        /// </summary>
        public const string PWRTGC = "PWRTGC";

        /// <summary>
        /// PWRCPF.
        /// </summary>
        public const string PWRCPF = "PWRCPF";

        /// <summary>
        /// PWPS01.
        /// </summary>
        public const string PWPS01 = "PWPS01";

        /// <summary>
        /// PWPS02.
        /// </summary>
        public const string PWPS02 = "PWPS02";

        /// <summary>
        /// PWPS03.
        /// </summary>
        public const string PWPS03 = "PWPS03";

        /// <summary>
        /// PWPS04.
        /// </summary>
        public const string PWPS04 = "PWPS04";

        /// <summary>
        /// PWPS05.
        /// </summary>
        public const string PWPS05 = "PWPS05";

        /// <summary>
        /// PWPS06.
        /// </summary>
        public const string PWPS06 = "PWPS06";

        /// <summary>
        /// PWPS07.
        /// </summary>
        public const string PWPS07 = "PWPS07";

        /// <summary>
        /// PWPS08.
        /// </summary>
        public const string PWPS08 = "PWPS08";

        /// <summary>
        /// PWPS09.
        /// </summary>
        public const string PWPS09 = "PWPS09";

        /// <summary>
        /// PWPS10.
        /// </summary>
        public const string PWPS10 = "PWPS10";

        /// <summary>
        /// PWCRMD.
        /// </summary>
        public const string PWCRMD = "PWCRMD";

        /// <summary>
        /// PWARTG.
        /// </summary>
        public const string PWARTG = "PWARTG";

        /// <summary>
        /// PWCORD.
        /// </summary>
        public const string PWCORD = "PWCORD";

        /// <summary>
        /// PWCHDT.
        /// </summary>
        public const string PWCHDT = "PWCHDT";

        /// <summary>
        /// PWDOCC.
        /// </summary>
        public const string PWDOCC = "PWDOCC";

        /// <summary>
        /// PWCHLN.
        /// </summary>
        public const string PWCHLN = "PWCHLN";

        /// <summary>
        /// PWCRCD.
        /// </summary>
        public const string PWCRCD = "PWCRCD";

        /// <summary>
        /// PWCRR.
        /// </summary>
        public const string PWCRR = "PWCRR";

        /// <summary>
        /// PWFRRC.
        /// </summary>
        public const string PWFRRC = "PWFRRC";

        /// <summary>
        /// PWFEA.
        /// </summary>
        public const string PWFEA = "PWFEA";

        /// <summary>
        /// PWFUC.
        /// </summary>
        public const string PWFUC = "PWFUC";

        /// <summary>
        /// PWFEC.
        /// </summary>
        public const string PWFEC = "PWFEC";

        /// <summary>
        /// PWFCHG.
        /// </summary>
        public const string PWFCHG = "PWFCHG";

        /// <summary>
        /// PWFAP.
        /// </summary>
        public const string PWFAP = "PWFAP";

        /// <summary>
        /// PWFREC.
        /// </summary>
        public const string PWFREC = "PWFREC";

        /// <summary>
        /// PWURCD.
        /// </summary>
        public const string PWURCD = "PWURCD";

        /// <summary>
        /// PWURDT.
        /// </summary>
        public const string PWURDT = "PWURDT";

        /// <summary>
        /// PWURAT.
        /// </summary>
        public const string PWURAT = "PWURAT";

        /// <summary>
        /// PWURAB.
        /// </summary>
        public const string PWURAB = "PWURAB";

        /// <summary>
        /// PWURRF.
        /// </summary>
        public const string PWURRF = "PWURRF";

        /// <summary>
        /// PWTORG.
        /// </summary>
        public const string PWTORG = "PWTORG";

        /// <summary>
        /// PWUSER.
        /// </summary>
        public const string PWUSER = "PWUSER";

        /// <summary>
        /// PWPID.
        /// </summary>
        public const string PWPID = "PWPID";

        /// <summary>
        /// PWJOBN.
        /// </summary>
        public const string PWJOBN = "PWJOBN";

        /// <summary>
        /// PWUPMJ.
        /// </summary>
        public const string PWUPMJ = "PWUPMJ";

        /// <summary>
        /// PWTDAY.
        /// </summary>
        public const string PWTDAY = "PWTDAY";

        /// <summary>
        /// PWIVI.
        /// </summary>
        public const string PWIVI = "PWIVI";

        /// <summary>
        /// PWWRTH.
        /// </summary>
        public const string PWWRTH = "PWWRTH";

        /// <summary>
        /// PWPOGS.
        /// </summary>
        public const string PWPOGS = "PWPOGS";

        /// <summary>
        /// PWSTKT.
        /// </summary>
        public const string PWSTKT = "PWSTKT";

        /// <summary>
        /// PWCNV2.
        /// </summary>
        public const string PWCNV2 = "PWCNV2";

        /// <summary>
        /// PWCONV.
        /// </summary>
        public const string PWCONV = "PWCONV";

        /// <summary>
        /// PWMODE.
        /// </summary>
        public const string PWMODE = "PWMODE";

        /// <summary>
        /// PWUKID.
        /// </summary>
        public const string PWUKID = "PWUKID";

        /// <summary>
        /// PWSOPO.
        /// </summary>
        public const string PWSOPO = "PWSOPO";

        /// <summary>
        /// PWSEQ.
        /// </summary>
        public const string PWSEQ = "PWSEQ";

        /// <summary>
        /// PWPSRY.
        /// </summary>
        public const string PWPSRY = "PWPSRY";

        /// <summary>
        /// PWPSR.
        /// </summary>
        public const string PWPSR = "PWPSR";

        /// <summary>
        /// PWSFX.
        /// </summary>
        public const string PWSFX = "PWSFX";

        /// <summary>
        /// PWMSGT.
        /// </summary>
        public const string PWMSGT = "PWMSGT";

        /// <summary>
        /// PWMTST.
        /// </summary>
        public const string PWMTST = "PWMTST";

        /// <summary>
        /// PWLNIX.
        /// </summary>
        public const string PWLNIX = "PWLNIX";

        /// <summary>
        /// PWAREV.
        /// </summary>
        public const string PWAREV = "PWAREV";

        /// <summary>
        /// PWDETD.
        /// </summary>
        public const string PWDETD = "PWDETD";

        /// <summary>
        /// PWDETF.
        /// </summary>
        public const string PWDETF = "PWDETF";

        /// <summary>
        /// PWABT1.
        /// </summary>
        public const string PWABT1 = "PWABT1";

        /// <summary>
        /// PWABR1.
        /// </summary>
        public const string PWABR1 = "PWABR1";

        /// <summary>
        /// PWABT2.
        /// </summary>
        public const string PWABT2 = "PWABT2";

        /// <summary>
        /// PWABR2.
        /// </summary>
        public const string PWABR2 = "PWABR2";

        /// <summary>
        /// PWABT3.
        /// </summary>
        public const string PWABT3 = "PWABT3";

        /// <summary>
        /// PWABR3.
        /// </summary>
        public const string PWABR3 = "PWABR3";

        /// <summary>
        /// PWABT4.
        /// </summary>
        public const string PWABT4 = "PWABT4";

        /// <summary>
        /// PWABR4.
        /// </summary>
        public const string PWABR4 = "PWABR4";

        /// <summary>
        /// PWOSFX.
        /// </summary>
        public const string PWOSFX = "PWOSFX";

        /// <summary>
        /// PWHCLD.
        /// </summary>
        public const string PWHCLD = "PWHCLD";

        /// <summary>
        /// PWDOC8.
        /// </summary>
        public const string PWDOC8 = "PWDOC8";

        /// <summary>
        /// PWODCT.
        /// </summary>
        public const string PWODCT = "PWODCT";

        /// <summary>
        /// PWCO0.
        /// </summary>
        public const string PWCO0 = "PWCO0";

        /// <summary>
        /// PWSFIX.
        /// </summary>
        public const string PWSFIX = "PWSFIX";

        /// <summary>
        /// PWLINN.
        /// </summary>
        public const string PWLINN = "PWLINN";

        /// <summary>
        /// PWSHPN.
        /// </summary>
        public const string PWSHPN = "PWSHPN";

        /// <summary>
        /// PWPEID.
        /// </summary>
        public const string PWPEID = "PWPEID";

        /// <summary>
        /// PWTCID.
        /// </summary>
        public const string PWTCID = "PWTCID";

        /// <summary>
        /// PWDUAL.
        /// </summary>
        public const string PWDUAL = "PWDUAL";

        /// <summary>
        /// PWPRJM.
        /// </summary>
        public const string PWPRJM = "PWPRJM";

        /// <summary>
        /// PWDLEJ.
        /// </summary>
        public const string PWDLEJ = "PWDLEJ";

        /// <summary>
        /// PWPMTN.
        /// </summary>
        public const string PWPMTN = "PWPMTN";

        /// <summary>
        /// PWXDCK.
        /// </summary>
        public const string PWXDCK = "PWXDCK";

        /// <summary>
        /// PWMCLN.
        /// </summary>
        public const string PWMCLN = "PWMCLN";

        /// <summary>
        /// PWUNSPSC.
        /// </summary>
        public const string PWUNSPSC = "PWUNSPSC";

        /// <summary>
        /// PWCMDCDE.
        /// </summary>
        public const string PWCMDCDE = "PWCMDCDE";

        /// <summary>
        /// PWRSFX.
        /// </summary>
        public const string PWRSFX = "PWRSFX";

        /// <summary>
        /// PWVR03.
        /// </summary>
        public const string PWVR03 = "PWVR03";

        /// <summary>
        /// PWMACT.
        /// </summary>
        public const string PWMACT = "PWMACT";

        /// <summary>
        /// PWBLKT.
        /// </summary>
        public const string PWBLKT = "PWBLKT";

        /// <summary>
        /// PWAFND.
        /// </summary>
        public const string PWAFND = "PWAFND";

        /// <summary>
        /// PWWVID.
        /// </summary>
        public const string PWWVID = "PWWVID";

        /// <summary>
        /// PWCNTRTID.
        /// </summary>
        public const string PWCNTRTID = "PWCNTRTID";

        /// <summary>
        /// PWCNTRTDID.
        /// </summary>
        public const string PWCNTRTDID = "PWCNTRTDID";

        /// <summary>
        /// PWMOADJ.
        /// </summary>
        public const string PWMOADJ = "PWMOADJ";

        /// <summary>
        /// PWWVTY.
        /// </summary>
        public const string PWWVTY = "PWWVTY";

        /// <summary>
        /// PWPODC01.
        /// </summary>
        public const string PWPODC01 = "PWPODC01";

        /// <summary>
        /// PWPODC02.
        /// </summary>
        public const string PWPODC02 = "PWPODC02";

        /// <summary>
        /// PWPODC03.
        /// </summary>
        public const string PWPODC03 = "PWPODC03";

        /// <summary>
        /// PWPODC04.
        /// </summary>
        public const string PWPODC04 = "PWPODC04";

        /// <summary>
        /// PWJBCD.
        /// </summary>
        public const string PWJBCD = "PWJBCD";

        /// <summary>
        /// PWSRQTY.
        /// </summary>
        public const string PWSRQTY = "PWSRQTY";

        /// <summary>
        /// PWSRUOM.
        /// </summary>
        public const string PWSRUOM = "PWSRUOM";

        /// <summary>
        /// PWCFGFL.
        /// </summary>
        public const string PWCFGFL = "PWCFGFL";

        /// <summary>
        /// PWPMPN.
        /// </summary>
        public const string PWPMPN = "PWPMPN";

        /// <summary>
        /// PWPNS.
        /// </summary>
        public const string PWPNS = "PWPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F4311Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWCTID", "PWCTID", JdeDataType.String, 30, true, true),
        new JdeField("PWJOBS", "PWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PWACTN", "PWACTN", JdeDataType.String, 2),
        new JdeField("PWEDFL", "PWEDFL", JdeDataType.String, 2),
        new JdeField("PWKCOO", "PWKCOO", JdeDataType.String, 10),
        new JdeField("PWDOCO", "PWDOCO", JdeDataType.Numeric),
        new JdeField("PWDCTO", "PWDCTO", JdeDataType.String, 4),
        new JdeField("PWSFXO", "PWSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PWLNID", "PWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWMCU", "PWMCU", JdeDataType.String, 24),
        new JdeField("PWCO", "PWCO", JdeDataType.String, 10),
        new JdeField("PWOKCO", "PWOKCO", JdeDataType.String, 10),
        new JdeField("PWOORN", "PWOORN", JdeDataType.String, 16),
        new JdeField("PWOCTO", "PWOCTO", JdeDataType.String, 4),
        new JdeField("PWOGNO", "PWOGNO", JdeDataType.Numeric),
        new JdeField("PWRKCO", "PWRKCO", JdeDataType.String, 10),
        new JdeField("PWRORN", "PWRORN", JdeDataType.String, 16),
        new JdeField("PWRCTO", "PWRCTO", JdeDataType.String, 4),
        new JdeField("PWRLLN", "PWRLLN", JdeDataType.Numeric),
        new JdeField("PWDMCT", "PWDMCT", JdeDataType.String, 24),
        new JdeField("PWDMCS", "PWDMCS", JdeDataType.Numeric),
        new JdeField("PWBALU", "PWBALU", JdeDataType.String, 2),
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric),
        new JdeField("PWSHAN", "PWSHAN", JdeDataType.Numeric),
        new JdeField("PWDRQJ", "PWDRQJ", JdeDataType.Numeric),
        new JdeField("PWTRDJ", "PWTRDJ", JdeDataType.Numeric),
        new JdeField("PWPDDJ", "PWPDDJ", JdeDataType.Numeric),
        new JdeField("PWOPDJ", "PWOPDJ", JdeDataType.Numeric),
        new JdeField("PWADDJ", "PWADDJ", JdeDataType.Numeric),
        new JdeField("PWCNDJ", "PWCNDJ", JdeDataType.Numeric),
        new JdeField("PWPEFJ", "PWPEFJ", JdeDataType.Numeric),
        new JdeField("PWPPDJ", "PWPPDJ", JdeDataType.Numeric),
        new JdeField("PWPSDJ", "PWPSDJ", JdeDataType.Numeric),
        new JdeField("PWDSVJ", "PWDSVJ", JdeDataType.Numeric),
        new JdeField("PWDGL", "PWDGL", JdeDataType.Numeric),
        new JdeField("PWPN", "PWPN", JdeDataType.Numeric),
        new JdeField("PWVR01", "PWVR01", JdeDataType.String, 50),
        new JdeField("PWVR02", "PWVR02", JdeDataType.String, 50),
        new JdeField("PWITM", "PWITM", JdeDataType.Numeric),
        new JdeField("PWLITM", "PWLITM", JdeDataType.String, 50),
        new JdeField("PWAITM", "PWAITM", JdeDataType.String, 50),
        new JdeField("PWLOCN", "PWLOCN", JdeDataType.String, 40),
        new JdeField("PWLOTN", "PWLOTN", JdeDataType.String, 60),
        new JdeField("PWFRGD", "PWFRGD", JdeDataType.String, 6),
        new JdeField("PWTHGD", "PWTHGD", JdeDataType.String, 6),
        new JdeField("PWFRMP", "PWFRMP", JdeDataType.Numeric),
        new JdeField("PWTHRP", "PWTHRP", JdeDataType.Numeric),
        new JdeField("PWDSC1", "PWDSC1", JdeDataType.String, 60),
        new JdeField("PWDSC2", "PWDSC2", JdeDataType.String, 60),
        new JdeField("PWLNTY", "PWLNTY", JdeDataType.String, 4),
        new JdeField("PWNXTR", "PWNXTR", JdeDataType.String, 6),
        new JdeField("PWLTTR", "PWLTTR", JdeDataType.String, 6),
        new JdeField("PWRLIT", "PWRLIT", JdeDataType.String, 16),
        new JdeField("PWPDS1", "PWPDS1", JdeDataType.String, 6),
        new JdeField("PWPDS2", "PWPDS2", JdeDataType.String, 6),
        new JdeField("PWPDS3", "PWPDS3", JdeDataType.String, 6),
        new JdeField("PWPDS4", "PWPDS4", JdeDataType.String, 6),
        new JdeField("PWPDS5", "PWPDS5", JdeDataType.String, 6),
        new JdeField("PWPDP1", "PWPDP1", JdeDataType.String, 6),
        new JdeField("PWPDP2", "PWPDP2", JdeDataType.String, 6),
        new JdeField("PWPDP3", "PWPDP3", JdeDataType.String, 6),
        new JdeField("PWPDP4", "PWPDP4", JdeDataType.String, 6),
        new JdeField("PWPDP5", "PWPDP5", JdeDataType.String, 6),
        new JdeField("PWUOM", "PWUOM", JdeDataType.String, 4),
        new JdeField("PWUORG", "PWUORG", JdeDataType.Numeric),
        new JdeField("PWUCHG", "PWUCHG", JdeDataType.Numeric),
        new JdeField("PWUOPN", "PWUOPN", JdeDataType.Numeric),
        new JdeField("PWUREC", "PWUREC", JdeDataType.Numeric),
        new JdeField("PWCREC", "PWCREC", JdeDataType.Numeric),
        new JdeField("PWURLV", "PWURLV", JdeDataType.Numeric),
        new JdeField("PWOTQY", "PWOTQY", JdeDataType.String, 2),
        new JdeField("PWPRRC", "PWPRRC", JdeDataType.Numeric),
        new JdeField("PWAEXP", "PWAEXP", JdeDataType.Numeric),
        new JdeField("PWACHG", "PWACHG", JdeDataType.Numeric),
        new JdeField("PWAOPN", "PWAOPN", JdeDataType.Numeric),
        new JdeField("PWAREC", "PWAREC", JdeDataType.Numeric),
        new JdeField("PWARLV", "PWARLV", JdeDataType.Numeric),
        new JdeField("PWFTN1", "PWFTN1", JdeDataType.Numeric),
        new JdeField("PWTRLV", "PWTRLV", JdeDataType.Numeric),
        new JdeField("PWPROV", "PWPROV", JdeDataType.String, 2),
        new JdeField("PWAMC3", "PWAMC3", JdeDataType.Numeric),
        new JdeField("PWECST", "PWECST", JdeDataType.Numeric),
        new JdeField("PWCSTO", "PWCSTO", JdeDataType.String, 2),
        new JdeField("PWCSMP", "PWCSMP", JdeDataType.String, 2),
        new JdeField("PWINMG", "PWINMG", JdeDataType.String, 20),
        new JdeField("PWASN", "PWASN", JdeDataType.String, 16),
        new JdeField("PWPRGR", "PWPRGR", JdeDataType.String, 16),
        new JdeField("PWCLVL", "PWCLVL", JdeDataType.String, 6),
        new JdeField("PWCATN", "PWCATN", JdeDataType.String, 16),
        new JdeField("PWDSPR", "PWDSPR", JdeDataType.Numeric),
        new JdeField("PWPTC", "PWPTC", JdeDataType.String, 6),
        new JdeField("PWTX", "PWTX", JdeDataType.String, 2),
        new JdeField("PWEXR1", "PWEXR1", JdeDataType.String, 4),
        new JdeField("PWTXA1", "PWTXA1", JdeDataType.String, 20),
        new JdeField("PWATXT", "PWATXT", JdeDataType.String, 2),
        new JdeField("PWCNID", "PWCNID", JdeDataType.String, 40),
        new JdeField("PWCDCD", "PWCDCD", JdeDataType.String, 30),
        new JdeField("PWNTR", "PWNTR", JdeDataType.String, 4),
        new JdeField("PWFRTH", "PWFRTH", JdeDataType.String, 6),
        new JdeField("PWFRTC", "PWFRTC", JdeDataType.String, 2),
        new JdeField("PWZON", "PWZON", JdeDataType.String, 6),
        new JdeField("PWFRAT", "PWFRAT", JdeDataType.String, 20),
        new JdeField("PWRATT", "PWRATT", JdeDataType.String, 2),
        new JdeField("PWANBY", "PWANBY", JdeDataType.Numeric),
        new JdeField("PWANCR", "PWANCR", JdeDataType.Numeric),
        new JdeField("PWMOT", "PWMOT", JdeDataType.String, 6),
        new JdeField("PWCOT", "PWCOT", JdeDataType.String, 6),
        new JdeField("PWSHCM", "PWSHCM", JdeDataType.String, 6),
        new JdeField("PWSHCN", "PWSHCN", JdeDataType.String, 6),
        new JdeField("PWUOM1", "PWUOM1", JdeDataType.String, 4),
        new JdeField("PWPQOR", "PWPQOR", JdeDataType.Numeric),
        new JdeField("PWUOM2", "PWUOM2", JdeDataType.String, 4),
        new JdeField("PWSQOR", "PWSQOR", JdeDataType.Numeric),
        new JdeField("PWUOM3", "PWUOM3", JdeDataType.String, 4),
        new JdeField("PWITWT", "PWITWT", JdeDataType.Numeric),
        new JdeField("PWWTUM", "PWWTUM", JdeDataType.String, 4),
        new JdeField("PWITVL", "PWITVL", JdeDataType.Numeric),
        new JdeField("PWVLUM", "PWVLUM", JdeDataType.String, 4),
        new JdeField("PWGLC", "PWGLC", JdeDataType.String, 8),
        new JdeField("PWCTRY", "PWCTRY", JdeDataType.Numeric),
        new JdeField("PWFY", "PWFY", JdeDataType.Numeric),
        new JdeField("PWSTTS", "PWSTTS", JdeDataType.String, 4),
        new JdeField("PWRCD", "PWRCD", JdeDataType.String, 6),
        new JdeField("PWFUF1", "PWFUF1", JdeDataType.String, 2),
        new JdeField("PWFUF2", "PWFUF2", JdeDataType.String, 2),
        new JdeField("PWGRWT", "PWGRWT", JdeDataType.Numeric),
        new JdeField("PWGWUM", "PWGWUM", JdeDataType.String, 4),
        new JdeField("PWLT", "PWLT", JdeDataType.String, 4),
        new JdeField("PWANI", "PWANI", JdeDataType.String, 58),
        new JdeField("PWAID", "PWAID", JdeDataType.String, 16),
        new JdeField("PWOMCU", "PWOMCU", JdeDataType.String, 24),
        new JdeField("PWOBJ", "PWOBJ", JdeDataType.String, 12),
        new JdeField("PWSUB", "PWSUB", JdeDataType.String, 16),
        new JdeField("PWSBLT", "PWSBLT", JdeDataType.String, 2),
        new JdeField("PWSBL", "PWSBL", JdeDataType.String, 16),
        new JdeField("PWASID", "PWASID", JdeDataType.String, 50),
        new JdeField("PWCCMP", "PWCCMP", JdeDataType.Numeric),
        new JdeField("PWTAG", "PWTAG", JdeDataType.String, 16),
        new JdeField("PWWR01", "PWWR01", JdeDataType.String, 8),
        new JdeField("PWPL", "PWPL", JdeDataType.String, 8),
        new JdeField("PWELEV", "PWELEV", JdeDataType.String, 6),
        new JdeField("PWR001", "PWR001", JdeDataType.String, 6),
        new JdeField("PWRTNR", "PWRTNR", JdeDataType.String, 6),
        new JdeField("PWLCOD", "PWLCOD", JdeDataType.String, 4),
        new JdeField("PWPURG", "PWPURG", JdeDataType.String, 2),
        new JdeField("PWPROM", "PWPROM", JdeDataType.String, 2),
        new JdeField("PWFNLP", "PWFNLP", JdeDataType.String, 2),
        new JdeField("PWAVCH", "PWAVCH", JdeDataType.String, 2),
        new JdeField("PWPRPY", "PWPRPY", JdeDataType.String, 2),
        new JdeField("PWUNCD", "PWUNCD", JdeDataType.String, 2),
        new JdeField("PWMATY", "PWMATY", JdeDataType.String, 2),
        new JdeField("PWRTGC", "PWRTGC", JdeDataType.String, 2),
        new JdeField("PWRCPF", "PWRCPF", JdeDataType.String, 2),
        new JdeField("PWPS01", "PWPS01", JdeDataType.String, 2),
        new JdeField("PWPS02", "PWPS02", JdeDataType.String, 2),
        new JdeField("PWPS03", "PWPS03", JdeDataType.String, 2),
        new JdeField("PWPS04", "PWPS04", JdeDataType.String, 2),
        new JdeField("PWPS05", "PWPS05", JdeDataType.String, 2),
        new JdeField("PWPS06", "PWPS06", JdeDataType.String, 2),
        new JdeField("PWPS07", "PWPS07", JdeDataType.String, 2),
        new JdeField("PWPS08", "PWPS08", JdeDataType.String, 2),
        new JdeField("PWPS09", "PWPS09", JdeDataType.String, 2),
        new JdeField("PWPS10", "PWPS10", JdeDataType.String, 2),
        new JdeField("PWCRMD", "PWCRMD", JdeDataType.String, 2),
        new JdeField("PWARTG", "PWARTG", JdeDataType.String, 24),
        new JdeField("PWCORD", "PWCORD", JdeDataType.Numeric),
        new JdeField("PWCHDT", "PWCHDT", JdeDataType.String, 4),
        new JdeField("PWDOCC", "PWDOCC", JdeDataType.Numeric),
        new JdeField("PWCHLN", "PWCHLN", JdeDataType.Numeric),
        new JdeField("PWCRCD", "PWCRCD", JdeDataType.String, 6),
        new JdeField("PWCRR", "PWCRR", JdeDataType.Numeric),
        new JdeField("PWFRRC", "PWFRRC", JdeDataType.Numeric),
        new JdeField("PWFEA", "PWFEA", JdeDataType.Numeric),
        new JdeField("PWFUC", "PWFUC", JdeDataType.Numeric),
        new JdeField("PWFEC", "PWFEC", JdeDataType.Numeric),
        new JdeField("PWFCHG", "PWFCHG", JdeDataType.Numeric),
        new JdeField("PWFAP", "PWFAP", JdeDataType.Numeric),
        new JdeField("PWFREC", "PWFREC", JdeDataType.Numeric),
        new JdeField("PWURCD", "PWURCD", JdeDataType.String, 4),
        new JdeField("PWURDT", "PWURDT", JdeDataType.Numeric),
        new JdeField("PWURAT", "PWURAT", JdeDataType.Numeric),
        new JdeField("PWURAB", "PWURAB", JdeDataType.Numeric),
        new JdeField("PWURRF", "PWURRF", JdeDataType.String, 30),
        new JdeField("PWTORG", "PWTORG", JdeDataType.String, 20),
        new JdeField("PWUSER", "PWUSER", JdeDataType.String, 20),
        new JdeField("PWPID", "PWPID", JdeDataType.String, 20),
        new JdeField("PWJOBN", "PWJOBN", JdeDataType.String, 20),
        new JdeField("PWUPMJ", "PWUPMJ", JdeDataType.Numeric),
        new JdeField("PWTDAY", "PWTDAY", JdeDataType.Numeric),
        new JdeField("PWIVI", "PWIVI", JdeDataType.String, 2),
        new JdeField("PWWRTH", "PWWRTH", JdeDataType.String, 2),
        new JdeField("PWPOGS", "PWPOGS", JdeDataType.String, 2),
        new JdeField("PWSTKT", "PWSTKT", JdeDataType.String, 2),
        new JdeField("PWCNV2", "PWCNV2", JdeDataType.Numeric),
        new JdeField("PWCONV", "PWCONV", JdeDataType.Numeric),
        new JdeField("PWMODE", "PWMODE", JdeDataType.String, 2),
        new JdeField("PWUKID", "PWUKID", JdeDataType.Numeric),
        new JdeField("PWSOPO", "PWSOPO", JdeDataType.String, 2),
        new JdeField("PWSEQ", "PWSEQ", JdeDataType.Numeric),
        new JdeField("PWPSRY", "PWPSRY", JdeDataType.String, 4),
        new JdeField("PWPSR", "PWPSR", JdeDataType.String, 24),
        new JdeField("PWSFX", "PWSFX", JdeDataType.String, 6),
        new JdeField("PWMSGT", "PWMSGT", JdeDataType.String, 2),
        new JdeField("PWMTST", "PWMTST", JdeDataType.String, 4),
        new JdeField("PWLNIX", "PWLNIX", JdeDataType.Numeric),
        new JdeField("PWAREV", "PWAREV", JdeDataType.Numeric),
        new JdeField("PWDETD", "PWDETD", JdeDataType.Numeric),
        new JdeField("PWDETF", "PWDETF", JdeDataType.Numeric),
        new JdeField("PWABT1", "PWABT1", JdeDataType.String, 2),
        new JdeField("PWABR1", "PWABR1", JdeDataType.String, 24),
        new JdeField("PWABT2", "PWABT2", JdeDataType.String, 2),
        new JdeField("PWABR2", "PWABR2", JdeDataType.String, 24),
        new JdeField("PWABT3", "PWABT3", JdeDataType.String, 2),
        new JdeField("PWABR3", "PWABR3", JdeDataType.String, 24),
        new JdeField("PWABT4", "PWABT4", JdeDataType.String, 2),
        new JdeField("PWABR4", "PWABR4", JdeDataType.String, 24),
        new JdeField("PWOSFX", "PWOSFX", JdeDataType.String, 6),
        new JdeField("PWHCLD", "PWHCLD", JdeDataType.String, 2),
        new JdeField("PWDOC8", "PWDOC8", JdeDataType.String, 16),
        new JdeField("PWODCT", "PWODCT", JdeDataType.String, 4),
        new JdeField("PWCO0", "PWCO0", JdeDataType.String, 10),
        new JdeField("PWSFIX", "PWSFIX", JdeDataType.String, 6),
        new JdeField("PWLINN", "PWLINN", JdeDataType.Numeric),
        new JdeField("PWSHPN", "PWSHPN", JdeDataType.Numeric),
        new JdeField("PWPEID", "PWPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWTCID", "PWTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWDUAL", "PWDUAL", JdeDataType.String, 2),
        new JdeField("PWPRJM", "PWPRJM", JdeDataType.Numeric),
        new JdeField("PWDLEJ", "PWDLEJ", JdeDataType.Numeric),
        new JdeField("PWPMTN", "PWPMTN", JdeDataType.String, 24),
        new JdeField("PWXDCK", "PWXDCK", JdeDataType.String, 2),
        new JdeField("PWMCLN", "PWMCLN", JdeDataType.Numeric),
        new JdeField("PWUNSPSC", "PWUNSPSC", JdeDataType.String, 16),
        new JdeField("PWCMDCDE", "PWCMDCDE", JdeDataType.String, 30),
        new JdeField("PWRSFX", "PWRSFX", JdeDataType.String, 6),
        new JdeField("PWVR03", "PWVR03", JdeDataType.String, 50),
        new JdeField("PWMACT", "PWMACT", JdeDataType.String, 2),
        new JdeField("PWBLKT", "PWBLKT", JdeDataType.String, 2),
        new JdeField("PWAFND", "PWAFND", JdeDataType.Numeric),
        new JdeField("PWWVID", "PWWVID", JdeDataType.Numeric),
        new JdeField("PWCNTRTID", "PWCNTRTID", JdeDataType.Numeric),
        new JdeField("PWCNTRTDID", "PWCNTRTDID", JdeDataType.Numeric),
        new JdeField("PWMOADJ", "PWMOADJ", JdeDataType.String, 2),
        new JdeField("PWWVTY", "PWWVTY", JdeDataType.String, 2),
        new JdeField("PWPODC01", "PWPODC01", JdeDataType.String, 6),
        new JdeField("PWPODC02", "PWPODC02", JdeDataType.String, 6),
        new JdeField("PWPODC03", "PWPODC03", JdeDataType.String, 20),
        new JdeField("PWPODC04", "PWPODC04", JdeDataType.String, 20),
        new JdeField("PWJBCD", "PWJBCD", JdeDataType.String, 12),
        new JdeField("PWSRQTY", "PWSRQTY", JdeDataType.Numeric),
        new JdeField("PWSRUOM", "PWSRUOM", JdeDataType.String, 4),
        new JdeField("PWCFGFL", "PWCFGFL", JdeDataType.String, 2),
        new JdeField("PWPMPN", "PWPMPN", JdeDataType.String, 60),
        new JdeField("PWPNS", "PWPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4311Z_0", "Primary Key on PWCTID, PWPEID, PWTCID, PWJOBS, PWSFXO, PWLNID", new[] { "PWCTID", "PWPEID", "PWTCID", "PWJOBS", "PWSFXO", "PWLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4311Z_2", "Index on PWMCU, PWITM, PWOORN, PWOCTO, PWOKCO, PWOGNO", new[] { "PWMCU", "PWITM", "PWOORN", "PWOCTO", "PWOKCO", "PWOGNO" }),
        new JdeIndex("F4311Z_3", "Index on PWOORN, PWOCTO, PWOKCO, PWOGNO, PWSFX", new[] { "PWOORN", "PWOCTO", "PWOKCO", "PWOGNO", "PWSFX" }),
        new JdeIndex("F4311Z_4", "Index on PWCTID, PWPEID, PWTCID, PWJOBS, PWSFXO, PWACTN, PWLNID", new[] { "PWCTID", "PWPEID", "PWTCID", "PWJOBS", "PWSFXO", "PWACTN", "PWLNID" }),
        new JdeIndex("F4311Z_5", "Index on PWCTID, PWPEID, PWTCID, PWJOBS, PWSFXO, PWMCLN", new[] { "PWCTID", "PWPEID", "PWTCID", "PWJOBS", "PWSFXO", "PWMCLN" })
    };
}
