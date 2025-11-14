using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B11Z1 - .
/// </summary>
public class F03B11Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VJEDUS.
        /// </summary>
        public const string VJEDUS = "VJEDUS";

        /// <summary>
        /// VJEDTY.
        /// </summary>
        public const string VJEDTY = "VJEDTY";

        /// <summary>
        /// VJEDSQ.
        /// </summary>
        public const string VJEDSQ = "VJEDSQ";

        /// <summary>
        /// VJEDTN.
        /// </summary>
        public const string VJEDTN = "VJEDTN";

        /// <summary>
        /// VJEDCT.
        /// </summary>
        public const string VJEDCT = "VJEDCT";

        /// <summary>
        /// VJEDLN.
        /// </summary>
        public const string VJEDLN = "VJEDLN";

        /// <summary>
        /// VJEDTS.
        /// </summary>
        public const string VJEDTS = "VJEDTS";

        /// <summary>
        /// VJEDFT.
        /// </summary>
        public const string VJEDFT = "VJEDFT";

        /// <summary>
        /// VJEDDT.
        /// </summary>
        public const string VJEDDT = "VJEDDT";

        /// <summary>
        /// VJEDER.
        /// </summary>
        public const string VJEDER = "VJEDER";

        /// <summary>
        /// VJEDDL.
        /// </summary>
        public const string VJEDDL = "VJEDDL";

        /// <summary>
        /// VJEDSP.
        /// </summary>
        public const string VJEDSP = "VJEDSP";

        /// <summary>
        /// VJEDTC.
        /// </summary>
        public const string VJEDTC = "VJEDTC";

        /// <summary>
        /// VJEDTR.
        /// </summary>
        public const string VJEDTR = "VJEDTR";

        /// <summary>
        /// VJEDBT.
        /// </summary>
        public const string VJEDBT = "VJEDBT";

        /// <summary>
        /// VJEDGL.
        /// </summary>
        public const string VJEDGL = "VJEDGL";

        /// <summary>
        /// VJEDDH.
        /// </summary>
        public const string VJEDDH = "VJEDDH";

        /// <summary>
        /// VJEDAN.
        /// </summary>
        public const string VJEDAN = "VJEDAN";

        /// <summary>
        /// VJDOC.
        /// </summary>
        public const string VJDOC = "VJDOC";

        /// <summary>
        /// VJDCT.
        /// </summary>
        public const string VJDCT = "VJDCT";

        /// <summary>
        /// VJKCO.
        /// </summary>
        public const string VJKCO = "VJKCO";

        /// <summary>
        /// VJSFX.
        /// </summary>
        public const string VJSFX = "VJSFX";

        /// <summary>
        /// VJAN8.
        /// </summary>
        public const string VJAN8 = "VJAN8";

        /// <summary>
        /// VJDGJ.
        /// </summary>
        public const string VJDGJ = "VJDGJ";

        /// <summary>
        /// VJDIVJ.
        /// </summary>
        public const string VJDIVJ = "VJDIVJ";

        /// <summary>
        /// VJICUT.
        /// </summary>
        public const string VJICUT = "VJICUT";

        /// <summary>
        /// VJICU.
        /// </summary>
        public const string VJICU = "VJICU";

        /// <summary>
        /// VJDICJ.
        /// </summary>
        public const string VJDICJ = "VJDICJ";

        /// <summary>
        /// VJFY.
        /// </summary>
        public const string VJFY = "VJFY";

        /// <summary>
        /// VJCTRY.
        /// </summary>
        public const string VJCTRY = "VJCTRY";

        /// <summary>
        /// VJPN.
        /// </summary>
        public const string VJPN = "VJPN";

        /// <summary>
        /// VJCO.
        /// </summary>
        public const string VJCO = "VJCO";

        /// <summary>
        /// VJGLC.
        /// </summary>
        public const string VJGLC = "VJGLC";

        /// <summary>
        /// VJAID.
        /// </summary>
        public const string VJAID = "VJAID";

        /// <summary>
        /// VJPA8.
        /// </summary>
        public const string VJPA8 = "VJPA8";

        /// <summary>
        /// VJAN8J.
        /// </summary>
        public const string VJAN8J = "VJAN8J";

        /// <summary>
        /// VJPYR.
        /// </summary>
        public const string VJPYR = "VJPYR";

        /// <summary>
        /// VJPOST.
        /// </summary>
        public const string VJPOST = "VJPOST";

        /// <summary>
        /// VJISTR.
        /// </summary>
        public const string VJISTR = "VJISTR";

        /// <summary>
        /// VJBALJ.
        /// </summary>
        public const string VJBALJ = "VJBALJ";

        /// <summary>
        /// VJPST.
        /// </summary>
        public const string VJPST = "VJPST";

        /// <summary>
        /// VJAG.
        /// </summary>
        public const string VJAG = "VJAG";

        /// <summary>
        /// VJAAP.
        /// </summary>
        public const string VJAAP = "VJAAP";

        /// <summary>
        /// VJADSC.
        /// </summary>
        public const string VJADSC = "VJADSC";

        /// <summary>
        /// VJADSA.
        /// </summary>
        public const string VJADSA = "VJADSA";

        /// <summary>
        /// VJATXA.
        /// </summary>
        public const string VJATXA = "VJATXA";

        /// <summary>
        /// VJATXN.
        /// </summary>
        public const string VJATXN = "VJATXN";

        /// <summary>
        /// VJSTAM.
        /// </summary>
        public const string VJSTAM = "VJSTAM";

        /// <summary>
        /// VJCRRM.
        /// </summary>
        public const string VJCRRM = "VJCRRM";

        /// <summary>
        /// VJCRCD.
        /// </summary>
        public const string VJCRCD = "VJCRCD";

        /// <summary>
        /// VJCRR.
        /// </summary>
        public const string VJCRR = "VJCRR";

        /// <summary>
        /// VJDMCD.
        /// </summary>
        public const string VJDMCD = "VJDMCD";

        /// <summary>
        /// VJACR.
        /// </summary>
        public const string VJACR = "VJACR";

        /// <summary>
        /// VJFAP.
        /// </summary>
        public const string VJFAP = "VJFAP";

        /// <summary>
        /// VJCDS.
        /// </summary>
        public const string VJCDS = "VJCDS";

        /// <summary>
        /// VJCDSA.
        /// </summary>
        public const string VJCDSA = "VJCDSA";

        /// <summary>
        /// VJCTXA.
        /// </summary>
        public const string VJCTXA = "VJCTXA";

        /// <summary>
        /// VJCTXN.
        /// </summary>
        public const string VJCTXN = "VJCTXN";

        /// <summary>
        /// VJCTAM.
        /// </summary>
        public const string VJCTAM = "VJCTAM";

        /// <summary>
        /// VJTXA1.
        /// </summary>
        public const string VJTXA1 = "VJTXA1";

        /// <summary>
        /// VJEXR1.
        /// </summary>
        public const string VJEXR1 = "VJEXR1";

        /// <summary>
        /// VJDSVJ.
        /// </summary>
        public const string VJDSVJ = "VJDSVJ";

        /// <summary>
        /// VJGLBA.
        /// </summary>
        public const string VJGLBA = "VJGLBA";

        /// <summary>
        /// VJAM.
        /// </summary>
        public const string VJAM = "VJAM";

        /// <summary>
        /// VJAID2.
        /// </summary>
        public const string VJAID2 = "VJAID2";

        /// <summary>
        /// VJAM2.
        /// </summary>
        public const string VJAM2 = "VJAM2";

        /// <summary>
        /// VJMCU.
        /// </summary>
        public const string VJMCU = "VJMCU";

        /// <summary>
        /// VJOBJ.
        /// </summary>
        public const string VJOBJ = "VJOBJ";

        /// <summary>
        /// VJSUB.
        /// </summary>
        public const string VJSUB = "VJSUB";

        /// <summary>
        /// VJSBLT.
        /// </summary>
        public const string VJSBLT = "VJSBLT";

        /// <summary>
        /// VJSBL.
        /// </summary>
        public const string VJSBL = "VJSBL";

        /// <summary>
        /// VJPTC.
        /// </summary>
        public const string VJPTC = "VJPTC";

        /// <summary>
        /// VJDDJ.
        /// </summary>
        public const string VJDDJ = "VJDDJ";

        /// <summary>
        /// VJDDNJ.
        /// </summary>
        public const string VJDDNJ = "VJDDNJ";

        /// <summary>
        /// VJRDDJ.
        /// </summary>
        public const string VJRDDJ = "VJRDDJ";

        /// <summary>
        /// VJRDSJ.
        /// </summary>
        public const string VJRDSJ = "VJRDSJ";

        /// <summary>
        /// VJSMTJ.
        /// </summary>
        public const string VJSMTJ = "VJSMTJ";

        /// <summary>
        /// VJNBRR.
        /// </summary>
        public const string VJNBRR = "VJNBRR";

        /// <summary>
        /// VJRDRL.
        /// </summary>
        public const string VJRDRL = "VJRDRL";

        /// <summary>
        /// VJRMDS.
        /// </summary>
        public const string VJRMDS = "VJRMDS";

        /// <summary>
        /// VJCOLL.
        /// </summary>
        public const string VJCOLL = "VJCOLL";

        /// <summary>
        /// VJCORC.
        /// </summary>
        public const string VJCORC = "VJCORC";

        /// <summary>
        /// VJAFC.
        /// </summary>
        public const string VJAFC = "VJAFC";

        /// <summary>
        /// VJRSCO.
        /// </summary>
        public const string VJRSCO = "VJRSCO";

        /// <summary>
        /// VJCKNU.
        /// </summary>
        public const string VJCKNU = "VJCKNU";

        /// <summary>
        /// VJODOC.
        /// </summary>
        public const string VJODOC = "VJODOC";

        /// <summary>
        /// VJODCT.
        /// </summary>
        public const string VJODCT = "VJODCT";

        /// <summary>
        /// VJOKCO.
        /// </summary>
        public const string VJOKCO = "VJOKCO";

        /// <summary>
        /// VJOSFX.
        /// </summary>
        public const string VJOSFX = "VJOSFX";

        /// <summary>
        /// VJVINV.
        /// </summary>
        public const string VJVINV = "VJVINV";

        /// <summary>
        /// VJPO.
        /// </summary>
        public const string VJPO = "VJPO";

        /// <summary>
        /// VJPDCT.
        /// </summary>
        public const string VJPDCT = "VJPDCT";

        /// <summary>
        /// VJPKCO.
        /// </summary>
        public const string VJPKCO = "VJPKCO";

        /// <summary>
        /// VJDCTO.
        /// </summary>
        public const string VJDCTO = "VJDCTO";

        /// <summary>
        /// VJLNID.
        /// </summary>
        public const string VJLNID = "VJLNID";

        /// <summary>
        /// VJSDOC.
        /// </summary>
        public const string VJSDOC = "VJSDOC";

        /// <summary>
        /// VJSDCT.
        /// </summary>
        public const string VJSDCT = "VJSDCT";

        /// <summary>
        /// VJSKCO.
        /// </summary>
        public const string VJSKCO = "VJSKCO";

        /// <summary>
        /// VJSFXO.
        /// </summary>
        public const string VJSFXO = "VJSFXO";

        /// <summary>
        /// VJVLDT.
        /// </summary>
        public const string VJVLDT = "VJVLDT";

        /// <summary>
        /// VJCMC1.
        /// </summary>
        public const string VJCMC1 = "VJCMC1";

        /// <summary>
        /// VJVR01.
        /// </summary>
        public const string VJVR01 = "VJVR01";

        /// <summary>
        /// VJUNIT.
        /// </summary>
        public const string VJUNIT = "VJUNIT";

        /// <summary>
        /// VJMCU2.
        /// </summary>
        public const string VJMCU2 = "VJMCU2";

        /// <summary>
        /// VJRMK.
        /// </summary>
        public const string VJRMK = "VJRMK";

        /// <summary>
        /// VJALPH.
        /// </summary>
        public const string VJALPH = "VJALPH";

        /// <summary>
        /// VJRF.
        /// </summary>
        public const string VJRF = "VJRF";

        /// <summary>
        /// VJDRF.
        /// </summary>
        public const string VJDRF = "VJDRF";

        /// <summary>
        /// VJCTL.
        /// </summary>
        public const string VJCTL = "VJCTL";

        /// <summary>
        /// VJFNLP.
        /// </summary>
        public const string VJFNLP = "VJFNLP";

        /// <summary>
        /// VJITM.
        /// </summary>
        public const string VJITM = "VJITM";

        /// <summary>
        /// VJU.
        /// </summary>
        public const string VJU = "VJU";

        /// <summary>
        /// VJUM.
        /// </summary>
        public const string VJUM = "VJUM";

        /// <summary>
        /// VJALT6.
        /// </summary>
        public const string VJALT6 = "VJALT6";

        /// <summary>
        /// VJRYIN.
        /// </summary>
        public const string VJRYIN = "VJRYIN";

        /// <summary>
        /// VJVDGJ.
        /// </summary>
        public const string VJVDGJ = "VJVDGJ";

        /// <summary>
        /// VJVRE.
        /// </summary>
        public const string VJVRE = "VJVRE";

        /// <summary>
        /// VJRP1.
        /// </summary>
        public const string VJRP1 = "VJRP1";

        /// <summary>
        /// VJRP2.
        /// </summary>
        public const string VJRP2 = "VJRP2";

        /// <summary>
        /// VJRP3.
        /// </summary>
        public const string VJRP3 = "VJRP3";

        /// <summary>
        /// VJAR01.
        /// </summary>
        public const string VJAR01 = "VJAR01";

        /// <summary>
        /// VJAR02.
        /// </summary>
        public const string VJAR02 = "VJAR02";

        /// <summary>
        /// VJAR03.
        /// </summary>
        public const string VJAR03 = "VJAR03";

        /// <summary>
        /// VJAR04.
        /// </summary>
        public const string VJAR04 = "VJAR04";

        /// <summary>
        /// VJAR05.
        /// </summary>
        public const string VJAR05 = "VJAR05";

        /// <summary>
        /// VJAR06.
        /// </summary>
        public const string VJAR06 = "VJAR06";

        /// <summary>
        /// VJAR07.
        /// </summary>
        public const string VJAR07 = "VJAR07";

        /// <summary>
        /// VJAR08.
        /// </summary>
        public const string VJAR08 = "VJAR08";

        /// <summary>
        /// VJAR09.
        /// </summary>
        public const string VJAR09 = "VJAR09";

        /// <summary>
        /// VJAR10.
        /// </summary>
        public const string VJAR10 = "VJAR10";

        /// <summary>
        /// VJURC1.
        /// </summary>
        public const string VJURC1 = "VJURC1";

        /// <summary>
        /// VJURDT.
        /// </summary>
        public const string VJURDT = "VJURDT";

        /// <summary>
        /// VJURAT.
        /// </summary>
        public const string VJURAT = "VJURAT";

        /// <summary>
        /// VJURAB.
        /// </summary>
        public const string VJURAB = "VJURAB";

        /// <summary>
        /// VJURRF.
        /// </summary>
        public const string VJURRF = "VJURRF";

        /// <summary>
        /// VJTORG.
        /// </summary>
        public const string VJTORG = "VJTORG";

        /// <summary>
        /// VJUSER.
        /// </summary>
        public const string VJUSER = "VJUSER";

        /// <summary>
        /// VJPID.
        /// </summary>
        public const string VJPID = "VJPID";

        /// <summary>
        /// VJUPMJ.
        /// </summary>
        public const string VJUPMJ = "VJUPMJ";

        /// <summary>
        /// VJUPMT.
        /// </summary>
        public const string VJUPMT = "VJUPMT";

        /// <summary>
        /// VJJOBN.
        /// </summary>
        public const string VJJOBN = "VJJOBN";

        /// <summary>
        /// VJHCRR.
        /// </summary>
        public const string VJHCRR = "VJHCRR";

        /// <summary>
        /// VJHDGJ.
        /// </summary>
        public const string VJHDGJ = "VJHDGJ";

        /// <summary>
        /// VJDIM.
        /// </summary>
        public const string VJDIM = "VJDIM";

        /// <summary>
        /// VJDID.
        /// </summary>
        public const string VJDID = "VJDID";

        /// <summary>
        /// VJDIY.
        /// </summary>
        public const string VJDIY = "VJDIY";

        /// <summary>
        /// VJDI#.
        /// </summary>
        public const string VJDI_ = "VJDI#";

        /// <summary>
        /// VJDGM.
        /// </summary>
        public const string VJDGM = "VJDGM";

        /// <summary>
        /// VJDGD.
        /// </summary>
        public const string VJDGD = "VJDGD";

        /// <summary>
        /// VJDGY.
        /// </summary>
        public const string VJDGY = "VJDGY";

        /// <summary>
        /// VJDG#.
        /// </summary>
        public const string VJDG_ = "VJDG#";

        /// <summary>
        /// VJDICM.
        /// </summary>
        public const string VJDICM = "VJDICM";

        /// <summary>
        /// VJDICD.
        /// </summary>
        public const string VJDICD = "VJDICD";

        /// <summary>
        /// VJDICY.
        /// </summary>
        public const string VJDICY = "VJDICY";

        /// <summary>
        /// VJDIC#.
        /// </summary>
        public const string VJDIC_ = "VJDIC#";

        /// <summary>
        /// VJDSVM.
        /// </summary>
        public const string VJDSVM = "VJDSVM";

        /// <summary>
        /// VJDSVD.
        /// </summary>
        public const string VJDSVD = "VJDSVD";

        /// <summary>
        /// VJDSVY.
        /// </summary>
        public const string VJDSVY = "VJDSVY";

        /// <summary>
        /// VJDSV#.
        /// </summary>
        public const string VJDSV_ = "VJDSV#";

        /// <summary>
        /// VJDDM.
        /// </summary>
        public const string VJDDM = "VJDDM";

        /// <summary>
        /// VJDDD.
        /// </summary>
        public const string VJDDD = "VJDDD";

        /// <summary>
        /// VJDDY.
        /// </summary>
        public const string VJDDY = "VJDDY";

        /// <summary>
        /// VJDD#.
        /// </summary>
        public const string VJDD_ = "VJDD#";

        /// <summary>
        /// VJDDNM.
        /// </summary>
        public const string VJDDNM = "VJDDNM";

        /// <summary>
        /// VJDDND.
        /// </summary>
        public const string VJDDND = "VJDDND";

        /// <summary>
        /// VJDDNY.
        /// </summary>
        public const string VJDDNY = "VJDDNY";

        /// <summary>
        /// VJDDN#.
        /// </summary>
        public const string VJDDN_ = "VJDDN#";

        /// <summary>
        /// VJSMTM.
        /// </summary>
        public const string VJSMTM = "VJSMTM";

        /// <summary>
        /// VJSMTD.
        /// </summary>
        public const string VJSMTD = "VJSMTD";

        /// <summary>
        /// VJSMTY.
        /// </summary>
        public const string VJSMTY = "VJSMTY";

        /// <summary>
        /// VJSMT#.
        /// </summary>
        public const string VJSMT_ = "VJSMT#";

        /// <summary>
        /// VJRDDM.
        /// </summary>
        public const string VJRDDM = "VJRDDM";

        /// <summary>
        /// VJRDDD.
        /// </summary>
        public const string VJRDDD = "VJRDDD";

        /// <summary>
        /// VJRDDY.
        /// </summary>
        public const string VJRDDY = "VJRDDY";

        /// <summary>
        /// VJRDD#.
        /// </summary>
        public const string VJRDD_ = "VJRDD#";

        /// <summary>
        /// VJRDSM.
        /// </summary>
        public const string VJRDSM = "VJRDSM";

        /// <summary>
        /// VJRDSD.
        /// </summary>
        public const string VJRDSD = "VJRDSD";

        /// <summary>
        /// VJRDSY.
        /// </summary>
        public const string VJRDSY = "VJRDSY";

        /// <summary>
        /// VJRDS#.
        /// </summary>
        public const string VJRDS_ = "VJRDS#";

        /// <summary>
        /// VJHDGM.
        /// </summary>
        public const string VJHDGM = "VJHDGM";

        /// <summary>
        /// VJHDGD.
        /// </summary>
        public const string VJHDGD = "VJHDGD";

        /// <summary>
        /// VJHDGY.
        /// </summary>
        public const string VJHDGY = "VJHDGY";

        /// <summary>
        /// VJHDG#.
        /// </summary>
        public const string VJHDG_ = "VJHDG#";

        /// <summary>
        /// VJSHPN.
        /// </summary>
        public const string VJSHPN = "VJSHPN";

        /// <summary>
        /// VJDTXS.
        /// </summary>
        public const string VJDTXS = "VJDTXS";

        /// <summary>
        /// VJOMOD.
        /// </summary>
        public const string VJOMOD = "VJOMOD";

        /// <summary>
        /// VJCLMG.
        /// </summary>
        public const string VJCLMG = "VJCLMG";

        /// <summary>
        /// VJCMGR.
        /// </summary>
        public const string VJCMGR = "VJCMGR";

        /// <summary>
        /// VJATAD.
        /// </summary>
        public const string VJATAD = "VJATAD";

        /// <summary>
        /// VJCTAD.
        /// </summary>
        public const string VJCTAD = "VJCTAD";

        /// <summary>
        /// VJNRTA.
        /// </summary>
        public const string VJNRTA = "VJNRTA";

        /// <summary>
        /// VJFNRT.
        /// </summary>
        public const string VJFNRT = "VJFNRT";

        /// <summary>
        /// VJPRGF.
        /// </summary>
        public const string VJPRGF = "VJPRGF";

        /// <summary>
        /// VJGFL1.
        /// </summary>
        public const string VJGFL1 = "VJGFL1";

        /// <summary>
        /// VJGFL2.
        /// </summary>
        public const string VJGFL2 = "VJGFL2";

        /// <summary>
        /// VJDOCO.
        /// </summary>
        public const string VJDOCO = "VJDOCO";

        /// <summary>
        /// VJKCOO.
        /// </summary>
        public const string VJKCOO = "VJKCOO";

        /// <summary>
        /// VJSOTF.
        /// </summary>
        public const string VJSOTF = "VJSOTF";

        /// <summary>
        /// VJDTPB.
        /// </summary>
        public const string VJDTPB = "VJDTPB";

        /// <summary>
        /// VJERDJ.
        /// </summary>
        public const string VJERDJ = "VJERDJ";

        /// <summary>
        /// VJNETST.
        /// </summary>
        public const string VJNETST = "VJNETST";

        /// <summary>
        /// VJRMR1.
        /// </summary>
        public const string VJRMR1 = "VJRMR1";
    }

    /// <inheritdoc />
    public override string TableName => "F03B11Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VJEDUS", "VJEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VJEDTY", "VJEDTY", JdeDataType.String, 2),
        new JdeField("VJEDSQ", "VJEDSQ", JdeDataType.Numeric),
        new JdeField("VJEDTN", "VJEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VJEDCT", "VJEDCT", JdeDataType.String, 4),
        new JdeField("VJEDLN", "VJEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VJEDTS", "VJEDTS", JdeDataType.String, 12),
        new JdeField("VJEDFT", "VJEDFT", JdeDataType.String, 20),
        new JdeField("VJEDDT", "VJEDDT", JdeDataType.Numeric),
        new JdeField("VJEDER", "VJEDER", JdeDataType.String, 2),
        new JdeField("VJEDDL", "VJEDDL", JdeDataType.Numeric),
        new JdeField("VJEDSP", "VJEDSP", JdeDataType.String, 2),
        new JdeField("VJEDTC", "VJEDTC", JdeDataType.String, 2),
        new JdeField("VJEDTR", "VJEDTR", JdeDataType.String, 2),
        new JdeField("VJEDBT", "VJEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VJEDGL", "VJEDGL", JdeDataType.String, 2),
        new JdeField("VJEDDH", "VJEDDH", JdeDataType.String, 2),
        new JdeField("VJEDAN", "VJEDAN", JdeDataType.Numeric),
        new JdeField("VJDOC", "VJDOC", JdeDataType.Numeric),
        new JdeField("VJDCT", "VJDCT", JdeDataType.String, 4),
        new JdeField("VJKCO", "VJKCO", JdeDataType.String, 10),
        new JdeField("VJSFX", "VJSFX", JdeDataType.String, 6),
        new JdeField("VJAN8", "VJAN8", JdeDataType.Numeric),
        new JdeField("VJDGJ", "VJDGJ", JdeDataType.Numeric),
        new JdeField("VJDIVJ", "VJDIVJ", JdeDataType.Numeric),
        new JdeField("VJICUT", "VJICUT", JdeDataType.String, 4),
        new JdeField("VJICU", "VJICU", JdeDataType.Numeric),
        new JdeField("VJDICJ", "VJDICJ", JdeDataType.Numeric),
        new JdeField("VJFY", "VJFY", JdeDataType.Numeric),
        new JdeField("VJCTRY", "VJCTRY", JdeDataType.Numeric),
        new JdeField("VJPN", "VJPN", JdeDataType.Numeric),
        new JdeField("VJCO", "VJCO", JdeDataType.String, 10),
        new JdeField("VJGLC", "VJGLC", JdeDataType.String, 8),
        new JdeField("VJAID", "VJAID", JdeDataType.String, 16),
        new JdeField("VJPA8", "VJPA8", JdeDataType.Numeric),
        new JdeField("VJAN8J", "VJAN8J", JdeDataType.Numeric),
        new JdeField("VJPYR", "VJPYR", JdeDataType.Numeric),
        new JdeField("VJPOST", "VJPOST", JdeDataType.String, 2),
        new JdeField("VJISTR", "VJISTR", JdeDataType.String, 2),
        new JdeField("VJBALJ", "VJBALJ", JdeDataType.String, 2),
        new JdeField("VJPST", "VJPST", JdeDataType.String, 2),
        new JdeField("VJAG", "VJAG", JdeDataType.Numeric),
        new JdeField("VJAAP", "VJAAP", JdeDataType.Numeric),
        new JdeField("VJADSC", "VJADSC", JdeDataType.Numeric),
        new JdeField("VJADSA", "VJADSA", JdeDataType.Numeric),
        new JdeField("VJATXA", "VJATXA", JdeDataType.Numeric),
        new JdeField("VJATXN", "VJATXN", JdeDataType.Numeric),
        new JdeField("VJSTAM", "VJSTAM", JdeDataType.Numeric),
        new JdeField("VJCRRM", "VJCRRM", JdeDataType.String, 2),
        new JdeField("VJCRCD", "VJCRCD", JdeDataType.String, 6),
        new JdeField("VJCRR", "VJCRR", JdeDataType.Numeric),
        new JdeField("VJDMCD", "VJDMCD", JdeDataType.String, 2),
        new JdeField("VJACR", "VJACR", JdeDataType.Numeric),
        new JdeField("VJFAP", "VJFAP", JdeDataType.Numeric),
        new JdeField("VJCDS", "VJCDS", JdeDataType.Numeric),
        new JdeField("VJCDSA", "VJCDSA", JdeDataType.Numeric),
        new JdeField("VJCTXA", "VJCTXA", JdeDataType.Numeric),
        new JdeField("VJCTXN", "VJCTXN", JdeDataType.Numeric),
        new JdeField("VJCTAM", "VJCTAM", JdeDataType.Numeric),
        new JdeField("VJTXA1", "VJTXA1", JdeDataType.String, 20),
        new JdeField("VJEXR1", "VJEXR1", JdeDataType.String, 4),
        new JdeField("VJDSVJ", "VJDSVJ", JdeDataType.Numeric),
        new JdeField("VJGLBA", "VJGLBA", JdeDataType.String, 16),
        new JdeField("VJAM", "VJAM", JdeDataType.String, 2),
        new JdeField("VJAID2", "VJAID2", JdeDataType.String, 16),
        new JdeField("VJAM2", "VJAM2", JdeDataType.String, 2),
        new JdeField("VJMCU", "VJMCU", JdeDataType.String, 24),
        new JdeField("VJOBJ", "VJOBJ", JdeDataType.String, 12),
        new JdeField("VJSUB", "VJSUB", JdeDataType.String, 16),
        new JdeField("VJSBLT", "VJSBLT", JdeDataType.String, 2),
        new JdeField("VJSBL", "VJSBL", JdeDataType.String, 16),
        new JdeField("VJPTC", "VJPTC", JdeDataType.String, 6),
        new JdeField("VJDDJ", "VJDDJ", JdeDataType.Numeric),
        new JdeField("VJDDNJ", "VJDDNJ", JdeDataType.Numeric),
        new JdeField("VJRDDJ", "VJRDDJ", JdeDataType.Numeric),
        new JdeField("VJRDSJ", "VJRDSJ", JdeDataType.Numeric),
        new JdeField("VJSMTJ", "VJSMTJ", JdeDataType.Numeric),
        new JdeField("VJNBRR", "VJNBRR", JdeDataType.String, 2),
        new JdeField("VJRDRL", "VJRDRL", JdeDataType.String, 2),
        new JdeField("VJRMDS", "VJRMDS", JdeDataType.Numeric),
        new JdeField("VJCOLL", "VJCOLL", JdeDataType.String, 2),
        new JdeField("VJCORC", "VJCORC", JdeDataType.String, 4),
        new JdeField("VJAFC", "VJAFC", JdeDataType.String, 2),
        new JdeField("VJRSCO", "VJRSCO", JdeDataType.String, 4),
        new JdeField("VJCKNU", "VJCKNU", JdeDataType.String, 50),
        new JdeField("VJODOC", "VJODOC", JdeDataType.Numeric),
        new JdeField("VJODCT", "VJODCT", JdeDataType.String, 4),
        new JdeField("VJOKCO", "VJOKCO", JdeDataType.String, 10),
        new JdeField("VJOSFX", "VJOSFX", JdeDataType.String, 6),
        new JdeField("VJVINV", "VJVINV", JdeDataType.String, 50),
        new JdeField("VJPO", "VJPO", JdeDataType.String, 16),
        new JdeField("VJPDCT", "VJPDCT", JdeDataType.String, 4),
        new JdeField("VJPKCO", "VJPKCO", JdeDataType.String, 10),
        new JdeField("VJDCTO", "VJDCTO", JdeDataType.String, 4),
        new JdeField("VJLNID", "VJLNID", JdeDataType.Numeric),
        new JdeField("VJSDOC", "VJSDOC", JdeDataType.Numeric),
        new JdeField("VJSDCT", "VJSDCT", JdeDataType.String, 4),
        new JdeField("VJSKCO", "VJSKCO", JdeDataType.String, 10),
        new JdeField("VJSFXO", "VJSFXO", JdeDataType.String, 6),
        new JdeField("VJVLDT", "VJVLDT", JdeDataType.Numeric),
        new JdeField("VJCMC1", "VJCMC1", JdeDataType.Numeric),
        new JdeField("VJVR01", "VJVR01", JdeDataType.String, 50),
        new JdeField("VJUNIT", "VJUNIT", JdeDataType.String, 16),
        new JdeField("VJMCU2", "VJMCU2", JdeDataType.String, 24),
        new JdeField("VJRMK", "VJRMK", JdeDataType.String, 60),
        new JdeField("VJALPH", "VJALPH", JdeDataType.String, 80),
        new JdeField("VJRF", "VJRF", JdeDataType.String, 4),
        new JdeField("VJDRF", "VJDRF", JdeDataType.Numeric),
        new JdeField("VJCTL", "VJCTL", JdeDataType.String, 26),
        new JdeField("VJFNLP", "VJFNLP", JdeDataType.String, 2),
        new JdeField("VJITM", "VJITM", JdeDataType.Numeric),
        new JdeField("VJU", "VJU", JdeDataType.Numeric),
        new JdeField("VJUM", "VJUM", JdeDataType.String, 4),
        new JdeField("VJALT6", "VJALT6", JdeDataType.String, 2),
        new JdeField("VJRYIN", "VJRYIN", JdeDataType.String, 2),
        new JdeField("VJVDGJ", "VJVDGJ", JdeDataType.Numeric),
        new JdeField("VJVRE", "VJVRE", JdeDataType.String, 6),
        new JdeField("VJRP1", "VJRP1", JdeDataType.String, 2),
        new JdeField("VJRP2", "VJRP2", JdeDataType.String, 2),
        new JdeField("VJRP3", "VJRP3", JdeDataType.String, 2),
        new JdeField("VJAR01", "VJAR01", JdeDataType.String, 6),
        new JdeField("VJAR02", "VJAR02", JdeDataType.String, 6),
        new JdeField("VJAR03", "VJAR03", JdeDataType.String, 6),
        new JdeField("VJAR04", "VJAR04", JdeDataType.String, 6),
        new JdeField("VJAR05", "VJAR05", JdeDataType.String, 6),
        new JdeField("VJAR06", "VJAR06", JdeDataType.String, 6),
        new JdeField("VJAR07", "VJAR07", JdeDataType.String, 6),
        new JdeField("VJAR08", "VJAR08", JdeDataType.String, 6),
        new JdeField("VJAR09", "VJAR09", JdeDataType.String, 6),
        new JdeField("VJAR10", "VJAR10", JdeDataType.String, 6),
        new JdeField("VJURC1", "VJURC1", JdeDataType.String, 6),
        new JdeField("VJURDT", "VJURDT", JdeDataType.Numeric),
        new JdeField("VJURAT", "VJURAT", JdeDataType.Numeric),
        new JdeField("VJURAB", "VJURAB", JdeDataType.Numeric),
        new JdeField("VJURRF", "VJURRF", JdeDataType.String, 30),
        new JdeField("VJTORG", "VJTORG", JdeDataType.String, 20),
        new JdeField("VJUSER", "VJUSER", JdeDataType.String, 20),
        new JdeField("VJPID", "VJPID", JdeDataType.String, 20),
        new JdeField("VJUPMJ", "VJUPMJ", JdeDataType.Numeric),
        new JdeField("VJUPMT", "VJUPMT", JdeDataType.Numeric),
        new JdeField("VJJOBN", "VJJOBN", JdeDataType.String, 20),
        new JdeField("VJHCRR", "VJHCRR", JdeDataType.Numeric),
        new JdeField("VJHDGJ", "VJHDGJ", JdeDataType.Numeric),
        new JdeField("VJDIM", "VJDIM", JdeDataType.Numeric),
        new JdeField("VJDID", "VJDID", JdeDataType.Numeric),
        new JdeField("VJDIY", "VJDIY", JdeDataType.Numeric),
        new JdeField("VJDI#", "VJDI#", JdeDataType.Numeric),
        new JdeField("VJDGM", "VJDGM", JdeDataType.Numeric),
        new JdeField("VJDGD", "VJDGD", JdeDataType.Numeric),
        new JdeField("VJDGY", "VJDGY", JdeDataType.Numeric),
        new JdeField("VJDG#", "VJDG#", JdeDataType.Numeric),
        new JdeField("VJDICM", "VJDICM", JdeDataType.Numeric),
        new JdeField("VJDICD", "VJDICD", JdeDataType.Numeric),
        new JdeField("VJDICY", "VJDICY", JdeDataType.Numeric),
        new JdeField("VJDIC#", "VJDIC#", JdeDataType.Numeric),
        new JdeField("VJDSVM", "VJDSVM", JdeDataType.Numeric),
        new JdeField("VJDSVD", "VJDSVD", JdeDataType.Numeric),
        new JdeField("VJDSVY", "VJDSVY", JdeDataType.Numeric),
        new JdeField("VJDSV#", "VJDSV#", JdeDataType.Numeric),
        new JdeField("VJDDM", "VJDDM", JdeDataType.Numeric),
        new JdeField("VJDDD", "VJDDD", JdeDataType.Numeric),
        new JdeField("VJDDY", "VJDDY", JdeDataType.Numeric),
        new JdeField("VJDD#", "VJDD#", JdeDataType.Numeric),
        new JdeField("VJDDNM", "VJDDNM", JdeDataType.Numeric),
        new JdeField("VJDDND", "VJDDND", JdeDataType.Numeric),
        new JdeField("VJDDNY", "VJDDNY", JdeDataType.Numeric),
        new JdeField("VJDDN#", "VJDDN#", JdeDataType.Numeric),
        new JdeField("VJSMTM", "VJSMTM", JdeDataType.Numeric),
        new JdeField("VJSMTD", "VJSMTD", JdeDataType.Numeric),
        new JdeField("VJSMTY", "VJSMTY", JdeDataType.Numeric),
        new JdeField("VJSMT#", "VJSMT#", JdeDataType.Numeric),
        new JdeField("VJRDDM", "VJRDDM", JdeDataType.Numeric),
        new JdeField("VJRDDD", "VJRDDD", JdeDataType.Numeric),
        new JdeField("VJRDDY", "VJRDDY", JdeDataType.Numeric),
        new JdeField("VJRDD#", "VJRDD#", JdeDataType.Numeric),
        new JdeField("VJRDSM", "VJRDSM", JdeDataType.Numeric),
        new JdeField("VJRDSD", "VJRDSD", JdeDataType.Numeric),
        new JdeField("VJRDSY", "VJRDSY", JdeDataType.Numeric),
        new JdeField("VJRDS#", "VJRDS#", JdeDataType.Numeric),
        new JdeField("VJHDGM", "VJHDGM", JdeDataType.Numeric),
        new JdeField("VJHDGD", "VJHDGD", JdeDataType.Numeric),
        new JdeField("VJHDGY", "VJHDGY", JdeDataType.Numeric),
        new JdeField("VJHDG#", "VJHDG#", JdeDataType.Numeric),
        new JdeField("VJSHPN", "VJSHPN", JdeDataType.Numeric),
        new JdeField("VJDTXS", "VJDTXS", JdeDataType.String, 2),
        new JdeField("VJOMOD", "VJOMOD", JdeDataType.String, 2),
        new JdeField("VJCLMG", "VJCLMG", JdeDataType.String, 20),
        new JdeField("VJCMGR", "VJCMGR", JdeDataType.String, 20),
        new JdeField("VJATAD", "VJATAD", JdeDataType.Numeric),
        new JdeField("VJCTAD", "VJCTAD", JdeDataType.Numeric),
        new JdeField("VJNRTA", "VJNRTA", JdeDataType.Numeric),
        new JdeField("VJFNRT", "VJFNRT", JdeDataType.Numeric),
        new JdeField("VJPRGF", "VJPRGF", JdeDataType.String, 2),
        new JdeField("VJGFL1", "VJGFL1", JdeDataType.String, 2),
        new JdeField("VJGFL2", "VJGFL2", JdeDataType.String, 2),
        new JdeField("VJDOCO", "VJDOCO", JdeDataType.Numeric),
        new JdeField("VJKCOO", "VJKCOO", JdeDataType.String, 10),
        new JdeField("VJSOTF", "VJSOTF", JdeDataType.String, 2),
        new JdeField("VJDTPB", "VJDTPB", JdeDataType.Numeric),
        new JdeField("VJERDJ", "VJERDJ", JdeDataType.Numeric),
        new JdeField("VJNETST", "VJNETST", JdeDataType.String, 2),
        new JdeField("VJRMR1", "VJRMR1", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B11Z1_0", "Primary Key on VJEDUS, VJEDBT, VJEDTN, VJEDLN", new[] { "VJEDUS", "VJEDBT", "VJEDTN", "VJEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
