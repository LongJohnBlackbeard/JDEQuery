using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1721 - .
/// </summary>
public class F1721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCOO.
        /// </summary>
        public const string CDKCOO = "CDKCOO";

        /// <summary>
        /// CDCOCH.
        /// </summary>
        public const string CDCOCH = "CDCOCH";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDDOC1.
        /// </summary>
        public const string CDDOC1 = "CDDOC1";

        /// <summary>
        /// CDDCT1.
        /// </summary>
        public const string CDDCT1 = "CDDCT1";

        /// <summary>
        /// CDSKCO.
        /// </summary>
        public const string CDSKCO = "CDSKCO";

        /// <summary>
        /// CDOSFX.
        /// </summary>
        public const string CDOSFX = "CDOSFX";

        /// <summary>
        /// CDLINN.
        /// </summary>
        public const string CDLINN = "CDLINN";

        /// <summary>
        /// CDDL01.
        /// </summary>
        public const string CDDL01 = "CDDL01";

        /// <summary>
        /// CDCSDT.
        /// </summary>
        public const string CDCSDT = "CDCSDT";

        /// <summary>
        /// CDCDTE.
        /// </summary>
        public const string CDCDTE = "CDCDTE";

        /// <summary>
        /// CDCHD.
        /// </summary>
        public const string CDCHD = "CDCHD";

        /// <summary>
        /// CDCHGST.
        /// </summary>
        public const string CDCHGST = "CDCHGST";

        /// <summary>
        /// CDMCUS.
        /// </summary>
        public const string CDMCUS = "CDMCUS";

        /// <summary>
        /// CDAID.
        /// </summary>
        public const string CDAID = "CDAID";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDOBJ.
        /// </summary>
        public const string CDOBJ = "CDOBJ";

        /// <summary>
        /// CDSUB.
        /// </summary>
        public const string CDSUB = "CDSUB";

        /// <summary>
        /// CDSBL.
        /// </summary>
        public const string CDSBL = "CDSBL";

        /// <summary>
        /// CDSBLT.
        /// </summary>
        public const string CDSBLT = "CDSBLT";

        /// <summary>
        /// CDCO.
        /// </summary>
        public const string CDCO = "CDCO";

        /// <summary>
        /// CDGLC.
        /// </summary>
        public const string CDGLC = "CDGLC";

        /// <summary>
        /// CDGLCCV.
        /// </summary>
        public const string CDGLCCV = "CDGLCCV";

        /// <summary>
        /// CDGLCNC.
        /// </summary>
        public const string CDGLCNC = "CDGLCNC";

        /// <summary>
        /// CDLNTY.
        /// </summary>
        public const string CDLNTY = "CDLNTY";

        /// <summary>
        /// CDAN8.
        /// </summary>
        public const string CDAN8 = "CDAN8";

        /// <summary>
        /// CDSHAN.
        /// </summary>
        public const string CDSHAN = "CDSHAN";

        /// <summary>
        /// CDANOB.
        /// </summary>
        public const string CDANOB = "CDANOB";

        /// <summary>
        /// CDLANO.
        /// </summary>
        public const string CDLANO = "CDLANO";

        /// <summary>
        /// CDPEFJ.
        /// </summary>
        public const string CDPEFJ = "CDPEFJ";

        /// <summary>
        /// CDEXR1.
        /// </summary>
        public const string CDEXR1 = "CDEXR1";

        /// <summary>
        /// CDTXA1.
        /// </summary>
        public const string CDTXA1 = "CDTXA1";

        /// <summary>
        /// CDTAX1.
        /// </summary>
        public const string CDTAX1 = "CDTAX1";

        /// <summary>
        /// CDPRODF.
        /// </summary>
        public const string CDPRODF = "CDPRODF";

        /// <summary>
        /// CDPRODM.
        /// </summary>
        public const string CDPRODM = "CDPRODM";

        /// <summary>
        /// CDNUMB.
        /// </summary>
        public const string CDNUMB = "CDNUMB";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDLITM.
        /// </summary>
        public const string CDLITM = "CDLITM";

        /// <summary>
        /// CDAITM.
        /// </summary>
        public const string CDAITM = "CDAITM";

        /// <summary>
        /// CDLOTN.
        /// </summary>
        public const string CDLOTN = "CDLOTN";

        /// <summary>
        /// CDLOTT.
        /// </summary>
        public const string CDLOTT = "CDLOTT";

        /// <summary>
        /// CDSERP.
        /// </summary>
        public const string CDSERP = "CDSERP";

        /// <summary>
        /// CDCOVGR.
        /// </summary>
        public const string CDCOVGR = "CDCOVGR";

        /// <summary>
        /// CDMMCU.
        /// </summary>
        public const string CDMMCU = "CDMMCU";

        /// <summary>
        /// CDPRODC.
        /// </summary>
        public const string CDPRODC = "CDPRODC";

        /// <summary>
        /// CDCNDJ.
        /// </summary>
        public const string CDCNDJ = "CDCNDJ";

        /// <summary>
        /// CDCNRC.
        /// </summary>
        public const string CDCNRC = "CDCNRC";

        /// <summary>
        /// CDCDUR.
        /// </summary>
        public const string CDCDUR = "CDCDUR";

        /// <summary>
        /// CDDAYSC.
        /// </summary>
        public const string CDDAYSC = "CDDAYSC";

        /// <summary>
        /// CDBILLF.
        /// </summary>
        public const string CDBILLF = "CDBILLF";

        /// <summary>
        /// CDYN.
        /// </summary>
        public const string CDYN = "CDYN";

        /// <summary>
        /// CDADAR.
        /// </summary>
        public const string CDADAR = "CDADAR";

        /// <summary>
        /// CDBDUR.
        /// </summary>
        public const string CDBDUR = "CDBDUR";

        /// <summary>
        /// CDBLFC.
        /// </summary>
        public const string CDBLFC = "CDBLFC";

        /// <summary>
        /// CDDOM.
        /// </summary>
        public const string CDDOM = "CDDOM";

        /// <summary>
        /// CDBUM.
        /// </summary>
        public const string CDBUM = "CDBUM";

        /// <summary>
        /// CDBTFR.
        /// </summary>
        public const string CDBTFR = "CDBTFR";

        /// <summary>
        /// CDBTDT.
        /// </summary>
        public const string CDBTDT = "CDBTDT";

        /// <summary>
        /// CDRNWDT.
        /// </summary>
        public const string CDRNWDT = "CDRNWDT";

        /// <summary>
        /// CDDGL.
        /// </summary>
        public const string CDDGL = "CDDGL";

        /// <summary>
        /// CDUOM4.
        /// </summary>
        public const string CDUOM4 = "CDUOM4";

        /// <summary>
        /// CDUM.
        /// </summary>
        public const string CDUM = "CDUM";

        /// <summary>
        /// CDU.
        /// </summary>
        public const string CDU = "CDU";

        /// <summary>
        /// CDUP.
        /// </summary>
        public const string CDUP = "CDUP";

        /// <summary>
        /// CDFUPC.
        /// </summary>
        public const string CDFUPC = "CDFUPC";

        /// <summary>
        /// CDAMTCD.
        /// </summary>
        public const string CDAMTCD = "CDAMTCD";

        /// <summary>
        /// CDAMTCF.
        /// </summary>
        public const string CDAMTCF = "CDAMTCF";

        /// <summary>
        /// CDCANDM.
        /// </summary>
        public const string CDCANDM = "CDCANDM";

        /// <summary>
        /// CDCANFN.
        /// </summary>
        public const string CDCANFN = "CDCANFN";

        /// <summary>
        /// CDRRBA.
        /// </summary>
        public const string CDRRBA = "CDRRBA";

        /// <summary>
        /// CDFRBA.
        /// </summary>
        public const string CDFRBA = "CDFRBA";

        /// <summary>
        /// CDAEXP.
        /// </summary>
        public const string CDAEXP = "CDAEXP";

        /// <summary>
        /// CDFEA.
        /// </summary>
        public const string CDFEA = "CDFEA";

        /// <summary>
        /// CDTOTD.
        /// </summary>
        public const string CDTOTD = "CDTOTD";

        /// <summary>
        /// CDFOAG.
        /// </summary>
        public const string CDFOAG = "CDFOAG";

        /// <summary>
        /// CDDSCT.
        /// </summary>
        public const string CDDSCT = "CDDSCT";

        /// <summary>
        /// CDCDSA.
        /// </summary>
        public const string CDCDSA = "CDCDSA";

        /// <summary>
        /// CDSTAM.
        /// </summary>
        public const string CDSTAM = "CDSTAM";

        /// <summary>
        /// CDATXN.
        /// </summary>
        public const string CDATXN = "CDATXN";

        /// <summary>
        /// CDATXA.
        /// </summary>
        public const string CDATXA = "CDATXA";

        /// <summary>
        /// CDAA1.
        /// </summary>
        public const string CDAA1 = "CDAA1";

        /// <summary>
        /// CDAA2.
        /// </summary>
        public const string CDAA2 = "CDAA2";

        /// <summary>
        /// CDUREC.
        /// </summary>
        public const string CDUREC = "CDUREC";

        /// <summary>
        /// CDUOPN.
        /// </summary>
        public const string CDUOPN = "CDUOPN";

        /// <summary>
        /// CDAREC.
        /// </summary>
        public const string CDAREC = "CDAREC";

        /// <summary>
        /// CDFREC.
        /// </summary>
        public const string CDFREC = "CDFREC";

        /// <summary>
        /// CDAOPN.
        /// </summary>
        public const string CDAOPN = "CDAOPN";

        /// <summary>
        /// CDFOPN.
        /// </summary>
        public const string CDFOPN = "CDFOPN";

        /// <summary>
        /// CDMXMET1.
        /// </summary>
        public const string CDMXMET1 = "CDMXMET1";

        /// <summary>
        /// CDMXMET2.
        /// </summary>
        public const string CDMXMET2 = "CDMXMET2";

        /// <summary>
        /// CDMXMET3.
        /// </summary>
        public const string CDMXMET3 = "CDMXMET3";

        /// <summary>
        /// CDDAILY.
        /// </summary>
        public const string CDDAILY = "CDDAILY";

        /// <summary>
        /// CDPTC.
        /// </summary>
        public const string CDPTC = "CDPTC";

        /// <summary>
        /// CDRYIN.
        /// </summary>
        public const string CDRYIN = "CDRYIN";

        /// <summary>
        /// CDSSDJ.
        /// </summary>
        public const string CDSSDJ = "CDSSDJ";

        /// <summary>
        /// CDBSUSP.
        /// </summary>
        public const string CDBSUSP = "CDBSUSP";

        /// <summary>
        /// CDCD01.
        /// </summary>
        public const string CDCD01 = "CDCD01";

        /// <summary>
        /// CDCD02.
        /// </summary>
        public const string CDCD02 = "CDCD02";

        /// <summary>
        /// CDCD03.
        /// </summary>
        public const string CDCD03 = "CDCD03";

        /// <summary>
        /// CDCD04.
        /// </summary>
        public const string CDCD04 = "CDCD04";

        /// <summary>
        /// CDCD05.
        /// </summary>
        public const string CDCD05 = "CDCD05";

        /// <summary>
        /// CDRNFLG.
        /// </summary>
        public const string CDRNFLG = "CDRNFLG";

        /// <summary>
        /// CDBSWAR.
        /// </summary>
        public const string CDBSWAR = "CDBSWAR";

        /// <summary>
        /// CDBTF05.
        /// </summary>
        public const string CDBTF05 = "CDBTF05";

        /// <summary>
        /// CDWRLFL.
        /// </summary>
        public const string CDWRLFL = "CDWRLFL";

        /// <summary>
        /// CDCRR.
        /// </summary>
        public const string CDCRR = "CDCRR";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDCRCF.
        /// </summary>
        public const string CDCRCF = "CDCRCF";

        /// <summary>
        /// CDCRRD.
        /// </summary>
        public const string CDCRRD = "CDCRRD";

        /// <summary>
        /// CDCRRM.
        /// </summary>
        public const string CDCRRM = "CDCRRM";

        /// <summary>
        /// CDDSFT.
        /// </summary>
        public const string CDDSFT = "CDDSFT";

        /// <summary>
        /// CDDSPC.
        /// </summary>
        public const string CDDSPC = "CDDSPC";

        /// <summary>
        /// CDUOM2.
        /// </summary>
        public const string CDUOM2 = "CDUOM2";

        /// <summary>
        /// CDVR01.
        /// </summary>
        public const string CDVR01 = "CDVR01";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDCRTU.
        /// </summary>
        public const string CDCRTU = "CDCRTU";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDASN1.
        /// </summary>
        public const string CDASN1 = "CDASN1";

        /// <summary>
        /// CDASN2.
        /// </summary>
        public const string CDASN2 = "CDASN2";

        /// <summary>
        /// CDPCPR.
        /// </summary>
        public const string CDPCPR = "CDPCPR";

        /// <summary>
        /// CDAN8PB.
        /// </summary>
        public const string CDAN8PB = "CDAN8PB";

        /// <summary>
        /// CDADPRF.
        /// </summary>
        public const string CDADPRF = "CDADPRF";
    }

    /// <inheritdoc />
    public override string TableName => "F1721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4),
        new JdeField("CDKCOO", "CDKCOO", JdeDataType.String, 10),
        new JdeField("CDCOCH", "CDCOCH", JdeDataType.String, 6, true, true),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDOC1", "CDDOC1", JdeDataType.Numeric),
        new JdeField("CDDCT1", "CDDCT1", JdeDataType.String, 4),
        new JdeField("CDSKCO", "CDSKCO", JdeDataType.String, 10),
        new JdeField("CDOSFX", "CDOSFX", JdeDataType.String, 6),
        new JdeField("CDLINN", "CDLINN", JdeDataType.Numeric),
        new JdeField("CDDL01", "CDDL01", JdeDataType.String, 60),
        new JdeField("CDCSDT", "CDCSDT", JdeDataType.Numeric),
        new JdeField("CDCDTE", "CDCDTE", JdeDataType.Numeric),
        new JdeField("CDCHD", "CDCHD", JdeDataType.Numeric),
        new JdeField("CDCHGST", "CDCHGST", JdeDataType.String, 4),
        new JdeField("CDMCUS", "CDMCUS", JdeDataType.String, 24),
        new JdeField("CDAID", "CDAID", JdeDataType.String, 16),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDOBJ", "CDOBJ", JdeDataType.String, 12),
        new JdeField("CDSUB", "CDSUB", JdeDataType.String, 16),
        new JdeField("CDSBL", "CDSBL", JdeDataType.String, 16),
        new JdeField("CDSBLT", "CDSBLT", JdeDataType.String, 2),
        new JdeField("CDCO", "CDCO", JdeDataType.String, 10),
        new JdeField("CDGLC", "CDGLC", JdeDataType.String, 8),
        new JdeField("CDGLCCV", "CDGLCCV", JdeDataType.String, 8),
        new JdeField("CDGLCNC", "CDGLCNC", JdeDataType.String, 8),
        new JdeField("CDLNTY", "CDLNTY", JdeDataType.String, 4),
        new JdeField("CDAN8", "CDAN8", JdeDataType.Numeric),
        new JdeField("CDSHAN", "CDSHAN", JdeDataType.Numeric),
        new JdeField("CDANOB", "CDANOB", JdeDataType.Numeric),
        new JdeField("CDLANO", "CDLANO", JdeDataType.Numeric),
        new JdeField("CDPEFJ", "CDPEFJ", JdeDataType.Numeric),
        new JdeField("CDEXR1", "CDEXR1", JdeDataType.String, 4),
        new JdeField("CDTXA1", "CDTXA1", JdeDataType.String, 20),
        new JdeField("CDTAX1", "CDTAX1", JdeDataType.String, 2),
        new JdeField("CDPRODF", "CDPRODF", JdeDataType.String, 16),
        new JdeField("CDPRODM", "CDPRODM", JdeDataType.String, 16),
        new JdeField("CDNUMB", "CDNUMB", JdeDataType.Numeric),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDLITM", "CDLITM", JdeDataType.String, 50),
        new JdeField("CDAITM", "CDAITM", JdeDataType.String, 50),
        new JdeField("CDLOTN", "CDLOTN", JdeDataType.String, 60),
        new JdeField("CDLOTT", "CDLOTT", JdeDataType.String, 60),
        new JdeField("CDSERP", "CDSERP", JdeDataType.String, 16),
        new JdeField("CDCOVGR", "CDCOVGR", JdeDataType.String, 16),
        new JdeField("CDMMCU", "CDMMCU", JdeDataType.String, 24),
        new JdeField("CDPRODC", "CDPRODC", JdeDataType.String, 20),
        new JdeField("CDCNDJ", "CDCNDJ", JdeDataType.Numeric),
        new JdeField("CDCNRC", "CDCNRC", JdeDataType.String, 6),
        new JdeField("CDCDUR", "CDCDUR", JdeDataType.Numeric),
        new JdeField("CDDAYSC", "CDDAYSC", JdeDataType.Numeric),
        new JdeField("CDBILLF", "CDBILLF", JdeDataType.String, 2),
        new JdeField("CDYN", "CDYN", JdeDataType.String, 2),
        new JdeField("CDADAR", "CDADAR", JdeDataType.String, 2),
        new JdeField("CDBDUR", "CDBDUR", JdeDataType.Numeric),
        new JdeField("CDBLFC", "CDBLFC", JdeDataType.String, 2),
        new JdeField("CDDOM", "CDDOM", JdeDataType.Numeric),
        new JdeField("CDBUM", "CDBUM", JdeDataType.String, 4),
        new JdeField("CDBTFR", "CDBTFR", JdeDataType.Numeric),
        new JdeField("CDBTDT", "CDBTDT", JdeDataType.Numeric),
        new JdeField("CDRNWDT", "CDRNWDT", JdeDataType.Numeric),
        new JdeField("CDDGL", "CDDGL", JdeDataType.Numeric),
        new JdeField("CDUOM4", "CDUOM4", JdeDataType.String, 4),
        new JdeField("CDUM", "CDUM", JdeDataType.String, 4),
        new JdeField("CDU", "CDU", JdeDataType.Numeric),
        new JdeField("CDUP", "CDUP", JdeDataType.Numeric),
        new JdeField("CDFUPC", "CDFUPC", JdeDataType.Numeric),
        new JdeField("CDAMTCD", "CDAMTCD", JdeDataType.Numeric),
        new JdeField("CDAMTCF", "CDAMTCF", JdeDataType.Numeric),
        new JdeField("CDCANDM", "CDCANDM", JdeDataType.Numeric),
        new JdeField("CDCANFN", "CDCANFN", JdeDataType.Numeric),
        new JdeField("CDRRBA", "CDRRBA", JdeDataType.Numeric),
        new JdeField("CDFRBA", "CDFRBA", JdeDataType.Numeric),
        new JdeField("CDAEXP", "CDAEXP", JdeDataType.Numeric),
        new JdeField("CDFEA", "CDFEA", JdeDataType.Numeric),
        new JdeField("CDTOTD", "CDTOTD", JdeDataType.Numeric),
        new JdeField("CDFOAG", "CDFOAG", JdeDataType.Numeric),
        new JdeField("CDDSCT", "CDDSCT", JdeDataType.Numeric),
        new JdeField("CDCDSA", "CDCDSA", JdeDataType.Numeric),
        new JdeField("CDSTAM", "CDSTAM", JdeDataType.Numeric),
        new JdeField("CDATXN", "CDATXN", JdeDataType.Numeric),
        new JdeField("CDATXA", "CDATXA", JdeDataType.Numeric),
        new JdeField("CDAA1", "CDAA1", JdeDataType.Numeric),
        new JdeField("CDAA2", "CDAA2", JdeDataType.Numeric),
        new JdeField("CDUREC", "CDUREC", JdeDataType.Numeric),
        new JdeField("CDUOPN", "CDUOPN", JdeDataType.Numeric),
        new JdeField("CDAREC", "CDAREC", JdeDataType.Numeric),
        new JdeField("CDFREC", "CDFREC", JdeDataType.Numeric),
        new JdeField("CDAOPN", "CDAOPN", JdeDataType.Numeric),
        new JdeField("CDFOPN", "CDFOPN", JdeDataType.Numeric),
        new JdeField("CDMXMET1", "CDMXMET1", JdeDataType.Numeric),
        new JdeField("CDMXMET2", "CDMXMET2", JdeDataType.Numeric),
        new JdeField("CDMXMET3", "CDMXMET3", JdeDataType.Numeric),
        new JdeField("CDDAILY", "CDDAILY", JdeDataType.Numeric),
        new JdeField("CDPTC", "CDPTC", JdeDataType.String, 6),
        new JdeField("CDRYIN", "CDRYIN", JdeDataType.String, 2),
        new JdeField("CDSSDJ", "CDSSDJ", JdeDataType.Numeric),
        new JdeField("CDBSUSP", "CDBSUSP", JdeDataType.String, 2),
        new JdeField("CDCD01", "CDCD01", JdeDataType.String, 16),
        new JdeField("CDCD02", "CDCD02", JdeDataType.String, 16),
        new JdeField("CDCD03", "CDCD03", JdeDataType.String, 20),
        new JdeField("CDCD04", "CDCD04", JdeDataType.String, 20),
        new JdeField("CDCD05", "CDCD05", JdeDataType.String, 20),
        new JdeField("CDRNFLG", "CDRNFLG", JdeDataType.String, 2),
        new JdeField("CDBSWAR", "CDBSWAR", JdeDataType.String, 2),
        new JdeField("CDBTF05", "CDBTF05", JdeDataType.String, 2),
        new JdeField("CDWRLFL", "CDWRLFL", JdeDataType.Numeric),
        new JdeField("CDCRR", "CDCRR", JdeDataType.Numeric),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDCRCF", "CDCRCF", JdeDataType.String, 6),
        new JdeField("CDCRRD", "CDCRRD", JdeDataType.Numeric),
        new JdeField("CDCRRM", "CDCRRM", JdeDataType.String, 2),
        new JdeField("CDDSFT", "CDDSFT", JdeDataType.String, 2),
        new JdeField("CDDSPC", "CDDSPC", JdeDataType.Numeric),
        new JdeField("CDUOM2", "CDUOM2", JdeDataType.String, 4),
        new JdeField("CDVR01", "CDVR01", JdeDataType.String, 50),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDCRTU", "CDCRTU", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDASN1", "CDASN1", JdeDataType.String, 16),
        new JdeField("CDASN2", "CDASN2", JdeDataType.String, 16),
        new JdeField("CDPCPR", "CDPCPR", JdeDataType.Numeric),
        new JdeField("CDAN8PB", "CDAN8PB", JdeDataType.Numeric),
        new JdeField("CDADPRF", "CDADPRF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1721_0", "Primary Key on CDDOCO, CDCOCH, CDLNID", new[] { "CDDOCO", "CDCOCH", "CDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1721_2", "Index on CDAN8, CDLNTY", new[] { "CDAN8", "CDLNTY" }),
        new JdeIndex("F1721_3", "Index on CDLNTY, CDNUMB", new[] { "CDLNTY", "CDNUMB" }),
        new JdeIndex("F1721_4", "Index on CDLANO, CDLNTY", new[] { "CDLANO", "CDLNTY" }),
        new JdeIndex("F1721_5", "Index on CDDOCO, CDCOCH, SYS_NC00133$", new[] { "CDDOCO", "CDCOCH", "SYS_NC00133$" }),
        new JdeIndex("F1721_6", "Index on CDAN8, CDDCTO", new[] { "CDAN8", "CDDCTO" }),
        new JdeIndex("F1721_7", "Index on CDNUMB", new[] { "CDNUMB" })
    };
}
