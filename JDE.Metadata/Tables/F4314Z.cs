using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4314Z - .
/// </summary>
public class F4314Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNCTID.
        /// </summary>
        public const string PNCTID = "PNCTID";

        /// <summary>
        /// PNJOBS.
        /// </summary>
        public const string PNJOBS = "PNJOBS";

        /// <summary>
        /// PNXTLN.
        /// </summary>
        public const string PNXTLN = "PNXTLN";

        /// <summary>
        /// PNDLNID.
        /// </summary>
        public const string PNDLNID = "PNDLNID";

        /// <summary>
        /// PNACTN.
        /// </summary>
        public const string PNACTN = "PNACTN";

        /// <summary>
        /// PNEDFL.
        /// </summary>
        public const string PNEDFL = "PNEDFL";

        /// <summary>
        /// PNMAPR.
        /// </summary>
        public const string PNMAPR = "PNMAPR";

        /// <summary>
        /// PNPCR.
        /// </summary>
        public const string PNPCR = "PNPCR";

        /// <summary>
        /// PNDSC1.
        /// </summary>
        public const string PNDSC1 = "PNDSC1";

        /// <summary>
        /// PNDSC2.
        /// </summary>
        public const string PNDSC2 = "PNDSC2";

        /// <summary>
        /// PNUITM.
        /// </summary>
        public const string PNUITM = "PNUITM";

        /// <summary>
        /// PNFLSH.
        /// </summary>
        public const string PNFLSH = "PNFLSH";

        /// <summary>
        /// PNCITM.
        /// </summary>
        public const string PNCITM = "PNCITM";

        /// <summary>
        /// PNIVI.
        /// </summary>
        public const string PNIVI = "PNIVI";

        /// <summary>
        /// PNSTKT.
        /// </summary>
        public const string PNSTKT = "PNSTKT";

        /// <summary>
        /// PNCLEV.
        /// </summary>
        public const string PNCLEV = "PNCLEV";

        /// <summary>
        /// PNCONV.
        /// </summary>
        public const string PNCONV = "PNCONV";

        /// <summary>
        /// PNCNV2.
        /// </summary>
        public const string PNCNV2 = "PNCNV2";

        /// <summary>
        /// PNJEL1.
        /// </summary>
        public const string PNJEL1 = "PNJEL1";

        /// <summary>
        /// PNRWT1.
        /// </summary>
        public const string PNRWT1 = "PNRWT1";

        /// <summary>
        /// PNJEL2.
        /// </summary>
        public const string PNJEL2 = "PNJEL2";

        /// <summary>
        /// PNRWT2.
        /// </summary>
        public const string PNRWT2 = "PNRWT2";

        /// <summary>
        /// PNJEL3.
        /// </summary>
        public const string PNJEL3 = "PNJEL3";

        /// <summary>
        /// PNRWT3.
        /// </summary>
        public const string PNRWT3 = "PNRWT3";

        /// <summary>
        /// PNJEL4.
        /// </summary>
        public const string PNJEL4 = "PNJEL4";

        /// <summary>
        /// PNRWT4.
        /// </summary>
        public const string PNRWT4 = "PNRWT4";

        /// <summary>
        /// PNJEL5.
        /// </summary>
        public const string PNJEL5 = "PNJEL5";

        /// <summary>
        /// PNRWT5.
        /// </summary>
        public const string PNRWT5 = "PNRWT5";

        /// <summary>
        /// PNJEL6.
        /// </summary>
        public const string PNJEL6 = "PNJEL6";

        /// <summary>
        /// PNRWT6.
        /// </summary>
        public const string PNRWT6 = "PNRWT6";

        /// <summary>
        /// PNJEL7.
        /// </summary>
        public const string PNJEL7 = "PNJEL7";

        /// <summary>
        /// PNRWT7.
        /// </summary>
        public const string PNRWT7 = "PNRWT7";

        /// <summary>
        /// PNRWT8.
        /// </summary>
        public const string PNRWT8 = "PNRWT8";

        /// <summary>
        /// PNJEL8.
        /// </summary>
        public const string PNJEL8 = "PNJEL8";

        /// <summary>
        /// PNRWT9.
        /// </summary>
        public const string PNRWT9 = "PNRWT9";

        /// <summary>
        /// PNJEL9.
        /// </summary>
        public const string PNJEL9 = "PNJEL9";

        /// <summary>
        /// PNRWTA.
        /// </summary>
        public const string PNRWTA = "PNRWTA";

        /// <summary>
        /// PNRWTB.
        /// </summary>
        public const string PNRWTB = "PNRWTB";

        /// <summary>
        /// PNRWTD.
        /// </summary>
        public const string PNRWTD = "PNRWTD";

        /// <summary>
        /// PNRWTE.
        /// </summary>
        public const string PNRWTE = "PNRWTE";

        /// <summary>
        /// PNRWTF.
        /// </summary>
        public const string PNRWTF = "PNRWTF";

        /// <summary>
        /// PNRWTG.
        /// </summary>
        public const string PNRWTG = "PNRWTG";

        /// <summary>
        /// PNACIT.
        /// </summary>
        public const string PNACIT = "PNACIT";

        /// <summary>
        /// PNBANI.
        /// </summary>
        public const string PNBANI = "PNBANI";

        /// <summary>
        /// PNSTAM.
        /// </summary>
        public const string PNSTAM = "PNSTAM";

        /// <summary>
        /// PNSTA1.
        /// </summary>
        public const string PNSTA1 = "PNSTA1";

        /// <summary>
        /// PNSTA2.
        /// </summary>
        public const string PNSTA2 = "PNSTA2";

        /// <summary>
        /// PNDDNJ.
        /// </summary>
        public const string PNDDNJ = "PNDDNJ";

        /// <summary>
        /// PNAC07.
        /// </summary>
        public const string PNAC07 = "PNAC07";

        /// <summary>
        /// PNDDJ.
        /// </summary>
        public const string PNDDJ = "PNDDJ";

        /// <summary>
        /// PNADSC.
        /// </summary>
        public const string PNADSC = "PNADSC";

        /// <summary>
        /// PNATXA.
        /// </summary>
        public const string PNATXA = "PNATXA";

        /// <summary>
        /// PNAG.
        /// </summary>
        public const string PNAG = "PNAG";

        /// <summary>
        /// PNACR.
        /// </summary>
        public const string PNACR = "PNACR";

        /// <summary>
        /// PNCDS.
        /// </summary>
        public const string PNCDS = "PNCDS";

        /// <summary>
        /// PNCTAM.
        /// </summary>
        public const string PNCTAM = "PNCTAM";

        /// <summary>
        /// PNCTXA.
        /// </summary>
        public const string PNCTXA = "PNCTXA";

        /// <summary>
        /// PNCRC.
        /// </summary>
        public const string PNCRC = "PNCRC";

        /// <summary>
        /// PNPYE.
        /// </summary>
        public const string PNPYE = "PNPYE";

        /// <summary>
        /// PNAPC.
        /// </summary>
        public const string PNAPC = "PNAPC";

        /// <summary>
        /// PNRMK.
        /// </summary>
        public const string PNRMK = "PNRMK";

        /// <summary>
        /// PNTNN.
        /// </summary>
        public const string PNTNN = "PNTNN";

        /// <summary>
        /// PNATAD.
        /// </summary>
        public const string PNATAD = "PNATAD";

        /// <summary>
        /// PNCTAD.
        /// </summary>
        public const string PNCTAD = "PNCTAD";

        /// <summary>
        /// PNUPAD.
        /// </summary>
        public const string PNUPAD = "PNUPAD";

        /// <summary>
        /// PNCRRD.
        /// </summary>
        public const string PNCRRD = "PNCRRD";

        /// <summary>
        /// PNUNCS.
        /// </summary>
        public const string PNUNCS = "PNUNCS";

        /// <summary>
        /// PNFUC.
        /// </summary>
        public const string PNFUC = "PNFUC";

        /// <summary>
        /// PNAEXP.
        /// </summary>
        public const string PNAEXP = "PNAEXP";

        /// <summary>
        /// PNFEA.
        /// </summary>
        public const string PNFEA = "PNFEA";

        /// <summary>
        /// PNPCRT.
        /// </summary>
        public const string PNPCRT = "PNPCRT";

        /// <summary>
        /// PNRETA.
        /// </summary>
        public const string PNRETA = "PNRETA";

        /// <summary>
        /// PNRETT.
        /// </summary>
        public const string PNRETT = "PNRETT";

        /// <summary>
        /// PNREFA.
        /// </summary>
        public const string PNREFA = "PNREFA";

        /// <summary>
        /// PNREFT.
        /// </summary>
        public const string PNREFT = "PNREFT";

        /// <summary>
        /// PNU.
        /// </summary>
        public const string PNU = "PNU";

        /// <summary>
        /// PNAA.
        /// </summary>
        public const string PNAA = "PNAA";

        /// <summary>
        /// PNFAA.
        /// </summary>
        public const string PNFAA = "PNFAA";

        /// <summary>
        /// PNAA1.
        /// </summary>
        public const string PNAA1 = "PNAA1";

        /// <summary>
        /// PNAA2.
        /// </summary>
        public const string PNAA2 = "PNAA2";

        /// <summary>
        /// PNAN01.
        /// </summary>
        public const string PNAN01 = "PNAN01";

        /// <summary>
        /// PNAN02.
        /// </summary>
        public const string PNAN02 = "PNAN02";

        /// <summary>
        /// PNBCT1.
        /// </summary>
        public const string PNBCT1 = "PNBCT1";

        /// <summary>
        /// PNBCT2.
        /// </summary>
        public const string PNBCT2 = "PNBCT2";

        /// <summary>
        /// PNTRR1.
        /// </summary>
        public const string PNTRR1 = "PNTRR1";

        /// <summary>
        /// PNTRR2.
        /// </summary>
        public const string PNTRR2 = "PNTRR2";

        /// <summary>
        /// PNTRD1.
        /// </summary>
        public const string PNTRD1 = "PNTRD1";

        /// <summary>
        /// PNTRD2.
        /// </summary>
        public const string PNTRD2 = "PNTRD2";

        /// <summary>
        /// PNCRCM.
        /// </summary>
        public const string PNCRCM = "PNCRCM";

        /// <summary>
        /// PNABR1.
        /// </summary>
        public const string PNABR1 = "PNABR1";

        /// <summary>
        /// PNABT1.
        /// </summary>
        public const string PNABT1 = "PNABT1";

        /// <summary>
        /// PNABR2.
        /// </summary>
        public const string PNABR2 = "PNABR2";

        /// <summary>
        /// PNABT2.
        /// </summary>
        public const string PNABT2 = "PNABT2";

        /// <summary>
        /// PNABR3.
        /// </summary>
        public const string PNABR3 = "PNABR3";

        /// <summary>
        /// PNABT3.
        /// </summary>
        public const string PNABT3 = "PNABT3";

        /// <summary>
        /// PNABR4.
        /// </summary>
        public const string PNABR4 = "PNABR4";

        /// <summary>
        /// PNABT4.
        /// </summary>
        public const string PNABT4 = "PNABT4";

        /// <summary>
        /// PNRTNP.
        /// </summary>
        public const string PNRTNP = "PNRTNP";

        /// <summary>
        /// PNFTNP.
        /// </summary>
        public const string PNFTNP = "PNFTNP";

        /// <summary>
        /// PNMATC.
        /// </summary>
        public const string PNMATC = "PNMATC";

        /// <summary>
        /// PNAN8.
        /// </summary>
        public const string PNAN8 = "PNAN8";

        /// <summary>
        /// PNKCOO.
        /// </summary>
        public const string PNKCOO = "PNKCOO";

        /// <summary>
        /// PNDOCO.
        /// </summary>
        public const string PNDOCO = "PNDOCO";

        /// <summary>
        /// PNDCTO.
        /// </summary>
        public const string PNDCTO = "PNDCTO";

        /// <summary>
        /// PNSFXO.
        /// </summary>
        public const string PNSFXO = "PNSFXO";

        /// <summary>
        /// PNLNID.
        /// </summary>
        public const string PNLNID = "PNLNID";

        /// <summary>
        /// PNNLIN.
        /// </summary>
        public const string PNNLIN = "PNNLIN";

        /// <summary>
        /// PNALIN.
        /// </summary>
        public const string PNALIN = "PNALIN";

        /// <summary>
        /// PNRTBY.
        /// </summary>
        public const string PNRTBY = "PNRTBY";

        /// <summary>
        /// PNDMCT.
        /// </summary>
        public const string PNDMCT = "PNDMCT";

        /// <summary>
        /// PNDMCS.
        /// </summary>
        public const string PNDMCS = "PNDMCS";

        /// <summary>
        /// PNBALU.
        /// </summary>
        public const string PNBALU = "PNBALU";

        /// <summary>
        /// PNITM.
        /// </summary>
        public const string PNITM = "PNITM";

        /// <summary>
        /// PNLITM.
        /// </summary>
        public const string PNLITM = "PNLITM";

        /// <summary>
        /// PNAITM.
        /// </summary>
        public const string PNAITM = "PNAITM";

        /// <summary>
        /// PNIMCU.
        /// </summary>
        public const string PNIMCU = "PNIMCU";

        /// <summary>
        /// PNLOCN.
        /// </summary>
        public const string PNLOCN = "PNLOCN";

        /// <summary>
        /// PNLOTN.
        /// </summary>
        public const string PNLOTN = "PNLOTN";

        /// <summary>
        /// PNLOTG.
        /// </summary>
        public const string PNLOTG = "PNLOTG";

        /// <summary>
        /// PNLOTP.
        /// </summary>
        public const string PNLOTP = "PNLOTP";

        /// <summary>
        /// PNVRMK.
        /// </summary>
        public const string PNVRMK = "PNVRMK";

        /// <summary>
        /// PNCNID.
        /// </summary>
        public const string PNCNID = "PNCNID";

        /// <summary>
        /// PNNXTR.
        /// </summary>
        public const string PNNXTR = "PNNXTR";

        /// <summary>
        /// PNLTTR.
        /// </summary>
        public const string PNLTTR = "PNLTTR";

        /// <summary>
        /// PNTRDJ.
        /// </summary>
        public const string PNTRDJ = "PNTRDJ";

        /// <summary>
        /// PNRCDJ.
        /// </summary>
        public const string PNRCDJ = "PNRCDJ";

        /// <summary>
        /// PNDRQJ.
        /// </summary>
        public const string PNDRQJ = "PNDRQJ";

        /// <summary>
        /// PNPDDJ.
        /// </summary>
        public const string PNPDDJ = "PNPDDJ";

        /// <summary>
        /// PNOPDJ.
        /// </summary>
        public const string PNOPDJ = "PNOPDJ";

        /// <summary>
        /// PNRCD.
        /// </summary>
        public const string PNRCD = "PNRCD";

        /// <summary>
        /// PNVINV.
        /// </summary>
        public const string PNVINV = "PNVINV";

        /// <summary>
        /// PNPTC.
        /// </summary>
        public const string PNPTC = "PNPTC";

        /// <summary>
        /// PNPST.
        /// </summary>
        public const string PNPST = "PNPST";

        /// <summary>
        /// PNLAND.
        /// </summary>
        public const string PNLAND = "PNLAND";

        /// <summary>
        /// PNPRP5.
        /// </summary>
        public const string PNPRP5 = "PNPRP5";

        /// <summary>
        /// PNLVLA.
        /// </summary>
        public const string PNLVLA = "PNLVLA";

        /// <summary>
        /// PNILOG.
        /// </summary>
        public const string PNILOG = "PNILOG";

        /// <summary>
        /// PNDLOG.
        /// </summary>
        public const string PNDLOG = "PNDLOG";

        /// <summary>
        /// PNRTGC.
        /// </summary>
        public const string PNRTGC = "PNRTGC";

        /// <summary>
        /// PNRCPF.
        /// </summary>
        public const string PNRCPF = "PNRCPF";

        /// <summary>
        /// PNAVCH.
        /// </summary>
        public const string PNAVCH = "PNAVCH";

        /// <summary>
        /// PNLNTY.
        /// </summary>
        public const string PNLNTY = "PNLNTY";

        /// <summary>
        /// PNGLC.
        /// </summary>
        public const string PNGLC = "PNGLC";

        /// <summary>
        /// PNMCU.
        /// </summary>
        public const string PNMCU = "PNMCU";

        /// <summary>
        /// PNCO.
        /// </summary>
        public const string PNCO = "PNCO";

        /// <summary>
        /// PNAID.
        /// </summary>
        public const string PNAID = "PNAID";

        /// <summary>
        /// PNANI.
        /// </summary>
        public const string PNANI = "PNANI";

        /// <summary>
        /// PNMACT.
        /// </summary>
        public const string PNMACT = "PNMACT";

        /// <summary>
        /// PNOMCU.
        /// </summary>
        public const string PNOMCU = "PNOMCU";

        /// <summary>
        /// PNOBJ.
        /// </summary>
        public const string PNOBJ = "PNOBJ";

        /// <summary>
        /// PNSUB.
        /// </summary>
        public const string PNSUB = "PNSUB";

        /// <summary>
        /// PNASID.
        /// </summary>
        public const string PNASID = "PNASID";

        /// <summary>
        /// PNSBL.
        /// </summary>
        public const string PNSBL = "PNSBL";

        /// <summary>
        /// PNSBLT.
        /// </summary>
        public const string PNSBLT = "PNSBLT";

        /// <summary>
        /// PNKCO.
        /// </summary>
        public const string PNKCO = "PNKCO";

        /// <summary>
        /// PNDOC.
        /// </summary>
        public const string PNDOC = "PNDOC";

        /// <summary>
        /// PNDCT.
        /// </summary>
        public const string PNDCT = "PNDCT";

        /// <summary>
        /// PNSFX.
        /// </summary>
        public const string PNSFX = "PNSFX";

        /// <summary>
        /// PNDGL.
        /// </summary>
        public const string PNDGL = "PNDGL";

        /// <summary>
        /// PNJELN.
        /// </summary>
        public const string PNJELN = "PNJELN";

        /// <summary>
        /// PNVANI.
        /// </summary>
        public const string PNVANI = "PNVANI";

        /// <summary>
        /// PNTX.
        /// </summary>
        public const string PNTX = "PNTX";

        /// <summary>
        /// PNEXR1.
        /// </summary>
        public const string PNEXR1 = "PNEXR1";

        /// <summary>
        /// PNTXA1.
        /// </summary>
        public const string PNTXA1 = "PNTXA1";

        /// <summary>
        /// PNUOM.
        /// </summary>
        public const string PNUOM = "PNUOM";

        /// <summary>
        /// PNUORG.
        /// </summary>
        public const string PNUORG = "PNUORG";

        /// <summary>
        /// PNUPTD.
        /// </summary>
        public const string PNUPTD = "PNUPTD";

        /// <summary>
        /// PNUOPN.
        /// </summary>
        public const string PNUOPN = "PNUOPN";

        /// <summary>
        /// PNUREC.
        /// </summary>
        public const string PNUREC = "PNUREC";

        /// <summary>
        /// PNUCLO.
        /// </summary>
        public const string PNUCLO = "PNUCLO";

        /// <summary>
        /// PNQTYS.
        /// </summary>
        public const string PNQTYS = "PNQTYS";

        /// <summary>
        /// PNQTYR.
        /// </summary>
        public const string PNQTYR = "PNQTYR";

        /// <summary>
        /// PNQTYW.
        /// </summary>
        public const string PNQTYW = "PNQTYW";

        /// <summary>
        /// PNQTYC.
        /// </summary>
        public const string PNQTYC = "PNQTYC";

        /// <summary>
        /// PNQTYJ.
        /// </summary>
        public const string PNQTYJ = "PNQTYJ";

        /// <summary>
        /// PNQTYA.
        /// </summary>
        public const string PNQTYA = "PNQTYA";

        /// <summary>
        /// PNUOM3.
        /// </summary>
        public const string PNUOM3 = "PNUOM3";

        /// <summary>
        /// PNPRRC.
        /// </summary>
        public const string PNPRRC = "PNPRRC";

        /// <summary>
        /// PNECST.
        /// </summary>
        public const string PNECST = "PNECST";

        /// <summary>
        /// PNAPTD.
        /// </summary>
        public const string PNAPTD = "PNAPTD";

        /// <summary>
        /// PNAOPN.
        /// </summary>
        public const string PNAOPN = "PNAOPN";

        /// <summary>
        /// PNAREC.
        /// </summary>
        public const string PNAREC = "PNAREC";

        /// <summary>
        /// PNACLO.
        /// </summary>
        public const string PNACLO = "PNACLO";

        /// <summary>
        /// PNAVCO.
        /// </summary>
        public const string PNAVCO = "PNAVCO";

        /// <summary>
        /// PNVARC.
        /// </summary>
        public const string PNVARC = "PNVARC";

        /// <summary>
        /// PNCRCD.
        /// </summary>
        public const string PNCRCD = "PNCRCD";

        /// <summary>
        /// PNCRR.
        /// </summary>
        public const string PNCRR = "PNCRR";

        /// <summary>
        /// PNFRRC.
        /// </summary>
        public const string PNFRRC = "PNFRRC";

        /// <summary>
        /// PNFEC.
        /// </summary>
        public const string PNFEC = "PNFEC";

        /// <summary>
        /// PNFAP.
        /// </summary>
        public const string PNFAP = "PNFAP";

        /// <summary>
        /// PNFAPT.
        /// </summary>
        public const string PNFAPT = "PNFAPT";

        /// <summary>
        /// PNFREC.
        /// </summary>
        public const string PNFREC = "PNFREC";

        /// <summary>
        /// PNFCLO.
        /// </summary>
        public const string PNFCLO = "PNFCLO";

        /// <summary>
        /// PNADWT.
        /// </summary>
        public const string PNADWT = "PNADWT";

        /// <summary>
        /// PNURCD.
        /// </summary>
        public const string PNURCD = "PNURCD";

        /// <summary>
        /// PNURDT.
        /// </summary>
        public const string PNURDT = "PNURDT";

        /// <summary>
        /// PNURAT.
        /// </summary>
        public const string PNURAT = "PNURAT";

        /// <summary>
        /// PNURAB.
        /// </summary>
        public const string PNURAB = "PNURAB";

        /// <summary>
        /// PNURRF.
        /// </summary>
        public const string PNURRF = "PNURRF";

        /// <summary>
        /// PNTORG.
        /// </summary>
        public const string PNTORG = "PNTORG";

        /// <summary>
        /// PNPEID.
        /// </summary>
        public const string PNPEID = "PNPEID";

        /// <summary>
        /// PNTCID.
        /// </summary>
        public const string PNTCID = "PNTCID";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNTERM.
        /// </summary>
        public const string PNTERM = "PNTERM";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNTDAY.
        /// </summary>
        public const string PNTDAY = "PNTDAY";

        /// <summary>
        /// PNJBCD.
        /// </summary>
        public const string PNJBCD = "PNJBCD";

        /// <summary>
        /// PNSRQTY.
        /// </summary>
        public const string PNSRQTY = "PNSRQTY";

        /// <summary>
        /// PNSRUOM.
        /// </summary>
        public const string PNSRUOM = "PNSRUOM";

        /// <summary>
        /// PNNBRU.
        /// </summary>
        public const string PNNBRU = "PNNBRU";

        /// <summary>
        /// PNNEWR.
        /// </summary>
        public const string PNNEWR = "PNNEWR";
    }

    /// <inheritdoc />
    public override string TableName => "F4314Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNCTID", "PNCTID", JdeDataType.String, 30, true, true),
        new JdeField("PNJOBS", "PNJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PNXTLN", "PNXTLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PNDLNID", "PNDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PNACTN", "PNACTN", JdeDataType.String, 2),
        new JdeField("PNEDFL", "PNEDFL", JdeDataType.String, 2),
        new JdeField("PNMAPR", "PNMAPR", JdeDataType.String, 2),
        new JdeField("PNPCR", "PNPCR", JdeDataType.Numeric),
        new JdeField("PNDSC1", "PNDSC1", JdeDataType.String, 60),
        new JdeField("PNDSC2", "PNDSC2", JdeDataType.String, 60),
        new JdeField("PNUITM", "PNUITM", JdeDataType.String, 52),
        new JdeField("PNFLSH", "PNFLSH", JdeDataType.String, 80),
        new JdeField("PNCITM", "PNCITM", JdeDataType.String, 50),
        new JdeField("PNIVI", "PNIVI", JdeDataType.String, 2),
        new JdeField("PNSTKT", "PNSTKT", JdeDataType.String, 2),
        new JdeField("PNCLEV", "PNCLEV", JdeDataType.String, 2),
        new JdeField("PNCONV", "PNCONV", JdeDataType.Numeric),
        new JdeField("PNCNV2", "PNCNV2", JdeDataType.Numeric),
        new JdeField("PNJEL1", "PNJEL1", JdeDataType.Numeric),
        new JdeField("PNRWT1", "PNRWT1", JdeDataType.String, 2),
        new JdeField("PNJEL2", "PNJEL2", JdeDataType.Numeric),
        new JdeField("PNRWT2", "PNRWT2", JdeDataType.String, 2),
        new JdeField("PNJEL3", "PNJEL3", JdeDataType.Numeric),
        new JdeField("PNRWT3", "PNRWT3", JdeDataType.String, 2),
        new JdeField("PNJEL4", "PNJEL4", JdeDataType.Numeric),
        new JdeField("PNRWT4", "PNRWT4", JdeDataType.String, 2),
        new JdeField("PNJEL5", "PNJEL5", JdeDataType.Numeric),
        new JdeField("PNRWT5", "PNRWT5", JdeDataType.String, 2),
        new JdeField("PNJEL6", "PNJEL6", JdeDataType.Numeric),
        new JdeField("PNRWT6", "PNRWT6", JdeDataType.String, 2),
        new JdeField("PNJEL7", "PNJEL7", JdeDataType.Numeric),
        new JdeField("PNRWT7", "PNRWT7", JdeDataType.String, 2),
        new JdeField("PNRWT8", "PNRWT8", JdeDataType.String, 2),
        new JdeField("PNJEL8", "PNJEL8", JdeDataType.Numeric),
        new JdeField("PNRWT9", "PNRWT9", JdeDataType.String, 2),
        new JdeField("PNJEL9", "PNJEL9", JdeDataType.Numeric),
        new JdeField("PNRWTA", "PNRWTA", JdeDataType.String, 2),
        new JdeField("PNRWTB", "PNRWTB", JdeDataType.String, 2),
        new JdeField("PNRWTD", "PNRWTD", JdeDataType.String, 2),
        new JdeField("PNRWTE", "PNRWTE", JdeDataType.String, 2),
        new JdeField("PNRWTF", "PNRWTF", JdeDataType.String, 2),
        new JdeField("PNRWTG", "PNRWTG", JdeDataType.String, 2),
        new JdeField("PNACIT", "PNACIT", JdeDataType.String, 2),
        new JdeField("PNBANI", "PNBANI", JdeDataType.String, 58),
        new JdeField("PNSTAM", "PNSTAM", JdeDataType.Numeric),
        new JdeField("PNSTA1", "PNSTA1", JdeDataType.Numeric),
        new JdeField("PNSTA2", "PNSTA2", JdeDataType.Numeric),
        new JdeField("PNDDNJ", "PNDDNJ", JdeDataType.Numeric),
        new JdeField("PNAC07", "PNAC07", JdeDataType.String, 6),
        new JdeField("PNDDJ", "PNDDJ", JdeDataType.Numeric),
        new JdeField("PNADSC", "PNADSC", JdeDataType.Numeric),
        new JdeField("PNATXA", "PNATXA", JdeDataType.Numeric),
        new JdeField("PNAG", "PNAG", JdeDataType.Numeric),
        new JdeField("PNACR", "PNACR", JdeDataType.Numeric),
        new JdeField("PNCDS", "PNCDS", JdeDataType.Numeric),
        new JdeField("PNCTAM", "PNCTAM", JdeDataType.Numeric),
        new JdeField("PNCTXA", "PNCTXA", JdeDataType.Numeric),
        new JdeField("PNCRC", "PNCRC", JdeDataType.String, 6),
        new JdeField("PNPYE", "PNPYE", JdeDataType.Numeric),
        new JdeField("PNAPC", "PNAPC", JdeDataType.String, 8),
        new JdeField("PNRMK", "PNRMK", JdeDataType.String, 60),
        new JdeField("PNTNN", "PNTNN", JdeDataType.String, 2),
        new JdeField("PNATAD", "PNATAD", JdeDataType.Numeric),
        new JdeField("PNCTAD", "PNCTAD", JdeDataType.Numeric),
        new JdeField("PNUPAD", "PNUPAD", JdeDataType.Numeric),
        new JdeField("PNCRRD", "PNCRRD", JdeDataType.Numeric),
        new JdeField("PNUNCS", "PNUNCS", JdeDataType.Numeric),
        new JdeField("PNFUC", "PNFUC", JdeDataType.Numeric),
        new JdeField("PNAEXP", "PNAEXP", JdeDataType.Numeric),
        new JdeField("PNFEA", "PNFEA", JdeDataType.Numeric),
        new JdeField("PNPCRT", "PNPCRT", JdeDataType.Numeric),
        new JdeField("PNRETA", "PNRETA", JdeDataType.Numeric),
        new JdeField("PNRETT", "PNRETT", JdeDataType.Numeric),
        new JdeField("PNREFA", "PNREFA", JdeDataType.Numeric),
        new JdeField("PNREFT", "PNREFT", JdeDataType.Numeric),
        new JdeField("PNU", "PNU", JdeDataType.Numeric),
        new JdeField("PNAA", "PNAA", JdeDataType.Numeric),
        new JdeField("PNFAA", "PNFAA", JdeDataType.Numeric),
        new JdeField("PNAA1", "PNAA1", JdeDataType.Numeric),
        new JdeField("PNAA2", "PNAA2", JdeDataType.Numeric),
        new JdeField("PNAN01", "PNAN01", JdeDataType.Numeric),
        new JdeField("PNAN02", "PNAN02", JdeDataType.Numeric),
        new JdeField("PNBCT1", "PNBCT1", JdeDataType.String, 2),
        new JdeField("PNBCT2", "PNBCT2", JdeDataType.String, 2),
        new JdeField("PNTRR1", "PNTRR1", JdeDataType.Numeric),
        new JdeField("PNTRR2", "PNTRR2", JdeDataType.Numeric),
        new JdeField("PNTRD1", "PNTRD1", JdeDataType.Numeric),
        new JdeField("PNTRD2", "PNTRD2", JdeDataType.Numeric),
        new JdeField("PNCRCM", "PNCRCM", JdeDataType.String, 2),
        new JdeField("PNABR1", "PNABR1", JdeDataType.String, 24),
        new JdeField("PNABT1", "PNABT1", JdeDataType.String, 2),
        new JdeField("PNABR2", "PNABR2", JdeDataType.String, 24),
        new JdeField("PNABT2", "PNABT2", JdeDataType.String, 2),
        new JdeField("PNABR3", "PNABR3", JdeDataType.String, 24),
        new JdeField("PNABT3", "PNABT3", JdeDataType.String, 2),
        new JdeField("PNABR4", "PNABR4", JdeDataType.String, 24),
        new JdeField("PNABT4", "PNABT4", JdeDataType.String, 2),
        new JdeField("PNRTNP", "PNRTNP", JdeDataType.Numeric),
        new JdeField("PNFTNP", "PNFTNP", JdeDataType.Numeric),
        new JdeField("PNMATC", "PNMATC", JdeDataType.String, 2),
        new JdeField("PNAN8", "PNAN8", JdeDataType.Numeric),
        new JdeField("PNKCOO", "PNKCOO", JdeDataType.String, 10),
        new JdeField("PNDOCO", "PNDOCO", JdeDataType.Numeric),
        new JdeField("PNDCTO", "PNDCTO", JdeDataType.String, 4),
        new JdeField("PNSFXO", "PNSFXO", JdeDataType.String, 6),
        new JdeField("PNLNID", "PNLNID", JdeDataType.Numeric),
        new JdeField("PNNLIN", "PNNLIN", JdeDataType.Numeric),
        new JdeField("PNALIN", "PNALIN", JdeDataType.Numeric),
        new JdeField("PNRTBY", "PNRTBY", JdeDataType.String, 4),
        new JdeField("PNDMCT", "PNDMCT", JdeDataType.String, 24),
        new JdeField("PNDMCS", "PNDMCS", JdeDataType.Numeric),
        new JdeField("PNBALU", "PNBALU", JdeDataType.String, 2),
        new JdeField("PNITM", "PNITM", JdeDataType.Numeric),
        new JdeField("PNLITM", "PNLITM", JdeDataType.String, 50),
        new JdeField("PNAITM", "PNAITM", JdeDataType.String, 50),
        new JdeField("PNIMCU", "PNIMCU", JdeDataType.String, 24),
        new JdeField("PNLOCN", "PNLOCN", JdeDataType.String, 40),
        new JdeField("PNLOTN", "PNLOTN", JdeDataType.String, 60),
        new JdeField("PNLOTG", "PNLOTG", JdeDataType.String, 6),
        new JdeField("PNLOTP", "PNLOTP", JdeDataType.Numeric),
        new JdeField("PNVRMK", "PNVRMK", JdeDataType.String, 60),
        new JdeField("PNCNID", "PNCNID", JdeDataType.String, 40),
        new JdeField("PNNXTR", "PNNXTR", JdeDataType.String, 6),
        new JdeField("PNLTTR", "PNLTTR", JdeDataType.String, 6),
        new JdeField("PNTRDJ", "PNTRDJ", JdeDataType.Numeric),
        new JdeField("PNRCDJ", "PNRCDJ", JdeDataType.Numeric),
        new JdeField("PNDRQJ", "PNDRQJ", JdeDataType.Numeric),
        new JdeField("PNPDDJ", "PNPDDJ", JdeDataType.Numeric),
        new JdeField("PNOPDJ", "PNOPDJ", JdeDataType.Numeric),
        new JdeField("PNRCD", "PNRCD", JdeDataType.String, 6),
        new JdeField("PNVINV", "PNVINV", JdeDataType.String, 50),
        new JdeField("PNPTC", "PNPTC", JdeDataType.String, 6),
        new JdeField("PNPST", "PNPST", JdeDataType.String, 2),
        new JdeField("PNLAND", "PNLAND", JdeDataType.String, 2),
        new JdeField("PNPRP5", "PNPRP5", JdeDataType.String, 6),
        new JdeField("PNLVLA", "PNLVLA", JdeDataType.String, 6),
        new JdeField("PNILOG", "PNILOG", JdeDataType.String, 2),
        new JdeField("PNDLOG", "PNDLOG", JdeDataType.String, 2),
        new JdeField("PNRTGC", "PNRTGC", JdeDataType.String, 2),
        new JdeField("PNRCPF", "PNRCPF", JdeDataType.String, 2),
        new JdeField("PNAVCH", "PNAVCH", JdeDataType.String, 2),
        new JdeField("PNLNTY", "PNLNTY", JdeDataType.String, 4),
        new JdeField("PNGLC", "PNGLC", JdeDataType.String, 8),
        new JdeField("PNMCU", "PNMCU", JdeDataType.String, 24),
        new JdeField("PNCO", "PNCO", JdeDataType.String, 10),
        new JdeField("PNAID", "PNAID", JdeDataType.String, 16),
        new JdeField("PNANI", "PNANI", JdeDataType.String, 58),
        new JdeField("PNMACT", "PNMACT", JdeDataType.String, 2),
        new JdeField("PNOMCU", "PNOMCU", JdeDataType.String, 24),
        new JdeField("PNOBJ", "PNOBJ", JdeDataType.String, 12),
        new JdeField("PNSUB", "PNSUB", JdeDataType.String, 16),
        new JdeField("PNASID", "PNASID", JdeDataType.String, 50),
        new JdeField("PNSBL", "PNSBL", JdeDataType.String, 16),
        new JdeField("PNSBLT", "PNSBLT", JdeDataType.String, 2),
        new JdeField("PNKCO", "PNKCO", JdeDataType.String, 10),
        new JdeField("PNDOC", "PNDOC", JdeDataType.Numeric),
        new JdeField("PNDCT", "PNDCT", JdeDataType.String, 4),
        new JdeField("PNSFX", "PNSFX", JdeDataType.String, 6),
        new JdeField("PNDGL", "PNDGL", JdeDataType.Numeric),
        new JdeField("PNJELN", "PNJELN", JdeDataType.Numeric),
        new JdeField("PNVANI", "PNVANI", JdeDataType.String, 58),
        new JdeField("PNTX", "PNTX", JdeDataType.String, 2),
        new JdeField("PNEXR1", "PNEXR1", JdeDataType.String, 4),
        new JdeField("PNTXA1", "PNTXA1", JdeDataType.String, 20),
        new JdeField("PNUOM", "PNUOM", JdeDataType.String, 4),
        new JdeField("PNUORG", "PNUORG", JdeDataType.Numeric),
        new JdeField("PNUPTD", "PNUPTD", JdeDataType.Numeric),
        new JdeField("PNUOPN", "PNUOPN", JdeDataType.Numeric),
        new JdeField("PNUREC", "PNUREC", JdeDataType.Numeric),
        new JdeField("PNUCLO", "PNUCLO", JdeDataType.Numeric),
        new JdeField("PNQTYS", "PNQTYS", JdeDataType.Numeric),
        new JdeField("PNQTYR", "PNQTYR", JdeDataType.Numeric),
        new JdeField("PNQTYW", "PNQTYW", JdeDataType.Numeric),
        new JdeField("PNQTYC", "PNQTYC", JdeDataType.Numeric),
        new JdeField("PNQTYJ", "PNQTYJ", JdeDataType.Numeric),
        new JdeField("PNQTYA", "PNQTYA", JdeDataType.Numeric),
        new JdeField("PNUOM3", "PNUOM3", JdeDataType.String, 4),
        new JdeField("PNPRRC", "PNPRRC", JdeDataType.Numeric),
        new JdeField("PNECST", "PNECST", JdeDataType.Numeric),
        new JdeField("PNAPTD", "PNAPTD", JdeDataType.Numeric),
        new JdeField("PNAOPN", "PNAOPN", JdeDataType.Numeric),
        new JdeField("PNAREC", "PNAREC", JdeDataType.Numeric),
        new JdeField("PNACLO", "PNACLO", JdeDataType.Numeric),
        new JdeField("PNAVCO", "PNAVCO", JdeDataType.Numeric),
        new JdeField("PNVARC", "PNVARC", JdeDataType.Numeric),
        new JdeField("PNCRCD", "PNCRCD", JdeDataType.String, 6),
        new JdeField("PNCRR", "PNCRR", JdeDataType.Numeric),
        new JdeField("PNFRRC", "PNFRRC", JdeDataType.Numeric),
        new JdeField("PNFEC", "PNFEC", JdeDataType.Numeric),
        new JdeField("PNFAP", "PNFAP", JdeDataType.Numeric),
        new JdeField("PNFAPT", "PNFAPT", JdeDataType.Numeric),
        new JdeField("PNFREC", "PNFREC", JdeDataType.Numeric),
        new JdeField("PNFCLO", "PNFCLO", JdeDataType.Numeric),
        new JdeField("PNADWT", "PNADWT", JdeDataType.Numeric),
        new JdeField("PNURCD", "PNURCD", JdeDataType.String, 4),
        new JdeField("PNURDT", "PNURDT", JdeDataType.Numeric),
        new JdeField("PNURAT", "PNURAT", JdeDataType.Numeric),
        new JdeField("PNURAB", "PNURAB", JdeDataType.Numeric),
        new JdeField("PNURRF", "PNURRF", JdeDataType.String, 30),
        new JdeField("PNTORG", "PNTORG", JdeDataType.String, 20),
        new JdeField("PNPEID", "PNPEID", JdeDataType.Numeric),
        new JdeField("PNTCID", "PNTCID", JdeDataType.Numeric),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNTERM", "PNTERM", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNTDAY", "PNTDAY", JdeDataType.Numeric),
        new JdeField("PNJBCD", "PNJBCD", JdeDataType.String, 12),
        new JdeField("PNSRQTY", "PNSRQTY", JdeDataType.Numeric),
        new JdeField("PNSRUOM", "PNSRUOM", JdeDataType.String, 4),
        new JdeField("PNNBRU", "PNNBRU", JdeDataType.String, 2),
        new JdeField("PNNEWR", "PNNEWR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4314Z_0", "Primary Key on PNCTID, PNJOBS, PNXTLN, PNDLNID", new[] { "PNCTID", "PNJOBS", "PNXTLN", "PNDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4314Z_2", "Index on PNDOCO, PNDCTO, PNKCOO, PNSFXO, PNLNID, PNMATC, PNNLIN", new[] { "PNDOCO", "PNDCTO", "PNKCOO", "PNSFXO", "PNLNID", "PNMATC", "PNNLIN" })
    };
}
