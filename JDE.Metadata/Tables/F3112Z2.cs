using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3112Z2 - .
/// </summary>
public class F3112Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLEDUS.
        /// </summary>
        public const string WLEDUS = "WLEDUS";

        /// <summary>
        /// WLEDBT.
        /// </summary>
        public const string WLEDBT = "WLEDBT";

        /// <summary>
        /// WLEDTN.
        /// </summary>
        public const string WLEDTN = "WLEDTN";

        /// <summary>
        /// WLEDLN.
        /// </summary>
        public const string WLEDLN = "WLEDLN";

        /// <summary>
        /// WLEDCT.
        /// </summary>
        public const string WLEDCT = "WLEDCT";

        /// <summary>
        /// WLTYTN.
        /// </summary>
        public const string WLTYTN = "WLTYTN";

        /// <summary>
        /// WLEDFT.
        /// </summary>
        public const string WLEDFT = "WLEDFT";

        /// <summary>
        /// WLEDDT.
        /// </summary>
        public const string WLEDDT = "WLEDDT";

        /// <summary>
        /// WLDRIN.
        /// </summary>
        public const string WLDRIN = "WLDRIN";

        /// <summary>
        /// WLEDDL.
        /// </summary>
        public const string WLEDDL = "WLEDDL";

        /// <summary>
        /// WLEDSP.
        /// </summary>
        public const string WLEDSP = "WLEDSP";

        /// <summary>
        /// WLPNID.
        /// </summary>
        public const string WLPNID = "WLPNID";

        /// <summary>
        /// WLTNAC.
        /// </summary>
        public const string WLTNAC = "WLTNAC";

        /// <summary>
        /// WLDOCO.
        /// </summary>
        public const string WLDOCO = "WLDOCO";

        /// <summary>
        /// WLDCTO.
        /// </summary>
        public const string WLDCTO = "WLDCTO";

        /// <summary>
        /// WLSFXO.
        /// </summary>
        public const string WLSFXO = "WLSFXO";

        /// <summary>
        /// WLTRT.
        /// </summary>
        public const string WLTRT = "WLTRT";

        /// <summary>
        /// WLKIT.
        /// </summary>
        public const string WLKIT = "WLKIT";

        /// <summary>
        /// WLKITL.
        /// </summary>
        public const string WLKITL = "WLKITL";

        /// <summary>
        /// WLKITA.
        /// </summary>
        public const string WLKITA = "WLKITA";

        /// <summary>
        /// WLMMCU.
        /// </summary>
        public const string WLMMCU = "WLMMCU";

        /// <summary>
        /// WLLINE.
        /// </summary>
        public const string WLLINE = "WLLINE";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLALD.
        /// </summary>
        public const string WLALD = "WLALD";

        /// <summary>
        /// WLDSC1.
        /// </summary>
        public const string WLDSC1 = "WLDSC1";

        /// <summary>
        /// WLOPSQ.
        /// </summary>
        public const string WLOPSQ = "WLOPSQ";

        /// <summary>
        /// WLOPSC.
        /// </summary>
        public const string WLOPSC = "WLOPSC";

        /// <summary>
        /// WLOPST.
        /// </summary>
        public const string WLOPST = "WLOPST";

        /// <summary>
        /// WLINPE.
        /// </summary>
        public const string WLINPE = "WLINPE";

        /// <summary>
        /// WLTIMB.
        /// </summary>
        public const string WLTIMB = "WLTIMB";

        /// <summary>
        /// WLLAMC.
        /// </summary>
        public const string WLLAMC = "WLLAMC";

        /// <summary>
        /// WLBFPF.
        /// </summary>
        public const string WLBFPF = "WLBFPF";

        /// <summary>
        /// WLPPRF.
        /// </summary>
        public const string WLPPRF = "WLPPRF";

        /// <summary>
        /// WLJBCD.
        /// </summary>
        public const string WLJBCD = "WLJBCD";

        /// <summary>
        /// WLAN8.
        /// </summary>
        public const string WLAN8 = "WLAN8";

        /// <summary>
        /// WLCRTR.
        /// </summary>
        public const string WLCRTR = "WLCRTR";

        /// <summary>
        /// WLSLTR.
        /// </summary>
        public const string WLSLTR = "WLSLTR";

        /// <summary>
        /// WLTRDJ.
        /// </summary>
        public const string WLTRDJ = "WLTRDJ";

        /// <summary>
        /// WLDRQJ.
        /// </summary>
        public const string WLDRQJ = "WLDRQJ";

        /// <summary>
        /// WLSTRT.
        /// </summary>
        public const string WLSTRT = "WLSTRT";

        /// <summary>
        /// WLRSFT.
        /// </summary>
        public const string WLRSFT = "WLRSFT";

        /// <summary>
        /// WLSSFT.
        /// </summary>
        public const string WLSSFT = "WLSSFT";

        /// <summary>
        /// WLCSFT.
        /// </summary>
        public const string WLCSFT = "WLCSFT";

        /// <summary>
        /// WLLTPC.
        /// </summary>
        public const string WLLTPC = "WLLTPC";

        /// <summary>
        /// WLPOVR.
        /// </summary>
        public const string WLPOVR = "WLPOVR";

        /// <summary>
        /// WLOPYP.
        /// </summary>
        public const string WLOPYP = "WLOPYP";

        /// <summary>
        /// WLCPYP.
        /// </summary>
        public const string WLCPYP = "WLCPYP";

        /// <summary>
        /// WLNXOP.
        /// </summary>
        public const string WLNXOP = "WLNXOP";

        /// <summary>
        /// WLSETC.
        /// </summary>
        public const string WLSETC = "WLSETC";

        /// <summary>
        /// WLMOVD.
        /// </summary>
        public const string WLMOVD = "WLMOVD";

        /// <summary>
        /// WLQUED.
        /// </summary>
        public const string WLQUED = "WLQUED";

        /// <summary>
        /// WLRUNM.
        /// </summary>
        public const string WLRUNM = "WLRUNM";

        /// <summary>
        /// WLRUNL.
        /// </summary>
        public const string WLRUNL = "WLRUNL";

        /// <summary>
        /// WLSETL.
        /// </summary>
        public const string WLSETL = "WLSETL";

        /// <summary>
        /// WLMACA.
        /// </summary>
        public const string WLMACA = "WLMACA";

        /// <summary>
        /// WLLABA.
        /// </summary>
        public const string WLLABA = "WLLABA";

        /// <summary>
        /// WLSETA.
        /// </summary>
        public const string WLSETA = "WLSETA";

        /// <summary>
        /// WLOPSR.
        /// </summary>
        public const string WLOPSR = "WLOPSR";

        /// <summary>
        /// WLUORG.
        /// </summary>
        public const string WLUORG = "WLUORG";

        /// <summary>
        /// WLSOCN.
        /// </summary>
        public const string WLSOCN = "WLSOCN";

        /// <summary>
        /// WLSOQS.
        /// </summary>
        public const string WLSOQS = "WLSOQS";

        /// <summary>
        /// WLQMTO.
        /// </summary>
        public const string WLQMTO = "WLQMTO";

        /// <summary>
        /// WLPWRT.
        /// </summary>
        public const string WLPWRT = "WLPWRT";

        /// <summary>
        /// WLUOM.
        /// </summary>
        public const string WLUOM = "WLUOM";

        /// <summary>
        /// WLCTS2.
        /// </summary>
        public const string WLCTS2 = "WLCTS2";

        /// <summary>
        /// WLCTS3.
        /// </summary>
        public const string WLCTS3 = "WLCTS3";

        /// <summary>
        /// WLCTS4.
        /// </summary>
        public const string WLCTS4 = "WLCTS4";

        /// <summary>
        /// WLCTS5.
        /// </summary>
        public const string WLCTS5 = "WLCTS5";

        /// <summary>
        /// WLCTS6.
        /// </summary>
        public const string WLCTS6 = "WLCTS6";

        /// <summary>
        /// WLAPID.
        /// </summary>
        public const string WLAPID = "WLAPID";

        /// <summary>
        /// WLSHNO.
        /// </summary>
        public const string WLSHNO = "WLSHNO";

        /// <summary>
        /// WLOMCU.
        /// </summary>
        public const string WLOMCU = "WLOMCU";

        /// <summary>
        /// WLOBJ.
        /// </summary>
        public const string WLOBJ = "WLOBJ";

        /// <summary>
        /// WLSUB.
        /// </summary>
        public const string WLSUB = "WLSUB";

        /// <summary>
        /// WLVEND.
        /// </summary>
        public const string WLVEND = "WLVEND";

        /// <summary>
        /// WLRKCO.
        /// </summary>
        public const string WLRKCO = "WLRKCO";

        /// <summary>
        /// WLRORN.
        /// </summary>
        public const string WLRORN = "WLRORN";

        /// <summary>
        /// WLRCTO.
        /// </summary>
        public const string WLRCTO = "WLRCTO";

        /// <summary>
        /// WLRLLN.
        /// </summary>
        public const string WLRLLN = "WLRLLN";

        /// <summary>
        /// WLDCT.
        /// </summary>
        public const string WLDCT = "WLDCT";

        /// <summary>
        /// WLURCD.
        /// </summary>
        public const string WLURCD = "WLURCD";

        /// <summary>
        /// WLURDT.
        /// </summary>
        public const string WLURDT = "WLURDT";

        /// <summary>
        /// WLURAT.
        /// </summary>
        public const string WLURAT = "WLURAT";

        /// <summary>
        /// WLURAB.
        /// </summary>
        public const string WLURAB = "WLURAB";

        /// <summary>
        /// WLURRF.
        /// </summary>
        public const string WLURRF = "WLURRF";

        /// <summary>
        /// WLTORG.
        /// </summary>
        public const string WLTORG = "WLTORG";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLTDAY.
        /// </summary>
        public const string WLTDAY = "WLTDAY";

        /// <summary>
        /// WLCAPU.
        /// </summary>
        public const string WLCAPU = "WLCAPU";

        /// <summary>
        /// WLCLHR.
        /// </summary>
        public const string WLCLHR = "WLCLHR";

        /// <summary>
        /// WLCMHR.
        /// </summary>
        public const string WLCMHR = "WLCMHR";

        /// <summary>
        /// WLCOST.
        /// </summary>
        public const string WLCOST = "WLCOST";

        /// <summary>
        /// WLCSHR.
        /// </summary>
        public const string WLCSHR = "WLCSHR";

        /// <summary>
        /// WLLOCN.
        /// </summary>
        public const string WLLOCN = "WLLOCN";

        /// <summary>
        /// WLRUC.
        /// </summary>
        public const string WLRUC = "WLRUC";

        /// <summary>
        /// WLWMCU.
        /// </summary>
        public const string WLWMCU = "WLWMCU";

        /// <summary>
        /// WLNUMB.
        /// </summary>
        public const string WLNUMB = "WLNUMB";

        /// <summary>
        /// WLCTS7.
        /// </summary>
        public const string WLCTS7 = "WLCTS7";

        /// <summary>
        /// WLCTS8.
        /// </summary>
        public const string WLCTS8 = "WLCTS8";

        /// <summary>
        /// WLSHFT.
        /// </summary>
        public const string WLSHFT = "WLSHFT";

        /// <summary>
        /// WLACTB.
        /// </summary>
        public const string WLACTB = "WLACTB";

        /// <summary>
        /// WLCTS9.
        /// </summary>
        public const string WLCTS9 = "WLCTS9";

        /// <summary>
        /// WLLABP.
        /// </summary>
        public const string WLLABP = "WLLABP";

        /// <summary>
        /// WLMACR.
        /// </summary>
        public const string WLMACR = "WLMACR";

        /// <summary>
        /// WLSETR.
        /// </summary>
        public const string WLSETR = "WLSETR";

        /// <summary>
        /// WLAPSC.
        /// </summary>
        public const string WLAPSC = "WLAPSC";

        /// <summary>
        /// WLSEST.
        /// </summary>
        public const string WLSEST = "WLSEST";

        /// <summary>
        /// WLSEET.
        /// </summary>
        public const string WLSEET = "WLSEET";

        /// <summary>
        /// WLTMCO.
        /// </summary>
        public const string WLTMCO = "WLTMCO";

        /// <summary>
        /// WLD2J.
        /// </summary>
        public const string WLD2J = "WLD2J";

        /// <summary>
        /// WLSTTI.
        /// </summary>
        public const string WLSTTI = "WLSTTI";

        /// <summary>
        /// WLCMPE.
        /// </summary>
        public const string WLCMPE = "WLCMPE";

        /// <summary>
        /// WLCMPC.
        /// </summary>
        public const string WLCMPC = "WLCMPC";

        /// <summary>
        /// WLCPLVLFR.
        /// </summary>
        public const string WLCPLVLFR = "WLCPLVLFR";

        /// <summary>
        /// WLCPLVLTO.
        /// </summary>
        public const string WLCPLVLTO = "WLCPLVLTO";

        /// <summary>
        /// WLCMRQ.
        /// </summary>
        public const string WLCMRQ = "WLCMRQ";

        /// <summary>
        /// WLPAYAB.
        /// </summary>
        public const string WLPAYAB = "WLPAYAB";

        /// <summary>
        /// WLBILL.
        /// </summary>
        public const string WLBILL = "WLBILL";

        /// <summary>
        /// WLACRTB.
        /// </summary>
        public const string WLACRTB = "WLACRTB";

        /// <summary>
        /// WLACRTP.
        /// </summary>
        public const string WLACRTP = "WLACRTP";

        /// <summary>
        /// WLEBILL.
        /// </summary>
        public const string WLEBILL = "WLEBILL";

        /// <summary>
        /// WLAMTA.
        /// </summary>
        public const string WLAMTA = "WLAMTA";

        /// <summary>
        /// WLAMTO.
        /// </summary>
        public const string WLAMTO = "WLAMTO";

        /// <summary>
        /// WLESRTB.
        /// </summary>
        public const string WLESRTB = "WLESRTB";

        /// <summary>
        /// WLESRTP.
        /// </summary>
        public const string WLESRTP = "WLESRTP";

        /// <summary>
        /// WLEPAAP.
        /// </summary>
        public const string WLEPAAP = "WLEPAAP";

        /// <summary>
        /// WLTOTB.
        /// </summary>
        public const string WLTOTB = "WLTOTB";

        /// <summary>
        /// WLCLAMT.
        /// </summary>
        public const string WLCLAMT = "WLCLAMT";

        /// <summary>
        /// WLDTBIL.
        /// </summary>
        public const string WLDTBIL = "WLDTBIL";

        /// <summary>
        /// WLDTPAY.
        /// </summary>
        public const string WLDTPAY = "WLDTPAY";

        /// <summary>
        /// WLPAAP.
        /// </summary>
        public const string WLPAAP = "WLPAAP";

        /// <summary>
        /// WLLBR1.
        /// </summary>
        public const string WLLBR1 = "WLLBR1";

        /// <summary>
        /// WLEPETM.
        /// </summary>
        public const string WLEPETM = "WLEPETM";

        /// <summary>
        /// WLENTCK.
        /// </summary>
        public const string WLENTCK = "WLENTCK";

        /// <summary>
        /// WLGLCNC.
        /// </summary>
        public const string WLGLCNC = "WLGLCNC";

        /// <summary>
        /// WLGLCCV.
        /// </summary>
        public const string WLGLCCV = "WLGLCCV";

        /// <summary>
        /// WLASN4.
        /// </summary>
        public const string WLASN4 = "WLASN4";

        /// <summary>
        /// WLASN2.
        /// </summary>
        public const string WLASN2 = "WLASN2";

        /// <summary>
        /// WLPCOVR.
        /// </summary>
        public const string WLPCOVR = "WLPCOVR";

        /// <summary>
        /// WLMTHPR.
        /// </summary>
        public const string WLMTHPR = "WLMTHPR";

        /// <summary>
        /// WLSAID.
        /// </summary>
        public const string WLSAID = "WLSAID";

        /// <summary>
        /// WLPRODF.
        /// </summary>
        public const string WLPRODF = "WLPRODF";

        /// <summary>
        /// WLPRODM.
        /// </summary>
        public const string WLPRODM = "WLPRODM";

        /// <summary>
        /// WLCOVGR.
        /// </summary>
        public const string WLCOVGR = "WLCOVGR";

        /// <summary>
        /// WLPMTHP.
        /// </summary>
        public const string WLPMTHP = "WLPMTHP";

        /// <summary>
        /// WLPYPRT.
        /// </summary>
        public const string WLPYPRT = "WLPYPRT";

        /// <summary>
        /// WLCRDC.
        /// </summary>
        public const string WLCRDC = "WLCRDC";

        /// <summary>
        /// WLBCRCD.
        /// </summary>
        public const string WLBCRCD = "WLBCRCD";

        /// <summary>
        /// WLBCRR.
        /// </summary>
        public const string WLBCRR = "WLBCRR";

        /// <summary>
        /// WLBCRRM.
        /// </summary>
        public const string WLBCRRM = "WLBCRRM";

        /// <summary>
        /// WLFESUNB.
        /// </summary>
        public const string WLFESUNB = "WLFESUNB";

        /// <summary>
        /// WLFEBILL.
        /// </summary>
        public const string WLFEBILL = "WLFEBILL";

        /// <summary>
        /// WLFACUNB.
        /// </summary>
        public const string WLFACUNB = "WLFACUNB";

        /// <summary>
        /// WLFTOTB.
        /// </summary>
        public const string WLFTOTB = "WLFTOTB";

        /// <summary>
        /// WLPCRCD.
        /// </summary>
        public const string WLPCRCD = "WLPCRCD";

        /// <summary>
        /// WLPCRR.
        /// </summary>
        public const string WLPCRR = "WLPCRR";

        /// <summary>
        /// WLPCRRM.
        /// </summary>
        public const string WLPCRRM = "WLPCRRM";

        /// <summary>
        /// WLFESUNP.
        /// </summary>
        public const string WLFESUNP = "WLFESUNP";

        /// <summary>
        /// WLFEPAAP.
        /// </summary>
        public const string WLFEPAAP = "WLFEPAAP";

        /// <summary>
        /// WLFACUNP.
        /// </summary>
        public const string WLFACUNP = "WLFACUNP";

        /// <summary>
        /// WLFPAAP.
        /// </summary>
        public const string WLFPAAP = "WLFPAAP";

        /// <summary>
        /// WLDTSUB.
        /// </summary>
        public const string WLDTSUB = "WLDTSUB";

        /// <summary>
        /// WLTMSUB.
        /// </summary>
        public const string WLTMSUB = "WLTMSUB";

        /// <summary>
        /// WLCSLPRT.
        /// </summary>
        public const string WLCSLPRT = "WLCSLPRT";

        /// <summary>
        /// WLMCUCSL.
        /// </summary>
        public const string WLMCUCSL = "WLMCUCSL";

        /// <summary>
        /// WLINVREQ.
        /// </summary>
        public const string WLINVREQ = "WLINVREQ";

        /// <summary>
        /// WLINVREC.
        /// </summary>
        public const string WLINVREC = "WLINVREC";

        /// <summary>
        /// WLSRVEND.
        /// </summary>
        public const string WLSRVEND = "WLSRVEND";

        /// <summary>
        /// WLRLOT.
        /// </summary>
        public const string WLRLOT = "WLRLOT";

        /// <summary>
        /// WLFAILCD.
        /// </summary>
        public const string WLFAILCD = "WLFAILCD";

        /// <summary>
        /// WLLSRCE.
        /// </summary>
        public const string WLLSRCE = "WLLSRCE";

        /// <summary>
        /// WLUKIDP.
        /// </summary>
        public const string WLUKIDP = "WLUKIDP";

        /// <summary>
        /// WLVMRS31.
        /// </summary>
        public const string WLVMRS31 = "WLVMRS31";

        /// <summary>
        /// WLVMRS32.
        /// </summary>
        public const string WLVMRS32 = "WLVMRS32";

        /// <summary>
        /// WLVMRS33.
        /// </summary>
        public const string WLVMRS33 = "WLVMRS33";

        /// <summary>
        /// WLSTRX.
        /// </summary>
        public const string WLSTRX = "WLSTRX";
    }

    /// <inheritdoc />
    public override string TableName => "F3112Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLEDUS", "WLEDUS", JdeDataType.String, 20, true, true),
        new JdeField("WLEDBT", "WLEDBT", JdeDataType.String, 30, true, true),
        new JdeField("WLEDTN", "WLEDTN", JdeDataType.String, 44, true, true),
        new JdeField("WLEDLN", "WLEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WLEDCT", "WLEDCT", JdeDataType.String, 4),
        new JdeField("WLTYTN", "WLTYTN", JdeDataType.String, 16),
        new JdeField("WLEDFT", "WLEDFT", JdeDataType.String, 20),
        new JdeField("WLEDDT", "WLEDDT", JdeDataType.Numeric),
        new JdeField("WLDRIN", "WLDRIN", JdeDataType.String, 2),
        new JdeField("WLEDDL", "WLEDDL", JdeDataType.Numeric),
        new JdeField("WLEDSP", "WLEDSP", JdeDataType.String, 2),
        new JdeField("WLPNID", "WLPNID", JdeDataType.String, 30),
        new JdeField("WLTNAC", "WLTNAC", JdeDataType.String, 4),
        new JdeField("WLDOCO", "WLDOCO", JdeDataType.Numeric),
        new JdeField("WLDCTO", "WLDCTO", JdeDataType.String, 4),
        new JdeField("WLSFXO", "WLSFXO", JdeDataType.String, 6),
        new JdeField("WLTRT", "WLTRT", JdeDataType.String, 6),
        new JdeField("WLKIT", "WLKIT", JdeDataType.Numeric),
        new JdeField("WLKITL", "WLKITL", JdeDataType.String, 50),
        new JdeField("WLKITA", "WLKITA", JdeDataType.String, 50),
        new JdeField("WLMMCU", "WLMMCU", JdeDataType.String, 24),
        new JdeField("WLLINE", "WLLINE", JdeDataType.String, 24),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLALD", "WLALD", JdeDataType.String, 8),
        new JdeField("WLDSC1", "WLDSC1", JdeDataType.String, 60),
        new JdeField("WLOPSQ", "WLOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WLOPSC", "WLOPSC", JdeDataType.String, 4, true, true),
        new JdeField("WLOPST", "WLOPST", JdeDataType.String, 4),
        new JdeField("WLINPE", "WLINPE", JdeDataType.String, 4),
        new JdeField("WLTIMB", "WLTIMB", JdeDataType.String, 2),
        new JdeField("WLLAMC", "WLLAMC", JdeDataType.String, 2),
        new JdeField("WLBFPF", "WLBFPF", JdeDataType.String, 2),
        new JdeField("WLPPRF", "WLPPRF", JdeDataType.String, 2),
        new JdeField("WLJBCD", "WLJBCD", JdeDataType.String, 12),
        new JdeField("WLAN8", "WLAN8", JdeDataType.Numeric),
        new JdeField("WLCRTR", "WLCRTR", JdeDataType.Numeric),
        new JdeField("WLSLTR", "WLSLTR", JdeDataType.Numeric),
        new JdeField("WLTRDJ", "WLTRDJ", JdeDataType.Numeric),
        new JdeField("WLDRQJ", "WLDRQJ", JdeDataType.Numeric),
        new JdeField("WLSTRT", "WLSTRT", JdeDataType.Numeric),
        new JdeField("WLRSFT", "WLRSFT", JdeDataType.String, 2),
        new JdeField("WLSSFT", "WLSSFT", JdeDataType.String, 2),
        new JdeField("WLCSFT", "WLCSFT", JdeDataType.String, 2),
        new JdeField("WLLTPC", "WLLTPC", JdeDataType.Numeric),
        new JdeField("WLPOVR", "WLPOVR", JdeDataType.Numeric),
        new JdeField("WLOPYP", "WLOPYP", JdeDataType.Numeric),
        new JdeField("WLCPYP", "WLCPYP", JdeDataType.Numeric),
        new JdeField("WLNXOP", "WLNXOP", JdeDataType.Numeric),
        new JdeField("WLSETC", "WLSETC", JdeDataType.Numeric),
        new JdeField("WLMOVD", "WLMOVD", JdeDataType.Numeric),
        new JdeField("WLQUED", "WLQUED", JdeDataType.Numeric),
        new JdeField("WLRUNM", "WLRUNM", JdeDataType.Numeric),
        new JdeField("WLRUNL", "WLRUNL", JdeDataType.Numeric),
        new JdeField("WLSETL", "WLSETL", JdeDataType.Numeric),
        new JdeField("WLMACA", "WLMACA", JdeDataType.Numeric),
        new JdeField("WLLABA", "WLLABA", JdeDataType.Numeric),
        new JdeField("WLSETA", "WLSETA", JdeDataType.Numeric),
        new JdeField("WLOPSR", "WLOPSR", JdeDataType.Numeric),
        new JdeField("WLUORG", "WLUORG", JdeDataType.Numeric),
        new JdeField("WLSOCN", "WLSOCN", JdeDataType.Numeric),
        new JdeField("WLSOQS", "WLSOQS", JdeDataType.Numeric),
        new JdeField("WLQMTO", "WLQMTO", JdeDataType.Numeric),
        new JdeField("WLPWRT", "WLPWRT", JdeDataType.Numeric),
        new JdeField("WLUOM", "WLUOM", JdeDataType.String, 4),
        new JdeField("WLCTS2", "WLCTS2", JdeDataType.Numeric),
        new JdeField("WLCTS3", "WLCTS3", JdeDataType.Numeric),
        new JdeField("WLCTS4", "WLCTS4", JdeDataType.Numeric),
        new JdeField("WLCTS5", "WLCTS5", JdeDataType.Numeric),
        new JdeField("WLCTS6", "WLCTS6", JdeDataType.Numeric),
        new JdeField("WLAPID", "WLAPID", JdeDataType.String, 24),
        new JdeField("WLSHNO", "WLSHNO", JdeDataType.String, 20),
        new JdeField("WLOMCU", "WLOMCU", JdeDataType.String, 24),
        new JdeField("WLOBJ", "WLOBJ", JdeDataType.String, 12),
        new JdeField("WLSUB", "WLSUB", JdeDataType.String, 16),
        new JdeField("WLVEND", "WLVEND", JdeDataType.Numeric),
        new JdeField("WLRKCO", "WLRKCO", JdeDataType.String, 10),
        new JdeField("WLRORN", "WLRORN", JdeDataType.String, 16),
        new JdeField("WLRCTO", "WLRCTO", JdeDataType.String, 4),
        new JdeField("WLRLLN", "WLRLLN", JdeDataType.Numeric),
        new JdeField("WLDCT", "WLDCT", JdeDataType.String, 4),
        new JdeField("WLURCD", "WLURCD", JdeDataType.String, 4),
        new JdeField("WLURDT", "WLURDT", JdeDataType.Numeric),
        new JdeField("WLURAT", "WLURAT", JdeDataType.Numeric),
        new JdeField("WLURAB", "WLURAB", JdeDataType.Numeric),
        new JdeField("WLURRF", "WLURRF", JdeDataType.String, 30),
        new JdeField("WLTORG", "WLTORG", JdeDataType.String, 20),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLTDAY", "WLTDAY", JdeDataType.Numeric),
        new JdeField("WLCAPU", "WLCAPU", JdeDataType.String, 4),
        new JdeField("WLCLHR", "WLCLHR", JdeDataType.Numeric),
        new JdeField("WLCMHR", "WLCMHR", JdeDataType.Numeric),
        new JdeField("WLCOST", "WLCOST", JdeDataType.String, 6),
        new JdeField("WLCSHR", "WLCSHR", JdeDataType.Numeric),
        new JdeField("WLLOCN", "WLLOCN", JdeDataType.String, 40),
        new JdeField("WLRUC", "WLRUC", JdeDataType.Numeric),
        new JdeField("WLWMCU", "WLWMCU", JdeDataType.String, 24),
        new JdeField("WLNUMB", "WLNUMB", JdeDataType.Numeric),
        new JdeField("WLCTS7", "WLCTS7", JdeDataType.Numeric),
        new JdeField("WLCTS8", "WLCTS8", JdeDataType.Numeric),
        new JdeField("WLSHFT", "WLSHFT", JdeDataType.String, 2),
        new JdeField("WLACTB", "WLACTB", JdeDataType.String, 20),
        new JdeField("WLCTS9", "WLCTS9", JdeDataType.Numeric),
        new JdeField("WLLABP", "WLLABP", JdeDataType.Numeric),
        new JdeField("WLMACR", "WLMACR", JdeDataType.Numeric),
        new JdeField("WLSETR", "WLSETR", JdeDataType.Numeric),
        new JdeField("WLAPSC", "WLAPSC", JdeDataType.String, 2),
        new JdeField("WLSEST", "WLSEST", JdeDataType.Numeric),
        new JdeField("WLSEET", "WLSEET", JdeDataType.Numeric),
        new JdeField("WLTMCO", "WLTMCO", JdeDataType.Numeric),
        new JdeField("WLD2J", "WLD2J", JdeDataType.Numeric),
        new JdeField("WLSTTI", "WLSTTI", JdeDataType.Numeric),
        new JdeField("WLCMPE", "WLCMPE", JdeDataType.String, 6),
        new JdeField("WLCMPC", "WLCMPC", JdeDataType.String, 20),
        new JdeField("WLCPLVLFR", "WLCPLVLFR", JdeDataType.Numeric),
        new JdeField("WLCPLVLTO", "WLCPLVLTO", JdeDataType.Numeric),
        new JdeField("WLCMRQ", "WLCMRQ", JdeDataType.String, 2),
        new JdeField("WLPAYAB", "WLPAYAB", JdeDataType.String, 2),
        new JdeField("WLBILL", "WLBILL", JdeDataType.String, 2),
        new JdeField("WLACRTB", "WLACRTB", JdeDataType.Numeric),
        new JdeField("WLACRTP", "WLACRTP", JdeDataType.Numeric),
        new JdeField("WLEBILL", "WLEBILL", JdeDataType.Numeric),
        new JdeField("WLAMTA", "WLAMTA", JdeDataType.Numeric),
        new JdeField("WLAMTO", "WLAMTO", JdeDataType.Numeric),
        new JdeField("WLESRTB", "WLESRTB", JdeDataType.Numeric),
        new JdeField("WLESRTP", "WLESRTP", JdeDataType.Numeric),
        new JdeField("WLEPAAP", "WLEPAAP", JdeDataType.Numeric),
        new JdeField("WLTOTB", "WLTOTB", JdeDataType.Numeric),
        new JdeField("WLCLAMT", "WLCLAMT", JdeDataType.Numeric),
        new JdeField("WLDTBIL", "WLDTBIL", JdeDataType.Numeric),
        new JdeField("WLDTPAY", "WLDTPAY", JdeDataType.Numeric),
        new JdeField("WLPAAP", "WLPAAP", JdeDataType.Numeric),
        new JdeField("WLLBR1", "WLLBR1", JdeDataType.Numeric),
        new JdeField("WLEPETM", "WLEPETM", JdeDataType.Numeric),
        new JdeField("WLENTCK", "WLENTCK", JdeDataType.String, 6),
        new JdeField("WLGLCNC", "WLGLCNC", JdeDataType.String, 8),
        new JdeField("WLGLCCV", "WLGLCCV", JdeDataType.String, 8),
        new JdeField("WLASN4", "WLASN4", JdeDataType.String, 16),
        new JdeField("WLASN2", "WLASN2", JdeDataType.String, 16),
        new JdeField("WLPCOVR", "WLPCOVR", JdeDataType.Numeric),
        new JdeField("WLMTHPR", "WLMTHPR", JdeDataType.String, 2),
        new JdeField("WLSAID", "WLSAID", JdeDataType.Numeric),
        new JdeField("WLPRODF", "WLPRODF", JdeDataType.String, 16),
        new JdeField("WLPRODM", "WLPRODM", JdeDataType.String, 16),
        new JdeField("WLCOVGR", "WLCOVGR", JdeDataType.String, 16),
        new JdeField("WLPMTHP", "WLPMTHP", JdeDataType.String, 2),
        new JdeField("WLPYPRT", "WLPYPRT", JdeDataType.String, 2),
        new JdeField("WLCRDC", "WLCRDC", JdeDataType.String, 6),
        new JdeField("WLBCRCD", "WLBCRCD", JdeDataType.String, 6),
        new JdeField("WLBCRR", "WLBCRR", JdeDataType.Numeric),
        new JdeField("WLBCRRM", "WLBCRRM", JdeDataType.String, 2),
        new JdeField("WLFESUNB", "WLFESUNB", JdeDataType.Numeric),
        new JdeField("WLFEBILL", "WLFEBILL", JdeDataType.Numeric),
        new JdeField("WLFACUNB", "WLFACUNB", JdeDataType.Numeric),
        new JdeField("WLFTOTB", "WLFTOTB", JdeDataType.Numeric),
        new JdeField("WLPCRCD", "WLPCRCD", JdeDataType.String, 6),
        new JdeField("WLPCRR", "WLPCRR", JdeDataType.Numeric),
        new JdeField("WLPCRRM", "WLPCRRM", JdeDataType.String, 2),
        new JdeField("WLFESUNP", "WLFESUNP", JdeDataType.Numeric),
        new JdeField("WLFEPAAP", "WLFEPAAP", JdeDataType.Numeric),
        new JdeField("WLFACUNP", "WLFACUNP", JdeDataType.Numeric),
        new JdeField("WLFPAAP", "WLFPAAP", JdeDataType.Numeric),
        new JdeField("WLDTSUB", "WLDTSUB", JdeDataType.Numeric),
        new JdeField("WLTMSUB", "WLTMSUB", JdeDataType.Numeric),
        new JdeField("WLCSLPRT", "WLCSLPRT", JdeDataType.Numeric),
        new JdeField("WLMCUCSL", "WLMCUCSL", JdeDataType.String, 24),
        new JdeField("WLINVREQ", "WLINVREQ", JdeDataType.String, 2),
        new JdeField("WLINVREC", "WLINVREC", JdeDataType.String, 2),
        new JdeField("WLSRVEND", "WLSRVEND", JdeDataType.Numeric),
        new JdeField("WLRLOT", "WLRLOT", JdeDataType.String, 60),
        new JdeField("WLFAILCD", "WLFAILCD", JdeDataType.String, 16),
        new JdeField("WLLSRCE", "WLLSRCE", JdeDataType.String, 2),
        new JdeField("WLUKIDP", "WLUKIDP", JdeDataType.Numeric),
        new JdeField("WLVMRS31", "WLVMRS31", JdeDataType.String, 4),
        new JdeField("WLVMRS32", "WLVMRS32", JdeDataType.String, 16),
        new JdeField("WLVMRS33", "WLVMRS33", JdeDataType.String, 20),
        new JdeField("WLSTRX", "WLSTRX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3112Z2_0", "Primary Key on WLEDUS, WLEDBT, WLEDTN, WLEDLN, WLOPSQ, WLOPSC, WLMCU", new[] { "WLEDUS", "WLEDBT", "WLEDTN", "WLEDLN", "WLOPSQ", "WLOPSC", "WLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
