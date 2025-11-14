using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4102 - .
/// </summary>
public class F4102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBLITM.
        /// </summary>
        public const string IBLITM = "IBLITM";

        /// <summary>
        /// IBAITM.
        /// </summary>
        public const string IBAITM = "IBAITM";

        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBSRP1.
        /// </summary>
        public const string IBSRP1 = "IBSRP1";

        /// <summary>
        /// IBSRP2.
        /// </summary>
        public const string IBSRP2 = "IBSRP2";

        /// <summary>
        /// IBSRP3.
        /// </summary>
        public const string IBSRP3 = "IBSRP3";

        /// <summary>
        /// IBSRP4.
        /// </summary>
        public const string IBSRP4 = "IBSRP4";

        /// <summary>
        /// IBSRP5.
        /// </summary>
        public const string IBSRP5 = "IBSRP5";

        /// <summary>
        /// IBSRP6.
        /// </summary>
        public const string IBSRP6 = "IBSRP6";

        /// <summary>
        /// IBSRP7.
        /// </summary>
        public const string IBSRP7 = "IBSRP7";

        /// <summary>
        /// IBSRP8.
        /// </summary>
        public const string IBSRP8 = "IBSRP8";

        /// <summary>
        /// IBSRP9.
        /// </summary>
        public const string IBSRP9 = "IBSRP9";

        /// <summary>
        /// IBSRP0.
        /// </summary>
        public const string IBSRP0 = "IBSRP0";

        /// <summary>
        /// IBPRP1.
        /// </summary>
        public const string IBPRP1 = "IBPRP1";

        /// <summary>
        /// IBPRP2.
        /// </summary>
        public const string IBPRP2 = "IBPRP2";

        /// <summary>
        /// IBPRP3.
        /// </summary>
        public const string IBPRP3 = "IBPRP3";

        /// <summary>
        /// IBPRP4.
        /// </summary>
        public const string IBPRP4 = "IBPRP4";

        /// <summary>
        /// IBPRP5.
        /// </summary>
        public const string IBPRP5 = "IBPRP5";

        /// <summary>
        /// IBPRP6.
        /// </summary>
        public const string IBPRP6 = "IBPRP6";

        /// <summary>
        /// IBPRP7.
        /// </summary>
        public const string IBPRP7 = "IBPRP7";

        /// <summary>
        /// IBPRP8.
        /// </summary>
        public const string IBPRP8 = "IBPRP8";

        /// <summary>
        /// IBPRP9.
        /// </summary>
        public const string IBPRP9 = "IBPRP9";

        /// <summary>
        /// IBPRP0.
        /// </summary>
        public const string IBPRP0 = "IBPRP0";

        /// <summary>
        /// IBCDCD.
        /// </summary>
        public const string IBCDCD = "IBCDCD";

        /// <summary>
        /// IBPDGR.
        /// </summary>
        public const string IBPDGR = "IBPDGR";

        /// <summary>
        /// IBDSGP.
        /// </summary>
        public const string IBDSGP = "IBDSGP";

        /// <summary>
        /// IBVEND.
        /// </summary>
        public const string IBVEND = "IBVEND";

        /// <summary>
        /// IBANPL.
        /// </summary>
        public const string IBANPL = "IBANPL";

        /// <summary>
        /// IBBUYR.
        /// </summary>
        public const string IBBUYR = "IBBUYR";

        /// <summary>
        /// IBGLPT.
        /// </summary>
        public const string IBGLPT = "IBGLPT";

        /// <summary>
        /// IBORIG.
        /// </summary>
        public const string IBORIG = "IBORIG";

        /// <summary>
        /// IBROPI.
        /// </summary>
        public const string IBROPI = "IBROPI";

        /// <summary>
        /// IBROQI.
        /// </summary>
        public const string IBROQI = "IBROQI";

        /// <summary>
        /// IBRQMX.
        /// </summary>
        public const string IBRQMX = "IBRQMX";

        /// <summary>
        /// IBRQMN.
        /// </summary>
        public const string IBRQMN = "IBRQMN";

        /// <summary>
        /// IBWOMO.
        /// </summary>
        public const string IBWOMO = "IBWOMO";

        /// <summary>
        /// IBSERV.
        /// </summary>
        public const string IBSERV = "IBSERV";

        /// <summary>
        /// IBSAFE.
        /// </summary>
        public const string IBSAFE = "IBSAFE";

        /// <summary>
        /// IBSLD.
        /// </summary>
        public const string IBSLD = "IBSLD";

        /// <summary>
        /// IBCKAV.
        /// </summary>
        public const string IBCKAV = "IBCKAV";

        /// <summary>
        /// IBSRCE.
        /// </summary>
        public const string IBSRCE = "IBSRCE";

        /// <summary>
        /// IBLOTS.
        /// </summary>
        public const string IBLOTS = "IBLOTS";

        /// <summary>
        /// IBOT1Y.
        /// </summary>
        public const string IBOT1Y = "IBOT1Y";

        /// <summary>
        /// IBOT2Y.
        /// </summary>
        public const string IBOT2Y = "IBOT2Y";

        /// <summary>
        /// IBSTDP.
        /// </summary>
        public const string IBSTDP = "IBSTDP";

        /// <summary>
        /// IBFRMP.
        /// </summary>
        public const string IBFRMP = "IBFRMP";

        /// <summary>
        /// IBTHRP.
        /// </summary>
        public const string IBTHRP = "IBTHRP";

        /// <summary>
        /// IBSTDG.
        /// </summary>
        public const string IBSTDG = "IBSTDG";

        /// <summary>
        /// IBFRGD.
        /// </summary>
        public const string IBFRGD = "IBFRGD";

        /// <summary>
        /// IBTHGD.
        /// </summary>
        public const string IBTHGD = "IBTHGD";

        /// <summary>
        /// IBCOTY.
        /// </summary>
        public const string IBCOTY = "IBCOTY";

        /// <summary>
        /// IBMMPC.
        /// </summary>
        public const string IBMMPC = "IBMMPC";

        /// <summary>
        /// IBPRGR.
        /// </summary>
        public const string IBPRGR = "IBPRGR";

        /// <summary>
        /// IBRPRC.
        /// </summary>
        public const string IBRPRC = "IBRPRC";

        /// <summary>
        /// IBORPR.
        /// </summary>
        public const string IBORPR = "IBORPR";

        /// <summary>
        /// IBBACK.
        /// </summary>
        public const string IBBACK = "IBBACK";

        /// <summary>
        /// IBIFLA.
        /// </summary>
        public const string IBIFLA = "IBIFLA";

        /// <summary>
        /// IBABCS.
        /// </summary>
        public const string IBABCS = "IBABCS";

        /// <summary>
        /// IBABCM.
        /// </summary>
        public const string IBABCM = "IBABCM";

        /// <summary>
        /// IBABCI.
        /// </summary>
        public const string IBABCI = "IBABCI";

        /// <summary>
        /// IBOVR.
        /// </summary>
        public const string IBOVR = "IBOVR";

        /// <summary>
        /// IBSHCM.
        /// </summary>
        public const string IBSHCM = "IBSHCM";

        /// <summary>
        /// IBCARS.
        /// </summary>
        public const string IBCARS = "IBCARS";

        /// <summary>
        /// IBCARP.
        /// </summary>
        public const string IBCARP = "IBCARP";

        /// <summary>
        /// IBSHCN.
        /// </summary>
        public const string IBSHCN = "IBSHCN";

        /// <summary>
        /// IBSTKT.
        /// </summary>
        public const string IBSTKT = "IBSTKT";

        /// <summary>
        /// IBLNTY.
        /// </summary>
        public const string IBLNTY = "IBLNTY";

        /// <summary>
        /// IBFIFO.
        /// </summary>
        public const string IBFIFO = "IBFIFO";

        /// <summary>
        /// IBCYCL.
        /// </summary>
        public const string IBCYCL = "IBCYCL";

        /// <summary>
        /// IBINMG.
        /// </summary>
        public const string IBINMG = "IBINMG";

        /// <summary>
        /// IBWARR.
        /// </summary>
        public const string IBWARR = "IBWARR";

        /// <summary>
        /// IBSRNR.
        /// </summary>
        public const string IBSRNR = "IBSRNR";

        /// <summary>
        /// IBPCTM.
        /// </summary>
        public const string IBPCTM = "IBPCTM";

        /// <summary>
        /// IBCMCG.
        /// </summary>
        public const string IBCMCG = "IBCMCG";

        /// <summary>
        /// IBFUF1.
        /// </summary>
        public const string IBFUF1 = "IBFUF1";

        /// <summary>
        /// IBTX.
        /// </summary>
        public const string IBTX = "IBTX";

        /// <summary>
        /// IBTAX1.
        /// </summary>
        public const string IBTAX1 = "IBTAX1";

        /// <summary>
        /// IBMPST.
        /// </summary>
        public const string IBMPST = "IBMPST";

        /// <summary>
        /// IBMRPD.
        /// </summary>
        public const string IBMRPD = "IBMRPD";

        /// <summary>
        /// IBMRPC.
        /// </summary>
        public const string IBMRPC = "IBMRPC";

        /// <summary>
        /// IBUPC.
        /// </summary>
        public const string IBUPC = "IBUPC";

        /// <summary>
        /// IBSNS.
        /// </summary>
        public const string IBSNS = "IBSNS";

        /// <summary>
        /// IBMERL.
        /// </summary>
        public const string IBMERL = "IBMERL";

        /// <summary>
        /// IBLTLV.
        /// </summary>
        public const string IBLTLV = "IBLTLV";

        /// <summary>
        /// IBLTMF.
        /// </summary>
        public const string IBLTMF = "IBLTMF";

        /// <summary>
        /// IBLTCM.
        /// </summary>
        public const string IBLTCM = "IBLTCM";

        /// <summary>
        /// IBOPC.
        /// </summary>
        public const string IBOPC = "IBOPC";

        /// <summary>
        /// IBOPV.
        /// </summary>
        public const string IBOPV = "IBOPV";

        /// <summary>
        /// IBACQ.
        /// </summary>
        public const string IBACQ = "IBACQ";

        /// <summary>
        /// IBMLQ.
        /// </summary>
        public const string IBMLQ = "IBMLQ";

        /// <summary>
        /// IBLTPU.
        /// </summary>
        public const string IBLTPU = "IBLTPU";

        /// <summary>
        /// IBMPSP.
        /// </summary>
        public const string IBMPSP = "IBMPSP";

        /// <summary>
        /// IBMRPP.
        /// </summary>
        public const string IBMRPP = "IBMRPP";

        /// <summary>
        /// IBITC.
        /// </summary>
        public const string IBITC = "IBITC";

        /// <summary>
        /// IBECO.
        /// </summary>
        public const string IBECO = "IBECO";

        /// <summary>
        /// IBECTY.
        /// </summary>
        public const string IBECTY = "IBECTY";

        /// <summary>
        /// IBECOD.
        /// </summary>
        public const string IBECOD = "IBECOD";

        /// <summary>
        /// IBMTF1.
        /// </summary>
        public const string IBMTF1 = "IBMTF1";

        /// <summary>
        /// IBMTF2.
        /// </summary>
        public const string IBMTF2 = "IBMTF2";

        /// <summary>
        /// IBMTF3.
        /// </summary>
        public const string IBMTF3 = "IBMTF3";

        /// <summary>
        /// IBMTF4.
        /// </summary>
        public const string IBMTF4 = "IBMTF4";

        /// <summary>
        /// IBMTF5.
        /// </summary>
        public const string IBMTF5 = "IBMTF5";

        /// <summary>
        /// IBMOVD.
        /// </summary>
        public const string IBMOVD = "IBMOVD";

        /// <summary>
        /// IBQUED.
        /// </summary>
        public const string IBQUED = "IBQUED";

        /// <summary>
        /// IBSETL.
        /// </summary>
        public const string IBSETL = "IBSETL";

        /// <summary>
        /// IBSRNK.
        /// </summary>
        public const string IBSRNK = "IBSRNK";

        /// <summary>
        /// IBSRKF.
        /// </summary>
        public const string IBSRKF = "IBSRKF";

        /// <summary>
        /// IBTIMB.
        /// </summary>
        public const string IBTIMB = "IBTIMB";

        /// <summary>
        /// IBBQTY.
        /// </summary>
        public const string IBBQTY = "IBBQTY";

        /// <summary>
        /// IBORDW.
        /// </summary>
        public const string IBORDW = "IBORDW";

        /// <summary>
        /// IBEXPD.
        /// </summary>
        public const string IBEXPD = "IBEXPD";

        /// <summary>
        /// IBDEFD.
        /// </summary>
        public const string IBDEFD = "IBDEFD";

        /// <summary>
        /// IBMULT.
        /// </summary>
        public const string IBMULT = "IBMULT";

        /// <summary>
        /// IBSFLT.
        /// </summary>
        public const string IBSFLT = "IBSFLT";

        /// <summary>
        /// IBMAKE.
        /// </summary>
        public const string IBMAKE = "IBMAKE";

        /// <summary>
        /// IBLFDJ.
        /// </summary>
        public const string IBLFDJ = "IBLFDJ";

        /// <summary>
        /// IBLLX.
        /// </summary>
        public const string IBLLX = "IBLLX";

        /// <summary>
        /// IBCMGL.
        /// </summary>
        public const string IBCMGL = "IBCMGL";

        /// <summary>
        /// IBURCD.
        /// </summary>
        public const string IBURCD = "IBURCD";

        /// <summary>
        /// IBURDT.
        /// </summary>
        public const string IBURDT = "IBURDT";

        /// <summary>
        /// IBURAT.
        /// </summary>
        public const string IBURAT = "IBURAT";

        /// <summary>
        /// IBURAB.
        /// </summary>
        public const string IBURAB = "IBURAB";

        /// <summary>
        /// IBURRF.
        /// </summary>
        public const string IBURRF = "IBURRF";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBTDAY.
        /// </summary>
        public const string IBTDAY = "IBTDAY";

        /// <summary>
        /// IBTFLA.
        /// </summary>
        public const string IBTFLA = "IBTFLA";

        /// <summary>
        /// IBCOMH.
        /// </summary>
        public const string IBCOMH = "IBCOMH";

        /// <summary>
        /// IBAVRT.
        /// </summary>
        public const string IBAVRT = "IBAVRT";

        /// <summary>
        /// IBPOC.
        /// </summary>
        public const string IBPOC = "IBPOC";

        /// <summary>
        /// IBAING.
        /// </summary>
        public const string IBAING = "IBAING";

        /// <summary>
        /// IBBBDD.
        /// </summary>
        public const string IBBBDD = "IBBBDD";

        /// <summary>
        /// IBCMDM.
        /// </summary>
        public const string IBCMDM = "IBCMDM";

        /// <summary>
        /// IBLECM.
        /// </summary>
        public const string IBLECM = "IBLECM";

        /// <summary>
        /// IBLEDD.
        /// </summary>
        public const string IBLEDD = "IBLEDD";

        /// <summary>
        /// IBMLOT.
        /// </summary>
        public const string IBMLOT = "IBMLOT";

        /// <summary>
        /// IBPEFD.
        /// </summary>
        public const string IBPEFD = "IBPEFD";

        /// <summary>
        /// IBSBDD.
        /// </summary>
        public const string IBSBDD = "IBSBDD";

        /// <summary>
        /// IBU1DD.
        /// </summary>
        public const string IBU1DD = "IBU1DD";

        /// <summary>
        /// IBU2DD.
        /// </summary>
        public const string IBU2DD = "IBU2DD";

        /// <summary>
        /// IBU3DD.
        /// </summary>
        public const string IBU3DD = "IBU3DD";

        /// <summary>
        /// IBU4DD.
        /// </summary>
        public const string IBU4DD = "IBU4DD";

        /// <summary>
        /// IBU5DD.
        /// </summary>
        public const string IBU5DD = "IBU5DD";

        /// <summary>
        /// IBXDCK.
        /// </summary>
        public const string IBXDCK = "IBXDCK";

        /// <summary>
        /// IBLAF.
        /// </summary>
        public const string IBLAF = "IBLAF";

        /// <summary>
        /// IBLTFM.
        /// </summary>
        public const string IBLTFM = "IBLTFM";

        /// <summary>
        /// IBRWLA.
        /// </summary>
        public const string IBRWLA = "IBRWLA";

        /// <summary>
        /// IBLNPA.
        /// </summary>
        public const string IBLNPA = "IBLNPA";

        /// <summary>
        /// IBLOTC.
        /// </summary>
        public const string IBLOTC = "IBLOTC";

        /// <summary>
        /// IBAPSC.
        /// </summary>
        public const string IBAPSC = "IBAPSC";

        /// <summary>
        /// IBPRI1.
        /// </summary>
        public const string IBPRI1 = "IBPRI1";

        /// <summary>
        /// IBPRI2.
        /// </summary>
        public const string IBPRI2 = "IBPRI2";

        /// <summary>
        /// IBLTCV.
        /// </summary>
        public const string IBLTCV = "IBLTCV";

        /// <summary>
        /// IBASHL.
        /// </summary>
        public const string IBASHL = "IBASHL";

        /// <summary>
        /// IBOPTH.
        /// </summary>
        public const string IBOPTH = "IBOPTH";

        /// <summary>
        /// IBCUTH.
        /// </summary>
        public const string IBCUTH = "IBCUTH";

        /// <summary>
        /// IBUMTH.
        /// </summary>
        public const string IBUMTH = "IBUMTH";

        /// <summary>
        /// IBLMFG.
        /// </summary>
        public const string IBLMFG = "IBLMFG";

        /// <summary>
        /// IBLINE.
        /// </summary>
        public const string IBLINE = "IBLINE";

        /// <summary>
        /// IBDFTPCT.
        /// </summary>
        public const string IBDFTPCT = "IBDFTPCT";

        /// <summary>
        /// IBKBIT.
        /// </summary>
        public const string IBKBIT = "IBKBIT";

        /// <summary>
        /// IBDFENDITM.
        /// </summary>
        public const string IBDFENDITM = "IBDFENDITM";

        /// <summary>
        /// IBKANEXLL.
        /// </summary>
        public const string IBKANEXLL = "IBKANEXLL";

        /// <summary>
        /// IBSCPSELL.
        /// </summary>
        public const string IBSCPSELL = "IBSCPSELL";

        /// <summary>
        /// IBMOPTH.
        /// </summary>
        public const string IBMOPTH = "IBMOPTH";

        /// <summary>
        /// IBMCUTH.
        /// </summary>
        public const string IBMCUTH = "IBMCUTH";

        /// <summary>
        /// IBCUMTH.
        /// </summary>
        public const string IBCUMTH = "IBCUMTH";

        /// <summary>
        /// IBATPRN.
        /// </summary>
        public const string IBATPRN = "IBATPRN";

        /// <summary>
        /// IBATPCA.
        /// </summary>
        public const string IBATPCA = "IBATPCA";

        /// <summary>
        /// IBATPAC.
        /// </summary>
        public const string IBATPAC = "IBATPAC";

        /// <summary>
        /// IBCOORE.
        /// </summary>
        public const string IBCOORE = "IBCOORE";

        /// <summary>
        /// IBVCPFC.
        /// </summary>
        public const string IBVCPFC = "IBVCPFC";

        /// <summary>
        /// IBPNYN.
        /// </summary>
        public const string IBPNYN = "IBPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "F4102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBLITM", "IBLITM", JdeDataType.String, 50),
        new JdeField("IBAITM", "IBAITM", JdeDataType.String, 50),
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBSRP1", "IBSRP1", JdeDataType.String, 6),
        new JdeField("IBSRP2", "IBSRP2", JdeDataType.String, 6),
        new JdeField("IBSRP3", "IBSRP3", JdeDataType.String, 6),
        new JdeField("IBSRP4", "IBSRP4", JdeDataType.String, 6),
        new JdeField("IBSRP5", "IBSRP5", JdeDataType.String, 6),
        new JdeField("IBSRP6", "IBSRP6", JdeDataType.String, 12),
        new JdeField("IBSRP7", "IBSRP7", JdeDataType.String, 12),
        new JdeField("IBSRP8", "IBSRP8", JdeDataType.String, 12),
        new JdeField("IBSRP9", "IBSRP9", JdeDataType.String, 12),
        new JdeField("IBSRP0", "IBSRP0", JdeDataType.String, 12),
        new JdeField("IBPRP1", "IBPRP1", JdeDataType.String, 6),
        new JdeField("IBPRP2", "IBPRP2", JdeDataType.String, 6),
        new JdeField("IBPRP3", "IBPRP3", JdeDataType.String, 6),
        new JdeField("IBPRP4", "IBPRP4", JdeDataType.String, 6),
        new JdeField("IBPRP5", "IBPRP5", JdeDataType.String, 6),
        new JdeField("IBPRP6", "IBPRP6", JdeDataType.String, 12),
        new JdeField("IBPRP7", "IBPRP7", JdeDataType.String, 12),
        new JdeField("IBPRP8", "IBPRP8", JdeDataType.String, 12),
        new JdeField("IBPRP9", "IBPRP9", JdeDataType.String, 12),
        new JdeField("IBPRP0", "IBPRP0", JdeDataType.String, 12),
        new JdeField("IBCDCD", "IBCDCD", JdeDataType.String, 30),
        new JdeField("IBPDGR", "IBPDGR", JdeDataType.String, 6),
        new JdeField("IBDSGP", "IBDSGP", JdeDataType.String, 6),
        new JdeField("IBVEND", "IBVEND", JdeDataType.Numeric),
        new JdeField("IBANPL", "IBANPL", JdeDataType.Numeric),
        new JdeField("IBBUYR", "IBBUYR", JdeDataType.Numeric),
        new JdeField("IBGLPT", "IBGLPT", JdeDataType.String, 8),
        new JdeField("IBORIG", "IBORIG", JdeDataType.String, 6),
        new JdeField("IBROPI", "IBROPI", JdeDataType.Numeric),
        new JdeField("IBROQI", "IBROQI", JdeDataType.Numeric),
        new JdeField("IBRQMX", "IBRQMX", JdeDataType.Numeric),
        new JdeField("IBRQMN", "IBRQMN", JdeDataType.Numeric),
        new JdeField("IBWOMO", "IBWOMO", JdeDataType.Numeric),
        new JdeField("IBSERV", "IBSERV", JdeDataType.Numeric),
        new JdeField("IBSAFE", "IBSAFE", JdeDataType.Numeric),
        new JdeField("IBSLD", "IBSLD", JdeDataType.Numeric),
        new JdeField("IBCKAV", "IBCKAV", JdeDataType.String, 2),
        new JdeField("IBSRCE", "IBSRCE", JdeDataType.String, 2),
        new JdeField("IBLOTS", "IBLOTS", JdeDataType.String, 2),
        new JdeField("IBOT1Y", "IBOT1Y", JdeDataType.String, 2),
        new JdeField("IBOT2Y", "IBOT2Y", JdeDataType.String, 2),
        new JdeField("IBSTDP", "IBSTDP", JdeDataType.Numeric),
        new JdeField("IBFRMP", "IBFRMP", JdeDataType.Numeric),
        new JdeField("IBTHRP", "IBTHRP", JdeDataType.Numeric),
        new JdeField("IBSTDG", "IBSTDG", JdeDataType.String, 6),
        new JdeField("IBFRGD", "IBFRGD", JdeDataType.String, 6),
        new JdeField("IBTHGD", "IBTHGD", JdeDataType.String, 6),
        new JdeField("IBCOTY", "IBCOTY", JdeDataType.String, 2),
        new JdeField("IBMMPC", "IBMMPC", JdeDataType.Numeric),
        new JdeField("IBPRGR", "IBPRGR", JdeDataType.String, 16),
        new JdeField("IBRPRC", "IBRPRC", JdeDataType.String, 16),
        new JdeField("IBORPR", "IBORPR", JdeDataType.String, 16),
        new JdeField("IBBACK", "IBBACK", JdeDataType.String, 2),
        new JdeField("IBIFLA", "IBIFLA", JdeDataType.String, 4),
        new JdeField("IBABCS", "IBABCS", JdeDataType.String, 2),
        new JdeField("IBABCM", "IBABCM", JdeDataType.String, 2),
        new JdeField("IBABCI", "IBABCI", JdeDataType.String, 2),
        new JdeField("IBOVR", "IBOVR", JdeDataType.String, 2),
        new JdeField("IBSHCM", "IBSHCM", JdeDataType.String, 6),
        new JdeField("IBCARS", "IBCARS", JdeDataType.Numeric),
        new JdeField("IBCARP", "IBCARP", JdeDataType.Numeric),
        new JdeField("IBSHCN", "IBSHCN", JdeDataType.String, 6),
        new JdeField("IBSTKT", "IBSTKT", JdeDataType.String, 2),
        new JdeField("IBLNTY", "IBLNTY", JdeDataType.String, 4),
        new JdeField("IBFIFO", "IBFIFO", JdeDataType.String, 2),
        new JdeField("IBCYCL", "IBCYCL", JdeDataType.String, 6),
        new JdeField("IBINMG", "IBINMG", JdeDataType.String, 20),
        new JdeField("IBWARR", "IBWARR", JdeDataType.String, 16),
        new JdeField("IBSRNR", "IBSRNR", JdeDataType.String, 2),
        new JdeField("IBPCTM", "IBPCTM", JdeDataType.Numeric),
        new JdeField("IBCMCG", "IBCMCG", JdeDataType.String, 16),
        new JdeField("IBFUF1", "IBFUF1", JdeDataType.String, 2),
        new JdeField("IBTX", "IBTX", JdeDataType.String, 2),
        new JdeField("IBTAX1", "IBTAX1", JdeDataType.String, 2),
        new JdeField("IBMPST", "IBMPST", JdeDataType.String, 2),
        new JdeField("IBMRPD", "IBMRPD", JdeDataType.String, 2),
        new JdeField("IBMRPC", "IBMRPC", JdeDataType.String, 2),
        new JdeField("IBUPC", "IBUPC", JdeDataType.Numeric),
        new JdeField("IBSNS", "IBSNS", JdeDataType.String, 2),
        new JdeField("IBMERL", "IBMERL", JdeDataType.String, 6),
        new JdeField("IBLTLV", "IBLTLV", JdeDataType.Numeric),
        new JdeField("IBLTMF", "IBLTMF", JdeDataType.Numeric),
        new JdeField("IBLTCM", "IBLTCM", JdeDataType.Numeric),
        new JdeField("IBOPC", "IBOPC", JdeDataType.String, 2),
        new JdeField("IBOPV", "IBOPV", JdeDataType.Numeric),
        new JdeField("IBACQ", "IBACQ", JdeDataType.Numeric),
        new JdeField("IBMLQ", "IBMLQ", JdeDataType.Numeric),
        new JdeField("IBLTPU", "IBLTPU", JdeDataType.Numeric),
        new JdeField("IBMPSP", "IBMPSP", JdeDataType.String, 2),
        new JdeField("IBMRPP", "IBMRPP", JdeDataType.String, 2),
        new JdeField("IBITC", "IBITC", JdeDataType.String, 2),
        new JdeField("IBECO", "IBECO", JdeDataType.String, 24),
        new JdeField("IBECTY", "IBECTY", JdeDataType.String, 4),
        new JdeField("IBECOD", "IBECOD", JdeDataType.Numeric),
        new JdeField("IBMTF1", "IBMTF1", JdeDataType.Numeric),
        new JdeField("IBMTF2", "IBMTF2", JdeDataType.Numeric),
        new JdeField("IBMTF3", "IBMTF3", JdeDataType.Numeric),
        new JdeField("IBMTF4", "IBMTF4", JdeDataType.Numeric),
        new JdeField("IBMTF5", "IBMTF5", JdeDataType.Numeric),
        new JdeField("IBMOVD", "IBMOVD", JdeDataType.Numeric),
        new JdeField("IBQUED", "IBQUED", JdeDataType.Numeric),
        new JdeField("IBSETL", "IBSETL", JdeDataType.Numeric),
        new JdeField("IBSRNK", "IBSRNK", JdeDataType.Numeric),
        new JdeField("IBSRKF", "IBSRKF", JdeDataType.String, 2),
        new JdeField("IBTIMB", "IBTIMB", JdeDataType.String, 2),
        new JdeField("IBBQTY", "IBBQTY", JdeDataType.Numeric),
        new JdeField("IBORDW", "IBORDW", JdeDataType.String, 2),
        new JdeField("IBEXPD", "IBEXPD", JdeDataType.Numeric),
        new JdeField("IBDEFD", "IBDEFD", JdeDataType.Numeric),
        new JdeField("IBMULT", "IBMULT", JdeDataType.Numeric),
        new JdeField("IBSFLT", "IBSFLT", JdeDataType.Numeric),
        new JdeField("IBMAKE", "IBMAKE", JdeDataType.String, 2),
        new JdeField("IBLFDJ", "IBLFDJ", JdeDataType.Numeric),
        new JdeField("IBLLX", "IBLLX", JdeDataType.Numeric),
        new JdeField("IBCMGL", "IBCMGL", JdeDataType.String, 2),
        new JdeField("IBURCD", "IBURCD", JdeDataType.String, 4),
        new JdeField("IBURDT", "IBURDT", JdeDataType.Numeric),
        new JdeField("IBURAT", "IBURAT", JdeDataType.Numeric),
        new JdeField("IBURAB", "IBURAB", JdeDataType.Numeric),
        new JdeField("IBURRF", "IBURRF", JdeDataType.String, 30),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBTDAY", "IBTDAY", JdeDataType.Numeric),
        new JdeField("IBTFLA", "IBTFLA", JdeDataType.String, 4),
        new JdeField("IBCOMH", "IBCOMH", JdeDataType.Numeric),
        new JdeField("IBAVRT", "IBAVRT", JdeDataType.Numeric),
        new JdeField("IBPOC", "IBPOC", JdeDataType.String, 2),
        new JdeField("IBAING", "IBAING", JdeDataType.String, 2),
        new JdeField("IBBBDD", "IBBBDD", JdeDataType.Numeric),
        new JdeField("IBCMDM", "IBCMDM", JdeDataType.String, 2),
        new JdeField("IBLECM", "IBLECM", JdeDataType.String, 2),
        new JdeField("IBLEDD", "IBLEDD", JdeDataType.Numeric),
        new JdeField("IBMLOT", "IBMLOT", JdeDataType.String, 2),
        new JdeField("IBPEFD", "IBPEFD", JdeDataType.Numeric),
        new JdeField("IBSBDD", "IBSBDD", JdeDataType.Numeric),
        new JdeField("IBU1DD", "IBU1DD", JdeDataType.Numeric),
        new JdeField("IBU2DD", "IBU2DD", JdeDataType.Numeric),
        new JdeField("IBU3DD", "IBU3DD", JdeDataType.Numeric),
        new JdeField("IBU4DD", "IBU4DD", JdeDataType.Numeric),
        new JdeField("IBU5DD", "IBU5DD", JdeDataType.Numeric),
        new JdeField("IBXDCK", "IBXDCK", JdeDataType.String, 2),
        new JdeField("IBLAF", "IBLAF", JdeDataType.String, 2),
        new JdeField("IBLTFM", "IBLTFM", JdeDataType.String, 2),
        new JdeField("IBRWLA", "IBRWLA", JdeDataType.String, 2),
        new JdeField("IBLNPA", "IBLNPA", JdeDataType.String, 2),
        new JdeField("IBLOTC", "IBLOTC", JdeDataType.String, 6),
        new JdeField("IBAPSC", "IBAPSC", JdeDataType.String, 2),
        new JdeField("IBPRI1", "IBPRI1", JdeDataType.Numeric),
        new JdeField("IBPRI2", "IBPRI2", JdeDataType.Numeric),
        new JdeField("IBLTCV", "IBLTCV", JdeDataType.Numeric),
        new JdeField("IBASHL", "IBASHL", JdeDataType.String, 2),
        new JdeField("IBOPTH", "IBOPTH", JdeDataType.Numeric),
        new JdeField("IBCUTH", "IBCUTH", JdeDataType.Numeric),
        new JdeField("IBUMTH", "IBUMTH", JdeDataType.String, 6),
        new JdeField("IBLMFG", "IBLMFG", JdeDataType.String, 2),
        new JdeField("IBLINE", "IBLINE", JdeDataType.String, 24),
        new JdeField("IBDFTPCT", "IBDFTPCT", JdeDataType.Numeric),
        new JdeField("IBKBIT", "IBKBIT", JdeDataType.String, 2),
        new JdeField("IBDFENDITM", "IBDFENDITM", JdeDataType.String, 2),
        new JdeField("IBKANEXLL", "IBKANEXLL", JdeDataType.String, 2),
        new JdeField("IBSCPSELL", "IBSCPSELL", JdeDataType.String, 2),
        new JdeField("IBMOPTH", "IBMOPTH", JdeDataType.Numeric),
        new JdeField("IBMCUTH", "IBMCUTH", JdeDataType.Numeric),
        new JdeField("IBCUMTH", "IBCUMTH", JdeDataType.String, 6),
        new JdeField("IBATPRN", "IBATPRN", JdeDataType.String, 160),
        new JdeField("IBATPCA", "IBATPCA", JdeDataType.String, 2),
        new JdeField("IBATPAC", "IBATPAC", JdeDataType.String, 10),
        new JdeField("IBCOORE", "IBCOORE", JdeDataType.String, 2),
        new JdeField("IBVCPFC", "IBVCPFC", JdeDataType.String, 40),
        new JdeField("IBPNYN", "IBPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4102_0", "Primary Key on IBMCU, IBITM", new[] { "IBMCU", "IBITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4102_10", "Index on IBMCU, IBPRP7, IBPRP8, IBPRP9", new[] { "IBMCU", "IBPRP7", "IBPRP8", "IBPRP9" }),
        new JdeIndex("F4102_11", "Index on IBLLX, IBITM, IBMCU", new[] { "IBLLX", "IBITM", "IBMCU" }),
        new JdeIndex("F4102_12", "Index on IBATPRN", new[] { "IBATPRN" }),
        new JdeIndex("F4102_13", "Index on IBPRGR, IBSRP1, IBSRP2, IBSRP3, IBSRP4, IBSRP5, IBPRP1, IBPRP2, IBPRP3, IBPRP4, IBPRP5, IBSHCN, IBSHCM, IBCYCL, IBPRP6, IBPRP7", new[] { "IBPRGR", "IBSRP1", "IBSRP2", "IBSRP3", "IBSRP4", "IBSRP5", "IBPRP1", "IBPRP2", "IBPRP3", "IBPRP4", "IBPRP5", "IBSHCN", "IBSHCM", "IBCYCL", "IBPRP6", "IBPRP7" }),
        new JdeIndex("F4102_14", "Index on IBSTKT", new[] { "IBSTKT" }),
        new JdeIndex("F4102_2", "Index on IBITM, IBMCU", new[] { "IBITM", "IBMCU" }),
        new JdeIndex("F4102_3", "Index on IBVEND, IBITM", new[] { "IBVEND", "IBITM" }),
        new JdeIndex("F4102_4", "Index on IBPRP5, IBITM", new[] { "IBPRP5", "IBITM" }),
        new JdeIndex("F4102_5", "Index on IBPRP4, IBMCU, IBMPST", new[] { "IBPRP4", "IBMCU", "IBMPST" }),
        new JdeIndex("F4102_6", "Index on IBANPL, IBMCU, IBPRP4, IBMPST", new[] { "IBANPL", "IBMCU", "IBPRP4", "IBMPST" }),
        new JdeIndex("F4102_7", "Index on IBBUYR, IBMCU, IBPRP4, IBMPST", new[] { "IBBUYR", "IBMCU", "IBPRP4", "IBMPST" }),
        new JdeIndex("F4102_8", "Index on IBPRP0, IBITM, IBMCU", new[] { "IBPRP0", "IBITM", "IBMCU" })
    };
}
