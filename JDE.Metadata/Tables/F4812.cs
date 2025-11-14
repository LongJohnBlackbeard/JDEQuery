using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4812 - .
/// </summary>
public class F4812 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDDCT.
        /// </summary>
        public const string WDDCT = "WDDCT";

        /// <summary>
        /// WDDOC.
        /// </summary>
        public const string WDDOC = "WDDOC";

        /// <summary>
        /// WDKCO.
        /// </summary>
        public const string WDKCO = "WDKCO";

        /// <summary>
        /// WDDGL.
        /// </summary>
        public const string WDDGL = "WDDGL";

        /// <summary>
        /// WDJELN.
        /// </summary>
        public const string WDJELN = "WDJELN";

        /// <summary>
        /// WDAID.
        /// </summary>
        public const string WDAID = "WDAID";

        /// <summary>
        /// WDMCU.
        /// </summary>
        public const string WDMCU = "WDMCU";

        /// <summary>
        /// WDRP11.
        /// </summary>
        public const string WDRP11 = "WDRP11";

        /// <summary>
        /// WDOBJ.
        /// </summary>
        public const string WDOBJ = "WDOBJ";

        /// <summary>
        /// WDSUB.
        /// </summary>
        public const string WDSUB = "WDSUB";

        /// <summary>
        /// WDSBL.
        /// </summary>
        public const string WDSBL = "WDSBL";

        /// <summary>
        /// WDSBLT.
        /// </summary>
        public const string WDSBLT = "WDSBLT";

        /// <summary>
        /// WDOPSQ.
        /// </summary>
        public const string WDOPSQ = "WDOPSQ";

        /// <summary>
        /// WDWR01.
        /// </summary>
        public const string WDWR01 = "WDWR01";

        /// <summary>
        /// WDWR07.
        /// </summary>
        public const string WDWR07 = "WDWR07";

        /// <summary>
        /// WDLT.
        /// </summary>
        public const string WDLT = "WDLT";

        /// <summary>
        /// WDCTRY.
        /// </summary>
        public const string WDCTRY = "WDCTRY";

        /// <summary>
        /// WDFY.
        /// </summary>
        public const string WDFY = "WDFY";

        /// <summary>
        /// WDPN.
        /// </summary>
        public const string WDPN = "WDPN";

        /// <summary>
        /// WDCO.
        /// </summary>
        public const string WDCO = "WDCO";

        /// <summary>
        /// WDODCT.
        /// </summary>
        public const string WDODCT = "WDODCT";

        /// <summary>
        /// WDOSFX.
        /// </summary>
        public const string WDOSFX = "WDOSFX";

        /// <summary>
        /// WDODOC.
        /// </summary>
        public const string WDODOC = "WDODOC";

        /// <summary>
        /// WDOKCO.
        /// </summary>
        public const string WDOKCO = "WDOKCO";

        /// <summary>
        /// WDPO.
        /// </summary>
        public const string WDPO = "WDPO";

        /// <summary>
        /// WDPDCT.
        /// </summary>
        public const string WDPDCT = "WDPDCT";

        /// <summary>
        /// WDPKCO.
        /// </summary>
        public const string WDPKCO = "WDPKCO";

        /// <summary>
        /// WDPSFX.
        /// </summary>
        public const string WDPSFX = "WDPSFX";

        /// <summary>
        /// WDOGNO.
        /// </summary>
        public const string WDOGNO = "WDOGNO";

        /// <summary>
        /// WDR001.
        /// </summary>
        public const string WDR001 = "WDR001";

        /// <summary>
        /// WDR002.
        /// </summary>
        public const string WDR002 = "WDR002";

        /// <summary>
        /// WDR003.
        /// </summary>
        public const string WDR003 = "WDR003";

        /// <summary>
        /// WDPRTR.
        /// </summary>
        public const string WDPRTR = "WDPRTR";

        /// <summary>
        /// WDJBCD.
        /// </summary>
        public const string WDJBCD = "WDJBCD";

        /// <summary>
        /// WDJBST.
        /// </summary>
        public const string WDJBST = "WDJBST";

        /// <summary>
        /// WDPDBA.
        /// </summary>
        public const string WDPDBA = "WDPDBA";

        /// <summary>
        /// WDPTAX.
        /// </summary>
        public const string WDPTAX = "WDPTAX";

        /// <summary>
        /// WDEQCG.
        /// </summary>
        public const string WDEQCG = "WDEQCG";

        /// <summary>
        /// WDEQWO.
        /// </summary>
        public const string WDEQWO = "WDEQWO";

        /// <summary>
        /// WDACL0.
        /// </summary>
        public const string WDACL0 = "WDACL0";

        /// <summary>
        /// WDERC.
        /// </summary>
        public const string WDERC = "WDERC";

        /// <summary>
        /// WDAN8.
        /// </summary>
        public const string WDAN8 = "WDAN8";

        /// <summary>
        /// WDDC.
        /// </summary>
        public const string WDDC = "WDDC";

        /// <summary>
        /// WDHMCU.
        /// </summary>
        public const string WDHMCU = "WDHMCU";

        /// <summary>
        /// WDJMCU.
        /// </summary>
        public const string WDJMCU = "WDJMCU";

        /// <summary>
        /// WDRP12.
        /// </summary>
        public const string WDRP12 = "WDRP12";

        /// <summary>
        /// WDDSVJ.
        /// </summary>
        public const string WDDSVJ = "WDDSVJ";

        /// <summary>
        /// WDDAGO.
        /// </summary>
        public const string WDDAGO = "WDDAGO";

        /// <summary>
        /// WDAGS.
        /// </summary>
        public const string WDAGS = "WDAGS";

        /// <summary>
        /// WDEXA.
        /// </summary>
        public const string WDEXA = "WDEXA";

        /// <summary>
        /// WDEXR.
        /// </summary>
        public const string WDEXR = "WDEXR";

        /// <summary>
        /// WDPCFG.
        /// </summary>
        public const string WDPCFG = "WDPCFG";

        /// <summary>
        /// WDPRIC.
        /// </summary>
        public const string WDPRIC = "WDPRIC";

        /// <summary>
        /// WDU.
        /// </summary>
        public const string WDU = "WDU";

        /// <summary>
        /// WDUM.
        /// </summary>
        public const string WDUM = "WDUM";

        /// <summary>
        /// WDAA.
        /// </summary>
        public const string WDAA = "WDAA";

        /// <summary>
        /// WDDOCM.
        /// </summary>
        public const string WDDOCM = "WDDOCM";

        /// <summary>
        /// WDDOCO.
        /// </summary>
        public const string WDDOCO = "WDDOCO";

        /// <summary>
        /// WDDCTO.
        /// </summary>
        public const string WDDCTO = "WDDCTO";

        /// <summary>
        /// WDKCOO.
        /// </summary>
        public const string WDKCOO = "WDKCOO";

        /// <summary>
        /// WDCOCH.
        /// </summary>
        public const string WDCOCH = "WDCOCH";

        /// <summary>
        /// WDLNID.
        /// </summary>
        public const string WDLNID = "WDLNID";

        /// <summary>
        /// WDOPIM.
        /// </summary>
        public const string WDOPIM = "WDOPIM";

        /// <summary>
        /// WDPCTN.
        /// </summary>
        public const string WDPCTN = "WDPCTN";

        /// <summary>
        /// WDPCTT.
        /// </summary>
        public const string WDPCTT = "WDPCTT";

        /// <summary>
        /// WDPCKO.
        /// </summary>
        public const string WDPCKO = "WDPCKO";

        /// <summary>
        /// WDPRSQ.
        /// </summary>
        public const string WDPRSQ = "WDPRSQ";

        /// <summary>
        /// WDSBSQ.
        /// </summary>
        public const string WDSBSQ = "WDSBSQ";

        /// <summary>
        /// WDSCSQ.
        /// </summary>
        public const string WDSCSQ = "WDSCSQ";

        /// <summary>
        /// WDBCI.
        /// </summary>
        public const string WDBCI = "WDBCI";

        /// <summary>
        /// WDLSSQ.
        /// </summary>
        public const string WDLSSQ = "WDLSSQ";

        /// <summary>
        /// WDPMSQ.
        /// </summary>
        public const string WDPMSQ = "WDPMSQ";

        /// <summary>
        /// WDLSPM.
        /// </summary>
        public const string WDLSPM = "WDLSPM";

        /// <summary>
        /// WDTCLS.
        /// </summary>
        public const string WDTCLS = "WDTCLS";

        /// <summary>
        /// WDELGC.
        /// </summary>
        public const string WDELGC = "WDELGC";

        /// <summary>
        /// WDJRST.
        /// </summary>
        public const string WDJRST = "WDJRST";

        /// <summary>
        /// WDICUJ.
        /// </summary>
        public const string WDICUJ = "WDICUJ";

        /// <summary>
        /// WDIVD.
        /// </summary>
        public const string WDIVD = "WDIVD";

        /// <summary>
        /// WDHLD.
        /// </summary>
        public const string WDHLD = "WDHLD";

        /// <summary>
        /// WDRDJ.
        /// </summary>
        public const string WDRDJ = "WDRDJ";

        /// <summary>
        /// WDVOID.
        /// </summary>
        public const string WDVOID = "WDVOID";

        /// <summary>
        /// WDICUA.
        /// </summary>
        public const string WDICUA = "WDICUA";

        /// <summary>
        /// WDJRSP.
        /// </summary>
        public const string WDJRSP = "WDJRSP";

        /// <summary>
        /// WDBDPN.
        /// </summary>
        public const string WDBDPN = "WDBDPN";

        /// <summary>
        /// WDSLNK.
        /// </summary>
        public const string WDSLNK = "WDSLNK";

        /// <summary>
        /// WDCLNK.
        /// </summary>
        public const string WDCLNK = "WDCLNK";

        /// <summary>
        /// WDCCOD.
        /// </summary>
        public const string WDCCOD = "WDCCOD";

        /// <summary>
        /// WDCCR.
        /// </summary>
        public const string WDCCR = "WDCCR";

        /// <summary>
        /// WDCINR.
        /// </summary>
        public const string WDCINR = "WDCINR";

        /// <summary>
        /// WDCRVR.
        /// </summary>
        public const string WDCRVR = "WDCRVR";

        /// <summary>
        /// WDSBAR.
        /// </summary>
        public const string WDSBAR = "WDSBAR";

        /// <summary>
        /// WDTBDT.
        /// </summary>
        public const string WDTBDT = "WDTBDT";

        /// <summary>
        /// WDCAP.
        /// </summary>
        public const string WDCAP = "WDCAP";

        /// <summary>
        /// WDBRT.
        /// </summary>
        public const string WDBRT = "WDBRT";

        /// <summary>
        /// WDPERT.
        /// </summary>
        public const string WDPERT = "WDPERT";

        /// <summary>
        /// WDADCR.
        /// </summary>
        public const string WDADCR = "WDADCR";

        /// <summary>
        /// WDCAPI.
        /// </summary>
        public const string WDCAPI = "WDCAPI";

        /// <summary>
        /// WDBRTI.
        /// </summary>
        public const string WDBRTI = "WDBRTI";

        /// <summary>
        /// WDPCIM.
        /// </summary>
        public const string WDPCIM = "WDPCIM";

        /// <summary>
        /// WDADCI.
        /// </summary>
        public const string WDADCI = "WDADCI";

        /// <summary>
        /// WDTX.
        /// </summary>
        public const string WDTX = "WDTX";

        /// <summary>
        /// WDTOG.
        /// </summary>
        public const string WDTOG = "WDTOG";

        /// <summary>
        /// WDEXR1.
        /// </summary>
        public const string WDEXR1 = "WDEXR1";

        /// <summary>
        /// WDTXA1.
        /// </summary>
        public const string WDTXA1 = "WDTXA1";

        /// <summary>
        /// WDDCP.
        /// </summary>
        public const string WDDCP = "WDDCP";

        /// <summary>
        /// WDJTAX.
        /// </summary>
        public const string WDJTAX = "WDJTAX";

        /// <summary>
        /// WDJTXF.
        /// </summary>
        public const string WDJTXF = "WDJTXF";

        /// <summary>
        /// WDBTOL.
        /// </summary>
        public const string WDBTOL = "WDBTOL";

        /// <summary>
        /// WDCRCD.
        /// </summary>
        public const string WDCRCD = "WDCRCD";

        /// <summary>
        /// WDCRR.
        /// </summary>
        public const string WDCRR = "WDCRR";

        /// <summary>
        /// WDCRRM.
        /// </summary>
        public const string WDCRRM = "WDCRRM";

        /// <summary>
        /// WDFTOL.
        /// </summary>
        public const string WDFTOL = "WDFTOL";

        /// <summary>
        /// WDITOL.
        /// </summary>
        public const string WDITOL = "WDITOL";

        /// <summary>
        /// WDITXA.
        /// </summary>
        public const string WDITXA = "WDITXA";

        /// <summary>
        /// WDITAM.
        /// </summary>
        public const string WDITAM = "WDITAM";

        /// <summary>
        /// WDIDSC.
        /// </summary>
        public const string WDIDSC = "WDIDSC";

        /// <summary>
        /// WDCITL.
        /// </summary>
        public const string WDCITL = "WDCITL";

        /// <summary>
        /// WDCITA.
        /// </summary>
        public const string WDCITA = "WDCITA";

        /// <summary>
        /// WDCITX.
        /// </summary>
        public const string WDCITX = "WDCITX";

        /// <summary>
        /// WDCIDS.
        /// </summary>
        public const string WDCIDS = "WDCIDS";

        /// <summary>
        /// WDIJST.
        /// </summary>
        public const string WDIJST = "WDIJST";

        /// <summary>
        /// WDPRTF.
        /// </summary>
        public const string WDPRTF = "WDPRTF";

        /// <summary>
        /// WDICU.
        /// </summary>
        public const string WDICU = "WDICU";

        /// <summary>
        /// WDAN8O.
        /// </summary>
        public const string WDAN8O = "WDAN8O";

        /// <summary>
        /// WDVINV.
        /// </summary>
        public const string WDVINV = "WDVINV";

        /// <summary>
        /// WDDI.
        /// </summary>
        public const string WDDI = "WDDI";

        /// <summary>
        /// WDDOCZ.
        /// </summary>
        public const string WDDOCZ = "WDDOCZ";

        /// <summary>
        /// WDDCTI.
        /// </summary>
        public const string WDDCTI = "WDDCTI";

        /// <summary>
        /// WDKCOI.
        /// </summary>
        public const string WDKCOI = "WDKCOI";

        /// <summary>
        /// WDSFX.
        /// </summary>
        public const string WDSFX = "WDSFX";

        /// <summary>
        /// WDSBSK.
        /// </summary>
        public const string WDSBSK = "WDSBSK";

        /// <summary>
        /// WDBLKK.
        /// </summary>
        public const string WDBLKK = "WDBLKK";

        /// <summary>
        /// WDAID5.
        /// </summary>
        public const string WDAID5 = "WDAID5";

        /// <summary>
        /// WDSBL5.
        /// </summary>
        public const string WDSBL5 = "WDSBL5";

        /// <summary>
        /// WDSBT5.
        /// </summary>
        public const string WDSBT5 = "WDSBT5";

        /// <summary>
        /// WDAID6.
        /// </summary>
        public const string WDAID6 = "WDAID6";

        /// <summary>
        /// WDSBL6.
        /// </summary>
        public const string WDSBL6 = "WDSBL6";

        /// <summary>
        /// WDSBT6.
        /// </summary>
        public const string WDSBT6 = "WDSBT6";

        /// <summary>
        /// WDAREX.
        /// </summary>
        public const string WDAREX = "WDAREX";

        /// <summary>
        /// WDGLC.
        /// </summary>
        public const string WDGLC = "WDGLC";

        /// <summary>
        /// WDRGLC.
        /// </summary>
        public const string WDRGLC = "WDRGLC";

        /// <summary>
        /// WDPRET.
        /// </summary>
        public const string WDPRET = "WDPRET";

        /// <summary>
        /// WDRTNG.
        /// </summary>
        public const string WDRTNG = "WDRTNG";

        /// <summary>
        /// WDRTPS.
        /// </summary>
        public const string WDRTPS = "WDRTPS";

        /// <summary>
        /// WDFRTN.
        /// </summary>
        public const string WDFRTN = "WDFRTN";

        /// <summary>
        /// WDDWNL.
        /// </summary>
        public const string WDDWNL = "WDDWNL";

        /// <summary>
        /// WDCBLC.
        /// </summary>
        public const string WDCBLC = "WDCBLC";

        /// <summary>
        /// WDDEJ.
        /// </summary>
        public const string WDDEJ = "WDDEJ";

        /// <summary>
        /// WDCRRD.
        /// </summary>
        public const string WDCRRD = "WDCRRD";

        /// <summary>
        /// WDCRCE.
        /// </summary>
        public const string WDCRCE = "WDCRCE";

        /// <summary>
        /// WDCRCF.
        /// </summary>
        public const string WDCRCF = "WDCRCF";

        /// <summary>
        /// WDAA2.
        /// </summary>
        public const string WDAA2 = "WDAA2";

        /// <summary>
        /// WDTYKY.
        /// </summary>
        public const string WDTYKY = "WDTYKY";

        /// <summary>
        /// WDDGJ.
        /// </summary>
        public const string WDDGJ = "WDDGJ";

        /// <summary>
        /// WDIDGJ.
        /// </summary>
        public const string WDIDGJ = "WDIDGJ";

        /// <summary>
        /// WDPTFG.
        /// </summary>
        public const string WDPTFG = "WDPTFG";

        /// <summary>
        /// WDITM.
        /// </summary>
        public const string WDITM = "WDITM";

        /// <summary>
        /// WDPAID.
        /// </summary>
        public const string WDPAID = "WDPAID";

        /// <summary>
        /// WDFEA.
        /// </summary>
        public const string WDFEA = "WDFEA";

        /// <summary>
        /// WDERDB.
        /// </summary>
        public const string WDERDB = "WDERDB";

        /// <summary>
        /// WDERDT.
        /// </summary>
        public const string WDERDT = "WDERDT";

        /// <summary>
        /// WDSUBA.
        /// </summary>
        public const string WDSUBA = "WDSUBA";

        /// <summary>
        /// WDBCTK.
        /// </summary>
        public const string WDBCTK = "WDBCTK";

        /// <summary>
        /// WDPARS.
        /// </summary>
        public const string WDPARS = "WDPARS";

        /// <summary>
        /// WDPRGR.
        /// </summary>
        public const string WDPRGR = "WDPRGR";

        /// <summary>
        /// WDCPGP.
        /// </summary>
        public const string WDCPGP = "WDCPGP";

        /// <summary>
        /// WDBBF.
        /// </summary>
        public const string WDBBF = "WDBBF";

        /// <summary>
        /// WDMKRP.
        /// </summary>
        public const string WDMKRP = "WDMKRP";

        /// <summary>
        /// WDFBAS.
        /// </summary>
        public const string WDFBAS = "WDFBAS";

        /// <summary>
        /// WDRFBS.
        /// </summary>
        public const string WDRFBS = "WDRFBS";

        /// <summary>
        /// WDTKM1.
        /// </summary>
        public const string WDTKM1 = "WDTKM1";

        /// <summary>
        /// WDTKM2.
        /// </summary>
        public const string WDTKM2 = "WDTKM2";

        /// <summary>
        /// WDTKM3.
        /// </summary>
        public const string WDTKM3 = "WDTKM3";

        /// <summary>
        /// WDTKA1.
        /// </summary>
        public const string WDTKA1 = "WDTKA1";

        /// <summary>
        /// WDTKA2.
        /// </summary>
        public const string WDTKA2 = "WDTKA2";

        /// <summary>
        /// WDTKA3.
        /// </summary>
        public const string WDTKA3 = "WDTKA3";

        /// <summary>
        /// WDTKG1.
        /// </summary>
        public const string WDTKG1 = "WDTKG1";

        /// <summary>
        /// WDTKT1.
        /// </summary>
        public const string WDTKT1 = "WDTKT1";

        /// <summary>
        /// WDHBTL.
        /// </summary>
        public const string WDHBTL = "WDHBTL";

        /// <summary>
        /// WDHITL.
        /// </summary>
        public const string WDHITL = "WDHITL";

        /// <summary>
        /// WDHITX.
        /// </summary>
        public const string WDHITX = "WDHITX";

        /// <summary>
        /// WDHTAM.
        /// </summary>
        public const string WDHTAM = "WDHTAM";

        /// <summary>
        /// WDPRIF.
        /// </summary>
        public const string WDPRIF = "WDPRIF";

        /// <summary>
        /// WDNCTL.
        /// </summary>
        public const string WDNCTL = "WDNCTL";

        /// <summary>
        /// WDUSER.
        /// </summary>
        public const string WDUSER = "WDUSER";

        /// <summary>
        /// WDJOBN.
        /// </summary>
        public const string WDJOBN = "WDJOBN";

        /// <summary>
        /// WDPID.
        /// </summary>
        public const string WDPID = "WDPID";

        /// <summary>
        /// WDUPMJ.
        /// </summary>
        public const string WDUPMJ = "WDUPMJ";

        /// <summary>
        /// WDUPMT.
        /// </summary>
        public const string WDUPMT = "WDUPMT";

        /// <summary>
        /// WDVGCSF.
        /// </summary>
        public const string WDVGCSF = "WDVGCSF";

        /// <summary>
        /// WDVGCOA.
        /// </summary>
        public const string WDVGCOA = "WDVGCOA";

        /// <summary>
        /// WDVVTY.
        /// </summary>
        public const string WDVVTY = "WDVVTY";

        /// <summary>
        /// WDVVTC.
        /// </summary>
        public const string WDVVTC = "WDVVTC";

        /// <summary>
        /// WDRAS.
        /// </summary>
        public const string WDRAS = "WDRAS";

        /// <summary>
        /// WDRAG.
        /// </summary>
        public const string WDRAG = "WDRAG";

        /// <summary>
        /// WDJPGC.
        /// </summary>
        public const string WDJPGC = "WDJPGC";

        /// <summary>
        /// WDAA3.
        /// </summary>
        public const string WDAA3 = "WDAA3";

        /// <summary>
        /// WDACR.
        /// </summary>
        public const string WDACR = "WDACR";

        /// <summary>
        /// WDBUF.
        /// </summary>
        public const string WDBUF = "WDBUF";

        /// <summary>
        /// WDPRTP.
        /// </summary>
        public const string WDPRTP = "WDPRTP";

        /// <summary>
        /// WDHBIN.
        /// </summary>
        public const string WDHBIN = "WDHBIN";

        /// <summary>
        /// WDHBRV.
        /// </summary>
        public const string WDHBRV = "WDHBRV";

        /// <summary>
        /// WDBPTX.
        /// </summary>
        public const string WDBPTX = "WDBPTX";
    }

    /// <inheritdoc />
    public override string TableName => "F4812";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDDCT", "WDDCT", JdeDataType.String, 4),
        new JdeField("WDDOC", "WDDOC", JdeDataType.Numeric),
        new JdeField("WDKCO", "WDKCO", JdeDataType.String, 10),
        new JdeField("WDDGL", "WDDGL", JdeDataType.Numeric, null, true, true),
        new JdeField("WDJELN", "WDJELN", JdeDataType.Numeric),
        new JdeField("WDAID", "WDAID", JdeDataType.String, 16),
        new JdeField("WDMCU", "WDMCU", JdeDataType.String, 24),
        new JdeField("WDRP11", "WDRP11", JdeDataType.String, 6),
        new JdeField("WDOBJ", "WDOBJ", JdeDataType.String, 12),
        new JdeField("WDSUB", "WDSUB", JdeDataType.String, 16),
        new JdeField("WDSBL", "WDSBL", JdeDataType.String, 16),
        new JdeField("WDSBLT", "WDSBLT", JdeDataType.String, 2),
        new JdeField("WDOPSQ", "WDOPSQ", JdeDataType.Numeric),
        new JdeField("WDWR01", "WDWR01", JdeDataType.String, 8),
        new JdeField("WDWR07", "WDWR07", JdeDataType.String, 6),
        new JdeField("WDLT", "WDLT", JdeDataType.String, 4),
        new JdeField("WDCTRY", "WDCTRY", JdeDataType.Numeric),
        new JdeField("WDFY", "WDFY", JdeDataType.Numeric),
        new JdeField("WDPN", "WDPN", JdeDataType.Numeric),
        new JdeField("WDCO", "WDCO", JdeDataType.String, 10),
        new JdeField("WDODCT", "WDODCT", JdeDataType.String, 4),
        new JdeField("WDOSFX", "WDOSFX", JdeDataType.String, 6),
        new JdeField("WDODOC", "WDODOC", JdeDataType.Numeric),
        new JdeField("WDOKCO", "WDOKCO", JdeDataType.String, 10),
        new JdeField("WDPO", "WDPO", JdeDataType.String, 16),
        new JdeField("WDPDCT", "WDPDCT", JdeDataType.String, 4),
        new JdeField("WDPKCO", "WDPKCO", JdeDataType.String, 10),
        new JdeField("WDPSFX", "WDPSFX", JdeDataType.String, 6),
        new JdeField("WDOGNO", "WDOGNO", JdeDataType.Numeric),
        new JdeField("WDR001", "WDR001", JdeDataType.String, 6),
        new JdeField("WDR002", "WDR002", JdeDataType.String, 6),
        new JdeField("WDR003", "WDR003", JdeDataType.String, 6),
        new JdeField("WDPRTR", "WDPRTR", JdeDataType.Numeric),
        new JdeField("WDJBCD", "WDJBCD", JdeDataType.String, 12),
        new JdeField("WDJBST", "WDJBST", JdeDataType.String, 8),
        new JdeField("WDPDBA", "WDPDBA", JdeDataType.Numeric),
        new JdeField("WDPTAX", "WDPTAX", JdeDataType.String, 4),
        new JdeField("WDEQCG", "WDEQCG", JdeDataType.String, 18),
        new JdeField("WDEQWO", "WDEQWO", JdeDataType.String, 18),
        new JdeField("WDACL0", "WDACL0", JdeDataType.String, 6),
        new JdeField("WDERC", "WDERC", JdeDataType.String, 4),
        new JdeField("WDAN8", "WDAN8", JdeDataType.Numeric),
        new JdeField("WDDC", "WDDC", JdeDataType.String, 80),
        new JdeField("WDHMCU", "WDHMCU", JdeDataType.String, 24),
        new JdeField("WDJMCU", "WDJMCU", JdeDataType.String, 24),
        new JdeField("WDRP12", "WDRP12", JdeDataType.String, 6),
        new JdeField("WDDSVJ", "WDDSVJ", JdeDataType.Numeric),
        new JdeField("WDDAGO", "WDDAGO", JdeDataType.Numeric),
        new JdeField("WDAGS", "WDAGS", JdeDataType.String, 2),
        new JdeField("WDEXA", "WDEXA", JdeDataType.String, 60),
        new JdeField("WDEXR", "WDEXR", JdeDataType.String, 60),
        new JdeField("WDPCFG", "WDPCFG", JdeDataType.String, 2),
        new JdeField("WDPRIC", "WDPRIC", JdeDataType.Numeric),
        new JdeField("WDU", "WDU", JdeDataType.Numeric),
        new JdeField("WDUM", "WDUM", JdeDataType.String, 4),
        new JdeField("WDAA", "WDAA", JdeDataType.Numeric),
        new JdeField("WDDOCM", "WDDOCM", JdeDataType.Numeric),
        new JdeField("WDDOCO", "WDDOCO", JdeDataType.Numeric),
        new JdeField("WDDCTO", "WDDCTO", JdeDataType.String, 4),
        new JdeField("WDKCOO", "WDKCOO", JdeDataType.String, 10),
        new JdeField("WDCOCH", "WDCOCH", JdeDataType.String, 6),
        new JdeField("WDLNID", "WDLNID", JdeDataType.Numeric),
        new JdeField("WDOPIM", "WDOPIM", JdeDataType.String, 30),
        new JdeField("WDPCTN", "WDPCTN", JdeDataType.Numeric),
        new JdeField("WDPCTT", "WDPCTT", JdeDataType.String, 4),
        new JdeField("WDPCKO", "WDPCKO", JdeDataType.String, 10),
        new JdeField("WDPRSQ", "WDPRSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WDSBSQ", "WDSBSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WDSCSQ", "WDSCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WDBCI", "WDBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("WDLSSQ", "WDLSSQ", JdeDataType.String, 2),
        new JdeField("WDPMSQ", "WDPMSQ", JdeDataType.Numeric),
        new JdeField("WDLSPM", "WDLSPM", JdeDataType.String, 2),
        new JdeField("WDTCLS", "WDTCLS", JdeDataType.String, 2),
        new JdeField("WDELGC", "WDELGC", JdeDataType.String, 2),
        new JdeField("WDJRST", "WDJRST", JdeDataType.String, 2),
        new JdeField("WDICUJ", "WDICUJ", JdeDataType.Numeric),
        new JdeField("WDIVD", "WDIVD", JdeDataType.Numeric),
        new JdeField("WDHLD", "WDHLD", JdeDataType.String, 2),
        new JdeField("WDRDJ", "WDRDJ", JdeDataType.Numeric),
        new JdeField("WDVOID", "WDVOID", JdeDataType.String, 2),
        new JdeField("WDICUA", "WDICUA", JdeDataType.Numeric),
        new JdeField("WDJRSP", "WDJRSP", JdeDataType.String, 2),
        new JdeField("WDBDPN", "WDBDPN", JdeDataType.String, 2),
        new JdeField("WDSLNK", "WDSLNK", JdeDataType.Numeric, null, true, true),
        new JdeField("WDCLNK", "WDCLNK", JdeDataType.Numeric, null, true, true),
        new JdeField("WDCCOD", "WDCCOD", JdeDataType.String, 10, true, true),
        new JdeField("WDCCR", "WDCCR", JdeDataType.String, 20),
        new JdeField("WDCINR", "WDCINR", JdeDataType.String, 20),
        new JdeField("WDCRVR", "WDCRVR", JdeDataType.String, 20),
        new JdeField("WDSBAR", "WDSBAR", JdeDataType.String, 4),
        new JdeField("WDTBDT", "WDTBDT", JdeDataType.Numeric),
        new JdeField("WDCAP", "WDCAP", JdeDataType.String, 2),
        new JdeField("WDBRT", "WDBRT", JdeDataType.Numeric),
        new JdeField("WDPERT", "WDPERT", JdeDataType.Numeric),
        new JdeField("WDADCR", "WDADCR", JdeDataType.Numeric),
        new JdeField("WDCAPI", "WDCAPI", JdeDataType.String, 2),
        new JdeField("WDBRTI", "WDBRTI", JdeDataType.Numeric),
        new JdeField("WDPCIM", "WDPCIM", JdeDataType.Numeric),
        new JdeField("WDADCI", "WDADCI", JdeDataType.Numeric),
        new JdeField("WDTX", "WDTX", JdeDataType.String, 2),
        new JdeField("WDTOG", "WDTOG", JdeDataType.String, 2),
        new JdeField("WDEXR1", "WDEXR1", JdeDataType.String, 4),
        new JdeField("WDTXA1", "WDTXA1", JdeDataType.String, 20),
        new JdeField("WDDCP", "WDDCP", JdeDataType.Numeric),
        new JdeField("WDJTAX", "WDJTAX", JdeDataType.Numeric),
        new JdeField("WDJTXF", "WDJTXF", JdeDataType.Numeric),
        new JdeField("WDBTOL", "WDBTOL", JdeDataType.Numeric),
        new JdeField("WDCRCD", "WDCRCD", JdeDataType.String, 6),
        new JdeField("WDCRR", "WDCRR", JdeDataType.Numeric),
        new JdeField("WDCRRM", "WDCRRM", JdeDataType.String, 2),
        new JdeField("WDFTOL", "WDFTOL", JdeDataType.Numeric),
        new JdeField("WDITOL", "WDITOL", JdeDataType.Numeric),
        new JdeField("WDITXA", "WDITXA", JdeDataType.Numeric),
        new JdeField("WDITAM", "WDITAM", JdeDataType.Numeric),
        new JdeField("WDIDSC", "WDIDSC", JdeDataType.Numeric),
        new JdeField("WDCITL", "WDCITL", JdeDataType.Numeric),
        new JdeField("WDCITA", "WDCITA", JdeDataType.Numeric),
        new JdeField("WDCITX", "WDCITX", JdeDataType.Numeric),
        new JdeField("WDCIDS", "WDCIDS", JdeDataType.Numeric),
        new JdeField("WDIJST", "WDIJST", JdeDataType.String, 2),
        new JdeField("WDPRTF", "WDPRTF", JdeDataType.String, 2),
        new JdeField("WDICU", "WDICU", JdeDataType.Numeric),
        new JdeField("WDAN8O", "WDAN8O", JdeDataType.Numeric),
        new JdeField("WDVINV", "WDVINV", JdeDataType.String, 50),
        new JdeField("WDDI", "WDDI", JdeDataType.Numeric),
        new JdeField("WDDOCZ", "WDDOCZ", JdeDataType.Numeric),
        new JdeField("WDDCTI", "WDDCTI", JdeDataType.String, 4),
        new JdeField("WDKCOI", "WDKCOI", JdeDataType.String, 10),
        new JdeField("WDSFX", "WDSFX", JdeDataType.String, 6),
        new JdeField("WDSBSK", "WDSBSK", JdeDataType.String, 8),
        new JdeField("WDBLKK", "WDBLKK", JdeDataType.String, 160),
        new JdeField("WDAID5", "WDAID5", JdeDataType.String, 16),
        new JdeField("WDSBL5", "WDSBL5", JdeDataType.String, 16),
        new JdeField("WDSBT5", "WDSBT5", JdeDataType.String, 2),
        new JdeField("WDAID6", "WDAID6", JdeDataType.String, 16),
        new JdeField("WDSBL6", "WDSBL6", JdeDataType.String, 16),
        new JdeField("WDSBT6", "WDSBT6", JdeDataType.String, 2),
        new JdeField("WDAREX", "WDAREX", JdeDataType.String, 2),
        new JdeField("WDGLC", "WDGLC", JdeDataType.String, 8),
        new JdeField("WDRGLC", "WDRGLC", JdeDataType.String, 8),
        new JdeField("WDPRET", "WDPRET", JdeDataType.Numeric),
        new JdeField("WDRTNG", "WDRTNG", JdeDataType.Numeric),
        new JdeField("WDRTPS", "WDRTPS", JdeDataType.Numeric),
        new JdeField("WDFRTN", "WDFRTN", JdeDataType.Numeric),
        new JdeField("WDDWNL", "WDDWNL", JdeDataType.String, 2),
        new JdeField("WDCBLC", "WDCBLC", JdeDataType.String, 2),
        new JdeField("WDDEJ", "WDDEJ", JdeDataType.Numeric),
        new JdeField("WDCRRD", "WDCRRD", JdeDataType.Numeric),
        new JdeField("WDCRCE", "WDCRCE", JdeDataType.String, 6),
        new JdeField("WDCRCF", "WDCRCF", JdeDataType.String, 6),
        new JdeField("WDAA2", "WDAA2", JdeDataType.Numeric),
        new JdeField("WDTYKY", "WDTYKY", JdeDataType.String, 2),
        new JdeField("WDDGJ", "WDDGJ", JdeDataType.Numeric),
        new JdeField("WDIDGJ", "WDIDGJ", JdeDataType.Numeric),
        new JdeField("WDPTFG", "WDPTFG", JdeDataType.String, 2),
        new JdeField("WDITM", "WDITM", JdeDataType.Numeric),
        new JdeField("WDPAID", "WDPAID", JdeDataType.Numeric),
        new JdeField("WDFEA", "WDFEA", JdeDataType.Numeric),
        new JdeField("WDERDB", "WDERDB", JdeDataType.String, 2),
        new JdeField("WDERDT", "WDERDT", JdeDataType.Numeric),
        new JdeField("WDSUBA", "WDSUBA", JdeDataType.String, 16),
        new JdeField("WDBCTK", "WDBCTK", JdeDataType.String, 20),
        new JdeField("WDPARS", "WDPARS", JdeDataType.String, 16),
        new JdeField("WDPRGR", "WDPRGR", JdeDataType.String, 16),
        new JdeField("WDCPGP", "WDCPGP", JdeDataType.String, 16),
        new JdeField("WDBBF", "WDBBF", JdeDataType.String, 2),
        new JdeField("WDMKRP", "WDMKRP", JdeDataType.Numeric),
        new JdeField("WDFBAS", "WDFBAS", JdeDataType.String, 2),
        new JdeField("WDRFBS", "WDRFBS", JdeDataType.String, 2),
        new JdeField("WDTKM1", "WDTKM1", JdeDataType.String, 2),
        new JdeField("WDTKM2", "WDTKM2", JdeDataType.String, 2),
        new JdeField("WDTKM3", "WDTKM3", JdeDataType.String, 2),
        new JdeField("WDTKA1", "WDTKA1", JdeDataType.String, 2),
        new JdeField("WDTKA2", "WDTKA2", JdeDataType.String, 2),
        new JdeField("WDTKA3", "WDTKA3", JdeDataType.String, 2),
        new JdeField("WDTKG1", "WDTKG1", JdeDataType.String, 2),
        new JdeField("WDTKT1", "WDTKT1", JdeDataType.String, 2),
        new JdeField("WDHBTL", "WDHBTL", JdeDataType.Numeric),
        new JdeField("WDHITL", "WDHITL", JdeDataType.Numeric),
        new JdeField("WDHITX", "WDHITX", JdeDataType.Numeric),
        new JdeField("WDHTAM", "WDHTAM", JdeDataType.Numeric),
        new JdeField("WDPRIF", "WDPRIF", JdeDataType.Numeric),
        new JdeField("WDNCTL", "WDNCTL", JdeDataType.String, 2),
        new JdeField("WDUSER", "WDUSER", JdeDataType.String, 20),
        new JdeField("WDJOBN", "WDJOBN", JdeDataType.String, 20),
        new JdeField("WDPID", "WDPID", JdeDataType.String, 20),
        new JdeField("WDUPMJ", "WDUPMJ", JdeDataType.Numeric),
        new JdeField("WDUPMT", "WDUPMT", JdeDataType.Numeric),
        new JdeField("WDVGCSF", "WDVGCSF", JdeDataType.String, 20),
        new JdeField("WDVGCOA", "WDVGCOA", JdeDataType.String, 20),
        new JdeField("WDVVTY", "WDVVTY", JdeDataType.String, 12),
        new JdeField("WDVVTC", "WDVVTC", JdeDataType.String, 20),
        new JdeField("WDRAS", "WDRAS", JdeDataType.String, 2),
        new JdeField("WDRAG", "WDRAG", JdeDataType.Numeric),
        new JdeField("WDJPGC", "WDJPGC", JdeDataType.String, 6),
        new JdeField("WDAA3", "WDAA3", JdeDataType.Numeric),
        new JdeField("WDACR", "WDACR", JdeDataType.Numeric),
        new JdeField("WDBUF", "WDBUF", JdeDataType.String, 2),
        new JdeField("WDPRTP", "WDPRTP", JdeDataType.String, 2),
        new JdeField("WDHBIN", "WDHBIN", JdeDataType.Numeric),
        new JdeField("WDHBRV", "WDHBRV", JdeDataType.Numeric),
        new JdeField("WDBPTX", "WDBPTX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4812_0", "Primary Key on WDBCI, WDDGL, WDSBSQ, WDPRSQ, WDSCSQ, WDSLNK, WDCLNK, WDCCOD", new[] { "WDBCI", "WDDGL", "WDSBSQ", "WDPRSQ", "WDSCSQ", "WDSLNK", "WDCLNK", "WDCCOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4812_10", "Index on WDEQCG, WDAN8O, WDMCU, WDOBJ, WDSUB", new[] { "WDEQCG", "WDAN8O", "WDMCU", "WDOBJ", "WDSUB" }),
        new JdeIndex("F4812_11", "Index on WDAN8, WDAN8O, WDMCU, WDOBJ, WDSUB, WDJBCD, WDJBST, WDDGL", new[] { "WDAN8", "WDAN8O", "WDMCU", "WDOBJ", "WDSUB", "WDJBCD", "WDJBST", "WDDGL" }),
        new JdeIndex("F4812_12", "Index on WDDOCZ, WDDCTI, WDKCOI, WDSFX, WDMCU, WDOBJ, WDSUB, WDJBCD", new[] { "WDDOCZ", "WDDCTI", "WDKCOI", "WDSFX", "WDMCU", "WDOBJ", "WDSUB", "WDJBCD" }),
        new JdeIndex("F4812_14", "Index on WDICUA, WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDLNID, WDELGC", new[] { "WDICUA", "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDLNID", "WDELGC" }),
        new JdeIndex("F4812_17", "Index on WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDOPIM, WDDOCZ, WDDCTI, WDKCOI, WDTCLS", new[] { "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDOPIM", "WDDOCZ", "WDDCTI", "WDKCOI", "WDTCLS" }),
        new JdeIndex("F4812_18", "Index on WDICU, WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDLNID", new[] { "WDICU", "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDLNID" }),
        new JdeIndex("F4812_19", "Index on WDAN8, WDPRTR, WDPDBA, WDPTAX", new[] { "WDAN8", "WDPRTR", "WDPDBA", "WDPTAX" }),
        new JdeIndex("F4812_2", "Index on WDICU, WDDOCZ, WDDCTI, WDKCOI, WDSFX", new[] { "WDICU", "WDDOCZ", "WDDCTI", "WDKCOI", "WDSFX" }),
        new JdeIndex("F4812_20", "Index on WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDLNID, WDMCU, WDSUB, WDOBJ", new[] { "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDLNID", "WDMCU", "WDSUB", "WDOBJ" }),
        new JdeIndex("F4812_21", "Index on WDAID, WDBCI, WDDGL, WDSBSQ, WDSCSQ", new[] { "WDAID", "WDBCI", "WDDGL", "WDSBSQ", "WDSCSQ" }),
        new JdeIndex("F4812_22", "Index on WDICU, WDSBL, WDSBLT, WDMCU, WDDOCO, WDDCTO, WDKCOO, WDAN8, WDOBJ, WDSUB, WDTBDT", new[] { "WDICU", "WDSBL", "WDSBLT", "WDMCU", "WDDOCO", "WDDCTO", "WDKCOO", "WDAN8", "WDOBJ", "WDSUB", "WDTBDT" }),
        new JdeIndex("F4812_23", "Index on WDSLNK, WDCLNK, WDCCOD", new[] { "WDSLNK", "WDCLNK", "WDCCOD" }),
        new JdeIndex("F4812_24", "Index on WDSLNK, WDCLNK, WDBCI", new[] { "WDSLNK", "WDCLNK", "WDBCI" }),
        new JdeIndex("F4812_25", "Index on WDCLNK, WDCCOD", new[] { "WDCLNK", "WDCCOD" }),
        new JdeIndex("F4812_26", "Index on WDAN8O, WDMCU, WDOBJ, WDSUB, WDSBL, WDSBLT, WDJBCD, WDJBST, WDDGL", new[] { "WDAN8O", "WDMCU", "WDOBJ", "WDSUB", "WDSBL", "WDSBLT", "WDJBCD", "WDJBST", "WDDGL" }),
        new JdeIndex("F4812_27", "Index on WDICU, WDDOC, WDDCT, WDKCO", new[] { "WDICU", "WDDOC", "WDDCT", "WDKCO" }),
        new JdeIndex("F4812_28", "Index on WDDCT, WDAN8, WDPRTR, WDTCLS", new[] { "WDDCT", "WDAN8", "WDPRTR", "WDTCLS" }),
        new JdeIndex("F4812_29", "Index on SYS_NC00204$, SYS_NC00205$, WDDCTO, WDKCOO, WDCOCH, WDLNID, WDCCR", new[] { "SYS_NC00204$", "SYS_NC00205$", "WDDCTO", "WDKCOO", "WDCOCH", "WDLNID", "WDCCR" }),
        new JdeIndex("F4812_3", "Index on WDMCU, WDOBJ, WDSUB, WDDGL, WDSBL, WDSBLT, WDJBCD, WDJBST", new[] { "WDMCU", "WDOBJ", "WDSUB", "WDDGL", "WDSBL", "WDSBLT", "WDJBCD", "WDJBST" }),
        new JdeIndex("F4812_30", "Index on WDTCLS, WDDOCZ, WDDCTI, WDKCOI, WDSFX", new[] { "WDTCLS", "WDDOCZ", "WDDCTI", "WDKCOI", "WDSFX" }),
        new JdeIndex("F4812_31", "Index on WDICUJ, WDCCOD", new[] { "WDICUJ", "WDCCOD" }),
        new JdeIndex("F4812_32", "Index on WDDGL, WDPRSQ, WDSBSQ, WDSCSQ, WDBCI, WDSLNK, WDCCOD", new[] { "WDDGL", "WDPRSQ", "WDSBSQ", "WDSCSQ", "WDBCI", "WDSLNK", "WDCCOD" }),
        new JdeIndex("F4812_33", "Index on WDRAG", new[] { "WDRAG" }),
        new JdeIndex("F4812_6", "Index on WDICUJ, WDAN8O, WDMCU, WDOBJ, WDSUB, WDSBL, WDSBLT, WDJBCD, WDJBST, WDDGL", new[] { "WDICUJ", "WDAN8O", "WDMCU", "WDOBJ", "WDSUB", "WDSBL", "WDSBLT", "WDJBCD", "WDJBST", "WDDGL" }),
        new JdeIndex("F4812_7", "Index on WDICUA, WDSBL, WDSBLT, WDDOCO, WDDCTO, WDKCOO, WDAN8, WDMCU, WDOBJ, WDSUB, WDBCI, WDSLNK, WDCLNK, WDTBDT, WDHMCU, WDCCOD", new[] { "WDICUA", "WDSBL", "WDSBLT", "WDDOCO", "WDDCTO", "WDKCOO", "WDAN8", "WDMCU", "WDOBJ", "WDSUB", "WDBCI", "WDSLNK", "WDCLNK", "WDTBDT", "WDHMCU", "WDCCOD" }),
        new JdeIndex("F4812_8", "Index on WDICU, WDSBSK, WDBLKK, WDGLC, WDEXR1, WDTXA1, WDCRCD", new[] { "WDICU", "WDSBSK", "WDBLKK", "WDGLC", "WDEXR1", "WDTXA1", "WDCRCD" }),
        new JdeIndex("F4812_9", "Index on WDDOCO, WDDCTO, WDKCOO, WDCOCH, WDLNID, WDTCLS, WDMCU, WDSUB, WDOBJ", new[] { "WDDOCO", "WDDCTO", "WDKCOO", "WDCOCH", "WDLNID", "WDTCLS", "WDMCU", "WDSUB", "WDOBJ" })
    };
}
