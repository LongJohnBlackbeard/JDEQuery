using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47032 - .
/// </summary>
public class F47032 : JdeTable
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
        /// SZADDJ.
        /// </summary>
        public const string SZADDJ = "SZADDJ";

        /// <summary>
        /// SZCNDJ.
        /// </summary>
        public const string SZCNDJ = "SZCNDJ";

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
        /// SZRLIT.
        /// </summary>
        public const string SZRLIT = "SZRLIT";

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
        /// SZPRRC.
        /// </summary>
        public const string SZPRRC = "SZPRRC";

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
        /// SZASID.
        /// </summary>
        public const string SZASID = "SZASID";

        /// <summary>
        /// SZTAG.
        /// </summary>
        public const string SZTAG = "SZTAG";

        /// <summary>
        /// SZPL.
        /// </summary>
        public const string SZPL = "SZPL";

        /// <summary>
        /// SZELEV.
        /// </summary>
        public const string SZELEV = "SZELEV";

        /// <summary>
        /// SZAVCH.
        /// </summary>
        public const string SZAVCH = "SZAVCH";

        /// <summary>
        /// SZPRPY.
        /// </summary>
        public const string SZPRPY = "SZPRPY";

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
        /// SZTXLN.
        /// </summary>
        public const string SZTXLN = "SZTXLN";

        /// <summary>
        /// SZDVAN.
        /// </summary>
        public const string SZDVAN = "SZDVAN";

        /// <summary>
        /// SZBTAN.
        /// </summary>
        public const string SZBTAN = "SZBTAN";

        /// <summary>
        /// SZMKFR.
        /// </summary>
        public const string SZMKFR = "SZMKFR";

        /// <summary>
        /// SZLDNM.
        /// </summary>
        public const string SZLDNM = "SZLDNM";

        /// <summary>
        /// SZVR03.
        /// </summary>
        public const string SZVR03 = "SZVR03";

        /// <summary>
        /// SZMERL.
        /// </summary>
        public const string SZMERL = "SZMERL";

        /// <summary>
        /// SZSHPN.
        /// </summary>
        public const string SZSHPN = "SZSHPN";

        /// <summary>
        /// SZADTM.
        /// </summary>
        public const string SZADTM = "SZADTM";

        /// <summary>
        /// SZOPTT.
        /// </summary>
        public const string SZOPTT = "SZOPTT";

        /// <summary>
        /// SZPDTT.
        /// </summary>
        public const string SZPDTT = "SZPDTT";

        /// <summary>
        /// SZPMDT.
        /// </summary>
        public const string SZPMDT = "SZPMDT";

        /// <summary>
        /// SZPSTM.
        /// </summary>
        public const string SZPSTM = "SZPSTM";

        /// <summary>
        /// SZVRMK.
        /// </summary>
        public const string SZVRMK = "SZVRMK";

        /// <summary>
        /// SZLOT1.
        /// </summary>
        public const string SZLOT1 = "SZLOT1";

        /// <summary>
        /// SZLOT2.
        /// </summary>
        public const string SZLOT2 = "SZLOT2";

        /// <summary>
        /// SZRLOT.
        /// </summary>
        public const string SZRLOT = "SZRLOT";

        /// <summary>
        /// SZLOTS.
        /// </summary>
        public const string SZLOTS = "SZLOTS";

        /// <summary>
        /// SZMMEJ.
        /// </summary>
        public const string SZMMEJ = "SZMMEJ";

        /// <summary>
        /// SZOUOM.
        /// </summary>
        public const string SZOUOM = "SZOUOM";

        /// <summary>
        /// SZAUREC.
        /// </summary>
        public const string SZAUREC = "SZAUREC";

        /// <summary>
        /// SZLDSC.
        /// </summary>
        public const string SZLDSC = "SZLDSC";

        /// <summary>
        /// SZCTSN.
        /// </summary>
        public const string SZCTSN = "SZCTSN";

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
        /// SZGDVAN.
        /// </summary>
        public const string SZGDVAN = "SZGDVAN";

        /// <summary>
        /// SZGBTAN.
        /// </summary>
        public const string SZGBTAN = "SZGBTAN";

        /// <summary>
        /// SZGMKFR.
        /// </summary>
        public const string SZGMKFR = "SZGMKFR";

        /// <summary>
        /// SZORIG.
        /// </summary>
        public const string SZORIG = "SZORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F47032";

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
        new JdeField("SZSPID", "SZSPID", JdeDataType.String, 40),
        new JdeField("SZHLVL", "SZHLVL", JdeDataType.Numeric),
        new JdeField("SZHL03", "SZHL03", JdeDataType.String, 4),
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
        new JdeField("SZADDJ", "SZADDJ", JdeDataType.Numeric),
        new JdeField("SZCNDJ", "SZCNDJ", JdeDataType.Numeric),
        new JdeField("SZPSDJ", "SZPSDJ", JdeDataType.Numeric),
        new JdeField("SZDSVJ", "SZDSVJ", JdeDataType.Numeric),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZCITM", "SZCITM", JdeDataType.String, 50),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZRLIT", "SZRLIT", JdeDataType.String, 16),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZUCHG", "SZUCHG", JdeDataType.Numeric),
        new JdeField("SZUOPN", "SZUOPN", JdeDataType.Numeric),
        new JdeField("SZUREC", "SZUREC", JdeDataType.Numeric),
        new JdeField("SZPRRC", "SZPRRC", JdeDataType.Numeric),
        new JdeField("SZACHG", "SZACHG", JdeDataType.Numeric),
        new JdeField("SZAOPN", "SZAOPN", JdeDataType.Numeric),
        new JdeField("SZAREC", "SZAREC", JdeDataType.Numeric),
        new JdeField("SZAMC3", "SZAMC3", JdeDataType.Numeric),
        new JdeField("SZECST", "SZECST", JdeDataType.Numeric),
        new JdeField("SZCSTO", "SZCSTO", JdeDataType.String, 2),
        new JdeField("SZCLVL", "SZCLVL", JdeDataType.String, 6),
        new JdeField("SZCATN", "SZCATN", JdeDataType.String, 16),
        new JdeField("SZDSPR", "SZDSPR", JdeDataType.Numeric),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZATXT", "SZATXT", JdeDataType.String, 2),
        new JdeField("SZCNID", "SZCNID", JdeDataType.String, 40),
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
        new JdeField("SZUOM3", "SZUOM3", JdeDataType.String, 4),
        new JdeField("SZITWT", "SZITWT", JdeDataType.Numeric),
        new JdeField("SZWTUM", "SZWTUM", JdeDataType.String, 4),
        new JdeField("SZITVL", "SZITVL", JdeDataType.Numeric),
        new JdeField("SZVLUM", "SZVLUM", JdeDataType.String, 4),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZSTTS", "SZSTTS", JdeDataType.String, 4),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZGRWT", "SZGRWT", JdeDataType.Numeric),
        new JdeField("SZGWUM", "SZGWUM", JdeDataType.String, 4),
        new JdeField("SZASID", "SZASID", JdeDataType.String, 50),
        new JdeField("SZTAG", "SZTAG", JdeDataType.String, 16),
        new JdeField("SZPL", "SZPL", JdeDataType.String, 8),
        new JdeField("SZELEV", "SZELEV", JdeDataType.String, 6),
        new JdeField("SZAVCH", "SZAVCH", JdeDataType.String, 2),
        new JdeField("SZPRPY", "SZPRPY", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFRRC", "SZFRRC", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFUC", "SZFUC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
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
        new JdeField("SZTXLN", "SZTXLN", JdeDataType.String, 120),
        new JdeField("SZDVAN", "SZDVAN", JdeDataType.Numeric),
        new JdeField("SZBTAN", "SZBTAN", JdeDataType.Numeric),
        new JdeField("SZMKFR", "SZMKFR", JdeDataType.Numeric),
        new JdeField("SZLDNM", "SZLDNM", JdeDataType.Numeric),
        new JdeField("SZVR03", "SZVR03", JdeDataType.String, 50),
        new JdeField("SZMERL", "SZMERL", JdeDataType.String, 6),
        new JdeField("SZSHPN", "SZSHPN", JdeDataType.Numeric),
        new JdeField("SZADTM", "SZADTM", JdeDataType.Numeric),
        new JdeField("SZOPTT", "SZOPTT", JdeDataType.Numeric),
        new JdeField("SZPDTT", "SZPDTT", JdeDataType.Numeric),
        new JdeField("SZPMDT", "SZPMDT", JdeDataType.Numeric),
        new JdeField("SZPSTM", "SZPSTM", JdeDataType.Numeric),
        new JdeField("SZVRMK", "SZVRMK", JdeDataType.String, 60),
        new JdeField("SZLOT1", "SZLOT1", JdeDataType.String, 60),
        new JdeField("SZLOT2", "SZLOT2", JdeDataType.String, 60),
        new JdeField("SZRLOT", "SZRLOT", JdeDataType.String, 60),
        new JdeField("SZLOTS", "SZLOTS", JdeDataType.String, 2),
        new JdeField("SZMMEJ", "SZMMEJ", JdeDataType.Numeric),
        new JdeField("SZOUOM", "SZOUOM", JdeDataType.String, 4),
        new JdeField("SZAUREC", "SZAUREC", JdeDataType.Numeric),
        new JdeField("SZLDSC", "SZLDSC", JdeDataType.String, 60),
        new JdeField("SZCTSN", "SZCTSN", JdeDataType.String, 80),
        new JdeField("SZGAN8", "SZGAN8", JdeDataType.Numeric),
        new JdeField("SZGSHAN", "SZGSHAN", JdeDataType.Numeric),
        new JdeField("SZGCARS", "SZGCARS", JdeDataType.Numeric),
        new JdeField("SZGDVAN", "SZGDVAN", JdeDataType.Numeric),
        new JdeField("SZGBTAN", "SZGBTAN", JdeDataType.Numeric),
        new JdeField("SZGMKFR", "SZGMKFR", JdeDataType.Numeric),
        new JdeField("SZORIG", "SZORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47032_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
