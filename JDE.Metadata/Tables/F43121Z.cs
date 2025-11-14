using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43121Z - .
/// </summary>
public class F43121Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWDOC.
        /// </summary>
        public const string PWDOC = "PWDOC";

        /// <summary>
        /// PWDOCO.
        /// </summary>
        public const string PWDOCO = "PWDOCO";

        /// <summary>
        /// PWDCTO.
        /// </summary>
        public const string PWDCTO = "PWDCTO";

        /// <summary>
        /// PWKCOO.
        /// </summary>
        public const string PWKCOO = "PWKCOO";

        /// <summary>
        /// PWSFXO.
        /// </summary>
        public const string PWSFXO = "PWSFXO";

        /// <summary>
        /// PWLNID.
        /// </summary>
        public const string PWLNID = "PWLNID";

        /// <summary>
        /// PWNLIN.
        /// </summary>
        public const string PWNLIN = "PWNLIN";

        /// <summary>
        /// PWJOBS.
        /// </summary>
        public const string PWJOBS = "PWJOBS";

        /// <summary>
        /// PWCTID.
        /// </summary>
        public const string PWCTID = "PWCTID";

        /// <summary>
        /// PWSELC.
        /// </summary>
        public const string PWSELC = "PWSELC";

        /// <summary>
        /// PWKCO.
        /// </summary>
        public const string PWKCO = "PWKCO";

        /// <summary>
        /// PWJELN.
        /// </summary>
        public const string PWJELN = "PWJELN";

        /// <summary>
        /// PWJEL1.
        /// </summary>
        public const string PWJEL1 = "PWJEL1";

        /// <summary>
        /// PWJEL2.
        /// </summary>
        public const string PWJEL2 = "PWJEL2";

        /// <summary>
        /// PWJEL3.
        /// </summary>
        public const string PWJEL3 = "PWJEL3";

        /// <summary>
        /// PWJEL4.
        /// </summary>
        public const string PWJEL4 = "PWJEL4";

        /// <summary>
        /// PWJEL5.
        /// </summary>
        public const string PWJEL5 = "PWJEL5";

        /// <summary>
        /// PWJEL6.
        /// </summary>
        public const string PWJEL6 = "PWJEL6";

        /// <summary>
        /// PWJEL7.
        /// </summary>
        public const string PWJEL7 = "PWJEL7";

        /// <summary>
        /// PWJEL8.
        /// </summary>
        public const string PWJEL8 = "PWJEL8";

        /// <summary>
        /// PWJEL9.
        /// </summary>
        public const string PWJEL9 = "PWJEL9";

        /// <summary>
        /// PWMCU.
        /// </summary>
        public const string PWMCU = "PWMCU";

        /// <summary>
        /// PWLOCN.
        /// </summary>
        public const string PWLOCN = "PWLOCN";

        /// <summary>
        /// PWLOTN.
        /// </summary>
        public const string PWLOTN = "PWLOTN";

        /// <summary>
        /// PWLOTG.
        /// </summary>
        public const string PWLOTG = "PWLOTG";

        /// <summary>
        /// PWLOTP.
        /// </summary>
        public const string PWLOTP = "PWLOTP";

        /// <summary>
        /// PWLOTS.
        /// </summary>
        public const string PWLOTS = "PWLOTS";

        /// <summary>
        /// PWIVI.
        /// </summary>
        public const string PWIVI = "PWIVI";

        /// <summary>
        /// PWSTKT.
        /// </summary>
        public const string PWSTKT = "PWSTKT";

        /// <summary>
        /// PWLEDG.
        /// </summary>
        public const string PWLEDG = "PWLEDG";

        /// <summary>
        /// PWCLEV.
        /// </summary>
        public const string PWCLEV = "PWCLEV";

        /// <summary>
        /// PWGLC.
        /// </summary>
        public const string PWGLC = "PWGLC";

        /// <summary>
        /// PWRCDJ.
        /// </summary>
        public const string PWRCDJ = "PWRCDJ";

        /// <summary>
        /// PWDGL.
        /// </summary>
        public const string PWDGL = "PWDGL";

        /// <summary>
        /// PWRCD.
        /// </summary>
        public const string PWRCD = "PWRCD";

        /// <summary>
        /// PWSRNR.
        /// </summary>
        public const string PWSRNR = "PWSRNR";

        /// <summary>
        /// PWVEND.
        /// </summary>
        public const string PWVEND = "PWVEND";

        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWVRMK.
        /// </summary>
        public const string PWVRMK = "PWVRMK";

        /// <summary>
        /// PWVANI.
        /// </summary>
        public const string PWVANI = "PWVANI";

        /// <summary>
        /// PWPRP5.
        /// </summary>
        public const string PWPRP5 = "PWPRP5";

        /// <summary>
        /// PWASID.
        /// </summary>
        public const string PWASID = "PWASID";

        /// <summary>
        /// PWCNID.
        /// </summary>
        public const string PWCNID = "PWCNID";

        /// <summary>
        /// PWSBL.
        /// </summary>
        public const string PWSBL = "PWSBL";

        /// <summary>
        /// PWSBLT.
        /// </summary>
        public const string PWSBLT = "PWSBLT";

        /// <summary>
        /// PWULOT.
        /// </summary>
        public const string PWULOT = "PWULOT";

        /// <summary>
        /// PWAVGC.
        /// </summary>
        public const string PWAVGC = "PWAVGC";

        /// <summary>
        /// PWSOQS.
        /// </summary>
        public const string PWSOQS = "PWSOQS";

        /// <summary>
        /// PWUOM2.
        /// </summary>
        public const string PWUOM2 = "PWUOM2";

        /// <summary>
        /// PWUOM3.
        /// </summary>
        public const string PWUOM3 = "PWUOM3";

        /// <summary>
        /// PWSOCN.
        /// </summary>
        public const string PWSOCN = "PWSOCN";

        /// <summary>
        /// PWUOM1.
        /// </summary>
        public const string PWUOM1 = "PWUOM1";

        /// <summary>
        /// PWCNV1.
        /// </summary>
        public const string PWCNV1 = "PWCNV1";

        /// <summary>
        /// PWOPST.
        /// </summary>
        public const string PWOPST = "PWOPST";

        /// <summary>
        /// PWRTG.
        /// </summary>
        public const string PWRTG = "PWRTG";

        /// <summary>
        /// PWUPIB.
        /// </summary>
        public const string PWUPIB = "PWUPIB";

        /// <summary>
        /// PWRCPT.
        /// </summary>
        public const string PWRCPT = "PWRCPT";

        /// <summary>
        /// PWPMTE.
        /// </summary>
        public const string PWPMTE = "PWPMTE";

        /// <summary>
        /// PWCONV.
        /// </summary>
        public const string PWCONV = "PWCONV";

        /// <summary>
        /// PWCRR.
        /// </summary>
        public const string PWCRR = "PWCRR";

        /// <summary>
        /// PWUOM.
        /// </summary>
        public const string PWUOM = "PWUOM";

        /// <summary>
        /// PWUREC.
        /// </summary>
        public const string PWUREC = "PWUREC";

        /// <summary>
        /// PWPRRC.
        /// </summary>
        public const string PWPRRC = "PWPRRC";

        /// <summary>
        /// PWAREC.
        /// </summary>
        public const string PWAREC = "PWAREC";

        /// <summary>
        /// PWAOPN.
        /// </summary>
        public const string PWAOPN = "PWAOPN";

        /// <summary>
        /// PWECST.
        /// </summary>
        public const string PWECST = "PWECST";

        /// <summary>
        /// PWCRYR.
        /// </summary>
        public const string PWCRYR = "PWCRYR";

        /// <summary>
        /// PWFRRC.
        /// </summary>
        public const string PWFRRC = "PWFRRC";

        /// <summary>
        /// PWFEC.
        /// </summary>
        public const string PWFEC = "PWFEC";

        /// <summary>
        /// PWFREC.
        /// </summary>
        public const string PWFREC = "PWFREC";

        /// <summary>
        /// PWITM.
        /// </summary>
        public const string PWITM = "PWITM";

        /// <summary>
        /// PWRPL.
        /// </summary>
        public const string PWRPL = "PWRPL";

        /// <summary>
        /// PWNROU.
        /// </summary>
        public const string PWNROU = "PWNROU";

        /// <summary>
        /// PWCRCD.
        /// </summary>
        public const string PWCRCD = "PWCRCD";

        /// <summary>
        /// PWCO.
        /// </summary>
        public const string PWCO = "PWCO";

        /// <summary>
        /// PWPTC.
        /// </summary>
        public const string PWPTC = "PWPTC";

        /// <summary>
        /// PWDRQJ.
        /// </summary>
        public const string PWDRQJ = "PWDRQJ";

        /// <summary>
        /// PWPDDJ.
        /// </summary>
        public const string PWPDDJ = "PWPDDJ";

        /// <summary>
        /// PWOPDJ.
        /// </summary>
        public const string PWOPDJ = "PWOPDJ";

        /// <summary>
        /// PWLNTY.
        /// </summary>
        public const string PWLNTY = "PWLNTY";

        /// <summary>
        /// PWAITM.
        /// </summary>
        public const string PWAITM = "PWAITM";

        /// <summary>
        /// PWLITM.
        /// </summary>
        public const string PWLITM = "PWLITM";

        /// <summary>
        /// PWCNV2.
        /// </summary>
        public const string PWCNV2 = "PWCNV2";

        /// <summary>
        /// PWLIN.
        /// </summary>
        public const string PWLIN = "PWLIN";

        /// <summary>
        /// PWNXTR.
        /// </summary>
        public const string PWNXTR = "PWNXTR";

        /// <summary>
        /// PWWRTH.
        /// </summary>
        public const string PWWRTH = "PWWRTH";

        /// <summary>
        /// PWNXT2.
        /// </summary>
        public const string PWNXT2 = "PWNXT2";

        /// <summary>
        /// PWSOPO.
        /// </summary>
        public const string PWSOPO = "PWSOPO";

        /// <summary>
        /// PWDSC1.
        /// </summary>
        public const string PWDSC1 = "PWDSC1";

        /// <summary>
        /// PWLAND.
        /// </summary>
        public const string PWLAND = "PWLAND";

        /// <summary>
        /// PWALIN.
        /// </summary>
        public const string PWALIN = "PWALIN";

        /// <summary>
        /// PWCRDC.
        /// </summary>
        public const string PWCRDC = "PWCRDC";

        /// <summary>
        /// PWDSCV.
        /// </summary>
        public const string PWDSCV = "PWDSCV";

        /// <summary>
        /// PWDMBV.
        /// </summary>
        public const string PWDMBV = "PWDMBV";

        /// <summary>
        /// PWDZBA.
        /// </summary>
        public const string PWDZBA = "PWDZBA";

        /// <summary>
        /// PWCZBA.
        /// </summary>
        public const string PWCZBA = "PWCZBA";

        /// <summary>
        /// PWRCNV.
        /// </summary>
        public const string PWRCNV = "PWRCNV";

        /// <summary>
        /// PWDTAC.
        /// </summary>
        public const string PWDTAC = "PWDTAC";

        /// <summary>
        /// PWCTAC.
        /// </summary>
        public const string PWCTAC = "PWCTAC";

        /// <summary>
        /// PWTRR1.
        /// </summary>
        public const string PWTRR1 = "PWTRR1";

        /// <summary>
        /// PWTRR2.
        /// </summary>
        public const string PWTRR2 = "PWTRR2";

        /// <summary>
        /// PWCRCM.
        /// </summary>
        public const string PWCRCM = "PWCRCM";

        /// <summary>
        /// PWDMCT.
        /// </summary>
        public const string PWDMCT = "PWDMCT";

        /// <summary>
        /// PWDMCS.
        /// </summary>
        public const string PWDMCS = "PWDMCS";

        /// <summary>
        /// PWMODE.
        /// </summary>
        public const string PWMODE = "PWMODE";

        /// <summary>
        /// PWPSR.
        /// </summary>
        public const string PWPSR = "PWPSR";

        /// <summary>
        /// PWPSRY.
        /// </summary>
        public const string PWPSRY = "PWPSRY";

        /// <summary>
        /// PWSEQ.
        /// </summary>
        public const string PWSEQ = "PWSEQ";

        /// <summary>
        /// PWTREX.
        /// </summary>
        public const string PWTREX = "PWTREX";

        /// <summary>
        /// PWTEMP.
        /// </summary>
        public const string PWTEMP = "PWTEMP";

        /// <summary>
        /// PWSTPU.
        /// </summary>
        public const string PWSTPU = "PWSTPU";

        /// <summary>
        /// PWDNTY.
        /// </summary>
        public const string PWDNTY = "PWDNTY";

        /// <summary>
        /// PWDNTP.
        /// </summary>
        public const string PWDNTP = "PWDNTP";

        /// <summary>
        /// PWDETP.
        /// </summary>
        public const string PWDETP = "PWDETP";

        /// <summary>
        /// PWDTPU.
        /// </summary>
        public const string PWDTPU = "PWDTPU";

        /// <summary>
        /// PWAMBR.
        /// </summary>
        public const string PWAMBR = "PWAMBR";

        /// <summary>
        /// PWBUM3.
        /// </summary>
        public const string PWBUM3 = "PWBUM3";

        /// <summary>
        /// PWVCF.
        /// </summary>
        public const string PWVCF = "PWVCF";

        /// <summary>
        /// PWSTOK.
        /// </summary>
        public const string PWSTOK = "PWSTOK";

        /// <summary>
        /// PWBUM4.
        /// </summary>
        public const string PWBUM4 = "PWBUM4";

        /// <summary>
        /// PWWGTR.
        /// </summary>
        public const string PWWGTR = "PWWGTR";

        /// <summary>
        /// PWBUM5.
        /// </summary>
        public const string PWBUM5 = "PWBUM5";

        /// <summary>
        /// PWSTUM.
        /// </summary>
        public const string PWSTUM = "PWSTUM";

        /// <summary>
        /// PWBUM6.
        /// </summary>
        public const string PWBUM6 = "PWBUM6";

        /// <summary>
        /// PWBPFG.
        /// </summary>
        public const string PWBPFG = "PWBPFG";

        /// <summary>
        /// PWABR1.
        /// </summary>
        public const string PWABR1 = "PWABR1";

        /// <summary>
        /// PWABT1.
        /// </summary>
        public const string PWABT1 = "PWABT1";

        /// <summary>
        /// PWABR2.
        /// </summary>
        public const string PWABR2 = "PWABR2";

        /// <summary>
        /// PWABT2.
        /// </summary>
        public const string PWABT2 = "PWABT2";

        /// <summary>
        /// PWABR3.
        /// </summary>
        public const string PWABR3 = "PWABR3";

        /// <summary>
        /// PWABT3.
        /// </summary>
        public const string PWABT3 = "PWABT3";

        /// <summary>
        /// PWABR4.
        /// </summary>
        public const string PWABR4 = "PWABR4";

        /// <summary>
        /// PWABT4.
        /// </summary>
        public const string PWABT4 = "PWABT4";

        /// <summary>
        /// PWPSQ.
        /// </summary>
        public const string PWPSQ = "PWPSQ";

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
        /// PWVR05.
        /// </summary>
        public const string PWVR05 = "PWVR05";

        /// <summary>
        /// PWVR04.
        /// </summary>
        public const string PWVR04 = "PWVR04";

        /// <summary>
        /// PWVR02.
        /// </summary>
        public const string PWVR02 = "PWVR02";

        /// <summary>
        /// PWVR01.
        /// </summary>
        public const string PWVR01 = "PWVR01";

        /// <summary>
        /// PWUPUM.
        /// </summary>
        public const string PWUPUM = "PWUPUM";

        /// <summary>
        /// PWUPQT.
        /// </summary>
        public const string PWUPQT = "PWUPQT";

        /// <summary>
        /// PWUPCN.
        /// </summary>
        public const string PWUPCN = "PWUPCN";

        /// <summary>
        /// PWUKID.
        /// </summary>
        public const string PWUKID = "PWUKID";

        /// <summary>
        /// PWSTAM.
        /// </summary>
        public const string PWSTAM = "PWSTAM";

        /// <summary>
        /// PWSQOR.
        /// </summary>
        public const string PWSQOR = "PWSQOR";

        /// <summary>
        /// PWSCUM.
        /// </summary>
        public const string PWSCUM = "PWSCUM";

        /// <summary>
        /// PWSCCQ.
        /// </summary>
        public const string PWSCCQ = "PWSCCQ";

        /// <summary>
        /// PWSCCN.
        /// </summary>
        public const string PWSCCN = "PWSCCN";

        /// <summary>
        /// PWPLT.
        /// </summary>
        public const string PWPLT = "PWPLT";

        /// <summary>
        /// PWPAK.
        /// </summary>
        public const string PWPAK = "PWPAK";

        /// <summary>
        /// PWMERL.
        /// </summary>
        public const string PWMERL = "PWMERL";

        /// <summary>
        /// PWMACT.
        /// </summary>
        public const string PWMACT = "PWMACT";

        /// <summary>
        /// PWKTLN.
        /// </summary>
        public const string PWKTLN = "PWKTLN";

        /// <summary>
        /// PWFUF6.
        /// </summary>
        public const string PWFUF6 = "PWFUF6";

        /// <summary>
        /// PWFUF5.
        /// </summary>
        public const string PWFUF5 = "PWFUF5";

        /// <summary>
        /// PWFUF4.
        /// </summary>
        public const string PWFUF4 = "PWFUF4";

        /// <summary>
        /// PWFUF3.
        /// </summary>
        public const string PWFUF3 = "PWFUF3";

        /// <summary>
        /// PWDUAL.
        /// </summary>
        public const string PWDUAL = "PWDUAL";

        /// <summary>
        /// PWCTAM.
        /// </summary>
        public const string PWCTAM = "PWCTAM";

        /// <summary>
        /// PWXDCK.
        /// </summary>
        public const string PWXDCK = "PWXDCK";

        /// <summary>
        /// PWCPNT.
        /// </summary>
        public const string PWCPNT = "PWCPNT";

        /// <summary>
        /// PWBCRC.
        /// </summary>
        public const string PWBCRC = "PWBCRC";

        /// <summary>
        /// PWUOMV.
        /// </summary>
        public const string PWUOMV = "PWUOMV";

        /// <summary>
        /// PWLOTC.
        /// </summary>
        public const string PWLOTC = "PWLOTC";

        /// <summary>
        /// PWJEL0.
        /// </summary>
        public const string PWJEL0 = "PWJEL0";

        /// <summary>
        /// PWJELNNMBR.
        /// </summary>
        public const string PWJELNNMBR = "PWJELNNMBR";

        /// <summary>
        /// PWPOE.
        /// </summary>
        public const string PWPOE = "PWPOE";

        /// <summary>
        /// PWJELA.
        /// </summary>
        public const string PWJELA = "PWJELA";

        /// <summary>
        /// PWJELB.
        /// </summary>
        public const string PWJELB = "PWJELB";

        /// <summary>
        /// PWJELC.
        /// </summary>
        public const string PWJELC = "PWJELC";

        /// <summary>
        /// PWJELD.
        /// </summary>
        public const string PWJELD = "PWJELD";

        /// <summary>
        /// PWRTGO.
        /// </summary>
        public const string PWRTGO = "PWRTGO";

        /// <summary>
        /// PWPTRF.
        /// </summary>
        public const string PWPTRF = "PWPTRF";

        /// <summary>
        /// PWPMT2.
        /// </summary>
        public const string PWPMT2 = "PWPMT2";

        /// <summary>
        /// PWCTSN.
        /// </summary>
        public const string PWCTSN = "PWCTSN";

        /// <summary>
        /// PWPROV.
        /// </summary>
        public const string PWPROV = "PWPROV";

        /// <summary>
        /// PWASN.
        /// </summary>
        public const string PWASN = "PWASN";

        /// <summary>
        /// PWPRFLG1.
        /// </summary>
        public const string PWPRFLG1 = "PWPRFLG1";

        /// <summary>
        /// PWPRFLG2.
        /// </summary>
        public const string PWPRFLG2 = "PWPRFLG2";

        /// <summary>
        /// PWMOADJ.
        /// </summary>
        public const string PWMOADJ = "PWMOADJ";

        /// <summary>
        /// PWPS09.
        /// </summary>
        public const string PWPS09 = "PWPS09";

        /// <summary>
        /// PWQTYPY.
        /// </summary>
        public const string PWQTYPY = "PWQTYPY";

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
        /// PWREVFLG.
        /// </summary>
        public const string PWREVFLG = "PWREVFLG";

        /// <summary>
        /// PWAPPFLG.
        /// </summary>
        public const string PWAPPFLG = "PWAPPFLG";

        /// <summary>
        /// PWREVAN8.
        /// </summary>
        public const string PWREVAN8 = "PWREVAN8";

        /// <summary>
        /// PWAPPAN8.
        /// </summary>
        public const string PWAPPAN8 = "PWAPPAN8";

        /// <summary>
        /// PWWOPID.
        /// </summary>
        public const string PWWOPID = "PWWOPID";

        /// <summary>
        /// PWWVTY.
        /// </summary>
        public const string PWWVTY = "PWWVTY";

        /// <summary>
        /// PWAREV.
        /// </summary>
        public const string PWAREV = "PWAREV";

        /// <summary>
        /// PWSRRC.
        /// </summary>
        public const string PWSRRC = "PWSRRC";

        /// <summary>
        /// PWFSRRC.
        /// </summary>
        public const string PWFSRRC = "PWFSRRC";

        /// <summary>
        /// PWEV01.
        /// </summary>
        public const string PWEV01 = "PWEV01";

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
        /// PWNBRU.
        /// </summary>
        public const string PWNBRU = "PWNBRU";

        /// <summary>
        /// PWNEWR.
        /// </summary>
        public const string PWNEWR = "PWNEWR";

        /// <summary>
        /// PWCFGFL.
        /// </summary>
        public const string PWCFGFL = "PWCFGFL";

        /// <summary>
        /// PWCFRON.
        /// </summary>
        public const string PWCFRON = "PWCFRON";

        /// <summary>
        /// PWCFROT.
        /// </summary>
        public const string PWCFROT = "PWCFROT";

        /// <summary>
        /// PWCFRCO.
        /// </summary>
        public const string PWCFRCO = "PWCFRCO";

        /// <summary>
        /// PWCFSFX.
        /// </summary>
        public const string PWCFSFX = "PWCFSFX";

        /// <summary>
        /// PWCFLID.
        /// </summary>
        public const string PWCFLID = "PWCFLID";

        /// <summary>
        /// PWCFOUF.
        /// </summary>
        public const string PWCFOUF = "PWCFOUF";

        /// <summary>
        /// PWCFSWF.
        /// </summary>
        public const string PWCFSWF = "PWCFSWF";

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
    public override string TableName => "F43121Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWDOC", "PWDOC", JdeDataType.Numeric),
        new JdeField("PWDOCO", "PWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PWDCTO", "PWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PWKCOO", "PWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PWSFXO", "PWSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PWLNID", "PWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWNLIN", "PWNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PWJOBS", "PWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PWCTID", "PWCTID", JdeDataType.String, 30, true, true),
        new JdeField("PWSELC", "PWSELC", JdeDataType.String, 2),
        new JdeField("PWKCO", "PWKCO", JdeDataType.String, 10),
        new JdeField("PWJELN", "PWJELN", JdeDataType.Numeric),
        new JdeField("PWJEL1", "PWJEL1", JdeDataType.Numeric),
        new JdeField("PWJEL2", "PWJEL2", JdeDataType.Numeric),
        new JdeField("PWJEL3", "PWJEL3", JdeDataType.Numeric),
        new JdeField("PWJEL4", "PWJEL4", JdeDataType.Numeric),
        new JdeField("PWJEL5", "PWJEL5", JdeDataType.Numeric),
        new JdeField("PWJEL6", "PWJEL6", JdeDataType.Numeric),
        new JdeField("PWJEL7", "PWJEL7", JdeDataType.Numeric),
        new JdeField("PWJEL8", "PWJEL8", JdeDataType.Numeric),
        new JdeField("PWJEL9", "PWJEL9", JdeDataType.Numeric),
        new JdeField("PWMCU", "PWMCU", JdeDataType.String, 24),
        new JdeField("PWLOCN", "PWLOCN", JdeDataType.String, 40),
        new JdeField("PWLOTN", "PWLOTN", JdeDataType.String, 60),
        new JdeField("PWLOTG", "PWLOTG", JdeDataType.String, 6),
        new JdeField("PWLOTP", "PWLOTP", JdeDataType.Numeric),
        new JdeField("PWLOTS", "PWLOTS", JdeDataType.String, 2),
        new JdeField("PWIVI", "PWIVI", JdeDataType.String, 2),
        new JdeField("PWSTKT", "PWSTKT", JdeDataType.String, 2),
        new JdeField("PWLEDG", "PWLEDG", JdeDataType.String, 4),
        new JdeField("PWCLEV", "PWCLEV", JdeDataType.String, 2),
        new JdeField("PWGLC", "PWGLC", JdeDataType.String, 8),
        new JdeField("PWRCDJ", "PWRCDJ", JdeDataType.Numeric),
        new JdeField("PWDGL", "PWDGL", JdeDataType.Numeric),
        new JdeField("PWRCD", "PWRCD", JdeDataType.String, 6),
        new JdeField("PWSRNR", "PWSRNR", JdeDataType.String, 2),
        new JdeField("PWVEND", "PWVEND", JdeDataType.Numeric),
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric),
        new JdeField("PWVRMK", "PWVRMK", JdeDataType.String, 60),
        new JdeField("PWVANI", "PWVANI", JdeDataType.String, 58),
        new JdeField("PWPRP5", "PWPRP5", JdeDataType.String, 6),
        new JdeField("PWASID", "PWASID", JdeDataType.String, 50),
        new JdeField("PWCNID", "PWCNID", JdeDataType.String, 40),
        new JdeField("PWSBL", "PWSBL", JdeDataType.String, 16),
        new JdeField("PWSBLT", "PWSBLT", JdeDataType.String, 2),
        new JdeField("PWULOT", "PWULOT", JdeDataType.String, 2),
        new JdeField("PWAVGC", "PWAVGC", JdeDataType.String, 2),
        new JdeField("PWSOQS", "PWSOQS", JdeDataType.Numeric),
        new JdeField("PWUOM2", "PWUOM2", JdeDataType.String, 4),
        new JdeField("PWUOM3", "PWUOM3", JdeDataType.String, 4),
        new JdeField("PWSOCN", "PWSOCN", JdeDataType.Numeric),
        new JdeField("PWUOM1", "PWUOM1", JdeDataType.String, 4),
        new JdeField("PWCNV1", "PWCNV1", JdeDataType.Numeric),
        new JdeField("PWOPST", "PWOPST", JdeDataType.String, 4),
        new JdeField("PWRTG", "PWRTG", JdeDataType.String, 2),
        new JdeField("PWUPIB", "PWUPIB", JdeDataType.String, 8),
        new JdeField("PWRCPT", "PWRCPT", JdeDataType.String, 2),
        new JdeField("PWPMTE", "PWPMTE", JdeDataType.String, 2),
        new JdeField("PWCONV", "PWCONV", JdeDataType.Numeric),
        new JdeField("PWCRR", "PWCRR", JdeDataType.Numeric),
        new JdeField("PWUOM", "PWUOM", JdeDataType.String, 4),
        new JdeField("PWUREC", "PWUREC", JdeDataType.Numeric),
        new JdeField("PWPRRC", "PWPRRC", JdeDataType.Numeric),
        new JdeField("PWAREC", "PWAREC", JdeDataType.Numeric),
        new JdeField("PWAOPN", "PWAOPN", JdeDataType.Numeric),
        new JdeField("PWECST", "PWECST", JdeDataType.Numeric),
        new JdeField("PWCRYR", "PWCRYR", JdeDataType.String, 2),
        new JdeField("PWFRRC", "PWFRRC", JdeDataType.Numeric),
        new JdeField("PWFEC", "PWFEC", JdeDataType.Numeric),
        new JdeField("PWFREC", "PWFREC", JdeDataType.Numeric),
        new JdeField("PWITM", "PWITM", JdeDataType.Numeric),
        new JdeField("PWRPL", "PWRPL", JdeDataType.String, 2),
        new JdeField("PWNROU", "PWNROU", JdeDataType.String, 8),
        new JdeField("PWCRCD", "PWCRCD", JdeDataType.String, 6),
        new JdeField("PWCO", "PWCO", JdeDataType.String, 10),
        new JdeField("PWPTC", "PWPTC", JdeDataType.String, 6),
        new JdeField("PWDRQJ", "PWDRQJ", JdeDataType.Numeric),
        new JdeField("PWPDDJ", "PWPDDJ", JdeDataType.Numeric),
        new JdeField("PWOPDJ", "PWOPDJ", JdeDataType.Numeric),
        new JdeField("PWLNTY", "PWLNTY", JdeDataType.String, 4),
        new JdeField("PWAITM", "PWAITM", JdeDataType.String, 50),
        new JdeField("PWLITM", "PWLITM", JdeDataType.String, 50),
        new JdeField("PWCNV2", "PWCNV2", JdeDataType.Numeric),
        new JdeField("PWLIN", "PWLIN", JdeDataType.Numeric),
        new JdeField("PWNXTR", "PWNXTR", JdeDataType.String, 6),
        new JdeField("PWWRTH", "PWWRTH", JdeDataType.String, 2),
        new JdeField("PWNXT2", "PWNXT2", JdeDataType.String, 6),
        new JdeField("PWSOPO", "PWSOPO", JdeDataType.String, 2),
        new JdeField("PWDSC1", "PWDSC1", JdeDataType.String, 60),
        new JdeField("PWLAND", "PWLAND", JdeDataType.String, 2),
        new JdeField("PWALIN", "PWALIN", JdeDataType.Numeric),
        new JdeField("PWCRDC", "PWCRDC", JdeDataType.String, 6),
        new JdeField("PWDSCV", "PWDSCV", JdeDataType.String, 2),
        new JdeField("PWDMBV", "PWDMBV", JdeDataType.String, 2),
        new JdeField("PWDZBA", "PWDZBA", JdeDataType.String, 2),
        new JdeField("PWCZBA", "PWCZBA", JdeDataType.String, 2),
        new JdeField("PWRCNV", "PWRCNV", JdeDataType.String, 2),
        new JdeField("PWDTAC", "PWDTAC", JdeDataType.String, 2),
        new JdeField("PWCTAC", "PWCTAC", JdeDataType.String, 2),
        new JdeField("PWTRR1", "PWTRR1", JdeDataType.Numeric),
        new JdeField("PWTRR2", "PWTRR2", JdeDataType.Numeric),
        new JdeField("PWCRCM", "PWCRCM", JdeDataType.String, 2),
        new JdeField("PWDMCT", "PWDMCT", JdeDataType.String, 24),
        new JdeField("PWDMCS", "PWDMCS", JdeDataType.Numeric),
        new JdeField("PWMODE", "PWMODE", JdeDataType.String, 2),
        new JdeField("PWPSR", "PWPSR", JdeDataType.String, 24),
        new JdeField("PWPSRY", "PWPSRY", JdeDataType.String, 4),
        new JdeField("PWSEQ", "PWSEQ", JdeDataType.Numeric),
        new JdeField("PWTREX", "PWTREX", JdeDataType.String, 60),
        new JdeField("PWTEMP", "PWTEMP", JdeDataType.Numeric),
        new JdeField("PWSTPU", "PWSTPU", JdeDataType.String, 2),
        new JdeField("PWDNTY", "PWDNTY", JdeDataType.Numeric),
        new JdeField("PWDNTP", "PWDNTP", JdeDataType.String, 2),
        new JdeField("PWDETP", "PWDETP", JdeDataType.Numeric),
        new JdeField("PWDTPU", "PWDTPU", JdeDataType.String, 2),
        new JdeField("PWAMBR", "PWAMBR", JdeDataType.Numeric),
        new JdeField("PWBUM3", "PWBUM3", JdeDataType.String, 4),
        new JdeField("PWVCF", "PWVCF", JdeDataType.Numeric),
        new JdeField("PWSTOK", "PWSTOK", JdeDataType.Numeric),
        new JdeField("PWBUM4", "PWBUM4", JdeDataType.String, 4),
        new JdeField("PWWGTR", "PWWGTR", JdeDataType.Numeric),
        new JdeField("PWBUM5", "PWBUM5", JdeDataType.String, 4),
        new JdeField("PWSTUM", "PWSTUM", JdeDataType.Numeric),
        new JdeField("PWBUM6", "PWBUM6", JdeDataType.String, 4),
        new JdeField("PWBPFG", "PWBPFG", JdeDataType.String, 2),
        new JdeField("PWABR1", "PWABR1", JdeDataType.String, 24),
        new JdeField("PWABT1", "PWABT1", JdeDataType.String, 2),
        new JdeField("PWABR2", "PWABR2", JdeDataType.String, 24),
        new JdeField("PWABT2", "PWABT2", JdeDataType.String, 2),
        new JdeField("PWABR3", "PWABR3", JdeDataType.String, 24),
        new JdeField("PWABT3", "PWABT3", JdeDataType.String, 2),
        new JdeField("PWABR4", "PWABR4", JdeDataType.String, 24),
        new JdeField("PWABT4", "PWABT4", JdeDataType.String, 2),
        new JdeField("PWPSQ", "PWPSQ", JdeDataType.Numeric),
        new JdeField("PWSHPN", "PWSHPN", JdeDataType.Numeric),
        new JdeField("PWPEID", "PWPEID", JdeDataType.Numeric),
        new JdeField("PWTCID", "PWTCID", JdeDataType.Numeric),
        new JdeField("PWVR05", "PWVR05", JdeDataType.String, 50),
        new JdeField("PWVR04", "PWVR04", JdeDataType.String, 50),
        new JdeField("PWVR02", "PWVR02", JdeDataType.String, 50),
        new JdeField("PWVR01", "PWVR01", JdeDataType.String, 50),
        new JdeField("PWUPUM", "PWUPUM", JdeDataType.String, 4),
        new JdeField("PWUPQT", "PWUPQT", JdeDataType.Numeric),
        new JdeField("PWUPCN", "PWUPCN", JdeDataType.String, 26),
        new JdeField("PWUKID", "PWUKID", JdeDataType.Numeric),
        new JdeField("PWSTAM", "PWSTAM", JdeDataType.Numeric),
        new JdeField("PWSQOR", "PWSQOR", JdeDataType.Numeric),
        new JdeField("PWSCUM", "PWSCUM", JdeDataType.String, 4),
        new JdeField("PWSCCQ", "PWSCCQ", JdeDataType.Numeric),
        new JdeField("PWSCCN", "PWSCCN", JdeDataType.String, 28),
        new JdeField("PWPLT", "PWPLT", JdeDataType.String, 36),
        new JdeField("PWPAK", "PWPAK", JdeDataType.String, 36),
        new JdeField("PWMERL", "PWMERL", JdeDataType.String, 6),
        new JdeField("PWMACT", "PWMACT", JdeDataType.String, 2),
        new JdeField("PWKTLN", "PWKTLN", JdeDataType.Numeric),
        new JdeField("PWFUF6", "PWFUF6", JdeDataType.String, 2),
        new JdeField("PWFUF5", "PWFUF5", JdeDataType.String, 2),
        new JdeField("PWFUF4", "PWFUF4", JdeDataType.String, 2),
        new JdeField("PWFUF3", "PWFUF3", JdeDataType.String, 2),
        new JdeField("PWDUAL", "PWDUAL", JdeDataType.String, 2),
        new JdeField("PWCTAM", "PWCTAM", JdeDataType.Numeric),
        new JdeField("PWXDCK", "PWXDCK", JdeDataType.String, 2),
        new JdeField("PWCPNT", "PWCPNT", JdeDataType.Numeric),
        new JdeField("PWBCRC", "PWBCRC", JdeDataType.String, 6),
        new JdeField("PWUOMV", "PWUOMV", JdeDataType.String, 4),
        new JdeField("PWLOTC", "PWLOTC", JdeDataType.String, 6),
        new JdeField("PWJEL0", "PWJEL0", JdeDataType.Numeric),
        new JdeField("PWJELNNMBR", "PWJELNNMBR", JdeDataType.Numeric),
        new JdeField("PWPOE", "PWPOE", JdeDataType.String, 12),
        new JdeField("PWJELA", "PWJELA", JdeDataType.Numeric),
        new JdeField("PWJELB", "PWJELB", JdeDataType.Numeric),
        new JdeField("PWJELC", "PWJELC", JdeDataType.Numeric),
        new JdeField("PWJELD", "PWJELD", JdeDataType.Numeric),
        new JdeField("PWRTGO", "PWRTGO", JdeDataType.String, 2),
        new JdeField("PWPTRF", "PWPTRF", JdeDataType.String, 2),
        new JdeField("PWPMT2", "PWPMT2", JdeDataType.String, 2),
        new JdeField("PWCTSN", "PWCTSN", JdeDataType.String, 80),
        new JdeField("PWPROV", "PWPROV", JdeDataType.String, 2),
        new JdeField("PWASN", "PWASN", JdeDataType.String, 16),
        new JdeField("PWPRFLG1", "PWPRFLG1", JdeDataType.String, 2),
        new JdeField("PWPRFLG2", "PWPRFLG2", JdeDataType.String, 2),
        new JdeField("PWMOADJ", "PWMOADJ", JdeDataType.String, 2),
        new JdeField("PWPS09", "PWPS09", JdeDataType.String, 2),
        new JdeField("PWQTYPY", "PWQTYPY", JdeDataType.Numeric),
        new JdeField("PWWVID", "PWWVID", JdeDataType.Numeric),
        new JdeField("PWCNTRTID", "PWCNTRTID", JdeDataType.Numeric),
        new JdeField("PWCNTRTDID", "PWCNTRTDID", JdeDataType.Numeric),
        new JdeField("PWREVFLG", "PWREVFLG", JdeDataType.String, 2),
        new JdeField("PWAPPFLG", "PWAPPFLG", JdeDataType.String, 2),
        new JdeField("PWREVAN8", "PWREVAN8", JdeDataType.Numeric),
        new JdeField("PWAPPAN8", "PWAPPAN8", JdeDataType.Numeric),
        new JdeField("PWWOPID", "PWWOPID", JdeDataType.Numeric),
        new JdeField("PWWVTY", "PWWVTY", JdeDataType.String, 2),
        new JdeField("PWAREV", "PWAREV", JdeDataType.Numeric),
        new JdeField("PWSRRC", "PWSRRC", JdeDataType.Numeric),
        new JdeField("PWFSRRC", "PWFSRRC", JdeDataType.Numeric),
        new JdeField("PWEV01", "PWEV01", JdeDataType.String, 2),
        new JdeField("PWJBCD", "PWJBCD", JdeDataType.String, 12),
        new JdeField("PWSRQTY", "PWSRQTY", JdeDataType.Numeric),
        new JdeField("PWSRUOM", "PWSRUOM", JdeDataType.String, 4),
        new JdeField("PWNBRU", "PWNBRU", JdeDataType.String, 2),
        new JdeField("PWNEWR", "PWNEWR", JdeDataType.String, 2),
        new JdeField("PWCFGFL", "PWCFGFL", JdeDataType.String, 2),
        new JdeField("PWCFRON", "PWCFRON", JdeDataType.Numeric),
        new JdeField("PWCFROT", "PWCFROT", JdeDataType.String, 4),
        new JdeField("PWCFRCO", "PWCFRCO", JdeDataType.String, 10),
        new JdeField("PWCFSFX", "PWCFSFX", JdeDataType.String, 6),
        new JdeField("PWCFLID", "PWCFLID", JdeDataType.Numeric),
        new JdeField("PWCFOUF", "PWCFOUF", JdeDataType.String, 2),
        new JdeField("PWCFSWF", "PWCFSWF", JdeDataType.String, 2),
        new JdeField("PWPMPN", "PWPMPN", JdeDataType.String, 60),
        new JdeField("PWPNS", "PWPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43121Z_0", "Primary Key on PWCTID, PWJOBS, PWDOCO, PWDCTO, PWKCOO, PWSFXO, PWLNID, PWNLIN", new[] { "PWCTID", "PWJOBS", "PWDOCO", "PWDCTO", "PWKCOO", "PWSFXO", "PWLNID", "PWNLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43121Z_2", "Index on PWCTID, PWJOBS, PWLNID, PWNLIN", new[] { "PWCTID", "PWJOBS", "PWLNID", "PWNLIN" }),
        new JdeIndex("F43121Z_4", "Index on PWDOCO, PWDCTO, PWKCOO, PWSFXO, PWLNID", new[] { "PWDOCO", "PWDCTO", "PWKCOO", "PWSFXO", "PWLNID" })
    };
}
