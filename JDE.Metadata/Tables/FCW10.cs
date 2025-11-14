using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW10 - .
/// </summary>
public class FCW10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WBITM.
        /// </summary>
        public const string WBITM = "WBITM";

        /// <summary>
        /// WBMCU.
        /// </summary>
        public const string WBMCU = "WBMCU";

        /// <summary>
        /// WBEV01.
        /// </summary>
        public const string WBEV01 = "WBEV01";

        /// <summary>
        /// WBSTKT.
        /// </summary>
        public const string WBSTKT = "WBSTKT";

        /// <summary>
        /// WBGLPT.
        /// </summary>
        public const string WBGLPT = "WBGLPT";

        /// <summary>
        /// WBLNTY.
        /// </summary>
        public const string WBLNTY = "WBLNTY";

        /// <summary>
        /// WBANPL.
        /// </summary>
        public const string WBANPL = "WBANPL";

        /// <summary>
        /// WBBUYR.
        /// </summary>
        public const string WBBUYR = "WBBUYR";

        /// <summary>
        /// WBVEND.
        /// </summary>
        public const string WBVEND = "WBVEND";

        /// <summary>
        /// WBINMG.
        /// </summary>
        public const string WBINMG = "WBINMG";

        /// <summary>
        /// WBCMGL.
        /// </summary>
        public const string WBCMGL = "WBCMGL";

        /// <summary>
        /// WBORIG.
        /// </summary>
        public const string WBORIG = "WBORIG";

        /// <summary>
        /// WBTAX1.
        /// </summary>
        public const string WBTAX1 = "WBTAX1";

        /// <summary>
        /// WBTX.
        /// </summary>
        public const string WBTX = "WBTX";

        /// <summary>
        /// WBSRCE.
        /// </summary>
        public const string WBSRCE = "WBSRCE";

        /// <summary>
        /// WBLOTS.
        /// </summary>
        public const string WBLOTS = "WBLOTS";

        /// <summary>
        /// WBSRNR.
        /// </summary>
        public const string WBSRNR = "WBSRNR";

        /// <summary>
        /// WBCKAV.
        /// </summary>
        public const string WBCKAV = "WBCKAV";

        /// <summary>
        /// WBBACK.
        /// </summary>
        public const string WBBACK = "WBBACK";

        /// <summary>
        /// WBPRGR.
        /// </summary>
        public const string WBPRGR = "WBPRGR";

        /// <summary>
        /// WBRPRC.
        /// </summary>
        public const string WBRPRC = "WBRPRC";

        /// <summary>
        /// WBORPR.
        /// </summary>
        public const string WBORPR = "WBORPR";

        /// <summary>
        /// WBMMPC.
        /// </summary>
        public const string WBMMPC = "WBMMPC";

        /// <summary>
        /// WBSLD.
        /// </summary>
        public const string WBSLD = "WBSLD";

        /// <summary>
        /// WBABCS.
        /// </summary>
        public const string WBABCS = "WBABCS";

        /// <summary>
        /// WBABCM.
        /// </summary>
        public const string WBABCM = "WBABCM";

        /// <summary>
        /// WBABCI.
        /// </summary>
        public const string WBABCI = "WBABCI";

        /// <summary>
        /// WBSRP1.
        /// </summary>
        public const string WBSRP1 = "WBSRP1";

        /// <summary>
        /// WBSRP2.
        /// </summary>
        public const string WBSRP2 = "WBSRP2";

        /// <summary>
        /// WBSRP3.
        /// </summary>
        public const string WBSRP3 = "WBSRP3";

        /// <summary>
        /// WBSRP4.
        /// </summary>
        public const string WBSRP4 = "WBSRP4";

        /// <summary>
        /// WBSRP5.
        /// </summary>
        public const string WBSRP5 = "WBSRP5";

        /// <summary>
        /// WBSRP6.
        /// </summary>
        public const string WBSRP6 = "WBSRP6";

        /// <summary>
        /// WBSRP7.
        /// </summary>
        public const string WBSRP7 = "WBSRP7";

        /// <summary>
        /// WBSRP8.
        /// </summary>
        public const string WBSRP8 = "WBSRP8";

        /// <summary>
        /// WBSRP9.
        /// </summary>
        public const string WBSRP9 = "WBSRP9";

        /// <summary>
        /// WBSRP0.
        /// </summary>
        public const string WBSRP0 = "WBSRP0";

        /// <summary>
        /// WBCARS.
        /// </summary>
        public const string WBCARS = "WBCARS";

        /// <summary>
        /// WBCARP.
        /// </summary>
        public const string WBCARP = "WBCARP";

        /// <summary>
        /// WBSHCN.
        /// </summary>
        public const string WBSHCN = "WBSHCN";

        /// <summary>
        /// WBSHCM.
        /// </summary>
        public const string WBSHCM = "WBSHCM";

        /// <summary>
        /// WBCYCL.
        /// </summary>
        public const string WBCYCL = "WBCYCL";

        /// <summary>
        /// WBPRP1.
        /// </summary>
        public const string WBPRP1 = "WBPRP1";

        /// <summary>
        /// WBPRP2.
        /// </summary>
        public const string WBPRP2 = "WBPRP2";

        /// <summary>
        /// WBPRP3.
        /// </summary>
        public const string WBPRP3 = "WBPRP3";

        /// <summary>
        /// WBPRP4.
        /// </summary>
        public const string WBPRP4 = "WBPRP4";

        /// <summary>
        /// WBPRP5.
        /// </summary>
        public const string WBPRP5 = "WBPRP5";

        /// <summary>
        /// WBPRP6.
        /// </summary>
        public const string WBPRP6 = "WBPRP6";

        /// <summary>
        /// WBPRP7.
        /// </summary>
        public const string WBPRP7 = "WBPRP7";

        /// <summary>
        /// WBPRP8.
        /// </summary>
        public const string WBPRP8 = "WBPRP8";

        /// <summary>
        /// WBPRP9.
        /// </summary>
        public const string WBPRP9 = "WBPRP9";

        /// <summary>
        /// WBPRP0.
        /// </summary>
        public const string WBPRP0 = "WBPRP0";

        /// <summary>
        /// WBOPC.
        /// </summary>
        public const string WBOPC = "WBOPC";

        /// <summary>
        /// WBOPV.
        /// </summary>
        public const string WBOPV = "WBOPV";

        /// <summary>
        /// WBMPST.
        /// </summary>
        public const string WBMPST = "WBMPST";

        /// <summary>
        /// WBMPSP.
        /// </summary>
        public const string WBMPSP = "WBMPSP";

        /// <summary>
        /// WBMTF1.
        /// </summary>
        public const string WBMTF1 = "WBMTF1";

        /// <summary>
        /// WBMTF2.
        /// </summary>
        public const string WBMTF2 = "WBMTF2";

        /// <summary>
        /// WBMTF3.
        /// </summary>
        public const string WBMTF3 = "WBMTF3";

        /// <summary>
        /// WBSETL.
        /// </summary>
        public const string WBSETL = "WBSETL";

        /// <summary>
        /// WBQUED.
        /// </summary>
        public const string WBQUED = "WBQUED";

        /// <summary>
        /// WBECO.
        /// </summary>
        public const string WBECO = "WBECO";

        /// <summary>
        /// WBECTY.
        /// </summary>
        public const string WBECTY = "WBECTY";

        /// <summary>
        /// WBECOD.
        /// </summary>
        public const string WBECOD = "WBECOD";

        /// <summary>
        /// WBPOC.
        /// </summary>
        public const string WBPOC = "WBPOC";

        /// <summary>
        /// WBAVRT.
        /// </summary>
        public const string WBAVRT = "WBAVRT";

        /// <summary>
        /// WBACQ.
        /// </summary>
        public const string WBACQ = "WBACQ";

        /// <summary>
        /// WBITC.
        /// </summary>
        public const string WBITC = "WBITC";

        /// <summary>
        /// WBTIMB.
        /// </summary>
        public const string WBTIMB = "WBTIMB";

        /// <summary>
        /// WBMERL.
        /// </summary>
        public const string WBMERL = "WBMERL";

        /// <summary>
        /// WBSRNK.
        /// </summary>
        public const string WBSRNK = "WBSRNK";

        /// <summary>
        /// WBSRKF.
        /// </summary>
        public const string WBSRKF = "WBSRKF";

        /// <summary>
        /// WBLTLV.
        /// </summary>
        public const string WBLTLV = "WBLTLV";

        /// <summary>
        /// WBLTMF.
        /// </summary>
        public const string WBLTMF = "WBLTMF";

        /// <summary>
        /// WBLTCM.
        /// </summary>
        public const string WBLTCM = "WBLTCM";

        /// <summary>
        /// WBLTPU.
        /// </summary>
        public const string WBLTPU = "WBLTPU";

        /// <summary>
        /// WBMRPP.
        /// </summary>
        public const string WBMRPP = "WBMRPP";

        /// <summary>
        /// WBFRMP.
        /// </summary>
        public const string WBFRMP = "WBFRMP";

        /// <summary>
        /// WBMLQ.
        /// </summary>
        public const string WBMLQ = "WBMLQ";

        /// <summary>
        /// WBOT1Y.
        /// </summary>
        public const string WBOT1Y = "WBOT1Y";

        /// <summary>
        /// WBSTDP.
        /// </summary>
        public const string WBSTDP = "WBSTDP";

        /// <summary>
        /// WBTHRP.
        /// </summary>
        public const string WBTHRP = "WBTHRP";

        /// <summary>
        /// WBOT2Y.
        /// </summary>
        public const string WBOT2Y = "WBOT2Y";

        /// <summary>
        /// WBSTDG.
        /// </summary>
        public const string WBSTDG = "WBSTDG";

        /// <summary>
        /// WBFRGD.
        /// </summary>
        public const string WBFRGD = "WBFRGD";

        /// <summary>
        /// WBTHGD.
        /// </summary>
        public const string WBTHGD = "WBTHGD";

        /// <summary>
        /// WBPRODM.
        /// </summary>
        public const string WBPRODM = "WBPRODM";

        /// <summary>
        /// WBPRODF.
        /// </summary>
        public const string WBPRODF = "WBPRODF";

        /// <summary>
        /// WBMCUZ.
        /// </summary>
        public const string WBMCUZ = "WBMCUZ";

        /// <summary>
        /// WBCCOST.
        /// </summary>
        public const string WBCCOST = "WBCCOST";

        /// <summary>
        /// WBRTRND.
        /// </summary>
        public const string WBRTRND = "WBRTRND";

        /// <summary>
        /// WBRPRBL.
        /// </summary>
        public const string WBRPRBL = "WBRPRBL";

        /// <summary>
        /// WBDCD1.
        /// </summary>
        public const string WBDCD1 = "WBDCD1";

        /// <summary>
        /// WBDCD2.
        /// </summary>
        public const string WBDCD2 = "WBDCD2";

        /// <summary>
        /// WBDCD3.
        /// </summary>
        public const string WBDCD3 = "WBDCD3";

        /// <summary>
        /// WBDCD4.
        /// </summary>
        public const string WBDCD4 = "WBDCD4";

        /// <summary>
        /// WBDCD5.
        /// </summary>
        public const string WBDCD5 = "WBDCD5";

        /// <summary>
        /// WBROQI.
        /// </summary>
        public const string WBROQI = "WBROQI";

        /// <summary>
        /// WBRQMX.
        /// </summary>
        public const string WBRQMX = "WBRQMX";

        /// <summary>
        /// WBRQMN.
        /// </summary>
        public const string WBRQMN = "WBRQMN";

        /// <summary>
        /// WBROPI.
        /// </summary>
        public const string WBROPI = "WBROPI";

        /// <summary>
        /// WBMULT.
        /// </summary>
        public const string WBMULT = "WBMULT";

        /// <summary>
        /// WBUPC.
        /// </summary>
        public const string WBUPC = "WBUPC";

        /// <summary>
        /// WBSAFE.
        /// </summary>
        public const string WBSAFE = "WBSAFE";

        /// <summary>
        /// WBAING.
        /// </summary>
        public const string WBAING = "WBAING";

        /// <summary>
        /// WBBBDD.
        /// </summary>
        public const string WBBBDD = "WBBBDD";

        /// <summary>
        /// WBCMDM.
        /// </summary>
        public const string WBCMDM = "WBCMDM";

        /// <summary>
        /// WBLECM.
        /// </summary>
        public const string WBLECM = "WBLECM";

        /// <summary>
        /// WBLEDD.
        /// </summary>
        public const string WBLEDD = "WBLEDD";

        /// <summary>
        /// WBMLOT.
        /// </summary>
        public const string WBMLOT = "WBMLOT";

        /// <summary>
        /// WBPEFD.
        /// </summary>
        public const string WBPEFD = "WBPEFD";

        /// <summary>
        /// WBSBDD.
        /// </summary>
        public const string WBSBDD = "WBSBDD";

        /// <summary>
        /// WBU1DD.
        /// </summary>
        public const string WBU1DD = "WBU1DD";

        /// <summary>
        /// WBU2DD.
        /// </summary>
        public const string WBU2DD = "WBU2DD";

        /// <summary>
        /// WBU3DD.
        /// </summary>
        public const string WBU3DD = "WBU3DD";

        /// <summary>
        /// WBU4DD.
        /// </summary>
        public const string WBU4DD = "WBU4DD";

        /// <summary>
        /// WBU5DD.
        /// </summary>
        public const string WBU5DD = "WBU5DD";

        /// <summary>
        /// WBXDCK.
        /// </summary>
        public const string WBXDCK = "WBXDCK";

        /// <summary>
        /// WBLAF.
        /// </summary>
        public const string WBLAF = "WBLAF";

        /// <summary>
        /// WBLTFM.
        /// </summary>
        public const string WBLTFM = "WBLTFM";

        /// <summary>
        /// WBRWLA.
        /// </summary>
        public const string WBRWLA = "WBRWLA";

        /// <summary>
        /// WBLNPA.
        /// </summary>
        public const string WBLNPA = "WBLNPA";

        /// <summary>
        /// WBLOTC.
        /// </summary>
        public const string WBLOTC = "WBLOTC";

        /// <summary>
        /// WBAPSC.
        /// </summary>
        public const string WBAPSC = "WBAPSC";

        /// <summary>
        /// WBPRI1.
        /// </summary>
        public const string WBPRI1 = "WBPRI1";

        /// <summary>
        /// WBPRI2.
        /// </summary>
        public const string WBPRI2 = "WBPRI2";

        /// <summary>
        /// WBLTCV.
        /// </summary>
        public const string WBLTCV = "WBLTCV";

        /// <summary>
        /// WBASHL.
        /// </summary>
        public const string WBASHL = "WBASHL";

        /// <summary>
        /// WBCOORE.
        /// </summary>
        public const string WBCOORE = "WBCOORE";

        /// <summary>
        /// WBPNYN.
        /// </summary>
        public const string WBPNYN = "WBPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "FCW10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WBITM", "WBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WBMCU", "WBMCU", JdeDataType.String, 24, true, true),
        new JdeField("WBEV01", "WBEV01", JdeDataType.String, 2, true, true),
        new JdeField("WBSTKT", "WBSTKT", JdeDataType.String, 2),
        new JdeField("WBGLPT", "WBGLPT", JdeDataType.String, 8),
        new JdeField("WBLNTY", "WBLNTY", JdeDataType.String, 4),
        new JdeField("WBANPL", "WBANPL", JdeDataType.Numeric),
        new JdeField("WBBUYR", "WBBUYR", JdeDataType.Numeric),
        new JdeField("WBVEND", "WBVEND", JdeDataType.Numeric),
        new JdeField("WBINMG", "WBINMG", JdeDataType.String, 20),
        new JdeField("WBCMGL", "WBCMGL", JdeDataType.String, 2),
        new JdeField("WBORIG", "WBORIG", JdeDataType.String, 6),
        new JdeField("WBTAX1", "WBTAX1", JdeDataType.String, 2),
        new JdeField("WBTX", "WBTX", JdeDataType.String, 2),
        new JdeField("WBSRCE", "WBSRCE", JdeDataType.String, 2),
        new JdeField("WBLOTS", "WBLOTS", JdeDataType.String, 2),
        new JdeField("WBSRNR", "WBSRNR", JdeDataType.String, 2),
        new JdeField("WBCKAV", "WBCKAV", JdeDataType.String, 2),
        new JdeField("WBBACK", "WBBACK", JdeDataType.String, 2),
        new JdeField("WBPRGR", "WBPRGR", JdeDataType.String, 16),
        new JdeField("WBRPRC", "WBRPRC", JdeDataType.String, 16),
        new JdeField("WBORPR", "WBORPR", JdeDataType.String, 16),
        new JdeField("WBMMPC", "WBMMPC", JdeDataType.Numeric),
        new JdeField("WBSLD", "WBSLD", JdeDataType.Numeric),
        new JdeField("WBABCS", "WBABCS", JdeDataType.String, 2),
        new JdeField("WBABCM", "WBABCM", JdeDataType.String, 2),
        new JdeField("WBABCI", "WBABCI", JdeDataType.String, 2),
        new JdeField("WBSRP1", "WBSRP1", JdeDataType.String, 6),
        new JdeField("WBSRP2", "WBSRP2", JdeDataType.String, 6),
        new JdeField("WBSRP3", "WBSRP3", JdeDataType.String, 6),
        new JdeField("WBSRP4", "WBSRP4", JdeDataType.String, 6),
        new JdeField("WBSRP5", "WBSRP5", JdeDataType.String, 6),
        new JdeField("WBSRP6", "WBSRP6", JdeDataType.String, 12),
        new JdeField("WBSRP7", "WBSRP7", JdeDataType.String, 12),
        new JdeField("WBSRP8", "WBSRP8", JdeDataType.String, 12),
        new JdeField("WBSRP9", "WBSRP9", JdeDataType.String, 12),
        new JdeField("WBSRP0", "WBSRP0", JdeDataType.String, 12),
        new JdeField("WBCARS", "WBCARS", JdeDataType.Numeric),
        new JdeField("WBCARP", "WBCARP", JdeDataType.Numeric),
        new JdeField("WBSHCN", "WBSHCN", JdeDataType.String, 6),
        new JdeField("WBSHCM", "WBSHCM", JdeDataType.String, 6),
        new JdeField("WBCYCL", "WBCYCL", JdeDataType.String, 6),
        new JdeField("WBPRP1", "WBPRP1", JdeDataType.String, 6),
        new JdeField("WBPRP2", "WBPRP2", JdeDataType.String, 6),
        new JdeField("WBPRP3", "WBPRP3", JdeDataType.String, 6),
        new JdeField("WBPRP4", "WBPRP4", JdeDataType.String, 6),
        new JdeField("WBPRP5", "WBPRP5", JdeDataType.String, 6),
        new JdeField("WBPRP6", "WBPRP6", JdeDataType.String, 12),
        new JdeField("WBPRP7", "WBPRP7", JdeDataType.String, 12),
        new JdeField("WBPRP8", "WBPRP8", JdeDataType.String, 12),
        new JdeField("WBPRP9", "WBPRP9", JdeDataType.String, 12),
        new JdeField("WBPRP0", "WBPRP0", JdeDataType.String, 12),
        new JdeField("WBOPC", "WBOPC", JdeDataType.String, 2),
        new JdeField("WBOPV", "WBOPV", JdeDataType.Numeric),
        new JdeField("WBMPST", "WBMPST", JdeDataType.String, 2),
        new JdeField("WBMPSP", "WBMPSP", JdeDataType.String, 2),
        new JdeField("WBMTF1", "WBMTF1", JdeDataType.Numeric),
        new JdeField("WBMTF2", "WBMTF2", JdeDataType.Numeric),
        new JdeField("WBMTF3", "WBMTF3", JdeDataType.Numeric),
        new JdeField("WBSETL", "WBSETL", JdeDataType.Numeric),
        new JdeField("WBQUED", "WBQUED", JdeDataType.Numeric),
        new JdeField("WBECO", "WBECO", JdeDataType.String, 24),
        new JdeField("WBECTY", "WBECTY", JdeDataType.String, 4),
        new JdeField("WBECOD", "WBECOD", JdeDataType.Numeric),
        new JdeField("WBPOC", "WBPOC", JdeDataType.String, 2),
        new JdeField("WBAVRT", "WBAVRT", JdeDataType.Numeric),
        new JdeField("WBACQ", "WBACQ", JdeDataType.Numeric),
        new JdeField("WBITC", "WBITC", JdeDataType.String, 2),
        new JdeField("WBTIMB", "WBTIMB", JdeDataType.String, 2),
        new JdeField("WBMERL", "WBMERL", JdeDataType.String, 6),
        new JdeField("WBSRNK", "WBSRNK", JdeDataType.Numeric),
        new JdeField("WBSRKF", "WBSRKF", JdeDataType.String, 2),
        new JdeField("WBLTLV", "WBLTLV", JdeDataType.Numeric),
        new JdeField("WBLTMF", "WBLTMF", JdeDataType.Numeric),
        new JdeField("WBLTCM", "WBLTCM", JdeDataType.Numeric),
        new JdeField("WBLTPU", "WBLTPU", JdeDataType.Numeric),
        new JdeField("WBMRPP", "WBMRPP", JdeDataType.String, 2),
        new JdeField("WBFRMP", "WBFRMP", JdeDataType.Numeric),
        new JdeField("WBMLQ", "WBMLQ", JdeDataType.Numeric),
        new JdeField("WBOT1Y", "WBOT1Y", JdeDataType.String, 2),
        new JdeField("WBSTDP", "WBSTDP", JdeDataType.Numeric),
        new JdeField("WBTHRP", "WBTHRP", JdeDataType.Numeric),
        new JdeField("WBOT2Y", "WBOT2Y", JdeDataType.String, 2),
        new JdeField("WBSTDG", "WBSTDG", JdeDataType.String, 6),
        new JdeField("WBFRGD", "WBFRGD", JdeDataType.String, 6),
        new JdeField("WBTHGD", "WBTHGD", JdeDataType.String, 6),
        new JdeField("WBPRODM", "WBPRODM", JdeDataType.String, 16),
        new JdeField("WBPRODF", "WBPRODF", JdeDataType.String, 16),
        new JdeField("WBMCUZ", "WBMCUZ", JdeDataType.String, 24),
        new JdeField("WBCCOST", "WBCCOST", JdeDataType.String, 6),
        new JdeField("WBRTRND", "WBRTRND", JdeDataType.String, 2),
        new JdeField("WBRPRBL", "WBRPRBL", JdeDataType.String, 2),
        new JdeField("WBDCD1", "WBDCD1", JdeDataType.String, 6),
        new JdeField("WBDCD2", "WBDCD2", JdeDataType.String, 6),
        new JdeField("WBDCD3", "WBDCD3", JdeDataType.String, 6),
        new JdeField("WBDCD4", "WBDCD4", JdeDataType.String, 6),
        new JdeField("WBDCD5", "WBDCD5", JdeDataType.String, 6),
        new JdeField("WBROQI", "WBROQI", JdeDataType.Numeric),
        new JdeField("WBRQMX", "WBRQMX", JdeDataType.Numeric),
        new JdeField("WBRQMN", "WBRQMN", JdeDataType.Numeric),
        new JdeField("WBROPI", "WBROPI", JdeDataType.Numeric),
        new JdeField("WBMULT", "WBMULT", JdeDataType.Numeric),
        new JdeField("WBUPC", "WBUPC", JdeDataType.Numeric),
        new JdeField("WBSAFE", "WBSAFE", JdeDataType.Numeric),
        new JdeField("WBAING", "WBAING", JdeDataType.String, 2),
        new JdeField("WBBBDD", "WBBBDD", JdeDataType.Numeric),
        new JdeField("WBCMDM", "WBCMDM", JdeDataType.String, 2),
        new JdeField("WBLECM", "WBLECM", JdeDataType.String, 2),
        new JdeField("WBLEDD", "WBLEDD", JdeDataType.Numeric),
        new JdeField("WBMLOT", "WBMLOT", JdeDataType.String, 2),
        new JdeField("WBPEFD", "WBPEFD", JdeDataType.Numeric),
        new JdeField("WBSBDD", "WBSBDD", JdeDataType.Numeric),
        new JdeField("WBU1DD", "WBU1DD", JdeDataType.Numeric),
        new JdeField("WBU2DD", "WBU2DD", JdeDataType.Numeric),
        new JdeField("WBU3DD", "WBU3DD", JdeDataType.Numeric),
        new JdeField("WBU4DD", "WBU4DD", JdeDataType.Numeric),
        new JdeField("WBU5DD", "WBU5DD", JdeDataType.Numeric),
        new JdeField("WBXDCK", "WBXDCK", JdeDataType.String, 2),
        new JdeField("WBLAF", "WBLAF", JdeDataType.String, 2),
        new JdeField("WBLTFM", "WBLTFM", JdeDataType.String, 2),
        new JdeField("WBRWLA", "WBRWLA", JdeDataType.String, 2),
        new JdeField("WBLNPA", "WBLNPA", JdeDataType.String, 2),
        new JdeField("WBLOTC", "WBLOTC", JdeDataType.String, 6),
        new JdeField("WBAPSC", "WBAPSC", JdeDataType.String, 2),
        new JdeField("WBPRI1", "WBPRI1", JdeDataType.Numeric),
        new JdeField("WBPRI2", "WBPRI2", JdeDataType.Numeric),
        new JdeField("WBLTCV", "WBLTCV", JdeDataType.Numeric),
        new JdeField("WBASHL", "WBASHL", JdeDataType.String, 2),
        new JdeField("WBCOORE", "WBCOORE", JdeDataType.String, 2),
        new JdeField("WBPNYN", "WBPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW10_0", "Primary Key on WBITM, WBMCU, WBEV01", new[] { "WBITM", "WBMCU", "WBEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
