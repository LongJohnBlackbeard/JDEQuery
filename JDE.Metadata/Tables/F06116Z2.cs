using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06116Z2 - .
/// </summary>
public class F06116Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMEDUS.
        /// </summary>
        public const string VMEDUS = "VMEDUS";

        /// <summary>
        /// VMEDTY.
        /// </summary>
        public const string VMEDTY = "VMEDTY";

        /// <summary>
        /// VMEDSQ.
        /// </summary>
        public const string VMEDSQ = "VMEDSQ";

        /// <summary>
        /// VMEDTN.
        /// </summary>
        public const string VMEDTN = "VMEDTN";

        /// <summary>
        /// VMEDCT.
        /// </summary>
        public const string VMEDCT = "VMEDCT";

        /// <summary>
        /// VMEDLN.
        /// </summary>
        public const string VMEDLN = "VMEDLN";

        /// <summary>
        /// VMEDTS.
        /// </summary>
        public const string VMEDTS = "VMEDTS";

        /// <summary>
        /// VMEDFT.
        /// </summary>
        public const string VMEDFT = "VMEDFT";

        /// <summary>
        /// VMEDDT.
        /// </summary>
        public const string VMEDDT = "VMEDDT";

        /// <summary>
        /// VMEDER.
        /// </summary>
        public const string VMEDER = "VMEDER";

        /// <summary>
        /// VMEDDL.
        /// </summary>
        public const string VMEDDL = "VMEDDL";

        /// <summary>
        /// VMEDSP.
        /// </summary>
        public const string VMEDSP = "VMEDSP";

        /// <summary>
        /// VMEDTC.
        /// </summary>
        public const string VMEDTC = "VMEDTC";

        /// <summary>
        /// VMEDTR.
        /// </summary>
        public const string VMEDTR = "VMEDTR";

        /// <summary>
        /// VMEDBT.
        /// </summary>
        public const string VMEDBT = "VMEDBT";

        /// <summary>
        /// VMEDGL.
        /// </summary>
        public const string VMEDGL = "VMEDGL";

        /// <summary>
        /// VMPANP.
        /// </summary>
        public const string VMPANP = "VMPANP";

        /// <summary>
        /// VMAN8.
        /// </summary>
        public const string VMAN8 = "VMAN8";

        /// <summary>
        /// VMPALF.
        /// </summary>
        public const string VMPALF = "VMPALF";

        /// <summary>
        /// VMPRTR.
        /// </summary>
        public const string VMPRTR = "VMPRTR";

        /// <summary>
        /// VMRCCD.
        /// </summary>
        public const string VMRCCD = "VMRCCD";

        /// <summary>
        /// VMCKCN.
        /// </summary>
        public const string VMCKCN = "VMCKCN";

        /// <summary>
        /// VMAM.
        /// </summary>
        public const string VMAM = "VMAM";

        /// <summary>
        /// VMCO.
        /// </summary>
        public const string VMCO = "VMCO";

        /// <summary>
        /// VMHMCO.
        /// </summary>
        public const string VMHMCO = "VMHMCO";

        /// <summary>
        /// VMHMCU.
        /// </summary>
        public const string VMHMCU = "VMHMCU";

        /// <summary>
        /// VMMCU.
        /// </summary>
        public const string VMMCU = "VMMCU";

        /// <summary>
        /// VMOBJ.
        /// </summary>
        public const string VMOBJ = "VMOBJ";

        /// <summary>
        /// VMSUB.
        /// </summary>
        public const string VMSUB = "VMSUB";

        /// <summary>
        /// VMRCO.
        /// </summary>
        public const string VMRCO = "VMRCO";

        /// <summary>
        /// VMGMCU.
        /// </summary>
        public const string VMGMCU = "VMGMCU";

        /// <summary>
        /// VMGOBJ.
        /// </summary>
        public const string VMGOBJ = "VMGOBJ";

        /// <summary>
        /// VMGSUB.
        /// </summary>
        public const string VMGSUB = "VMGSUB";

        /// <summary>
        /// VMSBL.
        /// </summary>
        public const string VMSBL = "VMSBL";

        /// <summary>
        /// VMSBLT.
        /// </summary>
        public const string VMSBLT = "VMSBLT";

        /// <summary>
        /// VMWR01.
        /// </summary>
        public const string VMWR01 = "VMWR01";

        /// <summary>
        /// VMMCUO.
        /// </summary>
        public const string VMMCUO = "VMMCUO";

        /// <summary>
        /// VMMAIL.
        /// </summary>
        public const string VMMAIL = "VMMAIL";

        /// <summary>
        /// VMPHRW.
        /// </summary>
        public const string VMPHRW = "VMPHRW";

        /// <summary>
        /// VMOPSQ.
        /// </summary>
        public const string VMOPSQ = "VMOPSQ";

        /// <summary>
        /// VMRILT.
        /// </summary>
        public const string VMRILT = "VMRILT";

        /// <summary>
        /// VMBDSN.
        /// </summary>
        public const string VMBDSN = "VMBDSN";

        /// <summary>
        /// VMPCUN.
        /// </summary>
        public const string VMPCUN = "VMPCUN";

        /// <summary>
        /// VMUM.
        /// </summary>
        public const string VMUM = "VMUM";

        /// <summary>
        /// VMPHRT.
        /// </summary>
        public const string VMPHRT = "VMPHRT";

        /// <summary>
        /// VMPPRT.
        /// </summary>
        public const string VMPPRT = "VMPPRT";

        /// <summary>
        /// VMBHRT.
        /// </summary>
        public const string VMBHRT = "VMBHRT";

        /// <summary>
        /// VMPBRT.
        /// </summary>
        public const string VMPBRT = "VMPBRT";

        /// <summary>
        /// VMBDRT.
        /// </summary>
        public const string VMBDRT = "VMBDRT";

        /// <summary>
        /// VMGPA.
        /// </summary>
        public const string VMGPA = "VMGPA";

        /// <summary>
        /// VMDPA.
        /// </summary>
        public const string VMDPA = "VMDPA";

        /// <summary>
        /// VMRCPY.
        /// </summary>
        public const string VMRCPY = "VMRCPY";

        /// <summary>
        /// VMSAMT.
        /// </summary>
        public const string VMSAMT = "VMSAMT";

        /// <summary>
        /// VMUN.
        /// </summary>
        public const string VMUN = "VMUN";

        /// <summary>
        /// VMJBCD.
        /// </summary>
        public const string VMJBCD = "VMJBCD";

        /// <summary>
        /// VMJBST.
        /// </summary>
        public const string VMJBST = "VMJBST";

        /// <summary>
        /// VMWST.
        /// </summary>
        public const string VMWST = "VMWST";

        /// <summary>
        /// VMWCNT.
        /// </summary>
        public const string VMWCNT = "VMWCNT";

        /// <summary>
        /// VMWCTY.
        /// </summary>
        public const string VMWCTY = "VMWCTY";

        /// <summary>
        /// VMWCMP.
        /// </summary>
        public const string VMWCMP = "VMWCMP";

        /// <summary>
        /// VMWET.
        /// </summary>
        public const string VMWET = "VMWET";

        /// <summary>
        /// VMGENA.
        /// </summary>
        public const string VMGENA = "VMGENA";

        /// <summary>
        /// VMWCAM.
        /// </summary>
        public const string VMWCAM = "VMWCAM";

        /// <summary>
        /// VMWCMB.
        /// </summary>
        public const string VMWCMB = "VMWCMB";

        /// <summary>
        /// VMGENB.
        /// </summary>
        public const string VMGENB = "VMGENB";

        /// <summary>
        /// VMWCMO.
        /// </summary>
        public const string VMWCMO = "VMWCMO";

        /// <summary>
        /// VMGENO.
        /// </summary>
        public const string VMGENO = "VMGENO";

        /// <summary>
        /// VMWCMX.
        /// </summary>
        public const string VMWCMX = "VMWCMX";

        /// <summary>
        /// VMGENX.
        /// </summary>
        public const string VMGENX = "VMGENX";

        /// <summary>
        /// VMHMO.
        /// </summary>
        public const string VMHMO = "VMHMO";

        /// <summary>
        /// VMPDBA.
        /// </summary>
        public const string VMPDBA = "VMPDBA";

        /// <summary>
        /// VMPB.
        /// </summary>
        public const string VMPB = "VMPB";

        /// <summary>
        /// VMDEDM.
        /// </summary>
        public const string VMDEDM = "VMDEDM";

        /// <summary>
        /// VMPAYM.
        /// </summary>
        public const string VMPAYM = "VMPAYM";

        /// <summary>
        /// VMSHFT.
        /// </summary>
        public const string VMSHFT = "VMSHFT";

        /// <summary>
        /// VMSHD.
        /// </summary>
        public const string VMSHD = "VMSHD";

        /// <summary>
        /// VMSALY.
        /// </summary>
        public const string VMSALY = "VMSALY";

        /// <summary>
        /// VMNMTH.
        /// </summary>
        public const string VMNMTH = "VMNMTH";

        /// <summary>
        /// VMPFRQ.
        /// </summary>
        public const string VMPFRQ = "VMPFRQ";

        /// <summary>
        /// VMFY.
        /// </summary>
        public const string VMFY = "VMFY";

        /// <summary>
        /// VMDGL.
        /// </summary>
        public const string VMDGL = "VMDGL";

        /// <summary>
        /// VMPN.
        /// </summary>
        public const string VMPN = "VMPN";

        /// <summary>
        /// VMDWK.
        /// </summary>
        public const string VMDWK = "VMDWK";

        /// <summary>
        /// VMDW.
        /// </summary>
        public const string VMDW = "VMDW";

        /// <summary>
        /// VMPPED.
        /// </summary>
        public const string VMPPED = "VMPPED";

        /// <summary>
        /// VMPPP.
        /// </summary>
        public const string VMPPP = "VMPPP";

        /// <summary>
        /// VMDTBT.
        /// </summary>
        public const string VMDTBT = "VMDTBT";

        /// <summary>
        /// VMTCDE.
        /// </summary>
        public const string VMTCDE = "VMTCDE";

        /// <summary>
        /// VMEQCO.
        /// </summary>
        public const string VMEQCO = "VMEQCO";

        /// <summary>
        /// VMEQWO.
        /// </summary>
        public const string VMEQWO = "VMEQWO";

        /// <summary>
        /// VMEQCG.
        /// </summary>
        public const string VMEQCG = "VMEQCG";

        /// <summary>
        /// VMQOBJ.
        /// </summary>
        public const string VMQOBJ = "VMQOBJ";

        /// <summary>
        /// VMERC.
        /// </summary>
        public const string VMERC = "VMERC";

        /// <summary>
        /// VMEQRT.
        /// </summary>
        public const string VMEQRT = "VMEQRT";

        /// <summary>
        /// VMEQGR.
        /// </summary>
        public const string VMEQGR = "VMEQGR";

        /// <summary>
        /// VMEQHR.
        /// </summary>
        public const string VMEQHR = "VMEQHR";

        /// <summary>
        /// VMEXR.
        /// </summary>
        public const string VMEXR = "VMEXR";

        /// <summary>
        /// VMP001.
        /// </summary>
        public const string VMP001 = "VMP001";

        /// <summary>
        /// VMP002.
        /// </summary>
        public const string VMP002 = "VMP002";

        /// <summary>
        /// VMP003.
        /// </summary>
        public const string VMP003 = "VMP003";

        /// <summary>
        /// VMP004.
        /// </summary>
        public const string VMP004 = "VMP004";

        /// <summary>
        /// VMUSER.
        /// </summary>
        public const string VMUSER = "VMUSER";

        /// <summary>
        /// VMCMMT.
        /// </summary>
        public const string VMCMMT = "VMCMMT";

        /// <summary>
        /// VMCKDT.
        /// </summary>
        public const string VMCKDT = "VMCKDT";

        /// <summary>
        /// VMUAMT.
        /// </summary>
        public const string VMUAMT = "VMUAMT";

        /// <summary>
        /// VMYST.
        /// </summary>
        public const string VMYST = "VMYST";

        /// <summary>
        /// VMICU.
        /// </summary>
        public const string VMICU = "VMICU";

        /// <summary>
        /// VMGICU.
        /// </summary>
        public const string VMGICU = "VMGICU";

        /// <summary>
        /// VMDICJ.
        /// </summary>
        public const string VMDICJ = "VMDICJ";

        /// <summary>
        /// VMUPMJ.
        /// </summary>
        public const string VMUPMJ = "VMUPMJ";

        /// <summary>
        /// VMPID.
        /// </summary>
        public const string VMPID = "VMPID";

        /// <summary>
        /// VMANI.
        /// </summary>
        public const string VMANI = "VMANI";

        /// <summary>
        /// VMCTRY.
        /// </summary>
        public const string VMCTRY = "VMCTRY";

        /// <summary>
        /// VMANN8.
        /// </summary>
        public const string VMANN8 = "VMANN8";

        /// <summary>
        /// VMPGRP.
        /// </summary>
        public const string VMPGRP = "VMPGRP";

        /// <summary>
        /// VMPAYG.
        /// </summary>
        public const string VMPAYG = "VMPAYG";

        /// <summary>
        /// VMPAYN.
        /// </summary>
        public const string VMPAYN = "VMPAYN";

        /// <summary>
        /// VMSFLG.
        /// </summary>
        public const string VMSFLG = "VMSFLG";

        /// <summary>
        /// VMWS.
        /// </summary>
        public const string VMWS = "VMWS";

        /// <summary>
        /// VMPCK.
        /// </summary>
        public const string VMPCK = "VMPCK";

        /// <summary>
        /// VMICC.
        /// </summary>
        public const string VMICC = "VMICC";

        /// <summary>
        /// VMICS.
        /// </summary>
        public const string VMICS = "VMICS";

        /// <summary>
        /// VMCMTH.
        /// </summary>
        public const string VMCMTH = "VMCMTH";

        /// <summary>
        /// VMACO.
        /// </summary>
        public const string VMACO = "VMACO";

        /// <summary>
        /// VMAI.
        /// </summary>
        public const string VMAI = "VMAI";

        /// <summary>
        /// VMSEC$.
        /// </summary>
        public const string VMSEC_ = "VMSEC$";

        /// <summary>
        /// VMOHF.
        /// </summary>
        public const string VMOHF = "VMOHF";

        /// <summary>
        /// VMDEP1.
        /// </summary>
        public const string VMDEP1 = "VMDEP1";

        /// <summary>
        /// VMDEP2.
        /// </summary>
        public const string VMDEP2 = "VMDEP2";

        /// <summary>
        /// VMDEP3.
        /// </summary>
        public const string VMDEP3 = "VMDEP3";

        /// <summary>
        /// VMDEP4.
        /// </summary>
        public const string VMDEP4 = "VMDEP4";

        /// <summary>
        /// VMDEP5.
        /// </summary>
        public const string VMDEP5 = "VMDEP5";

        /// <summary>
        /// VMTT01.
        /// </summary>
        public const string VMTT01 = "VMTT01";

        /// <summary>
        /// VMTT02.
        /// </summary>
        public const string VMTT02 = "VMTT02";

        /// <summary>
        /// VMTT03.
        /// </summary>
        public const string VMTT03 = "VMTT03";

        /// <summary>
        /// VMTT04.
        /// </summary>
        public const string VMTT04 = "VMTT04";

        /// <summary>
        /// VMTT05.
        /// </summary>
        public const string VMTT05 = "VMTT05";

        /// <summary>
        /// VMTT06.
        /// </summary>
        public const string VMTT06 = "VMTT06";

        /// <summary>
        /// VMTT07.
        /// </summary>
        public const string VMTT07 = "VMTT07";

        /// <summary>
        /// VMTT08.
        /// </summary>
        public const string VMTT08 = "VMTT08";

        /// <summary>
        /// VMTT09.
        /// </summary>
        public const string VMTT09 = "VMTT09";

        /// <summary>
        /// VMTT10.
        /// </summary>
        public const string VMTT10 = "VMTT10";

        /// <summary>
        /// VMTT11.
        /// </summary>
        public const string VMTT11 = "VMTT11";

        /// <summary>
        /// VMTT12.
        /// </summary>
        public const string VMTT12 = "VMTT12";

        /// <summary>
        /// VMTT13.
        /// </summary>
        public const string VMTT13 = "VMTT13";

        /// <summary>
        /// VMTT14.
        /// </summary>
        public const string VMTT14 = "VMTT14";

        /// <summary>
        /// VMTT15.
        /// </summary>
        public const string VMTT15 = "VMTT15";

        /// <summary>
        /// VMUSR.
        /// </summary>
        public const string VMUSR = "VMUSR";

        /// <summary>
        /// VMEPA.
        /// </summary>
        public const string VMEPA = "VMEPA";

        /// <summary>
        /// VMBFA.
        /// </summary>
        public const string VMBFA = "VMBFA";

        /// <summary>
        /// VMRTWC.
        /// </summary>
        public const string VMRTWC = "VMRTWC";

        /// <summary>
        /// VMGENR.
        /// </summary>
        public const string VMGENR = "VMGENR";

        /// <summary>
        /// VMADV.
        /// </summary>
        public const string VMADV = "VMADV";

        /// <summary>
        /// VMSTIP.
        /// </summary>
        public const string VMSTIP = "VMSTIP";

        /// <summary>
        /// VMALPH.
        /// </summary>
        public const string VMALPH = "VMALPH";

        /// <summary>
        /// VMIIAP.
        /// </summary>
        public const string VMIIAP = "VMIIAP";

        /// <summary>
        /// VMFICM.
        /// </summary>
        public const string VMFICM = "VMFICM";

        /// <summary>
        /// VMDTAB.
        /// </summary>
        public const string VMDTAB = "VMDTAB";

        /// <summary>
        /// VMDTSP.
        /// </summary>
        public const string VMDTSP = "VMDTSP";

        /// <summary>
        /// VMYST1.
        /// </summary>
        public const string VMYST1 = "VMYST1";

        /// <summary>
        /// VMSHRT.
        /// </summary>
        public const string VMSHRT = "VMSHRT";

        /// <summary>
        /// VMLD.
        /// </summary>
        public const string VMLD = "VMLD";

        /// <summary>
        /// VMACTB.
        /// </summary>
        public const string VMACTB = "VMACTB";

        /// <summary>
        /// VMABR1.
        /// </summary>
        public const string VMABR1 = "VMABR1";

        /// <summary>
        /// VMABT1.
        /// </summary>
        public const string VMABT1 = "VMABT1";

        /// <summary>
        /// VMABR2.
        /// </summary>
        public const string VMABR2 = "VMABR2";

        /// <summary>
        /// VMABT2.
        /// </summary>
        public const string VMABT2 = "VMABT2";

        /// <summary>
        /// VMABR3.
        /// </summary>
        public const string VMABR3 = "VMABR3";

        /// <summary>
        /// VMABT3.
        /// </summary>
        public const string VMABT3 = "VMABT3";

        /// <summary>
        /// VMABR4.
        /// </summary>
        public const string VMABR4 = "VMABR4";

        /// <summary>
        /// VMABT4.
        /// </summary>
        public const string VMABT4 = "VMABT4";

        /// <summary>
        /// VMITM.
        /// </summary>
        public const string VMITM = "VMITM";

        /// <summary>
        /// VMBLGRT.
        /// </summary>
        public const string VMBLGRT = "VMBLGRT";

        /// <summary>
        /// VMRCHGAMT.
        /// </summary>
        public const string VMRCHGAMT = "VMRCHGAMT";

        /// <summary>
        /// VMFBLGRT.
        /// </summary>
        public const string VMFBLGRT = "VMFBLGRT";

        /// <summary>
        /// VMFRCHGAMT.
        /// </summary>
        public const string VMFRCHGAMT = "VMFRCHGAMT";

        /// <summary>
        /// VMCRR.
        /// </summary>
        public const string VMCRR = "VMCRR";

        /// <summary>
        /// VMCRCD.
        /// </summary>
        public const string VMCRCD = "VMCRCD";

        /// <summary>
        /// VMCRDC.
        /// </summary>
        public const string VMCRDC = "VMCRDC";

        /// <summary>
        /// VMRCHGMODE.
        /// </summary>
        public const string VMRCHGMODE = "VMRCHGMODE";

        /// <summary>
        /// VMSSFL.
        /// </summary>
        public const string VMSSFL = "VMSSFL";

        /// <summary>
        /// VMLTTP.
        /// </summary>
        public const string VMLTTP = "VMLTTP";

        /// <summary>
        /// VMRKID.
        /// </summary>
        public const string VMRKID = "VMRKID";

        /// <summary>
        /// VMPOS.
        /// </summary>
        public const string VMPOS = "VMPOS";

        /// <summary>
        /// VMOTRULECD.
        /// </summary>
        public const string VMOTRULECD = "VMOTRULECD";

        /// <summary>
        /// VMTSKID.
        /// </summary>
        public const string VMTSKID = "VMTSKID";

        /// <summary>
        /// VMUPMT.
        /// </summary>
        public const string VMUPMT = "VMUPMT";

        /// <summary>
        /// VMANPA.
        /// </summary>
        public const string VMANPA = "VMANPA";

        /// <summary>
        /// VMDOCM.
        /// </summary>
        public const string VMDOCM = "VMDOCM";

        /// <summary>
        /// VMSSREID.
        /// </summary>
        public const string VMSSREID = "VMSSREID";

        /// <summary>
        /// VMPAYLIA.
        /// </summary>
        public const string VMPAYLIA = "VMPAYLIA";

        /// <summary>
        /// VMTCFD.
        /// </summary>
        public const string VMTCFD = "VMTCFD";

        /// <summary>
        /// VMTCTD.
        /// </summary>
        public const string VMTCTD = "VMTCTD";

        /// <summary>
        /// VMHWPD.
        /// </summary>
        public const string VMHWPD = "VMHWPD";

        /// <summary>
        /// VMINSTID.
        /// </summary>
        public const string VMINSTID = "VMINSTID";

        /// <summary>
        /// VMTCUN.
        /// </summary>
        public const string VMTCUN = "VMTCUN";

        /// <summary>
        /// VMTCHC.
        /// </summary>
        public const string VMTCHC = "VMTCHC";

        /// <summary>
        /// VMTCHB.
        /// </summary>
        public const string VMTCHB = "VMTCHB";

        /// <summary>
        /// VMTCJT.
        /// </summary>
        public const string VMTCJT = "VMTCJT";

        /// <summary>
        /// VMTCJS.
        /// </summary>
        public const string VMTCJS = "VMTCJS";

        /// <summary>
        /// VMTCRT.
        /// </summary>
        public const string VMTCRT = "VMTCRT";

        /// <summary>
        /// VMTCSC.
        /// </summary>
        public const string VMTCSC = "VMTCSC";

        /// <summary>
        /// VMTCSD.
        /// </summary>
        public const string VMTCSD = "VMTCSD";

        /// <summary>
        /// VMTCBR.
        /// </summary>
        public const string VMTCBR = "VMTCBR";

        /// <summary>
        /// VMTCPC.
        /// </summary>
        public const string VMTCPC = "VMTCPC";

        /// <summary>
        /// VMTCWC.
        /// </summary>
        public const string VMTCWC = "VMTCWC";

        /// <summary>
        /// VMTCWS.
        /// </summary>
        public const string VMTCWS = "VMTCWS";

        /// <summary>
        /// VMTCJL.
        /// </summary>
        public const string VMTCJL = "VMTCJL";

        /// <summary>
        /// VMTCANI.
        /// </summary>
        public const string VMTCANI = "VMTCANI";

        /// <summary>
        /// VMJBLC.
        /// </summary>
        public const string VMJBLC = "VMJBLC";

        /// <summary>
        /// VMLDED.
        /// </summary>
        public const string VMLDED = "VMLDED";

        /// <summary>
        /// VMTCPF.
        /// </summary>
        public const string VMTCPF = "VMTCPF";

        /// <summary>
        /// VMCRFL.
        /// </summary>
        public const string VMCRFL = "VMCRFL";

        /// <summary>
        /// VMCPTR.
        /// </summary>
        public const string VMCPTR = "VMCPTR";

        /// <summary>
        /// VMZ1CR.
        /// </summary>
        public const string VMZ1CR = "VMZ1CR";

        /// <summary>
        /// VMZ1CM.
        /// </summary>
        public const string VMZ1CM = "VMZ1CM";

        /// <summary>
        /// VMELCR.
        /// </summary>
        public const string VMELCR = "VMELCR";

        /// <summary>
        /// VMTRLX.
        /// </summary>
        public const string VMTRLX = "VMTRLX";

        /// <summary>
        /// VMSEQNC.
        /// </summary>
        public const string VMSEQNC = "VMSEQNC";

        /// <summary>
        /// VMLDID.
        /// </summary>
        public const string VMLDID = "VMLDID";

        /// <summary>
        /// VMDLRB.
        /// </summary>
        public const string VMDLRB = "VMDLRB";

        /// <summary>
        /// VMAUSPTWW.
        /// </summary>
        public const string VMAUSPTWW = "VMAUSPTWW";
    }

    /// <inheritdoc />
    public override string TableName => "F06116Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMEDUS", "VMEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VMEDTY", "VMEDTY", JdeDataType.String, 2),
        new JdeField("VMEDSQ", "VMEDSQ", JdeDataType.Numeric),
        new JdeField("VMEDTN", "VMEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VMEDCT", "VMEDCT", JdeDataType.String, 4),
        new JdeField("VMEDLN", "VMEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VMEDTS", "VMEDTS", JdeDataType.String, 12),
        new JdeField("VMEDFT", "VMEDFT", JdeDataType.String, 20),
        new JdeField("VMEDDT", "VMEDDT", JdeDataType.Numeric),
        new JdeField("VMEDER", "VMEDER", JdeDataType.String, 2),
        new JdeField("VMEDDL", "VMEDDL", JdeDataType.Numeric),
        new JdeField("VMEDSP", "VMEDSP", JdeDataType.String, 2),
        new JdeField("VMEDTC", "VMEDTC", JdeDataType.String, 2),
        new JdeField("VMEDTR", "VMEDTR", JdeDataType.String, 2),
        new JdeField("VMEDBT", "VMEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VMEDGL", "VMEDGL", JdeDataType.String, 2),
        new JdeField("VMPANP", "VMPANP", JdeDataType.String, 18),
        new JdeField("VMAN8", "VMAN8", JdeDataType.Numeric),
        new JdeField("VMPALF", "VMPALF", JdeDataType.String, 24),
        new JdeField("VMPRTR", "VMPRTR", JdeDataType.Numeric),
        new JdeField("VMRCCD", "VMRCCD", JdeDataType.String, 2),
        new JdeField("VMCKCN", "VMCKCN", JdeDataType.Numeric),
        new JdeField("VMAM", "VMAM", JdeDataType.String, 2),
        new JdeField("VMCO", "VMCO", JdeDataType.String, 10),
        new JdeField("VMHMCO", "VMHMCO", JdeDataType.String, 10),
        new JdeField("VMHMCU", "VMHMCU", JdeDataType.String, 24),
        new JdeField("VMMCU", "VMMCU", JdeDataType.String, 24),
        new JdeField("VMOBJ", "VMOBJ", JdeDataType.String, 12),
        new JdeField("VMSUB", "VMSUB", JdeDataType.String, 16),
        new JdeField("VMRCO", "VMRCO", JdeDataType.String, 10),
        new JdeField("VMGMCU", "VMGMCU", JdeDataType.String, 24),
        new JdeField("VMGOBJ", "VMGOBJ", JdeDataType.String, 12),
        new JdeField("VMGSUB", "VMGSUB", JdeDataType.String, 16),
        new JdeField("VMSBL", "VMSBL", JdeDataType.String, 16),
        new JdeField("VMSBLT", "VMSBLT", JdeDataType.String, 2),
        new JdeField("VMWR01", "VMWR01", JdeDataType.String, 8),
        new JdeField("VMMCUO", "VMMCUO", JdeDataType.String, 24),
        new JdeField("VMMAIL", "VMMAIL", JdeDataType.String, 20),
        new JdeField("VMPHRW", "VMPHRW", JdeDataType.Numeric),
        new JdeField("VMOPSQ", "VMOPSQ", JdeDataType.Numeric),
        new JdeField("VMRILT", "VMRILT", JdeDataType.String, 2),
        new JdeField("VMBDSN", "VMBDSN", JdeDataType.String, 44),
        new JdeField("VMPCUN", "VMPCUN", JdeDataType.Numeric),
        new JdeField("VMUM", "VMUM", JdeDataType.String, 4),
        new JdeField("VMPHRT", "VMPHRT", JdeDataType.Numeric),
        new JdeField("VMPPRT", "VMPPRT", JdeDataType.Numeric),
        new JdeField("VMBHRT", "VMBHRT", JdeDataType.Numeric),
        new JdeField("VMPBRT", "VMPBRT", JdeDataType.Numeric),
        new JdeField("VMBDRT", "VMBDRT", JdeDataType.Numeric),
        new JdeField("VMGPA", "VMGPA", JdeDataType.Numeric),
        new JdeField("VMDPA", "VMDPA", JdeDataType.Numeric),
        new JdeField("VMRCPY", "VMRCPY", JdeDataType.Numeric),
        new JdeField("VMSAMT", "VMSAMT", JdeDataType.Numeric),
        new JdeField("VMUN", "VMUN", JdeDataType.String, 12),
        new JdeField("VMJBCD", "VMJBCD", JdeDataType.String, 12),
        new JdeField("VMJBST", "VMJBST", JdeDataType.String, 8),
        new JdeField("VMWST", "VMWST", JdeDataType.Numeric),
        new JdeField("VMWCNT", "VMWCNT", JdeDataType.Numeric),
        new JdeField("VMWCTY", "VMWCTY", JdeDataType.Numeric),
        new JdeField("VMWCMP", "VMWCMP", JdeDataType.String, 8),
        new JdeField("VMWET", "VMWET", JdeDataType.String, 2),
        new JdeField("VMGENA", "VMGENA", JdeDataType.Numeric),
        new JdeField("VMWCAM", "VMWCAM", JdeDataType.Numeric),
        new JdeField("VMWCMB", "VMWCMB", JdeDataType.Numeric),
        new JdeField("VMGENB", "VMGENB", JdeDataType.Numeric),
        new JdeField("VMWCMO", "VMWCMO", JdeDataType.Numeric),
        new JdeField("VMGENO", "VMGENO", JdeDataType.Numeric),
        new JdeField("VMWCMX", "VMWCMX", JdeDataType.Numeric),
        new JdeField("VMGENX", "VMGENX", JdeDataType.Numeric),
        new JdeField("VMHMO", "VMHMO", JdeDataType.Numeric),
        new JdeField("VMPDBA", "VMPDBA", JdeDataType.Numeric),
        new JdeField("VMPB", "VMPB", JdeDataType.String, 2),
        new JdeField("VMDEDM", "VMDEDM", JdeDataType.String, 2),
        new JdeField("VMPAYM", "VMPAYM", JdeDataType.Numeric),
        new JdeField("VMSHFT", "VMSHFT", JdeDataType.String, 2),
        new JdeField("VMSHD", "VMSHD", JdeDataType.Numeric),
        new JdeField("VMSALY", "VMSALY", JdeDataType.String, 2),
        new JdeField("VMNMTH", "VMNMTH", JdeDataType.String, 2),
        new JdeField("VMPFRQ", "VMPFRQ", JdeDataType.String, 2),
        new JdeField("VMFY", "VMFY", JdeDataType.Numeric),
        new JdeField("VMDGL", "VMDGL", JdeDataType.Numeric),
        new JdeField("VMPN", "VMPN", JdeDataType.Numeric),
        new JdeField("VMDWK", "VMDWK", JdeDataType.Numeric),
        new JdeField("VMDW", "VMDW", JdeDataType.String, 2),
        new JdeField("VMPPED", "VMPPED", JdeDataType.Numeric),
        new JdeField("VMPPP", "VMPPP", JdeDataType.String, 2),
        new JdeField("VMDTBT", "VMDTBT", JdeDataType.Numeric),
        new JdeField("VMTCDE", "VMTCDE", JdeDataType.Numeric),
        new JdeField("VMEQCO", "VMEQCO", JdeDataType.String, 10),
        new JdeField("VMEQWO", "VMEQWO", JdeDataType.String, 18),
        new JdeField("VMEQCG", "VMEQCG", JdeDataType.String, 18),
        new JdeField("VMQOBJ", "VMQOBJ", JdeDataType.String, 12),
        new JdeField("VMERC", "VMERC", JdeDataType.String, 4),
        new JdeField("VMEQRT", "VMEQRT", JdeDataType.Numeric),
        new JdeField("VMEQGR", "VMEQGR", JdeDataType.Numeric),
        new JdeField("VMEQHR", "VMEQHR", JdeDataType.Numeric),
        new JdeField("VMEXR", "VMEXR", JdeDataType.String, 60),
        new JdeField("VMP001", "VMP001", JdeDataType.String, 6),
        new JdeField("VMP002", "VMP002", JdeDataType.String, 6),
        new JdeField("VMP003", "VMP003", JdeDataType.String, 6),
        new JdeField("VMP004", "VMP004", JdeDataType.String, 6),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMCMMT", "VMCMMT", JdeDataType.String, 2),
        new JdeField("VMCKDT", "VMCKDT", JdeDataType.Numeric),
        new JdeField("VMUAMT", "VMUAMT", JdeDataType.Numeric),
        new JdeField("VMYST", "VMYST", JdeDataType.String, 2),
        new JdeField("VMICU", "VMICU", JdeDataType.Numeric),
        new JdeField("VMGICU", "VMGICU", JdeDataType.Numeric),
        new JdeField("VMDICJ", "VMDICJ", JdeDataType.Numeric),
        new JdeField("VMUPMJ", "VMUPMJ", JdeDataType.Numeric),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMANI", "VMANI", JdeDataType.String, 58),
        new JdeField("VMCTRY", "VMCTRY", JdeDataType.Numeric),
        new JdeField("VMANN8", "VMANN8", JdeDataType.Numeric),
        new JdeField("VMPGRP", "VMPGRP", JdeDataType.String, 4),
        new JdeField("VMPAYG", "VMPAYG", JdeDataType.String, 2),
        new JdeField("VMPAYN", "VMPAYN", JdeDataType.String, 2),
        new JdeField("VMSFLG", "VMSFLG", JdeDataType.String, 2),
        new JdeField("VMWS", "VMWS", JdeDataType.String, 2),
        new JdeField("VMPCK", "VMPCK", JdeDataType.String, 2),
        new JdeField("VMICC", "VMICC", JdeDataType.String, 2),
        new JdeField("VMICS", "VMICS", JdeDataType.String, 2),
        new JdeField("VMCMTH", "VMCMTH", JdeDataType.String, 2),
        new JdeField("VMACO", "VMACO", JdeDataType.String, 2),
        new JdeField("VMAI", "VMAI", JdeDataType.String, 2),
        new JdeField("VMSEC$", "VMSEC$", JdeDataType.String, 2),
        new JdeField("VMOHF", "VMOHF", JdeDataType.String, 2),
        new JdeField("VMDEP1", "VMDEP1", JdeDataType.String, 2),
        new JdeField("VMDEP2", "VMDEP2", JdeDataType.String, 2),
        new JdeField("VMDEP3", "VMDEP3", JdeDataType.String, 2),
        new JdeField("VMDEP4", "VMDEP4", JdeDataType.String, 2),
        new JdeField("VMDEP5", "VMDEP5", JdeDataType.String, 2),
        new JdeField("VMTT01", "VMTT01", JdeDataType.String, 4),
        new JdeField("VMTT02", "VMTT02", JdeDataType.String, 4),
        new JdeField("VMTT03", "VMTT03", JdeDataType.String, 4),
        new JdeField("VMTT04", "VMTT04", JdeDataType.String, 4),
        new JdeField("VMTT05", "VMTT05", JdeDataType.String, 4),
        new JdeField("VMTT06", "VMTT06", JdeDataType.String, 4),
        new JdeField("VMTT07", "VMTT07", JdeDataType.String, 4),
        new JdeField("VMTT08", "VMTT08", JdeDataType.String, 4),
        new JdeField("VMTT09", "VMTT09", JdeDataType.String, 4),
        new JdeField("VMTT10", "VMTT10", JdeDataType.String, 4),
        new JdeField("VMTT11", "VMTT11", JdeDataType.String, 4),
        new JdeField("VMTT12", "VMTT12", JdeDataType.String, 4),
        new JdeField("VMTT13", "VMTT13", JdeDataType.String, 4),
        new JdeField("VMTT14", "VMTT14", JdeDataType.String, 4),
        new JdeField("VMTT15", "VMTT15", JdeDataType.String, 4),
        new JdeField("VMUSR", "VMUSR", JdeDataType.String, 36),
        new JdeField("VMEPA", "VMEPA", JdeDataType.Numeric),
        new JdeField("VMBFA", "VMBFA", JdeDataType.Numeric),
        new JdeField("VMRTWC", "VMRTWC", JdeDataType.Numeric),
        new JdeField("VMGENR", "VMGENR", JdeDataType.Numeric),
        new JdeField("VMADV", "VMADV", JdeDataType.String, 2),
        new JdeField("VMSTIP", "VMSTIP", JdeDataType.String, 2),
        new JdeField("VMALPH", "VMALPH", JdeDataType.String, 80),
        new JdeField("VMIIAP", "VMIIAP", JdeDataType.String, 2),
        new JdeField("VMFICM", "VMFICM", JdeDataType.String, 2),
        new JdeField("VMDTAB", "VMDTAB", JdeDataType.String, 10),
        new JdeField("VMDTSP", "VMDTSP", JdeDataType.Numeric),
        new JdeField("VMYST1", "VMYST1", JdeDataType.String, 2),
        new JdeField("VMSHRT", "VMSHRT", JdeDataType.Numeric),
        new JdeField("VMLD", "VMLD", JdeDataType.String, 2),
        new JdeField("VMACTB", "VMACTB", JdeDataType.String, 20),
        new JdeField("VMABR1", "VMABR1", JdeDataType.String, 24),
        new JdeField("VMABT1", "VMABT1", JdeDataType.String, 2),
        new JdeField("VMABR2", "VMABR2", JdeDataType.String, 24),
        new JdeField("VMABT2", "VMABT2", JdeDataType.String, 2),
        new JdeField("VMABR3", "VMABR3", JdeDataType.String, 24),
        new JdeField("VMABT3", "VMABT3", JdeDataType.String, 2),
        new JdeField("VMABR4", "VMABR4", JdeDataType.String, 24),
        new JdeField("VMABT4", "VMABT4", JdeDataType.String, 2),
        new JdeField("VMITM", "VMITM", JdeDataType.Numeric),
        new JdeField("VMBLGRT", "VMBLGRT", JdeDataType.Numeric),
        new JdeField("VMRCHGAMT", "VMRCHGAMT", JdeDataType.Numeric),
        new JdeField("VMFBLGRT", "VMFBLGRT", JdeDataType.Numeric),
        new JdeField("VMFRCHGAMT", "VMFRCHGAMT", JdeDataType.Numeric),
        new JdeField("VMCRR", "VMCRR", JdeDataType.Numeric),
        new JdeField("VMCRCD", "VMCRCD", JdeDataType.String, 6),
        new JdeField("VMCRDC", "VMCRDC", JdeDataType.String, 6),
        new JdeField("VMRCHGMODE", "VMRCHGMODE", JdeDataType.String, 2),
        new JdeField("VMSSFL", "VMSSFL", JdeDataType.String, 2),
        new JdeField("VMLTTP", "VMLTTP", JdeDataType.String, 4),
        new JdeField("VMRKID", "VMRKID", JdeDataType.Numeric),
        new JdeField("VMPOS", "VMPOS", JdeDataType.String, 16),
        new JdeField("VMOTRULECD", "VMOTRULECD", JdeDataType.String, 6),
        new JdeField("VMTSKID", "VMTSKID", JdeDataType.Numeric),
        new JdeField("VMUPMT", "VMUPMT", JdeDataType.Numeric),
        new JdeField("VMANPA", "VMANPA", JdeDataType.Numeric),
        new JdeField("VMDOCM", "VMDOCM", JdeDataType.Numeric),
        new JdeField("VMSSREID", "VMSSREID", JdeDataType.String, 18),
        new JdeField("VMPAYLIA", "VMPAYLIA", JdeDataType.String, 2),
        new JdeField("VMTCFD", "VMTCFD", JdeDataType.Numeric),
        new JdeField("VMTCTD", "VMTCTD", JdeDataType.Numeric),
        new JdeField("VMHWPD", "VMHWPD", JdeDataType.Numeric),
        new JdeField("VMINSTID", "VMINSTID", JdeDataType.String, 72),
        new JdeField("VMTCUN", "VMTCUN", JdeDataType.String, 2),
        new JdeField("VMTCHC", "VMTCHC", JdeDataType.String, 2),
        new JdeField("VMTCHB", "VMTCHB", JdeDataType.String, 2),
        new JdeField("VMTCJT", "VMTCJT", JdeDataType.String, 2),
        new JdeField("VMTCJS", "VMTCJS", JdeDataType.String, 2),
        new JdeField("VMTCRT", "VMTCRT", JdeDataType.String, 2),
        new JdeField("VMTCSC", "VMTCSC", JdeDataType.String, 2),
        new JdeField("VMTCSD", "VMTCSD", JdeDataType.String, 2),
        new JdeField("VMTCBR", "VMTCBR", JdeDataType.String, 2),
        new JdeField("VMTCPC", "VMTCPC", JdeDataType.String, 2),
        new JdeField("VMTCWC", "VMTCWC", JdeDataType.String, 2),
        new JdeField("VMTCWS", "VMTCWS", JdeDataType.String, 2),
        new JdeField("VMTCJL", "VMTCJL", JdeDataType.String, 2),
        new JdeField("VMTCANI", "VMTCANI", JdeDataType.String, 2),
        new JdeField("VMJBLC", "VMJBLC", JdeDataType.String, 12),
        new JdeField("VMLDED", "VMLDED", JdeDataType.Numeric),
        new JdeField("VMTCPF", "VMTCPF", JdeDataType.String, 2),
        new JdeField("VMCRFL", "VMCRFL", JdeDataType.String, 2),
        new JdeField("VMCPTR", "VMCPTR", JdeDataType.Numeric),
        new JdeField("VMZ1CR", "VMZ1CR", JdeDataType.String, 4),
        new JdeField("VMZ1CM", "VMZ1CM", JdeDataType.String, 200),
        new JdeField("VMELCR", "VMELCR", JdeDataType.String, 2),
        new JdeField("VMTRLX", "VMTRLX", JdeDataType.Numeric),
        new JdeField("VMSEQNC", "VMSEQNC", JdeDataType.Numeric, null, true, true),
        new JdeField("VMLDID", "VMLDID", JdeDataType.String, 10),
        new JdeField("VMDLRB", "VMDLRB", JdeDataType.String, 2),
        new JdeField("VMAUSPTWW", "VMAUSPTWW", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06116Z2_0", "Primary Key on VMEDUS, VMEDBT, VMEDTN, VMEDLN, VMSEQNC", new[] { "VMEDUS", "VMEDBT", "VMEDTN", "VMEDLN", "VMSEQNC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06116Z2_2", "Index on VMAN8, VMTRLX, SYS_NC00223$", new[] { "VMAN8", "VMTRLX", "SYS_NC00223$" }),
        new JdeIndex("F06116Z2_3", "Index on VMAN8, VMEDTN, SYS_NC00223$, VMELCR", new[] { "VMAN8", "VMEDTN", "SYS_NC00223$", "VMELCR" }),
        new JdeIndex("F06116Z2_4", "Index on VMAN8, VMPRTR", new[] { "VMAN8", "VMPRTR" })
    };
}
