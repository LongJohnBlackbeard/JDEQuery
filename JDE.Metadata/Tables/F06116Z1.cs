using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06116Z1 - .
/// </summary>
public class F06116Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VLEDUS.
        /// </summary>
        public const string VLEDUS = "VLEDUS";

        /// <summary>
        /// VLEDTY.
        /// </summary>
        public const string VLEDTY = "VLEDTY";

        /// <summary>
        /// VLEDSQ.
        /// </summary>
        public const string VLEDSQ = "VLEDSQ";

        /// <summary>
        /// VLEDTN.
        /// </summary>
        public const string VLEDTN = "VLEDTN";

        /// <summary>
        /// VLEDCT.
        /// </summary>
        public const string VLEDCT = "VLEDCT";

        /// <summary>
        /// VLEDLN.
        /// </summary>
        public const string VLEDLN = "VLEDLN";

        /// <summary>
        /// VLEDTS.
        /// </summary>
        public const string VLEDTS = "VLEDTS";

        /// <summary>
        /// VLEDFT.
        /// </summary>
        public const string VLEDFT = "VLEDFT";

        /// <summary>
        /// VLEDDT.
        /// </summary>
        public const string VLEDDT = "VLEDDT";

        /// <summary>
        /// VLEDER.
        /// </summary>
        public const string VLEDER = "VLEDER";

        /// <summary>
        /// VLEDDL.
        /// </summary>
        public const string VLEDDL = "VLEDDL";

        /// <summary>
        /// VLEDSP.
        /// </summary>
        public const string VLEDSP = "VLEDSP";

        /// <summary>
        /// VLEDTC.
        /// </summary>
        public const string VLEDTC = "VLEDTC";

        /// <summary>
        /// VLEDTR.
        /// </summary>
        public const string VLEDTR = "VLEDTR";

        /// <summary>
        /// VLEDBT.
        /// </summary>
        public const string VLEDBT = "VLEDBT";

        /// <summary>
        /// VLEDGL.
        /// </summary>
        public const string VLEDGL = "VLEDGL";

        /// <summary>
        /// VLPANP.
        /// </summary>
        public const string VLPANP = "VLPANP";

        /// <summary>
        /// VLAN8.
        /// </summary>
        public const string VLAN8 = "VLAN8";

        /// <summary>
        /// VLPALF.
        /// </summary>
        public const string VLPALF = "VLPALF";

        /// <summary>
        /// VLPRTR.
        /// </summary>
        public const string VLPRTR = "VLPRTR";

        /// <summary>
        /// VLRCCD.
        /// </summary>
        public const string VLRCCD = "VLRCCD";

        /// <summary>
        /// VLCKCN.
        /// </summary>
        public const string VLCKCN = "VLCKCN";

        /// <summary>
        /// VLAM.
        /// </summary>
        public const string VLAM = "VLAM";

        /// <summary>
        /// VLCO.
        /// </summary>
        public const string VLCO = "VLCO";

        /// <summary>
        /// VLHMCO.
        /// </summary>
        public const string VLHMCO = "VLHMCO";

        /// <summary>
        /// VLHMCU.
        /// </summary>
        public const string VLHMCU = "VLHMCU";

        /// <summary>
        /// VLMCU.
        /// </summary>
        public const string VLMCU = "VLMCU";

        /// <summary>
        /// VLOBJ.
        /// </summary>
        public const string VLOBJ = "VLOBJ";

        /// <summary>
        /// VLSUB.
        /// </summary>
        public const string VLSUB = "VLSUB";

        /// <summary>
        /// VLRCO.
        /// </summary>
        public const string VLRCO = "VLRCO";

        /// <summary>
        /// VLGMCU.
        /// </summary>
        public const string VLGMCU = "VLGMCU";

        /// <summary>
        /// VLGOBJ.
        /// </summary>
        public const string VLGOBJ = "VLGOBJ";

        /// <summary>
        /// VLGSUB.
        /// </summary>
        public const string VLGSUB = "VLGSUB";

        /// <summary>
        /// VLSBL.
        /// </summary>
        public const string VLSBL = "VLSBL";

        /// <summary>
        /// VLSBLT.
        /// </summary>
        public const string VLSBLT = "VLSBLT";

        /// <summary>
        /// VLWR01.
        /// </summary>
        public const string VLWR01 = "VLWR01";

        /// <summary>
        /// VLMCUO.
        /// </summary>
        public const string VLMCUO = "VLMCUO";

        /// <summary>
        /// VLMAIL.
        /// </summary>
        public const string VLMAIL = "VLMAIL";

        /// <summary>
        /// VLPHRW.
        /// </summary>
        public const string VLPHRW = "VLPHRW";

        /// <summary>
        /// VLOPSQ.
        /// </summary>
        public const string VLOPSQ = "VLOPSQ";

        /// <summary>
        /// VLRILT.
        /// </summary>
        public const string VLRILT = "VLRILT";

        /// <summary>
        /// VLBDSN.
        /// </summary>
        public const string VLBDSN = "VLBDSN";

        /// <summary>
        /// VLPCUN.
        /// </summary>
        public const string VLPCUN = "VLPCUN";

        /// <summary>
        /// VLUM.
        /// </summary>
        public const string VLUM = "VLUM";

        /// <summary>
        /// VLPHRT.
        /// </summary>
        public const string VLPHRT = "VLPHRT";

        /// <summary>
        /// VLPPRT.
        /// </summary>
        public const string VLPPRT = "VLPPRT";

        /// <summary>
        /// VLBHRT.
        /// </summary>
        public const string VLBHRT = "VLBHRT";

        /// <summary>
        /// VLPBRT.
        /// </summary>
        public const string VLPBRT = "VLPBRT";

        /// <summary>
        /// VLBDRT.
        /// </summary>
        public const string VLBDRT = "VLBDRT";

        /// <summary>
        /// VLGPA.
        /// </summary>
        public const string VLGPA = "VLGPA";

        /// <summary>
        /// VLDPA.
        /// </summary>
        public const string VLDPA = "VLDPA";

        /// <summary>
        /// VLRCPY.
        /// </summary>
        public const string VLRCPY = "VLRCPY";

        /// <summary>
        /// VLSAMT.
        /// </summary>
        public const string VLSAMT = "VLSAMT";

        /// <summary>
        /// VLUN.
        /// </summary>
        public const string VLUN = "VLUN";

        /// <summary>
        /// VLJBCD.
        /// </summary>
        public const string VLJBCD = "VLJBCD";

        /// <summary>
        /// VLJBST.
        /// </summary>
        public const string VLJBST = "VLJBST";

        /// <summary>
        /// VLWST.
        /// </summary>
        public const string VLWST = "VLWST";

        /// <summary>
        /// VLWCNT.
        /// </summary>
        public const string VLWCNT = "VLWCNT";

        /// <summary>
        /// VLWCTY.
        /// </summary>
        public const string VLWCTY = "VLWCTY";

        /// <summary>
        /// VLWCMP.
        /// </summary>
        public const string VLWCMP = "VLWCMP";

        /// <summary>
        /// VLWET.
        /// </summary>
        public const string VLWET = "VLWET";

        /// <summary>
        /// VLGENA.
        /// </summary>
        public const string VLGENA = "VLGENA";

        /// <summary>
        /// VLWCAM.
        /// </summary>
        public const string VLWCAM = "VLWCAM";

        /// <summary>
        /// VLWCMB.
        /// </summary>
        public const string VLWCMB = "VLWCMB";

        /// <summary>
        /// VLGENB.
        /// </summary>
        public const string VLGENB = "VLGENB";

        /// <summary>
        /// VLWCMO.
        /// </summary>
        public const string VLWCMO = "VLWCMO";

        /// <summary>
        /// VLGENO.
        /// </summary>
        public const string VLGENO = "VLGENO";

        /// <summary>
        /// VLWCMX.
        /// </summary>
        public const string VLWCMX = "VLWCMX";

        /// <summary>
        /// VLGENX.
        /// </summary>
        public const string VLGENX = "VLGENX";

        /// <summary>
        /// VLHMO.
        /// </summary>
        public const string VLHMO = "VLHMO";

        /// <summary>
        /// VLPDBA.
        /// </summary>
        public const string VLPDBA = "VLPDBA";

        /// <summary>
        /// VLPB.
        /// </summary>
        public const string VLPB = "VLPB";

        /// <summary>
        /// VLDEDM.
        /// </summary>
        public const string VLDEDM = "VLDEDM";

        /// <summary>
        /// VLPAYM.
        /// </summary>
        public const string VLPAYM = "VLPAYM";

        /// <summary>
        /// VLSHFT.
        /// </summary>
        public const string VLSHFT = "VLSHFT";

        /// <summary>
        /// VLSHD.
        /// </summary>
        public const string VLSHD = "VLSHD";

        /// <summary>
        /// VLSALY.
        /// </summary>
        public const string VLSALY = "VLSALY";

        /// <summary>
        /// VLNMTH.
        /// </summary>
        public const string VLNMTH = "VLNMTH";

        /// <summary>
        /// VLPFRQ.
        /// </summary>
        public const string VLPFRQ = "VLPFRQ";

        /// <summary>
        /// VLFY.
        /// </summary>
        public const string VLFY = "VLFY";

        /// <summary>
        /// VLDGL.
        /// </summary>
        public const string VLDGL = "VLDGL";

        /// <summary>
        /// VLPN.
        /// </summary>
        public const string VLPN = "VLPN";

        /// <summary>
        /// VLDWK.
        /// </summary>
        public const string VLDWK = "VLDWK";

        /// <summary>
        /// VLDW.
        /// </summary>
        public const string VLDW = "VLDW";

        /// <summary>
        /// VLPPED.
        /// </summary>
        public const string VLPPED = "VLPPED";

        /// <summary>
        /// VLPPP.
        /// </summary>
        public const string VLPPP = "VLPPP";

        /// <summary>
        /// VLDTBT.
        /// </summary>
        public const string VLDTBT = "VLDTBT";

        /// <summary>
        /// VLTCDE.
        /// </summary>
        public const string VLTCDE = "VLTCDE";

        /// <summary>
        /// VLEQCO.
        /// </summary>
        public const string VLEQCO = "VLEQCO";

        /// <summary>
        /// VLEQWO.
        /// </summary>
        public const string VLEQWO = "VLEQWO";

        /// <summary>
        /// VLEQCG.
        /// </summary>
        public const string VLEQCG = "VLEQCG";

        /// <summary>
        /// VLQOBJ.
        /// </summary>
        public const string VLQOBJ = "VLQOBJ";

        /// <summary>
        /// VLERC.
        /// </summary>
        public const string VLERC = "VLERC";

        /// <summary>
        /// VLEQRT.
        /// </summary>
        public const string VLEQRT = "VLEQRT";

        /// <summary>
        /// VLEQGR.
        /// </summary>
        public const string VLEQGR = "VLEQGR";

        /// <summary>
        /// VLEQHR.
        /// </summary>
        public const string VLEQHR = "VLEQHR";

        /// <summary>
        /// VLEXR.
        /// </summary>
        public const string VLEXR = "VLEXR";

        /// <summary>
        /// VLP001.
        /// </summary>
        public const string VLP001 = "VLP001";

        /// <summary>
        /// VLP002.
        /// </summary>
        public const string VLP002 = "VLP002";

        /// <summary>
        /// VLP003.
        /// </summary>
        public const string VLP003 = "VLP003";

        /// <summary>
        /// VLP004.
        /// </summary>
        public const string VLP004 = "VLP004";

        /// <summary>
        /// VLUSER.
        /// </summary>
        public const string VLUSER = "VLUSER";

        /// <summary>
        /// VLCMMT.
        /// </summary>
        public const string VLCMMT = "VLCMMT";

        /// <summary>
        /// VLCKDT.
        /// </summary>
        public const string VLCKDT = "VLCKDT";

        /// <summary>
        /// VLUAMT.
        /// </summary>
        public const string VLUAMT = "VLUAMT";

        /// <summary>
        /// VLYST.
        /// </summary>
        public const string VLYST = "VLYST";

        /// <summary>
        /// VLICU.
        /// </summary>
        public const string VLICU = "VLICU";

        /// <summary>
        /// VLGICU.
        /// </summary>
        public const string VLGICU = "VLGICU";

        /// <summary>
        /// VLDICJ.
        /// </summary>
        public const string VLDICJ = "VLDICJ";

        /// <summary>
        /// VLUPMJ.
        /// </summary>
        public const string VLUPMJ = "VLUPMJ";

        /// <summary>
        /// VLPID.
        /// </summary>
        public const string VLPID = "VLPID";

        /// <summary>
        /// VLANI.
        /// </summary>
        public const string VLANI = "VLANI";

        /// <summary>
        /// VLCTRY.
        /// </summary>
        public const string VLCTRY = "VLCTRY";

        /// <summary>
        /// VLANN8.
        /// </summary>
        public const string VLANN8 = "VLANN8";

        /// <summary>
        /// VLPGRP.
        /// </summary>
        public const string VLPGRP = "VLPGRP";

        /// <summary>
        /// VLPAYG.
        /// </summary>
        public const string VLPAYG = "VLPAYG";

        /// <summary>
        /// VLPAYN.
        /// </summary>
        public const string VLPAYN = "VLPAYN";

        /// <summary>
        /// VLSFLG.
        /// </summary>
        public const string VLSFLG = "VLSFLG";

        /// <summary>
        /// VLWS.
        /// </summary>
        public const string VLWS = "VLWS";

        /// <summary>
        /// VLPCK.
        /// </summary>
        public const string VLPCK = "VLPCK";

        /// <summary>
        /// VLICC.
        /// </summary>
        public const string VLICC = "VLICC";

        /// <summary>
        /// VLICS.
        /// </summary>
        public const string VLICS = "VLICS";

        /// <summary>
        /// VLCMTH.
        /// </summary>
        public const string VLCMTH = "VLCMTH";

        /// <summary>
        /// VLACO.
        /// </summary>
        public const string VLACO = "VLACO";

        /// <summary>
        /// VLAI.
        /// </summary>
        public const string VLAI = "VLAI";

        /// <summary>
        /// VLSEC$.
        /// </summary>
        public const string VLSEC_ = "VLSEC$";

        /// <summary>
        /// VLOHF.
        /// </summary>
        public const string VLOHF = "VLOHF";

        /// <summary>
        /// VLDEP1.
        /// </summary>
        public const string VLDEP1 = "VLDEP1";

        /// <summary>
        /// VLDEP2.
        /// </summary>
        public const string VLDEP2 = "VLDEP2";

        /// <summary>
        /// VLDEP3.
        /// </summary>
        public const string VLDEP3 = "VLDEP3";

        /// <summary>
        /// VLDEP4.
        /// </summary>
        public const string VLDEP4 = "VLDEP4";

        /// <summary>
        /// VLDEP5.
        /// </summary>
        public const string VLDEP5 = "VLDEP5";

        /// <summary>
        /// VLTT01.
        /// </summary>
        public const string VLTT01 = "VLTT01";

        /// <summary>
        /// VLTT02.
        /// </summary>
        public const string VLTT02 = "VLTT02";

        /// <summary>
        /// VLTT03.
        /// </summary>
        public const string VLTT03 = "VLTT03";

        /// <summary>
        /// VLTT04.
        /// </summary>
        public const string VLTT04 = "VLTT04";

        /// <summary>
        /// VLTT05.
        /// </summary>
        public const string VLTT05 = "VLTT05";

        /// <summary>
        /// VLTT06.
        /// </summary>
        public const string VLTT06 = "VLTT06";

        /// <summary>
        /// VLTT07.
        /// </summary>
        public const string VLTT07 = "VLTT07";

        /// <summary>
        /// VLTT08.
        /// </summary>
        public const string VLTT08 = "VLTT08";

        /// <summary>
        /// VLTT09.
        /// </summary>
        public const string VLTT09 = "VLTT09";

        /// <summary>
        /// VLTT10.
        /// </summary>
        public const string VLTT10 = "VLTT10";

        /// <summary>
        /// VLTT11.
        /// </summary>
        public const string VLTT11 = "VLTT11";

        /// <summary>
        /// VLTT12.
        /// </summary>
        public const string VLTT12 = "VLTT12";

        /// <summary>
        /// VLTT13.
        /// </summary>
        public const string VLTT13 = "VLTT13";

        /// <summary>
        /// VLTT14.
        /// </summary>
        public const string VLTT14 = "VLTT14";

        /// <summary>
        /// VLTT15.
        /// </summary>
        public const string VLTT15 = "VLTT15";

        /// <summary>
        /// VLUSR.
        /// </summary>
        public const string VLUSR = "VLUSR";

        /// <summary>
        /// VLEPA.
        /// </summary>
        public const string VLEPA = "VLEPA";

        /// <summary>
        /// VLBFA.
        /// </summary>
        public const string VLBFA = "VLBFA";

        /// <summary>
        /// VLRTWC.
        /// </summary>
        public const string VLRTWC = "VLRTWC";

        /// <summary>
        /// VLGENR.
        /// </summary>
        public const string VLGENR = "VLGENR";

        /// <summary>
        /// VLADV.
        /// </summary>
        public const string VLADV = "VLADV";

        /// <summary>
        /// VLSTIP.
        /// </summary>
        public const string VLSTIP = "VLSTIP";

        /// <summary>
        /// VLALPH.
        /// </summary>
        public const string VLALPH = "VLALPH";

        /// <summary>
        /// VLIIAP.
        /// </summary>
        public const string VLIIAP = "VLIIAP";

        /// <summary>
        /// VLFICM.
        /// </summary>
        public const string VLFICM = "VLFICM";

        /// <summary>
        /// VLDTAB.
        /// </summary>
        public const string VLDTAB = "VLDTAB";

        /// <summary>
        /// VLDTSP.
        /// </summary>
        public const string VLDTSP = "VLDTSP";

        /// <summary>
        /// VLYST1.
        /// </summary>
        public const string VLYST1 = "VLYST1";

        /// <summary>
        /// VLSHRT.
        /// </summary>
        public const string VLSHRT = "VLSHRT";

        /// <summary>
        /// VLLD.
        /// </summary>
        public const string VLLD = "VLLD";

        /// <summary>
        /// VLACTB.
        /// </summary>
        public const string VLACTB = "VLACTB";

        /// <summary>
        /// VLABR1.
        /// </summary>
        public const string VLABR1 = "VLABR1";

        /// <summary>
        /// VLABT1.
        /// </summary>
        public const string VLABT1 = "VLABT1";

        /// <summary>
        /// VLABR2.
        /// </summary>
        public const string VLABR2 = "VLABR2";

        /// <summary>
        /// VLABT2.
        /// </summary>
        public const string VLABT2 = "VLABT2";

        /// <summary>
        /// VLABR3.
        /// </summary>
        public const string VLABR3 = "VLABR3";

        /// <summary>
        /// VLABT3.
        /// </summary>
        public const string VLABT3 = "VLABT3";

        /// <summary>
        /// VLABR4.
        /// </summary>
        public const string VLABR4 = "VLABR4";

        /// <summary>
        /// VLABT4.
        /// </summary>
        public const string VLABT4 = "VLABT4";

        /// <summary>
        /// VLITM.
        /// </summary>
        public const string VLITM = "VLITM";

        /// <summary>
        /// VLBLGRT.
        /// </summary>
        public const string VLBLGRT = "VLBLGRT";

        /// <summary>
        /// VLRCHGAMT.
        /// </summary>
        public const string VLRCHGAMT = "VLRCHGAMT";

        /// <summary>
        /// VLFBLGRT.
        /// </summary>
        public const string VLFBLGRT = "VLFBLGRT";

        /// <summary>
        /// VLFRCHGAMT.
        /// </summary>
        public const string VLFRCHGAMT = "VLFRCHGAMT";

        /// <summary>
        /// VLCRR.
        /// </summary>
        public const string VLCRR = "VLCRR";

        /// <summary>
        /// VLCRCD.
        /// </summary>
        public const string VLCRCD = "VLCRCD";

        /// <summary>
        /// VLCRDC.
        /// </summary>
        public const string VLCRDC = "VLCRDC";

        /// <summary>
        /// VLRCHGMODE.
        /// </summary>
        public const string VLRCHGMODE = "VLRCHGMODE";

        /// <summary>
        /// VLSSFL.
        /// </summary>
        public const string VLSSFL = "VLSSFL";

        /// <summary>
        /// VLLTTP.
        /// </summary>
        public const string VLLTTP = "VLLTTP";

        /// <summary>
        /// VLRKID.
        /// </summary>
        public const string VLRKID = "VLRKID";

        /// <summary>
        /// VLPOS.
        /// </summary>
        public const string VLPOS = "VLPOS";

        /// <summary>
        /// VLOTRULECD.
        /// </summary>
        public const string VLOTRULECD = "VLOTRULECD";

        /// <summary>
        /// VLTSKID.
        /// </summary>
        public const string VLTSKID = "VLTSKID";

        /// <summary>
        /// VLUPMT.
        /// </summary>
        public const string VLUPMT = "VLUPMT";

        /// <summary>
        /// VLANPA.
        /// </summary>
        public const string VLANPA = "VLANPA";

        /// <summary>
        /// VLDOCM.
        /// </summary>
        public const string VLDOCM = "VLDOCM";

        /// <summary>
        /// VLSSREID.
        /// </summary>
        public const string VLSSREID = "VLSSREID";

        /// <summary>
        /// VLPAYLIA.
        /// </summary>
        public const string VLPAYLIA = "VLPAYLIA";

        /// <summary>
        /// VLTCFD.
        /// </summary>
        public const string VLTCFD = "VLTCFD";

        /// <summary>
        /// VLTCTD.
        /// </summary>
        public const string VLTCTD = "VLTCTD";

        /// <summary>
        /// VLHWPD.
        /// </summary>
        public const string VLHWPD = "VLHWPD";

        /// <summary>
        /// VLINSTID.
        /// </summary>
        public const string VLINSTID = "VLINSTID";

        /// <summary>
        /// VLTCUN.
        /// </summary>
        public const string VLTCUN = "VLTCUN";

        /// <summary>
        /// VLTCHC.
        /// </summary>
        public const string VLTCHC = "VLTCHC";

        /// <summary>
        /// VLTCHB.
        /// </summary>
        public const string VLTCHB = "VLTCHB";

        /// <summary>
        /// VLTCJT.
        /// </summary>
        public const string VLTCJT = "VLTCJT";

        /// <summary>
        /// VLTCJS.
        /// </summary>
        public const string VLTCJS = "VLTCJS";

        /// <summary>
        /// VLTCRT.
        /// </summary>
        public const string VLTCRT = "VLTCRT";

        /// <summary>
        /// VLTCSC.
        /// </summary>
        public const string VLTCSC = "VLTCSC";

        /// <summary>
        /// VLTCSD.
        /// </summary>
        public const string VLTCSD = "VLTCSD";

        /// <summary>
        /// VLTCBR.
        /// </summary>
        public const string VLTCBR = "VLTCBR";

        /// <summary>
        /// VLTCPC.
        /// </summary>
        public const string VLTCPC = "VLTCPC";

        /// <summary>
        /// VLTCWC.
        /// </summary>
        public const string VLTCWC = "VLTCWC";

        /// <summary>
        /// VLTCWS.
        /// </summary>
        public const string VLTCWS = "VLTCWS";

        /// <summary>
        /// VLTCJL.
        /// </summary>
        public const string VLTCJL = "VLTCJL";

        /// <summary>
        /// VLTCANI.
        /// </summary>
        public const string VLTCANI = "VLTCANI";

        /// <summary>
        /// VLJBLC.
        /// </summary>
        public const string VLJBLC = "VLJBLC";

        /// <summary>
        /// VLLDED.
        /// </summary>
        public const string VLLDED = "VLLDED";

        /// <summary>
        /// VLTCPF.
        /// </summary>
        public const string VLTCPF = "VLTCPF";

        /// <summary>
        /// VLCRFL.
        /// </summary>
        public const string VLCRFL = "VLCRFL";

        /// <summary>
        /// VLCPTR.
        /// </summary>
        public const string VLCPTR = "VLCPTR";

        /// <summary>
        /// VLZ1CR.
        /// </summary>
        public const string VLZ1CR = "VLZ1CR";

        /// <summary>
        /// VLZ1CM.
        /// </summary>
        public const string VLZ1CM = "VLZ1CM";

        /// <summary>
        /// VLLDID.
        /// </summary>
        public const string VLLDID = "VLLDID";

        /// <summary>
        /// VLAUSPTWW.
        /// </summary>
        public const string VLAUSPTWW = "VLAUSPTWW";
    }

    /// <inheritdoc />
    public override string TableName => "F06116Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VLEDUS", "VLEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VLEDTY", "VLEDTY", JdeDataType.String, 2),
        new JdeField("VLEDSQ", "VLEDSQ", JdeDataType.Numeric),
        new JdeField("VLEDTN", "VLEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VLEDCT", "VLEDCT", JdeDataType.String, 4),
        new JdeField("VLEDLN", "VLEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VLEDTS", "VLEDTS", JdeDataType.String, 12),
        new JdeField("VLEDFT", "VLEDFT", JdeDataType.String, 20),
        new JdeField("VLEDDT", "VLEDDT", JdeDataType.Numeric),
        new JdeField("VLEDER", "VLEDER", JdeDataType.String, 2),
        new JdeField("VLEDDL", "VLEDDL", JdeDataType.Numeric),
        new JdeField("VLEDSP", "VLEDSP", JdeDataType.String, 2),
        new JdeField("VLEDTC", "VLEDTC", JdeDataType.String, 2),
        new JdeField("VLEDTR", "VLEDTR", JdeDataType.String, 2),
        new JdeField("VLEDBT", "VLEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VLEDGL", "VLEDGL", JdeDataType.String, 2),
        new JdeField("VLPANP", "VLPANP", JdeDataType.String, 18),
        new JdeField("VLAN8", "VLAN8", JdeDataType.Numeric),
        new JdeField("VLPALF", "VLPALF", JdeDataType.String, 24),
        new JdeField("VLPRTR", "VLPRTR", JdeDataType.Numeric),
        new JdeField("VLRCCD", "VLRCCD", JdeDataType.String, 2),
        new JdeField("VLCKCN", "VLCKCN", JdeDataType.Numeric),
        new JdeField("VLAM", "VLAM", JdeDataType.String, 2),
        new JdeField("VLCO", "VLCO", JdeDataType.String, 10),
        new JdeField("VLHMCO", "VLHMCO", JdeDataType.String, 10),
        new JdeField("VLHMCU", "VLHMCU", JdeDataType.String, 24),
        new JdeField("VLMCU", "VLMCU", JdeDataType.String, 24),
        new JdeField("VLOBJ", "VLOBJ", JdeDataType.String, 12),
        new JdeField("VLSUB", "VLSUB", JdeDataType.String, 16),
        new JdeField("VLRCO", "VLRCO", JdeDataType.String, 10),
        new JdeField("VLGMCU", "VLGMCU", JdeDataType.String, 24),
        new JdeField("VLGOBJ", "VLGOBJ", JdeDataType.String, 12),
        new JdeField("VLGSUB", "VLGSUB", JdeDataType.String, 16),
        new JdeField("VLSBL", "VLSBL", JdeDataType.String, 16),
        new JdeField("VLSBLT", "VLSBLT", JdeDataType.String, 2),
        new JdeField("VLWR01", "VLWR01", JdeDataType.String, 8),
        new JdeField("VLMCUO", "VLMCUO", JdeDataType.String, 24),
        new JdeField("VLMAIL", "VLMAIL", JdeDataType.String, 20),
        new JdeField("VLPHRW", "VLPHRW", JdeDataType.Numeric),
        new JdeField("VLOPSQ", "VLOPSQ", JdeDataType.Numeric),
        new JdeField("VLRILT", "VLRILT", JdeDataType.String, 2),
        new JdeField("VLBDSN", "VLBDSN", JdeDataType.String, 44),
        new JdeField("VLPCUN", "VLPCUN", JdeDataType.Numeric),
        new JdeField("VLUM", "VLUM", JdeDataType.String, 4),
        new JdeField("VLPHRT", "VLPHRT", JdeDataType.Numeric),
        new JdeField("VLPPRT", "VLPPRT", JdeDataType.Numeric),
        new JdeField("VLBHRT", "VLBHRT", JdeDataType.Numeric),
        new JdeField("VLPBRT", "VLPBRT", JdeDataType.Numeric),
        new JdeField("VLBDRT", "VLBDRT", JdeDataType.Numeric),
        new JdeField("VLGPA", "VLGPA", JdeDataType.Numeric),
        new JdeField("VLDPA", "VLDPA", JdeDataType.Numeric),
        new JdeField("VLRCPY", "VLRCPY", JdeDataType.Numeric),
        new JdeField("VLSAMT", "VLSAMT", JdeDataType.Numeric),
        new JdeField("VLUN", "VLUN", JdeDataType.String, 12),
        new JdeField("VLJBCD", "VLJBCD", JdeDataType.String, 12),
        new JdeField("VLJBST", "VLJBST", JdeDataType.String, 8),
        new JdeField("VLWST", "VLWST", JdeDataType.Numeric),
        new JdeField("VLWCNT", "VLWCNT", JdeDataType.Numeric),
        new JdeField("VLWCTY", "VLWCTY", JdeDataType.Numeric),
        new JdeField("VLWCMP", "VLWCMP", JdeDataType.String, 8),
        new JdeField("VLWET", "VLWET", JdeDataType.String, 2),
        new JdeField("VLGENA", "VLGENA", JdeDataType.Numeric),
        new JdeField("VLWCAM", "VLWCAM", JdeDataType.Numeric),
        new JdeField("VLWCMB", "VLWCMB", JdeDataType.Numeric),
        new JdeField("VLGENB", "VLGENB", JdeDataType.Numeric),
        new JdeField("VLWCMO", "VLWCMO", JdeDataType.Numeric),
        new JdeField("VLGENO", "VLGENO", JdeDataType.Numeric),
        new JdeField("VLWCMX", "VLWCMX", JdeDataType.Numeric),
        new JdeField("VLGENX", "VLGENX", JdeDataType.Numeric),
        new JdeField("VLHMO", "VLHMO", JdeDataType.Numeric),
        new JdeField("VLPDBA", "VLPDBA", JdeDataType.Numeric),
        new JdeField("VLPB", "VLPB", JdeDataType.String, 2),
        new JdeField("VLDEDM", "VLDEDM", JdeDataType.String, 2),
        new JdeField("VLPAYM", "VLPAYM", JdeDataType.Numeric),
        new JdeField("VLSHFT", "VLSHFT", JdeDataType.String, 2),
        new JdeField("VLSHD", "VLSHD", JdeDataType.Numeric),
        new JdeField("VLSALY", "VLSALY", JdeDataType.String, 2),
        new JdeField("VLNMTH", "VLNMTH", JdeDataType.String, 2),
        new JdeField("VLPFRQ", "VLPFRQ", JdeDataType.String, 2),
        new JdeField("VLFY", "VLFY", JdeDataType.Numeric),
        new JdeField("VLDGL", "VLDGL", JdeDataType.Numeric),
        new JdeField("VLPN", "VLPN", JdeDataType.Numeric),
        new JdeField("VLDWK", "VLDWK", JdeDataType.Numeric),
        new JdeField("VLDW", "VLDW", JdeDataType.String, 2),
        new JdeField("VLPPED", "VLPPED", JdeDataType.Numeric),
        new JdeField("VLPPP", "VLPPP", JdeDataType.String, 2),
        new JdeField("VLDTBT", "VLDTBT", JdeDataType.Numeric),
        new JdeField("VLTCDE", "VLTCDE", JdeDataType.Numeric),
        new JdeField("VLEQCO", "VLEQCO", JdeDataType.String, 10),
        new JdeField("VLEQWO", "VLEQWO", JdeDataType.String, 18),
        new JdeField("VLEQCG", "VLEQCG", JdeDataType.String, 18),
        new JdeField("VLQOBJ", "VLQOBJ", JdeDataType.String, 12),
        new JdeField("VLERC", "VLERC", JdeDataType.String, 4),
        new JdeField("VLEQRT", "VLEQRT", JdeDataType.Numeric),
        new JdeField("VLEQGR", "VLEQGR", JdeDataType.Numeric),
        new JdeField("VLEQHR", "VLEQHR", JdeDataType.Numeric),
        new JdeField("VLEXR", "VLEXR", JdeDataType.String, 60),
        new JdeField("VLP001", "VLP001", JdeDataType.String, 6),
        new JdeField("VLP002", "VLP002", JdeDataType.String, 6),
        new JdeField("VLP003", "VLP003", JdeDataType.String, 6),
        new JdeField("VLP004", "VLP004", JdeDataType.String, 6),
        new JdeField("VLUSER", "VLUSER", JdeDataType.String, 20),
        new JdeField("VLCMMT", "VLCMMT", JdeDataType.String, 2),
        new JdeField("VLCKDT", "VLCKDT", JdeDataType.Numeric),
        new JdeField("VLUAMT", "VLUAMT", JdeDataType.Numeric),
        new JdeField("VLYST", "VLYST", JdeDataType.String, 2),
        new JdeField("VLICU", "VLICU", JdeDataType.Numeric),
        new JdeField("VLGICU", "VLGICU", JdeDataType.Numeric),
        new JdeField("VLDICJ", "VLDICJ", JdeDataType.Numeric),
        new JdeField("VLUPMJ", "VLUPMJ", JdeDataType.Numeric),
        new JdeField("VLPID", "VLPID", JdeDataType.String, 20),
        new JdeField("VLANI", "VLANI", JdeDataType.String, 58),
        new JdeField("VLCTRY", "VLCTRY", JdeDataType.Numeric),
        new JdeField("VLANN8", "VLANN8", JdeDataType.Numeric),
        new JdeField("VLPGRP", "VLPGRP", JdeDataType.String, 4),
        new JdeField("VLPAYG", "VLPAYG", JdeDataType.String, 2),
        new JdeField("VLPAYN", "VLPAYN", JdeDataType.String, 2),
        new JdeField("VLSFLG", "VLSFLG", JdeDataType.String, 2),
        new JdeField("VLWS", "VLWS", JdeDataType.String, 2),
        new JdeField("VLPCK", "VLPCK", JdeDataType.String, 2),
        new JdeField("VLICC", "VLICC", JdeDataType.String, 2),
        new JdeField("VLICS", "VLICS", JdeDataType.String, 2),
        new JdeField("VLCMTH", "VLCMTH", JdeDataType.String, 2),
        new JdeField("VLACO", "VLACO", JdeDataType.String, 2),
        new JdeField("VLAI", "VLAI", JdeDataType.String, 2),
        new JdeField("VLSEC$", "VLSEC$", JdeDataType.String, 2),
        new JdeField("VLOHF", "VLOHF", JdeDataType.String, 2),
        new JdeField("VLDEP1", "VLDEP1", JdeDataType.String, 2),
        new JdeField("VLDEP2", "VLDEP2", JdeDataType.String, 2),
        new JdeField("VLDEP3", "VLDEP3", JdeDataType.String, 2),
        new JdeField("VLDEP4", "VLDEP4", JdeDataType.String, 2),
        new JdeField("VLDEP5", "VLDEP5", JdeDataType.String, 2),
        new JdeField("VLTT01", "VLTT01", JdeDataType.String, 4),
        new JdeField("VLTT02", "VLTT02", JdeDataType.String, 4),
        new JdeField("VLTT03", "VLTT03", JdeDataType.String, 4),
        new JdeField("VLTT04", "VLTT04", JdeDataType.String, 4),
        new JdeField("VLTT05", "VLTT05", JdeDataType.String, 4),
        new JdeField("VLTT06", "VLTT06", JdeDataType.String, 4),
        new JdeField("VLTT07", "VLTT07", JdeDataType.String, 4),
        new JdeField("VLTT08", "VLTT08", JdeDataType.String, 4),
        new JdeField("VLTT09", "VLTT09", JdeDataType.String, 4),
        new JdeField("VLTT10", "VLTT10", JdeDataType.String, 4),
        new JdeField("VLTT11", "VLTT11", JdeDataType.String, 4),
        new JdeField("VLTT12", "VLTT12", JdeDataType.String, 4),
        new JdeField("VLTT13", "VLTT13", JdeDataType.String, 4),
        new JdeField("VLTT14", "VLTT14", JdeDataType.String, 4),
        new JdeField("VLTT15", "VLTT15", JdeDataType.String, 4),
        new JdeField("VLUSR", "VLUSR", JdeDataType.String, 36),
        new JdeField("VLEPA", "VLEPA", JdeDataType.Numeric),
        new JdeField("VLBFA", "VLBFA", JdeDataType.Numeric),
        new JdeField("VLRTWC", "VLRTWC", JdeDataType.Numeric),
        new JdeField("VLGENR", "VLGENR", JdeDataType.Numeric),
        new JdeField("VLADV", "VLADV", JdeDataType.String, 2),
        new JdeField("VLSTIP", "VLSTIP", JdeDataType.String, 2),
        new JdeField("VLALPH", "VLALPH", JdeDataType.String, 80),
        new JdeField("VLIIAP", "VLIIAP", JdeDataType.String, 2),
        new JdeField("VLFICM", "VLFICM", JdeDataType.String, 2),
        new JdeField("VLDTAB", "VLDTAB", JdeDataType.String, 10),
        new JdeField("VLDTSP", "VLDTSP", JdeDataType.Numeric),
        new JdeField("VLYST1", "VLYST1", JdeDataType.String, 2),
        new JdeField("VLSHRT", "VLSHRT", JdeDataType.Numeric),
        new JdeField("VLLD", "VLLD", JdeDataType.String, 2),
        new JdeField("VLACTB", "VLACTB", JdeDataType.String, 20),
        new JdeField("VLABR1", "VLABR1", JdeDataType.String, 24),
        new JdeField("VLABT1", "VLABT1", JdeDataType.String, 2),
        new JdeField("VLABR2", "VLABR2", JdeDataType.String, 24),
        new JdeField("VLABT2", "VLABT2", JdeDataType.String, 2),
        new JdeField("VLABR3", "VLABR3", JdeDataType.String, 24),
        new JdeField("VLABT3", "VLABT3", JdeDataType.String, 2),
        new JdeField("VLABR4", "VLABR4", JdeDataType.String, 24),
        new JdeField("VLABT4", "VLABT4", JdeDataType.String, 2),
        new JdeField("VLITM", "VLITM", JdeDataType.Numeric),
        new JdeField("VLBLGRT", "VLBLGRT", JdeDataType.Numeric),
        new JdeField("VLRCHGAMT", "VLRCHGAMT", JdeDataType.Numeric),
        new JdeField("VLFBLGRT", "VLFBLGRT", JdeDataType.Numeric),
        new JdeField("VLFRCHGAMT", "VLFRCHGAMT", JdeDataType.Numeric),
        new JdeField("VLCRR", "VLCRR", JdeDataType.Numeric),
        new JdeField("VLCRCD", "VLCRCD", JdeDataType.String, 6),
        new JdeField("VLCRDC", "VLCRDC", JdeDataType.String, 6),
        new JdeField("VLRCHGMODE", "VLRCHGMODE", JdeDataType.String, 2),
        new JdeField("VLSSFL", "VLSSFL", JdeDataType.String, 2),
        new JdeField("VLLTTP", "VLLTTP", JdeDataType.String, 4),
        new JdeField("VLRKID", "VLRKID", JdeDataType.Numeric),
        new JdeField("VLPOS", "VLPOS", JdeDataType.String, 16),
        new JdeField("VLOTRULECD", "VLOTRULECD", JdeDataType.String, 6),
        new JdeField("VLTSKID", "VLTSKID", JdeDataType.Numeric),
        new JdeField("VLUPMT", "VLUPMT", JdeDataType.Numeric),
        new JdeField("VLANPA", "VLANPA", JdeDataType.Numeric),
        new JdeField("VLDOCM", "VLDOCM", JdeDataType.Numeric),
        new JdeField("VLSSREID", "VLSSREID", JdeDataType.String, 18),
        new JdeField("VLPAYLIA", "VLPAYLIA", JdeDataType.String, 2),
        new JdeField("VLTCFD", "VLTCFD", JdeDataType.Numeric),
        new JdeField("VLTCTD", "VLTCTD", JdeDataType.Numeric),
        new JdeField("VLHWPD", "VLHWPD", JdeDataType.Numeric),
        new JdeField("VLINSTID", "VLINSTID", JdeDataType.String, 72),
        new JdeField("VLTCUN", "VLTCUN", JdeDataType.String, 2),
        new JdeField("VLTCHC", "VLTCHC", JdeDataType.String, 2),
        new JdeField("VLTCHB", "VLTCHB", JdeDataType.String, 2),
        new JdeField("VLTCJT", "VLTCJT", JdeDataType.String, 2),
        new JdeField("VLTCJS", "VLTCJS", JdeDataType.String, 2),
        new JdeField("VLTCRT", "VLTCRT", JdeDataType.String, 2),
        new JdeField("VLTCSC", "VLTCSC", JdeDataType.String, 2),
        new JdeField("VLTCSD", "VLTCSD", JdeDataType.String, 2),
        new JdeField("VLTCBR", "VLTCBR", JdeDataType.String, 2),
        new JdeField("VLTCPC", "VLTCPC", JdeDataType.String, 2),
        new JdeField("VLTCWC", "VLTCWC", JdeDataType.String, 2),
        new JdeField("VLTCWS", "VLTCWS", JdeDataType.String, 2),
        new JdeField("VLTCJL", "VLTCJL", JdeDataType.String, 2),
        new JdeField("VLTCANI", "VLTCANI", JdeDataType.String, 2),
        new JdeField("VLJBLC", "VLJBLC", JdeDataType.String, 12),
        new JdeField("VLLDED", "VLLDED", JdeDataType.Numeric),
        new JdeField("VLTCPF", "VLTCPF", JdeDataType.String, 2),
        new JdeField("VLCRFL", "VLCRFL", JdeDataType.String, 2),
        new JdeField("VLCPTR", "VLCPTR", JdeDataType.Numeric),
        new JdeField("VLZ1CR", "VLZ1CR", JdeDataType.String, 4),
        new JdeField("VLZ1CM", "VLZ1CM", JdeDataType.String, 200),
        new JdeField("VLLDID", "VLLDID", JdeDataType.String, 10),
        new JdeField("VLAUSPTWW", "VLAUSPTWW", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06116Z1_0", "Primary Key on VLEDUS, VLEDBT, VLEDTN, VLEDLN", new[] { "VLEDUS", "VLEDBT", "VLEDTN", "VLEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06116Z1_10", "Index on VLAN8, VLSSREID, VLDWK", new[] { "VLAN8", "VLSSREID", "VLDWK" }),
        new JdeIndex("F06116Z1_11", "Index on VLINSTID", new[] { "VLINSTID" }),
        new JdeIndex("F06116Z1_12", "Index on VLAN8, VLPDBA", new[] { "VLAN8", "VLPDBA" }),
        new JdeIndex("F06116Z1_2", "Index on VLEDUS, VLEDBT, VLAN8, VLDWK, VLICU, VLEDTN", new[] { "VLEDUS", "VLEDBT", "VLAN8", "VLDWK", "VLICU", "VLEDTN" }),
        new JdeIndex("F06116Z1_4", "Index on VLAN8, VLDWK, VLPRTR", new[] { "VLAN8", "VLDWK", "VLPRTR" }),
        new JdeIndex("F06116Z1_5", "Index on VLTSKID, VLAN8, VLDWK, VLPDBA", new[] { "VLTSKID", "VLAN8", "VLDWK", "VLPDBA" }),
        new JdeIndex("F06116Z1_6", "Index on VLEDBT", new[] { "VLEDBT" }),
        new JdeIndex("F06116Z1_7", "Index on VLAN8, VLEDGL", new[] { "VLAN8", "VLEDGL" }),
        new JdeIndex("F06116Z1_8", "Index on VLEDGL, VLEDUS, VLEDBT, VLEDTN, VLEDLN", new[] { "VLEDGL", "VLEDUS", "VLEDBT", "VLEDTN", "VLEDLN" }),
        new JdeIndex("F06116Z1_9", "Index on VLAN8, VLPDBA, VLPANP", new[] { "VLAN8", "VLPDBA", "VLPANP" })
    };
}
