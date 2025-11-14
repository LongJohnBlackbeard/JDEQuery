using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101Z1 - .
/// </summary>
public class F4101Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZITBR.
        /// </summary>
        public const string SZITBR = "SZITBR";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZKIT.
        /// </summary>
        public const string SZKIT = "SZKIT";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZSRTX.
        /// </summary>
        public const string SZSRTX = "SZSRTX";

        /// <summary>
        /// SZALN.
        /// </summary>
        public const string SZALN = "SZALN";

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
        /// SZSRP6.
        /// </summary>
        public const string SZSRP6 = "SZSRP6";

        /// <summary>
        /// SZSRP7.
        /// </summary>
        public const string SZSRP7 = "SZSRP7";

        /// <summary>
        /// SZSRP8.
        /// </summary>
        public const string SZSRP8 = "SZSRP8";

        /// <summary>
        /// SZSRP9.
        /// </summary>
        public const string SZSRP9 = "SZSRP9";

        /// <summary>
        /// SZSRP0.
        /// </summary>
        public const string SZSRP0 = "SZSRP0";

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
        /// SZPRP6.
        /// </summary>
        public const string SZPRP6 = "SZPRP6";

        /// <summary>
        /// SZPRP7.
        /// </summary>
        public const string SZPRP7 = "SZPRP7";

        /// <summary>
        /// SZPRP8.
        /// </summary>
        public const string SZPRP8 = "SZPRP8";

        /// <summary>
        /// SZPRP9.
        /// </summary>
        public const string SZPRP9 = "SZPRP9";

        /// <summary>
        /// SZPRP0.
        /// </summary>
        public const string SZPRP0 = "SZPRP0";

        /// <summary>
        /// SZCDCD.
        /// </summary>
        public const string SZCDCD = "SZCDCD";

        /// <summary>
        /// SZPDGR.
        /// </summary>
        public const string SZPDGR = "SZPDGR";

        /// <summary>
        /// SZDSGP.
        /// </summary>
        public const string SZDSGP = "SZDSGP";

        /// <summary>
        /// SZPRGR.
        /// </summary>
        public const string SZPRGR = "SZPRGR";

        /// <summary>
        /// SZRPRC.
        /// </summary>
        public const string SZRPRC = "SZRPRC";

        /// <summary>
        /// SZORPR.
        /// </summary>
        public const string SZORPR = "SZORPR";

        /// <summary>
        /// SZBUYR.
        /// </summary>
        public const string SZBUYR = "SZBUYR";

        /// <summary>
        /// SZDRAW.
        /// </summary>
        public const string SZDRAW = "SZDRAW";

        /// <summary>
        /// SZRVNO.
        /// </summary>
        public const string SZRVNO = "SZRVNO";

        /// <summary>
        /// SZDSZE.
        /// </summary>
        public const string SZDSZE = "SZDSZE";

        /// <summary>
        /// SZVCUD.
        /// </summary>
        public const string SZVCUD = "SZVCUD";

        /// <summary>
        /// SZCARS.
        /// </summary>
        public const string SZCARS = "SZCARS";

        /// <summary>
        /// SZCARP.
        /// </summary>
        public const string SZCARP = "SZCARP";

        /// <summary>
        /// SZSHCN.
        /// </summary>
        public const string SZSHCN = "SZSHCN";

        /// <summary>
        /// SZSHCM.
        /// </summary>
        public const string SZSHCM = "SZSHCM";

        /// <summary>
        /// SZUOM1.
        /// </summary>
        public const string SZUOM1 = "SZUOM1";

        /// <summary>
        /// SZUOM2.
        /// </summary>
        public const string SZUOM2 = "SZUOM2";

        /// <summary>
        /// SZUOM3.
        /// </summary>
        public const string SZUOM3 = "SZUOM3";

        /// <summary>
        /// SZUOM4.
        /// </summary>
        public const string SZUOM4 = "SZUOM4";

        /// <summary>
        /// SZUOM6.
        /// </summary>
        public const string SZUOM6 = "SZUOM6";

        /// <summary>
        /// SZUOM8.
        /// </summary>
        public const string SZUOM8 = "SZUOM8";

        /// <summary>
        /// SZUOM9.
        /// </summary>
        public const string SZUOM9 = "SZUOM9";

        /// <summary>
        /// SZUWUM.
        /// </summary>
        public const string SZUWUM = "SZUWUM";

        /// <summary>
        /// SZUVM1.
        /// </summary>
        public const string SZUVM1 = "SZUVM1";

        /// <summary>
        /// SZSUTM.
        /// </summary>
        public const string SZSUTM = "SZSUTM";

        /// <summary>
        /// SZUMVW.
        /// </summary>
        public const string SZUMVW = "SZUMVW";

        /// <summary>
        /// SZCYCL.
        /// </summary>
        public const string SZCYCL = "SZCYCL";

        /// <summary>
        /// SZGLPT.
        /// </summary>
        public const string SZGLPT = "SZGLPT";

        /// <summary>
        /// SZPLEV.
        /// </summary>
        public const string SZPLEV = "SZPLEV";

        /// <summary>
        /// SZPPLV.
        /// </summary>
        public const string SZPPLV = "SZPPLV";

        /// <summary>
        /// SZCLEV.
        /// </summary>
        public const string SZCLEV = "SZCLEV";

        /// <summary>
        /// SZPRPO.
        /// </summary>
        public const string SZPRPO = "SZPRPO";

        /// <summary>
        /// SZCKAV.
        /// </summary>
        public const string SZCKAV = "SZCKAV";

        /// <summary>
        /// SZBPFG.
        /// </summary>
        public const string SZBPFG = "SZBPFG";

        /// <summary>
        /// SZSRCE.
        /// </summary>
        public const string SZSRCE = "SZSRCE";

        /// <summary>
        /// SZOT1Y.
        /// </summary>
        public const string SZOT1Y = "SZOT1Y";

        /// <summary>
        /// SZOT2Y.
        /// </summary>
        public const string SZOT2Y = "SZOT2Y";

        /// <summary>
        /// SZSTDP.
        /// </summary>
        public const string SZSTDP = "SZSTDP";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZTHRP.
        /// </summary>
        public const string SZTHRP = "SZTHRP";

        /// <summary>
        /// SZSTDG.
        /// </summary>
        public const string SZSTDG = "SZSTDG";

        /// <summary>
        /// SZFRGD.
        /// </summary>
        public const string SZFRGD = "SZFRGD";

        /// <summary>
        /// SZTHGD.
        /// </summary>
        public const string SZTHGD = "SZTHGD";

        /// <summary>
        /// SZCOTY.
        /// </summary>
        public const string SZCOTY = "SZCOTY";

        /// <summary>
        /// SZSTKT.
        /// </summary>
        public const string SZSTKT = "SZSTKT";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZCONT.
        /// </summary>
        public const string SZCONT = "SZCONT";

        /// <summary>
        /// SZBACK.
        /// </summary>
        public const string SZBACK = "SZBACK";

        /// <summary>
        /// SZIFLA.
        /// </summary>
        public const string SZIFLA = "SZIFLA";

        /// <summary>
        /// SZTFLA.
        /// </summary>
        public const string SZTFLA = "SZTFLA";

        /// <summary>
        /// SZINMG.
        /// </summary>
        public const string SZINMG = "SZINMG";

        /// <summary>
        /// SZABCS.
        /// </summary>
        public const string SZABCS = "SZABCS";

        /// <summary>
        /// SZABCM.
        /// </summary>
        public const string SZABCM = "SZABCM";

        /// <summary>
        /// SZABCI.
        /// </summary>
        public const string SZABCI = "SZABCI";

        /// <summary>
        /// SZOVR.
        /// </summary>
        public const string SZOVR = "SZOVR";

        /// <summary>
        /// SZWARR.
        /// </summary>
        public const string SZWARR = "SZWARR";

        /// <summary>
        /// SZCMCG.
        /// </summary>
        public const string SZCMCG = "SZCMCG";

        /// <summary>
        /// SZSRNR.
        /// </summary>
        public const string SZSRNR = "SZSRNR";

        /// <summary>
        /// SZPMTH.
        /// </summary>
        public const string SZPMTH = "SZPMTH";

        /// <summary>
        /// SZFIFO.
        /// </summary>
        public const string SZFIFO = "SZFIFO";

        /// <summary>
        /// SZLOTS.
        /// </summary>
        public const string SZLOTS = "SZLOTS";

        /// <summary>
        /// SZSLD.
        /// </summary>
        public const string SZSLD = "SZSLD";

        /// <summary>
        /// SZANPL.
        /// </summary>
        public const string SZANPL = "SZANPL";

        /// <summary>
        /// SZMPST.
        /// </summary>
        public const string SZMPST = "SZMPST";

        /// <summary>
        /// SZPCTM.
        /// </summary>
        public const string SZPCTM = "SZPCTM";

        /// <summary>
        /// SZMMPC.
        /// </summary>
        public const string SZMMPC = "SZMMPC";

        /// <summary>
        /// SZPTSC.
        /// </summary>
        public const string SZPTSC = "SZPTSC";

        /// <summary>
        /// SZSNS.
        /// </summary>
        public const string SZSNS = "SZSNS";

        /// <summary>
        /// SZLTLV.
        /// </summary>
        public const string SZLTLV = "SZLTLV";

        /// <summary>
        /// SZLTMF.
        /// </summary>
        public const string SZLTMF = "SZLTMF";

        /// <summary>
        /// SZLTCM.
        /// </summary>
        public const string SZLTCM = "SZLTCM";

        /// <summary>
        /// SZOPC.
        /// </summary>
        public const string SZOPC = "SZOPC";

        /// <summary>
        /// SZOPV.
        /// </summary>
        public const string SZOPV = "SZOPV";

        /// <summary>
        /// SZACQ.
        /// </summary>
        public const string SZACQ = "SZACQ";

        /// <summary>
        /// SZMLQ.
        /// </summary>
        public const string SZMLQ = "SZMLQ";

        /// <summary>
        /// SZLTPU.
        /// </summary>
        public const string SZLTPU = "SZLTPU";

        /// <summary>
        /// SZMPSP.
        /// </summary>
        public const string SZMPSP = "SZMPSP";

        /// <summary>
        /// SZMRPP.
        /// </summary>
        public const string SZMRPP = "SZMRPP";

        /// <summary>
        /// SZITC.
        /// </summary>
        public const string SZITC = "SZITC";

        /// <summary>
        /// SZORDW.
        /// </summary>
        public const string SZORDW = "SZORDW";

        /// <summary>
        /// SZMTF1.
        /// </summary>
        public const string SZMTF1 = "SZMTF1";

        /// <summary>
        /// SZMTF2.
        /// </summary>
        public const string SZMTF2 = "SZMTF2";

        /// <summary>
        /// SZMTF3.
        /// </summary>
        public const string SZMTF3 = "SZMTF3";

        /// <summary>
        /// SZMTF4.
        /// </summary>
        public const string SZMTF4 = "SZMTF4";

        /// <summary>
        /// SZMTF5.
        /// </summary>
        public const string SZMTF5 = "SZMTF5";

        /// <summary>
        /// SZEXPD.
        /// </summary>
        public const string SZEXPD = "SZEXPD";

        /// <summary>
        /// SZDEFD.
        /// </summary>
        public const string SZDEFD = "SZDEFD";

        /// <summary>
        /// SZSFLT.
        /// </summary>
        public const string SZSFLT = "SZSFLT";

        /// <summary>
        /// SZMAKE.
        /// </summary>
        public const string SZMAKE = "SZMAKE";

        /// <summary>
        /// SZCOBY.
        /// </summary>
        public const string SZCOBY = "SZCOBY";

        /// <summary>
        /// SZLLX.
        /// </summary>
        public const string SZLLX = "SZLLX";

        /// <summary>
        /// SZCMGL.
        /// </summary>
        public const string SZCMGL = "SZCMGL";

        /// <summary>
        /// SZCOMH.
        /// </summary>
        public const string SZCOMH = "SZCOMH";

        /// <summary>
        /// SZAVRT.
        /// </summary>
        public const string SZAVRT = "SZAVRT";

        /// <summary>
        /// SZUPCN.
        /// </summary>
        public const string SZUPCN = "SZUPCN";

        /// <summary>
        /// SZSCC0.
        /// </summary>
        public const string SZSCC0 = "SZSCC0";

        /// <summary>
        /// SZUMDF.
        /// </summary>
        public const string SZUMDF = "SZUMDF";

        /// <summary>
        /// SZUMS0.
        /// </summary>
        public const string SZUMS0 = "SZUMS0";

        /// <summary>
        /// SZUMUP.
        /// </summary>
        public const string SZUMUP = "SZUMUP";

        /// <summary>
        /// SZUMS1.
        /// </summary>
        public const string SZUMS1 = "SZUMS1";

        /// <summary>
        /// SZUMS2.
        /// </summary>
        public const string SZUMS2 = "SZUMS2";

        /// <summary>
        /// SZUMS3.
        /// </summary>
        public const string SZUMS3 = "SZUMS3";

        /// <summary>
        /// SZUMS4.
        /// </summary>
        public const string SZUMS4 = "SZUMS4";

        /// <summary>
        /// SZUMS5.
        /// </summary>
        public const string SZUMS5 = "SZUMS5";

        /// <summary>
        /// SZUMS6.
        /// </summary>
        public const string SZUMS6 = "SZUMS6";

        /// <summary>
        /// SZUMS7.
        /// </summary>
        public const string SZUMS7 = "SZUMS7";

        /// <summary>
        /// SZUMS8.
        /// </summary>
        public const string SZUMS8 = "SZUMS8";

        /// <summary>
        /// SZWTRQ.
        /// </summary>
        public const string SZWTRQ = "SZWTRQ";

        /// <summary>
        /// SZEQTY.
        /// </summary>
        public const string SZEQTY = "SZEQTY";

        /// <summary>
        /// SZPOC.
        /// </summary>
        public const string SZPOC = "SZPOC";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZVEND.
        /// </summary>
        public const string SZVEND = "SZVEND";

        /// <summary>
        /// SZORIG.
        /// </summary>
        public const string SZORIG = "SZORIG";

        /// <summary>
        /// SZROPI.
        /// </summary>
        public const string SZROPI = "SZROPI";

        /// <summary>
        /// SZROQI.
        /// </summary>
        public const string SZROQI = "SZROQI";

        /// <summary>
        /// SZRQMX.
        /// </summary>
        public const string SZRQMX = "SZRQMX";

        /// <summary>
        /// SZRQMN.
        /// </summary>
        public const string SZRQMN = "SZRQMN";

        /// <summary>
        /// SZWOMO.
        /// </summary>
        public const string SZWOMO = "SZWOMO";

        /// <summary>
        /// SZSERV.
        /// </summary>
        public const string SZSERV = "SZSERV";

        /// <summary>
        /// SZSAFE.
        /// </summary>
        public const string SZSAFE = "SZSAFE";

        /// <summary>
        /// SZFUF1.
        /// </summary>
        public const string SZFUF1 = "SZFUF1";

        /// <summary>
        /// SZTX.
        /// </summary>
        public const string SZTX = "SZTX";

        /// <summary>
        /// SZTAX1.
        /// </summary>
        public const string SZTAX1 = "SZTAX1";

        /// <summary>
        /// SZMRPD.
        /// </summary>
        public const string SZMRPD = "SZMRPD";

        /// <summary>
        /// SZMRPC.
        /// </summary>
        public const string SZMRPC = "SZMRPC";

        /// <summary>
        /// SZUPC.
        /// </summary>
        public const string SZUPC = "SZUPC";

        /// <summary>
        /// SZMERL.
        /// </summary>
        public const string SZMERL = "SZMERL";

        /// <summary>
        /// SZECO.
        /// </summary>
        public const string SZECO = "SZECO";

        /// <summary>
        /// SZECTY.
        /// </summary>
        public const string SZECTY = "SZECTY";

        /// <summary>
        /// SZECOD.
        /// </summary>
        public const string SZECOD = "SZECOD";

        /// <summary>
        /// SZMOVD.
        /// </summary>
        public const string SZMOVD = "SZMOVD";

        /// <summary>
        /// SZQUED.
        /// </summary>
        public const string SZQUED = "SZQUED";

        /// <summary>
        /// SZSETL.
        /// </summary>
        public const string SZSETL = "SZSETL";

        /// <summary>
        /// SZSRNK.
        /// </summary>
        public const string SZSRNK = "SZSRNK";

        /// <summary>
        /// SZSRKF.
        /// </summary>
        public const string SZSRKF = "SZSRKF";

        /// <summary>
        /// SZTIMB.
        /// </summary>
        public const string SZTIMB = "SZTIMB";

        /// <summary>
        /// SZBQTY.
        /// </summary>
        public const string SZBQTY = "SZBQTY";

        /// <summary>
        /// SZMULT.
        /// </summary>
        public const string SZMULT = "SZMULT";

        /// <summary>
        /// SZLFDJ.
        /// </summary>
        public const string SZLFDJ = "SZLFDJ";

        /// <summary>
        /// SZMLOT.
        /// </summary>
        public const string SZMLOT = "SZMLOT";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

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
        /// SZSTAW.
        /// </summary>
        public const string SZSTAW = "SZSTAW";

        /// <summary>
        /// SZEFFT.
        /// </summary>
        public const string SZEFFT = "SZEFFT";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

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
        /// SZTMPL.
        /// </summary>
        public const string SZTMPL = "SZTMPL";

        /// <summary>
        /// SZSEG1.
        /// </summary>
        public const string SZSEG1 = "SZSEG1";

        /// <summary>
        /// SZSEG2.
        /// </summary>
        public const string SZSEG2 = "SZSEG2";

        /// <summary>
        /// SZSEG3.
        /// </summary>
        public const string SZSEG3 = "SZSEG3";

        /// <summary>
        /// SZSEG4.
        /// </summary>
        public const string SZSEG4 = "SZSEG4";

        /// <summary>
        /// SZSEG5.
        /// </summary>
        public const string SZSEG5 = "SZSEG5";

        /// <summary>
        /// SZSEG6.
        /// </summary>
        public const string SZSEG6 = "SZSEG6";

        /// <summary>
        /// SZSEG7.
        /// </summary>
        public const string SZSEG7 = "SZSEG7";

        /// <summary>
        /// SZSEG8.
        /// </summary>
        public const string SZSEG8 = "SZSEG8";

        /// <summary>
        /// SZSEG9.
        /// </summary>
        public const string SZSEG9 = "SZSEG9";

        /// <summary>
        /// SZSEG0.
        /// </summary>
        public const string SZSEG0 = "SZSEG0";

        /// <summary>
        /// SZAING.
        /// </summary>
        public const string SZAING = "SZAING";

        /// <summary>
        /// SZCMDM.
        /// </summary>
        public const string SZCMDM = "SZCMDM";

        /// <summary>
        /// SZDPPO.
        /// </summary>
        public const string SZDPPO = "SZDPPO";

        /// <summary>
        /// SZDUAL.
        /// </summary>
        public const string SZDUAL = "SZDUAL";

        /// <summary>
        /// SZLECM.
        /// </summary>
        public const string SZLECM = "SZLECM";

        /// <summary>
        /// SZMIC.
        /// </summary>
        public const string SZMIC = "SZMIC";

        /// <summary>
        /// SZXDCK.
        /// </summary>
        public const string SZXDCK = "SZXDCK";

        /// <summary>
        /// SZDLTL.
        /// </summary>
        public const string SZDLTL = "SZDLTL";

        /// <summary>
        /// SZLEDD.
        /// </summary>
        public const string SZLEDD = "SZLEDD";

        /// <summary>
        /// SZPEFD.
        /// </summary>
        public const string SZPEFD = "SZPEFD";

        /// <summary>
        /// SZSBDD.
        /// </summary>
        public const string SZSBDD = "SZSBDD";

        /// <summary>
        /// SZU1DD.
        /// </summary>
        public const string SZU1DD = "SZU1DD";

        /// <summary>
        /// SZU2DD.
        /// </summary>
        public const string SZU2DD = "SZU2DD";

        /// <summary>
        /// SZU3DD.
        /// </summary>
        public const string SZU3DD = "SZU3DD";

        /// <summary>
        /// SZU4DD.
        /// </summary>
        public const string SZU4DD = "SZU4DD";

        /// <summary>
        /// SZU5DD.
        /// </summary>
        public const string SZU5DD = "SZU5DD";

        /// <summary>
        /// SZBBDD.
        /// </summary>
        public const string SZBBDD = "SZBBDD";

        /// <summary>
        /// SZLOTC.
        /// </summary>
        public const string SZLOTC = "SZLOTC";

        /// <summary>
        /// SZEXPI.
        /// </summary>
        public const string SZEXPI = "SZEXPI";

        /// <summary>
        /// SZCONB.
        /// </summary>
        public const string SZCONB = "SZCONB";

        /// <summary>
        /// SZPRI1.
        /// </summary>
        public const string SZPRI1 = "SZPRI1";

        /// <summary>
        /// SZPRI2.
        /// </summary>
        public const string SZPRI2 = "SZPRI2";

        /// <summary>
        /// SZGCMP.
        /// </summary>
        public const string SZGCMP = "SZGCMP";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";

        /// <summary>
        /// SZCMETH.
        /// </summary>
        public const string SZCMETH = "SZCMETH";

        /// <summary>
        /// SZLAF.
        /// </summary>
        public const string SZLAF = "SZLAF";

        /// <summary>
        /// SZLTFM.
        /// </summary>
        public const string SZLTFM = "SZLTFM";

        /// <summary>
        /// SZRWLA.
        /// </summary>
        public const string SZRWLA = "SZRWLA";

        /// <summary>
        /// SZLNPA.
        /// </summary>
        public const string SZLNPA = "SZLNPA";

        /// <summary>
        /// SZASHL.
        /// </summary>
        public const string SZASHL = "SZASHL";

        /// <summary>
        /// SZVMINV.
        /// </summary>
        public const string SZVMINV = "SZVMINV";

        /// <summary>
        /// SZLTCV.
        /// </summary>
        public const string SZLTCV = "SZLTCV";

        /// <summary>
        /// SZOPTH.
        /// </summary>
        public const string SZOPTH = "SZOPTH";

        /// <summary>
        /// SZCUTH.
        /// </summary>
        public const string SZCUTH = "SZCUTH";

        /// <summary>
        /// SZUMTH.
        /// </summary>
        public const string SZUMTH = "SZUMTH";

        /// <summary>
        /// SZLMFG.
        /// </summary>
        public const string SZLMFG = "SZLMFG";

        /// <summary>
        /// SZLINE.
        /// </summary>
        public const string SZLINE = "SZLINE";

        /// <summary>
        /// SZDFTPCT.
        /// </summary>
        public const string SZDFTPCT = "SZDFTPCT";

        /// <summary>
        /// SZKBIT.
        /// </summary>
        public const string SZKBIT = "SZKBIT";

        /// <summary>
        /// SZDFENDITM.
        /// </summary>
        public const string SZDFENDITM = "SZDFENDITM";

        /// <summary>
        /// SZKANEXLL.
        /// </summary>
        public const string SZKANEXLL = "SZKANEXLL";

        /// <summary>
        /// SZSCPSELL.
        /// </summary>
        public const string SZSCPSELL = "SZSCPSELL";

        /// <summary>
        /// SZMOPTH.
        /// </summary>
        public const string SZMOPTH = "SZMOPTH";

        /// <summary>
        /// SZMCUTH.
        /// </summary>
        public const string SZMCUTH = "SZMCUTH";

        /// <summary>
        /// SZCUMTH.
        /// </summary>
        public const string SZCUMTH = "SZCUMTH";

        /// <summary>
        /// SZATPRN.
        /// </summary>
        public const string SZATPRN = "SZATPRN";

        /// <summary>
        /// SZATPCA.
        /// </summary>
        public const string SZATPCA = "SZATPCA";

        /// <summary>
        /// SZATPAC.
        /// </summary>
        public const string SZATPAC = "SZATPAC";

        /// <summary>
        /// SZCOORE.
        /// </summary>
        public const string SZCOORE = "SZCOORE";

        /// <summary>
        /// SZVCPFC.
        /// </summary>
        public const string SZVCPFC = "SZVCPFC";

        /// <summary>
        /// SZPNYN.
        /// </summary>
        public const string SZPNYN = "SZPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "F4101Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZITBR", "SZITBR", JdeDataType.String, 2),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZKIT", "SZKIT", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZSRTX", "SZSRTX", JdeDataType.String, 60),
        new JdeField("SZALN", "SZALN", JdeDataType.String, 60),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZSRP6", "SZSRP6", JdeDataType.String, 12),
        new JdeField("SZSRP7", "SZSRP7", JdeDataType.String, 12),
        new JdeField("SZSRP8", "SZSRP8", JdeDataType.String, 12),
        new JdeField("SZSRP9", "SZSRP9", JdeDataType.String, 12),
        new JdeField("SZSRP0", "SZSRP0", JdeDataType.String, 12),
        new JdeField("SZPRP1", "SZPRP1", JdeDataType.String, 6),
        new JdeField("SZPRP2", "SZPRP2", JdeDataType.String, 6),
        new JdeField("SZPRP3", "SZPRP3", JdeDataType.String, 6),
        new JdeField("SZPRP4", "SZPRP4", JdeDataType.String, 6),
        new JdeField("SZPRP5", "SZPRP5", JdeDataType.String, 6),
        new JdeField("SZPRP6", "SZPRP6", JdeDataType.String, 12),
        new JdeField("SZPRP7", "SZPRP7", JdeDataType.String, 12),
        new JdeField("SZPRP8", "SZPRP8", JdeDataType.String, 12),
        new JdeField("SZPRP9", "SZPRP9", JdeDataType.String, 12),
        new JdeField("SZPRP0", "SZPRP0", JdeDataType.String, 12),
        new JdeField("SZCDCD", "SZCDCD", JdeDataType.String, 30),
        new JdeField("SZPDGR", "SZPDGR", JdeDataType.String, 6),
        new JdeField("SZDSGP", "SZDSGP", JdeDataType.String, 6),
        new JdeField("SZPRGR", "SZPRGR", JdeDataType.String, 16),
        new JdeField("SZRPRC", "SZRPRC", JdeDataType.String, 16),
        new JdeField("SZORPR", "SZORPR", JdeDataType.String, 16),
        new JdeField("SZBUYR", "SZBUYR", JdeDataType.Numeric),
        new JdeField("SZDRAW", "SZDRAW", JdeDataType.String, 40),
        new JdeField("SZRVNO", "SZRVNO", JdeDataType.String, 4),
        new JdeField("SZDSZE", "SZDSZE", JdeDataType.String, 2),
        new JdeField("SZVCUD", "SZVCUD", JdeDataType.Numeric),
        new JdeField("SZCARS", "SZCARS", JdeDataType.Numeric),
        new JdeField("SZCARP", "SZCARP", JdeDataType.Numeric),
        new JdeField("SZSHCN", "SZSHCN", JdeDataType.String, 6),
        new JdeField("SZSHCM", "SZSHCM", JdeDataType.String, 6),
        new JdeField("SZUOM1", "SZUOM1", JdeDataType.String, 4),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZUOM3", "SZUOM3", JdeDataType.String, 4),
        new JdeField("SZUOM4", "SZUOM4", JdeDataType.String, 4),
        new JdeField("SZUOM6", "SZUOM6", JdeDataType.String, 4),
        new JdeField("SZUOM8", "SZUOM8", JdeDataType.String, 4),
        new JdeField("SZUOM9", "SZUOM9", JdeDataType.String, 4),
        new JdeField("SZUWUM", "SZUWUM", JdeDataType.String, 4),
        new JdeField("SZUVM1", "SZUVM1", JdeDataType.String, 4),
        new JdeField("SZSUTM", "SZSUTM", JdeDataType.String, 4),
        new JdeField("SZUMVW", "SZUMVW", JdeDataType.String, 2),
        new JdeField("SZCYCL", "SZCYCL", JdeDataType.String, 6),
        new JdeField("SZGLPT", "SZGLPT", JdeDataType.String, 8),
        new JdeField("SZPLEV", "SZPLEV", JdeDataType.String, 2),
        new JdeField("SZPPLV", "SZPPLV", JdeDataType.String, 2),
        new JdeField("SZCLEV", "SZCLEV", JdeDataType.String, 2),
        new JdeField("SZPRPO", "SZPRPO", JdeDataType.String, 2),
        new JdeField("SZCKAV", "SZCKAV", JdeDataType.String, 2),
        new JdeField("SZBPFG", "SZBPFG", JdeDataType.String, 2),
        new JdeField("SZSRCE", "SZSRCE", JdeDataType.String, 2),
        new JdeField("SZOT1Y", "SZOT1Y", JdeDataType.String, 2),
        new JdeField("SZOT2Y", "SZOT2Y", JdeDataType.String, 2),
        new JdeField("SZSTDP", "SZSTDP", JdeDataType.Numeric),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZSTDG", "SZSTDG", JdeDataType.String, 6),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZCOTY", "SZCOTY", JdeDataType.String, 2),
        new JdeField("SZSTKT", "SZSTKT", JdeDataType.String, 2),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZCONT", "SZCONT", JdeDataType.String, 2),
        new JdeField("SZBACK", "SZBACK", JdeDataType.String, 2),
        new JdeField("SZIFLA", "SZIFLA", JdeDataType.String, 4),
        new JdeField("SZTFLA", "SZTFLA", JdeDataType.String, 4),
        new JdeField("SZINMG", "SZINMG", JdeDataType.String, 20),
        new JdeField("SZABCS", "SZABCS", JdeDataType.String, 2),
        new JdeField("SZABCM", "SZABCM", JdeDataType.String, 2),
        new JdeField("SZABCI", "SZABCI", JdeDataType.String, 2),
        new JdeField("SZOVR", "SZOVR", JdeDataType.String, 2),
        new JdeField("SZWARR", "SZWARR", JdeDataType.String, 16),
        new JdeField("SZCMCG", "SZCMCG", JdeDataType.String, 16),
        new JdeField("SZSRNR", "SZSRNR", JdeDataType.String, 2),
        new JdeField("SZPMTH", "SZPMTH", JdeDataType.String, 2),
        new JdeField("SZFIFO", "SZFIFO", JdeDataType.String, 2),
        new JdeField("SZLOTS", "SZLOTS", JdeDataType.String, 2),
        new JdeField("SZSLD", "SZSLD", JdeDataType.Numeric),
        new JdeField("SZANPL", "SZANPL", JdeDataType.Numeric),
        new JdeField("SZMPST", "SZMPST", JdeDataType.String, 2),
        new JdeField("SZPCTM", "SZPCTM", JdeDataType.Numeric),
        new JdeField("SZMMPC", "SZMMPC", JdeDataType.Numeric),
        new JdeField("SZPTSC", "SZPTSC", JdeDataType.String, 4),
        new JdeField("SZSNS", "SZSNS", JdeDataType.String, 2),
        new JdeField("SZLTLV", "SZLTLV", JdeDataType.Numeric),
        new JdeField("SZLTMF", "SZLTMF", JdeDataType.Numeric),
        new JdeField("SZLTCM", "SZLTCM", JdeDataType.Numeric),
        new JdeField("SZOPC", "SZOPC", JdeDataType.String, 2),
        new JdeField("SZOPV", "SZOPV", JdeDataType.Numeric),
        new JdeField("SZACQ", "SZACQ", JdeDataType.Numeric),
        new JdeField("SZMLQ", "SZMLQ", JdeDataType.Numeric),
        new JdeField("SZLTPU", "SZLTPU", JdeDataType.Numeric),
        new JdeField("SZMPSP", "SZMPSP", JdeDataType.String, 2),
        new JdeField("SZMRPP", "SZMRPP", JdeDataType.String, 2),
        new JdeField("SZITC", "SZITC", JdeDataType.String, 2),
        new JdeField("SZORDW", "SZORDW", JdeDataType.String, 2),
        new JdeField("SZMTF1", "SZMTF1", JdeDataType.Numeric),
        new JdeField("SZMTF2", "SZMTF2", JdeDataType.Numeric),
        new JdeField("SZMTF3", "SZMTF3", JdeDataType.Numeric),
        new JdeField("SZMTF4", "SZMTF4", JdeDataType.Numeric),
        new JdeField("SZMTF5", "SZMTF5", JdeDataType.Numeric),
        new JdeField("SZEXPD", "SZEXPD", JdeDataType.Numeric),
        new JdeField("SZDEFD", "SZDEFD", JdeDataType.Numeric),
        new JdeField("SZSFLT", "SZSFLT", JdeDataType.Numeric),
        new JdeField("SZMAKE", "SZMAKE", JdeDataType.String, 2),
        new JdeField("SZCOBY", "SZCOBY", JdeDataType.String, 2),
        new JdeField("SZLLX", "SZLLX", JdeDataType.Numeric),
        new JdeField("SZCMGL", "SZCMGL", JdeDataType.String, 2),
        new JdeField("SZCOMH", "SZCOMH", JdeDataType.Numeric),
        new JdeField("SZAVRT", "SZAVRT", JdeDataType.Numeric),
        new JdeField("SZUPCN", "SZUPCN", JdeDataType.String, 26),
        new JdeField("SZSCC0", "SZSCC0", JdeDataType.String, 28),
        new JdeField("SZUMDF", "SZUMDF", JdeDataType.String, 4),
        new JdeField("SZUMS0", "SZUMS0", JdeDataType.String, 4),
        new JdeField("SZUMUP", "SZUMUP", JdeDataType.String, 4),
        new JdeField("SZUMS1", "SZUMS1", JdeDataType.String, 4),
        new JdeField("SZUMS2", "SZUMS2", JdeDataType.String, 4),
        new JdeField("SZUMS3", "SZUMS3", JdeDataType.String, 4),
        new JdeField("SZUMS4", "SZUMS4", JdeDataType.String, 4),
        new JdeField("SZUMS5", "SZUMS5", JdeDataType.String, 4),
        new JdeField("SZUMS6", "SZUMS6", JdeDataType.String, 4),
        new JdeField("SZUMS7", "SZUMS7", JdeDataType.String, 4),
        new JdeField("SZUMS8", "SZUMS8", JdeDataType.String, 4),
        new JdeField("SZWTRQ", "SZWTRQ", JdeDataType.String, 2),
        new JdeField("SZEQTY", "SZEQTY", JdeDataType.String, 10),
        new JdeField("SZPOC", "SZPOC", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZVEND", "SZVEND", JdeDataType.Numeric),
        new JdeField("SZORIG", "SZORIG", JdeDataType.String, 6),
        new JdeField("SZROPI", "SZROPI", JdeDataType.Numeric),
        new JdeField("SZROQI", "SZROQI", JdeDataType.Numeric),
        new JdeField("SZRQMX", "SZRQMX", JdeDataType.Numeric),
        new JdeField("SZRQMN", "SZRQMN", JdeDataType.Numeric),
        new JdeField("SZWOMO", "SZWOMO", JdeDataType.Numeric),
        new JdeField("SZSERV", "SZSERV", JdeDataType.Numeric),
        new JdeField("SZSAFE", "SZSAFE", JdeDataType.Numeric),
        new JdeField("SZFUF1", "SZFUF1", JdeDataType.String, 2),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZTAX1", "SZTAX1", JdeDataType.String, 2),
        new JdeField("SZMRPD", "SZMRPD", JdeDataType.String, 2),
        new JdeField("SZMRPC", "SZMRPC", JdeDataType.String, 2),
        new JdeField("SZUPC", "SZUPC", JdeDataType.Numeric),
        new JdeField("SZMERL", "SZMERL", JdeDataType.String, 6),
        new JdeField("SZECO", "SZECO", JdeDataType.String, 24),
        new JdeField("SZECTY", "SZECTY", JdeDataType.String, 4),
        new JdeField("SZECOD", "SZECOD", JdeDataType.Numeric),
        new JdeField("SZMOVD", "SZMOVD", JdeDataType.Numeric),
        new JdeField("SZQUED", "SZQUED", JdeDataType.Numeric),
        new JdeField("SZSETL", "SZSETL", JdeDataType.Numeric),
        new JdeField("SZSRNK", "SZSRNK", JdeDataType.Numeric),
        new JdeField("SZSRKF", "SZSRKF", JdeDataType.String, 2),
        new JdeField("SZTIMB", "SZTIMB", JdeDataType.String, 2),
        new JdeField("SZBQTY", "SZBQTY", JdeDataType.Numeric),
        new JdeField("SZMULT", "SZMULT", JdeDataType.Numeric),
        new JdeField("SZLFDJ", "SZLFDJ", JdeDataType.Numeric),
        new JdeField("SZMLOT", "SZMLOT", JdeDataType.String, 2),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZSTAW", "SZSTAW", JdeDataType.String, 2),
        new JdeField("SZEFFT", "SZEFFT", JdeDataType.Numeric),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZTMPL", "SZTMPL", JdeDataType.String, 40),
        new JdeField("SZSEG1", "SZSEG1", JdeDataType.String, 20),
        new JdeField("SZSEG2", "SZSEG2", JdeDataType.String, 20),
        new JdeField("SZSEG3", "SZSEG3", JdeDataType.String, 20),
        new JdeField("SZSEG4", "SZSEG4", JdeDataType.String, 20),
        new JdeField("SZSEG5", "SZSEG5", JdeDataType.String, 20),
        new JdeField("SZSEG6", "SZSEG6", JdeDataType.String, 20),
        new JdeField("SZSEG7", "SZSEG7", JdeDataType.String, 20),
        new JdeField("SZSEG8", "SZSEG8", JdeDataType.String, 20),
        new JdeField("SZSEG9", "SZSEG9", JdeDataType.String, 20),
        new JdeField("SZSEG0", "SZSEG0", JdeDataType.String, 20),
        new JdeField("SZAING", "SZAING", JdeDataType.String, 2),
        new JdeField("SZCMDM", "SZCMDM", JdeDataType.String, 2),
        new JdeField("SZDPPO", "SZDPPO", JdeDataType.String, 2),
        new JdeField("SZDUAL", "SZDUAL", JdeDataType.String, 2),
        new JdeField("SZLECM", "SZLECM", JdeDataType.String, 2),
        new JdeField("SZMIC", "SZMIC", JdeDataType.String, 2),
        new JdeField("SZXDCK", "SZXDCK", JdeDataType.String, 2),
        new JdeField("SZDLTL", "SZDLTL", JdeDataType.Numeric),
        new JdeField("SZLEDD", "SZLEDD", JdeDataType.Numeric),
        new JdeField("SZPEFD", "SZPEFD", JdeDataType.Numeric),
        new JdeField("SZSBDD", "SZSBDD", JdeDataType.Numeric),
        new JdeField("SZU1DD", "SZU1DD", JdeDataType.Numeric),
        new JdeField("SZU2DD", "SZU2DD", JdeDataType.Numeric),
        new JdeField("SZU3DD", "SZU3DD", JdeDataType.Numeric),
        new JdeField("SZU4DD", "SZU4DD", JdeDataType.Numeric),
        new JdeField("SZU5DD", "SZU5DD", JdeDataType.Numeric),
        new JdeField("SZBBDD", "SZBBDD", JdeDataType.Numeric),
        new JdeField("SZLOTC", "SZLOTC", JdeDataType.String, 6),
        new JdeField("SZEXPI", "SZEXPI", JdeDataType.String, 2),
        new JdeField("SZCONB", "SZCONB", JdeDataType.String, 2),
        new JdeField("SZPRI1", "SZPRI1", JdeDataType.Numeric),
        new JdeField("SZPRI2", "SZPRI2", JdeDataType.Numeric),
        new JdeField("SZGCMP", "SZGCMP", JdeDataType.String, 2),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2),
        new JdeField("SZCMETH", "SZCMETH", JdeDataType.String, 2),
        new JdeField("SZLAF", "SZLAF", JdeDataType.String, 2),
        new JdeField("SZLTFM", "SZLTFM", JdeDataType.String, 2),
        new JdeField("SZRWLA", "SZRWLA", JdeDataType.String, 2),
        new JdeField("SZLNPA", "SZLNPA", JdeDataType.String, 2),
        new JdeField("SZASHL", "SZASHL", JdeDataType.String, 2),
        new JdeField("SZVMINV", "SZVMINV", JdeDataType.String, 2),
        new JdeField("SZLTCV", "SZLTCV", JdeDataType.Numeric),
        new JdeField("SZOPTH", "SZOPTH", JdeDataType.Numeric),
        new JdeField("SZCUTH", "SZCUTH", JdeDataType.Numeric),
        new JdeField("SZUMTH", "SZUMTH", JdeDataType.String, 6),
        new JdeField("SZLMFG", "SZLMFG", JdeDataType.String, 2),
        new JdeField("SZLINE", "SZLINE", JdeDataType.String, 24),
        new JdeField("SZDFTPCT", "SZDFTPCT", JdeDataType.Numeric),
        new JdeField("SZKBIT", "SZKBIT", JdeDataType.String, 2),
        new JdeField("SZDFENDITM", "SZDFENDITM", JdeDataType.String, 2),
        new JdeField("SZKANEXLL", "SZKANEXLL", JdeDataType.String, 2),
        new JdeField("SZSCPSELL", "SZSCPSELL", JdeDataType.String, 2),
        new JdeField("SZMOPTH", "SZMOPTH", JdeDataType.Numeric),
        new JdeField("SZMCUTH", "SZMCUTH", JdeDataType.Numeric),
        new JdeField("SZCUMTH", "SZCUMTH", JdeDataType.String, 6),
        new JdeField("SZATPRN", "SZATPRN", JdeDataType.String, 160),
        new JdeField("SZATPCA", "SZATPCA", JdeDataType.String, 2),
        new JdeField("SZATPAC", "SZATPAC", JdeDataType.String, 10),
        new JdeField("SZCOORE", "SZCOORE", JdeDataType.String, 2),
        new JdeField("SZVCPFC", "SZVCPFC", JdeDataType.String, 40),
        new JdeField("SZPNYN", "SZPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4101Z1_3", "Index on SZSEG1, SZSEG2, SZSEG3, SZSEG4, SZSEG5, SZSEG6, SZSEG7, SZSEG8, SZSEG9, SZSEG0", new[] { "SZSEG1", "SZSEG2", "SZSEG3", "SZSEG4", "SZSEG5", "SZSEG6", "SZSEG7", "SZSEG8", "SZSEG9", "SZSEG0" }),
        new JdeIndex("F4101Z1_4", "Index on SZLITM", new[] { "SZLITM" })
    };
}
