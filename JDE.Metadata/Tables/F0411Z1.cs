using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411Z1 - .
/// </summary>
public class F0411Z1 : JdeTable
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
        /// VLEDDH.
        /// </summary>
        public const string VLEDDH = "VLEDDH";

        /// <summary>
        /// VLEDAN.
        /// </summary>
        public const string VLEDAN = "VLEDAN";

        /// <summary>
        /// VLKCO.
        /// </summary>
        public const string VLKCO = "VLKCO";

        /// <summary>
        /// VLDOC.
        /// </summary>
        public const string VLDOC = "VLDOC";

        /// <summary>
        /// VLDCT.
        /// </summary>
        public const string VLDCT = "VLDCT";

        /// <summary>
        /// VLSFX.
        /// </summary>
        public const string VLSFX = "VLSFX";

        /// <summary>
        /// VLSFXE.
        /// </summary>
        public const string VLSFXE = "VLSFXE";

        /// <summary>
        /// VLDCTA.
        /// </summary>
        public const string VLDCTA = "VLDCTA";

        /// <summary>
        /// VLAN8.
        /// </summary>
        public const string VLAN8 = "VLAN8";

        /// <summary>
        /// VLPYE.
        /// </summary>
        public const string VLPYE = "VLPYE";

        /// <summary>
        /// VLSNTO.
        /// </summary>
        public const string VLSNTO = "VLSNTO";

        /// <summary>
        /// VLDIVJ.
        /// </summary>
        public const string VLDIVJ = "VLDIVJ";

        /// <summary>
        /// VLDSVJ.
        /// </summary>
        public const string VLDSVJ = "VLDSVJ";

        /// <summary>
        /// VLDDJ.
        /// </summary>
        public const string VLDDJ = "VLDDJ";

        /// <summary>
        /// VLDDNJ.
        /// </summary>
        public const string VLDDNJ = "VLDDNJ";

        /// <summary>
        /// VLDGJ.
        /// </summary>
        public const string VLDGJ = "VLDGJ";

        /// <summary>
        /// VLFY.
        /// </summary>
        public const string VLFY = "VLFY";

        /// <summary>
        /// VLCTRY.
        /// </summary>
        public const string VLCTRY = "VLCTRY";

        /// <summary>
        /// VLPN.
        /// </summary>
        public const string VLPN = "VLPN";

        /// <summary>
        /// VLCO.
        /// </summary>
        public const string VLCO = "VLCO";

        /// <summary>
        /// VLICU.
        /// </summary>
        public const string VLICU = "VLICU";

        /// <summary>
        /// VLICUT.
        /// </summary>
        public const string VLICUT = "VLICUT";

        /// <summary>
        /// VLDICJ.
        /// </summary>
        public const string VLDICJ = "VLDICJ";

        /// <summary>
        /// VLBALJ.
        /// </summary>
        public const string VLBALJ = "VLBALJ";

        /// <summary>
        /// VLPST.
        /// </summary>
        public const string VLPST = "VLPST";

        /// <summary>
        /// VLAG.
        /// </summary>
        public const string VLAG = "VLAG";

        /// <summary>
        /// VLAAP.
        /// </summary>
        public const string VLAAP = "VLAAP";

        /// <summary>
        /// VLADSC.
        /// </summary>
        public const string VLADSC = "VLADSC";

        /// <summary>
        /// VLADSA.
        /// </summary>
        public const string VLADSA = "VLADSA";

        /// <summary>
        /// VLATXA.
        /// </summary>
        public const string VLATXA = "VLATXA";

        /// <summary>
        /// VLATXN.
        /// </summary>
        public const string VLATXN = "VLATXN";

        /// <summary>
        /// VLSTAM.
        /// </summary>
        public const string VLSTAM = "VLSTAM";

        /// <summary>
        /// VLTXA1.
        /// </summary>
        public const string VLTXA1 = "VLTXA1";

        /// <summary>
        /// VLEXR1.
        /// </summary>
        public const string VLEXR1 = "VLEXR1";

        /// <summary>
        /// VLCRRM.
        /// </summary>
        public const string VLCRRM = "VLCRRM";

        /// <summary>
        /// VLCRCD.
        /// </summary>
        public const string VLCRCD = "VLCRCD";

        /// <summary>
        /// VLCRR.
        /// </summary>
        public const string VLCRR = "VLCRR";

        /// <summary>
        /// VLACR.
        /// </summary>
        public const string VLACR = "VLACR";

        /// <summary>
        /// VLFAP.
        /// </summary>
        public const string VLFAP = "VLFAP";

        /// <summary>
        /// VLCDS.
        /// </summary>
        public const string VLCDS = "VLCDS";

        /// <summary>
        /// VLCDSA.
        /// </summary>
        public const string VLCDSA = "VLCDSA";

        /// <summary>
        /// VLCTXA.
        /// </summary>
        public const string VLCTXA = "VLCTXA";

        /// <summary>
        /// VLCTXN.
        /// </summary>
        public const string VLCTXN = "VLCTXN";

        /// <summary>
        /// VLCTAM.
        /// </summary>
        public const string VLCTAM = "VLCTAM";

        /// <summary>
        /// VLGLC.
        /// </summary>
        public const string VLGLC = "VLGLC";

        /// <summary>
        /// VLGLBA.
        /// </summary>
        public const string VLGLBA = "VLGLBA";

        /// <summary>
        /// VLPOST.
        /// </summary>
        public const string VLPOST = "VLPOST";

        /// <summary>
        /// VLAM.
        /// </summary>
        public const string VLAM = "VLAM";

        /// <summary>
        /// VLAID2.
        /// </summary>
        public const string VLAID2 = "VLAID2";

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
        /// VLSBLT.
        /// </summary>
        public const string VLSBLT = "VLSBLT";

        /// <summary>
        /// VLSBL.
        /// </summary>
        public const string VLSBL = "VLSBL";

        /// <summary>
        /// VLBAID.
        /// </summary>
        public const string VLBAID = "VLBAID";

        /// <summary>
        /// VLPTC.
        /// </summary>
        public const string VLPTC = "VLPTC";

        /// <summary>
        /// VLVOD.
        /// </summary>
        public const string VLVOD = "VLVOD";

        /// <summary>
        /// VLOKCO.
        /// </summary>
        public const string VLOKCO = "VLOKCO";

        /// <summary>
        /// VLODCT.
        /// </summary>
        public const string VLODCT = "VLODCT";

        /// <summary>
        /// VLODOC.
        /// </summary>
        public const string VLODOC = "VLODOC";

        /// <summary>
        /// VLOSFX.
        /// </summary>
        public const string VLOSFX = "VLOSFX";

        /// <summary>
        /// VLCRC.
        /// </summary>
        public const string VLCRC = "VLCRC";

        /// <summary>
        /// VLVINV.
        /// </summary>
        public const string VLVINV = "VLVINV";

        /// <summary>
        /// VLPKCO.
        /// </summary>
        public const string VLPKCO = "VLPKCO";

        /// <summary>
        /// VLPO.
        /// </summary>
        public const string VLPO = "VLPO";

        /// <summary>
        /// VLPDCT.
        /// </summary>
        public const string VLPDCT = "VLPDCT";

        /// <summary>
        /// VLLNID.
        /// </summary>
        public const string VLLNID = "VLLNID";

        /// <summary>
        /// VLSFXO.
        /// </summary>
        public const string VLSFXO = "VLSFXO";

        /// <summary>
        /// VLOPSQ.
        /// </summary>
        public const string VLOPSQ = "VLOPSQ";

        /// <summary>
        /// VLVR01.
        /// </summary>
        public const string VLVR01 = "VLVR01";

        /// <summary>
        /// VLUNIT.
        /// </summary>
        public const string VLUNIT = "VLUNIT";

        /// <summary>
        /// VLMCU2.
        /// </summary>
        public const string VLMCU2 = "VLMCU2";

        /// <summary>
        /// VLRMK.
        /// </summary>
        public const string VLRMK = "VLRMK";

        /// <summary>
        /// VLRF.
        /// </summary>
        public const string VLRF = "VLRF";

        /// <summary>
        /// VLDRF.
        /// </summary>
        public const string VLDRF = "VLDRF";

        /// <summary>
        /// VLCTL.
        /// </summary>
        public const string VLCTL = "VLCTL";

        /// <summary>
        /// VLFNLP.
        /// </summary>
        public const string VLFNLP = "VLFNLP";

        /// <summary>
        /// VLU.
        /// </summary>
        public const string VLU = "VLU";

        /// <summary>
        /// VLUM.
        /// </summary>
        public const string VLUM = "VLUM";

        /// <summary>
        /// VLPYIN.
        /// </summary>
        public const string VLPYIN = "VLPYIN";

        /// <summary>
        /// VLTXA3.
        /// </summary>
        public const string VLTXA3 = "VLTXA3";

        /// <summary>
        /// VLEXR3.
        /// </summary>
        public const string VLEXR3 = "VLEXR3";

        /// <summary>
        /// VLRP1.
        /// </summary>
        public const string VLRP1 = "VLRP1";

        /// <summary>
        /// VLRP2.
        /// </summary>
        public const string VLRP2 = "VLRP2";

        /// <summary>
        /// VLRP3.
        /// </summary>
        public const string VLRP3 = "VLRP3";

        /// <summary>
        /// VLAC07.
        /// </summary>
        public const string VLAC07 = "VLAC07";

        /// <summary>
        /// VLTNN.
        /// </summary>
        public const string VLTNN = "VLTNN";

        /// <summary>
        /// VLDMCD.
        /// </summary>
        public const string VLDMCD = "VLDMCD";

        /// <summary>
        /// VLITM.
        /// </summary>
        public const string VLITM = "VLITM";

        /// <summary>
        /// VLHCRR.
        /// </summary>
        public const string VLHCRR = "VLHCRR";

        /// <summary>
        /// VLHDGJ.
        /// </summary>
        public const string VLHDGJ = "VLHDGJ";

        /// <summary>
        /// VLURC1.
        /// </summary>
        public const string VLURC1 = "VLURC1";

        /// <summary>
        /// VLURDT.
        /// </summary>
        public const string VLURDT = "VLURDT";

        /// <summary>
        /// VLURAT.
        /// </summary>
        public const string VLURAT = "VLURAT";

        /// <summary>
        /// VLURAB.
        /// </summary>
        public const string VLURAB = "VLURAB";

        /// <summary>
        /// VLURRF.
        /// </summary>
        public const string VLURRF = "VLURRF";

        /// <summary>
        /// VLTORG.
        /// </summary>
        public const string VLTORG = "VLTORG";

        /// <summary>
        /// VLUSER.
        /// </summary>
        public const string VLUSER = "VLUSER";

        /// <summary>
        /// VLPID.
        /// </summary>
        public const string VLPID = "VLPID";

        /// <summary>
        /// VLUPMJ.
        /// </summary>
        public const string VLUPMJ = "VLUPMJ";

        /// <summary>
        /// VLUPMT.
        /// </summary>
        public const string VLUPMT = "VLUPMT";

        /// <summary>
        /// VLJOBN.
        /// </summary>
        public const string VLJOBN = "VLJOBN";

        /// <summary>
        /// VLDIM.
        /// </summary>
        public const string VLDIM = "VLDIM";

        /// <summary>
        /// VLDID.
        /// </summary>
        public const string VLDID = "VLDID";

        /// <summary>
        /// VLDIY.
        /// </summary>
        public const string VLDIY = "VLDIY";

        /// <summary>
        /// VLDI#.
        /// </summary>
        public const string VLDI_ = "VLDI#";

        /// <summary>
        /// VLDSVM.
        /// </summary>
        public const string VLDSVM = "VLDSVM";

        /// <summary>
        /// VLDSVD.
        /// </summary>
        public const string VLDSVD = "VLDSVD";

        /// <summary>
        /// VLDSVY.
        /// </summary>
        public const string VLDSVY = "VLDSVY";

        /// <summary>
        /// VLDSV#.
        /// </summary>
        public const string VLDSV_ = "VLDSV#";

        /// <summary>
        /// VLDDM.
        /// </summary>
        public const string VLDDM = "VLDDM";

        /// <summary>
        /// VLDDD.
        /// </summary>
        public const string VLDDD = "VLDDD";

        /// <summary>
        /// VLDDY.
        /// </summary>
        public const string VLDDY = "VLDDY";

        /// <summary>
        /// VLDD#.
        /// </summary>
        public const string VLDD_ = "VLDD#";

        /// <summary>
        /// VLDDNM.
        /// </summary>
        public const string VLDDNM = "VLDDNM";

        /// <summary>
        /// VLDDND.
        /// </summary>
        public const string VLDDND = "VLDDND";

        /// <summary>
        /// VLDDNY.
        /// </summary>
        public const string VLDDNY = "VLDDNY";

        /// <summary>
        /// VLDDN#.
        /// </summary>
        public const string VLDDN_ = "VLDDN#";

        /// <summary>
        /// VLDGM.
        /// </summary>
        public const string VLDGM = "VLDGM";

        /// <summary>
        /// VLDGD.
        /// </summary>
        public const string VLDGD = "VLDGD";

        /// <summary>
        /// VLDGY.
        /// </summary>
        public const string VLDGY = "VLDGY";

        /// <summary>
        /// VLDG#.
        /// </summary>
        public const string VLDG_ = "VLDG#";

        /// <summary>
        /// VLDICM.
        /// </summary>
        public const string VLDICM = "VLDICM";

        /// <summary>
        /// VLDICD.
        /// </summary>
        public const string VLDICD = "VLDICD";

        /// <summary>
        /// VLDICY.
        /// </summary>
        public const string VLDICY = "VLDICY";

        /// <summary>
        /// VLDIC#.
        /// </summary>
        public const string VLDIC_ = "VLDIC#";

        /// <summary>
        /// VLHDGM.
        /// </summary>
        public const string VLHDGM = "VLHDGM";

        /// <summary>
        /// VLHDGD.
        /// </summary>
        public const string VLHDGD = "VLHDGD";

        /// <summary>
        /// VLHDGY.
        /// </summary>
        public const string VLHDGY = "VLHDGY";

        /// <summary>
        /// VLHDG#.
        /// </summary>
        public const string VLHDG_ = "VLHDG#";

        /// <summary>
        /// VLDOCM.
        /// </summary>
        public const string VLDOCM = "VLDOCM";

        /// <summary>
        /// VLTNST.
        /// </summary>
        public const string VLTNST = "VLTNST";

        /// <summary>
        /// VLYC01.
        /// </summary>
        public const string VLYC01 = "VLYC01";

        /// <summary>
        /// VLYC02.
        /// </summary>
        public const string VLYC02 = "VLYC02";

        /// <summary>
        /// VLYC03.
        /// </summary>
        public const string VLYC03 = "VLYC03";

        /// <summary>
        /// VLYC04.
        /// </summary>
        public const string VLYC04 = "VLYC04";

        /// <summary>
        /// VLYC05.
        /// </summary>
        public const string VLYC05 = "VLYC05";

        /// <summary>
        /// VLYC06.
        /// </summary>
        public const string VLYC06 = "VLYC06";

        /// <summary>
        /// VLYC07.
        /// </summary>
        public const string VLYC07 = "VLYC07";

        /// <summary>
        /// VLYC08.
        /// </summary>
        public const string VLYC08 = "VLYC08";

        /// <summary>
        /// VLYC09.
        /// </summary>
        public const string VLYC09 = "VLYC09";

        /// <summary>
        /// VLYC10.
        /// </summary>
        public const string VLYC10 = "VLYC10";

        /// <summary>
        /// VLDTXS.
        /// </summary>
        public const string VLDTXS = "VLDTXS";

        /// <summary>
        /// VLBCRC.
        /// </summary>
        public const string VLBCRC = "VLBCRC";

        /// <summary>
        /// VLATAD.
        /// </summary>
        public const string VLATAD = "VLATAD";

        /// <summary>
        /// VLCTAD.
        /// </summary>
        public const string VLCTAD = "VLCTAD";

        /// <summary>
        /// VLNRTA.
        /// </summary>
        public const string VLNRTA = "VLNRTA";

        /// <summary>
        /// VLFNRT.
        /// </summary>
        public const string VLFNRT = "VLFNRT";

        /// <summary>
        /// VLTAXP.
        /// </summary>
        public const string VLTAXP = "VLTAXP";

        /// <summary>
        /// VLPRGF.
        /// </summary>
        public const string VLPRGF = "VLPRGF";

        /// <summary>
        /// VLGFL5.
        /// </summary>
        public const string VLGFL5 = "VLGFL5";

        /// <summary>
        /// VLGFL6.
        /// </summary>
        public const string VLGFL6 = "VLGFL6";

        /// <summary>
        /// VLGAM1.
        /// </summary>
        public const string VLGAM1 = "VLGAM1";

        /// <summary>
        /// VLGAM2.
        /// </summary>
        public const string VLGAM2 = "VLGAM2";

        /// <summary>
        /// VLGEN4.
        /// </summary>
        public const string VLGEN4 = "VLGEN4";

        /// <summary>
        /// VLGEN5.
        /// </summary>
        public const string VLGEN5 = "VLGEN5";

        /// <summary>
        /// VLWTAD.
        /// </summary>
        public const string VLWTAD = "VLWTAD";

        /// <summary>
        /// VLWTAF.
        /// </summary>
        public const string VLWTAF = "VLWTAF";

        /// <summary>
        /// VLSMMF.
        /// </summary>
        public const string VLSMMF = "VLSMMF";

        /// <summary>
        /// VLPYWP.
        /// </summary>
        public const string VLPYWP = "VLPYWP";

        /// <summary>
        /// VLPWPG.
        /// </summary>
        public const string VLPWPG = "VLPWPG";

        /// <summary>
        /// VLNETST.
        /// </summary>
        public const string VLNETST = "VLNETST";

        /// <summary>
        /// VLATFLG.
        /// </summary>
        public const string VLATFLG = "VLATFLG";

        /// <summary>
        /// VLATRL.
        /// </summary>
        public const string VLATRL = "VLATRL";

        /// <summary>
        /// VLJOBS.
        /// </summary>
        public const string VLJOBS = "VLJOBS";

        /// <summary>
        /// VLPSTE.
        /// </summary>
        public const string VLPSTE = "VLPSTE";
    }

    /// <inheritdoc />
    public override string TableName => "F0411Z1";

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
        new JdeField("VLEDDH", "VLEDDH", JdeDataType.String, 2),
        new JdeField("VLEDAN", "VLEDAN", JdeDataType.Numeric),
        new JdeField("VLKCO", "VLKCO", JdeDataType.String, 10),
        new JdeField("VLDOC", "VLDOC", JdeDataType.Numeric),
        new JdeField("VLDCT", "VLDCT", JdeDataType.String, 4),
        new JdeField("VLSFX", "VLSFX", JdeDataType.String, 6),
        new JdeField("VLSFXE", "VLSFXE", JdeDataType.Numeric),
        new JdeField("VLDCTA", "VLDCTA", JdeDataType.String, 4),
        new JdeField("VLAN8", "VLAN8", JdeDataType.Numeric),
        new JdeField("VLPYE", "VLPYE", JdeDataType.Numeric),
        new JdeField("VLSNTO", "VLSNTO", JdeDataType.Numeric),
        new JdeField("VLDIVJ", "VLDIVJ", JdeDataType.Numeric),
        new JdeField("VLDSVJ", "VLDSVJ", JdeDataType.Numeric),
        new JdeField("VLDDJ", "VLDDJ", JdeDataType.Numeric),
        new JdeField("VLDDNJ", "VLDDNJ", JdeDataType.Numeric),
        new JdeField("VLDGJ", "VLDGJ", JdeDataType.Numeric),
        new JdeField("VLFY", "VLFY", JdeDataType.Numeric),
        new JdeField("VLCTRY", "VLCTRY", JdeDataType.Numeric),
        new JdeField("VLPN", "VLPN", JdeDataType.Numeric),
        new JdeField("VLCO", "VLCO", JdeDataType.String, 10),
        new JdeField("VLICU", "VLICU", JdeDataType.Numeric),
        new JdeField("VLICUT", "VLICUT", JdeDataType.String, 4),
        new JdeField("VLDICJ", "VLDICJ", JdeDataType.Numeric),
        new JdeField("VLBALJ", "VLBALJ", JdeDataType.String, 2),
        new JdeField("VLPST", "VLPST", JdeDataType.String, 2),
        new JdeField("VLAG", "VLAG", JdeDataType.Numeric),
        new JdeField("VLAAP", "VLAAP", JdeDataType.Numeric),
        new JdeField("VLADSC", "VLADSC", JdeDataType.Numeric),
        new JdeField("VLADSA", "VLADSA", JdeDataType.Numeric),
        new JdeField("VLATXA", "VLATXA", JdeDataType.Numeric),
        new JdeField("VLATXN", "VLATXN", JdeDataType.Numeric),
        new JdeField("VLSTAM", "VLSTAM", JdeDataType.Numeric),
        new JdeField("VLTXA1", "VLTXA1", JdeDataType.String, 20),
        new JdeField("VLEXR1", "VLEXR1", JdeDataType.String, 4),
        new JdeField("VLCRRM", "VLCRRM", JdeDataType.String, 2),
        new JdeField("VLCRCD", "VLCRCD", JdeDataType.String, 6),
        new JdeField("VLCRR", "VLCRR", JdeDataType.Numeric),
        new JdeField("VLACR", "VLACR", JdeDataType.Numeric),
        new JdeField("VLFAP", "VLFAP", JdeDataType.Numeric),
        new JdeField("VLCDS", "VLCDS", JdeDataType.Numeric),
        new JdeField("VLCDSA", "VLCDSA", JdeDataType.Numeric),
        new JdeField("VLCTXA", "VLCTXA", JdeDataType.Numeric),
        new JdeField("VLCTXN", "VLCTXN", JdeDataType.Numeric),
        new JdeField("VLCTAM", "VLCTAM", JdeDataType.Numeric),
        new JdeField("VLGLC", "VLGLC", JdeDataType.String, 8),
        new JdeField("VLGLBA", "VLGLBA", JdeDataType.String, 16),
        new JdeField("VLPOST", "VLPOST", JdeDataType.String, 2),
        new JdeField("VLAM", "VLAM", JdeDataType.String, 2),
        new JdeField("VLAID2", "VLAID2", JdeDataType.String, 16),
        new JdeField("VLMCU", "VLMCU", JdeDataType.String, 24),
        new JdeField("VLOBJ", "VLOBJ", JdeDataType.String, 12),
        new JdeField("VLSUB", "VLSUB", JdeDataType.String, 16),
        new JdeField("VLSBLT", "VLSBLT", JdeDataType.String, 2),
        new JdeField("VLSBL", "VLSBL", JdeDataType.String, 16),
        new JdeField("VLBAID", "VLBAID", JdeDataType.String, 16),
        new JdeField("VLPTC", "VLPTC", JdeDataType.String, 6),
        new JdeField("VLVOD", "VLVOD", JdeDataType.String, 2),
        new JdeField("VLOKCO", "VLOKCO", JdeDataType.String, 10),
        new JdeField("VLODCT", "VLODCT", JdeDataType.String, 4),
        new JdeField("VLODOC", "VLODOC", JdeDataType.Numeric),
        new JdeField("VLOSFX", "VLOSFX", JdeDataType.String, 6),
        new JdeField("VLCRC", "VLCRC", JdeDataType.String, 6),
        new JdeField("VLVINV", "VLVINV", JdeDataType.String, 50),
        new JdeField("VLPKCO", "VLPKCO", JdeDataType.String, 10),
        new JdeField("VLPO", "VLPO", JdeDataType.String, 16),
        new JdeField("VLPDCT", "VLPDCT", JdeDataType.String, 4),
        new JdeField("VLLNID", "VLLNID", JdeDataType.Numeric),
        new JdeField("VLSFXO", "VLSFXO", JdeDataType.String, 6),
        new JdeField("VLOPSQ", "VLOPSQ", JdeDataType.Numeric),
        new JdeField("VLVR01", "VLVR01", JdeDataType.String, 50),
        new JdeField("VLUNIT", "VLUNIT", JdeDataType.String, 16),
        new JdeField("VLMCU2", "VLMCU2", JdeDataType.String, 24),
        new JdeField("VLRMK", "VLRMK", JdeDataType.String, 60),
        new JdeField("VLRF", "VLRF", JdeDataType.String, 4),
        new JdeField("VLDRF", "VLDRF", JdeDataType.Numeric),
        new JdeField("VLCTL", "VLCTL", JdeDataType.String, 26),
        new JdeField("VLFNLP", "VLFNLP", JdeDataType.String, 2),
        new JdeField("VLU", "VLU", JdeDataType.Numeric),
        new JdeField("VLUM", "VLUM", JdeDataType.String, 4),
        new JdeField("VLPYIN", "VLPYIN", JdeDataType.String, 2),
        new JdeField("VLTXA3", "VLTXA3", JdeDataType.String, 20),
        new JdeField("VLEXR3", "VLEXR3", JdeDataType.String, 4),
        new JdeField("VLRP1", "VLRP1", JdeDataType.String, 2),
        new JdeField("VLRP2", "VLRP2", JdeDataType.String, 2),
        new JdeField("VLRP3", "VLRP3", JdeDataType.String, 2),
        new JdeField("VLAC07", "VLAC07", JdeDataType.String, 6),
        new JdeField("VLTNN", "VLTNN", JdeDataType.String, 2),
        new JdeField("VLDMCD", "VLDMCD", JdeDataType.String, 2),
        new JdeField("VLITM", "VLITM", JdeDataType.Numeric),
        new JdeField("VLHCRR", "VLHCRR", JdeDataType.Numeric),
        new JdeField("VLHDGJ", "VLHDGJ", JdeDataType.Numeric),
        new JdeField("VLURC1", "VLURC1", JdeDataType.String, 6),
        new JdeField("VLURDT", "VLURDT", JdeDataType.Numeric),
        new JdeField("VLURAT", "VLURAT", JdeDataType.Numeric),
        new JdeField("VLURAB", "VLURAB", JdeDataType.Numeric),
        new JdeField("VLURRF", "VLURRF", JdeDataType.String, 30),
        new JdeField("VLTORG", "VLTORG", JdeDataType.String, 20),
        new JdeField("VLUSER", "VLUSER", JdeDataType.String, 20),
        new JdeField("VLPID", "VLPID", JdeDataType.String, 20),
        new JdeField("VLUPMJ", "VLUPMJ", JdeDataType.Numeric),
        new JdeField("VLUPMT", "VLUPMT", JdeDataType.Numeric),
        new JdeField("VLJOBN", "VLJOBN", JdeDataType.String, 20),
        new JdeField("VLDIM", "VLDIM", JdeDataType.Numeric),
        new JdeField("VLDID", "VLDID", JdeDataType.Numeric),
        new JdeField("VLDIY", "VLDIY", JdeDataType.Numeric),
        new JdeField("VLDI#", "VLDI#", JdeDataType.Numeric),
        new JdeField("VLDSVM", "VLDSVM", JdeDataType.Numeric),
        new JdeField("VLDSVD", "VLDSVD", JdeDataType.Numeric),
        new JdeField("VLDSVY", "VLDSVY", JdeDataType.Numeric),
        new JdeField("VLDSV#", "VLDSV#", JdeDataType.Numeric),
        new JdeField("VLDDM", "VLDDM", JdeDataType.Numeric),
        new JdeField("VLDDD", "VLDDD", JdeDataType.Numeric),
        new JdeField("VLDDY", "VLDDY", JdeDataType.Numeric),
        new JdeField("VLDD#", "VLDD#", JdeDataType.Numeric),
        new JdeField("VLDDNM", "VLDDNM", JdeDataType.Numeric),
        new JdeField("VLDDND", "VLDDND", JdeDataType.Numeric),
        new JdeField("VLDDNY", "VLDDNY", JdeDataType.Numeric),
        new JdeField("VLDDN#", "VLDDN#", JdeDataType.Numeric),
        new JdeField("VLDGM", "VLDGM", JdeDataType.Numeric),
        new JdeField("VLDGD", "VLDGD", JdeDataType.Numeric),
        new JdeField("VLDGY", "VLDGY", JdeDataType.Numeric),
        new JdeField("VLDG#", "VLDG#", JdeDataType.Numeric),
        new JdeField("VLDICM", "VLDICM", JdeDataType.Numeric),
        new JdeField("VLDICD", "VLDICD", JdeDataType.Numeric),
        new JdeField("VLDICY", "VLDICY", JdeDataType.Numeric),
        new JdeField("VLDIC#", "VLDIC#", JdeDataType.Numeric),
        new JdeField("VLHDGM", "VLHDGM", JdeDataType.Numeric),
        new JdeField("VLHDGD", "VLHDGD", JdeDataType.Numeric),
        new JdeField("VLHDGY", "VLHDGY", JdeDataType.Numeric),
        new JdeField("VLHDG#", "VLHDG#", JdeDataType.Numeric),
        new JdeField("VLDOCM", "VLDOCM", JdeDataType.Numeric),
        new JdeField("VLTNST", "VLTNST", JdeDataType.String, 40),
        new JdeField("VLYC01", "VLYC01", JdeDataType.String, 6),
        new JdeField("VLYC02", "VLYC02", JdeDataType.String, 6),
        new JdeField("VLYC03", "VLYC03", JdeDataType.String, 6),
        new JdeField("VLYC04", "VLYC04", JdeDataType.String, 6),
        new JdeField("VLYC05", "VLYC05", JdeDataType.String, 6),
        new JdeField("VLYC06", "VLYC06", JdeDataType.String, 6),
        new JdeField("VLYC07", "VLYC07", JdeDataType.String, 6),
        new JdeField("VLYC08", "VLYC08", JdeDataType.String, 6),
        new JdeField("VLYC09", "VLYC09", JdeDataType.String, 6),
        new JdeField("VLYC10", "VLYC10", JdeDataType.String, 6),
        new JdeField("VLDTXS", "VLDTXS", JdeDataType.String, 2),
        new JdeField("VLBCRC", "VLBCRC", JdeDataType.String, 6),
        new JdeField("VLATAD", "VLATAD", JdeDataType.Numeric),
        new JdeField("VLCTAD", "VLCTAD", JdeDataType.Numeric),
        new JdeField("VLNRTA", "VLNRTA", JdeDataType.Numeric),
        new JdeField("VLFNRT", "VLFNRT", JdeDataType.Numeric),
        new JdeField("VLTAXP", "VLTAXP", JdeDataType.String, 2),
        new JdeField("VLPRGF", "VLPRGF", JdeDataType.String, 2),
        new JdeField("VLGFL5", "VLGFL5", JdeDataType.String, 2),
        new JdeField("VLGFL6", "VLGFL6", JdeDataType.String, 2),
        new JdeField("VLGAM1", "VLGAM1", JdeDataType.Numeric),
        new JdeField("VLGAM2", "VLGAM2", JdeDataType.Numeric),
        new JdeField("VLGEN4", "VLGEN4", JdeDataType.String, 50),
        new JdeField("VLGEN5", "VLGEN5", JdeDataType.String, 50),
        new JdeField("VLWTAD", "VLWTAD", JdeDataType.Numeric),
        new JdeField("VLWTAF", "VLWTAF", JdeDataType.Numeric),
        new JdeField("VLSMMF", "VLSMMF", JdeDataType.String, 2),
        new JdeField("VLPYWP", "VLPYWP", JdeDataType.String, 2),
        new JdeField("VLPWPG", "VLPWPG", JdeDataType.Numeric),
        new JdeField("VLNETST", "VLNETST", JdeDataType.String, 2),
        new JdeField("VLATFLG", "VLATFLG", JdeDataType.String, 2),
        new JdeField("VLATRL", "VLATRL", JdeDataType.String, 4),
        new JdeField("VLJOBS", "VLJOBS", JdeDataType.Numeric),
        new JdeField("VLPSTE", "VLPSTE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411Z1_0", "Primary Key on VLEDUS, VLEDBT, VLEDTN, VLEDLN", new[] { "VLEDUS", "VLEDBT", "VLEDTN", "VLEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
