using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43121Z1 - .
/// </summary>
public class F43121Z1 : JdeTable
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
        /// SZTPUR.
        /// </summary>
        public const string SZTPUR = "SZTPUR";

        /// <summary>
        /// SZLSTS.
        /// </summary>
        public const string SZLSTS = "SZLSTS";

        /// <summary>
        /// SZRATY.
        /// </summary>
        public const string SZRATY = "SZRATY";

        /// <summary>
        /// SZRECOPT.
        /// </summary>
        public const string SZRECOPT = "SZRECOPT";

        /// <summary>
        /// SZMATC.
        /// </summary>
        public const string SZMATC = "SZMATC";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

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
        /// SZNLIN.
        /// </summary>
        public const string SZNLIN = "SZNLIN";

        /// <summary>
        /// SZALIN.
        /// </summary>
        public const string SZALIN = "SZALIN";

        /// <summary>
        /// SZRTBY.
        /// </summary>
        public const string SZRTBY = "SZRTBY";

        /// <summary>
        /// SZDMCT.
        /// </summary>
        public const string SZDMCT = "SZDMCT";

        /// <summary>
        /// SZDMCS.
        /// </summary>
        public const string SZDMCS = "SZDMCS";

        /// <summary>
        /// SZBALU.
        /// </summary>
        public const string SZBALU = "SZBALU";

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
        /// SZIMCU.
        /// </summary>
        public const string SZIMCU = "SZIMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZLOTG.
        /// </summary>
        public const string SZLOTG = "SZLOTG";

        /// <summary>
        /// SZLOTP.
        /// </summary>
        public const string SZLOTP = "SZLOTP";

        /// <summary>
        /// SZVRMK.
        /// </summary>
        public const string SZVRMK = "SZVRMK";

        /// <summary>
        /// SZCNID.
        /// </summary>
        public const string SZCNID = "SZCNID";

        /// <summary>
        /// SZNXTR.
        /// </summary>
        public const string SZNXTR = "SZNXTR";

        /// <summary>
        /// SZLTTR.
        /// </summary>
        public const string SZLTTR = "SZLTTR";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZRCDJ.
        /// </summary>
        public const string SZRCDJ = "SZRCDJ";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZPDDJ.
        /// </summary>
        public const string SZPDDJ = "SZPDDJ";

        /// <summary>
        /// SZOPDJ.
        /// </summary>
        public const string SZOPDJ = "SZOPDJ";

        /// <summary>
        /// SZRCD.
        /// </summary>
        public const string SZRCD = "SZRCD";

        /// <summary>
        /// SZVINV.
        /// </summary>
        public const string SZVINV = "SZVINV";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZPST.
        /// </summary>
        public const string SZPST = "SZPST";

        /// <summary>
        /// SZLAND.
        /// </summary>
        public const string SZLAND = "SZLAND";

        /// <summary>
        /// SZPRP5.
        /// </summary>
        public const string SZPRP5 = "SZPRP5";

        /// <summary>
        /// SZLVLA.
        /// </summary>
        public const string SZLVLA = "SZLVLA";

        /// <summary>
        /// SZILOG.
        /// </summary>
        public const string SZILOG = "SZILOG";

        /// <summary>
        /// SZDLOG.
        /// </summary>
        public const string SZDLOG = "SZDLOG";

        /// <summary>
        /// SZRTGC.
        /// </summary>
        public const string SZRTGC = "SZRTGC";

        /// <summary>
        /// SZRCPF.
        /// </summary>
        public const string SZRCPF = "SZRCPF";

        /// <summary>
        /// SZAVCH.
        /// </summary>
        public const string SZAVCH = "SZAVCH";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

        /// <summary>
        /// SZANI.
        /// </summary>
        public const string SZANI = "SZANI";

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
        /// SZASID.
        /// </summary>
        public const string SZASID = "SZASID";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

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
        /// SZSFX.
        /// </summary>
        public const string SZSFX = "SZSFX";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZJELN.
        /// </summary>
        public const string SZJELN = "SZJELN";

        /// <summary>
        /// SZVANI.
        /// </summary>
        public const string SZVANI = "SZVANI";

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
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZUPTD.
        /// </summary>
        public const string SZUPTD = "SZUPTD";

        /// <summary>
        /// SZUOPN.
        /// </summary>
        public const string SZUOPN = "SZUOPN";

        /// <summary>
        /// SZUREC.
        /// </summary>
        public const string SZUREC = "SZUREC";

        /// <summary>
        /// SZUCLO.
        /// </summary>
        public const string SZUCLO = "SZUCLO";

        /// <summary>
        /// SZQTYS.
        /// </summary>
        public const string SZQTYS = "SZQTYS";

        /// <summary>
        /// SZQTYR.
        /// </summary>
        public const string SZQTYR = "SZQTYR";

        /// <summary>
        /// SZQTYW.
        /// </summary>
        public const string SZQTYW = "SZQTYW";

        /// <summary>
        /// SZQTYC.
        /// </summary>
        public const string SZQTYC = "SZQTYC";

        /// <summary>
        /// SZQTYJ.
        /// </summary>
        public const string SZQTYJ = "SZQTYJ";

        /// <summary>
        /// SZQTYA.
        /// </summary>
        public const string SZQTYA = "SZQTYA";

        /// <summary>
        /// SZUOM3.
        /// </summary>
        public const string SZUOM3 = "SZUOM3";

        /// <summary>
        /// SZPRRC.
        /// </summary>
        public const string SZPRRC = "SZPRRC";

        /// <summary>
        /// SZECST.
        /// </summary>
        public const string SZECST = "SZECST";

        /// <summary>
        /// SZAPTD.
        /// </summary>
        public const string SZAPTD = "SZAPTD";

        /// <summary>
        /// SZAOPN.
        /// </summary>
        public const string SZAOPN = "SZAOPN";

        /// <summary>
        /// SZAREC.
        /// </summary>
        public const string SZAREC = "SZAREC";

        /// <summary>
        /// SZACLO.
        /// </summary>
        public const string SZACLO = "SZACLO";

        /// <summary>
        /// SZAVCO.
        /// </summary>
        public const string SZAVCO = "SZAVCO";

        /// <summary>
        /// SZVARC.
        /// </summary>
        public const string SZVARC = "SZVARC";

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
        /// SZFEC.
        /// </summary>
        public const string SZFEC = "SZFEC";

        /// <summary>
        /// SZFAP.
        /// </summary>
        public const string SZFAP = "SZFAP";

        /// <summary>
        /// SZFAPT.
        /// </summary>
        public const string SZFAPT = "SZFAPT";

        /// <summary>
        /// SZFREC.
        /// </summary>
        public const string SZFREC = "SZFREC";

        /// <summary>
        /// SZFCLO.
        /// </summary>
        public const string SZFCLO = "SZFCLO";

        /// <summary>
        /// SZADDJ.
        /// </summary>
        public const string SZADDJ = "SZADDJ";

        /// <summary>
        /// SZSHAN.
        /// </summary>
        public const string SZSHAN = "SZSHAN";

        /// <summary>
        /// SZCITM.
        /// </summary>
        public const string SZCITM = "SZCITM";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZVR02.
        /// </summary>
        public const string SZVR02 = "SZVR02";

        /// <summary>
        /// SZLDSC.
        /// </summary>
        public const string SZLDSC = "SZLDSC";

        /// <summary>
        /// SZMMEJ.
        /// </summary>
        public const string SZMMEJ = "SZMMEJ";

        /// <summary>
        /// SZLOTS.
        /// </summary>
        public const string SZLOTS = "SZLOTS";

        /// <summary>
        /// SZRLOT.
        /// </summary>
        public const string SZRLOT = "SZRLOT";

        /// <summary>
        /// SZLOT1.
        /// </summary>
        public const string SZLOT1 = "SZLOT1";

        /// <summary>
        /// SZLOT2.
        /// </summary>
        public const string SZLOT2 = "SZLOT2";

        /// <summary>
        /// SZAMBR.
        /// </summary>
        public const string SZAMBR = "SZAMBR";

        /// <summary>
        /// SZBUM3.
        /// </summary>
        public const string SZBUM3 = "SZBUM3";

        /// <summary>
        /// SZSTOK.
        /// </summary>
        public const string SZSTOK = "SZSTOK";

        /// <summary>
        /// SZBUM4.
        /// </summary>
        public const string SZBUM4 = "SZBUM4";

        /// <summary>
        /// SZWGTR.
        /// </summary>
        public const string SZWGTR = "SZWGTR";

        /// <summary>
        /// SZBUM5.
        /// </summary>
        public const string SZBUM5 = "SZBUM5";

        /// <summary>
        /// SZTEMP.
        /// </summary>
        public const string SZTEMP = "SZTEMP";

        /// <summary>
        /// SZSTPU.
        /// </summary>
        public const string SZSTPU = "SZSTPU";

        /// <summary>
        /// SZDEND.
        /// </summary>
        public const string SZDEND = "SZDEND";

        /// <summary>
        /// SZDNTP.
        /// </summary>
        public const string SZDNTP = "SZDNTP";

        /// <summary>
        /// SZDETP.
        /// </summary>
        public const string SZDETP = "SZDETP";

        /// <summary>
        /// SZDTPU.
        /// </summary>
        public const string SZDTPU = "SZDTPU";

        /// <summary>
        /// SZRCTM.
        /// </summary>
        public const string SZRCTM = "SZRCTM";

        /// <summary>
        /// SZABR1.
        /// </summary>
        public const string SZABR1 = "SZABR1";

        /// <summary>
        /// SZABT1.
        /// </summary>
        public const string SZABT1 = "SZABT1";

        /// <summary>
        /// SZABR2.
        /// </summary>
        public const string SZABR2 = "SZABR2";

        /// <summary>
        /// SZABT2.
        /// </summary>
        public const string SZABT2 = "SZABT2";

        /// <summary>
        /// SZABR3.
        /// </summary>
        public const string SZABR3 = "SZABR3";

        /// <summary>
        /// SZABT3.
        /// </summary>
        public const string SZABT3 = "SZABT3";

        /// <summary>
        /// SZABR4.
        /// </summary>
        public const string SZABR4 = "SZABR4";

        /// <summary>
        /// SZABT4.
        /// </summary>
        public const string SZABT4 = "SZABT4";

        /// <summary>
        /// SZMOT.
        /// </summary>
        public const string SZMOT = "SZMOT";

        /// <summary>
        /// SZANCR.
        /// </summary>
        public const string SZANCR = "SZANCR";

        /// <summary>
        /// SZURET.
        /// </summary>
        public const string SZURET = "SZURET";

        /// <summary>
        /// SZUDMG.
        /// </summary>
        public const string SZUDMG = "SZUDMG";

        /// <summary>
        /// SZDGCD.
        /// </summary>
        public const string SZDGCD = "SZDGCD";

        /// <summary>
        /// SZUREJ.
        /// </summary>
        public const string SZUREJ = "SZUREJ";

        /// <summary>
        /// SZRJCD.
        /// </summary>
        public const string SZRJCD = "SZRJCD";

        /// <summary>
        /// SZUIQ1.
        /// </summary>
        public const string SZUIQ1 = "SZUIQ1";

        /// <summary>
        /// SZU1CD.
        /// </summary>
        public const string SZU1CD = "SZU1CD";

        /// <summary>
        /// SZUIQ2.
        /// </summary>
        public const string SZUIQ2 = "SZUIQ2";

        /// <summary>
        /// SZU2CD.
        /// </summary>
        public const string SZU2CD = "SZU2CD";

        /// <summary>
        /// SZUIQ3.
        /// </summary>
        public const string SZUIQ3 = "SZUIQ3";

        /// <summary>
        /// SZU3CD.
        /// </summary>
        public const string SZU3CD = "SZU3CD";

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
        /// SZVR05.
        /// </summary>
        public const string SZVR05 = "SZVR05";

        /// <summary>
        /// SZVR04.
        /// </summary>
        public const string SZVR04 = "SZVR04";

        /// <summary>
        /// SZUPUM.
        /// </summary>
        public const string SZUPUM = "SZUPUM";

        /// <summary>
        /// SZUPQT.
        /// </summary>
        public const string SZUPQT = "SZUPQT";

        /// <summary>
        /// SZUPCN.
        /// </summary>
        public const string SZUPCN = "SZUPCN";

        /// <summary>
        /// SZUOM2.
        /// </summary>
        public const string SZUOM2 = "SZUOM2";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZSTAM.
        /// </summary>
        public const string SZSTAM = "SZSTAM";

        /// <summary>
        /// SZSQOR.
        /// </summary>
        public const string SZSQOR = "SZSQOR";

        /// <summary>
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZSCUM.
        /// </summary>
        public const string SZSCUM = "SZSCUM";

        /// <summary>
        /// SZSCCQ.
        /// </summary>
        public const string SZSCCQ = "SZSCCQ";

        /// <summary>
        /// SZSCCN.
        /// </summary>
        public const string SZSCCN = "SZSCCN";

        /// <summary>
        /// SZPLT.
        /// </summary>
        public const string SZPLT = "SZPLT";

        /// <summary>
        /// SZPAK.
        /// </summary>
        public const string SZPAK = "SZPAK";

        /// <summary>
        /// SZMERL.
        /// </summary>
        public const string SZMERL = "SZMERL";

        /// <summary>
        /// SZMACT.
        /// </summary>
        public const string SZMACT = "SZMACT";

        /// <summary>
        /// SZLDNM.
        /// </summary>
        public const string SZLDNM = "SZLDNM";

        /// <summary>
        /// SZKTLN.
        /// </summary>
        public const string SZKTLN = "SZKTLN";

        /// <summary>
        /// SZFUF6.
        /// </summary>
        public const string SZFUF6 = "SZFUF6";

        /// <summary>
        /// SZFUF5.
        /// </summary>
        public const string SZFUF5 = "SZFUF5";

        /// <summary>
        /// SZFUF4.
        /// </summary>
        public const string SZFUF4 = "SZFUF4";

        /// <summary>
        /// SZFUF3.
        /// </summary>
        public const string SZFUF3 = "SZFUF3";

        /// <summary>
        /// SZDUAL.
        /// </summary>
        public const string SZDUAL = "SZDUAL";

        /// <summary>
        /// SZCTAM.
        /// </summary>
        public const string SZCTAM = "SZCTAM";

        /// <summary>
        /// SZXDCK.
        /// </summary>
        public const string SZXDCK = "SZXDCK";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZLOTC.
        /// </summary>
        public const string SZLOTC = "SZLOTC";

        /// <summary>
        /// SZPOE.
        /// </summary>
        public const string SZPOE = "SZPOE";

        /// <summary>
        /// SZVR03.
        /// </summary>
        public const string SZVR03 = "SZVR03";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZSRQTY.
        /// </summary>
        public const string SZSRQTY = "SZSRQTY";

        /// <summary>
        /// SZSRUOM.
        /// </summary>
        public const string SZSRUOM = "SZSRUOM";

        /// <summary>
        /// SZORIG.
        /// </summary>
        public const string SZORIG = "SZORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F43121Z1";

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
        new JdeField("SZTPUR", "SZTPUR", JdeDataType.String, 4),
        new JdeField("SZLSTS", "SZLSTS", JdeDataType.String, 4),
        new JdeField("SZRATY", "SZRATY", JdeDataType.String, 2),
        new JdeField("SZRECOPT", "SZRECOPT", JdeDataType.String, 2),
        new JdeField("SZMATC", "SZMATC", JdeDataType.String, 2),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZNLIN", "SZNLIN", JdeDataType.Numeric),
        new JdeField("SZALIN", "SZALIN", JdeDataType.Numeric),
        new JdeField("SZRTBY", "SZRTBY", JdeDataType.String, 4),
        new JdeField("SZDMCT", "SZDMCT", JdeDataType.String, 24),
        new JdeField("SZDMCS", "SZDMCS", JdeDataType.Numeric),
        new JdeField("SZBALU", "SZBALU", JdeDataType.String, 2),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZIMCU", "SZIMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZLOTG", "SZLOTG", JdeDataType.String, 6),
        new JdeField("SZLOTP", "SZLOTP", JdeDataType.Numeric),
        new JdeField("SZVRMK", "SZVRMK", JdeDataType.String, 60),
        new JdeField("SZCNID", "SZCNID", JdeDataType.String, 40),
        new JdeField("SZNXTR", "SZNXTR", JdeDataType.String, 6),
        new JdeField("SZLTTR", "SZLTTR", JdeDataType.String, 6),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZRCDJ", "SZRCDJ", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZOPDJ", "SZOPDJ", JdeDataType.Numeric),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZVINV", "SZVINV", JdeDataType.String, 50),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZPST", "SZPST", JdeDataType.String, 2),
        new JdeField("SZLAND", "SZLAND", JdeDataType.String, 2),
        new JdeField("SZPRP5", "SZPRP5", JdeDataType.String, 6),
        new JdeField("SZLVLA", "SZLVLA", JdeDataType.String, 6),
        new JdeField("SZILOG", "SZILOG", JdeDataType.String, 2),
        new JdeField("SZDLOG", "SZDLOG", JdeDataType.String, 2),
        new JdeField("SZRTGC", "SZRTGC", JdeDataType.String, 2),
        new JdeField("SZRCPF", "SZRCPF", JdeDataType.String, 2),
        new JdeField("SZAVCH", "SZAVCH", JdeDataType.String, 2),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZASID", "SZASID", JdeDataType.String, 50),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZSFX", "SZSFX", JdeDataType.String, 6),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZJELN", "SZJELN", JdeDataType.Numeric),
        new JdeField("SZVANI", "SZVANI", JdeDataType.String, 58),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZUPTD", "SZUPTD", JdeDataType.Numeric),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZUREC", "SZUREC", JdeDataType.Numeric),
        new JdeField("SZUCLO", "SZUCLO", JdeDataType.Numeric),
        new JdeField("SZQTYS", "SZQTYS", JdeDataType.Numeric),
        new JdeField("SZQTYR", "SZQTYR", JdeDataType.Numeric),
        new JdeField("SZQTYW", "SZQTYW", JdeDataType.Numeric),
        new JdeField("SZQTYC", "SZQTYC", JdeDataType.Numeric),
        new JdeField("SZQTYJ", "SZQTYJ", JdeDataType.Numeric),
        new JdeField("SZQTYA", "SZQTYA", JdeDataType.Numeric),
        new JdeField("SZUOM3", "SZUOM3", JdeDataType.String, 4),
        new JdeField("SZPRRC", "SZPRRC", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZAPTD", "SZAPTD", JdeDataType.Numeric),
        new JdeField("SZAOPN", "SZAOPN", JdeDataType.Numeric),
        new JdeField("SZAREC", "SZAREC", JdeDataType.Numeric),
        new JdeField("SZACLO", "SZACLO", JdeDataType.Numeric),
        new JdeField("SZAVCO", "SZAVCO", JdeDataType.Numeric),
        new JdeField("SZVARC", "SZVARC", JdeDataType.Numeric),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFRRC", "SZFRRC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
        new JdeField("SZFAP", "SZFAP", JdeDataType.Numeric),
        new JdeField("SZFAPT", "SZFAPT", JdeDataType.Numeric),
        new JdeField("SZFREC", "SZFREC", JdeDataType.Numeric),
        new JdeField("SZFCLO", "SZFCLO", JdeDataType.Numeric),
        new JdeField("SZADDJ", "SZADDJ", JdeDataType.Numeric),
        new JdeField("SZSHAN", "SZSHAN", JdeDataType.Numeric),
        new JdeField("SZCITM", "SZCITM", JdeDataType.String, 50),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
        new JdeField("SZLDSC", "SZLDSC", JdeDataType.String, 60),
        new JdeField("SZMMEJ", "SZMMEJ", JdeDataType.Numeric),
        new JdeField("SZLOTS", "SZLOTS", JdeDataType.String, 2),
        new JdeField("SZRLOT", "SZRLOT", JdeDataType.String, 60),
        new JdeField("SZLOT1", "SZLOT1", JdeDataType.String, 60),
        new JdeField("SZLOT2", "SZLOT2", JdeDataType.String, 60),
        new JdeField("SZAMBR", "SZAMBR", JdeDataType.Numeric),
        new JdeField("SZBUM3", "SZBUM3", JdeDataType.String, 4),
        new JdeField("SZSTOK", "SZSTOK", JdeDataType.Numeric),
        new JdeField("SZBUM4", "SZBUM4", JdeDataType.String, 4),
        new JdeField("SZWGTR", "SZWGTR", JdeDataType.Numeric),
        new JdeField("SZBUM5", "SZBUM5", JdeDataType.String, 4),
        new JdeField("SZTEMP", "SZTEMP", JdeDataType.Numeric),
        new JdeField("SZSTPU", "SZSTPU", JdeDataType.String, 2),
        new JdeField("SZDEND", "SZDEND", JdeDataType.Numeric),
        new JdeField("SZDNTP", "SZDNTP", JdeDataType.String, 2),
        new JdeField("SZDETP", "SZDETP", JdeDataType.Numeric),
        new JdeField("SZDTPU", "SZDTPU", JdeDataType.String, 2),
        new JdeField("SZRCTM", "SZRCTM", JdeDataType.Numeric),
        new JdeField("SZABR1", "SZABR1", JdeDataType.String, 24),
        new JdeField("SZABT1", "SZABT1", JdeDataType.String, 2),
        new JdeField("SZABR2", "SZABR2", JdeDataType.String, 24),
        new JdeField("SZABT2", "SZABT2", JdeDataType.String, 2),
        new JdeField("SZABR3", "SZABR3", JdeDataType.String, 24),
        new JdeField("SZABT3", "SZABT3", JdeDataType.String, 2),
        new JdeField("SZABR4", "SZABR4", JdeDataType.String, 24),
        new JdeField("SZABT4", "SZABT4", JdeDataType.String, 2),
        new JdeField("SZMOT", "SZMOT", JdeDataType.String, 6),
        new JdeField("SZANCR", "SZANCR", JdeDataType.Numeric),
        new JdeField("SZURET", "SZURET", JdeDataType.Numeric),
        new JdeField("SZUDMG", "SZUDMG", JdeDataType.Numeric),
        new JdeField("SZDGCD", "SZDGCD", JdeDataType.String, 4),
        new JdeField("SZUREJ", "SZUREJ", JdeDataType.Numeric),
        new JdeField("SZRJCD", "SZRJCD", JdeDataType.String, 4),
        new JdeField("SZUIQ1", "SZUIQ1", JdeDataType.Numeric),
        new JdeField("SZU1CD", "SZU1CD", JdeDataType.String, 4),
        new JdeField("SZUIQ2", "SZUIQ2", JdeDataType.Numeric),
        new JdeField("SZU2CD", "SZU2CD", JdeDataType.String, 4),
        new JdeField("SZUIQ3", "SZUIQ3", JdeDataType.Numeric),
        new JdeField("SZU3CD", "SZU3CD", JdeDataType.String, 4),
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
        new JdeField("SZVR05", "SZVR05", JdeDataType.String, 50),
        new JdeField("SZVR04", "SZVR04", JdeDataType.String, 50),
        new JdeField("SZUPUM", "SZUPUM", JdeDataType.String, 4),
        new JdeField("SZUPQT", "SZUPQT", JdeDataType.Numeric),
        new JdeField("SZUPCN", "SZUPCN", JdeDataType.String, 26),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric),
        new JdeField("SZSTAM", "SZSTAM", JdeDataType.Numeric),
        new JdeField("SZSQOR", "SZSQOR", JdeDataType.Numeric),
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZSCUM", "SZSCUM", JdeDataType.String, 4),
        new JdeField("SZSCCQ", "SZSCCQ", JdeDataType.Numeric),
        new JdeField("SZSCCN", "SZSCCN", JdeDataType.String, 28),
        new JdeField("SZPLT", "SZPLT", JdeDataType.String, 36),
        new JdeField("SZPAK", "SZPAK", JdeDataType.String, 36),
        new JdeField("SZMERL", "SZMERL", JdeDataType.String, 6),
        new JdeField("SZMACT", "SZMACT", JdeDataType.String, 2),
        new JdeField("SZLDNM", "SZLDNM", JdeDataType.Numeric),
        new JdeField("SZKTLN", "SZKTLN", JdeDataType.Numeric),
        new JdeField("SZFUF6", "SZFUF6", JdeDataType.String, 2),
        new JdeField("SZFUF5", "SZFUF5", JdeDataType.String, 2),
        new JdeField("SZFUF4", "SZFUF4", JdeDataType.String, 2),
        new JdeField("SZFUF3", "SZFUF3", JdeDataType.String, 2),
        new JdeField("SZDUAL", "SZDUAL", JdeDataType.String, 2),
        new JdeField("SZCTAM", "SZCTAM", JdeDataType.Numeric),
        new JdeField("SZXDCK", "SZXDCK", JdeDataType.String, 2),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZLOTC", "SZLOTC", JdeDataType.String, 6),
        new JdeField("SZPOE", "SZPOE", JdeDataType.String, 12),
        new JdeField("SZVR03", "SZVR03", JdeDataType.String, 50),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZSRQTY", "SZSRQTY", JdeDataType.Numeric),
        new JdeField("SZSRUOM", "SZSRUOM", JdeDataType.String, 4),
        new JdeField("SZORIG", "SZORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43121Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
